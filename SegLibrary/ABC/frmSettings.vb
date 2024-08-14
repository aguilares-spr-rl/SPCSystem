Imports System.Data.SqlClient
Imports Security_System
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frmSettings
#Region "Formulario Comun"
#Region "Propiedades"
    Public oAdmGrid As New objSeg
    Private oGridAdmin As New GridAdminClass
    Public ReadOnly Property FunctionID As String
    Public ReadOnly Property Grid As UltraGrid
        Get
            Return SGSETTINGSCUltraGrid
        End Get
    End Property
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
        SGSETTINGSCTableAdapter.Connection = Cn
        SGSETTINGSSTableAdapter.Connection = Cn
        SGSETTINGSTableAdapter.Connection = Cn

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FunctionID = pfunctionID
        Me.MdiParent = frmParent
    End Sub
#End Region 'Constructor
#End Region 'Formulario Comun
#Region "handlers"
    Private Sub SGSETTINGSCBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SGSETTINGSCBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SGSETTINGSCBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SegDS)
    End Sub
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGSETTINGS' Puede moverla o quitarla según sea necesario.
        Me.SGSETTINGSTableAdapter.Fill(Me.SegDS.SGSETTINGS)
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGSETTINGSS' Puede moverla o quitarla según sea necesario.
        Me.SGSETTINGSSTableAdapter.Fill(Me.SegDS.SGSETTINGSS)
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGSETTINGSC' Puede moverla o quitarla según sea necesario.
        Me.SGSETTINGSCTableAdapter.Fill(Me.SegDS.SGSETTINGSC)
        SetFormConfig()
    End Sub
#End Region 'handlers

#Region "Methods"
    Private Sub SetFormConfig()
        Try
            oGridAdmin.AddCol(0, "SGSettingcID", "SGSettingcID", Activation.Disabled, True)
            oGridAdmin.AddCol(0, "SGSettingcNombre", "Categoria")

            oGridAdmin.AddCol(1, "SGSettingsID", "SGSettingsID", Activation.Disabled, True)
            oGridAdmin.AddCol(1, "SGSettingsNombre", "SubCategoria")
            oGridAdmin.AddCol(1, "SGSettingcID", "SGSettingcID", Activation.Disabled, True)

            oGridAdmin.AddCol(2, "SGSettingID", "SGSettingID", Activation.Disabled, True)
            oGridAdmin.AddCol(2, "SGSettingNombre", "setting")
            oGridAdmin.AddCol(2, "SGSettingsID", "SGSettingsID", Activation.Disabled, True)
            oGridAdmin.AddCol(2, "SGSettingValorTexto", "Valor")
            oGridAdmin.AddCol(2, "SGSettingValorFecha", "Fecha")

            oGridAdmin.SetControlGrid(Grid)

        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
#End Region 'Methods

End Class