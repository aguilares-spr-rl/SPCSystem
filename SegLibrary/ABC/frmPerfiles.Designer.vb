<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPerfiles))
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("SGPERFILES", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilNombre")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstructuraMenuID")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlataformaID")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaUserID")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaDate")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiUserID")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiDate")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INETUSRPERFIL1")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISGPERFILESDETALLE3")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISGUSRPERFIL1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("INETUSRPERFIL1", 0)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsrPerfilID")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUserID")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilID")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaUserID")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaDate")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiUserID")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiDate")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ISGPERFILESDETALLE3", 0)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilDetalleID")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilID")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModuloID")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionID")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilConsultar")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilNuevo")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilEliminar")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilRecuperar")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilModificar")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilListar")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilExportar")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilGraficar")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaUserID")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaDate")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiUserID")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiDate")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ISGUSRPERFIL1", 0)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgUsrPerfilID")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SgUserID")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilID")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaUserID")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaDate")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiUserID")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiDate")
        Me.SegDS = New SegLibrary.SegDS()
        Me.SGPERFILESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPERFILESTableAdapter = New SegLibrary.SegDSTableAdapters.SGPERFILESTableAdapter()
        Me.TableAdapterManager = New SegLibrary.SegDSTableAdapters.TableAdapterManager()
        Me.SGPERFILESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SGPERFILESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.SGPERFILESUltraGrid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.SegDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPERFILESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPERFILESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SGPERFILESBindingNavigator.SuspendLayout()
        CType(Me.SGPERFILESUltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SegDS
        '
        Me.SegDS.DataSetName = "SegDS"
        Me.SegDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SGPERFILESBindingSource
        '
        Me.SGPERFILESBindingSource.DataMember = "SGPERFILES"
        Me.SGPERFILESBindingSource.DataSource = Me.SegDS
        '
        'SGPERFILESTableAdapter
        '
        Me.SGPERFILESTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SGPERFILESTableAdapter = Me.SGPERFILESTableAdapter
        Me.TableAdapterManager.SGPLATAFORMATableAdapter = Nothing
        Me.TableAdapterManager.SGUSRPERFILTableAdapter = Nothing
        Me.TableAdapterManager.SGUSUARIOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SegLibrary.SegDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SGPERFILESBindingNavigator
        '
        Me.SGPERFILESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SGPERFILESBindingNavigator.BindingSource = Me.SGPERFILESBindingSource
        Me.SGPERFILESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SGPERFILESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SGPERFILESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SGPERFILESBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.SGPERFILESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SGPERFILESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SGPERFILESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SGPERFILESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SGPERFILESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SGPERFILESBindingNavigator.Name = "SGPERFILESBindingNavigator"
        Me.SGPERFILESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SGPERFILESBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.SGPERFILESBindingNavigator.TabIndex = 0
        Me.SGPERFILESBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        Me.BindingNavigatorAddNewItem.Visible = False
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
        'SGPERFILESBindingNavigatorSaveItem
        '
        Me.SGPERFILESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SGPERFILESBindingNavigatorSaveItem.Image = CType(resources.GetObject("SGPERFILESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SGPERFILESBindingNavigatorSaveItem.Name = "SGPERFILESBindingNavigatorSaveItem"
        Me.SGPERFILESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SGPERFILESBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'SGPERFILESUltraGrid
        '
        Me.SGPERFILESUltraGrid.DataSource = Me.SGPERFILESBindingSource
        Me.SGPERFILESUltraGrid.DisplayLayout.AddNewBox.Hidden = False
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn16.Header.VisiblePosition = 3
        UltraGridColumn17.Header.VisiblePosition = 4
        UltraGridColumn18.Header.VisiblePosition = 5
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19})
        UltraGridBand2.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 0
        UltraGridColumn21.Header.VisiblePosition = 1
        UltraGridColumn22.Header.VisiblePosition = 2
        UltraGridColumn23.Header.VisiblePosition = 3
        UltraGridColumn24.Header.VisiblePosition = 4
        UltraGridColumn25.Header.VisiblePosition = 5
        UltraGridColumn26.Header.VisiblePosition = 6
        UltraGridColumn27.Header.VisiblePosition = 7
        UltraGridColumn28.Header.VisiblePosition = 8
        UltraGridColumn29.Header.VisiblePosition = 9
        UltraGridColumn30.Header.VisiblePosition = 10
        UltraGridColumn31.Header.VisiblePosition = 11
        UltraGridColumn32.Header.VisiblePosition = 12
        UltraGridColumn33.Header.VisiblePosition = 13
        UltraGridColumn34.Header.VisiblePosition = 14
        UltraGridColumn35.Header.VisiblePosition = 15
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35})
        UltraGridBand3.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridColumn38.Header.VisiblePosition = 2
        UltraGridColumn39.Header.VisiblePosition = 3
        UltraGridColumn40.Header.VisiblePosition = 4
        UltraGridColumn41.Header.VisiblePosition = 5
        UltraGridColumn42.Header.VisiblePosition = 6
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42})
        UltraGridBand4.Hidden = True
        Me.SGPERFILESUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.SGPERFILESUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.SGPERFILESUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.SGPERFILESUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.SGPERFILESUltraGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SGPERFILESUltraGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGPERFILESUltraGrid.Location = New System.Drawing.Point(0, 25)
        Me.SGPERFILESUltraGrid.Name = "SGPERFILESUltraGrid"
        Me.SGPERFILESUltraGrid.Size = New System.Drawing.Size(800, 425)
        Me.SGPERFILESUltraGrid.TabIndex = 1
        Me.SGPERFILESUltraGrid.Text = "UltraGrid1"
        '
        'frmPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SGPERFILESUltraGrid)
        Me.Controls.Add(Me.SGPERFILESBindingNavigator)
        Me.Name = "frmPerfiles"
        Me.Text = "frmPerfiles"
        CType(Me.SegDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPERFILESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPERFILESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SGPERFILESBindingNavigator.ResumeLayout(False)
        Me.SGPERFILESBindingNavigator.PerformLayout()
        CType(Me.SGPERFILESUltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SegDS As SegDS
    Friend WithEvents SGPERFILESBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SGPERFILESTableAdapter As SegDSTableAdapters.SGPERFILESTableAdapter
    Friend WithEvents TableAdapterManager As SegDSTableAdapters.TableAdapterManager
    Friend WithEvents SGPERFILESBindingNavigator As Windows.Forms.BindingNavigator
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
    Friend WithEvents SGPERFILESBindingNavigatorSaveItem As Windows.Forms.ToolStripButton
    Friend WithEvents SGPERFILESUltraGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolStripButton1 As Windows.Forms.ToolStripButton
End Class
