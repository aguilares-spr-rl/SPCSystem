Imports System.IO
Imports Infragistics.Win.UltraWinExplorerBar
Imports Infragistics.Win.UltraWinGrid.DocumentExport
Imports Infragistics.Win.UltraWinGrid.ExcelExport
Imports Infragistics.Win.UltraWinToolbars
Imports Infragistics.Win
Imports Security_System
Imports Infragistics.Win.UltraWinTabbedMdi
Imports Infragistics.Win.UltraWinEditors

Public Class frmMain
    Private Const CONTENTEMPTY = "Content Empty"

    Private gridExportFormat As GridExportFileFormat = GridExportFileFormat.PDF
    'Private progressTimer As Timer = Nothing
    Private progressPanel As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = Nothing
    Private progressPanelLabel As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = Nothing
    Private random As Random = New Random((DateTime.Now().Ticks) Mod Int32.MaxValue)
    'Private oUsr As New MySession
    Private m_sAplication As String = String.Empty

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        'AppStyling.StyleManager.Load(Utilities.GetEmbeddedResourceStream("WinNet.Styling.Theme 01.isl"))
        'AppStyling.StyleManager.Load(Path.Combine(Application.StartupPath, "../../Styling/Theme.isl"))
        AppStyling.StyleManager.Load(Path.Combine(Application.StartupPath, "../../Styling/Theme 01.isl"))

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        m_sAplication = System.Configuration.ConfigurationManager.AppSettings("Aplication")
        oUsr.App.Estructura = System.Configuration.ConfigurationManager.AppSettings("Estructura")
        oUsr.App.DataStore.Source = System.Configuration.ConfigurationManager.AppSettings("DataSource")
        oUsr.App.DataStore.DataBase = System.Configuration.ConfigurationManager.AppSettings("DataBase")
        oUsr.App.DataStore.User = Utilities.DesEncriptar(System.Configuration.ConfigurationManager.AppSettings("User"))
        oUsr.App.DataStore.Password = Utilities.DesEncriptar(System.Configuration.ConfigurationManager.AppSettings("Password"))
        oUsr.App.Log = Path.Combine(Application.StartupPath, "../Err.log")
        oUsr.App.ExportPath = Path.Combine(Application.StartupPath, "../Export")

        AddOtherDataStore(OData.UERP)

    End Sub

    Private Sub AddOtherDataStore(ByVal KeySettings As String)
        Dim oSourcePortal As New MyDataStore
        With oSourcePortal
            .Source = System.Configuration.ConfigurationManager.AppSettings("DataSource" + KeySettings)
            .DataBase = System.Configuration.ConfigurationManager.AppSettings("DataBase" + KeySettings)
            .User = Utilities.DesEncriptar(System.Configuration.ConfigurationManager.AppSettings("User" + KeySettings))
            .Password = Utilities.DesEncriptar(System.Configuration.ConfigurationManager.AppSettings("Password" + KeySettings))
        End With
        oUsr.App.OthersDataStore.Add(oSourcePortal)
    End Sub

    Private ReadOnly Property ProgressPanelProperty As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Get
            If progressPanel Is Nothing Then
                progressPanel = ultraStatusBar1.Panels("uspProgress")
            End If
            Return progressPanel
        End Get
    End Property

    Private ReadOnly Property ProgressPanelLabelProperty As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Get
            If progressPanelLabel Is Nothing Then
                progressPanelLabel = ultraStatusBar1.Panels("lblProgress")
            End If
            Return progressPanelLabel
        End Get
    End Property

