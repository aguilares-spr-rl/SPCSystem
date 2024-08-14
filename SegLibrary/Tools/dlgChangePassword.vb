Imports System.Windows.Forms
Imports Security_System

Public Class dlgChangePassword
    Public Property OUsr As New MySession
#Region "Eventos"
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Change() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region 'Eventos
#Region "Metodos"
    Private Sub SetFormConfig()
        Try
            txtAnterior.Text = ""
            txtNueva.Text = ""
            txtConfirma.Text = ""
        Catch ex As Exception
            Dim sErr As String = ex.Message
        End Try
    End Sub
    Private Function Change() As Boolean
        Dim oSql As New SgUsuarios(OUsr)
        Dim oCs As New ColeccionPrmSql
        Change = False
        Try
            If txtNueva.Text = "" Then
                MsgBox("La contraseña nueva es un dato requerido.", MsgBoxStyle.Information, "Omisión de captura")
                txtNueva.Select()
                Exit Function
            End If
            If txtConfirma.Text = "" Then
                MsgBox("Confirme la contraseña nueva.", MsgBoxStyle.Information, "Omisión de captura")
                txtConfirma.Select()
                Exit Function
            End If
            If txtNueva.Text <> txtConfirma.Text Then
                MsgBox("La contraseña de Usuario no coincide con el de Confirmación.", MsgBoxStyle.Information, "Error de captura")
                txtNueva.Select()
                Exit Function
            End If

            oCs.Create("@SgUserID", OUsr.UserID)
            Dim oTb As DataTable = oSql._Lista(oSql.Item, "USER", oCs)
            If Not oTb Is Nothing Then
                For Each Dr As DataRow In oTb.Rows
                    If Dr("SgUserPasswd").ToString <> "" Then
                        If txtAnterior.Text = "" Then
                            MsgBox("La contraseña anterior es un dato requerido.", MsgBoxStyle.Information, "Omisión de captura")
                            txtAnterior.Select()
                            Exit Function
                        End If
                    End If

                    If Trim(txtAnterior.Text) <> "" Then
                        If Trim(Seguridad.DesEncriptar(Dr("SgUserPasswd"))) <> Trim(txtAnterior.Text) Then
                            MsgBox("Contraseña anterior erróneo. Vuelva a intentar.", MsgBoxStyle.Information, "Error de captura")
                            txtAnterior.Select()
                            Exit Function
                        End If
                    End If
                Next
            End If

            oCs.Create("@SgUserPasswd", Seguridad.Encriptar(txtNueva.Text))
            Return oSql.ExecuteQry(oSql.UpdPass, oCs)

        Catch ex As Exception
            Dim sErr As String = ex.Message
        End Try
    End Function

#End Region 'Metodos

End Class
