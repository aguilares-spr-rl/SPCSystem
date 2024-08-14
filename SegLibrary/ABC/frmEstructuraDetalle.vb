Imports Security_System
Imports Infragistics.Win.UltraWinTree
Imports System.Windows.Forms
Imports Infragistics.Win
Imports System.Drawing
Imports Infragistics.Win.UltraWinGrid

Public Class frmEstructuraDetalle
#Region "Member"
    ' Selección del Tree
    Private oNodoseleccion As UltraTreeNode
    Private oNodoAgregar As UltraTreeNode
    ' Selecciones del Grid 
    Private TipoNodo As String
    Private iModuloSeleccion As Integer
    Private ModuloSeleccion As String
    Private iFuncionSeleccion As Integer
    Private FuncionSeleccion As String
#End Region 'Member
#Region "Properties"
    Public Property EstructuraMenuID As Int16
#End Region 'Properties
#Region "Handlers"
    Private Sub frmEstructuraDetalle_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetFormConfig()
    End Sub
    Private Sub UltraTree1_AfterSelect(sender As Object, e As SelectEventArgs) Handles UltraTree1.AfterSelect
        Dim node As UltraTreeNode = e.NewSelections(0)
        'Determine by checking the key of the selected node
        UltraStatusBar1.Panels("pnlNodoPadre").Text = node.Key + "-" + node.Text
        oNodoseleccion = node
        Select Case oNodoseleccion.Key.Substring(0, 1)
            Case "M"
                UltraToolbarsManager1.Tools.Item("btnAdd").SharedProps.Enabled = True
            Case "F"
                UltraToolbarsManager1.Tools.Item("btnAdd").SharedProps.Enabled = False
        End Select
        If Not oNodoseleccion Is Nothing Then
            UltraToolbarsManager1.Tools.Item("btnEliminar").SharedProps.Enabled = True
        End If

    End Sub
    Private Sub UltraTabControl1_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        TipoNodo = UltraTabControl1.SelectedTab.Key
    End Sub
    Private Sub UltraToolbarsManager1_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Dim iKey As Integer = 0

        If oNodoseleccion Is Nothing Then
            If UltraTree1.Nodes.Count = 0 Then
                TipoNodo = "R"
            End If
        End If

        Select Case e.Tool.Key
            Case "btnAdd"
                UltraTree1.Hide()
                Dim nNew As New UltraTreeNode()
                Select Case TipoNodo
                    Case "R"
                        If iModuloSeleccion = 0 Then
                            MsgBox("No existe selección de modulo para raiz", vbInformation, "Aviso")
                            Exit Sub
                        End If
                        nNew.Key = "M" + iModuloSeleccion.ToString
                        nNew.Text = ModuloSeleccion
                        UltraTree1.Nodes.Add(nNew)
                        AddNodo(nNew)
                        TipoNodo = "M"
                    Case "M"
                        If oNodoseleccion Is Nothing Then
                            MsgBox("No existe padre seleccionado", vbInformation, "Aviso")
                            Exit Sub
                        End If
                        nNew.Key = "M" + iModuloSeleccion.ToString
                        nNew.Text = ModuloSeleccion
                        oNodoseleccion.Nodes.Add(nNew)
                        AddNodo(nNew)
                    Case "F"
                        If oNodoseleccion Is Nothing Then
                            MsgBox("No existe padre seleccionado", vbInformation, "Aviso")
                            Exit Sub
                        End If
                        nNew.Key = "F" + iFuncionSeleccion.ToString
                        nNew.Text = FuncionSeleccion
                        oNodoseleccion.Nodes.Add(nNew)
                        AddNodo(nNew)
                    Case Else
                End Select
                UltraTree1.Show()
            Case "btnEliminar"
                RemoveNodo(oNodoseleccion)
            Case "btnActualizar"
                SetFormConfig()
            Case Else
        End Select

    End Sub
    Private Sub GridModulos_AfterSelectChange(sender As Object, e As AfterSelectChangeEventArgs) Handles GridModulos.AfterSelectChange
        If sender.Selected.rows.count = 0 Then Exit Sub
        Dim Row As UltraGridRow = sender.Selected.Rows(0)
        iModuloSeleccion = Row.Cells("ModuloID").Value
        ModuloSeleccion = Row.Cells("ModuloNombre").Value
        PermiteAgregar()
    End Sub
    Private Sub GridFunciones_AfterSelectChange(sender As Object, e As AfterSelectChangeEventArgs) Handles GridFunciones.AfterSelectChange
        If sender.Selected.rows.count = 0 Then Exit Sub
        Dim Row As UltraGridRow = sender.Selected.Rows(0)
        iFuncionSeleccion = Row.Cells("SGFuncionID").Value
        FuncionSeleccion = Row.Cells("SGFuncionNombre").Value
        PermiteAgregar()
    End Sub
