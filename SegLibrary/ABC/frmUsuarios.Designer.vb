<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("SGUSUARIOS", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgUserID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgUserName")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgUserEmail")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgUserPasswd")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgNombre")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgApellidos")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgUserAlta")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaUserID")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaDate")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiUserID")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiDate")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgActivo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISGUSRPERFIL2")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ISGUSRPERFIL2", 0)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgUsrPerfilID")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgUserID")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilID")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaUserID")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaDate")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiUserID")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiDate")
        Dim RibbonTab1 As Infragistics.Win.UltraWinToolbars.RibbonTab = New Infragistics.Win.UltraWinToolbars.RibbonTab("Usuarios")
        Dim RibbonGroup1 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("UsrReg")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.SGUSUARIOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.SGUSUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SegDS = New SegLibrary.SegDS()
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
        Me.SGUSUARIOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SGUSUARIOSUltraGrid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._frmUsuarios_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmUsuarios_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmUsuarios_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmUsuarios_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.ISGUSRPERFIL2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGUSUARIOSTableAdapter = New SegLibrary.SegDSTableAdapters.SGUSUARIOSTableAdapter()
        Me.TableAdapterManager = New SegLibrary.SegDSTableAdapters.TableAdapterManager()
        Me.SGUSRPERFILTableAdapter = New SegLibrary.SegDSTableAdapters.SGUSRPERFILTableAdapter()
        CType(Me.SGUSUARIOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SGUSUARIOSBindingNavigator.SuspendLayout()
        CType(Me.SGUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGUSUARIOSUltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISGUSRPERFIL2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SGUSUARIOSBindingNavigator
        '
        Me.SGUSUARIOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SGUSUARIOSBindingNavigator.BindingSource = Me.SGUSUARIOSBindingSource
        Me.SGUSUARIOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SGUSUARIOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SGUSUARIOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SGUSUARIOSBindingNavigatorSaveItem})
        Me.SGUSUARIOSBindingNavigator.Location = New System.Drawing.Point(0, 162)
        Me.SGUSUARIOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SGUSUARIOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SGUSUARIOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SGUSUARIOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SGUSUARIOSBindingNavigator.Name = "SGUSUARIOSBindingNavigator"
        Me.SGUSUARIOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SGUSUARIOSBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.SGUSUARIOSBindingNavigator.TabIndex = 0
        Me.SGUSUARIOSBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'SGUSUARIOSBindingSource
        '
        Me.SGUSUARIOSBindingSource.DataMember = "SGUSUARIOS"
        Me.SGUSUARIOSBindingSource.DataSource = Me.SegDS
        '
        'SegDS
        '
        Me.SegDS.DataSetName = "SegDS"
        Me.SegDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'SGUSUARIOSBindingNavigatorSaveItem
        '
        Me.SGUSUARIOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SGUSUARIOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("SGUSUARIOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SGUSUARIOSBindingNavigatorSaveItem.Name = "SGUSUARIOSBindingNavigatorSaveItem"
        Me.SGUSUARIOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SGUSUARIOSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'SGUSUARIOSUltraGrid
        '
        Me.SGUSUARIOSUltraGrid.DataSource = Me.SGUSUARIOSBindingSource
        Me.SGUSUARIOSUltraGrid.DisplayLayout.AddNewBox.Hidden = False
        UltraGridBand1.AddButtonCaption = "USUARIOS"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn14.Header.VisiblePosition = 11
        UltraGridColumn15.Header.VisiblePosition = 12
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn14, UltraGridColumn15})
        UltraGridBand2.AddButtonCaption = "PERFILES"
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 2
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        Me.SGUSUARIOSUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.SGUSUARIOSUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.SGUSUARIOSUltraGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SGUSUARIOSUltraGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGUSUARIOSUltraGrid.Location = New System.Drawing.Point(8, 187)
        Me.SGUSUARIOSUltraGrid.Name = "SGUSUARIOSUltraGrid"
        Me.SGUSUARIOSUltraGrid.Size = New System.Drawing.Size(784, 266)
        Me.SGUSUARIOSUltraGrid.TabIndex = 1
        Me.SGUSUARIOSUltraGrid.Text = "UltraGrid1"
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        RibbonTab1.Caption = "Usuarios"
        RibbonGroup1.Caption = "ACTIONS"
        RibbonGroup1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3})
        RibbonTab1.Groups.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonGroup() {RibbonGroup1})
        Me.UltraToolbarsManager1.Ribbon.NonInheritedRibbonTabs.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonTab() {RibbonTab1})
        Me.UltraToolbarsManager1.Ribbon.Visible = True
        Me.UltraToolbarsManager1.ShowFullMenusDelay = 500
        Me.UltraToolbarsManager1.ToolbarSettings.UseLargeImages = Infragistics.Win.DefaultableBoolean.[True]
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        ButtonTool4.SharedPropsInternal.AppearancesLarge.Appearance = Appearance1
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance2
        ButtonTool4.SharedPropsInternal.Caption = "Editar"
        ButtonTool4.SharedPropsInternal.Category = "Archivo"
        ButtonTool4.SharedPropsInternal.CustomizerCaption = "Editar"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool4})
        '
        '_frmUsuarios_Toolbars_Dock_Area_Left
        '
        Me._frmUsuarios_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmUsuarios_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frmUsuarios_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmUsuarios_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmUsuarios_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 8
        Me._frmUsuarios_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 187)
        Me._frmUsuarios_Toolbars_Dock_Area_Left.Name = "_frmUsuarios_Toolbars_Dock_Area_Left"
        Me._frmUsuarios_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(8, 266)
        Me._frmUsuarios_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmUsuarios_Toolbars_Dock_Area_Right
        '
        Me._frmUsuarios_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmUsuarios_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frmUsuarios_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmUsuarios_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmUsuarios_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 8
        Me._frmUsuarios_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(792, 187)
        Me._frmUsuarios_Toolbars_Dock_Area_Right.Name = "_frmUsuarios_Toolbars_Dock_Area_Right"
        Me._frmUsuarios_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(8, 266)
        Me._frmUsuarios_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmUsuarios_Toolbars_Dock_Area_Top
        '
        Me._frmUsuarios_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmUsuarios_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frmUsuarios_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmUsuarios_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmUsuarios_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmUsuarios_Toolbars_Dock_Area_Top.Name = "_frmUsuarios_Toolbars_Dock_Area_Top"
        Me._frmUsuarios_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(800, 162)
        Me._frmUsuarios_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmUsuarios_Toolbars_Dock_Area_Bottom
        '
        Me._frmUsuarios_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmUsuarios_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frmUsuarios_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmUsuarios_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmUsuarios_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent = 8
        Me._frmUsuarios_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 453)
        Me._frmUsuarios_Toolbars_Dock_Area_Bottom.Name = "_frmUsuarios_Toolbars_Dock_Area_Bottom"
        Me._frmUsuarios_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(800, 8)
        Me._frmUsuarios_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'ISGUSRPERFIL2BindingSource
        '
        Me.ISGUSRPERFIL2BindingSource.DataMember = "ISGUSRPERFIL2"
        Me.ISGUSRPERFIL2BindingSource.DataSource = Me.SGUSUARIOSBindingSource
        '
        'SGUSUARIOSTableAdapter
        '
        Me.SGUSUARIOSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SGSETTINGSCTableAdapter = Nothing
        Me.TableAdapterManager.SGSETTINGSSTableAdapter = Nothing
        Me.TableAdapterManager.SGSETTINGSTableAdapter = Nothing
        Me.TableAdapterManager.SGUSRPERFILTableAdapter = Me.SGUSRPERFILTableAdapter
        Me.TableAdapterManager.SGUSUARIOSTableAdapter = Me.SGUSUARIOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = SegLibrary.SegDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SGUSRPERFILTableAdapter
        '
        Me.SGUSRPERFILTableAdapter.ClearBeforeFill = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 461)
        Me.Controls.Add(Me.SGUSUARIOSUltraGrid)
        Me.Controls.Add(Me._frmUsuarios_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmUsuarios_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me.SGUSUARIOSBindingNavigator)
        Me.Controls.Add(Me._frmUsuarios_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._frmUsuarios_Toolbars_Dock_Area_Top)
        Me.Name = "frmUsuarios"
        Me.Text = "frmUsuarios"
        CType(Me.SGUSUARIOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SGUSUARIOSBindingNavigator.ResumeLayout(False)
        Me.SGUSUARIOSBindingNavigator.PerformLayout()
        CType(Me.SGUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGUSUARIOSUltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISGUSRPERFIL2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SegDS As SegDS
    Friend WithEvents SGUSUARIOSBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SGUSUARIOSTableAdapter As SegDSTableAdapters.SGUSUARIOSTableAdapter
    Friend WithEvents TableAdapterManager As SegDSTableAdapters.TableAdapterManager
    Friend WithEvents SGUSUARIOSBindingNavigator As Windows.Forms.BindingNavigator
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
    Friend WithEvents SGUSUARIOSBindingNavigatorSaveItem As Windows.Forms.ToolStripButton
    Friend WithEvents SGUSUARIOSUltraGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _frmUsuarios_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmUsuarios_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmUsuarios_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmUsuarios_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents ISGUSRPERFIL2BindingSource As Windows.Forms.BindingSource
    Friend WithEvents SGUSRPERFILTableAdapter As SegDSTableAdapters.SGUSRPERFILTableAdapter
End Class
