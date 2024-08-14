Imports System.Windows.Forms
Imports Security_System

Public Class dlgUsuario
    Public Property RegUsuario As Usuario
#Region "Eventos"
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Save() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetFormConfig()
    End Sub
#End Region 'Eventos
#Region "Metodos"
    Private Function Save() As Boolean
        Dim oSql As New SgUsuarios(oUsr)
        Save = False
        Try
            'Validaciones
            If txtSgUserPasswd.Text <> txtSgUserPasswdConfirm.Text Then
                MsgBox("La confirmación del password no coincide", vbInformation, "WARNING")
                Exit Function
            End If
            'Actualización de cambios
            With RegUsuario
                .r.ItemValue("@SgUserPasswd") = Utilities.Encriptar(txtSgUserPasswd.Text)
                .r.ItemValue("@AspNetId") = txtAspNetId.Text
                .r.ItemValue("@ErpHost") = ErpHost.Text
                .r.ItemValue("@ErpUser") = ErpUser.Text
                .r.ItemValue("@ErpPasswd") = ErpPasswd.Text
            End With
            ' Guardar cambios
            Return RegUsuario.Save()

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Function
    Private Sub SetFormConfig()
        Try
            txtSgUserID.Enabled = False
            txtSgUserName.Enabled = False
            txtSgApellidos.Enabled = False
            txtSgUserAlta.Enabled = False
            txtSgUserEmail.Enabled = False
            If RegUsuario.r.ItemValue("@SgUserID") > 0 Then
                txtSgUserID.Text = RegUsuario.r.ItemValue("@SgUserID")
                txtSgUserName.Text = RegUsuario.r.ItemValue("@SgUserName")
                txtSgApellidos.Text = RegUsuario.r.ItemValue("@SgApellidos")
                txtSgUserAlta.Text = RegUsuario.r.ItemValue("@SgUserAlta")
                txtSgUserEmail.Text = RegUsuario.r.ItemValue("@SgUserEmail")
                txtSgUserPasswd.Text = Utilities.DesEncriptar(RegUsuario.r.ItemValue("@SgUserPasswd"))
                txtSgUserPasswdConfirm.Text = Utilities.DesEncriptar(RegUsuario.r.ItemValue("@SgUserPasswd"))
                txtAspNetId.Text = RegUsuario.r.ItemValue("@SgNombre")
                ErpHost.Text = RegUsuario.r.ItemValue("@ErpHost")
                ErpUser.Text = RegUsuario.r.ItemValue("@SgUserName")
                ErpPasswd.Text = RegUsuario.r.ItemValue("@ErpPasswd")
            End If

        Catch ex As Exception
            Tools.AddErrorLog(oUsr.App.Log, ex)
        End Try
    End Sub
#End Region 'Metodos

End Class