#End Region 'Handlersd
#Region "Methods"
#Region "Ini"
    Private Sub SetFormConfig()
        Try

            UltraToolbarsManager1.Tools.Item("btnAdd").SharedProps.Enabled = False
            UltraToolbarsManager1.Tools.Item("btnEliminar").SharedProps.Enabled = False

            LoadGridModulos()

            'Impide la edición
            GridModulos.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False

            GridModulos.DisplayLayout.Bands(0).Columns.Item("ModuloID").Header.Caption = "ModuloID"
            GridModulos.DisplayLayout.Bands(0).Columns.Item("ModuloNombre").Header.Caption = "Modulo"

            For Each Col As UltraGridColumn In GridModulos.DisplayLayout.Bands(0).Columns
                Select Case Col.Key
                    Case "ModuloNombre"

                    Case Else
                        Col.Hidden = True

                End Select
            Next

            LoadGridFunciones()

            'Impide la edición
            GridFunciones.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False

            ', 
            GridFunciones.DisplayLayout.Bands(0).Columns.Item("SGFuncionID").Header.Caption = "SGFuncionID"
            GridFunciones.DisplayLayout.Bands(0).Columns.Item("SGFuncionNombre").Header.Caption = "SGFuncionNombre"

            For Each Col As UltraGridColumn In GridFunciones.DisplayLayout.Bands(0).Columns
                Select Case Col.Key
                    Case "SGFuncionNombre"

                    Case Else
                        Col.Hidden = True

                End Select
            Next

            LoadTree()

        Catch ex As Exception

        End Try
    End Sub
#End Region 'Ini
#Region "General"
    Private Sub PermiteAgregar()
        Try
            If TipoNodo <> "" Then
                UltraToolbarsManager1.Tools.Item("btnAdd").SharedProps.Enabled = True
            End If
        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
