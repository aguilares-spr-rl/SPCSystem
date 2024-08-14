Imports System.Data.SqlClient
Imports Security_System
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frmFunciones
#Region "Formulario Comun"
#Region "Propiedades"
    Public ReadOnly Property FunctionID As String
    Public ReadOnly Property Grid As UltraGrid
        Get
            Return SGFUNCIONESUltraGrid
        End Get
    End Property
    Private oGridAdmin As New GridAdminClass()

#End Region 'Propiedades
#Region "Constructor"
    Public Sub New(ByVal pfunctionID As String, ByVal frmParent As Form, ByVal Optional pUsr As MySession = Nothing)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim Cn As SqlConnection = New SqlConnection(pUsr.App.DataStore.StringCnx)
        If Cn.State = ConnectionState.Closed Then
            Cn.Open()
        End If
        SGFUNCIONESTableAdapter.Connection = Cn
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FunctionID = pfunctionID
        Me.MdiParent = frmParent
    End Sub
#End Region 'Constructor
#End Region 'Formulario Comun
#Region "Handlers"
    Private Sub SGFUNCIONESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SGFUNCIONESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SGFUNCIONESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SegDS)
    End Sub
    Private Sub frmFunciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGFUNCIONES' Puede moverla o quitarla según sea necesario.
        Me.SGFUNCIONESTableAdapter.Fill(Me.SegDS.SGFUNCIONES)
        SetFormConfig()
    End Sub
#End Region 'Handlers
#Region "Methods"
    Private Sub SetFormConfig()
        Try
            Me.Text = "Funciones"
            oGridAdmin.GridText = "ABC de Funciones"

            oGridAdmin.AddBanda(0, "FUN", "FUNCION")

            oGridAdmin.AddCol(0, "SGFuncionID", "ID", ,, 30)
            oGridAdmin.AddCol(0, "SGFuncionNombre", "Función")
            oGridAdmin.AddCol(0, "SGFuncionDescripcion", "Descripción",,, 300)

            oGridAdmin.AddCol(0, "SGFuncionConsultar", "Consultar",,,,, 1)
            oGridAdmin.AddCol(0, "SGFuncionNuevo", "Nuevo",,,,, 1)
            oGridAdmin.AddCol(0, "SGFuncionEliminar", "Eliminar",,,,, 1)
            oGridAdmin.AddCol(0, "SGFuncionRecuperar", "Recuperar",,,,, 1)
            oGridAdmin.AddCol(0, "SGFuncionModificar", "Modificar",,,,, 1)
            oGridAdmin.AddCol(0, "SGFuncionListar", "Listar",,,,, 1)
            oGridAdmin.AddCol(0, "SGFuncionExportar", "Exportar",,,,, 1)
            oGridAdmin.AddCol(0, "SGFuncionGraficar", "Graficar",,,,, 1)
            oGridAdmin.AddCol(0, "SGFuncionActivo", "Activo",,,,, 1)
            oGridAdmin.AddCol(0, "SGFuncionOLEDLL", "Activo",,,,, "")
            oGridAdmin.AddCol(0, "SGFuncionWeb", "Web",,,,, "")
            oGridAdmin.AddCol(0, "SGFuncionPrimaria", "Primaria",,,,, 1)

            oGridAdmin.SetControlGrid(Grid)

        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
#End Region 'Methods

End Class