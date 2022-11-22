Public Class Form1
  Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
    Dim x As Integer = Number.Value

    Dim r As Integer = x Mod 2

    If r = 0 Then
      MessageBox.Show("This is an even number")
    Else
      MessageBox.Show("This is an odd number")
    End If
  End Sub

  Private Sub Number_ValueChanged(sender As Object, e As EventArgs) Handles Number.ValueChanged
    Dim x As Integer = Number.Value

    Dim r As Integer = x Mod 2

    If r = 0 Then
      CheckButton.BackColor = Color.Red
    Else
      CheckButton.BackColor = Color.Green
    End If

  End Sub

  Private Sub OpenForm2Button_Click(sender As Object, e As EventArgs) Handles OpenForm2Button.Click
    Me.Hide()
    Form2.Show()
  End Sub
End Class
