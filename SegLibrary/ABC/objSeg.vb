Imports Security_System
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class objSeg
    Public Sub AddItemValueList(ByVal Grid As UltraGrid, ByVal Key As String, ByVal oTb As DataTable, ByVal Id As String, ByVal Des As String, ByVal Banda As Int32, ByVal Columna As String)
        Try
            If Grid.DisplayLayout.ValueLists.Exists(Key) Then
                Exit Sub
            End If
            If Not oTb Is Nothing Then
                Dim valueList As ValueList = Grid.DisplayLayout.ValueLists.Add("Key")
                For Each Dr As DataRow In oTb.Rows
                    valueList.ValueListItems.Add(Dr(Id), Dr(Des).ToString)
                Next
                Dim column As UltraGridColumn = Grid.DisplayLayout.Bands(Banda).Columns(Columna)
                column.ValueList = valueList
                column.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate
            End If

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub

End Class
Public Class AdmUGrid
    Public Sub AddItemValueList(ByVal Grid As UltraGrid, ByVal Key As String, ByVal oTb As DataTable, ByVal Id As String, ByVal Des As String, ByVal Banda As Int32, ByVal Columna As String)
        Try
            If Grid.DisplayLayout.ValueLists.Exists(Key) Then
                Exit Sub
            End If
            If Not oTb Is Nothing Then
                Dim valueList As ValueList = Grid.DisplayLayout.ValueLists.Add("Key")
                For Each Dr As DataRow In oTb.Rows
                    valueList.ValueListItems.Add(Dr(Id), Dr(Des).ToString)
                Next
                Dim column As UltraGridColumn = Grid.DisplayLayout.Bands(Banda).Columns(Columna)
                column.ValueList = valueList
                column.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate
            End If

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
End Class