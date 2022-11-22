<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Number = New System.Windows.Forms.NumericUpDown()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.OpenForm2Button = New System.Windows.Forms.Button()
        CType(Me.Number, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Number
        '
        Me.Number.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Number.Location = New System.Drawing.Point(12, 12)
        Me.Number.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(376, 71)
        Me.Number.TabIndex = 0
        '
        'CheckButton
        '
        Me.CheckButton.Location = New System.Drawing.Point(12, 89)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(376, 85)
        Me.CheckButton.TabIndex = 1
        Me.CheckButton.Text = "Check"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'OpenForm2Button
        '
        Me.OpenForm2Button.Location = New System.Drawing.Point(271, 180)
        Me.OpenForm2Button.Name = "OpenForm2Button"
        Me.OpenForm2Button.Size = New System.Drawing.Size(117, 23)
        Me.OpenForm2Button.TabIndex = 2
        Me.OpenForm2Button.Text = "Open Form2"
        Me.OpenForm2Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 212)
        Me.ControlBox = False
        Me.Controls.Add(Me.OpenForm2Button)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.Number)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Even/Odd"
        CType(Me.Number, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Number As NumericUpDown
    Friend WithEvents CheckButton As Button
    Friend WithEvents OpenForm2Button As Button
End Class
