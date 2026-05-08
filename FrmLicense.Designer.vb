<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLicense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLicense))
        Me.CmdCLose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxAppID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxLicense = New System.Windows.Forms.TextBox()
        Me.CmdLicense = New System.Windows.Forms.Button()
        Me.LbLicensing = New System.Windows.Forms.Label()
        Me.LbLicensed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmdCLose
        '
        Me.CmdCLose.Location = New System.Drawing.Point(259, 238)
        Me.CmdCLose.Name = "CmdCLose"
        Me.CmdCLose.Size = New System.Drawing.Size(118, 32)
        Me.CmdCLose.TabIndex = 14
        Me.CmdCLose.Text = "Đóng"
        Me.CmdCLose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Người dùng:"
        '
        'TxUser
        '
        Me.TxUser.Location = New System.Drawing.Point(128, 49)
        Me.TxUser.Name = "TxUser"
        Me.TxUser.Size = New System.Drawing.Size(249, 25)
        Me.TxUser.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mã ứng dụng:"
        '
        'TxAppID
        '
        Me.TxAppID.Location = New System.Drawing.Point(128, 18)
        Me.TxAppID.Name = "TxAppID"
        Me.TxAppID.ReadOnly = True
        Me.TxAppID.Size = New System.Drawing.Size(249, 25)
        Me.TxAppID.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Key kích hoạt:"
        '
        'TxLicense
        '
        Me.TxLicense.Location = New System.Drawing.Point(128, 98)
        Me.TxLicense.Multiline = True
        Me.TxLicense.Name = "TxLicense"
        Me.TxLicense.Size = New System.Drawing.Size(249, 56)
        Me.TxLicense.TabIndex = 15
        '
        'CmdLicense
        '
        Me.CmdLicense.Location = New System.Drawing.Point(135, 238)
        Me.CmdLicense.Name = "CmdLicense"
        Me.CmdLicense.Size = New System.Drawing.Size(118, 32)
        Me.CmdLicense.TabIndex = 17
        Me.CmdLicense.Text = "Đăng ký"
        Me.CmdLicense.UseVisualStyleBackColor = True
        '
        'LbLicensing
        '
        Me.LbLicensing.AutoSize = True
        Me.LbLicensing.Location = New System.Drawing.Point(12, 157)
        Me.LbLicensing.Name = "LbLicensing"
        Me.LbLicensing.Size = New System.Drawing.Size(313, 68)
        Me.LbLicensing.TabIndex = 18
        Me.LbLicensing.Text = "Bạn cần kích hoạt để tiếp tục sử dụng chương trình !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Đơn vị quản lý ứng dụng: Ba" &
    "n Bản đồ Quân khu 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Số điện thoại: 0905178114 - 0977172601" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "email: thinhqk5@gma" &
    "il.com"
        '
        'LbLicensed
        '
        Me.LbLicensed.AutoSize = True
        Me.LbLicensed.Location = New System.Drawing.Point(12, 157)
        Me.LbLicensed.Name = "LbLicensed"
        Me.LbLicensed.Size = New System.Drawing.Size(313, 68)
        Me.LbLicensed.TabIndex = 19
        Me.LbLicensed.Text = "Xin cảm ơn! Bạn đã đăng ký bản quyền thành công !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Đơn vị quản lý bản quyền: Ban " &
    "Bản đồ Quân khu 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Số điện thoại: 0905178114 - 0977172601" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "email: thinhqk5@gmail" &
    ".com"
        '
        'FrmLicense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 282)
        Me.Controls.Add(Me.LbLicensing)
        Me.Controls.Add(Me.CmdLicense)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxLicense)
        Me.Controls.Add(Me.CmdCLose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxAppID)
        Me.Controls.Add(Me.LbLicensed)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLicense"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng ký sử dụng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdCLose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxAppID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxLicense As TextBox
    Friend WithEvents CmdLicense As Button
    Friend WithEvents LbLicensing As Label
    Friend WithEvents LbLicensed As Label
End Class
