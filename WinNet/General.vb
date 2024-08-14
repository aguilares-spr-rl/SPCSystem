Imports Security_System
Imports System.Data.SqlClient
Module General
    Public oUsr As New MySession
    Public oCnx As SqlConnection
    Public Sub LoadCombo(ByVal oCmbx As ComboBox, ByVal View As DataView)
        Try
            With oCmbx
                .DataSource = View
                .ValueMember = View.Table.Columns(0).ColumnName
                .DisplayMember = View.Table.Columns(1).ColumnName
                .SelectedIndex = -1
            End With
        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
    Public Sub LoadCombo(ByVal oListCmbx As ToolStripComboBox, ByVal View As DataView)
        Try
            With oListCmbx.ComboBox
                .DataSource = View
                .ValueMember = View.Table.Columns(0).ColumnName
                .DisplayMember = View.Table.Columns(1).ColumnName
                .SelectedIndex = -1
            End With
        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
    Public Sub GetIndex(ByRef oCB As ComboBox, ByVal iTem As Integer, ByVal Val As Object)
        Try
            oCB.SelectedIndex = 0
            For Each NextItem As DataRowView In oCB.Items
                If NextItem.Item(iTem).ToString = Val Then
                    oCB.SelectedItem = NextItem
                    Exit For
                End If
            Next
        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)

        End Try
    End Sub

End Module
Enum DataSourceAux
    Portal = 0
    Uerp = 1
End Enum