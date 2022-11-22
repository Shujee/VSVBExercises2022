<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.NamesList = New System.Windows.Forms.ListBox()
        Me.TLP = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.Location = New System.Drawing.Point(9, 9)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(9)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(271, 23)
        Me.NameTextBox.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Location = New System.Drawing.Point(298, 9)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(9)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(67, 23)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'NamesList
        '
        Me.NamesList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLP.SetColumnSpan(Me.NamesList, 2)
        Me.NamesList.FormattingEnabled = True
        Me.NamesList.ItemHeight = 15
        Me.NamesList.Location = New System.Drawing.Point(9, 50)
        Me.NamesList.Margin = New System.Windows.Forms.Padding(9)
        Me.NamesList.Name = "NamesList"
        Me.NamesList.Size = New System.Drawing.Size(356, 364)
        Me.NamesList.TabIndex = 2
        '
        'TLP
        '
        Me.TLP.ColumnCount = 2
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP.Controls.Add(Me.NameTextBox, 0, 0)
        Me.TLP.Controls.Add(Me.NamesList, 0, 1)
        Me.TLP.Controls.Add(Me.AddButton, 1, 0)
        Me.TLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP.Location = New System.Drawing.Point(0, 0)
        Me.TLP.Name = "TLP"
        Me.TLP.RowCount = 2
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP.Size = New System.Drawing.Size(374, 431)
        Me.TLP.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.TLP)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Second Form"
        Me.TLP.ResumeLayout(False)
        Me.TLP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents NamesList As ListBox
    Friend WithEvents TLP As TableLayoutPanel
End Class