#Region "Eventos"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitExplorerBar()
    End Sub
    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Static bOK As Boolean

        If Not bOK Then
            bOK = True
            pSetConexion()
        End If
    End Sub
    'Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    'ultraExplorerBar1.CreationFilter = New Filters.ExplorerBarCreationFilter()
    '    'ultraToolbarsManager1.DrawFilter = New Filters.ToolbarDrawFilter()
    'End Sub
    Private Sub ultraToolbarsManager1_ToolClick(sender As Object, e As ToolClickEventArgs) Handles ultraToolbarsManager1.ToolClick
        Dim frmContent As Object = Nothing
        Dim MdiTab As MdiTab = Nothing
        MdiTab = UltraTabbedMdiManager1.TabFromKey(oUsr.CurrentFunction)
        Select Case (e.Tool.Key)
            Case "btnNew"
                If Not MdiTab Is Nothing Then
                    frmContent = MdiTab.Form
                    frmContent.ProcesaOpcion(EVENTOS.EV_NUEVO)
                End If

            Case "btnEdit"
                If Not MdiTab Is Nothing Then
                    frmContent = MdiTab.Form
                    frmContent.ProcesaOpcion(EVENTOS.EV_PROPIEDADES)
                End If

            Case "btnDelete"
                If Not MdiTab Is Nothing Then
                    frmContent = MdiTab.Form
                    frmContent.ProcesaOpcion(EVENTOS.EV_ELIMINAR)
                End If

            Case "btnRecover"
                If Not MdiTab Is Nothing Then
                    frmContent = MdiTab.Form
                    frmContent.ProcesaOpcion(EVENTOS.EV_RECUPERAR)
                End If

            Case "btnRefresh"
                If Not MdiTab Is Nothing Then
                    frmContent = MdiTab.Form
                    frmContent.ProcesaOpcion(EVENTOS.EV_CONSULTAR)
                End If
#Region "Especiales"
            Case "btnRunWorkflow"
                If Not MdiTab Is Nothing Then
                    frmContent = MdiTab.Form
                    e.Tool.SharedProps.Enabled = False
                    'frmContent.ProcesaOpcion(EVENTOS.EV_ESPECIAL1)
                End If
