Public Class Form2
    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DUNG12_ĐX.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DUNG12_OUT.Click
        MsgBox("Bạn đã thoát")
        Me.Close()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DUNG12_KH.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub LịchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DUNG12_CAL.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub MáyTínhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DUNG12_MT.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub ThôngTinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DUNG12_IF.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.evn.com.vn/c3/pages-c/Thong-tin-Su-kien-6-12.aspx")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://www.evn.com.vn/c3/pages-c/Dau-tu-Xay-dung-6-13.aspx")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("https://www.evn.com.vn/c3/pages-c/San-xuat-kinh-doanh-6-14.aspx")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        System.Diagnostics.Process.Start("https://www.evn.com.vn/c3/pages-c/Thi-truong-dien-6-15.aspx")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        System.Diagnostics.Process.Start("https://www.evn.com.vn/c3/pages-c/An-toan-dien-Tiet-kiem-dien-6-18.aspx")
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        System.Diagnostics.Process.Start("https://www.evn.com.vn/c3/pages-c/Cong-nghe-va-moi-truong-6-8.aspx")
    End Sub

    Private Sub ChỉSốĐiệnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DUNG12_CSĐ.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub TreeView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DUNG_12_TV.Nodes.Clear()
        DUNG_12_TV.ImageList = Me.anh
        Dung_12_TV.ImageIndex = 2
        Dung_12_TV.SelectedImageIndex = 2
        Dung_12_TV.Nodes.Add("Quận Hải Châu")
        Dung_12_TV.Nodes(0).Nodes.Add("Phường Bình Hiên")
        Dung_12_TV.Nodes(0).Nodes.Add("Phường Bình Thuận")
        Dung_12_TV.Nodes(0).Nodes.Add("Phường Hòa Cương Bắc")
        Dung_12_TV.Nodes(0).Nodes.Add("Phường Hòa Cương Nam")
        Dung_12_TV.Nodes.Add("Quận Thanh Khê")
        Dung_12_TV.Nodes(1).Nodes.Add("Phường An Khê")
        Dung_12_TV.Nodes(1).Nodes(0).Nodes.Add("Nhân viên thu tiền")
        Dung_12_TV.Nodes(1).Nodes(0).Nodes.Add("Quản lý nhân sự")
        Dung_12_TV.Nodes(1).Nodes.Add("Phường Chính Gián")
        Dung_12_TV.Nodes(1).Nodes(1).Nodes.Add("Nhân viên thu tiền")
        Dung_12_TV.Nodes(1).Nodes(1).Nodes.Add("Nhân viên thu tiền")
        Dung_12_TV.Nodes.Add("Quận Sơn Trà")
        Dung_12_TV.Nodes(2).Nodes.Add("Phường An Hải Bắc")
        Dung_12_TV.Nodes(2).Nodes.Add("Phường An Hải Đông")
        Dung_12_TV.Nodes.Add("Quận Ngũ Hành Sơn")
        Dung_12_TV.Nodes(3).Nodes.Add("Phường Hòa Hải")
        Dung_12_TV.Nodes(3).Nodes.Add("Phường Hòa Quý ")
        Dung_12_TV.Nodes(3).Nodes.Add("Phường Mỹ An")
        Dung_12_TV.Nodes.Add("Quận Liên Chiểu")
        Dung_12_TV.Nodes(4).Nodes.Add("Phường Hòa Hiệp Bắc")
        Dung_12_TV.Nodes(4).Nodes.Add("Phường Hòa Hiệp Nam")
        Dung_12_TV.Nodes.Add("Huyện Hòa Vang")
        Dung_12_TV.Nodes.Add("Quận Cẩm Lệ")
        Dung_12_TV.Nodes.Add("Huyện Hoàng Sa")

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles DUNG12_TS5.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub HướngDẫnSửDụngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HướngDẫnSửDụngToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.evn.com.vn/c3/evn-va-khach-hang/Trung-tam-cham-soc-khach-hang-dien-luc-9-144.aspx")
    End Sub

    Private Sub DanhSáchĐãNộpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchĐãNộpToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()
    End Sub
End Class