Imports Infragistics.Win.UltraWinGrid
Imports Security_System
Public Class frmContent
    'Private oUsr As New MySession
    Private m_oGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Private m_oToolBar As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
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

    Public Delegate Sub DlgMsgWorkHandler(ByVal sAcción As String, ByVal sIdenti As String, ByVal sMensaje As String)

    Public Sub New(ByVal pfunctionID As String, ByVal frmParen As Form, ByVal Optional pUsr As MySession = Nothing)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FunctionID = pfunctionID
        'oUsr = pUsr
        Me.MdiParent = frmParen
    End Sub
#Region "Eventos"
    Private Sub frmContent_Load(sender As Object, e As EventArgs) Handles Me.Load
        ProcesaOpcion()
    End Sub
    Private Sub DataGridViewMaestro_AfterRowActivate(sender As Object, e As EventArgs) Handles DataGridViewMaestro.AfterRowActivate
        If sender.ActiveRow Is Nothing Then Return
        Dim Drv As DataRowView = DirectCast(sender.ActiveRow.ListObject, DataRowView)
        ItemCurrent = Drv
    End Sub
    Private Sub WorkBackground1_MsgWork(sAcción As String, sKey As String, sMensaje As String) Handles WorkBackground1.MsgWork
        Me.BeginInvoke(New DlgMsgWorkHandler(AddressOf MsgWorkHandler), New Object() {sAcción, sKey, sMensaje})
    End Sub
#End Region 'Eventos
#Region "Metodos"
    Public Sub MsgWorkHandler(ByVal sAcc As String, ByVal sKey As String, ByVal sMsj As String)
        Try
            Select Case sAcc
                Case "Inicialización"
                    Progress.Minimum = 0
                    Progress.Maximum = Val(sMsj)
                Case "Iteración Vinc."
                    DataGridViewMaestro.Rows.Item(Val(sKey)).Appearance.BackColor = Color.Green
                    DataGridViewMaestro.Rows.Item(Val(sKey)).Cells.Item("cfd_stsprc").Value = sMsj.Split("|")(0)
                    DataGridViewMaestro.Rows.Item(Val(sKey)).Cells.Item("cfd_msjreg").Value = sMsj.Split("|")(1)
                Case "Fin Vinc."
                    ProcesaOpcion()
                    m_oToolBar.Tools.Item("btnRunWorkflow").SharedProps.Enabled = True
                Case "ComplementarInfo"
                    ProcesaOpcion()
                    m_oToolBar.Tools.Item("btnRunWorkflow").SharedProps.Enabled = True
            End Select
        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
    Public Sub ConfigToolBar()
        Dim oSql As New AppPermisos(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            oCs.Create("@SgUserID", oUsr.UserID)
            oCs.Create("@SGFuncionID", FunctionID)
            Dim oTb As DataTable = oSql._Item(oSql.Lista, "Permisos", oCs)

            If Not oTb Is Nothing Then
                For Each Dr As DataRow In oTb.Rows
                    m_oToolBar.Tools.Item("btnRefresh").SharedProps.Visible = (Dr("PerfilConsultar") = "S") 'Consultar
                    m_oToolBar.Tools.Item("btnNew").SharedProps.Visible = (Dr("PerfilNuevo") = "S") 'Nuevo
                    m_oToolBar.Tools.Item("btnDelete").SharedProps.Visible = (Dr("PerfilEliminar") = "S") 'Eliminar
                    m_oToolBar.Tools.Item("btnRecover").SharedProps.Visible = (Dr("PerfilRecuperar") = "S") 'Recuperar
                    m_oToolBar.Tools.Item("btnEdit").SharedProps.Visible = (Dr("PerfilModificar") = "S") 'Modificar
                    m_oToolBar.Tools.Item("btnExcel").SharedProps.Visible = (Dr("PerfilExportar") = "S") 'Exportar
                    m_oToolBar.Tools.Item("btnPrint").SharedProps.Visible = (Dr("PerfilListar") = "S") 'Listar
                    m_oToolBar.Tools.Item("btnPDF").SharedProps.Visible = (Dr("PerfilGraficar") = "S") 'Graficar
                    'btnEsp1.Visible = (Dr("PerfilEspecial1") = "S")
                    'btnEsp2.Visible = (Dr("PerfilEspecial2") = "S")
                    'btnEsp3.Visible = (Dr("PerfilEspecial3") = "S")
                    'btnEsp4.Visible = (Dr("PerfilEspecial4") = "S")
                    'btnEsp5.Visible = (Dr("PerfilEspecial5") = "S")
                    'btnEsp6.Visible = (Dr("PerfilEspecial6") = "S")
                    'btnEsp7.Visible = (Dr("PerfilEspecial7") = "S")
                    'btnEsp8.Visible = (Dr("PerfilEspecial8") = "S")
                    'btnEsp9.Visible = (Dr("PerfilEspecial9") = "S")
                    'btnEsp10.Visible = (Dr("PerfilEspecial10") = "S")
                    Exit For
                Next
            End If

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
    Public Sub ProcesaOpcion(Optional ByVal sEvento As String = "")
        Dim oSql As New SQLFuncion(oUsr)
        Dim oCs As New ColeccionPrmSql
        Dim obj As Object
        Try
            'Obtiene información de la funcion y evento
            oCs.Create("@SGFuncionID", FunctionID)
            Dim sDLL As String = oSql._Valor(oSql.Item, "SGFuncionOLEDLL", oCs)

            If sEvento = "" Then
                sEvento = EVENTOS.EV_CONSULTAR
                Me.Text = oSql._Valor(oSql.Item, "SGFuncion", oCs)
            End If

            ConfigToolBar()

            oUsr.CurrentStatus = "A"
            oUsr.CurrentFunction = FunctionID
            oUsr.CurrentEvent = sEvento

            Dim sEnsamblado As String = sDLL.Split(".")(0)
            Dim asm As Reflection.Assembly = Reflection.Assembly.Load(sEnsamblado)
            obj = asm.CreateInstance(sDLL)
            obj.ProcesaOpcion(oUsr, DataGridViewMaestro, WorkBackground1)
            m_oGrid = DataGridViewMaestro

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub

#End Region 'Metodos



End Class