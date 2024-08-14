Imports System.Data.SqlClient
Imports Security_System
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
'=====================================================================================================================================
'Catalogo Estandar
'=====================================================================================================================================
Public Class frmModulos
#Region "Formulario Comun"
#Region "Propiedades"
    Public ReadOnly Property FunctionID As String
    Public Property MyRowSelected As UltraGridRow
    Public ReadOnly Property Grid As UltraGrid
        Get
            Return SGMODULOSUltraGrid
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
        SGMODULOSTableAdapter.Connection = Cn
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FunctionID = pfunctionID
        Me.MdiParent = frmParent
    End Sub
#End Region 'Constructor
#End Region 'Formulario Comun
#Region "Handlers"
    Private Sub SGMODULOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SGMODULOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SGMODULOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SegDS)

    End Sub
    Private Sub frmModulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGMODULOS' Puede moverla o quitarla según sea necesario.
        Me.SGMODULOSTableAdapter.Fill(Me.SegDS.SGMODULOS)
    End Sub
#End Region 'Handlers

End Class