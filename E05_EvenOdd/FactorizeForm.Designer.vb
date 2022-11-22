<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FactorizeForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Number = New System.Windows.Forms.NumericUpDown()
        Me.FactorizeButton = New System.Windows.Forms.Button()
        Me.FactorsList = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Number, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Number, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FactorizeButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FactorsList, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Number
        '
        Me.Number.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Number.Location = New System.Drawing.Point(6, 6)
        Me.Number.Margin = New System.Windows.Forms.Padding(6)
        Me.Number.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.Number.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(701, 23)
        Me.Number.TabIndex = 0
        Me.Number.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'FactorizeButton
        '
        Me.FactorizeButton.Location = New System.Drawing.Point(719, 6)
        Me.FactorizeButton.Margin = New System.Windows.Forms.Padding(6)
        Me.FactorizeButton.Name = "FactorizeButton"
        Me.FactorizeButton.Size = New System.Drawing.Size(75, 23)
        Me.FactorizeButton.TabIndex = 1
        Me.FactorizeButton.Text = "Factorize"
        Me.FactorizeButton.UseVisualStyleBackColor = True
        '
        'FactorsList
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.FactorsList, 2)
        Me.FactorsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FactorsList.FormattingEnabled = True
        Me.FactorsList.ItemHeight = 15
        Me.FactorsList.Location = New System.Drawing.Point(6, 41)
        Me.FactorsList.Margin = New System.Windows.Forms.Padding(6)
        Me.FactorsList.Name = "FactorsList"
        Me.FactorsList.Size = New System.Drawing.Size(788, 403)
        Me.FactorsList.TabIndex = 2
        '
        'FactorizeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FactorizeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FactorizeForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Number, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Number As NumericUpDown
    Friend WithEvents FactorizeButton As Button
    Friend WithEvents FactorsList As ListBox
End Class
