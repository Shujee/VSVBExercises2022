Public Class Form3
    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdventureWorksDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdventureWorksDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.AdventureWorksDataSet.Product)

    End Sub
End Class