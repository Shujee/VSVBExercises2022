Imports System.Text.Json.Serialization

<JsonDerivedType(GetType(Circle), NameOf(Circle)),
  JsonDerivedType(GetType(Rect), NameOf(Rect)),
  JsonDerivedType(GetType(Line), NameOf(Line))>
Public MustInherit Class Shape
  Public Property P1 As New Point
  Public Property P2 As New Point
  Public MustOverride ReadOnly Property Type As ShapeType
  Public Property FillColor As Integer
  Public Property BorderColor As Integer
  Public Property BorderThickness As Integer
  Public MustOverride Sub Draw(g As Graphics)
End Class

Public Class Circle
  Inherits Shape

  Public Overrides ReadOnly Property Type As ShapeType
    Get
      Return ShapeType.Circle
    End Get
  End Property

  Public Overrides Sub Draw(g As Graphics)
    If Me.FillColor <> Color.Transparent.ToArgb() Then
      Using b As New SolidBrush(Color.FromArgb(Me.FillColor))
        g.FillEllipse(b, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y)
      End Using
    End If

    If Me.BorderColor <> Color.Transparent.ToArgb() Then
      Using b As New SolidBrush(Color.FromArgb(Me.BorderColor))
        Using p As New Pen(b, Me.BorderThickness)
          g.DrawEllipse(p, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y)
        End Using
      End Using
    End If
  End Sub
End Class

Public Class Rect
  Inherits Shape

  Public Overrides ReadOnly Property Type As ShapeType
    Get
      Return ShapeType.Rectangle
    End Get
  End Property

  Public Overrides Sub Draw(g As Graphics)
    If Me.FillColor <> Color.Transparent.ToArgb() Then
      Using b As New SolidBrush(Color.FromArgb(Me.FillColor))
        g.FillRectangle(b, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y)
      End Using
    End If

    If Me.BorderColor <> Color.Transparent.ToArgb() Then
      Using b As New SolidBrush(Color.FromArgb(Me.BorderColor))
        Using p As New Pen(b, Me.BorderThickness)
          g.DrawRectangle(p, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y)
        End Using
      End Using
    End If
  End Sub
End Class

Public Class Line
  Inherits Shape

  Public Overrides ReadOnly Property Type As ShapeType
    Get
      Return ShapeType.Line
    End Get
  End Property

  Public Overrides Sub Draw(g As Graphics)
    If Me.BorderColor <> Color.Transparent.ToArgb() Then
      Using b As New SolidBrush(Color.FromArgb(Me.BorderColor))
        Using p As New Pen(b, Me.BorderThickness)
          g.DrawLine(p, P1.X, P1.Y, P2.X, P2.Y)
        End Using
      End Using
    End If
  End Sub
End Class