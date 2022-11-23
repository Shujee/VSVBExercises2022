Public Class Form1
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ProductCategoryTableAdapter1.Fill(AdventureWorks1.ProductCategory)
    ProductTableAdapter1.Fill(AdventureWorks1.Product)
  End Sub

  Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
    If BS.Position > 0 Then BS.MovePrevious()
  End Sub

  Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
    If BS.Position < BS.Count - 1 Then BS.MoveNext()
  End Sub
End Class
