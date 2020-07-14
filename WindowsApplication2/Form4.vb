Public Class Form4
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles DUNG12_Timer1.Tick
        DUNG12_LB1.Text = DateTime.Now.Date.ToShortDateString
        DUNG12_LB2.Text = DateTime.Now.TimeOfDay.ToString
    End Sub
End Class