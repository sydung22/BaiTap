Public Class Form8
    Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles DUNG12_RTB1.LinkClicked
        System.Diagnostics.Process.Start("C:\Users\SyDung\AppData\Local\CocCoc\Browser\Application\browser.exe", e.LinkText)
    End Sub

    Private Sub DUNG12_BT1_Click(sender As Object, e As EventArgs) Handles DUNG12_BT1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class