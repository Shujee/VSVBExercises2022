<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim NameLabel As System.Windows.Forms.Label
        Dim ProductNumberLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim StandardCostLabel As System.Windows.Forms.Label
        Dim ListPriceLabel As System.Windows.Forms.Label
        Dim SizeLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim ProductCategoryIDLabel As System.Windows.Forms.Label
        Dim ProductModelIDLabel As System.Windows.Forms.Label
        Dim SellStartDateLabel As System.Windows.Forms.Label
        Dim SellEndDateLabel As System.Windows.Forms.Label
        Dim DiscontinuedDateLabel As System.Windows.Forms.Label
        Dim ThumbnailPhotoFileNameLabel As System.Windows.Forms.Label
        Dim RowguidLabel As System.Windows.Forms.Label
        Dim ModifiedDateLabel As System.Windows.Forms.Label
        Me.AdventureWorksDataSet = New Products3.AdventureWorksDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New Products3.AdventureWorksDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New Products3.AdventureWorksDataSetTableAdapters.TableAdapterManager()
        Me.ProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProductBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.StandardCostTextBox = New System.Windows.Forms.TextBox()
        Me.ListPriceTextBox = New System.Windows.Forms.TextBox()
        Me.SizeTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.SellStartDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SellEndDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DiscontinuedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ThumbnailPhotoFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.RowguidTextBox = New System.Windows.Forms.TextBox()
        Me.ModifiedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ProductCategoryTableAdapter1 = New Products3.AdventureWorksDataSetTableAdapters.ProductCategoryTableAdapter()
        Me.ProductModelTableAdapter1 = New Products3.AdventureWorksDataSetTableAdapters.ProductModelTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        NameLabel = New System.Windows.Forms.Label()
        ProductNumberLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        StandardCostLabel = New System.Windows.Forms.Label()
        ListPriceLabel = New System.Windows.Forms.Label()
        SizeLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        ProductCategoryIDLabel = New System.Windows.Forms.Label()
        ProductModelIDLabel = New System.Windows.Forms.Label()
        SellStartDateLabel = New System.Windows.Forms.Label()
        SellEndDateLabel = New System.Windows.Forms.Label()
        DiscontinuedDateLabel = New System.Windows.Forms.Label()
        ThumbnailPhotoFileNameLabel = New System.Windows.Forms.Label()
        RowguidLabel = New System.Windows.Forms.Label()
        ModifiedDateLabel = New System.Windows.Forms.Label()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdventureWorksDataSet
        '
        Me.AdventureWorksDataSet.DataSetName = "AdventureWorksDataSet"
        Me.AdventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.AdventureWorksDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductCategoryTableAdapter = Me.ProductCategoryTableAdapter1
        Me.TableAdapterManager.ProductModelTableAdapter = Me.ProductModelTableAdapter1
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = Products3.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductBindingNavigator
        '
        Me.ProductBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductBindingNavigator.BindingSource = Me.ProductBindingSource
        Me.ProductBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductBindingNavigatorSaveItem})
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductBindingNavigator.Name = "ProductBindingNavigator"
        Me.ProductBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ProductBindingNavigator.TabIndex = 0
        Me.ProductBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ProductBindingNavigatorSaveItem
        '
        Me.ProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductBindingNavigatorSaveItem.Name = "ProductBindingNavigatorSaveItem"
        Me.ProductBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProductBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(110, 63)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(256, 60)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'ProductNumberLabel
        '
        ProductNumberLabel.AutoSize = True
        ProductNumberLabel.Location = New System.Drawing.Point(110, 89)
        ProductNumberLabel.Name = "ProductNumberLabel"
        ProductNumberLabel.Size = New System.Drawing.Size(87, 13)
        ProductNumberLabel.TabIndex = 5
        ProductNumberLabel.Text = "Product Number:"
        '
        'ProductNumberTextBox
        '
        Me.ProductNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductNumber", True))
        Me.ProductNumberTextBox.Location = New System.Drawing.Point(256, 86)
        Me.ProductNumberTextBox.Name = "ProductNumberTextBox"
        Me.ProductNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProductNumberTextBox.TabIndex = 6
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(110, 115)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 7
        ColorLabel.Text = "Color:"
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(256, 112)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ColorTextBox.TabIndex = 8
        '
        'StandardCostLabel
        '
        StandardCostLabel.AutoSize = True
        StandardCostLabel.Location = New System.Drawing.Point(110, 141)
        StandardCostLabel.Name = "StandardCostLabel"
        StandardCostLabel.Size = New System.Drawing.Size(77, 13)
        StandardCostLabel.TabIndex = 9
        StandardCostLabel.Text = "Standard Cost:"
        '
        'StandardCostTextBox
        '
        Me.StandardCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "StandardCost", True))
        Me.StandardCostTextBox.Location = New System.Drawing.Point(256, 138)
        Me.StandardCostTextBox.Name = "StandardCostTextBox"
        Me.StandardCostTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StandardCostTextBox.TabIndex = 10
        '
        'ListPriceLabel
        '
        ListPriceLabel.AutoSize = True
        ListPriceLabel.Location = New System.Drawing.Point(110, 167)
        ListPriceLabel.Name = "ListPriceLabel"
        ListPriceLabel.Size = New System.Drawing.Size(53, 13)
        ListPriceLabel.TabIndex = 11
        ListPriceLabel.Text = "List Price:"
        '
        'ListPriceTextBox
        '
        Me.ListPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ListPrice", True))
        Me.ListPriceTextBox.Location = New System.Drawing.Point(256, 164)
        Me.ListPriceTextBox.Name = "ListPriceTextBox"
        Me.ListPriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ListPriceTextBox.TabIndex = 12
        '
        'SizeLabel
        '
        SizeLabel.AutoSize = True
        SizeLabel.Location = New System.Drawing.Point(110, 193)
        SizeLabel.Name = "SizeLabel"
        SizeLabel.Size = New System.Drawing.Size(30, 13)
        SizeLabel.TabIndex = 13
        SizeLabel.Text = "Size:"
        '
        'SizeTextBox
        '
        Me.SizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Size", True))
        Me.SizeTextBox.Location = New System.Drawing.Point(256, 190)
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SizeTextBox.TabIndex = 14
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(110, 219)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 15
        WeightLabel.Text = "Weight:"
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(256, 216)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WeightTextBox.TabIndex = 16
        '
        'ProductCategoryIDLabel
        '
        ProductCategoryIDLabel.AutoSize = True
        ProductCategoryIDLabel.Location = New System.Drawing.Point(110, 245)
        ProductCategoryIDLabel.Name = "ProductCategoryIDLabel"
        ProductCategoryIDLabel.Size = New System.Drawing.Size(106, 13)
        ProductCategoryIDLabel.TabIndex = 17
        ProductCategoryIDLabel.Text = "Product Category ID:"
        '
        'ProductModelIDLabel
        '
        ProductModelIDLabel.AutoSize = True
        ProductModelIDLabel.Location = New System.Drawing.Point(110, 271)
        ProductModelIDLabel.Name = "ProductModelIDLabel"
        ProductModelIDLabel.Size = New System.Drawing.Size(93, 13)
        ProductModelIDLabel.TabIndex = 19
        ProductModelIDLabel.Text = "Product Model ID:"
        '
        'SellStartDateLabel
        '
        SellStartDateLabel.AutoSize = True
        SellStartDateLabel.Location = New System.Drawing.Point(110, 298)
        SellStartDateLabel.Name = "SellStartDateLabel"
        SellStartDateLabel.Size = New System.Drawing.Size(78, 13)
        SellStartDateLabel.TabIndex = 21
        SellStartDateLabel.Text = "Sell Start Date:"
        '
        'SellStartDateDateTimePicker
        '
        Me.SellStartDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "SellStartDate", True))
        Me.SellStartDateDateTimePicker.Location = New System.Drawing.Point(256, 294)
        Me.SellStartDateDateTimePicker.Name = "SellStartDateDateTimePicker"
        Me.SellStartDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.SellStartDateDateTimePicker.TabIndex = 22
        '
        'SellEndDateLabel
        '
        SellEndDateLabel.AutoSize = True
        SellEndDateLabel.Location = New System.Drawing.Point(110, 324)
        SellEndDateLabel.Name = "SellEndDateLabel"
        SellEndDateLabel.Size = New System.Drawing.Size(75, 13)
        SellEndDateLabel.TabIndex = 23
        SellEndDateLabel.Text = "Sell End Date:"
        '
        'SellEndDateDateTimePicker
        '
        Me.SellEndDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "SellEndDate", True))
        Me.SellEndDateDateTimePicker.Location = New System.Drawing.Point(256, 320)
        Me.SellEndDateDateTimePicker.Name = "SellEndDateDateTimePicker"
        Me.SellEndDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.SellEndDateDateTimePicker.TabIndex = 24
        '
        'DiscontinuedDateLabel
        '
        DiscontinuedDateLabel.AutoSize = True
        DiscontinuedDateLabel.Location = New System.Drawing.Point(110, 350)
        DiscontinuedDateLabel.Name = "DiscontinuedDateLabel"
        DiscontinuedDateLabel.Size = New System.Drawing.Size(98, 13)
        DiscontinuedDateLabel.TabIndex = 25
        DiscontinuedDateLabel.Text = "Discontinued Date:"
        '
        'DiscontinuedDateDateTimePicker
        '
        Me.DiscontinuedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "DiscontinuedDate", True))
        Me.DiscontinuedDateDateTimePicker.Location = New System.Drawing.Point(256, 346)
        Me.DiscontinuedDateDateTimePicker.Name = "DiscontinuedDateDateTimePicker"
        Me.DiscontinuedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DiscontinuedDateDateTimePicker.TabIndex = 26
        '
        'ThumbnailPhotoFileNameLabel
        '
        ThumbnailPhotoFileNameLabel.AutoSize = True
        ThumbnailPhotoFileNameLabel.Location = New System.Drawing.Point(110, 375)
        ThumbnailPhotoFileNameLabel.Name = "ThumbnailPhotoFileNameLabel"
        ThumbnailPhotoFileNameLabel.Size = New System.Drawing.Size(140, 13)
        ThumbnailPhotoFileNameLabel.TabIndex = 27
        ThumbnailPhotoFileNameLabel.Text = "Thumbnail Photo File Name:"
        '
        'ThumbnailPhotoFileNameTextBox
        '
        Me.ThumbnailPhotoFileNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ThumbnailPhotoFileName", True))
        Me.ThumbnailPhotoFileNameTextBox.Location = New System.Drawing.Point(256, 372)
        Me.ThumbnailPhotoFileNameTextBox.Name = "ThumbnailPhotoFileNameTextBox"
        Me.ThumbnailPhotoFileNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ThumbnailPhotoFileNameTextBox.TabIndex = 28
        '
        'RowguidLabel
        '
        RowguidLabel.AutoSize = True
        RowguidLabel.Location = New System.Drawing.Point(110, 401)
        RowguidLabel.Name = "RowguidLabel"
        RowguidLabel.Size = New System.Drawing.Size(47, 13)
        RowguidLabel.TabIndex = 29
        RowguidLabel.Text = "rowguid:"
        '
        'RowguidTextBox
        '
        Me.RowguidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "rowguid", True))
        Me.RowguidTextBox.Location = New System.Drawing.Point(256, 398)
        Me.RowguidTextBox.Name = "RowguidTextBox"
        Me.RowguidTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RowguidTextBox.TabIndex = 30
        '
        'ModifiedDateLabel
        '
        ModifiedDateLabel.AutoSize = True
        ModifiedDateLabel.Location = New System.Drawing.Point(110, 428)
        ModifiedDateLabel.Name = "ModifiedDateLabel"
        ModifiedDateLabel.Size = New System.Drawing.Size(76, 13)
        ModifiedDateLabel.TabIndex = 31
        ModifiedDateLabel.Text = "Modified Date:"
        '
        'ModifiedDateDateTimePicker
        '
        Me.ModifiedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ModifiedDate", True))
        Me.ModifiedDateDateTimePicker.Location = New System.Drawing.Point(256, 424)
        Me.ModifiedDateDateTimePicker.Name = "ModifiedDateDateTimePicker"
        Me.ModifiedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ModifiedDateDateTimePicker.TabIndex = 32
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductBindingSource, "ProductCategoryID", True))
        Me.ComboBox1.DataSource = Me.AdventureWorksDataSet
        Me.ComboBox1.DisplayMember = "ProductCategory.Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(256, 242)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 33
        Me.ComboBox1.ValueMember = "ProductCategory.ProductCategoryID"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductBindingSource, "ProductModelID", True))
        Me.ComboBox2.DataSource = Me.AdventureWorksDataSet
        Me.ComboBox2.DisplayMember = "ProductModel.Name"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(256, 268)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 34
        Me.ComboBox2.ValueMember = "ProductModel.ProductModelID"
        '
        'ProductCategoryTableAdapter1
        '
        Me.ProductCategoryTableAdapter1.ClearBeforeFill = True
        '
        'ProductModelTableAdapter1
        '
        Me.ProductModelTableAdapter1.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductBindingSource, "ThumbNailPhoto", True))
        Me.PictureBox1.Location = New System.Drawing.Point(462, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 173)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 464)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(ProductNumberLabel)
        Me.Controls.Add(Me.ProductNumberTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(StandardCostLabel)
        Me.Controls.Add(Me.StandardCostTextBox)
        Me.Controls.Add(ListPriceLabel)
        Me.Controls.Add(Me.ListPriceTextBox)
        Me.Controls.Add(SizeLabel)
        Me.Controls.Add(Me.SizeTextBox)
        Me.Controls.Add(WeightLabel)
        Me.Controls.Add(Me.WeightTextBox)
        Me.Controls.Add(ProductCategoryIDLabel)
        Me.Controls.Add(ProductModelIDLabel)
        Me.Controls.Add(SellStartDateLabel)
        Me.Controls.Add(Me.SellStartDateDateTimePicker)
        Me.Controls.Add(SellEndDateLabel)
        Me.Controls.Add(Me.SellEndDateDateTimePicker)
        Me.Controls.Add(DiscontinuedDateLabel)
        Me.Controls.Add(Me.DiscontinuedDateDateTimePicker)
        Me.Controls.Add(ThumbnailPhotoFileNameLabel)
        Me.Controls.Add(Me.ThumbnailPhotoFileNameTextBox)
        Me.Controls.Add(RowguidLabel)
        Me.Controls.Add(Me.RowguidTextBox)
        Me.Controls.Add(ModifiedDateLabel)
        Me.Controls.Add(Me.ModifiedDateDateTimePicker)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdventureWorksDataSet As AdventureWorksDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As AdventureWorksDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As AdventureWorksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductBindingNavigator As BindingNavigator
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
    Friend WithEvents ProductBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ProductNumberTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents StandardCostTextBox As TextBox
    Friend WithEvents ListPriceTextBox As TextBox
    Friend WithEvents SizeTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents SellStartDateDateTimePicker As DateTimePicker
    Friend WithEvents SellEndDateDateTimePicker As DateTimePicker
    Friend WithEvents DiscontinuedDateDateTimePicker As DateTimePicker
    Friend WithEvents ThumbnailPhotoFileNameTextBox As TextBox
    Friend WithEvents RowguidTextBox As TextBox
    Friend WithEvents ModifiedDateDateTimePicker As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ProductCategoryTableAdapter1 As AdventureWorksDataSetTableAdapters.ProductCategoryTableAdapter
    Friend WithEvents ProductModelTableAdapter1 As AdventureWorksDataSetTableAdapters.ProductModelTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
End Class
