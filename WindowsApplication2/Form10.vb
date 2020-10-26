Imports System.Data.SqlClient
Public Class Form10
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String = "Data Source=NGUYENSYDUNG;Initial Catalog=ThongTinHTT;Integrated Security=True"
        con = New SqlConnection(constring)
        Xuat_hang()
        ComboBox1.Text = danh_sach.Current("MAHD") & " | " & danh_sach.Current("MAKH")
        'Lấy dữ liệu từ bảng đưa vào Combobox 
        For I = 0 To danh_sach.Count - 1
            danh_sach.Position = I
            ComboBox1.Items.Add(danh_sach.Current("MAHD") & " | " &
    danh_sach.Current("MAKH"))
        Next
    End Sub

    Private Sub Xuat_hang()
        lenh = "select * from CSDIEN order by MAHD"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("CSDIEN")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
            con.Close()
            danh_sach = Me.BindingContext(dttable)
            DataGrid1.DataSource = dttable
        End Sub



    Private Sub CB_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim tach As String
        tach = ComboBox1.Text.Substring(0, InStr(ComboBox1.Text, " |")).Trim
        lenh = "select * from CSDIEN where MAHD = '" & tach & "'"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("CSDIEN")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        danh_sach = Me.BindingContext(dttable)
        DataGrid1.DataSource = dttable
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Xuat_hang()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class