#End Region

            Case "btnMerge"


            Case "btnAdvancedFind"
            Case "btnRunReport"
            Case "btnExcel"
                If Not MdiTab Is Nothing Then
                    frmContent = MdiTab.Form
                    Me.UltraGridExcelExporter1.Export(frmContent.Grid, oUsr.App.ExportPath & "\ExcelExport.xlsx", Infragistics.Documents.Excel.WorkbookFormat.Excel2007)
                End If
            Case "btnPDF"
            Case "btnPrint"
            Case "btnExit"
                Application.Exit()
            Case "btnCambioPassword"
                ChangePassword()
                'MsgBox("Cambiar contraseña", vbInformation, "Password")
            Case "pmtOptions"
            Case "pccAbout"
            Case "PaneLayout"
            Case "listPaneLayout"
            Case Else
        End Select

    End Sub

    '===================================================================================================================================
    'Función procesa opción prototipo
    '===================================================================================================================================
    Public Sub ProcesaOpcion(ByVal FunctionID As String, ByRef ofrmContent As Object)
        Dim oSql As New SQLFuncion(oUsr)
        Dim oCs As New ColeccionPrmSql
        Dim sEvento As String = EVENTOS.EV_CONSULTAR
        Dim obj As Object
        Try
            'Obtiene información de la funcion y evento
            oCs.Create("@SGFuncionID", FunctionID)
            Dim sDLL As String = oSql._Valor(oSql.Item, "SGFuncionOLEDLL", oCs)
            Dim sEnsamblado As String = sDLL.Split(".")(0)
            Dim asm As Reflection.Assembly = Reflection.Assembly.Load(sEnsamblado)
            obj = asm.CreateInstance(sDLL)
            If Not obj Is Nothing Then
                ofrmContent = obj.InstanciaFrm(oUsr, Me)
            End If
        Catch ex As Exception
            Dim s As String = ex.Message
        End Try
    End Sub

    Private Sub ultraExplorerBar1_ItemClick(sender As Object, e As ItemEventArgs) Handles ultraExplorerBar1.ItemClick

        If Not (progressTimer Is Nothing) And Not (progressPanel Is Nothing) And Not (progressPanelLabel Is Nothing) Then
            progressTimer.Stop()
            progressPanel.ProgressBarInfo.Value = progressPanel.ProgressBarInfo.Minimum
            progressPanelLabel.Text = String.Format("{0}: {1}%", "Updating", progressPanel.ProgressBarInfo.Value)
            progressTimer.Start()
        End If

        oUsr.CurrentFunction = e.Item.Key
        oUsr.CurrentEvent = EVENTOS.EV_CONSULTAR

        Dim MdiTab As MdiTab = Nothing
        MdiTab = UltraTabbedMdiManager1.TabFromKey(e.Item.Key)
        Dim frmContent As Object = Nothing

        If MdiTab Is Nothing Then
            ProcesaOpcion(e.Item.Key, frmContent)
            If frmContent Is Nothing Then
                frmContent = New frmContent(e.Item.Key, Me, oUsr)
            End If
        Else
            frmContent = MdiTab.Form
        End If

        If Not frmContent Is Nothing Then
            frmContent.Show()
            frmContent.Activate()
        End If

    End Sub

    Private Sub UltraTabbedMdiManager1_InitializeTab(sender As Object, e As MdiTabEventArgs) Handles UltraTabbedMdiManager1.InitializeTab
        Dim frmContent As Object = e.Tab.Form
        If frmContent Is Nothing Then
            If (e.Tab.Form Is frmContentEmpty) Then
                e.Tab.Key = CONTENTEMPTY
            End If
            Exit Sub
        End If
        e.Tab.Key = frmContent.FunctionID
    End Sub
    Private Sub UltraGridExcelExporter1_ExportEnded(sender As Object, e As Infragistics.Win.UltraWinGrid.ExcelExport.ExportEndedEventArgs) Handles UltraGridExcelExporter1.ExportEnded
        System.Diagnostics.Process.Start(oUsr.App.ExportPath & "\ExcelExport.xlsx")
    End Sub

    Private Sub UltraGridDocumentExporter1_ExportEnded(sender As Object, e As Infragistics.Win.UltraWinGrid.DocumentExport.ExportEndedEventArgs) Handles UltraGridDocumentExporter1.ExportEnded
        Select Case gridExportFormat
            Case GridExportFileFormat.PDF
                System.Diagnostics.Process.Start(Application.StartupPath + "\pdfExport.pdf")
            Case GridExportFileFormat.XPS
                System.Diagnostics.Process.Start(Application.StartupPath + "\xpsExport.xps")
        End Select
    End Sub

    Private Sub progressTimer_Tick(sender As Object, e As EventArgs) Handles progressTimer.Tick
        If (Not progressPanel Is Nothing And Not progressPanelLabel Is Nothing) Then
            Dim Mystep As Integer = random.Next(0, 10)
            If (progressPanel.ProgressBarInfo.Value + Mystep > progressPanel.ProgressBarInfo.Maximum) Then
                progressPanel.ProgressBarInfo.Value = progressPanel.ProgressBarInfo.Minimum
                progressPanelLabel.Text = "Actualizado"
                progressTimer.Stop()
            Else
                progressPanel.ProgressBarInfo.Value += Mystep
                progressPanelLabel.Text = String.Format("{0}: {1}%", "Updating", progressPanel.ProgressBarInfo.Value)
            End If
        Else
            progressTimer.Stop()
        End If

    End Sub
    Private Sub ultraTrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles ultraTrackBar1.ValueChanged
        Dim usp As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = Nothing
        If ultraStatusBar1.Panels.Count > 0 Then
            usp = ultraStatusBar1.Panels("lblZoom")
        End If

        If (Not usp Is Nothing) Then
            usp.Text = String.Format("{0}%", ultraTrackBar1.Value)
        End If

    End Sub

    Private Sub ultraTrackBar1_DoubleClick(sender As Object, e As EventArgs) Handles ultraTrackBar1.DoubleClick
        If (Not ultraTrackBar1.MidpointSettings.Value.HasValue) Then
            Exit Sub
        End If
        Dim MouseEventArgs As MouseEventArgs = e
        If (Not MouseEventArgs Is Nothing) Then
            Dim uie As UIElement = ultraTrackBar1.UIElement.ElementFromPoint(MouseEventArgs.Location)
            If (Not uie Is Nothing And Not uie.GetAncestor(GetType(Infragistics.Win.UltraWinEditors.TrackBarThumbUIElement)) Is Nothing) Then
                ultraTrackBar1.Value = ultraTrackBar1.MidpointSettings.Value.Value
            End If
        End If

    End Sub
    Private Sub ultraTextEditor1_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles ultraTextEditor1.EditorButtonClick
        Dim s As String = sender.Text
        SearchingInGrid(s)
    End Sub

#End Region 'Eventos

