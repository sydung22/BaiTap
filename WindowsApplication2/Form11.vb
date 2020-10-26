Imports System.Data.SqlClient
Public Class Form11
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim constring As String = "Data Source=NGUYENSYDUNG;Initial Catalog=ThongTinHTT;Integrated Security=True"
        con = New SqlConnection(constring)
        Dim cmd As New SqlCommand
        Dim adp As New SqlDataAdapter
        Dim ds As New DataTable
        Dim sql As String
        sql = "SELECT * FROM HTT WHERE MAKH like '%" & Trim(TextBox1.Text) & "%' or TENKH like N'%" & TextBox1.Text & "%' or CMND like '%" & Trim(TextBox1.Text) & "%' or DIACHI like N'%" & Trim(TextBox1.Text) & "%' or GIOITINH like N'%" & Trim(TextBox1.Text) & "%' or NGAYSINH like '%" & Trim(TextBox1.Text) & "%' "
        Try
            con.Open()
            cmd = New SqlCommand(sql, con)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(ds)
            Dim rp As New CrystalReport3
            rp.Database.Tables("HTT").SetDataSource(ds)
            ReportKH.CrystalReportViewer1.ReportSource = rp
            ReportKH.CrystalReportViewer1.Refresh()
            ReportKH.ShowDialog()
            rp.Dispose()
            rp.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormRPHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String = "Data Source=NGUYENSYDUNG;Initial Catalog=ThongTinHTT;Integrated Security=True"
        con = New SqlConnection(constring)
        Xuat_ds()
    End Sub
    Private Sub Xuat_ds()
        Dim lenh As String
        lenh = "select * from HTT"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("HTT")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGrid1.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String = "select * from HTT where MAKH like '%" & Trim(TextBox1.Text) & "%' or TENKH like N'%" & TextBox1.Text & "%' or CMND like '%" & Trim(TextBox1.Text) & "%' or DIACHI like N'%" & Trim(TextBox1.Text) & "%' or GIOITINH like N'%" & Trim(TextBox1.Text) & "%' or NGAYSINH like '%" & Trim(TextBox1.Text) & "%'"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand(sql, con)
        da.Fill(dt)
        DataGrid1.DataSource = dt
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class