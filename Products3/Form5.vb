Public Class Form5
  Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    Me.Validate()
    Me.ProductBindingSource.EndEdit()
    Me.TableAdapterManager.UpdateAll(Me.AdventureWorksDataSet)

  End Sub
  Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'AdventureWorksDataSet.Product' table. You can move, or remove it, as needed.
    Me.ProductCategoryTableAdapter1.Fill(Me.AdventureWorksDataSet.ProductCategory)
    Me.ProductModelTableAdapter1.Fill(Me.AdventureWorksDataSet.ProductModel)
    Me.ProductTableAdapter.Fill(Me.AdventureWorksDataSet.Product)
  End Sub
End Class