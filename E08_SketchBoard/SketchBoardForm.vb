Public Class SketchBoardForm
  Private currentShape As Shape
  Private currentShapeType As ShapeType = ShapeType.None
  Private P1Marked As Boolean = False

  Private shapes As New List(Of Shape)

  Private Sub SketchBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    FillCombo.SelectedItem = "Transparent"
    BorderCombo.SelectedItem = "Black"
  End Sub

  Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
    currentShapeType = ShapeType.Circle
    P1Marked = False
  End Sub
  Private Sub RectButton_Click(sender As Object, e As EventArgs) Handles RectButton.Click
    currentShapeType = ShapeType.Rectangle
    P1Marked = False
  End Sub

  Private Sub LineButton_Click(sender As Object, e As EventArgs) Handles LineButton.Click
    currentShapeType = ShapeType.Line
    P1Marked = False
  End Sub

  Private Sub SketchBoardForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
    If currentShapeType <> ShapeType.None AndAlso Not P1Marked Then
      P1Marked = True

      If currentShapeType = ShapeType.Rectangle Then
        currentShape = New Rect() With
                  {
                  .P1 = e.Location,
                  .P2 = e.Location,
                  .BorderColor = ColorNameToValue(BorderCombo.SelectedItem),
                  .BorderThickness = Integer.Parse(BorderThicknessTextBox.Text),
                  .FillColor = ColorNameToValue(FillCombo.SelectedItem)
                  }
      ElseIf currentShapeType = ShapeType.Circle Then
        currentShape = New Circle() With
                  {
                  .P1 = e.Location,
                  .P2 = e.Location,
                  .BorderColor = ColorNameToValue(BorderCombo.SelectedItem),
                  .BorderThickness = Integer.Parse(BorderThicknessTextBox.Text),
                  .FillColor = ColorNameToValue(FillCombo.SelectedItem)
                  }
      ElseIf currentShapeType = ShapeType.Line Then
        currentShape = New Line() With
                  {
                  .P1 = e.Location,
                  .P2 = e.Location,
                  .BorderColor = ColorNameToValue(BorderCombo.SelectedItem),
                  .BorderThickness = Integer.Parse(BorderThicknessTextBox.Text),
                  .FillColor = ColorNameToValue(FillCombo.SelectedItem)
                  }
      End If

      Me.Invalidate()
    End If
  End Sub

  Private Sub SketchBoardForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
    If P1Marked AndAlso currentShape IsNot Nothing Then
      currentShape.P2 = e.Location
      Me.Invalidate()
    End If
  End Sub

  Private Sub SketchBoardForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
    If P1Marked AndAlso currentShape IsNot Nothing Then
      currentShape.P2 = e.Location
      shapes.Add(currentShape)
      Me.Invalidate()
      P1Marked = False
    End If
  End Sub

  Private Sub SketchBoardForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    For Each shp In shapes
      shp.Draw(e.Graphics)
    Next

    If currentShape IsNot Nothing Then currentShape.Draw(e.Graphics)
  End Sub

  Private Function ColorNameToValue(name As String) As Integer
    Return Color.FromKnownColor(DirectCast([Enum].Parse(GetType(KnownColor), name), KnownColor)).ToArgb()
  End Function

  Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
    Dim json As String
    json = System.Text.Json.JsonSerializer.Serialize(shapes.ToArray())

    Dim dlg As New SaveFileDialog With {
        .Filter = "JSON Files|*.json",
        .Title = "Save Drawing"
    }

    If dlg.ShowDialog() = DialogResult.OK Then
      System.IO.File.WriteAllText(dlg.FileName, json)
    End If
  End Sub

  Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
    Dim dlg As New OpenFileDialog With {
            .Filter = "JSON Files|*.json",
            .Title = "Open Drawing"
        }

    If dlg.ShowDialog() = DialogResult.OK Then
      Dim json As String
      json = System.IO.File.ReadAllText(dlg.FileName)

      Try
        Dim shp = System.Text.Json.JsonSerializer.Deserialize(Of Shape())(json)
        shapes.Clear()
        shapes.AddRange(shp)

        Me.Invalidate()
      Catch ex As Exception
        MessageBox.Show("Could not open selected drawing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub
End Class
