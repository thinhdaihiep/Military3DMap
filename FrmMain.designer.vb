<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.SttBar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GrpLayer = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtLine = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEvent = New System.Windows.Forms.TextBox()
        Me.MapView = New AxTerraExplorerX.AxTE3DWindowEx()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LbMeasure = New System.Windows.Forms.Label()
        Me.MapToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BtnPan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSelect = New System.Windows.Forms.ToolStripButton()
        Me.BtnCopy = New System.Windows.Forms.ToolStripButton()
        Me.BtnCut = New System.Windows.Forms.ToolStripButton()
        Me.BtnPaste = New System.Windows.Forms.ToolStripButton()
        Me.BtnDel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDistance = New System.Windows.Forms.ToolStripButton()
        Me.BtnHeight = New System.Windows.Forms.ToolStripButton()
        Me.BtnArea = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmdCapture = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNavigate = New System.Windows.Forms.ToolStripButton()
        Me.BtnOcean = New System.Windows.Forms.ToolStripButton()
        Me.BtnSetting = New System.Windows.Forms.ToolStripButton()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BtnOpen = New System.Windows.Forms.ToolStripSplitButton()
        Me.MnRecent1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnRecent2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnRecent3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnRecent4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnRecent5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUndo = New System.Windows.Forms.ToolStripButton()
        Me.BtnRedo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnShow = New System.Windows.Forms.ToolStripButton()
        Me.BtnHide = New System.Windows.Forms.ToolStripButton()
        Me.BtnFollow = New System.Windows.Forms.ToolStripButton()
        Me.BtnPlay = New System.Windows.Forms.ToolStripButton()
        Me.BtnPause = New System.Windows.Forms.ToolStripButton()
        Me.BtnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnHelp = New System.Windows.Forms.ToolStripButton()
        Me.BtnAbout = New System.Windows.Forms.ToolStripButton()
        Me.DlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.GrpTree = New System.Windows.Forms.GroupBox()
        Me.TreeView = New AxTerraExplorerX.AxTEInformationWindowEx()
        Me.TreeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BtnAddGroup = New System.Windows.Forms.ToolStripButton()
        Me.BtnAddLocation = New System.Windows.Forms.ToolStripButton()
        Me.BtnAddLabel = New System.Windows.Forms.ToolStripButton()
        Me.BtnAddImage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnLocateGroup = New System.Windows.Forms.ToolStripButton()
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.DlgColor = New System.Windows.Forms.ColorDialog()
        Me.StatusStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpLayer.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MapView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MapToolStrip.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        Me.GrpTree.SuspendLayout()
        CType(Me.TreeView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TreeToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SttBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 747)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1127, 25)
        Me.StatusStrip.TabIndex = 1
        '
        'SttBar
        '
        Me.SttBar.Image = CType(resources.GetObject("SttBar.Image"), System.Drawing.Image)
        Me.SttBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SttBar.Name = "SttBar"
        Me.SttBar.Size = New System.Drawing.Size(182, 20)
        Me.SttBar.Text = "Mở tập tin TerraExplorer(*.fly)"
        '
        'DlgOpen
        '
        Me.DlgOpen.DefaultExt = "*.fly"
        Me.DlgOpen.Filter = "TerraExplorer Files|*.fly"
        Me.DlgOpen.RestoreDirectory = True
        Me.DlgOpen.Title = "Open file..."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GrpLayer)
        Me.Panel1.Controls.Add(Me.TxtEvent)
        Me.Panel1.Controls.Add(Me.MapView)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.MapToolStrip)
        Me.Panel1.Location = New System.Drawing.Point(374, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(753, 716)
        Me.Panel1.TabIndex = 6
        '
        'GrpLayer
        '
        Me.GrpLayer.Controls.Add(Me.GroupBox3)
        Me.GrpLayer.Controls.Add(Me.GroupBox2)
        Me.GrpLayer.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLayer.Location = New System.Drawing.Point(100, 403)
        Me.GrpLayer.Name = "GrpLayer"
        Me.GrpLayer.Size = New System.Drawing.Size(357, 285)
        Me.GrpLayer.TabIndex = 15
        Me.GrpLayer.TabStop = False
        Me.GrpLayer.Text = "Chỉnh sửa"
        Me.GrpLayer.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 162)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 108)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nền"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(176, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "%"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(176, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 27)
        Me.Label7.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(99, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(71, 25)
        Me.TextBox3.TabIndex = 15
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Trong suốt:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(99, 27)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(71, 25)
        Me.TextBox4.TabIndex = 13
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Màu nền:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtLine)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 130)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Đường viền"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(178, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "%"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(178, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 27)
        Me.Label4.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(71, 25)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Trong suốt:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(71, 25)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Màu viền:"
        '
        'TxtLine
        '
        Me.TxtLine.Location = New System.Drawing.Point(101, 24)
        Me.TxtLine.Name = "TxtLine"
        Me.TxtLine.Size = New System.Drawing.Size(71, 25)
        Me.TxtLine.TabIndex = 11
        Me.TxtLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Độ nét:"
        '
        'TxtEvent
        '
        Me.TxtEvent.Location = New System.Drawing.Point(506, 3)
        Me.TxtEvent.Name = "TxtEvent"
        Me.TxtEvent.Size = New System.Drawing.Size(178, 25)
        Me.TxtEvent.TabIndex = 11
        Me.TxtEvent.Visible = False
        '
        'MapView
        '
        Me.MapView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MapView.Enabled = True
        Me.MapView.Location = New System.Drawing.Point(0, 31)
        Me.MapView.Name = "MapView"
        Me.MapView.Size = New System.Drawing.Size(753, 685)
        Me.MapView.TabIndex = 4
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.LbMeasure)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(320, 128)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(96, 86)
        Me.FlowLayoutPanel1.TabIndex = 3
        Me.FlowLayoutPanel1.Visible = False
        '
        'LbMeasure
        '
        Me.LbMeasure.AutoSize = True
        Me.LbMeasure.Location = New System.Drawing.Point(3, 0)
        Me.LbMeasure.Name = "LbMeasure"
        Me.LbMeasure.Size = New System.Drawing.Size(86, 17)
        Me.LbMeasure.TabIndex = 0
        Me.LbMeasure.Text = "Khoảng cách:"
        '
        'MapToolStrip
        '
        Me.MapToolStrip.Enabled = False
        Me.MapToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MapToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPan, Me.ToolStripSeparator8, Me.BtnSelect, Me.BtnCopy, Me.BtnCut, Me.BtnPaste, Me.BtnDel, Me.ToolStripSeparator2, Me.BtnDistance, Me.BtnHeight, Me.BtnArea, Me.ToolStripSeparator5, Me.CmdCapture, Me.ToolStripSeparator7, Me.BtnNavigate, Me.BtnOcean, Me.BtnSetting})
        Me.MapToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MapToolStrip.Name = "MapToolStrip"
        Me.MapToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MapToolStrip.Size = New System.Drawing.Size(753, 31)
        Me.MapToolStrip.TabIndex = 0
        Me.MapToolStrip.Text = "MapToolStrip"
        '
        'BtnPan
        '
        Me.BtnPan.Checked = True
        Me.BtnPan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BtnPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPan.Image = CType(resources.GetObject("BtnPan.Image"), System.Drawing.Image)
        Me.BtnPan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPan.Name = "BtnPan"
        Me.BtnPan.Size = New System.Drawing.Size(28, 28)
        Me.BtnPan.Text = "Pan"
        Me.BtnPan.ToolTipText = "Pan"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
        '
        'BtnSelect
        '
        Me.BtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(28, 28)
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.ToolTipText = "Select"
        '
        'BtnCopy
        '
        Me.BtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCopy.Enabled = False
        Me.BtnCopy.Image = CType(resources.GetObject("BtnCopy.Image"), System.Drawing.Image)
        Me.BtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(28, 28)
        Me.BtnCopy.Text = "Copy"
        Me.BtnCopy.ToolTipText = "Sao chép"
        '
        'BtnCut
        '
        Me.BtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCut.Enabled = False
        Me.BtnCut.Image = CType(resources.GetObject("BtnCut.Image"), System.Drawing.Image)
        Me.BtnCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCut.Name = "BtnCut"
        Me.BtnCut.Size = New System.Drawing.Size(28, 28)
        Me.BtnCut.Text = "Cut"
        Me.BtnCut.ToolTipText = "Cắt"
        '
        'BtnPaste
        '
        Me.BtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPaste.Enabled = False
        Me.BtnPaste.Image = CType(resources.GetObject("BtnPaste.Image"), System.Drawing.Image)
        Me.BtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPaste.Name = "BtnPaste"
        Me.BtnPaste.Size = New System.Drawing.Size(28, 28)
        Me.BtnPaste.Text = "Paste"
        Me.BtnPaste.ToolTipText = "Dán"
        '
        'BtnDel
        '
        Me.BtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDel.Enabled = False
        Me.BtnDel.Image = CType(resources.GetObject("BtnDel.Image"), System.Drawing.Image)
        Me.BtnDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(28, 28)
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.ToolTipText = "Xóa"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BtnDistance
        '
        Me.BtnDistance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDistance.Image = CType(resources.GetObject("BtnDistance.Image"), System.Drawing.Image)
        Me.BtnDistance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDistance.Name = "BtnDistance"
        Me.BtnDistance.Size = New System.Drawing.Size(28, 28)
        Me.BtnDistance.Text = "Measure Distance"
        Me.BtnDistance.ToolTipText = "Select"
        '
        'BtnHeight
        '
        Me.BtnHeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnHeight.Image = CType(resources.GetObject("BtnHeight.Image"), System.Drawing.Image)
        Me.BtnHeight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHeight.Name = "BtnHeight"
        Me.BtnHeight.Size = New System.Drawing.Size(28, 28)
        Me.BtnHeight.Text = "Measure Height"
        Me.BtnHeight.ToolTipText = "Select"
        '
        'BtnArea
        '
        Me.BtnArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnArea.Image = CType(resources.GetObject("BtnArea.Image"), System.Drawing.Image)
        Me.BtnArea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnArea.Name = "BtnArea"
        Me.BtnArea.Size = New System.Drawing.Size(28, 28)
        Me.BtnArea.Text = "Measure Area"
        Me.BtnArea.ToolTipText = "Select"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'CmdCapture
        '
        Me.CmdCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdCapture.Image = CType(resources.GetObject("CmdCapture.Image"), System.Drawing.Image)
        Me.CmdCapture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdCapture.Name = "CmdCapture"
        Me.CmdCapture.Size = New System.Drawing.Size(28, 28)
        Me.CmdCapture.Text = "Save image..."
        Me.CmdCapture.ToolTipText = "Lưu ảnh..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 31)
        '
        'BtnNavigate
        '
        Me.BtnNavigate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNavigate.Image = CType(resources.GetObject("BtnNavigate.Image"), System.Drawing.Image)
        Me.BtnNavigate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNavigate.Name = "BtnNavigate"
        Me.BtnNavigate.Size = New System.Drawing.Size(28, 28)
        Me.BtnNavigate.Text = "Navigator"
        '
        'BtnOcean
        '
        Me.BtnOcean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnOcean.Image = CType(resources.GetObject("BtnOcean.Image"), System.Drawing.Image)
        Me.BtnOcean.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOcean.Name = "BtnOcean"
        Me.BtnOcean.Size = New System.Drawing.Size(28, 28)
        Me.BtnOcean.Text = "Oceans toggle"
        Me.BtnOcean.ToolTipText = "Oceans toggle"
        '
        'BtnSetting
        '
        Me.BtnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSetting.Image = CType(resources.GetObject("BtnSetting.Image"), System.Drawing.Image)
        Me.BtnSetting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSetting.Name = "BtnSetting"
        Me.BtnSetting.Size = New System.Drawing.Size(28, 28)
        Me.BtnSetting.Text = "Project setting"
        Me.BtnSetting.ToolTipText = "Thiết đặt bản đồ"
        '
        'MainToolStrip
        '
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnOpen, Me.BtnSave, Me.ToolStripSeparator1, Me.BtnUndo, Me.BtnRedo, Me.ToolStripSeparator4, Me.ToolStripSeparator3, Me.BtnShow, Me.BtnHide, Me.BtnFollow, Me.BtnPlay, Me.BtnPause, Me.BtnUpdate, Me.ToolStripSeparator6, Me.BtnHelp, Me.BtnAbout})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainToolStrip.Size = New System.Drawing.Size(1127, 31)
        Me.MainToolStrip.TabIndex = 8
        Me.MainToolStrip.Text = "MainToolStrip"
        '
        'BtnOpen
        '
        Me.BtnOpen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnRecent1, Me.MnRecent2, Me.MnRecent3, Me.MnRecent4, Me.MnRecent5})
        Me.BtnOpen.Image = CType(resources.GetObject("BtnOpen.Image"), System.Drawing.Image)
        Me.BtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(74, 28)
        Me.BtnOpen.Text = "Mở..."
        Me.BtnOpen.ToolTipText = "Mở file..."
        '
        'MnRecent1
        '
        Me.MnRecent1.Name = "MnRecent1"
        Me.MnRecent1.Size = New System.Drawing.Size(67, 22)
        Me.MnRecent1.Tag = "1"
        Me.MnRecent1.Visible = False
        '
        'MnRecent2
        '
        Me.MnRecent2.Name = "MnRecent2"
        Me.MnRecent2.Size = New System.Drawing.Size(67, 22)
        Me.MnRecent2.Tag = "2"
        Me.MnRecent2.Visible = False
        '
        'MnRecent3
        '
        Me.MnRecent3.Name = "MnRecent3"
        Me.MnRecent3.Size = New System.Drawing.Size(67, 22)
        Me.MnRecent3.Tag = "3"
        Me.MnRecent3.Visible = False
        '
        'MnRecent4
        '
        Me.MnRecent4.Name = "MnRecent4"
        Me.MnRecent4.Size = New System.Drawing.Size(67, 22)
        Me.MnRecent4.Tag = "4"
        Me.MnRecent4.Visible = False
        '
        'MnRecent5
        '
        Me.MnRecent5.Name = "MnRecent5"
        Me.MnRecent5.Size = New System.Drawing.Size(67, 22)
        Me.MnRecent5.Tag = "5"
        Me.MnRecent5.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSave.Enabled = False
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(28, 28)
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.ToolTipText = "Lưu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BtnUndo
        '
        Me.BtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnUndo.Image = CType(resources.GetObject("BtnUndo.Image"), System.Drawing.Image)
        Me.BtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(28, 28)
        Me.BtnUndo.Text = "&Undo"
        Me.BtnUndo.ToolTipText = "Undo"
        '
        'BtnRedo
        '
        Me.BtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnRedo.Image = CType(resources.GetObject("BtnRedo.Image"), System.Drawing.Image)
        Me.BtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRedo.Name = "BtnRedo"
        Me.BtnRedo.Size = New System.Drawing.Size(28, 28)
        Me.BtnRedo.Text = "&Redo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'BtnShow
        '
        Me.BtnShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnShow.Image = CType(resources.GetObject("BtnShow.Image"), System.Drawing.Image)
        Me.BtnShow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(28, 28)
        Me.BtnShow.Text = "Show Screen"
        Me.BtnShow.ToolTipText = "Hiện màn hình trình chiếu"
        '
        'BtnHide
        '
        Me.BtnHide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnHide.Image = CType(resources.GetObject("BtnHide.Image"), System.Drawing.Image)
        Me.BtnHide.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHide.Name = "BtnHide"
        Me.BtnHide.Size = New System.Drawing.Size(28, 28)
        Me.BtnHide.Text = "Hide Sceen"
        Me.BtnHide.ToolTipText = "Ẩn màn hình trình chiếu"
        Me.BtnHide.Visible = False
        '
        'BtnFollow
        '
        Me.BtnFollow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFollow.Enabled = False
        Me.BtnFollow.Image = CType(resources.GetObject("BtnFollow.Image"), System.Drawing.Image)
        Me.BtnFollow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFollow.Name = "BtnFollow"
        Me.BtnFollow.Size = New System.Drawing.Size(28, 28)
        Me.BtnFollow.Text = "Follow"
        Me.BtnFollow.ToolTipText = "Cập nhật vị trí trình chiếu"
        Me.BtnFollow.Visible = False
        '
        'BtnPlay
        '
        Me.BtnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPlay.Enabled = False
        Me.BtnPlay.Image = CType(resources.GetObject("BtnPlay.Image"), System.Drawing.Image)
        Me.BtnPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(28, 28)
        Me.BtnPlay.Text = "Play show"
        Me.BtnPlay.ToolTipText = "Bắt đầu trình chiếu"
        '
        'BtnPause
        '
        Me.BtnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPause.Image = CType(resources.GetObject("BtnPause.Image"), System.Drawing.Image)
        Me.BtnPause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(28, 28)
        Me.BtnPause.Text = "Pause Show"
        Me.BtnPause.ToolTipText = "Tạm dừng trình chiếu"
        Me.BtnPause.Visible = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnUpdate.Enabled = False
        Me.BtnUpdate.Image = CType(resources.GetObject("BtnUpdate.Image"), System.Drawing.Image)
        Me.BtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(28, 28)
        Me.BtnUpdate.Text = "Update file"
        Me.BtnUpdate.ToolTipText = "Tải lại file trình chiếu"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'BtnHelp
        '
        Me.BtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnHelp.Image = CType(resources.GetObject("BtnHelp.Image"), System.Drawing.Image)
        Me.BtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(28, 28)
        Me.BtnHelp.Text = "Help"
        Me.BtnHelp.ToolTipText = "Trợ giúp"
        '
        'BtnAbout
        '
        Me.BtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAbout.Image = CType(resources.GetObject("BtnAbout.Image"), System.Drawing.Image)
        Me.BtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(28, 28)
        Me.BtnAbout.Text = "About"
        Me.BtnAbout.ToolTipText = "Về Chương trình"
        '
        'DlgSave
        '
        Me.DlgSave.DefaultExt = "*.fly"
        Me.DlgSave.Filter = "TerraExplorer Files|*.fly"
        Me.DlgSave.Title = "Save as..."
        '
        'GrpTree
        '
        Me.GrpTree.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrpTree.Controls.Add(Me.TreeView)
        Me.GrpTree.Controls.Add(Me.TreeToolStrip)
        Me.GrpTree.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpTree.Location = New System.Drawing.Point(5, 35)
        Me.GrpTree.Name = "GrpTree"
        Me.GrpTree.Size = New System.Drawing.Size(363, 709)
        Me.GrpTree.TabIndex = 9
        Me.GrpTree.TabStop = False
        Me.GrpTree.Text = "Danh sách"
        '
        'TreeView
        '
        Me.TreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView.Enabled = True
        Me.TreeView.Location = New System.Drawing.Point(3, 54)
        Me.TreeView.Name = "TreeView"
        Me.TreeView.Size = New System.Drawing.Size(357, 652)
        Me.TreeView.TabIndex = 15
        '
        'TreeToolStrip
        '
        Me.TreeToolStrip.Enabled = False
        Me.TreeToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TreeToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TreeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddGroup, Me.BtnAddLocation, Me.BtnAddLabel, Me.BtnAddImage, Me.ToolStripButton1, Me.ToolStripSeparator9, Me.BtnLocateGroup, Me.BtnEdit})
        Me.TreeToolStrip.Location = New System.Drawing.Point(3, 23)
        Me.TreeToolStrip.Name = "TreeToolStrip"
        Me.TreeToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TreeToolStrip.Size = New System.Drawing.Size(357, 31)
        Me.TreeToolStrip.TabIndex = 12
        Me.TreeToolStrip.Text = "TreeToolStrip"
        '
        'BtnAddGroup
        '
        Me.BtnAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddGroup.Image = CType(resources.GetObject("BtnAddGroup.Image"), System.Drawing.Image)
        Me.BtnAddGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddGroup.Name = "BtnAddGroup"
        Me.BtnAddGroup.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddGroup.Text = "Add Group"
        Me.BtnAddGroup.ToolTipText = "Thêm nhóm"
        '
        'BtnAddLocation
        '
        Me.BtnAddLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddLocation.Image = CType(resources.GetObject("BtnAddLocation.Image"), System.Drawing.Image)
        Me.BtnAddLocation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddLocation.Name = "BtnAddLocation"
        Me.BtnAddLocation.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddLocation.Text = "Add Location"
        Me.BtnAddLocation.ToolTipText = "Thêm vị trí"
        '
        'BtnAddLabel
        '
        Me.BtnAddLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddLabel.Image = CType(resources.GetObject("BtnAddLabel.Image"), System.Drawing.Image)
        Me.BtnAddLabel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddLabel.Name = "BtnAddLabel"
        Me.BtnAddLabel.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddLabel.Text = "Add Label"
        Me.BtnAddLabel.ToolTipText = "Thêm nhãn..."
        '
        'BtnAddImage
        '
        Me.BtnAddImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddImage.Image = CType(resources.GetObject("BtnAddImage.Image"), System.Drawing.Image)
        Me.BtnAddImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddImage.Name = "BtnAddImage"
        Me.BtnAddImage.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddImage.Text = "Add Image"
        Me.BtnAddImage.ToolTipText = "Thêm ảnh..."
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "Add Image"
        Me.ToolStripButton1.ToolTipText = "Thêm ảnh..."
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 31)
        '
        'BtnLocateGroup
        '
        Me.BtnLocateGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnLocateGroup.Enabled = False
        Me.BtnLocateGroup.Image = CType(resources.GetObject("BtnLocateGroup.Image"), System.Drawing.Image)
        Me.BtnLocateGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLocateGroup.Name = "BtnLocateGroup"
        Me.BtnLocateGroup.Size = New System.Drawing.Size(28, 28)
        Me.BtnLocateGroup.Text = "Edit"
        Me.BtnLocateGroup.ToolTipText = "Chỉnh sửa đối tượng"
        '
        'BtnEdit
        '
        Me.BtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(28, 28)
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.ToolTipText = "Chỉnh sửa đối tượng"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 772)
        Me.Controls.Add(Me.GrpTree)
        Me.Controls.Add(Me.MainToolStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmMain"
        Me.Text = "Military 3D Map"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GrpLayer.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MapView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.MapToolStrip.ResumeLayout(False)
        Me.MapToolStrip.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.GrpTree.ResumeLayout(False)
        Me.GrpTree.PerformLayout()
        CType(Me.TreeView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TreeToolStrip.ResumeLayout(False)
        Me.TreeToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents DlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SttBar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MapToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPan As ToolStripButton
    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents BtnSave As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnHelp As ToolStripButton
    Friend WithEvents BtnAbout As ToolStripButton
    Friend WithEvents BtnUndo As ToolStripButton
    Friend WithEvents BtnRedo As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BtnShow As ToolStripButton
    Friend WithEvents BtnHide As ToolStripButton
    Friend WithEvents BtnPlay As ToolStripButton
    Friend WithEvents BtnPause As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents BtnFollow As ToolStripButton
    Friend WithEvents BtnDistance As ToolStripButton
    Friend WithEvents BtnHeight As ToolStripButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LbMeasure As Label
    Friend WithEvents MapView As AxTerraExplorerX.AxTE3DWindowEx
    Friend WithEvents BtnUpdate As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents BtnNavigate As ToolStripButton
    Friend WithEvents BtnOcean As ToolStripButton
    Friend WithEvents BtnOpen As ToolStripSplitButton
    Friend WithEvents MnRecent1 As ToolStripMenuItem
    Friend WithEvents MnRecent2 As ToolStripMenuItem
    Friend WithEvents MnRecent3 As ToolStripMenuItem
    Friend WithEvents MnRecent4 As ToolStripMenuItem
    Friend WithEvents MnRecent5 As ToolStripMenuItem
    Friend WithEvents BtnArea As ToolStripButton
    Friend WithEvents TxtEvent As TextBox
    Friend WithEvents DlgSave As SaveFileDialog
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CmdCapture As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents BtnCopy As ToolStripButton
    Friend WithEvents BtnCut As ToolStripButton
    Friend WithEvents BtnPaste As ToolStripButton
    Friend WithEvents BtnDel As ToolStripButton
    Friend WithEvents GrpTree As GroupBox
    Friend WithEvents TreeToolStrip As ToolStrip
    Friend WithEvents BtnAddGroup As ToolStripButton
    Friend WithEvents BtnAddLocation As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents BtnEdit As ToolStripButton
    Friend WithEvents BtnAddLabel As ToolStripButton
    Friend WithEvents DlgColor As ColorDialog
    Friend WithEvents GrpLayer As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtLine As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAddImage As ToolStripButton
    Friend WithEvents BtnSetting As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TreeView As AxTerraExplorerX.AxTEInformationWindowEx
    Friend WithEvents BtnLocateGroup As ToolStripButton
End Class
