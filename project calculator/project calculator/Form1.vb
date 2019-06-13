Public Class cal
    Dim ans As Double
    Dim prev As String = "null"
    Dim number1 As Double
    Dim done As Boolean = False
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        textentry.Clear()
        ans = 0
        prev = "null"
        number1 = 0
        done = False

    End Sub

    Function equalto(ByVal temp As Double) As Double
        Select Case prev
            Case "add"
                ans += number1
            Case "subr"
                If ans = "0" Then
                    ans = number1
                Else
                    ans -= number1
                End If
            Case "mul"
                ans *= number1
            Case "div"
                ans /= number1
            Case "module"
                ans = ans Mod number1

        End Select
        number1 = 0
        Return (ans)
    End Function

    Private Sub equal_Click(sender As Object, e As EventArgs) Handles equal.Click
        number1 = textentry.Text
        textentry.Clear()
        ans = equalto(number1)
        textentry.Text = ans
        ans = 0
        done = False

    End Sub
    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        number1 = textentry.Text
        If prev <> "null" Then
            ans = equalto(number1)
        End If
        ans += number1
        textentry.Clear()
        prev = "add"
        done = False
    End Sub

    Private Sub subr_Click(sender As Object, e As EventArgs) Handles subr.Click
        number1 = textentry.Text
        If prev <> "null" Then
            ans = equalto(number1)
        End If
        If ans = "0" Then
            ans = number1
        Else
            ans -= number1
        End If

        textentry.Clear()
        prev = "subr"
        done = False
    End Sub

    Private Sub mul_Click(sender As Object, e As EventArgs) Handles mul.Click
        number1 = textentry.Text
        If prev <> "null" Then
            ans = equalto(number1)
        End If
        If ans = 0 Then
            ans = number1
        Else
            ans *= number1
        End If
        textentry.Clear()
        prev = "mul"
        done = False
    End Sub



    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        number1 = textentry.Text
        If prev <> "null" Then
            ans = equalto(number1)
        End If
        If ans = 0 Then
            ans = number1
        Else
            ans /= number1
        End If
        textentry.Clear()
        prev = "div"
        done = False
    End Sub

    Private Sub modl_Click(sender As Object, e As EventArgs) Handles modl.Click
        number1 = textentry.Text
        If prev <> "null" Then
            ans = equalto(number1)
        End If
        If ans = 0 Then
            ans = number1
        Else
            ans = ans Mod number1
        End If
        prev = "module"
        textentry.Clear()
        done = False
    End Sub

    Private Sub dot_Click(sender As Object, e As EventArgs) Handles dot.Click
        If done = False Then
            If textentry.Text <> "0" Then
                textentry.Text += "."
            Else
                textentry.Text = "."
            End If
            done = True
        End If

    End Sub


    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        If textentry.Text <> "0" Then
            textentry.Text += "0"

        Else
            textentry.Text = "0"
        End If

    End Sub

    Private Sub one_Click(sender As Object, e As EventArgs) Handles one.Click
        If textentry.Text <> "0" Then
            textentry.Text += "1"
        Else
            textentry.Text = "1"
        End If

    End Sub


    Private Sub two_Click(sender As Object, e As EventArgs) Handles two.Click

        If textentry.Text <> "0" Then
            textentry.Text += "2"
        Else
            textentry.Text = "2"
        End If

    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
        If textentry.Text <> "0" Then
            textentry.Text += "3"
        Else
            textentry.Text = "3"
        End If

    End Sub
    Private Sub four_Click(sender As Object, e As EventArgs) Handles four.Click

        If textentry.Text <> "0" Then
            textentry.Text += "4"
        Else
            textentry.Text = "4"
        End If

    End Sub
    Private Sub five_Click(sender As Object, e As EventArgs) Handles five.Click

        If textentry.Text <> "0" Then
            textentry.Text += "5"
        Else
            textentry.Text = "5"
        End If

    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click

        If textentry.Text <> "0" Then
            textentry.Text += "6"
        Else
            textentry.Text = "6"
        End If
    End Sub

    Private Sub seven_Click(sender As Object, e As EventArgs) Handles seven.Click

        If textentry.Text <> "0" Then
            textentry.Text += "7"
        Else
            textentry.Text = "7"
        End If

    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click

        If textentry.Text <> "0" Then
            textentry.Text += "8"
        Else
            textentry.Text = "8"
        End If

    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click

        If textentry.Text <> "0" Then
            textentry.Text += "9"
        Else
            textentry.Text = "9"
        End If

    End Sub

    Private Sub CE_Click(sender As Object, e As EventArgs) Handles CE.Click

        Dim str As String = textentry.Text
        Dim len As Integer
        len = str.Length
        If textentry.Text = "" Then
            MsgBox("No more backspaces available !! ")
        Else
            textentry.Text = str.Substring(0, len - 1)
        End If
        If done = True Then
            dot.Enabled = False
        End If
    End Sub
End Class