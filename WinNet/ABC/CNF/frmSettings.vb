Imports System.Data.SqlClient
Imports Security_System
Public Class frmSettings
#Region "frmComun"
#Region "Miembros privados"
    Private m_oGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Private m_oToolBar As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
#End Region 'Miembros privados
#Region "Propiedades"
    Public Property CurrentFuncion As New Funcion()
    Public ReadOnly Property FunctionID As String
    'Public ReadOnly Property Grid As Infragistics.Win.UltraWinGrid.UltraGrid
    Public ReadOnly Property Grid As Infragistics.Win.UltraWinGrid.UltraGrid
        Get
            Return m_oGrid
        End Get
    End Property
    Public Property ToolsBar As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
        Get
            Return m_oToolBar
        End Get
        Set(value As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager)
            m_oToolBar = value
        End Set
    End Property
    Public Property Progress As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Public Property ItemCurrent As DataRowView
#End Region 'Propiedades
#Region "Constructor"
    Public Sub New(ByVal pfunctionID As String, ByVal frmParen As Form, ByVal Optional pUsr As MySession = Nothing)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim Cn As SqlConnection = New SqlConnection(Utilities.GetDataStoreInfoEncript())
        SETTINGSTableAdapter.Connection = Cn
        SETTINGSITEMSTableAdapter.Connection = Cn
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FunctionID = pfunctionID
        'oUsr = pUsr
        Me.MdiParent = frmParen

        'IniListas()

    End Sub
#End Region 'Constructor
#End Region 'frmComun
#Region "Eventos"
    Private Sub SETTINGSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SETTINGSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SETTINGSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSSettings)

    End Sub
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSSettings.SETTINGSITEMS' Puede moverla o quitarla según sea necesario.
        Me.SETTINGSITEMSTableAdapter.Fill(Me.DSSettings.SETTINGSITEMS)
        'TODO: esta línea de código carga datos en la tabla 'DSSettings.SETTINGS' Puede moverla o quitarla según sea necesario.
        Me.SETTINGSTableAdapter.Fill(Me.DSSettings.SETTINGS)
    End Sub
#End Region 'Eventos

End Class