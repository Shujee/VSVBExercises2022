Public Class DigiClock
  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    TimeLabel.Text = Date.Now.ToString("HH:mm:ss")
  End Sub
End Class
