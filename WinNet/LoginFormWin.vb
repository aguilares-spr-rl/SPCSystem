Imports Security_System
Public Class LoginFormWin

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    'Private oUsr As New MySession

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Static iIntentos As Integer
        If oUsr.UserName = "" Then
            MsgBox("El usuario es un dato requerido", MsgBoxStyle.Information, "AVISO")
            Exit Sub
        End If
        If Login_in() Then
            oUsr.UserLogin = True
        Else
            iIntentos += 1
            If iIntentos < 3 Then
                MsgBox("Ínformación de ususario incorrecta", vbInformation, "AVISO")
                Exit Sub
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        oUsr.UserLogin = False
        Me.Close()
    End Sub

#Region "Metodos"
    Private Function Login_in() As Boolean
        Dim oSQL As New SQLSeguridades(oUsr)
        Dim oCs As New ColeccionPrmSql
        Login_in = False
        Try
            oCs.Create("@SgUserName", oUsr.UserName)
            oCs.Create("@SgUserPasswd", Seguridad.Encriptar(oUsr.UserPasswd))
            oCs.Create("@PlataformaID", 1)
            Dim oTb As DataTable = oSQL._Item(oSQL.QryCredenciales, "Credenciales", oCs)
            If Not oTb Is Nothing Then
                oUsr.Perfiles = oTb.Rows.Count
                For Each Dr As DataRow In oTb.Rows
                    oUsr.UserID = Dr("SgUserID").ToString
                    oUsr.Perfil = Dr("PerfilID").ToString
                    oUsr.PerfilNombre = Dr("PerfilNombre").ToString
                    Exit For
                Next
                Return (oUsr.UserID > 0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + ex.StackTrace + vbCrLf + ex.Source, MsgBoxStyle.Information, "ERROR EN LA APLICACIÓN")
            Return False
        End Try

    End Function

    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        oUsr.UserName = sender.text
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        oUsr.UserPasswd = sender.text
    End Sub

#End Region 'Metodos

End Class
