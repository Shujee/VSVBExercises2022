Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class AnalogClock
  Dim center As New Point(Me.Width / 2, Me.Height / 2)
  Dim w As Integer = Me.Width / 2 * 0.8
  Dim h As Integer = Me.Height / 2 * 0.8

  Dim hPen As New Pen(Brushes.Black, 12)
  Dim mPen As New Pen(Brushes.Black, 8)
  Dim sPen As New Pen(Brushes.Red, 4)

  Private Sub AnalogClock_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
    e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
    e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

    Dim hr As Integer = (Date.Now.Hour + Date.Now.Minute / 60) * 30 - 90
    Dim min As Integer = (Date.Now.Minute + Date.Now.Second / 60) * 6 - 90
    Dim sec As Integer = Date.Now.Second * 6 - 90

    Dim p As New Point

    p.X = center.X + w * Math.Cos(Radians(hr)) * 0.3
    p.Y = center.Y + h * Math.Sin(Radians(hr)) * 0.3
    e.Graphics.DrawLine(hPen, center, p)

    p.X = center.X + w * Math.Cos(Radians(min)) * 0.45
    p.Y = center.Y + h * Math.Sin(Radians(min)) * 0.45
    e.Graphics.DrawLine(mPen, center, p)

    p.X = center.X + w * Math.Cos(Radians(sec)) * 0.45
    p.Y = center.Y + h * Math.Sin(Radians(sec)) * 0.45
    e.Graphics.DrawLine(sPen, center, p)

    Me.Text = Date.Now.ToString()
  End Sub

  Private Function Radians(value As Double) As Double
    Return (value * Math.PI) / 180
  End Function

  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    Me.Invalidate()
  End Sub

  Private Sub AnalogClock_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
    center.X = Me.Width / 2 - 10
    center.Y = Me.Height / 2 - 20

    w = (Me.Width / 2)
    h = (Me.Height / 2)
  End Sub
End Class