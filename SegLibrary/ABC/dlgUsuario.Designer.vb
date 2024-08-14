<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgUsuario))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.InboxControlStyler1 = New Infragistics.Win.AppStyling.Runtime.InboxControlStyler(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtSgUserPasswdConfirm = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtSgUserPasswd = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtAspNetId = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtSgUserAlta = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtSgUserEmail = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSgApellidos = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSgUserName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSgUserID = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.ErpHost = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.ErpPasswd = New System.Windows.Forms.TextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.ErpUser = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.InboxControlStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(531, 311)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 37)
        Me.InboxControlStyler1.SetStyleSettings(Me.TableLayoutPanel1, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 30)
        Me.InboxControlStyler1.SetStyleSettings(Me.OK_Button, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = CType(resources.GetObject("Cancel_Button.Image"), System.Drawing.Image)
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 30)
        Me.InboxControlStyler1.SetStyleSettings(Me.Cancel_Button, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(675, 298)
        Me.InboxControlStyler1.SetStyleSettings(Me.TabControl1, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(667, 272)
        Me.InboxControlStyler1.SetStyleSettings(Me.TabPage1, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 238)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox1, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtSgUserPasswdConfirm)
        Me.GroupBox8.Location = New System.Drawing.Point(325, 180)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(247, 45)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox8, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Confirmar Password"
        '
        'txtSgUserPasswdConfirm
        '
        Me.txtSgUserPasswdConfirm.Location = New System.Drawing.Point(7, 16)
        Me.txtSgUserPasswdConfirm.Name = "txtSgUserPasswdConfirm"
        Me.txtSgUserPasswdConfirm.Size = New System.Drawing.Size(226, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtSgUserPasswdConfirm, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtSgUserPasswdConfirm.TabIndex = 0
        Me.txtSgUserPasswdConfirm.UseSystemPasswordChar = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtSgUserPasswd)
        Me.GroupBox9.Location = New System.Drawing.Point(80, 180)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(237, 45)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox9, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Password"
        '
        'txtSgUserPasswd
        '
        Me.txtSgUserPasswd.Location = New System.Drawing.Point(7, 16)
        Me.txtSgUserPasswd.Name = "txtSgUserPasswd"
        Me.txtSgUserPasswd.Size = New System.Drawing.Size(220, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtSgUserPasswd, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtSgUserPasswd.TabIndex = 0
        Me.txtSgUserPasswd.UseSystemPasswordChar = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtAspNetId)
        Me.GroupBox7.Location = New System.Drawing.Point(325, 28)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(247, 45)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox7, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Nombres"
        '
        'txtAspNetId
        '
        Me.txtAspNetId.Location = New System.Drawing.Point(13, 16)
        Me.txtAspNetId.Name = "txtAspNetId"
        Me.txtAspNetId.Size = New System.Drawing.Size(220, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtAspNetId, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtAspNetId.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtSgUserAlta)
        Me.GroupBox6.Location = New System.Drawing.Point(80, 81)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(237, 45)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox6, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Alta"
        '
        'txtSgUserAlta
        '
        Me.txtSgUserAlta.Location = New System.Drawing.Point(7, 16)
        Me.txtSgUserAlta.Name = "txtSgUserAlta"
        Me.txtSgUserAlta.Size = New System.Drawing.Size(220, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtSgUserAlta, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtSgUserAlta.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtSgUserEmail)
        Me.GroupBox5.Location = New System.Drawing.Point(80, 131)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(492, 45)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox5, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Email"
        '
        'txtSgUserEmail
        '
        Me.txtSgUserEmail.Location = New System.Drawing.Point(7, 16)
        Me.txtSgUserEmail.Name = "txtSgUserEmail"
        Me.txtSgUserEmail.Size = New System.Drawing.Size(471, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtSgUserEmail, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtSgUserEmail.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSgApellidos)
        Me.GroupBox4.Location = New System.Drawing.Point(325, 81)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(247, 45)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox4, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Apellidos"
        '
        'txtSgApellidos
        '
        Me.txtSgApellidos.Location = New System.Drawing.Point(13, 16)
        Me.txtSgApellidos.Name = "txtSgApellidos"
        Me.txtSgApellidos.Size = New System.Drawing.Size(220, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtSgApellidos, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtSgApellidos.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSgUserName)
        Me.GroupBox3.Location = New System.Drawing.Point(80, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(237, 45)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox3, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Usuario"
        '
        'txtSgUserName
        '
        Me.txtSgUserName.Location = New System.Drawing.Point(7, 16)
        Me.txtSgUserName.Name = "txtSgUserName"
        Me.txtSgUserName.Size = New System.Drawing.Size(220, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtSgUserName, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtSgUserName.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSgUserID)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(65, 45)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox2, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ID"
        '
        'txtSgUserID
        '
        Me.txtSgUserID.Location = New System.Drawing.Point(7, 16)
        Me.txtSgUserID.Name = "txtSgUserID"
        Me.txtSgUserID.Size = New System.Drawing.Size(51, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtSgUserID, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtSgUserID.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox12)
        Me.TabPage2.Controls.Add(Me.GroupBox10)
        Me.TabPage2.Controls.Add(Me.GroupBox11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(667, 272)
        Me.InboxControlStyler1.SetStyleSettings(Me.TabPage2, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ERP"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 61)
        Me.InboxControlStyler1.SetStyleSettings(Me.PictureBox1, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.ErpHost)
        Me.GroupBox10.Location = New System.Drawing.Point(492, 18)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(153, 44)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox10, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox10.TabIndex = 12
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "HostName"
        '
        'ErpHost
        '
        Me.ErpHost.Location = New System.Drawing.Point(11, 15)
        Me.ErpHost.Name = "ErpHost"
        Me.ErpHost.Size = New System.Drawing.Size(134, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.ErpHost, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.ErpHost.TabIndex = 1
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.ErpPasswd)
        Me.GroupBox11.Location = New System.Drawing.Point(214, 80)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(271, 44)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox11, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox11.TabIndex = 11
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Contraseña ERP"
        '
        'ErpPasswd
        '
        Me.ErpPasswd.Location = New System.Drawing.Point(11, 15)
        Me.ErpPasswd.Name = "ErpPasswd"
        Me.ErpPasswd.Size = New System.Drawing.Size(250, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.ErpPasswd, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.ErpPasswd.TabIndex = 1
        Me.ErpPasswd.UseSystemPasswordChar = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.ErpUser)
        Me.GroupBox12.Location = New System.Drawing.Point(214, 18)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(271, 44)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox12, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox12.TabIndex = 13
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Usuario ERP"
        '
        'ErpUser
        '
        Me.ErpUser.Location = New System.Drawing.Point(11, 15)
        Me.ErpUser.Name = "ErpUser"
        Me.ErpUser.Size = New System.Drawing.Size(250, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.ErpUser, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.ErpUser.TabIndex = 1
        '
        'dlgUsuario
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(689, 360)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUsuario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.InboxControlStyler1.SetStyleSettings(Me, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.Text = "dlgUsuario"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.InboxControlStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents InboxControlStyler1 As Infragistics.Win.AppStyling.Runtime.InboxControlStyler
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As Windows.Forms.GroupBox
    Friend WithEvents txtSgUserPasswdConfirm As Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As Windows.Forms.GroupBox
    Friend WithEvents txtSgUserPasswd As Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
    Friend WithEvents txtAspNetId As Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents txtSgUserAlta As Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents txtSgUserEmail As Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents txtSgApellidos As Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents txtSgUserName As Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents txtSgUserID As Windows.Forms.TextBox
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents GroupBox12 As Windows.Forms.GroupBox
    Friend WithEvents ErpUser As Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As Windows.Forms.GroupBox
    Friend WithEvents ErpHost As Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As Windows.Forms.GroupBox
    Friend WithEvents ErpPasswd As Windows.Forms.TextBox
End Class
