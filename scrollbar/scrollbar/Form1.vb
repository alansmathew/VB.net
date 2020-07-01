Public Class Form1
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        TextBox1.Text = HScrollBar1.Value
        'Me.BackColor = Color.FromArgb(HScrollBar1.Value, VScrollBar1.Value, HScrollBar2.Value)
        Button1.BackColor = Color.FromArgb(HScrollBar1.Value, VScrollBar1.Value, HScrollBar2.Value)
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        TextBox4.Text = VScrollBar1.Value
        'Me.BackColor = Color.FromArgb(HScrollBar1.Value, VScrollBar1.Value, HScrollBar2.Value)
        Button1.BackColor = Color.FromArgb(HScrollBar1.Value, VScrollBar1.Value, HScrollBar2.Value)
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        TextBox2.Text = HScrollBar2.Value
        'Me.BackColor = Color.FromArgb(HScrollBar1.Value, VScrollBar1.Value, HScrollBar2.Value)
        Button1.BackColor = Color.FromArgb(HScrollBar1.Value, VScrollBar1.Value, HScrollBar2.Value)
    End Sub


End Class