#Region "Metodos"

    Private Sub InitUI()

        Dim group As UltraExplorerBarGroup = ultraExplorerBar1.Groups("Group")
        If Not group Is Nothing Then
            group.Active = True
            group.Selected = True
            Dim item As UltraExplorerBarItem = group.Items("Funcion")
            If Not item Is Nothing Then
                item.Active = True
                ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ClickActiveItem)
            End If
        End If

        Dim Control As New Control()
        Control.Visible = False
        Control.Parent = Me
        ultraToolbarsManager1.Tools("pccAbout").Control = Control

        progressTimer = Infragistics.Win.Utilities.CreateTimer()
        progressTimer.Interval = 250
        progressTimer.Start()

        If ultraTrackBar1.MidpointSettings.Value.HasValue Then
            ultraTrackBar1.Value = ultraTrackBar1.MidpointSettings.Value.Value
        End If

    End Sub

    Private Sub InitExplorerBar()
        Dim oSql As New SQLMenu(oUsr)
        Dim oCs As New ColeccionPrmSql()
        Try
            oCs.Create("@PerfilID", oUsr.Perfil)
            oCs.Create("@ModuloID", "")
            Dim oTb As DataTable = oSql._Lista(oSql.ListGroups, "Groups", oCs)
            If Not oTb Is Nothing Then
                For Each Dr As DataRow In oTb.Rows
                    Dim aGroup As New UltraExplorerBarGroup()
                    aGroup = ultraExplorerBar1.Groups.Add()
                    aGroup.Text = Dr("ModuloNombre").ToString
                    aGroup.Key = Dr("ModuloID").ToString
                    oCs.ItemValue("@ModuloID") = aGroup.Key
                    Dim oTbItem As DataTable = oSql._Lista(oSql.ListItems, "Items", oCs)
                    If Not oTbItem Is Nothing Then
                        For Each Dri As DataRow In oTbItem.Rows
                            Dim anItem As New UltraExplorerBarItem()
                            anItem.Text = Dri("SGFuncionDescripcion").ToString
                            anItem.Key = Dri("SGFuncionID").ToString
                            Dim img As New System.Drawing.Bitmap(Path.Combine(Application.StartupPath, "../../Images/Edit.png"))
                            anItem.Settings.AppearancesSmall.Appearance.Image = img
                            aGroup.Items.Add(anItem)
                        Next
                    End If

                Next
            End If

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
    Private Sub pSetConexion()
        Dim oFrm As New LoginFormWin
        Try
            With oFrm
                .ShowDialog()
                If oUsr.UserLogin Then
                    Me.Text = m_sAplication & oUsr.App.DataStore.Source & "@" & oUsr.App.DataStore.DataBase & "@" & oUsr.UserName
                    'Seleccionar perfil
                    If oUsr.Perfiles > 1 Then
                        Dim oDlg As New dlgPerfiles()
                        oDlg.ShowDialog()
                    End If
                Else
                    MsgBox("Acceso denegado", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                    End
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
    End Sub

    Private Sub SearchingInGrid(ByVal s As String)
        Dim frmContent As Object = Nothing
        Dim MdiTab As MdiTab = Nothing
        Dim oGrid As UltraWinGrid.UltraGrid = Nothing
        Try
            MdiTab = UltraTabbedMdiManager1.TabFromKey(oUsr.CurrentFunction)
            If Not MdiTab Is Nothing Then
                frmContent = MdiTab.Form
                oGrid = frmContent.Grid
                'frmContent.SearchingInGrid(s)
            End If

            For Each row As UltraWinGrid.UltraGridRow In oGrid.Rows
                For Each cell As UltraWinGrid.UltraGridCell In row.Cells
                    If cell.Text.Contains(s) Then
                        'The cell must be activated first
                        cell.Activate()
                        'Cell must be in edit mode to perform selection
                        oGrid.PerformAction(UltraWinGrid.UltraGridAction.EnterEditMode)
                        'Start the selection
                        ''cell.SelStart = cell.Text.IndexOf(s)
                        'For this length
                        ''cell.SelLength = s.Length
                        'For eye candy, make this the first visible row
                        oGrid.DisplayLayout.RowScrollRegions(0).FirstRow = row
                        Exit Sub
                    End If
                Next
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.TargetSite.ToString)
        End Try
    End Sub

    Private Sub ChangePassword()
        Dim oSeg As New SegLibrary.dlgChangePassword
        Try
            With oSeg
                .OUsr = oUsr
                .Show()
            End With
        Catch ex As Exception
            Dim sErr As String = ex.Message
        End Try
    End Sub

#End Region 'Metodos

End Class
