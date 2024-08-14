<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgChangePassword
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAnterior = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNueva = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtConfirma = New System.Windows.Forms.TextBox()
        Me.InboxControlStyler1 = New Infragistics.Win.AppStyling.Runtime.InboxControlStyler(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.InboxControlStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(261, 219)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.InboxControlStyler1.SetStyleSettings(Me.TableLayoutPanel1, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.InboxControlStyler1.SetStyleSettings(Me.OK_Button, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.InboxControlStyler1.SetStyleSettings(Me.Cancel_Button, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAnterior)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 53)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox1, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contraseña Anterior"
        '
        'txtAnterior
        '
        Me.txtAnterior.Location = New System.Drawing.Point(16, 21)
        Me.txtAnterior.Name = "txtAnterior"
        Me.txtAnterior.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAnterior.Size = New System.Drawing.Size(342, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtAnterior, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtAnterior.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNueva)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 53)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox2, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contraseña Nueva"
        '
        'txtNueva
        '
        Me.txtNueva.Location = New System.Drawing.Point(16, 20)
        Me.txtNueva.Name = "txtNueva"
        Me.txtNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNueva.Size = New System.Drawing.Size(342, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtNueva, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtNueva.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtConfirma)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(375, 53)
        Me.InboxControlStyler1.SetStyleSettings(Me.GroupBox3, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Confirmar Contraseña"
        '
        'txtConfirma
        '
        Me.txtConfirma.Location = New System.Drawing.Point(16, 21)
        Me.txtConfirma.Name = "txtConfirma"
        Me.txtConfirma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirma.Size = New System.Drawing.Size(342, 20)
        Me.InboxControlStyler1.SetStyleSettings(Me.txtConfirma, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.txtConfirma.TabIndex = 1
        '
        'dlgChangePassword
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(419, 260)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgChangePassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.InboxControlStyler1.SetStyleSettings(Me, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.Text = "Cambio de contraseña"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.InboxControlStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents txtAnterior As Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents txtNueva As Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents txtConfirma As Windows.Forms.TextBox
    Friend WithEvents InboxControlStyler1 As Infragistics.Win.AppStyling.Runtime.InboxControlStyler
End Class
