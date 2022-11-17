Public Class DateTimeForm
  Private Sub ShowDate_Click(sender As Object, e As EventArgs) Handles ShowDate.Click
    MessageBox.Show(Date.Today.ToString("MMMM dd, yyyy"))
  End Sub

  Private Sub ShowTime_Click(sender As Object, e As EventArgs) Handles ShowTime.Click
    MessageBox.Show(Date.Now.ToString("HH:mm:ss"))
  End Sub
End Class
