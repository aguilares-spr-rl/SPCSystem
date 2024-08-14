Imports System.Data.SqlClient
Imports Security_System
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frmUsuarios
#Region "Formulario Comun"
#Region "Propiedades"
    Public objAdm As New objSeg
    Public ReadOnly Property FunctionID As String
    Public ReadOnly Property Grid As UltraGrid
        Get
            Return SGUSUARIOSUltraGrid
        End Get
    End Property
#End Region 'Propiedades
#Region "Constructor"
    Public Sub New(ByVal pfunctionID As String, ByVal frmParent As Form, ByVal Optional pUsr As MySession = Nothing)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim Cn As SqlConnection = New SqlConnection(pUsr.App.DataStore.StringCnx)
        If Cn.State = ConnectionState.Closed Then
            Cn.Open()
        End If
        SGUSUARIOSTableAdapter.Connection = Cn
        SGUSRPERFILTableAdapter.Connection = Cn
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FunctionID = pfunctionID
        Me.MdiParent = frmParent
        IniListas()
    End Sub
#End Region 'Constructor
#Region "Metodos de Configuración"
    Private Sub IniListas()
        Me.Text = "Perfiles"
        SGUSUARIOSUltraGrid.Text = "Información de Usuarios"
        IniListaPerfiles()

        Dim oCs As New ColeccionPrmSql
        oCs.Create("@SgActivo", 1)
        Dim oSql As New SgUsuarios(oUsr)
        Dim oTb As DataTable = oSql._Lista(oSql.List, "Usuarios", oCs)
        objAdm.AddItemValueList(Grid, "Usr", oTb, "SgUserID", "SgUserName", 1, "SgUserID")

    End Sub
#End Region 'Metodos de Configuración
#End Region 'Formulario Comun
#Region "Eventos"
    Private Sub SGUSUARIOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SGUSUARIOSBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            'Validaciones de formulario
            If SGUSUARIOSBindingSource.Current("SgUserName").ToString() = String.Empty Then
                MsgBox("UserName es un dato requerido")
                Exit Sub
            End If
            If SGUSUARIOSBindingSource.Current("SgUserEmail").ToString() = String.Empty Then
                MsgBox("Email es un dato requerido")
                Exit Sub
            End If
            If SGUSUARIOSBindingSource.Current("SgNombre").ToString() = String.Empty Then
                MsgBox("Nombre es dato requerido")
                Exit Sub
            End If
            If SGUSUARIOSBindingSource.Current("SgApellidos") = String.Empty Then
                MsgBox("Apellidos es un dato requerido")
                Exit Sub
            End If
            If SGUSUARIOSBindingSource.Current("SgUserAlta") Is Nothing Then
                MsgBox("Fecha de alta es un dato requerido")
                Exit Sub
            End If

            Me.SGUSUARIOSBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SegDS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en aplicación")
        End Try
    End Sub
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGUSRPERFIL' Puede moverla o quitarla según sea necesario.
        Me.SGUSRPERFILTableAdapter.Fill(Me.SegDS.SGUSRPERFIL)
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGUSUARIOS' Puede moverla o quitarla según sea necesario.
        Me.SGUSUARIOSTableAdapter.Fill(Me.SegDS.SGUSUARIOS)
        SetFormConfig()
    End Sub
    Private Sub SGUSUARIOSUltraGrid_AfterRowInsert(sender As Object, e As RowEventArgs) Handles SGUSUARIOSUltraGrid.AfterRowInsert
        'Valores predeterminados al insertar un registro en Grid
        Select Case e.Row.Band.Index
            Case 0
                e.Row.Cells("SgUserAlta").Value = Now
                e.Row.Cells("CreaUserID").Value = oUsr.UserID
                e.Row.Cells("CreaDate").Value = Now()
                e.Row.Cells("SgUserPasswd").Value = String.Empty
                e.Row.Cells("SgApellidos").Value = String.Empty
                e.Row.Cells("SgActivo").Value = True
            Case 1
                e.Row.Cells("CreaUserID").Value = oUsr.UserID
                e.Row.Cells("CreaDate").Value = Now()
        End Select

    End Sub
    Private Sub SGUSUARIOSUltraGrid_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles SGUSUARIOSUltraGrid.AfterRowUpdate
        e.Row.Cells("ModifiUserID").Value = oUsr.UserID
        e.Row.Cells("ModifiDate").Value = Now()
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key
            Case "Editar"    ' ButtonTool
                ActionUser("Upd")
        End Select
    End Sub
    Private Sub SGUSUARIOSUltraGrid_DoubleClick(sender As Object, e As EventArgs) Handles SGUSUARIOSUltraGrid.DoubleClick
        ActionUser("Upd")
    End Sub

