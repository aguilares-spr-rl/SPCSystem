Imports System.Data.SqlClient
Imports Security_System
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frmPerfiles
#Region "Formulario Comun"
#Region "Propiedades"
    Public ReadOnly Property FunctionID As String
    Public ReadOnly Property Grid As UltraGrid
        Get
            Return SGPERFILESUltraGrid
        End Get
    End Property
    Private oGridAdmin As New GridAdminClass
    Private ArListas As New List(Of DataTable)
    Public Property MyRowSelected As UltraGridRow

#End Region 'Propiedades
#Region "Constructor"
    Public Sub New(ByVal pfunctionID As String, ByVal frmParent As Form, ByVal Optional pUsr As MySession = Nothing)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim Cn As SqlConnection = New SqlConnection(pUsr.App.DataStore.StringCnx)
        If Cn.State = ConnectionState.Closed Then
            Cn.Open()
        End If
        SGPERFILESTableAdapter.Connection = Cn
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FunctionID = pfunctionID
        Me.MdiParent = frmParent
    End Sub
#End Region 'Constructor
#End Region 'Formulario Comun
#Region "Handlers"
    Private Sub SGPERFILESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SGPERFILESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SGPERFILESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SegDS)
    End Sub
    Private Sub frmPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGPERFILES' Puede moverla o quitarla según sea necesario.
        Select Case oUsr.App.Estructura
            Case 0
                Me.SGPERFILESTableAdapter.Fill(Me.SegDS.SGPERFILES)
            Case Else
                'Me.SGPERFILESTableAdapter.FillBy(Me.SegDS.SGPERFILES, oUsr.App.Estructura)
        End Select
        SetFormConfig()
    End Sub
    'Grid
    Private Sub SGPERFILESUltraGrid_AfterSelectChange(sender As Object, e As AfterSelectChangeEventArgs) Handles SGPERFILESUltraGrid.AfterSelectChange
        If Grid.Selected.Rows.Count > 0 Then
            Dim rowSelected As UltraGridRow
            For Each rowSelected In Grid.Selected.Rows
                MyRowSelected = rowSelected
                Exit For
            Next
        End If
    End Sub
    'Private Sub SGPERFILESUltraGrid_AfterRowInsert(sender As Object, e As RowEventArgs) Handles SGPERFILESUltraGrid.AfterRowInsert
    '    Select Case e.Row.Band.Index
    '        Case 0
    '            e.Row.Cells("CreaUserID").Value = oUsr.UserID
    '            e.Row.Cells("CreaDate").Value = Now()
    '        Case Else
    '    End Select
    'End Sub

    'Barra de herramientas
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim oFrm As New frmPerfilesDetalle
        Try
            If MyRowSelected Is Nothing Then
                MsgBox("No existe Perfil seleccionado", vbInformation, "AVISO")
                Exit Sub
            End If
            With oFrm
                If IsNumeric(MyRowSelected.Cells("PerfilID").Value) Then
                    .EstructuraMenuID = MyRowSelected.Cells("EstructuraMenuID").Value
                    .PerfilID = MyRowSelected.Cells("PerfilID").Value
                    .Text = MyRowSelected.Cells("PerfilNombre").Value
                    .ShowDialog()
                End If
            End With
        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
#End Region
#Region "Methods"
    Public Sub ProcesaOpcion(ByVal eve As EVENTOS)
        Try
            Select Case eve
                Case EVENTOS.EV_CONSULTAR
                    Me.SGPERFILESTableAdapter.Fill(Me.SegDS.SGPERFILES)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    Private Sub AddListas()
        Dim oSql As New SegListas(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            'Motivos
            oCs.Create("@EstructuraMenuID", IIf(oUsr.App.Estructura = 0, "%", oUsr.App.Estructura.ToString))
            Dim oTb As DataTable = oSql._Lista(oSql.Estructuras, "Estructuras", oCs)
            If Not oTb Is Nothing Then ArListas.Add(oTb)

            oTb = oSql._Lista(oSql.Plataforma, "Plataformas", oCs)
            If Not oTb Is Nothing Then ArListas.Add(oTb)

        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
    Private Sub SetFormConfig()
        Try
            AddListas()

            oGridAdmin.AddBanda(0, "PERFILES", "PERFIL", False)

            oGridAdmin.AddCol(0, "PerfilID", "PerfilID", Activation.Disabled, False)
            oGridAdmin.AddCol(0, "PerfilNombre", "PerfilNombre", Activation.AllowEdit, False)
            oGridAdmin.AddCol(0, "EstructuraMenuID", "Estructura", Activation.AllowEdit, , 300, ArListas.Find(Function(x) x.TableName = "Estructuras"))
            oGridAdmin.AddCol(0, "PlataformaID", "Plataforma", Activation.AllowEdit, , 300, ArListas.Find(Function(x) x.TableName = "Plataformas"))
            oGridAdmin.AddCol(0, "Activo", "Activo", Activation.AllowEdit,,,, 1)

            oGridAdmin.AddCol(0, "CreaUserID", "CreaUserID", Activation.Disabled, True,,, oUsr.UserID)
            oGridAdmin.AddCol(0, "CreaDate", "CreaDate", Activation.Disabled, True,,, Now)
            oGridAdmin.AddCol(0, "ModifiUserID", "ModifiUserID", Activation.Disabled, True)
            oGridAdmin.AddCol(0, "ModifiDate", "ModifiDate", Activation.Disabled, True)

            oGridAdmin.SetControlGrid(Grid)

        Catch ex As Exception

        End Try
    End Sub
#End Region 'Methods

End Class