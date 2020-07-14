<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DUNG12_Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DUNG12_LB1 = New System.Windows.Forms.Label()
        Me.DUNG12_LB2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(29, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'DUNG12_Timer1
        '
        Me.DUNG12_Timer1.Enabled = True
        '
        'DUNG12_LB1
        '
        Me.DUNG12_LB1.AutoSize = True
        Me.DUNG12_LB1.Location = New System.Drawing.Point(228, 255)
        Me.DUNG12_LB1.Name = "DUNG12_LB1"
        Me.DUNG12_LB1.Size = New System.Drawing.Size(51, 17)
        Me.DUNG12_LB1.TabIndex = 1
        Me.DUNG12_LB1.Text = "Label1"
        '
        'DUNG12_LB2
        '
        Me.DUNG12_LB2.AutoSize = True
        Me.DUNG12_LB2.Location = New System.Drawing.Point(228, 283)
        Me.DUNG12_LB2.Name = "DUNG12_LB2"
        Me.DUNG12_LB2.Size = New System.Drawing.Size(51, 17)
        Me.DUNG12_LB2.TabIndex = 2
        Me.DUNG12_LB2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ngày hiện tại :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Thời gian hiện tại : "
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(362, 309)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DUNG12_LB2)
        Me.Controls.Add(Me.DUNG12_LB1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DUNG12_Timer1 As Timer
    Friend WithEvents DUNG12_LB1 As Label
    Friend WithEvents DUNG12_LB2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
