namespace E09_Data1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
      System.Windows.Forms.Label productIDLabel;
      System.Windows.Forms.Label nameLabel;
      System.Windows.Forms.Label productNumberLabel;
      System.Windows.Forms.Label colorLabel;
      System.Windows.Forms.Label standardCostLabel;
      System.Windows.Forms.Label listPriceLabel;
      System.Windows.Forms.Label sizeLabel;
      System.Windows.Forms.Label weightLabel;
      System.Windows.Forms.Label productCategoryIDLabel;
      System.Windows.Forms.Label productModelIDLabel;
      System.Windows.Forms.Label sellStartDateLabel;
      System.Windows.Forms.Label sellEndDateLabel;
      System.Windows.Forms.Label discontinuedDateLabel;
      System.Windows.Forms.Label thumbnailPhotoFileNameLabel;
      System.Windows.Forms.Label rowguidLabel;
      System.Windows.Forms.Label modifiedDateLabel;
      this.adventureWorksDataSet = new E09_Data1.AdventureWorksDataSet();
      this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.productTableAdapter = new E09_Data1.AdventureWorksDataSetTableAdapters.ProductTableAdapter();
      this.tableAdapterManager = new E09_Data1.AdventureWorksDataSetTableAdapters.TableAdapterManager();
      this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.productIDTextBox = new System.Windows.Forms.TextBox();
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.productNumberTextBox = new System.Windows.Forms.TextBox();
      this.colorTextBox = new System.Windows.Forms.TextBox();
      this.standardCostTextBox = new System.Windows.Forms.TextBox();
      this.listPriceTextBox = new System.Windows.Forms.TextBox();
      this.sizeTextBox = new System.Windows.Forms.TextBox();
      this.weightTextBox = new System.Windows.Forms.TextBox();
      this.productCategoryIDTextBox = new System.Windows.Forms.TextBox();
      this.productModelIDTextBox = new System.Windows.Forms.TextBox();
      this.sellStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.sellEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.discontinuedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.thumbnailPhotoFileNameTextBox = new System.Windows.Forms.TextBox();
      this.rowguidTextBox = new System.Windows.Forms.TextBox();
      this.modifiedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      productIDLabel = new System.Windows.Forms.Label();
      nameLabel = new System.Windows.Forms.Label();
      productNumberLabel = new System.Windows.Forms.Label();
      colorLabel = new System.Windows.Forms.Label();
      standardCostLabel = new System.Windows.Forms.Label();
      listPriceLabel = new System.Windows.Forms.Label();
      sizeLabel = new System.Windows.Forms.Label();
      weightLabel = new System.Windows.Forms.Label();
      productCategoryIDLabel = new System.Windows.Forms.Label();
      productModelIDLabel = new System.Windows.Forms.Label();
      sellStartDateLabel = new System.Windows.Forms.Label();
      sellEndDateLabel = new System.Windows.Forms.Label();
      discontinuedDateLabel = new System.Windows.Forms.Label();
      thumbnailPhotoFileNameLabel = new System.Windows.Forms.Label();
      rowguidLabel = new System.Windows.Forms.Label();
      modifiedDateLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
      this.productBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // adventureWorksDataSet
      // 
      this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
      this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // productBindingSource
      // 
      this.productBindingSource.DataMember = "Product";
      this.productBindingSource.DataSource = this.adventureWorksDataSet;
      // 
      // productTableAdapter
      // 
      this.productTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.ProductCategoryTableAdapter = null;
      this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
      this.tableAdapterManager.UpdateOrder = E09_Data1.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // productBindingNavigator
      // 
      this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.productBindingNavigator.BindingSource = this.productBindingSource;
      this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
      this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.productBindingNavigator.Name = "productBindingNavigator";
      this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.productBindingNavigator.Size = new System.Drawing.Size(800, 25);
      this.productBindingNavigator.TabIndex = 0;
      this.productBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // productBindingNavigatorSaveItem
      // 
      this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
      this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
      this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
      this.productBindingNavigatorSaveItem.Text = "Save Data";
      this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
      // 
      // productIDLabel
      // 
      productIDLabel.AutoSize = true;
      productIDLabel.Location = new System.Drawing.Point(246, 42);
      productIDLabel.Name = "productIDLabel";
      productIDLabel.Size = new System.Drawing.Size(61, 13);
      productIDLabel.TabIndex = 1;
      productIDLabel.Text = "Product ID:";
      // 
      // productIDTextBox
      // 
      this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
      this.productIDTextBox.Location = new System.Drawing.Point(392, 39);
      this.productIDTextBox.Name = "productIDTextBox";
      this.productIDTextBox.Size = new System.Drawing.Size(250, 20);
      this.productIDTextBox.TabIndex = 2;
      // 
      // nameLabel
      // 
      nameLabel.AutoSize = true;
      nameLabel.Location = new System.Drawing.Point(246, 68);
      nameLabel.Name = "nameLabel";
      nameLabel.Size = new System.Drawing.Size(38, 13);
      nameLabel.TabIndex = 3;
      nameLabel.Text = "Name:";
      // 
      // nameTextBox
      // 
      this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
      this.nameTextBox.Location = new System.Drawing.Point(392, 65);
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.Size = new System.Drawing.Size(250, 20);
      this.nameTextBox.TabIndex = 4;
      // 
      // productNumberLabel
      // 
      productNumberLabel.AutoSize = true;
      productNumberLabel.Location = new System.Drawing.Point(246, 94);
      productNumberLabel.Name = "productNumberLabel";
      productNumberLabel.Size = new System.Drawing.Size(87, 13);
      productNumberLabel.TabIndex = 5;
      productNumberLabel.Text = "Product Number:";
      // 
      // productNumberTextBox
      // 
      this.productNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductNumber", true));
      this.productNumberTextBox.Location = new System.Drawing.Point(392, 91);
      this.productNumberTextBox.Name = "productNumberTextBox";
      this.productNumberTextBox.Size = new System.Drawing.Size(250, 20);
      this.productNumberTextBox.TabIndex = 6;
      // 
      // colorLabel
      // 
      colorLabel.AutoSize = true;
      colorLabel.Location = new System.Drawing.Point(246, 120);
      colorLabel.Name = "colorLabel";
      colorLabel.Size = new System.Drawing.Size(34, 13);
      colorLabel.TabIndex = 7;
      colorLabel.Text = "Color:";
      // 
      // colorTextBox
      // 
      this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Color", true));
      this.colorTextBox.Location = new System.Drawing.Point(392, 117);
      this.colorTextBox.Name = "colorTextBox";
      this.colorTextBox.Size = new System.Drawing.Size(250, 20);
      this.colorTextBox.TabIndex = 8;
      // 
      // standardCostLabel
      // 
      standardCostLabel.AutoSize = true;
      standardCostLabel.Location = new System.Drawing.Point(246, 146);
      standardCostLabel.Name = "standardCostLabel";
      standardCostLabel.Size = new System.Drawing.Size(77, 13);
      standardCostLabel.TabIndex = 9;
      standardCostLabel.Text = "Standard Cost:";
      // 
      // standardCostTextBox
      // 
      this.standardCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "StandardCost", true));
      this.standardCostTextBox.Location = new System.Drawing.Point(392, 143);
      this.standardCostTextBox.Name = "standardCostTextBox";
      this.standardCostTextBox.Size = new System.Drawing.Size(250, 20);
      this.standardCostTextBox.TabIndex = 10;
      // 
      // listPriceLabel
      // 
      listPriceLabel.AutoSize = true;
      listPriceLabel.Location = new System.Drawing.Point(246, 172);
      listPriceLabel.Name = "listPriceLabel";
      listPriceLabel.Size = new System.Drawing.Size(53, 13);
      listPriceLabel.TabIndex = 11;
      listPriceLabel.Text = "List Price:";
      // 
      // listPriceTextBox
      // 
      this.listPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ListPrice", true));
      this.listPriceTextBox.Location = new System.Drawing.Point(392, 169);
      this.listPriceTextBox.Name = "listPriceTextBox";
      this.listPriceTextBox.Size = new System.Drawing.Size(250, 20);
      this.listPriceTextBox.TabIndex = 12;
      // 
      // sizeLabel
      // 
      sizeLabel.AutoSize = true;
      sizeLabel.Location = new System.Drawing.Point(246, 198);
      sizeLabel.Name = "sizeLabel";
      sizeLabel.Size = new System.Drawing.Size(30, 13);
      sizeLabel.TabIndex = 13;
      sizeLabel.Text = "Size:";
      // 
      // sizeTextBox
      // 
      this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Size", true));
      this.sizeTextBox.Location = new System.Drawing.Point(392, 195);
      this.sizeTextBox.Name = "sizeTextBox";
      this.sizeTextBox.Size = new System.Drawing.Size(396, 20);
      this.sizeTextBox.TabIndex = 14;
      // 
      // weightLabel
      // 
      weightLabel.AutoSize = true;
      weightLabel.Location = new System.Drawing.Point(246, 224);
      weightLabel.Name = "weightLabel";
      weightLabel.Size = new System.Drawing.Size(44, 13);
      weightLabel.TabIndex = 15;
      weightLabel.Text = "Weight:";
      // 
      // weightTextBox
      // 
      this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Weight", true));
      this.weightTextBox.Location = new System.Drawing.Point(392, 221);
      this.weightTextBox.Name = "weightTextBox";
      this.weightTextBox.Size = new System.Drawing.Size(396, 20);
      this.weightTextBox.TabIndex = 16;
      // 
      // productCategoryIDLabel
      // 
      productCategoryIDLabel.AutoSize = true;
      productCategoryIDLabel.Location = new System.Drawing.Point(246, 250);
      productCategoryIDLabel.Name = "productCategoryIDLabel";
      productCategoryIDLabel.Size = new System.Drawing.Size(106, 13);
      productCategoryIDLabel.TabIndex = 17;
      productCategoryIDLabel.Text = "Product Category ID:";
      // 
      // productCategoryIDTextBox
      // 
      this.productCategoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCategoryID", true));
      this.productCategoryIDTextBox.Location = new System.Drawing.Point(392, 247);
      this.productCategoryIDTextBox.Name = "productCategoryIDTextBox";
      this.productCategoryIDTextBox.Size = new System.Drawing.Size(396, 20);
      this.productCategoryIDTextBox.TabIndex = 18;
      // 
      // productModelIDLabel
      // 
      productModelIDLabel.AutoSize = true;
      productModelIDLabel.Location = new System.Drawing.Point(246, 276);
      productModelIDLabel.Name = "productModelIDLabel";
      productModelIDLabel.Size = new System.Drawing.Size(93, 13);
      productModelIDLabel.TabIndex = 19;
      productModelIDLabel.Text = "Product Model ID:";
      // 
      // productModelIDTextBox
      // 
      this.productModelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductModelID", true));
      this.productModelIDTextBox.Location = new System.Drawing.Point(392, 273);
      this.productModelIDTextBox.Name = "productModelIDTextBox";
      this.productModelIDTextBox.Size = new System.Drawing.Size(396, 20);
      this.productModelIDTextBox.TabIndex = 20;
      // 
      // sellStartDateLabel
      // 
      sellStartDateLabel.AutoSize = true;
      sellStartDateLabel.Location = new System.Drawing.Point(246, 303);
      sellStartDateLabel.Name = "sellStartDateLabel";
      sellStartDateLabel.Size = new System.Drawing.Size(78, 13);
      sellStartDateLabel.TabIndex = 21;
      sellStartDateLabel.Text = "Sell Start Date:";
      // 
      // sellStartDateDateTimePicker
      // 
      this.sellStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "SellStartDate", true));
      this.sellStartDateDateTimePicker.Location = new System.Drawing.Point(392, 299);
      this.sellStartDateDateTimePicker.Name = "sellStartDateDateTimePicker";
      this.sellStartDateDateTimePicker.Size = new System.Drawing.Size(396, 20);
      this.sellStartDateDateTimePicker.TabIndex = 22;
      // 
      // sellEndDateLabel
      // 
      sellEndDateLabel.AutoSize = true;
      sellEndDateLabel.Location = new System.Drawing.Point(246, 329);
      sellEndDateLabel.Name = "sellEndDateLabel";
      sellEndDateLabel.Size = new System.Drawing.Size(75, 13);
      sellEndDateLabel.TabIndex = 23;
      sellEndDateLabel.Text = "Sell End Date:";
      // 
      // sellEndDateDateTimePicker
      // 
      this.sellEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "SellEndDate", true));
      this.sellEndDateDateTimePicker.Location = new System.Drawing.Point(392, 325);
      this.sellEndDateDateTimePicker.Name = "sellEndDateDateTimePicker";
      this.sellEndDateDateTimePicker.Size = new System.Drawing.Size(396, 20);
      this.sellEndDateDateTimePicker.TabIndex = 24;
      // 
      // discontinuedDateLabel
      // 
      discontinuedDateLabel.AutoSize = true;
      discontinuedDateLabel.Location = new System.Drawing.Point(246, 355);
      discontinuedDateLabel.Name = "discontinuedDateLabel";
      discontinuedDateLabel.Size = new System.Drawing.Size(98, 13);
      discontinuedDateLabel.TabIndex = 25;
      discontinuedDateLabel.Text = "Discontinued Date:";
      // 
      // discontinuedDateDateTimePicker
      // 
      this.discontinuedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "DiscontinuedDate", true));
      this.discontinuedDateDateTimePicker.Location = new System.Drawing.Point(392, 351);
      this.discontinuedDateDateTimePicker.Name = "discontinuedDateDateTimePicker";
      this.discontinuedDateDateTimePicker.Size = new System.Drawing.Size(396, 20);
      this.discontinuedDateDateTimePicker.TabIndex = 26;
      // 
      // thumbnailPhotoFileNameLabel
      // 
      thumbnailPhotoFileNameLabel.AutoSize = true;
      thumbnailPhotoFileNameLabel.Location = new System.Drawing.Point(246, 380);
      thumbnailPhotoFileNameLabel.Name = "thumbnailPhotoFileNameLabel";
      thumbnailPhotoFileNameLabel.Size = new System.Drawing.Size(140, 13);
      thumbnailPhotoFileNameLabel.TabIndex = 27;
      thumbnailPhotoFileNameLabel.Text = "Thumbnail Photo File Name:";
      // 
      // thumbnailPhotoFileNameTextBox
      // 
      this.thumbnailPhotoFileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ThumbnailPhotoFileName", true));
      this.thumbnailPhotoFileNameTextBox.Location = new System.Drawing.Point(392, 377);
      this.thumbnailPhotoFileNameTextBox.Name = "thumbnailPhotoFileNameTextBox";
      this.thumbnailPhotoFileNameTextBox.Size = new System.Drawing.Size(396, 20);
      this.thumbnailPhotoFileNameTextBox.TabIndex = 28;
      // 
      // rowguidLabel
      // 
      rowguidLabel.AutoSize = true;
      rowguidLabel.Location = new System.Drawing.Point(246, 406);
      rowguidLabel.Name = "rowguidLabel";
      rowguidLabel.Size = new System.Drawing.Size(47, 13);
      rowguidLabel.TabIndex = 29;
      rowguidLabel.Text = "rowguid:";
      // 
      // rowguidTextBox
      // 
      this.rowguidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "rowguid", true));
      this.rowguidTextBox.Location = new System.Drawing.Point(392, 403);
      this.rowguidTextBox.Name = "rowguidTextBox";
      this.rowguidTextBox.Size = new System.Drawing.Size(396, 20);
      this.rowguidTextBox.TabIndex = 30;
      // 
      // modifiedDateLabel
      // 
      modifiedDateLabel.AutoSize = true;
      modifiedDateLabel.Location = new System.Drawing.Point(246, 433);
      modifiedDateLabel.Name = "modifiedDateLabel";
      modifiedDateLabel.Size = new System.Drawing.Size(76, 13);
      modifiedDateLabel.TabIndex = 31;
      modifiedDateLabel.Text = "Modified Date:";
      // 
      // modifiedDateDateTimePicker
      // 
      this.modifiedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ModifiedDate", true));
      this.modifiedDateDateTimePicker.Location = new System.Drawing.Point(392, 429);
      this.modifiedDateDateTimePicker.Name = "modifiedDateDateTimePicker";
      this.modifiedDateDateTimePicker.Size = new System.Drawing.Size(396, 20);
      this.modifiedDateDateTimePicker.TabIndex = 32;
      // 
      // pictureBox1
      // 
      this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "ThumbNailPhoto", true));
      this.pictureBox1.Location = new System.Drawing.Point(648, 42);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(140, 147);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 33;
      this.pictureBox1.TabStop = false;
      // 
      // listBox1
      // 
      this.listBox1.DataSource = this.productBindingSource;
      this.listBox1.DisplayMember = "Name";
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(12, 28);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(228, 433);
      this.listBox1.TabIndex = 34;
      this.listBox1.ValueMember = "ProductID";
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 474);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(productIDLabel);
      this.Controls.Add(this.productIDTextBox);
      this.Controls.Add(nameLabel);
      this.Controls.Add(this.nameTextBox);
      this.Controls.Add(productNumberLabel);
      this.Controls.Add(this.productNumberTextBox);
      this.Controls.Add(colorLabel);
      this.Controls.Add(this.colorTextBox);
      this.Controls.Add(standardCostLabel);
      this.Controls.Add(this.standardCostTextBox);
      this.Controls.Add(listPriceLabel);
      this.Controls.Add(this.listPriceTextBox);
      this.Controls.Add(sizeLabel);
      this.Controls.Add(this.sizeTextBox);
      this.Controls.Add(weightLabel);
      this.Controls.Add(this.weightTextBox);
      this.Controls.Add(productCategoryIDLabel);
      this.Controls.Add(this.productCategoryIDTextBox);
      this.Controls.Add(productModelIDLabel);
      this.Controls.Add(this.productModelIDTextBox);
      this.Controls.Add(sellStartDateLabel);
      this.Controls.Add(this.sellStartDateDateTimePicker);
      this.Controls.Add(sellEndDateLabel);
      this.Controls.Add(this.sellEndDateDateTimePicker);
      this.Controls.Add(discontinuedDateLabel);
      this.Controls.Add(this.discontinuedDateDateTimePicker);
      this.Controls.Add(thumbnailPhotoFileNameLabel);
      this.Controls.Add(this.thumbnailPhotoFileNameTextBox);
      this.Controls.Add(rowguidLabel);
      this.Controls.Add(this.rowguidTextBox);
      this.Controls.Add(modifiedDateLabel);
      this.Controls.Add(this.modifiedDateDateTimePicker);
      this.Controls.Add(this.productBindingNavigator);
      this.Name = "Form2";
      this.Text = "Form2";
      this.Load += new System.EventHandler(this.Form2_Load);
      ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
      this.productBindingNavigator.ResumeLayout(false);
      this.productBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private AdventureWorksDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private AdventureWorksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox productNumberTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox standardCostTextBox;
        private System.Windows.Forms.TextBox listPriceTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox productCategoryIDTextBox;
        private System.Windows.Forms.TextBox productModelIDTextBox;
        private System.Windows.Forms.DateTimePicker sellStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker sellEndDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker discontinuedDateDateTimePicker;
        private System.Windows.Forms.TextBox thumbnailPhotoFileNameTextBox;
        private System.Windows.Forms.TextBox rowguidTextBox;
        private System.Windows.Forms.DateTimePicker modifiedDateDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}