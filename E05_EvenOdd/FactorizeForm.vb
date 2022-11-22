Public Class FactorizeForm
  Private Sub FactorizeButton_Click(sender As Object, e As EventArgs) Handles FactorizeButton.Click
    FactorsList.Items.Clear()

    Dim n As Long = Number.Value
    Dim i As Long = 2

    Dim z = Sum(20, 30)
    Dim w = Sum(645, 432)

    Dim s As String = "asdlkfjaskldf"
    While n > 1
      Dim r As Long = n Mod i

      If r = 0 Then
        FactorsList.Items.Add(i)
        n = n / i
      Else
        i = i + 1
      End If

      'A factor of N cannot be greater than square root of N
      If i > Math.Sqrt(n) + 1 Then
        FactorsList.Items.Add(n)
        Exit While
      End If
    End While
  End Sub

  Function Sum(a As Integer, b As Integer) As Integer
    Dim answer As Integer
    answer = a + b

    Return answer
  End Function
End Class