<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdventureWorksDataSet = New Products3.AdventureWorksDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.ProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProductBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductTableAdapter = New Products3.AdventureWorksDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New Products3.AdventureWorksDataSetTableAdapters.TableAdapterManager()
        Me.ProductCategoryTableAdapter1 = New Products3.AdventureWorksDataSetTableAdapters.ProductCategoryTableAdapter()
        Me.ProductModelTableAdapter1 = New Products3.AdventureWorksDataSetTableAdapters.ProductModelTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(25, 32)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 36
        NameLabel.Text = "Name:"
        '
        'ProductNumberLabel
        '
        ProductNumberLabel.AutoSize = True
        ProductNumberLabel.Location = New System.Drawing.Point(25, 58)
        ProductNumberLabel.Name = "ProductNumberLabel"
        ProductNumberLabel.Size = New System.Drawing.Size(87, 13)
        ProductNumberLabel.TabIndex = 38
        ProductNumberLabel.Text = "Product Number:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(25, 84)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 40
        ColorLabel.Text = "Color:"
        '
        'StandardCostLabel
        '
        StandardCostLabel.AutoSize = True
        StandardCostLabel.Location = New System.Drawing.Point(25, 110)
        StandardCostLabel.Name = "StandardCostLabel"
        StandardCostLabel.Size = New System.Drawing.Size(77, 13)
        StandardCostLabel.TabIndex = 42
        StandardCostLabel.Text = "Standard Cost:"
        '
        'ListPriceLabel
        '
        ListPriceLabel.AutoSize = True
        ListPriceLabel.Location = New System.Drawing.Point(25, 136)
        ListPriceLabel.Name = "ListPriceLabel"
        ListPriceLabel.Size = New System.Drawing.Size(53, 13)
        ListPriceLabel.TabIndex = 44
        ListPriceLabel.Text = "List Price:"
        '
        'SizeLabel
        '
        SizeLabel.AutoSize = True
        SizeLabel.Location = New System.Drawing.Point(25, 162)
        SizeLabel.Name = "SizeLabel"
        SizeLabel.Size = New System.Drawing.Size(30, 13)
        SizeLabel.TabIndex = 46
        SizeLabel.Text = "Size:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(25, 188)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 48
        WeightLabel.Text = "Weight:"
        '
        'ProductCategoryIDLabel
        '
        ProductCategoryIDLabel.AutoSize = True
        ProductCategoryIDLabel.Location = New System.Drawing.Point(25, 214)
        ProductCategoryIDLabel.Name = "ProductCategoryIDLabel"
        ProductCategoryIDLabel.Size = New System.Drawing.Size(106, 13)
        ProductCategoryIDLabel.TabIndex = 50
        ProductCategoryIDLabel.Text = "Product Category ID:"
        '
        'ProductModelIDLabel
        '
        ProductModelIDLabel.AutoSize = True
        ProductModelIDLabel.Location = New System.Drawing.Point(25, 240)
        ProductModelIDLabel.Name = "ProductModelIDLabel"
        ProductModelIDLabel.Size = New System.Drawing.Size(93, 13)
        ProductModelIDLabel.TabIndex = 51
        ProductModelIDLabel.Text = "Product Model ID:"
        '
        'SellStartDateLabel
        '
        SellStartDateLabel.AutoSize = True
        SellStartDateLabel.Location = New System.Drawing.Point(25, 267)
        SellStartDateLabel.Name = "SellStartDateLabel"
        SellStartDateLabel.Size = New System.Drawing.Size(78, 13)
        SellStartDateLabel.TabIndex = 52
        SellStartDateLabel.Text = "Sell Start Date:"
        '
        'SellEndDateLabel
        '
        SellEndDateLabel.AutoSize = True
        SellEndDateLabel.Location = New System.Drawing.Point(25, 293)
        SellEndDateLabel.Name = "SellEndDateLabel"
        SellEndDateLabel.Size = New System.Drawing.Size(75, 13)
        SellEndDateLabel.TabIndex = 54
        SellEndDateLabel.Text = "Sell End Date:"
        '
        'DiscontinuedDateLabel
        '
        DiscontinuedDateLabel.AutoSize = True
        DiscontinuedDateLabel.Location = New System.Drawing.Point(25, 319)
        DiscontinuedDateLabel.Name = "DiscontinuedDateLabel"
        DiscontinuedDateLabel.Size = New System.Drawing.Size(98, 13)
        DiscontinuedDateLabel.TabIndex = 56
        DiscontinuedDateLabel.Text = "Discontinued Date:"
        '
        'ThumbnailPhotoFileNameLabel
        '
        ThumbnailPhotoFileNameLabel.AutoSize = True
        ThumbnailPhotoFileNameLabel.Location = New System.Drawing.Point(25, 344)
        ThumbnailPhotoFileNameLabel.Name = "ThumbnailPhotoFileNameLabel"
        ThumbnailPhotoFileNameLabel.Size = New System.Drawing.Size(140, 13)
        ThumbnailPhotoFileNameLabel.TabIndex = 58
        ThumbnailPhotoFileNameLabel.Text = "Thumbnail Photo File Name:"
        '
        'RowguidLabel
        '
        RowguidLabel.AutoSize = True
        RowguidLabel.Location = New System.Drawing.Point(25, 370)
        RowguidLabel.Name = "RowguidLabel"
        RowguidLabel.Size = New System.Drawing.Size(47, 13)
        RowguidLabel.TabIndex = 60
        RowguidLabel.Text = "rowguid:"
        '
        'ModifiedDateLabel
        '
        ModifiedDateLabel.AutoSize = True
        ModifiedDateLabel.Location = New System.Drawing.Point(25, 397)
        ModifiedDateLabel.Name = "ModifiedDateLabel"
        ModifiedDateLabel.Size = New System.Drawing.Size(76, 13)
        ModifiedDateLabel.TabIndex = 62
        ModifiedDateLabel.Text = "Modified Date:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(830, 469)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.ProductBindingSource
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(243, 463)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "ProductID"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.AdventureWorksDataSet
        '
        'AdventureWorksDataSet
        '
        Me.AdventureWorksDataSet.DataSetName = "AdventureWorksDataSet"
        Me.AdventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.ProductBindingNavigator)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(252, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 463)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductBindingSource, "ThumbNailPhoto", True))
        Me.PictureBox1.Location = New System.Drawing.Point(377, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductBindingSource, "ProductModelID", True))
        Me.ComboBox2.DataSource = Me.AdventureWorksDataSet
        Me.ComboBox2.DisplayMember = "ProductModel.Name"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(171, 237)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 65
        Me.ComboBox2.ValueMember = "ProductModel.ProductModelID"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductBindingSource, "ProductCategoryID", True))
        Me.ComboBox1.DataSource = Me.AdventureWorksDataSet
        Me.ComboBox1.DisplayMember = "ProductCategory.Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(171, 211)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 64
        Me.ComboBox1.ValueMember = "ProductCategory.ProductCategoryID"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(171, 29)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 37
        '
        'ProductNumberTextBox
        '
        Me.ProductNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductNumber", True))
        Me.ProductNumberTextBox.Location = New System.Drawing.Point(171, 55)
        Me.ProductNumberTextBox.Name = "ProductNumberTextBox"
        Me.ProductNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProductNumberTextBox.TabIndex = 39
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(171, 81)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ColorTextBox.TabIndex = 41
        '
        'StandardCostTextBox
        '
        Me.StandardCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "StandardCost", True))
        Me.StandardCostTextBox.Location = New System.Drawing.Point(171, 107)
        Me.StandardCostTextBox.Name = "StandardCostTextBox"
        Me.StandardCostTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StandardCostTextBox.TabIndex = 43
        '
        'ListPriceTextBox
        '
        Me.ListPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ListPrice", True))
        Me.ListPriceTextBox.Location = New System.Drawing.Point(171, 133)
        Me.ListPriceTextBox.Name = "ListPriceTextBox"
        Me.ListPriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ListPriceTextBox.TabIndex = 45
        '
        'SizeTextBox
        '
        Me.SizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Size", True))
        Me.SizeTextBox.Location = New System.Drawing.Point(171, 159)
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SizeTextBox.TabIndex = 47
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(171, 185)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WeightTextBox.TabIndex = 49
        '
        'SellStartDateDateTimePicker
        '
        Me.SellStartDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "SellStartDate", True))
        Me.SellStartDateDateTimePicker.Location = New System.Drawing.Point(171, 263)
        Me.SellStartDateDateTimePicker.Name = "SellStartDateDateTimePicker"
        Me.SellStartDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.SellStartDateDateTimePicker.TabIndex = 53
        '
        'SellEndDateDateTimePicker
        '
        Me.SellEndDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "SellEndDate", True))
        Me.SellEndDateDateTimePicker.Location = New System.Drawing.Point(171, 289)
        Me.SellEndDateDateTimePicker.Name = "SellEndDateDateTimePicker"
        Me.SellEndDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.SellEndDateDateTimePicker.TabIndex = 55
        '
        'DiscontinuedDateDateTimePicker
        '
        Me.DiscontinuedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "DiscontinuedDate", True))
        Me.DiscontinuedDateDateTimePicker.Location = New System.Drawing.Point(171, 315)
        Me.DiscontinuedDateDateTimePicker.Name = "DiscontinuedDateDateTimePicker"
        Me.DiscontinuedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DiscontinuedDateDateTimePicker.TabIndex = 57
        '
        'ThumbnailPhotoFileNameTextBox
        '
        Me.ThumbnailPhotoFileNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ThumbnailPhotoFileName", True))
        Me.ThumbnailPhotoFileNameTextBox.Location = New System.Drawing.Point(171, 341)
        Me.ThumbnailPhotoFileNameTextBox.Name = "ThumbnailPhotoFileNameTextBox"
        Me.ThumbnailPhotoFileNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ThumbnailPhotoFileNameTextBox.TabIndex = 59
        '
        'RowguidTextBox
        '
        Me.RowguidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "rowguid", True))
        Me.RowguidTextBox.Location = New System.Drawing.Point(171, 367)
        Me.RowguidTextBox.Name = "RowguidTextBox"
        Me.RowguidTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RowguidTextBox.TabIndex = 61
        '
        'ModifiedDateDateTimePicker
        '
        Me.ModifiedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ModifiedDate", True))
        Me.ModifiedDateDateTimePicker.Location = New System.Drawing.Point(171, 393)
        Me.ModifiedDateDateTimePicker.Name = "ModifiedDateDateTimePicker"
        Me.ModifiedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ModifiedDateDateTimePicker.TabIndex = 63
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
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(575, 25)
        Me.ProductBindingNavigator.TabIndex = 1
        Me.ProductBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductBindingNavigatorSaveItem
        '
        Me.ProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductBindingNavigatorSaveItem.Name = "ProductBindingNavigatorSaveItem"
        Me.ProductBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductBindingNavigatorSaveItem.Text = "Save Data"
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
        'ProductCategoryTableAdapter1
        '
        Me.ProductCategoryTableAdapter1.ClearBeforeFill = True
        '
        'ProductModelTableAdapter1
        '
        Me.ProductModelTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ModifiedDateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(ModifiedDateLabel)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.RowguidTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(RowguidLabel)
        Me.GroupBox1.Controls.Add(Me.ThumbnailPhotoFileNameTextBox)
        Me.GroupBox1.Controls.Add(ProductNumberLabel)
        Me.GroupBox1.Controls.Add(ThumbnailPhotoFileNameLabel)
        Me.GroupBox1.Controls.Add(Me.ProductNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.DiscontinuedDateDateTimePicker)
        Me.GroupBox1.Controls.Add(ColorLabel)
        Me.GroupBox1.Controls.Add(DiscontinuedDateLabel)
        Me.GroupBox1.Controls.Add(Me.ColorTextBox)
        Me.GroupBox1.Controls.Add(Me.SellEndDateDateTimePicker)
        Me.GroupBox1.Controls.Add(StandardCostLabel)
        Me.GroupBox1.Controls.Add(SellEndDateLabel)
        Me.GroupBox1.Controls.Add(Me.StandardCostTextBox)
        Me.GroupBox1.Controls.Add(Me.SellStartDateDateTimePicker)
        Me.GroupBox1.Controls.Add(ListPriceLabel)
        Me.GroupBox1.Controls.Add(SellStartDateLabel)
        Me.GroupBox1.Controls.Add(Me.ListPriceTextBox)
        Me.GroupBox1.Controls.Add(ProductModelIDLabel)
        Me.GroupBox1.Controls.Add(SizeLabel)
        Me.GroupBox1.Controls.Add(ProductCategoryIDLabel)
        Me.GroupBox1.Controls.Add(Me.SizeTextBox)
        Me.GroupBox1.Controls.Add(Me.WeightTextBox)
        Me.GroupBox1.Controls.Add(WeightLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 424)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 469)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form5"
        Me.Text = "Master/Details View"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProductBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents AdventureWorksDataSet As AdventureWorksDataSet
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
    Friend WithEvents ProductTableAdapter As AdventureWorksDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As AdventureWorksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductCategoryTableAdapter1 As AdventureWorksDataSetTableAdapters.ProductCategoryTableAdapter
    Friend WithEvents ProductModelTableAdapter1 As AdventureWorksDataSetTableAdapters.ProductModelTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
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
    Friend WithEvents GroupBox1 As GroupBox
End Class
