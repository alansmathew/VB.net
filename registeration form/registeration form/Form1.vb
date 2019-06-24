Public Class Form1

    Public Sub message()
        MsgBox(" Enter all values ")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        DateTimePicker1.Value = " 1/1/2000 "
        RichTextBox1.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        ComboBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or
            TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or RichTextBox1.Text = "" Or
            ComboBox1.Text = "" Or CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And
             CheckBox4.Checked = False Then

            message()
        Else
            Form2.Show()
            Form2.Label6.Text = Me.TextBox1.Text
            Form2.Label16.Text = Me.TextBox2.Text
            Form2.Label17.Text = Me.TextBox3.Text
            Form2.Label18.Text = Me.TextBox4.Text
            Form2.Label19.Text = Me.TextBox5.Text
            Form2.Label20.Text = Me.TextBox6.Text
            Form2.Label10.Text = Me.DateTimePicker1.Value
            Form2.Label13.Text = Me.RichTextBox1.Text
            Form2.Label22.Text = Me.ComboBox1.Text
            If RadioButton1.Checked = True Then
                Form2.Label15.Text = Me.RadioButton1.Text
            ElseIf RadioButton2.Checked = True Then
                Form2.Label15.Text = Me.RadioButton2.Text
                ' Else
                ' MsgBox("Nothing is selected !! ")
            End If
            If CheckBox1.Checked = True Then
                Form2.Label21.Text = Form2.Label21.Text & "," & Me.CheckBox1.Text
            End If
            If CheckBox2.Checked = True Then
                Form2.Label21.Text = Form2.Label21.Text & "," & Me.CheckBox2.Text
            End If
            If CheckBox3.Checked = True Then
                Form2.Label21.Text = Form2.Label21.Text & "," & Me.CheckBox3.Text
            End If
            If CheckBox4.Checked = True Then
                Form2.Label21.Text = Form2.Label21.Text & "," & Me.CheckBox4.Text
            End If
        End If
    End Sub
End Class
