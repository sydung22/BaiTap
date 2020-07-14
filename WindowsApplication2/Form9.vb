
' Private Sub LV3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'  DUNG12_LV1.Items.Clear()
'  DUNG12_LV1.Columns.Add("STT", 40, HorizontalAlignment.Center)
'   DUNG12_LV1.Columns.Add("Mã khách hàng", 100, HorizontalAlignment.Center)
'   DUNG12_LV1.Columns.Add("Mã tháng", 100, HorizontalAlignment.Center)
'   DUNG12_LV1.Columns.Add("Chỉ số cũ", 100, HorizontalAlignment.Center)
''  DUNG12_LV1.Columns.Add("Chỉ số mới", 100, HorizontalAlignment.Center)
'  DUNG12_LV1.View = View.Details
'  Dim ptu As ListViewItem
' Dim i, t, tp As Integer
'  t = 0
'tp = 0
'  For i = 1 To 5
'     ptu = New ListViewItem(i)
'  If i Mod 2 <> 0 Then
'    ptu.SubItems.Add("H" & Microsoft.VisualBasic.Right("0" & t, 2))
'  t = t + 1
'  Else
'  ptu.SubItems.Add("B" & Microsoft.VisualBasic.Right("0" & t, 2))
'  t = t + 1
' End If
' Select Case (i)
'  Case 1
'      ptu.SubItems.Add("205501")
'      ptu.SubItems.Add("96")
'      ptu.SubItems.Add("162")
'  Case 2
'      ptu.SubItems.Add("205501")
'      ptu.SubItems.Add("75")
'      ptu.SubItems.Add("157")
'  Case 3
'      ptu.SubItems.Add("205501")
'     ptu.SubItems.Add("90")
'     ptu.SubItems.Add("192")
' Case 4
'    ptu.SubItems.Add("205501")
'    ptu.SubItems.Add("96")
'    ptu.SubItems.Add("201")
'    Case 5
' ptu.SubItems.Add("205501")
' ptu.SubItems.Add("91")
'           ptu.SubItems.Add("212")
' End Select
'     DUNG12_LV1.Items.Add(ptu)
'  Next
' End Sub

' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DUNG12_BT1.Click
'  Dim it As ListViewItem
'  it = New ListViewItem(6)
'   it.SubItems.Add(DUNG12_TB1.Text)
'   it.SubItems.Add(DUNG12_TB2.Text)
'   it.SubItems.Add(DUNG12_TB3.Text)
'    it.SubItems.Add(DUNG12_TB4.Text)
'     DUNG12_LV1.Items.Add(it)
'   MsgBox("Bạn đã thêm 1 chỉ số")
' End Sub

' Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DUNG12_BT3.Click
'     For Each it In DUNG12_LV1.SelectedItems
'        DUNG12_LV1.Items.Remove(it)
'    Next
' MsgBox("Bạn đã xóa thành công")
' End Sub

