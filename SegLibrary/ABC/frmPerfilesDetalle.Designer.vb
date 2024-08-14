<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfilesDetalle
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
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbar1")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("btnGuardar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("btnGuardar")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPerfilesDetalle))
        Dim Override1 As Infragistics.Win.UltraWinTree.Override = New Infragistics.Win.UltraWinTree.Override()
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me.frmPerfilesDetalle_Fill_Panel = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraTree1 = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.UltraStatusBar1 = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar()
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.InboxControlStyler1 = New Infragistics.Win.AppStyling.Runtime.InboxControlStyler(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmPerfilesDetalle_Fill_Panel.ClientArea.SuspendLayout()
        Me.frmPerfilesDetalle_Fill_Panel.SuspendLayout()
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraStatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InboxControlStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 0
        UltraToolbar2.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1})
        UltraToolbar2.Text = "UltraToolbar1"
        Me.UltraToolbarsManager1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar2})
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        ButtonTool2.SharedPropsInternal.AppearancesSmall.Appearance = Appearance2
        ButtonTool2.SharedPropsInternal.Caption = "Guardar"
        ButtonTool2.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool2})
        '
        'frmPerfilesDetalle_Fill_Panel
        '
        '
        'frmPerfilesDetalle_Fill_Panel.ClientArea
        '
        Me.frmPerfilesDetalle_Fill_Panel.ClientArea.Controls.Add(Me.UltraTree1)
        Me.frmPerfilesDetalle_Fill_Panel.ClientArea.Controls.Add(Me.UltraStatusBar1)
        Me.frmPerfilesDetalle_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.frmPerfilesDetalle_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmPerfilesDetalle_Fill_Panel.Location = New System.Drawing.Point(0, 25)
        Me.frmPerfilesDetalle_Fill_Panel.Name = "frmPerfilesDetalle_Fill_Panel"
        Me.frmPerfilesDetalle_Fill_Panel.Size = New System.Drawing.Size(703, 568)
        Me.frmPerfilesDetalle_Fill_Panel.TabIndex = 0
        '
        'UltraTree1
        '
        Me.UltraTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTree1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTree1.Name = "UltraTree1"
        Override1.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.SynchronizedCheckBox
        Me.UltraTree1.Override = Override1
        Me.UltraTree1.Size = New System.Drawing.Size(703, 545)
        Me.UltraTree1.TabIndex = 1
        '
        'UltraStatusBar1
        '
        Me.UltraStatusBar1.Location = New System.Drawing.Point(0, 545)
        Me.UltraStatusBar1.Name = "UltraStatusBar1"
        Me.UltraStatusBar1.Size = New System.Drawing.Size(703, 23)
        Me.UltraStatusBar1.TabIndex = 0
        Me.UltraStatusBar1.Text = "UltraStatusBar1"
        '
        '_frmPerfilesDetalle_Toolbars_Dock_Area_Left
        '
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 25)
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Left.Name = "_frmPerfilesDetalle_Toolbars_Dock_Area_Left"
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 568)
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmPerfilesDetalle_Toolbars_Dock_Area_Right
        '
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(703, 25)
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Right.Name = "_frmPerfilesDetalle_Toolbars_Dock_Area_Right"
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 568)
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmPerfilesDetalle_Toolbars_Dock_Area_Top
        '
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Top.Name = "_frmPerfilesDetalle_Toolbars_Dock_Area_Top"
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(703, 25)
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmPerfilesDetalle_Toolbars_Dock_Area_Bottom
        '
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 593)
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Bottom.Name = "_frmPerfilesDetalle_Toolbars_Dock_Area_Bottom"
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(703, 0)
        Me._frmPerfilesDetalle_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cubes.png")
        Me.ImageList1.Images.SetKeyName(1, "settings.png")
        Me.ImageList1.Images.SetKeyName(2, "proteger.png")
        '
        'frmPerfilesDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 593)
        Me.Controls.Add(Me.frmPerfilesDetalle_Fill_Panel)
        Me.Controls.Add(Me._frmPerfilesDetalle_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmPerfilesDetalle_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmPerfilesDetalle_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._frmPerfilesDetalle_Toolbars_Dock_Area_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPerfilesDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.InboxControlStyler1.SetStyleSettings(Me, New Infragistics.Win.AppStyling.Runtime.InboxControlStyleSettings(Infragistics.Win.DefaultableBoolean.[Default]))
        Me.Text = "frmPerfilesDetalle"
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmPerfilesDetalle_Fill_Panel.ClientArea.ResumeLayout(False)
        Me.frmPerfilesDetalle_Fill_Panel.ResumeLayout(False)
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraStatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InboxControlStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents frmPerfilesDetalle_Fill_Panel As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraStatusBar1 As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Friend WithEvents _frmPerfilesDetalle_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmPerfilesDetalle_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmPerfilesDetalle_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmPerfilesDetalle_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents InboxControlStyler1 As Infragistics.Win.AppStyling.Runtime.InboxControlStyler
    Friend WithEvents UltraTree1 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
End Class
