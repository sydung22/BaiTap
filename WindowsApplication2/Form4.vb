Public Class Form4
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text = DateTime.Now.Year.ToString
        Label4.Text = DateTime.Now.ToLongTimeString
        Dim pt As ListViewItem
        For Each pt In ListView1.Items
            If Convert.ToDateTime(pt.SubItems(0).Text) = Convert.ToDateTime(Now.ToString) Then
                MessageBox.Show(pt.SubItems(1).Text, "Thông báo")
            End If
        Next
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim bd As DateTime = e.Start.ToLongDateString
        Dim kt As DateTime = e.End.ToLongDateString
        TextBox1.Text = bd
        TextBox2.Text = kt
        Dim d2 As DateTime = Convert.ToDateTime(e.End.ToShortDateString())
        Dim d1 As DateTime = Convert.ToDateTime(e.Start.ToShortDateString())
        Dim d3 As TimeSpan
        d3 = d2 - d1
        Label7.Text = d3.Days
        Label11.Text = bd.Year
        Label13.Text = bd.Month
        Label15.Text = bd.Day
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As DateTime
        If TextBox3.Text = "" Then
            MsgBox("Chưa nhập dữ liệu cần tìm")
        Else
            t = Convert.ToDateTime(TextBox3.Text)
            MonthCalendar1.SetSelectionRange(t, t)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        ListView1.Columns.Add("Time", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Name", 100, HorizontalAlignment.Left)
        ListView1.View = View.Details
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim t As DateTime
        Dim t1 As String
        Dim pt As ListViewItem
        t = InputBox("Nhập báo thức", "Thông báo")
        pt = New ListViewItem(t)
        t1 = InputBox("Nhập nội dung", "Thông báo")
        pt.SubItems.Add(t1)
        ListView1.Items.Add(pt)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each it In ListView1.SelectedItems
            ListView1.Items.Remove(it)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class