'  Private Sub DUNG12_BT4_Click(sender As Object, e As EventArgs) Handles DUNG12_BT4.Click
'  Form2.Show()
'  Me.Hide()
' End Sub
Imports System.Data.SqlClient
Public Class Form9
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String = "Data Source=NGUYENSYDUNG;Initial Catalog=ThongTinHTT;Integrated Security=True"
        con = New SqlConnection(constring)
        Xuat_ds()
        danh_sach_moi(sender, e)
    End Sub
    Private Sub Xuat_ds()
        Dim lenh As String
        lenh = "select * from CSDIEN"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("CSDIEN")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGrid1.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat()
        DUNG12_TB0.Text = danh_sach.Current("MAHD")
        DUNG12_TB1.Text = danh_sach.Current("MAKH")
        DUNG12_TB2.Text = danh_sach.Current("MATH")
        DUNG12_TB3.Text = danh_sach.Current("CSCU")
        DUNG12_TB4.Text = danh_sach.Current("CSMOI")
        DUNG12_TB5.Text = danh_sach.Current("TIEN")
        DUNG12_TB6.Text = danh_sach.Current("LOAIDIEN")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat()
    End Sub

    Private Sub DUNG12_BT1_Click(sender As Object, e As EventArgs) Handles DUNG12_BT1.Click
        If MsgBox("Bạn có muốn thêm không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thêm") = MsgBoxResult.Yes Then
            If DUNG12_TB0.Text = "" Or DUNG12_TB1.Text = "" Or DUNG12_TB2.Text = "" Or DUNG12_TB3.Text = "" Or DUNG12_TB4.Text = "" Then
                MsgBox("Chưa nhập dữ liệu")
            Else
                Try
                    Dim csdien As New CSDIEN(DUNG12_TB0.Text, DUNG12_TB1.Text, DUNG12_TB2.Text, DUNG12_TB3.Text,
          DUNG12_TB4.Text, DUNG12_TB6.Text, DUNG12_TB5.Text)
                    csdien.Luu(lenh)
                    Dim cmd As New SqlCommand(lenh, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    Xuat_ds()
                    MsgBox("Đã thêm thành công")
                Catch ex As Exception
                    MsgBox("Không có dữ liệu mã KH")
                End Try
            End If
        End If
        DUNG12_TB0.Text = ""
        DUNG12_TB1.Text = ""
        DUNG12_TB2.Text = ""
        DUNG12_TB3.Text = ""
        DUNG12_TB4.Text = ""
        DUNG12_TB5.Text = ""
    End Sub

    Private Sub DUNG12_BT2_Click(sender As Object, e As EventArgs) Handles DUNG12_BT2.Click
        If MsgBox("Bạn có muốn sửa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sửa") = MsgBoxResult.Yes Then
            If DUNG12_TB1.Text = "" Or DUNG12_TB2.Text = "" Or DUNG12_TB3.Text = "" Or DUNG12_TB4.Text = "" Then
                MsgBox("Chưa nhập dữ liệu cần sửa")
            Else
                Dim csdien As New CSDIEN(DUNG12_TB0.Text, DUNG12_TB1.Text, DUNG12_TB2.Text, DUNG12_TB3.Text,
          DUNG12_TB4.Text, DUNG12_TB6.Text, DUNG12_TB5.Text)
                csdien.sua(lenh)
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_ds()
                MsgBox("Đã sửa thành công")
            End If
        End If
    End Sub

    Private Sub DUNG12_BT3_Click(sender As Object, e As EventArgs) Handles DUNG12_BT3.Click
        If MsgBox("Bạn có muốn Xóa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            If DUNG12_TB1.Text = "" Then
                MsgBox("Vui lòng chọn giá trị cần xóa")
            Else
                Dim csdien As New CSDIEN(DUNG12_TB0.Text, DUNG12_TB1.Text, DUNG12_TB2.Text, DUNG12_TB3.Text,
          DUNG12_TB4.Text, DUNG12_TB6.Text, DUNG12_TB5.Text)
                csdien.xoa(lenh)
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_ds()
                MsgBox("Đã xóa thành công")
            End If
        End If
    End Sub

    Private Sub DUNG12_BT4_Click(sender As Object, e As EventArgs) Handles DUNG12_BT4.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim constring As String = "Data Source=NGUYENSYDUNG;Initial Catalog=ThongTinHTT;Integrated Security=True"
        con = New SqlConnection(constring)
        Dim cmd As New SqlCommand
        Dim adp As New SqlDataAdapter
        Dim ds As New DataTable
        Dim sql As String
        sql = "SELECT * FROM CSDIEN,HTT WHERE CSDIEN.MAHD='" + DUNG12_TB0.Text + "' AND HTT.MAKH=CSDIEN.MAKH "
        Try
            con.Open()
            cmd = New SqlCommand(sql, con)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(ds)
            Dim rp As New CrystalReport2
            rp.Database.Tables("CSDIEN").SetDataSource(ds)
            rp.Database.Tables("HTT").SetDataSource(ds)
            Formshow.CrystalReportViewer1.ReportSource = rp
            Formshow.CrystalReportViewer1.Refresh()
            Formshow.ShowDialog()
            rp.Dispose()
            rp.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
