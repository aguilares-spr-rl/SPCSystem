Imports Security_System
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Module General
    Public oUsr As MySession
    Public Function Maneja_Error(oErr As Exception, Optional ByVal sRutina As String = "") As MsgBoxResult
        Dim sBody As String = String.Empty
        Dim sTitulo As String = String.Empty
        Maneja_Error = MsgBoxResult.Ignore

        Try
            sTitulo = "¡Condición Anormal!"
            sBody = "Rutina: " + sRutina & vbCrLf
            sBody += oErr.Message & vbCrLf
            sBody += oErr.Source

            Maneja_Error = MsgBox(sBody, MsgBoxStyle.AbortRetryIgnore, sTitulo)

        Catch ex As Exception
            MsgBox("ERROR | ERROR", MsgBoxStyle.Critical, "MANEJA ERROR")

        End Try

    End Function
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
Class Utilities
    Public Shared Function Encriptar(ByVal _cadenaAencriptar As String) As String
        Encriptar = String.Empty
        Try
            Dim encryted As Byte() = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar)
            Encriptar = Convert.ToBase64String(encryted)
        Catch ex As Exception
            Dim s As String = ex.Message
        End Try
    End Function

    Public Shared Function DesEncriptar(ByVal _cadenaAdesencriptar As String) As String
        DesEncriptar = String.Empty
        Try
            Dim decryted As Byte() = Convert.FromBase64String(_cadenaAdesencriptar)
            DesEncriptar = System.Text.Encoding.Unicode.GetString(decryted)
        Catch ex As Exception
            Dim s As String = ex.Message
        End Try
    End Function
End Class