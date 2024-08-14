<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFunciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFunciones))
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("SGFUNCIONES", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionNombre")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionDescripcion")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionConsultar")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionNuevo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionEliminar")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionRecuperar")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionModificar")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionListar")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionExportar")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionGraficar")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionActivo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionOLEDLL")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionWeb")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionPrimaria")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISGFUNCIONESMODULO1")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_SGFUNCIONEVENTOS_SGFUNCIONES")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISGPERFILESDETALLE1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ISGFUNCIONESMODULO1", 0)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionModuloID")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstructuraMenuID")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModuloID")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionID")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("FK_SGFUNCIONEVENTOS_SGFUNCIONES", 0)
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionEventoID")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionEventoTag")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionEvento")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionID")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ISGPERFILESDETALLE1", 0)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilDetalleID")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilID")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModuloID")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SGFuncionID")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilConsultar")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilNuevo")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilEliminar")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilRecuperar")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilModificar")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilListar")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilExportar")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PerfilGraficar")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaUserID")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreaDate")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiUserID")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModifiDate")
        Me.SegDS = New SegLibrary.SegDS()
        Me.SGFUNCIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGFUNCIONESTableAdapter = New SegLibrary.SegDSTableAdapters.SGFUNCIONESTableAdapter()
        Me.TableAdapterManager = New SegLibrary.SegDSTableAdapters.TableAdapterManager()
        Me.SGFUNCIONESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SGFUNCIONESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SGFUNCIONESUltraGrid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.SegDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGFUNCIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGFUNCIONESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SGFUNCIONESBindingNavigator.SuspendLayout()
        CType(Me.SGFUNCIONESUltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SegDS
        '
        Me.SegDS.DataSetName = "SegDS"
        Me.SegDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SGFUNCIONESBindingSource
        '
        Me.SGFUNCIONESBindingSource.DataMember = "SGFUNCIONES"
        Me.SGFUNCIONESBindingSource.DataSource = Me.SegDS
        '
        'SGFUNCIONESTableAdapter
        '
        Me.SGFUNCIONESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NETUSRPERFILTableAdapter = Nothing
        Me.TableAdapterManager.SGESTRUCTURAMENUTableAdapter = Nothing
        Me.TableAdapterManager.SGESTRUCTURASM_DETALLETableAdapter = Nothing
        Me.TableAdapterManager.SGFUNCIONESMODULOTableAdapter = Nothing
        Me.TableAdapterManager.SGFUNCIONESTableAdapter = Me.SGFUNCIONESTableAdapter
        Me.TableAdapterManager.SGFUNCIONEVENTOSTableAdapter = Nothing
        Me.TableAdapterManager.SGMODULOSTableAdapter = Nothing
        Me.TableAdapterManager.SGPERFILESDETALLETableAdapter = Nothing
        Me.TableAdapterManager.SGPERFILESTableAdapter = Nothing
        Me.TableAdapterManager.SGPLATAFORMATableAdapter = Nothing
        Me.TableAdapterManager.SGSETTINGSCTableAdapter = Nothing
        Me.TableAdapterManager.SGSETTINGSSTableAdapter = Nothing
        Me.TableAdapterManager.SGSETTINGSTableAdapter = Nothing
        Me.TableAdapterManager.SGUSRPERFILTableAdapter = Nothing
        Me.TableAdapterManager.SGUSUARIOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SegLibrary.SegDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SGFUNCIONESBindingNavigator
        '
        Me.SGFUNCIONESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SGFUNCIONESBindingNavigator.BindingSource = Me.SGFUNCIONESBindingSource
        Me.SGFUNCIONESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SGFUNCIONESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SGFUNCIONESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SGFUNCIONESBindingNavigatorSaveItem})
        Me.SGFUNCIONESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SGFUNCIONESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SGFUNCIONESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SGFUNCIONESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SGFUNCIONESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SGFUNCIONESBindingNavigator.Name = "SGFUNCIONESBindingNavigator"
        Me.SGFUNCIONESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SGFUNCIONESBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.SGFUNCIONESBindingNavigator.TabIndex = 0
        Me.SGFUNCIONESBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'SGFUNCIONESBindingNavigatorSaveItem
        '
        Me.SGFUNCIONESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SGFUNCIONESBindingNavigatorSaveItem.Image = CType(resources.GetObject("SGFUNCIONESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SGFUNCIONESBindingNavigatorSaveItem.Name = "SGFUNCIONESBindingNavigatorSaveItem"
        Me.SGFUNCIONESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SGFUNCIONESBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'SGFUNCIONESUltraGrid
        '
        Me.SGFUNCIONESUltraGrid.DataSource = Me.SGFUNCIONESBindingSource
        Me.SGFUNCIONESUltraGrid.DisplayLayout.AddNewBox.Hidden = False
        UltraGridBand1.AddButtonCaption = "FUNCION"
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
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        UltraGridBand2.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn24.Header.VisiblePosition = 1
        UltraGridColumn25.Header.VisiblePosition = 2
        UltraGridColumn26.Header.VisiblePosition = 3
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        UltraGridBand3.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn32.Header.VisiblePosition = 5
        UltraGridColumn33.Header.VisiblePosition = 6
        UltraGridColumn34.Header.VisiblePosition = 7
        UltraGridColumn35.Header.VisiblePosition = 8
        UltraGridColumn36.Header.VisiblePosition = 9
        UltraGridColumn37.Header.VisiblePosition = 10
        UltraGridColumn38.Header.VisiblePosition = 11
        UltraGridColumn39.Header.VisiblePosition = 12
        UltraGridColumn40.Header.VisiblePosition = 13
        UltraGridColumn41.Header.VisiblePosition = 14
        UltraGridColumn42.Header.VisiblePosition = 15
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42})
        UltraGridBand4.Hidden = True
        Me.SGFUNCIONESUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.SGFUNCIONESUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.SGFUNCIONESUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.SGFUNCIONESUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.SGFUNCIONESUltraGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SGFUNCIONESUltraGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGFUNCIONESUltraGrid.Location = New System.Drawing.Point(0, 25)
        Me.SGFUNCIONESUltraGrid.Name = "SGFUNCIONESUltraGrid"
        Me.SGFUNCIONESUltraGrid.Size = New System.Drawing.Size(800, 425)
        Me.SGFUNCIONESUltraGrid.TabIndex = 1
        Me.SGFUNCIONESUltraGrid.Text = "UltraGrid1"
        '
        'frmFunciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SGFUNCIONESUltraGrid)
        Me.Controls.Add(Me.SGFUNCIONESBindingNavigator)
        Me.Name = "frmFunciones"
        Me.Text = "frmFunciones"
        CType(Me.SegDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGFUNCIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGFUNCIONESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SGFUNCIONESBindingNavigator.ResumeLayout(False)
        Me.SGFUNCIONESBindingNavigator.PerformLayout()
        CType(Me.SGFUNCIONESUltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SegDS As SegDS
    Friend WithEvents SGFUNCIONESBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SGFUNCIONESTableAdapter As SegDSTableAdapters.SGFUNCIONESTableAdapter
    Friend WithEvents TableAdapterManager As SegDSTableAdapters.TableAdapterManager
    Friend WithEvents SGFUNCIONESBindingNavigator As Windows.Forms.BindingNavigator
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
    Friend WithEvents SGFUNCIONESBindingNavigatorSaveItem As Windows.Forms.ToolStripButton
    Friend WithEvents SGFUNCIONESUltraGrid As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
