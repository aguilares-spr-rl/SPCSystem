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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("SGSETTINGSC", -1)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGSettingcID")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGSettingcNombre")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_SGSETTINGSS_SGSETTINGSC")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("FK_SGSETTINGSS_SGSETTINGSC", 0)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGSettingsID")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGSettingsNombre")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGSettingcID")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_SGSETTINGS_SGSETTINGSS")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("FK_SGSETTINGS_SGSETTINGSS", 1)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGSettingID")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGSettingNombre")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGSettingsID")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGSettingValorTexto")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGSettingValorFecha")
        Me.SegDS = New SegLibrary.SegDS()
        Me.SGSETTINGSCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGSETTINGSCTableAdapter = New SegLibrary.SegDSTableAdapters.SGSETTINGSCTableAdapter()
        Me.TableAdapterManager = New SegLibrary.SegDSTableAdapters.TableAdapterManager()
        Me.SGSETTINGSSTableAdapter = New SegLibrary.SegDSTableAdapters.SGSETTINGSSTableAdapter()
        Me.SGSETTINGSTableAdapter = New SegLibrary.SegDSTableAdapters.SGSETTINGSTableAdapter()
        Me.SGSETTINGSCBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SGSETTINGSCBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SGSETTINGSCUltraGrid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.FKSGSETTINGSSSGSETTINGSCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKSGSETTINGSSGSETTINGSSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SegDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGSETTINGSCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGSETTINGSCBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SGSETTINGSCBindingNavigator.SuspendLayout()
        CType(Me.SGSETTINGSCUltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKSGSETTINGSSSGSETTINGSCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKSGSETTINGSSGSETTINGSSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SegDS
        '
        Me.SegDS.DataSetName = "SegDS"
        Me.SegDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SGSETTINGSCBindingSource
        '
        Me.SGSETTINGSCBindingSource.DataMember = "SGSETTINGSC"
        Me.SGSETTINGSCBindingSource.DataSource = Me.SegDS
        '
        'SGSETTINGSCTableAdapter
        '
        Me.SGSETTINGSCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NETUSRPERFILTableAdapter = Nothing
        Me.TableAdapterManager.SGESTRUCTURAMENUTableAdapter = Nothing
        Me.TableAdapterManager.SGESTRUCTURASM_DETALLETableAdapter = Nothing
        Me.TableAdapterManager.SGFUNCIONESMODULOTableAdapter = Nothing
        Me.TableAdapterManager.SGFUNCIONESTableAdapter = Nothing
        Me.TableAdapterManager.SGFUNCIONEVENTOSTableAdapter = Nothing
        Me.TableAdapterManager.SGMODULOSTableAdapter = Nothing
        Me.TableAdapterManager.SGPERFILESDETALLETableAdapter = Nothing
        Me.TableAdapterManager.SGPERFILESTableAdapter = Nothing
        Me.TableAdapterManager.SGPLATAFORMATableAdapter = Nothing
        Me.TableAdapterManager.SGSETTINGSCTableAdapter = Me.SGSETTINGSCTableAdapter
        Me.TableAdapterManager.SGSETTINGSSTableAdapter = Me.SGSETTINGSSTableAdapter
        Me.TableAdapterManager.SGSETTINGSTableAdapter = Me.SGSETTINGSTableAdapter
        Me.TableAdapterManager.SGUSRPERFILTableAdapter = Nothing
        Me.TableAdapterManager.SGUSUARIOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SegLibrary.SegDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SGSETTINGSSTableAdapter
        '
        Me.SGSETTINGSSTableAdapter.ClearBeforeFill = True
        '
        'SGSETTINGSTableAdapter
        '
        Me.SGSETTINGSTableAdapter.ClearBeforeFill = True
        '
        'SGSETTINGSCBindingNavigator
        '
        Me.SGSETTINGSCBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SGSETTINGSCBindingNavigator.BindingSource = Me.SGSETTINGSCBindingSource
        Me.SGSETTINGSCBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SGSETTINGSCBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SGSETTINGSCBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SGSETTINGSCBindingNavigatorSaveItem})
        Me.SGSETTINGSCBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SGSETTINGSCBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SGSETTINGSCBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SGSETTINGSCBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SGSETTINGSCBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SGSETTINGSCBindingNavigator.Name = "SGSETTINGSCBindingNavigator"
        Me.SGSETTINGSCBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SGSETTINGSCBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.SGSETTINGSCBindingNavigator.TabIndex = 0
        Me.SGSETTINGSCBindingNavigator.Text = "BindingNavigator1"
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
        'SGSETTINGSCBindingNavigatorSaveItem
        '
        Me.SGSETTINGSCBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SGSETTINGSCBindingNavigatorSaveItem.Image = CType(resources.GetObject("SGSETTINGSCBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SGSETTINGSCBindingNavigatorSaveItem.Name = "SGSETTINGSCBindingNavigatorSaveItem"
        Me.SGSETTINGSCBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SGSETTINGSCBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'SGSETTINGSCUltraGrid
        '
        Me.SGSETTINGSCUltraGrid.DataSource = Me.SGSETTINGSCBindingSource
        Me.SGSETTINGSCUltraGrid.DisplayLayout.AddNewBox.Hidden = False
        UltraGridBand1.AddButtonCaption = "CATEGORIA"
        UltraGridColumn25.Header.VisiblePosition = 0
        UltraGridColumn26.Header.VisiblePosition = 1
        UltraGridColumn27.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn25, UltraGridColumn26, UltraGridColumn27})
        UltraGridBand2.AddButtonCaption = "SUBCATEGORIA"
        UltraGridColumn28.Header.VisiblePosition = 0
        UltraGridColumn29.Header.VisiblePosition = 1
        UltraGridColumn30.Header.VisiblePosition = 2
        UltraGridColumn31.Header.VisiblePosition = 3
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31})
        UltraGridBand3.AddButtonCaption = "SETTING"
        UltraGridColumn32.Header.VisiblePosition = 0
        UltraGridColumn33.Header.VisiblePosition = 1
        UltraGridColumn34.Header.VisiblePosition = 2
        UltraGridColumn35.Header.VisiblePosition = 3
        UltraGridColumn36.Header.VisiblePosition = 4
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        Me.SGSETTINGSCUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.SGSETTINGSCUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.SGSETTINGSCUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.SGSETTINGSCUltraGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SGSETTINGSCUltraGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGSETTINGSCUltraGrid.Location = New System.Drawing.Point(0, 25)
        Me.SGSETTINGSCUltraGrid.Name = "SGSETTINGSCUltraGrid"
        Me.SGSETTINGSCUltraGrid.Size = New System.Drawing.Size(800, 425)
        Me.SGSETTINGSCUltraGrid.TabIndex = 1
        Me.SGSETTINGSCUltraGrid.Text = "UltraGrid1"
        '
        'FKSGSETTINGSSSGSETTINGSCBindingSource
        '
        Me.FKSGSETTINGSSSGSETTINGSCBindingSource.DataMember = "FK_SGSETTINGSS_SGSETTINGSC"
        Me.FKSGSETTINGSSSGSETTINGSCBindingSource.DataSource = Me.SGSETTINGSCBindingSource
        '
        'FKSGSETTINGSSGSETTINGSSBindingSource
        '
        Me.FKSGSETTINGSSGSETTINGSSBindingSource.DataMember = "FK_SGSETTINGS_SGSETTINGSS"
        Me.FKSGSETTINGSSGSETTINGSSBindingSource.DataSource = Me.FKSGSETTINGSSSGSETTINGSCBindingSource
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SGSETTINGSCUltraGrid)
        Me.Controls.Add(Me.SGSETTINGSCBindingNavigator)
        Me.Name = "frmSettings"
        Me.Text = "frmSettings"
        CType(Me.SegDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGSETTINGSCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGSETTINGSCBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SGSETTINGSCBindingNavigator.ResumeLayout(False)
        Me.SGSETTINGSCBindingNavigator.PerformLayout()
        CType(Me.SGSETTINGSCUltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKSGSETTINGSSSGSETTINGSCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKSGSETTINGSSGSETTINGSSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SegDS As SegDS
    Friend WithEvents SGSETTINGSCBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SGSETTINGSCTableAdapter As SegDSTableAdapters.SGSETTINGSCTableAdapter
    Friend WithEvents TableAdapterManager As SegDSTableAdapters.TableAdapterManager
    Friend WithEvents SGSETTINGSCBindingNavigator As Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents SGSETTINGSCBindingNavigatorSaveItem As Windows.Forms.ToolStripButton
    Friend WithEvents SGSETTINGSCUltraGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents SGSETTINGSSTableAdapter As SegDSTableAdapters.SGSETTINGSSTableAdapter
    Friend WithEvents FKSGSETTINGSSSGSETTINGSCBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SGSETTINGSTableAdapter As SegDSTableAdapters.SGSETTINGSTableAdapter
    Friend WithEvents FKSGSETTINGSSGSETTINGSSBindingSource As Windows.Forms.BindingSource
End Class
