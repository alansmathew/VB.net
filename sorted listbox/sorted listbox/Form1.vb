Public Class Form1



    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter a value !")
        Else
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
            TextBox1.Focus()
            ListBox1.Sorted = True

        End If

    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Nothing is selected !")
        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            TextBox1.Focus()
        End If
    End Sub


End Class
