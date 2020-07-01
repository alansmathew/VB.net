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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(278, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(35, 20)
        Me.TextBox1.TabIndex = 5
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(78, 104)
        Me.HScrollBar1.Maximum = 255
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(187, 17)
        Me.HScrollBar1.TabIndex = 6
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(78, 135)
        Me.HScrollBar2.Maximum = 255
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(187, 17)
        Me.HScrollBar2.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(278, 135)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(35, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(116, 175)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(35, 20)
        Me.TextBox4.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(22, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "r"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "g"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "b"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(78, 163)
        Me.VScrollBar1.Maximum = 255
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(22, 107)
        Me.VScrollBar1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.No
        Me.Button1.Location = New System.Drawing.Point(134, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 42)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(360, 320)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "ttttttt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents HScrollBar2 As System.Windows.Forms.HScrollBar
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