#End Region 'General
#Region "Grids"
    Private Sub LoadGridModulos()
        Dim oSql As New SQLSeg(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            oCs.Create("@ModuloActivo", True)
            oCs.Create("@EstructuraMenuID", EstructuraMenuID)
            Dim oTb As DataTable = oSql._Lista(oSql.ListModulos, "Modulos", oCs)
            If Not oTb Is Nothing Then
                With GridModulos
                    .DataSource = oTb
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
    Private Sub LoadGridFunciones()
        Dim oSql As New SQLFuncion(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            oCs.Create("@EstructuraMenuID", EstructuraMenuID)
            Dim oTb As DataTable = oSql._Lista(oSql.ListxAsignar, "Funciones", oCs)
            If Not oTb Is Nothing Then
                With GridFunciones
                    .DataSource = oTb
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
#End Region 'Grids
#Region "Tree"
    Private Sub LoadTree()
        Dim oSql As New SQLSeg(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            Me.UltraTree1.Nodes.Clear()
            oCs.Create("@EstructuraMenuID", EstructuraMenuID)
            Dim oTb As DataTable = oSql._Lista(oSql.ListEstructuraDetalle, "EstructuraModulos", oCs)
            If Not oTb Is Nothing Then
                For Each Dr As DataRow In oTb.Rows
                    If Dr("ModuloPadreID").ToString = Dr("ModuloID").ToString Then 'Es un modulo Raiz
                        Dim oNodoRaiz As UltraTreeNode = Me.UltraTree1.Nodes.Add("M" & Dr("ModuloID").ToString, Dr("ModuloNombre").ToString)
                        oNodoRaiz.Tag = Dr("EstructuraMenuDetalleID").ToString
                    Else
                        'Dim oNodoPadre As UltraTreeNode = Me.UltraTree1.Nodes.Item("M" & Dr("ModuloPadreID").ToString)
                        Dim oNodoPadre As UltraTreeNode = Me.UltraTree1.GetNodeByKey("M" & Dr("ModuloPadreID").ToString)
                        Dim oNodoHijo = oNodoPadre.Nodes.Add("M" & Dr("ModuloID").ToString, Dr("ModuloNombre").ToString)
                        oNodoHijo.Tag = Dr("EstructuraMenuDetalleID").ToString
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
                Next
            End If
        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
    Private Sub RemoveNodo(ByRef oNodo As UltraTreeNode)
        Try
            'Para Eliminar un nodo, se debe recorrer los hijos del mismo y si no tiene mas hijos se va eliminando hasta terminar con el nodo en cuestión.
            If oNodo.HasNodes Then
                For Each oNhijo As UltraTreeNode In oNodo.Nodes
                    RemoveNodo(oNhijo)
                Next
            Else
                If oNodo.Key.Substring(0, 1) = "M" Then
                    DeleteModuloEstructura(oNodo.Tag)
                    oNodo.Visible = False
                Else
                    DeleteFuncionModulo(oNodo.Tag)
                    oNodo.Visible = False
                End If
            End If

        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub

#End Region 'Tree
#Region "Data"
    Private Function DeleteFuncionModulo(ByVal iKey As Integer) As Boolean
        Dim oSql As New SQLFuncionesModulo(oUsr)
        Dim oCs As New ColeccionPrmSql
        DeleteFuncionModulo = False
        Try
            oCs.Create("@SGFuncionModuloID", iKey)
            Return oSql.ExecuteQry(oSql.Delete, oCs)
        Catch ex As Exception

        End Try
    End Function
    Private Function DeleteModuloEstructura(ByVal iKey As Integer) As Boolean
        Dim oSql As New SQLEstructuraDetalle(oUsr)
        Dim oCs As New ColeccionPrmSql
        DeleteModuloEstructura = False
        Try
            oCs.Create("@EstructuraMenuDetalleID", iKey)
            Return oSql.ExecuteQry(oSql.Delete, oCs)
        Catch ex As Exception

        End Try
    End Function
    Private Function InsertFuncionModulo(ByVal ModuloID As Integer, ByVal SGFuncionID As Integer, ByRef ID As Integer) As Boolean
        Dim oSql As New SQLFuncionesModulo(oUsr)
        Dim oCs As New ColeccionPrmSql
        InsertFuncionModulo = False
        Try
            oCs.Create("@EstructuraMenuID", EstructuraMenuID)
            oCs.Create("@ModuloID", ModuloID)
            oCs.Create("@SGFuncionID", SGFuncionID)
            oCs.Create("@SGFuncionModuloID", ID, "out")
            If oSql.ExecuteStore("Ins_FuncionModulo", oCs) Then
                ID = oCs.ItemValue("@SGFuncionModuloID")
                Return True
            End If
        Catch ex As Exception

        End Try
    End Function
    Private Function InsertModuloEstructura(ByVal ModuloID As Integer, ByVal ModuloPadreID As Integer, ByRef ID As Integer) As Boolean
        Dim oSql As New SQLEstructuraDetalle(oUsr)
        Dim oCs As New ColeccionPrmSql
        InsertModuloEstructura = False
        Try
            oCs.Create("@EstructuraMenuID", EstructuraMenuID)
            oCs.Create("@ModuloID", ModuloID)
            oCs.Create("@ModuloPadreID", ModuloPadreID)
            oCs.Create("@EstructuraMenuDetalleID", ID, "out")
            If oSql.ExecuteStore("Ins_EstructuraDetalle", oCs) Then
                ID = oCs.ItemValue("@EstructuraMenuDetalleID")
                Return True
            End If
        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Function

#End Region 'Data

#Region "Operations in Tree"
    Private Function AddNodo(ByVal oNode As UltraTreeNode) As Boolean
        Dim id As Integer = 0
        Dim iParent As Integer = 0
        AddNodo = False
        Try
            Select Case oNode.Key.Substring(0, 1)
                Case "M"
                    If oNode.Parent Is Nothing Then
                        iParent = oNode.Key.Replace("M", "")
                    Else
                        iParent = oNode.Parent.Key.Replace("M", "")
                    End If
                    If InsertModuloEstructura(oNode.Key.Replace("M", ""), iParent, id) Then
                        oNode.Tag = id.ToString
                    End If
                Case "F"
                    If InsertFuncionModulo(oNode.Parent.Key.Replace("M", ""), oNode.Key.Replace("F", ""), id) Then
                        oNode.Tag = id.ToString
                    End If
                Case Else
            End Select
            Return True
        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Function

#End Region 'Operations in Tree

#End Region 'Methods

End Class