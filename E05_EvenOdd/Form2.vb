Public Class Form2
  Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
    Dim s As String = NameTextBox.Text

    If s <> "" Then
      NamesList.Items.Add(s)
      NameTextBox.Text = ""
      NameTextBox.Focus()
    End If
  End Sub
End Class