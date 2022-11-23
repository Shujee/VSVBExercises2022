Public Class Form2
  Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ProductModelTableAdapter1.Fill(AdventureWorksDataSet1.ProductModel)
    ProductCategoryTableAdapter1.Fill(AdventureWorksDataSet1.ProductCategory)
    ProductTableAdapter1.Fill(AdventureWorksDataSet1.Product)
  End Sub
End Class