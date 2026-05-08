<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TxtSerial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdGetSerial = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CmdCreateKey = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtLicense = New System.Windows.Forms.TextBox()
        Me.CmdCLose = New System.Windows.Forms.Button()
        Me.CmdCopy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtSerial
        '
        Me.TxtSerial.Location = New System.Drawing.Point(141, 20)
        Me.TxtSerial.Name = "TxtSerial"
        Me.TxtSerial.Size = New System.Drawing.Size(249, 26)
        Me.TxtSerial.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input Local Serial:"
        '
        'CmdGetSerial
        '
        Me.CmdGetSerial.Location = New System.Drawing.Point(396, 17)
        Me.CmdGetSerial.Name = "CmdGetSerial"
        Me.CmdGetSerial.Size = New System.Drawing.Size(118, 32)
        Me.CmdGetSerial.TabIndex = 2
        Me.CmdGetSerial.Text = "Get this PC"
        Me.CmdGetSerial.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "User Name:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(141, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(249, 26)
        Me.TextBox2.TabIndex = 3
        '
        'CmdCreateKey
        '
        Me.CmdCreateKey.Location = New System.Drawing.Point(207, 94)
        Me.CmdCreateKey.Name = "CmdCreateKey"
        Me.CmdCreateKey.Size = New System.Drawing.Size(118, 32)
        Me.CmdCreateKey.TabIndex = 5
        Me.CmdCreateKey.Text = "Create Key"
        Me.CmdCreateKey.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "License key:"
        '
        'TxtLicense
        '
        Me.TxtLicense.Location = New System.Drawing.Point(141, 141)
        Me.TxtLicense.Multiline = True
        Me.TxtLicense.Name = "TxtLicense"
        Me.TxtLicense.Size = New System.Drawing.Size(249, 70)
        Me.TxtLicense.TabIndex = 6
        '
        'CmdCLose
        '
        Me.CmdCLose.Location = New System.Drawing.Point(395, 179)
        Me.CmdCLose.Name = "CmdCLose"
        Me.CmdCLose.Size = New System.Drawing.Size(118, 32)
        Me.CmdCLose.TabIndex = 8
        Me.CmdCLose.Text = "Close"
        Me.CmdCLose.UseVisualStyleBackColor = True
        '
        'CmdCopy
        '
        Me.CmdCopy.Location = New System.Drawing.Point(396, 141)
        Me.CmdCopy.Name = "CmdCopy"
        Me.CmdCopy.Size = New System.Drawing.Size(118, 32)
        Me.CmdCopy.TabIndex = 9
        Me.CmdCopy.Text = "Copy"
        Me.CmdCopy.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 226)
        Me.Controls.Add(Me.CmdCopy)
        Me.Controls.Add(Me.CmdCLose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtLicense)
        Me.Controls.Add(Me.CmdCreateKey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CmdGetSerial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSerial)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "M3M License generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSerial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmdGetSerial As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CmdCreateKey As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtLicense As TextBox
    Friend WithEvents CmdCLose As Button
    Friend WithEvents CmdCopy As Button
End Class
