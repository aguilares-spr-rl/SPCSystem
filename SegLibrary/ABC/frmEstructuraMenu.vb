Imports System.Data.SqlClient
Imports Security_System
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frmEstructuraMenu
#Region "Formulario Comun"
    Private Ds As New DataSet
#Region "Propiedades"
    Public oAdmGrid As New objSeg
    Public ReadOnly Property FunctionID As String
    Public ReadOnly Property Grid As UltraGrid
        Get
            Return SGESTRUCTURAMENUUltraGrid
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
        SGESTRUCTURAMENUTableAdapter.Connection = Cn
        SGESTRUCTURASM_DETALLETableAdapter.Connection = Cn
        SGFUNCIONESMODULOTableAdapter.Connection = Cn

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FunctionID = pfunctionID
        Me.MdiParent = frmParent
        IniListas()
    End Sub
#End Region 'Constructor
#Region "Metodos de Configuración"
    Private Sub IniListas()
        IniListaModulos()
    End Sub
#End Region 'Metodos de Configuración
#End Region 'Formulario Comun
#Region "Eventos"
    Private Sub SGESTRUCTURAMENUBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SGESTRUCTURAMENUBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SGESTRUCTURAMENUBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SegDS)

    End Sub
    Private Sub frmEstructuraMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGFUNCIONESMODULO' Puede moverla o quitarla según sea necesario.
        Me.SGFUNCIONESMODULOTableAdapter.Fill(Me.SegDS.SGFUNCIONESMODULO)
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGESTRUCTURASM_DETALLE' Puede moverla o quitarla según sea necesario.
        Me.SGESTRUCTURASM_DETALLETableAdapter.Fill(Me.SegDS.SGESTRUCTURASM_DETALLE)
        'TODO: esta línea de código carga datos en la tabla 'SegDS.SGESTRUCTURAMENU' Puede moverla o quitarla según sea necesario.
        Me.SGESTRUCTURAMENUTableAdapter.Fill(Me.SegDS.SGESTRUCTURAMENU)
        SetFormConfig()
    End Sub
    Private Sub SGESTRUCTURAMENUUltraGrid_AfterSelectChange(sender As Object, e As AfterSelectChangeEventArgs) Handles SGESTRUCTURAMENUUltraGrid.AfterSelectChange
        If Grid.Selected.Rows.Count > 0 Then
            Dim rowSelected As UltraGridRow
            For Each rowSelected In Grid.Selected.Rows
                MyRowSelected = rowSelected
                Exit For
            Next
        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If ExportXML() Then
            MsgBox("Exportación exitosa", MsgBoxStyle.Information, "AVISO")
        End If
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim sFile As String = String.Empty
        sFile = OpenFile(OpenFileDialog1)
        If sFile <> String.Empty Then
            Ds.ReadXml(sFile)
        End If
        If ImportXML() Then
            MsgBox("Importación exitosa", MsgBoxStyle.Information, "AVISO")
        End If
    End Sub
