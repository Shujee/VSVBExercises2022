Public Class Form1
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'AdventureWorksDataSet.ProductCategory' table. You can move, or remove it, as needed.
    ProductCategoryTableAdapter1.Fill(AdventureWorksDataSet.ProductCategory)
    ProductModelTableAdapter1.Fill(AdventureWorksDataSet.ProductModel)
    ProductTableAdapter1.Fill(AdventureWorksDataSet.Product)
  End Sub
End Class
