Public Class EvenOddForm
  Private Sub NumberTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NumberTextBox.KeyDown
    If e.KeyCode > 27 AndAlso (e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9) Then
      e.Handled = True
      e.SuppressKeyPress = True
    End If
  End Sub

  Private Sub DecideButton_Click(sender As Object, e As EventArgs) Handles DecideButton.Click
    If NumberTextBox.Text = "" Then
      MessageBox.Show("Please provide a number in the textbox.")
    Else
      Dim n As Integer
      n = Integer.Parse(NumberTextBox.Text)

      If n Mod 2 = 0 Then
        MessageBox.Show("The number is even.")
      Else
        MessageBox.Show("The number is odd.")
      End If
    End If
  End Sub
End Class
