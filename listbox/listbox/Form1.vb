Public Class add2


    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Nothing selected!")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If

    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If ListBox2.SelectedItem <> "" Then
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        ElseIf ListBox1.SelectedItem <> "" Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)

        Else
            MsgBox("Nothing selected!")
        End If

    End Sub


    Private Sub ad_Click(sender As Object, e As EventArgs) Handles ad.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter a value !")
        Else

            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
        End If
    End Sub


End Class
