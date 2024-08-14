<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("SETTINGS", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SettingID")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SettingNombre")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SettingClasifica")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISETTINGSITEMS1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ISETTINGSITEMS1", 0)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SettingItemID")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SettingItemValor")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SettingID")
        Me.DSSettings = New WinNet.DSSettings()
        Me.SETTINGSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SETTINGSTableAdapter = New WinNet.DSSettingsTableAdapters.SETTINGSTableAdapter()
        Me.TableAdapterManager = New WinNet.DSSettingsTableAdapters.TableAdapterManager()
        Me.SETTINGSITEMSTableAdapter = New WinNet.DSSettingsTableAdapters.SETTINGSITEMSTableAdapter()
        Me.SETTINGSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SETTINGSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SETTINGSUltraGrid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ISETTINGSITEMS1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DSSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SETTINGSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SETTINGSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SETTINGSBindingNavigator.SuspendLayout()
        CType(Me.SETTINGSUltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISETTINGSITEMS1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DSSettings
        '
        Me.DSSettings.DataSetName = "DSSettings"
        Me.DSSettings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SETTINGSBindingSource
        '
        Me.SETTINGSBindingSource.DataMember = "SETTINGS"
        Me.SETTINGSBindingSource.DataSource = Me.DSSettings
        '
        'SETTINGSTableAdapter
        '
        Me.SETTINGSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SETTINGSITEMSTableAdapter = Me.SETTINGSITEMSTableAdapter
        Me.TableAdapterManager.SETTINGSTableAdapter = Me.SETTINGSTableAdapter
        Me.TableAdapterManager.UpdateOrder = WinNet.DSSettingsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SETTINGSITEMSTableAdapter
        '
        Me.SETTINGSITEMSTableAdapter.ClearBeforeFill = True
        '
        'SETTINGSBindingNavigator
        '
        Me.SETTINGSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SETTINGSBindingNavigator.BindingSource = Me.SETTINGSBindingSource
        Me.SETTINGSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SETTINGSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SETTINGSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SETTINGSBindingNavigatorSaveItem})
        Me.SETTINGSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SETTINGSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SETTINGSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SETTINGSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SETTINGSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SETTINGSBindingNavigator.Name = "SETTINGSBindingNavigator"
        Me.SETTINGSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SETTINGSBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.SETTINGSBindingNavigator.TabIndex = 0
        Me.SETTINGSBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SETTINGSBindingNavigatorSaveItem
        '
        Me.SETTINGSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SETTINGSBindingNavigatorSaveItem.Image = CType(resources.GetObject("SETTINGSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SETTINGSBindingNavigatorSaveItem.Name = "SETTINGSBindingNavigatorSaveItem"
        Me.SETTINGSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SETTINGSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'SETTINGSUltraGrid
        '
        Me.SETTINGSUltraGrid.DataSource = Me.SETTINGSBindingSource
        Me.SETTINGSUltraGrid.DisplayLayout.AddNewBox.Hidden = False
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand2.AddButtonCaption = "ITEMS"
        UltraGridBand2.CardView = True
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn15.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.SETTINGSUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.SETTINGSUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.SETTINGSUltraGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SETTINGSUltraGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SETTINGSUltraGrid.Location = New System.Drawing.Point(0, 25)
        Me.SETTINGSUltraGrid.Name = "SETTINGSUltraGrid"
        Me.SETTINGSUltraGrid.Size = New System.Drawing.Size(800, 425)
        Me.SETTINGSUltraGrid.TabIndex = 1
        Me.SETTINGSUltraGrid.Text = "UltraGrid1"
        '
        'ISETTINGSITEMS1BindingSource
        '
        Me.ISETTINGSITEMS1BindingSource.DataMember = "ISETTINGSITEMS1"
        Me.ISETTINGSITEMS1BindingSource.DataSource = Me.SETTINGSBindingSource
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SETTINGSUltraGrid)
        Me.Controls.Add(Me.SETTINGSBindingNavigator)
        Me.Name = "frmSettings"
        Me.Text = "frmSettings"
        CType(Me.DSSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SETTINGSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SETTINGSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SETTINGSBindingNavigator.ResumeLayout(False)
        Me.SETTINGSBindingNavigator.PerformLayout()
        CType(Me.SETTINGSUltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISETTINGSITEMS1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSSettings As DSSettings
    Friend WithEvents SETTINGSBindingSource As BindingSource
    Friend WithEvents SETTINGSTableAdapter As DSSettingsTableAdapters.SETTINGSTableAdapter
    Friend WithEvents TableAdapterManager As DSSettingsTableAdapters.TableAdapterManager
    Friend WithEvents SETTINGSBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SETTINGSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SETTINGSUltraGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents SETTINGSITEMSTableAdapter As DSSettingsTableAdapters.SETTINGSITEMSTableAdapter
    Friend WithEvents ISETTINGSITEMS1BindingSource As BindingSource
End Class
