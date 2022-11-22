<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DateTimeForm
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
        Me.ShowTime = New System.Windows.Forms.Button()
        Me.ShowDate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShowTime
        '
        Me.ShowTime.BackColor = System.Drawing.Color.DodgerBlue
        Me.ShowTime.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ShowTime.Location = New System.Drawing.Point(189, 221)
        Me.ShowTime.Name = "ShowTime"
        Me.ShowTime.Size = New System.Drawing.Size(423, 143)
        Me.ShowTime.TabIndex = 0
        Me.ShowTime.Text = "Show Current Time"
        Me.ShowTime.UseVisualStyleBackColor = False
        '
        'ShowDate
        '
        Me.ShowDate.BackColor = System.Drawing.Color.DodgerBlue
        Me.ShowDate.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ShowDate.Location = New System.Drawing.Point(189, 57)
        Me.ShowDate.Name = "ShowDate"
        Me.ShowDate.Size = New System.Drawing.Size(423, 143)
        Me.ShowDate.TabIndex = 1
        Me.ShowDate.Text = "Show Current Date"
        Me.ShowDate.UseVisualStyleBackColor = False
        '
        'DateTimeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ShowDate)
        Me.Controls.Add(Me.ShowTime)
        Me.Name = "DateTimeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date & Time Information"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShowTime As Button
    Friend WithEvents ShowDate As Button
End Class
