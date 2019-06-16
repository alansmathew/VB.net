Public Class Form1
    Dim score As Integer = 0
    Dim i As Integer = 1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label2.Text > 0 Then
            Label2.Text = Label2.Text - 1
        Else
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        q1.Visible = True
        q2.Visible = False
        q3.Visible = False
        Timer1.Start()
        Label2.Text = 10
        '   RadioButton1.Checked = False
        ' RadioButton2.Checked = False
        ' RadioButton3.Checked = False
        ' RadioButton4.Checked = False
        score = 0


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If i = 1 Then
            If RadioButton3.Checked = True Then
                score += RadioButton3.Tag
            End If
            q1.Visible = False
            q2.Visible = True
            Label2.Text = 10
            i += 1
            Label3.Text = i

        ElseIf i = 2 Then
            If RadioButton8.Checked = True Then
                score += RadioButton8.Tag
            End If
            Label2.Text = 10
            q2.Visible = False
            q3.Visible = True
            i += 1
            Label3.Text = i
        Else
            If RadioButton10.Checked = True Then
                score += RadioButton10.Tag
            End If
            Timer1.Stop()
            q3.Enabled = False
            MsgBox("Total score is " & score)
        End If

    End Sub

End Class
