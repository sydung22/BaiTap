Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DUNG12_BT1.Click
        Dim max As Integer = 50000
        Dim i As Integer
        Me.DUNG12_PB.Maximum = max
        Dim st As String
        For i = 0 To max
            DUNG12_PB.Value = i
            st = Math.Floor(((i / max)) * 100).ToString & "%"
            Application.DoEvents()
            Label1.Text = "Đang thực hiện " & st
        Next
        Label1.Text = "Cập nhật thành công "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DUNG12_BT2.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class