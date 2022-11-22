<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EvenOddForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.DecideButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NumberTextBox.Location = New System.Drawing.Point(12, 12)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(776, 71)
        Me.NumberTextBox.TabIndex = 0
        Me.NumberTextBox.Text = "0"
        Me.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DecideButton
        '
        Me.DecideButton.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DecideButton.Location = New System.Drawing.Point(300, 89)
        Me.DecideButton.Name = "DecideButton"
        Me.DecideButton.Size = New System.Drawing.Size(200, 80)
        Me.DecideButton.TabIndex = 1
        Me.DecideButton.Text = "Check"
        Me.DecideButton.UseVisualStyleBackColor = True
        '
        'EvenOddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 176)
        Me.Controls.Add(Me.DecideButton)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Name = "EvenOddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Even/Odd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents DecideButton As Button
End Class
