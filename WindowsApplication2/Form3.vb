
'Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
' DUNG12_LV2.Items.Clear()
'DUNG12_LV2.Columns.Add("STT", 40, HorizontalAlignment.Center)
'DUNG12_LV2.Columns.Add("Mã khách hàng", 100, HorizontalAlignment.Center)
'DUNG12_LV2.Columns.Add("Họ Tên", 120, HorizontalAlignment.Center)
'DUNG12_LV2.Columns.Add("CMND", 100, HorizontalAlignment.Center)
'DUNG12_LV2.Columns.Add("Địa chỉ", 200, HorizontalAlignment.Center)
'DUNG12_LV2.Columns.Add("Giới tính", 100, HorizontalAlignment.Center)
'DUNG12_LV2.Columns.Add("Ngày sinh", 100, HorizontalAlignment.Center)
'DUNG12_LV2.Columns.Add("SĐT", 100, HorizontalAlignment.Center)
'DUNG12_LV2.Columns.Add("Ngày đăng ký", 100, HorizontalAlignment.Center)
'DUNG12_LV2.View = View.Details
'End Sub

' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DUNG12_BT1.Click
'Dim it As ListViewItem
'   it = New ListViewItem(11)
'    it.SubItems.Add(DUNG12_TB1.Text)
'    it.SubItems.Add(DUNG12_TB2.Text)
'     it.SubItems.Add(DUNG12_TB3.Text)
'     it.SubItems.Add(DUNG12_TB4.Text)
' If (DUNG12_RDB2.Checked = True) Then
'      it.SubItems.Add("Nữ")
'Else
'       it.SubItems.Add("Nam")
'End If

'   DUNG12_DTP1.CustomFormat = "dd-MM-yyyy"
'  DUNG12_DTP2.CustomFormat = "dd-MM-yyyy"
'  it.SubItems.Add(DUNG12_DTP1.Text)
'  it.SubItems.Add(DUNG12_TB7.Text)
'  it.SubItems.Add(DUNG12_DTP2.Text)
'  DUNG12_LV2.Items.Add(it)
'  MsgBox("Bạn đã thêm 1 khách hàng")
'End Sub

' Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DUNG12_BT3.Click
' For Each it In DUNG12_LV2.SelectedItems
'       DUNG12_LV2.Items.Remove(it)
'Next
'     MsgBox("Bạn đã xóa thành công")
'  End Sub

'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DUNG12_BT2.Click
'   MsgBox("Bạn đã sửa thành công")
' End Sub

'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles DUNG12_BT4.Click
'    Form2.Show()
'Me.Hide()
' End Sub
Imports System.Data.SqlClient
Public Class Form3
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String = "Data Source=NGUYENSYDUNG;Initial Catalog=ThongTinHTT;Integrated Security=True"
        con = New SqlConnection(constring)
        Xuat_ds()
        danh_sach_moi(sender, e)
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
    Private Sub xuat()
        DUNG12_DTP1.CustomFormat = "yyyy-MM-dd"
        DUNG12_DTP2.CustomFormat = "yyyy-MM-dd"
        DUNG12_TB1.Text = danh_sach.Current("MAKH")
        DUNG12_TB2.Text = danh_sach.Current("TENKH")
        DUNG12_TB3.Text = danh_sach.Current("CMND")
        DUNG12_TB4.Text = danh_sach.Current("DIACHI")
        DUNG12_TB7.Text = danh_sach.Current("SDT")
        If danh_sach.Current("GIOITINH") = "Nam" Then
            DUNG12_RDB1.Checked = True
        Else
            DUNG12_RDB2.Checked = True
        End If
        DUNG12_DTP1.Text = danh_sach.Current("NGAYSINH")
        DUNG12_DTP2.Text = danh_sach.Current("NGAYDK")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat()
    End Sub

    Private Sub DUNG12_BT1_Click(sender As Object, e As EventArgs) Handles DUNG12_BT1.Click
        If MsgBox("Bạn có muốn thêm không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thêm") = MsgBoxResult.Yes Then
            If DUNG12_TB1.Text = "" Or DUNG12_TB2.Text = "" Or DUNG12_TB3.Text = "" Or DUNG12_TB4.Text = "" Or DUNG12_TB7.Text = "" Then
                MsgBox("Chưa nhập dữ liệu")
            Else
                Try
                    Dim s As String
                    If (DUNG12_RDB2.Checked = True) Then
                        s = "Nữ"
                    Else
                        s = "Nam"
                    End If
                    lenh = "insert into HTT(MAKH,TENKH,CMND,DIACHI,SDT,GIOITINH,NGAYSINH,NGAYDK) values(N'" &
                DUNG12_TB1.Text & "',N'" & DUNG12_TB2.Text & "',N'" & DUNG12_TB3.Text &
                "',N'" & DUNG12_TB4.Text & "',N'" & DUNG12_TB7.Text & "',N'" & s & "','" & DUNG12_DTP1.Text & "','" & DUNG12_DTP2.Text & "')"
                    Dim cmd As New SqlCommand(lenh, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    Xuat_ds()
                    MsgBox("Đã thêm thành công")
                Catch ex As Exception
                    MsgBox("Dữ liệu không hợp lệ")
                End Try
            End If
            End If
        DUNG12_TB1.Text = ""
        DUNG12_TB2.Text = ""
        DUNG12_TB3.Text = ""
        DUNG12_TB4.Text = ""
        DUNG12_TB7.Text = ""
    End Sub

    Private Sub DUNG12_BT2_Click(sender As Object, e As EventArgs) Handles DUNG12_BT2.Click
        If MsgBox("Bạn có muốn sửa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sửa") = MsgBoxResult.Yes Then
            If DUNG12_TB1.Text = "" Or DUNG12_TB2.Text = "" Or DUNG12_TB3.Text = "" Or DUNG12_TB4.Text = "" Or DUNG12_TB7.Text = "" Then
                MsgBox("Chưa nhập dữ liệu cần sửa")
            Else
                Dim s As String
                If (DUNG12_RDB2.Checked = True) Then
                    s = "Nữ"
                Else
                    s = "Nam"
                End If
                lenh = "Update HTT set MAKH=N'" &
                DUNG12_TB1.Text & "',TENKH=N'" & DUNG12_TB2.Text & "',CMND=N'" & DUNG12_TB3.Text &
                "',DIACHI=N'" & DUNG12_TB4.Text & "',SDT=N'" & DUNG12_TB7.Text & "',GIOITINH=N'" & s & "',NGAYSINH='" & DUNG12_DTP1.Text & "',NGAYDK='" & DUNG12_DTP2.Text & "' where MAKH = '" & Trim(DUNG12_TB1.Text) & "'"
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
                lenh = "delete from HTT where MAKH = '" & DUNG12_TB1.Text & "'"
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
End Class