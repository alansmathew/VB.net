Public Class cal
    Dim ans As Double
    Dim prev As String
    Dim number1 As Double

    Private Sub equal_Click(sender As Object, e As EventArgs) Handles equal.Click
        number1 = textentery.Text
        textentery.Clear()
        Select Case prev
            Case "add"
                ans += number1
            Case "subr"
                ans -= number1
            Case "mul"
                ans *= number1
            Case "div"
                ans /= number1

        End Select

        textentery.Text = ans

    End Sub
    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        number1 = textentery.Text
        ans += number1
        textentery.Clear()
        prev = "add"
    End Sub

    Private Sub subr_Click(sender As Object, e As EventArgs) Handles subr.Click
        number1 = textentery.Text
        If ans = "0" Then
            ans = number1
        Else
            ans -= number1
        End If

        textentery.Clear()
        prev = "subr"
    End Sub

    Private Sub mul_Click(sender As Object, e As EventArgs) Handles mul.Click
        number1 = textentery.Text
        ans *= number1
        textentery.Clear()
        prev = "mul"
    End Sub



    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        number1 = textentery.Text
        ans /= number1
        textentery.Clear()
        prev = "div"
    End Sub

    Private Sub modl_Click(sender As Object, e As EventArgs) Handles modl.Click

        textentery.Clear()
    End Sub
    Private Sub four_Click(sender As Object, e As EventArgs) Handles four.Click
        If textentery.Text <> "0" Then
            textentery.Text += "4"
        Else
            textentery.Text += "4"
        End If
    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
            textentery.Text += "0"
    End Sub

    Private Sub one_Click(sender As Object, e As EventArgs) Handles one.Click
        If textentery.Text <> "0" Then
            textentery.Text += "1"
        Else
            textentery.Text += "1"
        End If

    End Sub


    Private Sub two_Click(sender As Object, e As EventArgs) Handles two.Click
        If textentery.Text <> "0" Then
            textentery.Text += "2"
        Else
            textentery.Text += "2"
        End If
    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
        If textentery.Text <> "0" Then
            textentery.Text += "3"
        Else
            textentery.Text += "3"
        End If
    End Sub

    Private Sub five_Click(sender As Object, e As EventArgs) Handles five.Click
        If textentery.Text <> "0" Then
            textentery.Text += "5"
        Else
            textentery.Text += "5"
        End If
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
        If textentery.Text <> "0" Then
            textentery.Text += "6"
        Else
            textentery.Text += "6"
        End If
    End Sub

    Private Sub seven_Click(sender As Object, e As EventArgs) Handles seven.Click
        If textentery.Text <> "0" Then
            textentery.Text += "7"
        Else
            textentery.Text += "7"
        End If
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
        If textentery.Text <> "0" Then
            textentery.Text += "8"
        Else
            textentery.Text += "8"
        End If
    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click
        If textentery.Text <> "0" Then
            textentery.Text += "9"
        Else
            textentery.Text += "9"
        End If
    End Sub



    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        textentery.Clear()
    End Sub


End Class
