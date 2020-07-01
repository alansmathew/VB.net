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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.Button()
        Me.del = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(219, 72)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(169, 264)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Value"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(66, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 20)
        Me.TextBox1.TabIndex = 2
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(85, 159)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(75, 23)
        Me.add.TabIndex = 3
        Me.add.Text = ">>"
        Me.add.UseVisualStyleBackColor = True
        '
        'del
        '
        Me.del.Location = New System.Drawing.Point(85, 201)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(75, 23)
        Me.del.TabIndex = 4
        Me.del.Text = "X"
        Me.del.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Entered values "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 378)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.del)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents del As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