#End Region 'Eventos
#Region "Metodos"
    Public Sub ProcesaOpcion(ByVal eve As EVENTOS)
        Try
            Select Case eve
                Case EVENTOS.EV_CONSULTAR
                    Me.SGUSRPERFILTableAdapter.Fill(Me.SegDS.SGUSRPERFIL)
                    'TODO: esta línea de código carga datos en la tabla 'SegDS.SGUSUARIOS' Puede moverla o quitarla según sea necesario.
                    Me.SGUSUARIOSTableAdapter.Fill(Me.SegDS.SGUSUARIOS)
                    SetFormConfig()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    Private Sub SetFormConfig()
        Try
            'GridModulos.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
            Grid.DisplayLayout.Bands(0).Columns.Item("SgUserName").Header.Caption = "UserName"
            Grid.DisplayLayout.Bands(0).Columns.Item("SgUserEmail").Header.Caption = "UserEmail"
            Grid.DisplayLayout.Bands(0).Columns.Item("SgNombre").Header.Caption = "Nombre"
            Grid.DisplayLayout.Bands(0).Columns.Item("SgApellidos").Header.Caption = "Apellidos"
            Grid.DisplayLayout.Bands(0).Columns.Item("SgUserAlta").Header.Caption = "Alta"
            Grid.DisplayLayout.Bands(0).Columns.Item("SgActivo").Header.Caption = "Activo"

            For Each Col As UltraGridColumn In Grid.DisplayLayout.Bands(0).Columns
                Select Case Col.Key
                    Case "CreaUserID", "CreaDate", "ModifiUserID", "ModifiDate", "ErpHost", "ErpUser", "ErpPasswd"
                        Col.Hidden = True
                    Case Else

                End Select
            Next
            For Each Col As UltraGridColumn In Grid.DisplayLayout.Bands(1).Columns
                Select Case Col.Key
                    Case "CreaUserID", "CreaDate", "ModifiUserID", "ModifiDate"
                        Col.Hidden = True
                    Case Else

                End Select
            Next

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
    Private Sub ActionUser(ByVal acc As String)
        Dim oFrm As New dlgUsuario
        Try

            If Grid.Selected.Rows.Count > 0 Then
                For Each Gr As UltraGridRow In Grid.Selected.Rows
                    With oFrm
                        .RegUsuario = New Usuario(acc, Gr.Cells("SgUserID").Value, Gr.Cells("SgUserName").Value, Gr.Cells("SgUserEmail").Value, Gr.Cells("SgUserAlta").Value, Gr.Cells("SgUserPasswd").Value, Gr.Cells("SgNombre").Value, Gr.Cells("SgApellidos").Value, Gr.Cells("ErpHost").Value.ToString, Gr.Cells("ErpUser").Value.ToString, Gr.Cells("ErpPasswd").Value.ToString)
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            Me.SGUSUARIOSTableAdapter.Fill(Me.SegDS.SGUSUARIOS)
                        End If
                    End With
                    Exit For
                Next
            End If
        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub


    Private Sub IniListaPerfiles()
        Dim oSql As New SQLPerfil(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            If SGUSUARIOSUltraGrid.DisplayLayout.ValueLists.Exists("Per") Then
                Exit Sub
            End If
            Dim oTb As DataTable = oSql._Lista(oSql.List, "PERFILES", oCs)
            If Not oTb Is Nothing Then
                Dim valueList As ValueList = Me.SGUSUARIOSUltraGrid.DisplayLayout.ValueLists.Add("Per")
                For Each Dr As DataRow In oTb.Rows
                    valueList.ValueListItems.Add(Dr("PerfilID"), Dr("PerfilNombre").ToString)
                Next
                Dim column As UltraGridColumn = SGUSUARIOSUltraGrid.DisplayLayout.Bands(1).Columns("PerfilID")
                column.ValueList = valueList
                column.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate
            End If

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub

#End Region 'Metodos
End Class