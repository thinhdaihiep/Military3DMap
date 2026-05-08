<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbout))
        Me.LbVersion = New System.Windows.Forms.Label()
        Me.LbCopyright = New System.Windows.Forms.Label()
        Me.LbLicense = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LbVersion
        '
        Me.LbVersion.AutoSize = True
        Me.LbVersion.BackColor = System.Drawing.Color.Transparent
        Me.LbVersion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVersion.ForeColor = System.Drawing.Color.DarkCyan
        Me.LbVersion.Location = New System.Drawing.Point(31, 129)
        Me.LbVersion.Name = "LbVersion"
        Me.LbVersion.Size = New System.Drawing.Size(85, 21)
        Me.LbVersion.TabIndex = 2
        Me.LbVersion.Text = "Phiên bản:"
        '
        'LbCopyright
        '
        Me.LbCopyright.AutoSize = True
        Me.LbCopyright.BackColor = System.Drawing.Color.Transparent
        Me.LbCopyright.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCopyright.ForeColor = System.Drawing.Color.DarkCyan
        Me.LbCopyright.Location = New System.Drawing.Point(31, 150)
        Me.LbCopyright.Name = "LbCopyright"
        Me.LbCopyright.Size = New System.Drawing.Size(87, 21)
        Me.LbCopyright.TabIndex = 3
        Me.LbCopyright.Text = "Copyright:"
        '
        'LbLicense
        '
        Me.LbLicense.AutoSize = True
        Me.LbLicense.BackColor = System.Drawing.Color.Transparent
        Me.LbLicense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LbLicense.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLicense.ForeColor = System.Drawing.Color.Brown
        Me.LbLicense.Location = New System.Drawing.Point(31, 206)
        Me.LbLicense.Name = "LbLicense"
        Me.LbLicense.Size = New System.Drawing.Size(228, 21)
        Me.LbLicense.TabIndex = 4
        Me.LbLicense.Text = "Phần mềm chưa được đăng ký"
        Me.LbLicense.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(31, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Email: thinhqk5@gmail.com"
        '
        'FrmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbLicense)
        Me.Controls.Add(Me.LbCopyright)
        Me.Controls.Add(Me.LbVersion)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAbout"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Military 3D Map"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbVersion As Label
    Friend WithEvents LbCopyright As Label
    Friend WithEvents LbLicense As Label
    Friend WithEvents Label1 As Label
End Class
