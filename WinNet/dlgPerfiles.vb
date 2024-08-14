Imports Security_System
Imports System.Windows.Forms

Public Class dlgPerfiles
    Private Sub dlgPerfiles_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadPerfiles()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        oUsr.Perfil = cmbPerfiles.SelectedValue
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#Region "Methods"
    Private Sub LoadPerfiles()
        Dim oSQL As New SQLSeguridades(oUsr)
        Dim oCs As New ColeccionPrmSql
        Try
            Try
                oCs.Create("@SgUserID", oUsr.UserID)
                oCs.Create("@PlataformaID", 2) '2 = Windows
                Dim oTb As DataTable = oSQL._Lista(oSQL.QryPerfiles, "Perfiles", oCs)
                LoadCombo(cmbPerfiles, oTb.DefaultView)
                GetIndex(cmbPerfiles, 0, oUsr.Perfil)
            Catch ex As Exception
                Dim s As String = ex.Message
            End Try

        Catch ex As Exception
            Dim Err As String = ex.Message
        End Try
    End Sub
#End Region 'Methods
End Class
