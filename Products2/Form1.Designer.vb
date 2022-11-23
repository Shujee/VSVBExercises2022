<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.AdventureWorks1 = New Products2.AdventureWorks()
        Me.ProductTableAdapter1 = New Products2.AdventureWorksTableAdapters.ProductTableAdapter()
        Me.ProductCategoryTableAdapter1 = New Products2.AdventureWorksTableAdapters.ProductCategoryTableAdapter()
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        CType(Me.AdventureWorks1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdventureWorks1
        '
        Me.AdventureWorks1.DataSetName = "AdventureWorks"
        Me.AdventureWorks1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableAdapter1
        '
        Me.ProductTableAdapter1.ClearBeforeFill = True
        '
        'ProductCategoryTableAdapter1
        '
        Me.ProductCategoryTableAdapter1.ClearBeforeFill = True
        '
        'BS
        '
        Me.BS.DataMember = "Product"
        Me.BS.DataSource = Me.AdventureWorks1
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Name", True))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(331, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "ListPrice", True))
        Me.TextBox2.Location = New System.Drawing.Point(12, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(331, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "SellStartDate", True))
        Me.TextBox3.Location = New System.Drawing.Point(12, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(331, 20)
        Me.TextBox3.TabIndex = 2
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(93, 108)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.PreviousButton.TabIndex = 3
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(174, 108)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 4
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 141)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AdventureWorks1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdventureWorks1 As AdventureWorks
    Friend WithEvents ProductTableAdapter1 As AdventureWorksTableAdapters.ProductTableAdapter
    Friend WithEvents ProductCategoryTableAdapter1 As AdventureWorksTableAdapters.ProductCategoryTableAdapter
    Friend WithEvents BS As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
End Class
