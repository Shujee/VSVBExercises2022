namespace E09_Data1
{
    partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
      this.productDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
      this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
      this.productBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
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
      // productDataGridView
      // 
      this.productDataGridView.AutoGenerateColumns = false;
      this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
      this.productDataGridView.DataSource = this.productBindingSource;
      this.productDataGridView.Location = new System.Drawing.Point(12, 28);
      this.productDataGridView.Name = "productDataGridView";
      this.productDataGridView.Size = new System.Drawing.Size(776, 410);
      this.productDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
      this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn2.HeaderText = "Name";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductNumber";
      this.dataGridViewTextBoxColumn3.HeaderText = "ProductNumber";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "Color";
      this.dataGridViewTextBoxColumn4.HeaderText = "Color";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "StandardCost";
      this.dataGridViewTextBoxColumn5.HeaderText = "StandardCost";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "ListPrice";
      this.dataGridViewTextBoxColumn6.HeaderText = "ListPrice";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "Size";
      this.dataGridViewTextBoxColumn7.HeaderText = "Size";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "Weight";
      this.dataGridViewTextBoxColumn8.HeaderText = "Weight";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "ProductCategoryID";
      this.dataGridViewTextBoxColumn9.HeaderText = "ProductCategoryID";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.DataPropertyName = "ProductModelID";
      this.dataGridViewTextBoxColumn10.HeaderText = "ProductModelID";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.DataPropertyName = "SellStartDate";
      this.dataGridViewTextBoxColumn11.HeaderText = "SellStartDate";
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.DataPropertyName = "SellEndDate";
      this.dataGridViewTextBoxColumn12.HeaderText = "SellEndDate";
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      // 
      // dataGridViewTextBoxColumn13
      // 
      this.dataGridViewTextBoxColumn13.DataPropertyName = "DiscontinuedDate";
      this.dataGridViewTextBoxColumn13.HeaderText = "DiscontinuedDate";
      this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
      // 
      // dataGridViewImageColumn1
      // 
      this.dataGridViewImageColumn1.DataPropertyName = "ThumbNailPhoto";
      this.dataGridViewImageColumn1.HeaderText = "ThumbNailPhoto";
      this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
      // 
      // dataGridViewTextBoxColumn14
      // 
      this.dataGridViewTextBoxColumn14.DataPropertyName = "ThumbnailPhotoFileName";
      this.dataGridViewTextBoxColumn14.HeaderText = "ThumbnailPhotoFileName";
      this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
      // 
      // dataGridViewTextBoxColumn15
      // 
      this.dataGridViewTextBoxColumn15.DataPropertyName = "rowguid";
      this.dataGridViewTextBoxColumn15.HeaderText = "rowguid";
      this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
      // 
      // dataGridViewTextBoxColumn16
      // 
      this.dataGridViewTextBoxColumn16.DataPropertyName = "ModifiedDate";
      this.dataGridViewTextBoxColumn16.HeaderText = "ModifiedDate";
      this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.productDataGridView);
      this.Controls.Add(this.productBindingNavigator);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
      this.productBindingNavigator.ResumeLayout(false);
      this.productBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}

