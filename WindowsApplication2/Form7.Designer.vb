<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.DUNG12_PB = New System.Windows.Forms.ProgressBar()
        Me.DUNG12_BT1 = New System.Windows.Forms.Button()
        Me.DUNG12_BT2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DUNG12_PB
        '
        Me.DUNG12_PB.Location = New System.Drawing.Point(26, 72)
        Me.DUNG12_PB.Name = "DUNG12_PB"
        Me.DUNG12_PB.Size = New System.Drawing.Size(529, 43)
        Me.DUNG12_PB.TabIndex = 0
        '
        'DUNG12_BT1
        '
        Me.DUNG12_BT1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DUNG12_BT1.Location = New System.Drawing.Point(66, 183)
        Me.DUNG12_BT1.Name = "DUNG12_BT1"
        Me.DUNG12_BT1.Size = New System.Drawing.Size(110, 33)
        Me.DUNG12_BT1.TabIndex = 2
        Me.DUNG12_BT1.Text = "Thực hiện"
        Me.DUNG12_BT1.UseVisualStyleBackColor = True
        '
        'DUNG12_BT2
        '
        Me.DUNG12_BT2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DUNG12_BT2.Location = New System.Drawing.Point(400, 183)
        Me.DUNG12_BT2.Name = "DUNG12_BT2"
        Me.DUNG12_BT2.Size = New System.Drawing.Size(110, 33)
        Me.DUNG12_BT2.TabIndex = 2
        Me.DUNG12_BT2.Text = "Thoát"
        Me.DUNG12_BT2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cập nhật hóa đơn"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Status"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 253)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DUNG12_BT2)
        Me.Controls.Add(Me.DUNG12_BT1)
        Me.Controls.Add(Me.DUNG12_PB)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DUNG12_PB As ProgressBar
    Friend WithEvents DUNG12_BT1 As Button
    Friend WithEvents DUNG12_BT2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
