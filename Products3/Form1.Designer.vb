<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AdventureWorksDataSet = New Products3.AdventureWorksDataSet()
        Me.AdventureWorksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter1 = New Products3.AdventureWorksDataSetTableAdapters.ProductTableAdapter()
        Me.ProductCategoryTableAdapter1 = New Products3.AdventureWorksDataSetTableAdapters.ProductCategoryTableAdapter()
        Me.ProductModelTableAdapter1 = New Products3.AdventureWorksDataSetTableAdapters.ProductModelTableAdapter()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StandardCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductModelIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SellStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThumbNailPhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdventureWorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.ProductNumberDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.StandardCostDataGridViewTextBoxColumn, Me.ListPriceDataGridViewTextBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.ProductCategoryIDDataGridViewTextBoxColumn, Me.ProductModelIDDataGridViewTextBoxColumn, Me.SellStartDateDataGridViewTextBoxColumn, Me.SellEndDateDataGridViewTextBoxColumn, Me.ThumbNailPhotoDataGridViewImageColumn})
        Me.DataGridView1.DataMember = "Product"
        Me.DataGridView1.DataSource = Me.AdventureWorksDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1233, 683)
        Me.DataGridView1.TabIndex = 0
        '
        'AdventureWorksDataSet
        '
        Me.AdventureWorksDataSet.DataSetName = "AdventureWorksDataSet"
        Me.AdventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdventureWorksDataSetBindingSource
        '
        Me.AdventureWorksDataSetBindingSource.DataSource = Me.AdventureWorksDataSet
        Me.AdventureWorksDataSetBindingSource.Position = 0
        '
        'ProductTableAdapter1
        '
        Me.ProductTableAdapter1.ClearBeforeFill = True
        '
        'ProductCategoryTableAdapter1
        '
        Me.ProductCategoryTableAdapter1.ClearBeforeFill = True
        '
        'ProductModelTableAdapter1
        '
        Me.ProductModelTableAdapter1.ClearBeforeFill = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 200
        '
        'ProductNumberDataGridViewTextBoxColumn
        '
        Me.ProductNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber"
        Me.ProductNumberDataGridViewTextBoxColumn.HeaderText = "Number"
        Me.ProductNumberDataGridViewTextBoxColumn.Name = "ProductNumberDataGridViewTextBoxColumn"
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        '
        'StandardCostDataGridViewTextBoxColumn
        '
        Me.StandardCostDataGridViewTextBoxColumn.DataPropertyName = "StandardCost"
        Me.StandardCostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.StandardCostDataGridViewTextBoxColumn.Name = "StandardCostDataGridViewTextBoxColumn"
        '
        'ListPriceDataGridViewTextBoxColumn
        '
        Me.ListPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice"
        Me.ListPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice"
        Me.ListPriceDataGridViewTextBoxColumn.Name = "ListPriceDataGridViewTextBoxColumn"
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'ProductCategoryIDDataGridViewTextBoxColumn
        '
        Me.ProductCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "ProductCategoryID"
        Me.ProductCategoryIDDataGridViewTextBoxColumn.DataSource = Me.AdventureWorksDataSet
        Me.ProductCategoryIDDataGridViewTextBoxColumn.DisplayMember = "ProductCategory.Name"
        Me.ProductCategoryIDDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.ProductCategoryIDDataGridViewTextBoxColumn.Name = "ProductCategoryIDDataGridViewTextBoxColumn"
        Me.ProductCategoryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductCategoryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProductCategoryIDDataGridViewTextBoxColumn.ValueMember = "ProductCategory.ProductCategoryID"
        Me.ProductCategoryIDDataGridViewTextBoxColumn.Width = 200
        '
        'ProductModelIDDataGridViewTextBoxColumn
        '
        Me.ProductModelIDDataGridViewTextBoxColumn.DataPropertyName = "ProductModelID"
        Me.ProductModelIDDataGridViewTextBoxColumn.DataSource = Me.AdventureWorksDataSet
        Me.ProductModelIDDataGridViewTextBoxColumn.DisplayMember = "ProductModel.Name"
        Me.ProductModelIDDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ProductModelIDDataGridViewTextBoxColumn.Name = "ProductModelIDDataGridViewTextBoxColumn"
        Me.ProductModelIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductModelIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProductModelIDDataGridViewTextBoxColumn.ValueMember = "ProductModel.ProductModelID"
        Me.ProductModelIDDataGridViewTextBoxColumn.Width = 200
        '
        'SellStartDateDataGridViewTextBoxColumn
        '
        Me.SellStartDateDataGridViewTextBoxColumn.DataPropertyName = "SellStartDate"
        Me.SellStartDateDataGridViewTextBoxColumn.HeaderText = "Start Date"
        Me.SellStartDateDataGridViewTextBoxColumn.Name = "SellStartDateDataGridViewTextBoxColumn"
        '
        'SellEndDateDataGridViewTextBoxColumn
        '
        Me.SellEndDateDataGridViewTextBoxColumn.DataPropertyName = "SellEndDate"
        Me.SellEndDateDataGridViewTextBoxColumn.HeaderText = "End Date"
        Me.SellEndDateDataGridViewTextBoxColumn.Name = "SellEndDateDataGridViewTextBoxColumn"
        '
        'ThumbNailPhotoDataGridViewImageColumn
        '
        Me.ThumbNailPhotoDataGridViewImageColumn.DataPropertyName = "ThumbNailPhoto"
        Me.ThumbNailPhotoDataGridViewImageColumn.HeaderText = "Photo"
        Me.ThumbNailPhotoDataGridViewImageColumn.Name = "ThumbNailPhotoDataGridViewImageColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 707)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdventureWorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AdventureWorksDataSetBindingSource As BindingSource
    Friend WithEvents AdventureWorksDataSet As AdventureWorksDataSet
    Friend WithEvents ProductTableAdapter1 As AdventureWorksDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductCategoryTableAdapter1 As AdventureWorksDataSetTableAdapters.ProductCategoryTableAdapter
    Friend WithEvents ProductModelTableAdapter1 As AdventureWorksDataSetTableAdapters.ProductModelTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StandardCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCategoryIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents ProductModelIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents SellStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThumbNailPhotoDataGridViewImageColumn As DataGridViewImageColumn
End Class
