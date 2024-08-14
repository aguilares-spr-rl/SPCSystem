Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Security_System
Imports System.Runtime.Remoting

Public Class GridAdminClass
#Region "Members"
    Private WithEvents m_oGrid As UltraGrid
    Private ConfigCol As New List(Of AttColumna)
    Private ConfigBan As New List(Of AttBanda)
#End Region 'Members
#Region "Property"
    Public Property GridText As String
    Public Property Nuevo As Boolean
    Public Property Eliminar As Boolean
    Public Property Modificar As Boolean

    Public Property MyRowSelected As UltraGridRow
    Public ReadOnly Property MyRows As Integer
        Get
            If Not m_oGrid Is Nothing Then
                Return m_oGrid.Rows.Count
            Else
                Return 0
            End If

        End Get
    End Property
    Public Property RegistroActivoDefault As Boolean = True
#End Region 'Property
#Region "Constructor"
    Public Sub New(ByVal pUsr As MySession)
        oUsr = pUsr
    End Sub
#End Region
    Public Sub AddBanda(ByVal pBand As Short, ByVal pName As String, ByVal Optional pAddButtonCaption As String = "", ByVal Optional pHidden As Boolean = False, ByVal Optional pAddNew As AllowAddNew = AllowAddNew.No)
        ConfigBan.Add(New AttBanda(pBand, pName, pAddButtonCaption, pHidden, pAddNew))
    End Sub
    Public Sub AddCol(ByVal pBand As Short, ByVal pName As String, ByVal pHeader As String, ByVal Optional pActivation As Activation = Activation.AllowEdit, ByVal Optional pHidden As Boolean = False, ByVal Optional pWidth As Integer = 0, ByVal Optional pLista As DataTable = Nothing, ByVal Optional pValorDefault As Object = Nothing)
        ConfigCol.Add(New AttColumna(pBand, pName, pHeader, pActivation, pHidden, pWidth, pLista, pValorDefault))
    End Sub
    Public Sub SetControlGrid(oGrid As UltraGrid) 'Pudiera incluir mas objetos visuales referenciados

        m_oGrid = oGrid
        m_oGrid.Text = GridText

        m_oGrid.DisplayLayout.Override.AllowAddNew = IIf(Nuevo, AllowAddNew.Yes, AllowAddNew.No)
        m_oGrid.DisplayLayout.Override.AllowDelete = IIf(Eliminar, DefaultableBoolean.True, DefaultableBoolean.False)
        m_oGrid.DisplayLayout.Override.AllowUpdate = IIf(Modificar, DefaultableBoolean.True, DefaultableBoolean.False)

        For Each CfgB As AttBanda In ConfigBan
            m_oGrid.DisplayLayout.Bands.Item(CfgB.Band).Override.AllowAddNew = CfgB.AddNew
            m_oGrid.DisplayLayout.Bands.Item(CfgB.Band).AddButtonCaption = CfgB.AddButtonCaption
            m_oGrid.DisplayLayout.Bands.Item(CfgB.Band).Hidden = CfgB.Hidden
        Next

        For Each Cfg As AttColumna In ConfigCol
            m_oGrid.DisplayLayout.Bands(Cfg.Band).Columns.Item(Cfg.Name).Header.Caption = Cfg.Header
            m_oGrid.DisplayLayout.Bands(Cfg.Band).Columns.Item(Cfg.Name).CellActivation = Cfg.Activation
            m_oGrid.DisplayLayout.Bands(Cfg.Band).Columns.Item(Cfg.Name).Hidden = Cfg.Hidden
            If Cfg.Width > 0 Then
                m_oGrid.DisplayLayout.Bands(Cfg.Band).Columns.Item(Cfg.Name).Width = Cfg.Width
            End If
            If Not Cfg.Lista Is Nothing Then
                If Not m_oGrid.DisplayLayout.ValueLists.Exists(Cfg.Lista.TableName) Then
                    Dim valueList As ValueList = m_oGrid.DisplayLayout.ValueLists.Add(Cfg.Lista.TableName)
                    For Each Dr As DataRow In Cfg.Lista.Rows
                        valueList.ValueListItems.Add(Dr(IdentColumn.Key), Dr(IdentColumn.Des).ToString)
                    Next
                    Dim column As UltraGridColumn = m_oGrid.DisplayLayout.Bands(Cfg.Band).Columns(Cfg.Name)
                    column.ValueList = valueList
                    column.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate
                End If
            End If
        Next
    End Sub
#Region "Handlers Grid"
    Private Sub m_oGrid_AfterRowInsert(sender As Object, e As RowEventArgs) Handles m_oGrid.AfterRowInsert
        For Each oCell As UltraGridCell In e.Row.Cells
            If ConfigCol.Exists(Function(x) x.Name = oCell.Column.Key) Then
                Dim oValor As Object = ConfigCol.Find(Function(x) x.Name = oCell.Column.Key).ValorDefault
                If Not oValor Is Nothing Then
                    oCell.Value = oValor
                End If
            End If
        Next
    End Sub
    Private Sub m_oGrid_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles m_oGrid.AfterRowUpdate
        If e.Row.Cells.Exists("ModifiUserID") Then
            e.Row.Cells("ModifiUserID").Value = oUsr.UserID
            e.Row.Cells("ModifiDate").Value = Now()
        End If
    End Sub

    Private Sub m_oGrid_AfterSelectChange(sender As Object, e As AfterSelectChangeEventArgs) Handles m_oGrid.AfterSelectChange
        If sender.Selected.Rows.Count > 0 Then
            Dim rowSelected As UltraGridRow
            For Each rowSelected In sender.Selected.Rows
                MyRowSelected = rowSelected
                Exit For
            Next
        End If
    End Sub
#End Region 'Handlers Grid
#Region "Class"
    Public Class AttBanda
        Public Band As Short
        Public Name As String
        Public AddButtonCaption As String
        Public Hidden As Boolean
        Public AddNew As AllowAddNew

        Public Sub New(ByVal pBand As Short, ByVal pName As String, ByVal Optional pAddButtonCaption As String = "", ByVal Optional pHidden As Boolean = False, ByVal Optional pAddNew As AllowAddNew = AllowAddNew.No)
            Band = pBand
            Name = pName
            AddButtonCaption = pAddButtonCaption
            Hidden = pHidden
            AddNew = pAddNew
        End Sub
    End Class
    Public Class AttColumna
        Public Band As Short
        Public Name As String
        Public Header As String
        Public Activation As Activation
        Public Hidden As Boolean
        Public Width As Integer
        Public Lista As DataTable
        Public ValorDefault As Object

        Public Sub New(ByVal pBand As Short, ByVal pName As String, ByVal pHeader As String, ByVal Optional pActivation As Activation = Activation.AllowEdit, ByVal Optional pHidden As Boolean = False, ByVal Optional pWidth As Integer = 0, ByVal Optional pLista As DataTable = Nothing, ByVal Optional pValorDefault As Object = Nothing)
            Band = pBand
            Name = pName
            Header = pHeader
            Activation = pActivation
            Hidden = pHidden
            Width = pWidth
            Lista = pLista
            ValorDefault = pValorDefault
        End Sub
    End Class
#End Region 'Class
#Region "Enumerations"
    Private Enum IdentColumn
        Key = 0
        Des = 1
    End Enum
#End Region 'Enumerations

End Class
