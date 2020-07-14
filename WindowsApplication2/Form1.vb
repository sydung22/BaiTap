Public Class Form1
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles DUNG12_TB1.Click
        DUNG12_TB1.Text = ""
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles DUNG12_TB2.Click
        DUNG12_TB2.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DUNG12_BT1.Click
        If DUNG12_TB1.Text = "sydung" And DUNG12_TB2.Text = "2222" Then
            Form2.Show()
            Me.Hide()
        ElseIf DUNG12_TB1.Text = "" And DUNG12_TB2.Text = "" Then
            MsgBox("Vui lòng đăng nhập")
        ElseIf DUNG12_TB1.Text = "" Then
            MsgBox("Vui lòng nhập tài khoản")
        ElseIf DUNG12_TB2.Text = "" Then
            MsgBox("Vui lòng nhập mật khẩu")
        Else
            MsgBox("Sai tài khoản hoặc mật khẩu")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DUNG12_BT2.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles DUNG12_CB1.CheckedChanged
        If (DUNG12_CB1.Checked = True) Then
            DUNG12_TB2.PasswordChar = ""
        Else
            DUNG12_TB2.PasswordChar = "*"
        End If
    End Sub
End Class