#End Region 'Eventos
#Region "Metodos"
    Private Sub SetFormConfig()
        Try
            Me.Text = "Estructuras de Menu"
            Grid.Text = "Detalle de la estructura de menu"

            Grid.DisplayLayout.Bands(2).Columns.Item("ModuloID").Header.Caption = "Modulo"
            Grid.DisplayLayout.Bands(2).Columns.Item("SGFuncionID").Header.Caption = "Funcion"

            For Each Col As UltraGridColumn In Grid.DisplayLayout.Bands(1).Columns
                Select Case Col.Key
                    Case "ConsumoID", "EstructuraMenuID", "SGFuncionModuloID", "EstructuraMenuDetalleID"
                        Col.CellActivation = Activation.Disabled
                        Col.Hidden = True

                    Case Else

                End Select
            Next
            For Each Col As UltraGridColumn In Grid.DisplayLayout.Bands(2).Columns
                Select Case Col.Key
                    Case "ConsumoID", "EstructuraMenuID", "SGFuncionModuloID", "EstructuraMenuDetalleID"
                        Col.CellActivation = Activation.Disabled
                        Col.Hidden = True

                    Case Else

                End Select
            Next

            IniListaModulos()
            ListFunciones()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub IniListaModulos()
        Dim oSql As New SQLModulo(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            If SGESTRUCTURAMENUUltraGrid.DisplayLayout.ValueLists.Exists("Mod") Then
                Exit Sub
            End If
            oCs.Create("@status", True)
            Dim oTb As DataTable = oSql._Lista(oSql.List, "MODULOS", oCs)
            If Not oTb Is Nothing Then
                Dim valueList As ValueList = Me.SGESTRUCTURAMENUUltraGrid.DisplayLayout.ValueLists.Add("Mod")
                For Each Dr As DataRow In oTb.Rows
                    valueList.ValueListItems.Add(Dr("ModuloID"), Dr("ModuloNombre").ToString)
                Next
                Dim column As UltraGridColumn = SGESTRUCTURAMENUUltraGrid.DisplayLayout.Bands(1).Columns("ModuloID")
                column.ValueList = valueList
                column.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate

                Dim othercolumn As UltraGridColumn = SGESTRUCTURAMENUUltraGrid.DisplayLayout.Bands(1).Columns("ModuloPadreID")
                othercolumn.ValueList = valueList
                othercolumn.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate

                Dim column2 As UltraGridColumn = SGESTRUCTURAMENUUltraGrid.DisplayLayout.Bands(2).Columns("ModuloID")
                column2.ValueList = valueList
                column2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate

            End If

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
    Private Sub ListFunciones()
        Dim oSql As New SQLFuncion(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            oCs.Create("@status", 1)
            Dim oTb As DataTable = oSql._Lista(oSql.Lista, "FUN", oCs)
            If Not oTb Is Nothing Then
                IniLista(oTb, Grid, 2)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub RefreshGrid()
        Try

            Me.SGESTRUCTURASM_DETALLETableAdapter.Fill(Me.SegDS.SGESTRUCTURASM_DETALLE)
            'TODO: esta línea de código carga datos en la tabla 'SegDS.SGESTRUCTURAMENU' Puede moverla o quitarla según sea necesario.
            Me.SGESTRUCTURAMENUTableAdapter.Fill(Me.SegDS.SGESTRUCTURAMENU)
            SetFormConfig()

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub

    Private Sub TSBEstructura_Click(sender As Object, e As EventArgs) Handles TSBEstructura.Click
        Dim oFrm As New frmEstructuraDetalle
        Try
            If MyRowSelected Is Nothing Then
                MsgBox("No existe Estructura seleccionada", vbInformation, "AVISO")
                Exit Sub
            End If
            With oFrm
                If IsNumeric(MyRowSelected.Cells("EstructuraMenuID").Value) Then
                    .EstructuraMenuID = MyRowSelected.Cells("EstructuraMenuID").Value
                    .Text = MyRowSelected.Cells("EstructuraMenuDescripcion").Value
                    .ShowDialog()
                End If
            End With
        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub

    Private Function ExportXML() As Boolean
        ExportXML = False
        Try
            Dim oBjEx As New ExportSG()
            Return oBjEx.Export()

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try

    End Function
    Private Function ImportXML() As Boolean
        Try
            Dim oBjEx As New ExportSG()
            Return oBjEx.Import(Ds)

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Function
    Private Function OpenFile(ByVal OpenDialg As OpenFileDialog) As String
        Dim myFile As String = Nothing
        OpenFile = String.Empty

        With OpenDialg
            .FileName = ""
            .InitialDirectory = "c:\"
            .Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
            .FilterIndex = 1
            .RestoreDirectory = True
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Return .FileName
            End If
        End With

    End Function

#End Region 'Metodos
End Class