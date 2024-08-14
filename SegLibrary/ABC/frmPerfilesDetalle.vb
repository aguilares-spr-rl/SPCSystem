Imports Security_System
Imports Infragistics.Win.UltraWinTree
Imports System.Windows.Forms
Imports Infragistics.Win
Imports System.Drawing
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinToolbars

Public Class frmPerfilesDetalle
#Region "Member"
    ' Selección del Tree
    Private oNodoseleccion As UltraTreeNode
    ' Selecciones del Grid 
#End Region 'Member
#Region "Properties"
    Public Property EstructuraMenuID As Int16
    Public Property PerfilID As Int16
#End Region 'Properties
#Region "Hendlers"
    Private Sub frmPerfilesDetalle_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetFormConfig()
    End Sub
    Private Sub UltraToolbarsManager1_ToolClick(sender As Object, e As ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key
            Case "btnGuardar"    ' ButtonTool
                ' Place code here
                SaveTreePerfil(UltraTree1.Nodes.Item(0))
                MsgBox("Fin del proceso", vbInformation, "Guardado")
        End Select
    End Sub

#End Region 'Hendlers
#Region "Methods"
#Region "Ini"
    Public Sub ProcesaOpcion(ByVal eve As EVENTOS)
        Try
            Select Case eve
                Case EVENTOS.EV_CONSULTAR
                    SetFormConfig()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    Private Sub SetFormConfig()
        Try
            LoadTree()
        Catch ex As Exception

        End Try
    End Sub
#End Region 'Ini
#Region "Tree"
    Private Sub LoadTree()
        Dim oSql As New SQLSeg(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            Me.UltraTree1.Nodes.Clear()
            Me.UltraTree1.ImageList = Me.ImageList1
            oCs.Create("@EstructuraMenuID", EstructuraMenuID)
            Dim oTb As DataTable = oSql._Lista(oSql.ListEstructuraDetalle, "EstructuraModulos", oCs)
            If Not oTb Is Nothing Then
                For Each Dr As DataRow In oTb.Rows
                    If Dr("ModuloPadreID").ToString = Dr("ModuloID").ToString Then 'Es un modulo Raiz
                        Dim oNodoRaiz As UltraTreeNode = Me.UltraTree1.Nodes.Add("M" & Dr("ModuloID").ToString, Dr("ModuloNombre").ToString)
                        oNodoRaiz.Tag = Dr("EstructuraMenuDetalleID").ToString
                        oNodoRaiz.LeftImages.Add(1)
                    Else
                        'Dim oNodoPadre As UltraTreeNode = Me.UltraTree1.Nodes.Item("M" & Dr("ModuloPadreID").ToString)
                        Dim oNodoPadre As UltraTreeNode = Me.UltraTree1.GetNodeByKey("M" & Dr("ModuloPadreID").ToString)
                        Dim oNodoHijo = oNodoPadre.Nodes.Add("M" & Dr("ModuloID").ToString, Dr("ModuloNombre").ToString)
                        oNodoHijo.Tag = Dr("EstructuraMenuDetalleID").ToString
                        oNodoHijo.LeftImages.Add(0)
                        If oNodoHijo.Key.Substring(0, 1) = "M" Then
                            LoadFunciones(oNodoHijo)
                        End If
                    End If
                Next
            End If

            UltraTree1.ExpandAll()
            UltraTree1.Show()

        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
    Private Sub LoadFunciones(ByVal oNodo As UltraTreeNode)
        Dim oSql As New SQLFuncionesModulo(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            oCs.Create("@EstructuraMenuID", EstructuraMenuID)
            oCs.Create("@ModuloID", oNodo.Key.Replace("M", ""))
            Dim oTb As DataTable = oSql._Lista(oSql.List, "FuncionesModulos", oCs)
            If Not oTb Is Nothing Then
                For Each Dr As DataRow In oTb.Rows
                    Dim oNodoHijo As UltraTreeNode = oNodo.Nodes.Add("F" & Dr("SGFuncionID").ToString, Dr("SGFuncionNombre").ToString)
                    oNodoHijo.Tag = Dr("SGFuncionModuloID").ToString
                    oNodoHijo.LeftImages.Add(2)
                    LoadEventos(oNodoHijo)
                Next
            End If
        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
    Private Sub LoadEventos(ByVal oNodo As UltraTreeNode)
        Dim oSql As New SQLFuncion(oUsr)
        Dim oCs As New ColeccionPrmSql
        Dim oPermisos As List(Of PermisoEvento)
        Try
            oCs.Create("@SGFuncionID", oNodo.Key.Replace("F", ""))
            Dim oTb As DataTable = oSql._Lista(oSql.Item, "Funcion", oCs)
            If Not oTb Is Nothing Then
                For Each Dr As DataRow In oTb.Rows

                    oPermisos = Permisos(PerfilID, oNodo.Parent.Key.Replace("M", ""), oCs.ItemValue("@SGFuncionID"))

                    For Each Col As DataColumn In oTb.Columns
                        Select Case Col.ColumnName
                            Case "SGFuncionConsultar", "SGFuncionNuevo", "SGFuncionEliminar", "SGFuncionRecuperar", "SGFuncionModificar",
                                 "SGFuncionListar", "SGFuncionExportar", "SGFuncionGraficar"

                                If Dr(Col.ColumnName) = True Then
                                    Dim oNodoHijo As UltraTreeNode = oNodo.Nodes.Add("E" & Dr("SGFuncionID").ToString + "-" + Col.ColumnName, Col.ColumnName.Replace("SGFuncion", ""))
                                    If oPermisos.Count > 0 Then
                                        oNodoHijo.CheckedState = IIf(oPermisos.Find(Function(x) x.Evento = oNodoHijo.Text).Permiso, CheckState.Checked, CheckState.Unchecked)
                                    End If
                                End If

                            Case Else

                        End Select
                    Next
                Next
            End If

        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
    Private Function Permisos(ByVal PerfilID As Integer, ByVal ModuloID As Integer, ByVal FuncionID As Integer) As List(Of PermisoEvento)
        Dim oSql As New SQLDetallesPerfil(oUsr)
        Dim oCs As New ColeccionPrmSql
        Dim oList As New List(Of PermisoEvento)
        Permisos = Nothing
        Try
            oCs.Create("@PerfilID", PerfilID)
            oCs.Create("@ModuloID", ModuloID)
            oCs.Create("@SGFuncionID", FuncionID)
            Dim oTb As DataTable = oSql._Item(oSql.Item, "Permisos", oCs)
            If Not oTb Is Nothing Then
                For Each Dr As DataRow In oTb.Rows
                    For Each oCol As DataColumn In oTb.Columns
                        Select Case oCol.ColumnName
                            Case "PerfilConsultar", "PerfilNuevo", "PerfilEliminar", "PerfilRecuperar", "PerfilModificar", "PerfilListar", "PerfilExportar", "PerfilGraficar"
                                oList.Add(New PermisoEvento(oCol.ColumnName.Replace("Perfil", ""), Dr(oCol.ColumnName)))
                            Case Else
                        End Select
                    Next
                    Exit For
                Next
            End If
            Return oList
        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Function


    Private Sub SaveTreePerfil(ByVal oNodo As UltraTreeNode)
        Dim oSql As New SQLDetallesPerfil(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            oCs.Create("@PerfilID", PerfilID)
            oCs.Create("@ModuloID", 0)
            oCs.Create("@SGFuncionID", 0)
            oCs.Create("@PerfilConsultar", False)
            oCs.Create("@PerfilNuevo", False)
            oCs.Create("@PerfilEliminar", False)
            oCs.Create("@PerfilRecuperar", False)
            oCs.Create("@PerfilModificar", False)
            oCs.Create("@PerfilListar", False)
            oCs.Create("@PerfilExportar", False)
            oCs.Create("@PerfilGraficar", False)
            oCs.Create("@CreaUserID", oUsr.UserID)
            oCs.Create("@PerfilDetalleID", 0)

            For Each oNodoChild As UltraTreeNode In oNodo.Nodes
                If oNodoChild.Key.Substring(0, 1) = "F" Then
                    If oNodoChild.CheckedState = CheckState.Checked Or oNodoChild.CheckedState = CheckState.Indeterminate Or oNodoChild.CheckedState = CheckState.Unchecked Then
                        oCs.ItemValue("@ModuloID") = oNodoChild.Parent.Key.Replace("M", "")
                        oCs.ItemValue("@SGFuncionID") = oNodoChild.Key.Replace("F", "")
                        For Each oNe As UltraTreeNode In oNodoChild.Nodes
                            Select Case oNe.Text
                                Case "Consultar"
                                    oCs.ItemValue("@PerfilConsultar") = (oNe.CheckedState = CheckState.Checked)
                                Case "Nuevo"
                                    oCs.ItemValue("@PerfilNuevo") = (oNe.CheckedState = CheckState.Checked)
                                Case "Eliminar"
                                    oCs.ItemValue("@PerfilEliminar") = (oNe.CheckedState = CheckState.Checked)
                                Case "Recuperar"
                                    oCs.ItemValue("@PerfilRecuperar") = (oNe.CheckedState = CheckState.Checked)
                                Case "Modificar"
                                    oCs.ItemValue("@PerfilModificar") = (oNe.CheckedState = CheckState.Checked)
                                Case "Listar"
                                    oCs.ItemValue("@PerfilListar") = (oNe.CheckedState = CheckState.Checked)
                                Case "Exportar"
                                    oCs.ItemValue("@PerfilExportar") = (oNe.CheckedState = CheckState.Checked)
                                Case "Graficar"
                                    oCs.ItemValue("@PerfilGraficar") = (oNe.CheckedState = CheckState.Checked)
                                Case Else
                            End Select
                        Next
                        Dim Identifica As Integer = ExisteIdentificador(PerfilID, oCs.ItemValue("@ModuloID"), oCs.ItemValue("@SGFuncionID"))
                        If Identifica > 0 Then
                            oCs.ItemValue("@PerfilDetalleID") = Identifica
                            oSql.ExecuteQry(oSql.Update, oCs)
                        Else
                            oSql.ExecuteQry(oSql.Insert, oCs)
                        End If
                    End If
                Else
                    If oNodoChild.HasNodes Then
                        SaveTreePerfil(oNodoChild)
                    End If
                End If
            Next
        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
    Private Function ExisteIdentificador(ByVal PerfilID As Integer, ByVal ModuloID As Integer, ByVal FuncionID As Integer) As Integer
        Dim oSql As New SQLDetallesPerfil(oUsr)
        Dim oCs As New ColeccionPrmSql
        ExisteIdentificador = 0
        Try
            oCs.Create("@PerfilID", PerfilID)
            oCs.Create("@ModuloID", ModuloID)
            oCs.Create("@SGFuncionID", FuncionID)
            Return Val(oSql._Valor(oSql.Existe, "Identificador", oCs).ToString)
        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Function
#End Region 'Tree
#End Region 'Methods

    Private Class PermisoEvento
        Public Property Evento As String
        Public Property Permiso As Boolean
        Public Sub New(ByVal pEvent As String, pPermis As Boolean)
            Evento = pEvent
            Permiso = pPermis
        End Sub
    End Class

End Class