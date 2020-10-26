Public Class Form5
    Dim A As Double, B As Double, C As Double, KQ As Double
    Dim CD, CR, CV1, DT1, CV2, DT2, CV3, DT3, HV, BK, C1, C2, C3, x, y, z, P, S As Double
    Dim pi = 3.14
    Dim pheptinh As Integer
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 5

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label11.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Label12.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        A = TextBox1.Text
        pheptinh = 5
        TextBox1.Text = ""
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        A = TextBox1.Text
        pheptinh = 6
        TextBox1.Text = ""
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        pheptinh = 8
        TextBox1.Text = ""
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TextBox1.Text = TextBox1.Text & "-"
    End Sub














    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        A = TextBox1.Text
        pheptinh = 7
        TextBox1.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A = TextBox1.Text
        pheptinh = 1
        TextBox1.Text = ""
    End Sub


    Private Sub Button17_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "."
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (TextBox1.Text = "") Then
            MsgBox("Vui lòng nhập số")
        Else
            B = TextBox1.Text
        End If
        Select Case pheptinh
            Case 1
                KQ = A + B
            Case 2
                KQ = A - B
            Case 3
                KQ = A * B
            Case 4
                If (B = 0) Then
                    MsgBox("Mẫu số không được bằng 0")
                Else
                    KQ = A / B
                End If
            Case 5
                If (B = 0) Then
                    MsgBox("Mẫu số không được bằng 0")
                Else
                    KQ = A Mod B
                End If
            Case 6
                KQ = A ^ B
            Case 7
                If (B = 0) Then
                    MsgBox("Mẫu số không được bằng 0")
                Else
                    KQ = A \ B
                End If
            Case 8
                If (B < 0) Then
                    MsgBox("Giá trị phải lớn hơn hoặc bằng 0")
                Else
                    KQ = Math.Sqrt(B)
                End If
        End Select
        TextBox1.Text = KQ
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        A = TextBox1.Text
        pheptinh = 3
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        A = TextBox1.Text
        pheptinh = 2
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        A = TextBox1.Text
        pheptinh = 4
        TextBox1.Text = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 8

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub
End Class