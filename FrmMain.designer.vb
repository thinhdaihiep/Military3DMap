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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Khởi động Military 3D Map..."}, 0)
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Sở chỉ huy", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Hành động tác chiến", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Công binh", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Đặc công", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Hậu cần - Kỹ thuật", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Hải quân", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup7 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Địa phương", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup8 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Pháo binh", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup9 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Phòng không - không quân", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup10 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Quân báo - trinh sát", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup11 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Tác chiến điện tử", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup12 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Thông tin", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup13 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Tăng thiết giáp", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup14 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Ký hiệu khác", System.Windows.Forms.HorizontalAlignment.Left)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.SttBar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PrgBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.LicenseBar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BtnOpen = New System.Windows.Forms.ToolStripSplitButton()
        Me.MnRecent = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.BtnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUndo = New System.Windows.Forms.ToolStripButton()
        Me.BtnRedo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnShow = New System.Windows.Forms.ToolStripButton()
        Me.BtnHide = New System.Windows.Forms.ToolStripButton()
        Me.BtnReload = New System.Windows.Forms.ToolStripButton()
        Me.BtnLink = New System.Windows.Forms.ToolStripButton()
        Me.BtnUnlink = New System.Windows.Forms.ToolStripButton()
        Me.BtnFollow = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSetting = New System.Windows.Forms.ToolStripButton()
        Me.BtnHelp = New System.Windows.Forms.ToolStripButton()
        Me.BtnAbout = New System.Windows.Forms.ToolStripButton()
        Me.DlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.DlgColor = New System.Windows.Forms.ColorDialog()
        Me.TxtEvent = New System.Windows.Forms.TextBox()
        Me.TmrFocus = New System.Windows.Forms.Timer(Me.components)
        Me.MainSpliter = New System.Windows.Forms.SplitContainer()
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.PageTree = New System.Windows.Forms.TabPage()
        Me.MapTree = New AxTerraExplorerX.AxTEInformationWindowEx()
        Me.TreeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BtnAddGroup = New System.Windows.Forms.ToolStripSplitButton()
        Me.MnAddLocation = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExpandGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUpdateGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCleanGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnRemoveNote = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAddLabel = New System.Windows.Forms.ToolStripSplitButton()
        Me.BtnAddImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAddLayer = New System.Windows.Forms.ToolStripSplitButton()
        Me.AddRaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddGroundObject = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFlyObject = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStandObject = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnAddFire = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnFire1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnFire2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnFire3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnFire4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnFire5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnFire6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnFire7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnFire8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnAddSmoke = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnSmoke1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnSmoke2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnSmoke3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnSmoke4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnSmoke5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnSmoke6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnSmoke7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnAddExp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnExp1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnExp2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnExp3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAddPoly = New System.Windows.Forms.ToolStripSplitButton()
        Me.BtnAddLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAddRec = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAddCircle = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAddArrow = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAddPres = New System.Windows.Forms.ToolStripButton()
        Me.BtnAddDmav = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnAddPresHL = New System.Windows.Forms.ToolStripButton()
        Me.BtnStartHL = New System.Windows.Forms.ToolStripButton()
        Me.btnStopHL = New System.Windows.Forms.ToolStripButton()
        Me.MapSplitter = New System.Windows.Forms.SplitContainer()
        Me.SplSubMap = New System.Windows.Forms.SplitContainer()
        Me.LbPresState = New System.Windows.Forms.Label()
        Me.MapView = New AxTerraExplorerX.AxTE3DWindowEx()
        Me.TabControls = New System.Windows.Forms.TabControl()
        Me.TabControl = New System.Windows.Forms.TabPage()
        Me.GrObject = New System.Windows.Forms.GroupBox()
        Me.CmdHideNote2 = New System.Windows.Forms.Button()
        Me.CmdShowNote2 = New System.Windows.Forms.Button()
        Me.CmdStartHL = New System.Windows.Forms.Button()
        Me.CmdStopHL = New System.Windows.Forms.Button()
        Me.GrControl = New System.Windows.Forms.GroupBox()
        Me.cmdStep = New System.Windows.Forms.Button()
        Me.tbrRate = New System.Windows.Forms.TrackBar()
        Me.CmdZoomIn = New System.Windows.Forms.Button()
        Me.CmdZoomOut = New System.Windows.Forms.Button()
        Me.CmdRotateLeft = New System.Windows.Forms.Button()
        Me.CmdGo = New System.Windows.Forms.Button()
        Me.CmdRotateRight = New System.Windows.Forms.Button()
        Me.CmdDown = New System.Windows.Forms.Button()
        Me.PicControl = New System.Windows.Forms.PictureBox()
        Me.CmdUp = New System.Windows.Forms.Button()
        Me.CmdStop = New System.Windows.Forms.Button()
        Me.GrCoor = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxY = New System.Windows.Forms.TextBox()
        Me.TxX = New System.Windows.Forms.TextBox()
        Me.CbCoor = New System.Windows.Forms.ComboBox()
        Me.TabInfo = New System.Windows.Forms.TabPage()
        Me.LvInfo = New System.Windows.Forms.ListView()
        Me.cIcon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cInfo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImgSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.TabTool = New System.Windows.Forms.TabControl()
        Me.PagePres = New System.Windows.Forms.TabPage()
        Me.GrEffect = New System.Windows.Forms.GroupBox()
        Me.cmbEffect = New System.Windows.Forms.ComboBox()
        Me.LvHighlight = New System.Windows.Forms.ListView()
        Me.cleName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cleType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HLTool = New System.Windows.Forms.ToolStrip()
        Me.BtnAddPresHL2 = New System.Windows.Forms.ToolStripButton()
        Me.BtnStartPresHL = New System.Windows.Forms.ToolStripButton()
        Me.BtnStopPresHL = New System.Windows.Forms.ToolStripButton()
        Me.btnReLoadEffect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDelPresHL = New System.Windows.Forms.ToolStripButton()
        Me.LbPres = New System.Windows.Forms.Label()
        Me.PresTool = New System.Windows.Forms.ToolStrip()
        Me.BtnPrivous = New System.Windows.Forms.ToolStripButton()
        Me.BtnPlay = New System.Windows.Forms.ToolStripButton()
        Me.BtnStep = New System.Windows.Forms.ToolStripButton()
        Me.BtnPause = New System.Windows.Forms.ToolStripButton()
        Me.BtnNext = New System.Windows.Forms.ToolStripButton()
        Me.BtnStop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnAddPresLocation = New System.Windows.Forms.ToolStripButton()
        Me.BtnDelPres = New System.Windows.Forms.ToolStripButton()
        Me.BtnUpdatePreslocation = New System.Windows.Forms.ToolStripButton()
        Me.BtnKeystep = New System.Windows.Forms.ToolStripButton()
        Me.BtnRepres = New System.Windows.Forms.ToolStripButton()
        Me.CmbEdit = New System.Windows.Forms.ComboBox()
        Me.LvSteps = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PageEdit = New System.Windows.Forms.TabPage()
        Me.TxName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GrNote = New System.Windows.Forms.GroupBox()
        Me.CmdDelNote = New System.Windows.Forms.Button()
        Me.CmdHideNote = New System.Windows.Forms.Button()
        Me.CmdSaveNote = New System.Windows.Forms.Button()
        Me.cmdShowNote = New System.Windows.Forms.Button()
        Me.TxNote = New System.Windows.Forms.TextBox()
        Me.GrEdit = New System.Windows.Forms.GroupBox()
        Me.CbAltmed = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.NrMaxView = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.NrMinView = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxLabel = New System.Windows.Forms.TextBox()
        Me.CmdApply = New System.Windows.Forms.Button()
        Me.lbLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFilename = New System.Windows.Forms.TextBox()
        Me.CmdOpen = New System.Windows.Forms.Button()
        Me.NrLinewid = New System.Windows.Forms.NumericUpDown()
        Me.NrFillOpa = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NrLineOpa = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NrDis = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NrScale = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFillColor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtLineColor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PageSign = New System.Windows.Forms.TabPage()
        Me.GrSignlist = New System.Windows.Forms.GroupBox()
        Me.LvSign = New System.Windows.Forms.ListView()
        Me.ImgLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.cbSignGroup = New System.Windows.Forms.ComboBox()
        Me.TxtFind = New System.Windows.Forms.TextBox()
        Me.GrSign = New System.Windows.Forms.GroupBox()
        Me.TxtColor6 = New System.Windows.Forms.TextBox()
        Me.RdKhac = New System.Windows.Forms.RadioButton()
        Me.CkCap = New System.Windows.Forms.CheckBox()
        Me.CmdAddSign = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxSignName = New System.Windows.Forms.TextBox()
        Me.TxMainColor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CmdSaveSign = New System.Windows.Forms.Button()
        Me.NrFont = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LbSignCap = New System.Windows.Forms.Label()
        Me.PicPivot = New System.Windows.Forms.PictureBox()
        Me.TxtColor4 = New System.Windows.Forms.TextBox()
        Me.TxtColor3 = New System.Windows.Forms.TextBox()
        Me.TxtColor2 = New System.Windows.Forms.TextBox()
        Me.TxtColor1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Ck2D = New System.Windows.Forms.CheckBox()
        Me.RdDich = New System.Windows.Forms.RadioButton()
        Me.RdTa = New System.Windows.Forms.RadioButton()
        Me.CkFlip = New System.Windows.Forms.CheckBox()
        Me.CbSignScale = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtColor5 = New System.Windows.Forms.TextBox()
        Me.PicSign = New System.Windows.Forms.PictureBox()
        Me.TxSignCap = New System.Windows.Forms.TextBox()
        Me.PageData = New System.Windows.Forms.TabPage()
        Me.SourceToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BtnFileCheck = New System.Windows.Forms.ToolStripButton()
        Me.BtnFileFix = New System.Windows.Forms.ToolStripButton()
        Me.LvFile = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LstSource = New System.Windows.Forms.ListBox()
        Me.CmdAddSource = New System.Windows.Forms.Button()
        Me.CmdDelSource = New System.Windows.Forms.Button()
        Me.MapToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BtnPan = New System.Windows.Forms.ToolStripButton()
        Me.BtnSelect = New System.Windows.Forms.ToolStripButton()
        Me.BtnSelectArea = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCopy = New System.Windows.Forms.ToolStripButton()
        Me.BtnCut = New System.Windows.Forms.ToolStripButton()
        Me.BtnPaste = New System.Windows.Forms.ToolStripButton()
        Me.BtnDel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDistance = New System.Windows.Forms.ToolStripButton()
        Me.BtnArea = New System.Windows.Forms.ToolStripButton()
        Me.BtnHeight = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNavigate = New System.Windows.Forms.ToolStripSplitButton()
        Me.MnNavigate = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnShadow = New System.Windows.Forms.ToolStripButton()
        Me.BtnTimeSlider = New System.Windows.Forms.ToolStripButton()
        Me.BtnOcean = New System.Windows.Forms.ToolStripButton()
        Me.BtnCapture = New System.Windows.Forms.ToolStripButton()
        Me.BtnOption = New System.Windows.Forms.ToolStripButton()
        Me.TmrPresWait = New System.Windows.Forms.Timer(Me.components)
        Me.DlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.BwCheckfile = New System.ComponentModel.BackgroundWorker()
        Me.BwFixFile = New System.ComponentModel.BackgroundWorker()
        Me.BwHighlight = New System.ComponentModel.BackgroundWorker()
        Me.BwLoadSign = New System.ComponentModel.BackgroundWorker()
        Me.BwEdit = New System.ComponentModel.BackgroundWorker()
        Me.ImgPivot = New System.Windows.Forms.ImageList(Me.components)
        Me.TmrLicense = New System.Windows.Forms.Timer(Me.components)
        Me.TmrHighlight = New System.Windows.Forms.Timer(Me.components)
        Me.ImgStep = New System.Windows.Forms.ImageList(Me.components)
        Me.TmrFollow = New System.Windows.Forms.Timer(Me.components)
        Me.TmrControl = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        CType(Me.MainSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSpliter.Panel1.SuspendLayout()
        Me.MainSpliter.Panel2.SuspendLayout()
        Me.MainSpliter.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.PageTree.SuspendLayout()
        CType(Me.MapTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TreeToolStrip.SuspendLayout()
        CType(Me.MapSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MapSplitter.Panel1.SuspendLayout()
        Me.MapSplitter.Panel2.SuspendLayout()
        Me.MapSplitter.SuspendLayout()
        CType(Me.SplSubMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplSubMap.Panel1.SuspendLayout()
        Me.SplSubMap.Panel2.SuspendLayout()
        Me.SplSubMap.SuspendLayout()
        CType(Me.MapView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControls.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.GrObject.SuspendLayout()
        Me.GrControl.SuspendLayout()
        CType(Me.tbrRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrCoor.SuspendLayout()
        Me.TabInfo.SuspendLayout()
        Me.TabTool.SuspendLayout()
        Me.PagePres.SuspendLayout()
        Me.GrEffect.SuspendLayout()
        Me.HLTool.SuspendLayout()
        Me.PresTool.SuspendLayout()
        Me.PageEdit.SuspendLayout()
        Me.GrNote.SuspendLayout()
        Me.GrEdit.SuspendLayout()
        CType(Me.NrMaxView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NrMinView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NrLinewid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NrFillOpa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NrLineOpa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NrDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NrScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageSign.SuspendLayout()
        Me.GrSignlist.SuspendLayout()
        Me.GrSign.SuspendLayout()
        CType(Me.NrFont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPivot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageData.SuspendLayout()
        Me.SourceToolStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MapToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SttBar, Me.PrgBar, Me.LicenseBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 847)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1479, 22)
        Me.StatusStrip.TabIndex = 0
        '
        'SttBar
        '
        Me.SttBar.Image = CType(resources.GetObject("SttBar.Image"), System.Drawing.Image)
        Me.SttBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SttBar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SttBar.Name = "SttBar"
        Me.SttBar.Size = New System.Drawing.Size(178, 17)
        Me.SttBar.Text = "Mở tập tin TerraExplorer(*.fly)"
        '
        'PrgBar
        '
        Me.PrgBar.Name = "PrgBar"
        Me.PrgBar.Size = New System.Drawing.Size(100, 19)
        Me.PrgBar.Visible = False
        '
        'LicenseBar
        '
        Me.LicenseBar.Image = CType(resources.GetObject("LicenseBar.Image"), System.Drawing.Image)
        Me.LicenseBar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LicenseBar.Name = "LicenseBar"
        Me.LicenseBar.Size = New System.Drawing.Size(1286, 20)
        Me.LicenseBar.Spring = True
        Me.LicenseBar.Text = "Thời hạn sử dụng: 10:00"
        Me.LicenseBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LicenseBar.ToolTipText = "Kích hoạt phần mềm"
        Me.LicenseBar.Visible = False
        '
        'DlgOpen
        '
        Me.DlgOpen.DefaultExt = "*.fly"
        Me.DlgOpen.Filter = "TerraExplorer Files|*.fly"
        Me.DlgOpen.RestoreDirectory = True
        Me.DlgOpen.Title = "Open file..."
        '
        'MainToolStrip
        '
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnOpen, Me.BtnSave, Me.BtnClose, Me.ToolStripSeparator1, Me.BtnUndo, Me.BtnRedo, Me.ToolStripSeparator4, Me.BtnShow, Me.BtnHide, Me.BtnReload, Me.BtnLink, Me.BtnUnlink, Me.BtnFollow, Me.ToolStripSeparator6, Me.BtnSetting, Me.BtnHelp, Me.BtnAbout})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainToolStrip.Size = New System.Drawing.Size(1479, 31)
        Me.MainToolStrip.TabIndex = 0
        Me.MainToolStrip.Text = "MainToolStrip"
        '
        'BtnOpen
        '
        Me.BtnOpen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnRecent})
        Me.BtnOpen.Image = CType(resources.GetObject("BtnOpen.Image"), System.Drawing.Image)
        Me.BtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(74, 28)
        Me.BtnOpen.Text = "Mở..."
        Me.BtnOpen.ToolTipText = "Mở file..."
        '
        'MnRecent
        '
        Me.MnRecent.Name = "MnRecent"
        Me.MnRecent.Size = New System.Drawing.Size(206, 22)
        Me.MnRecent.Tag = "1"
        Me.MnRecent.Text = "Chưa có tập tin được mở"
        '
        'BtnSave
        '
        Me.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(28, 28)
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.ToolTipText = "Lưu"
        '
        'BtnClose
        '
        Me.BtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(28, 28)
        Me.BtnClose.Text = "Close"
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
        'BtnReload
        '
        Me.BtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnReload.Enabled = False
        Me.BtnReload.Image = CType(resources.GetObject("BtnReload.Image"), System.Drawing.Image)
        Me.BtnReload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(28, 28)
        Me.BtnReload.Text = "Reload file"
        Me.BtnReload.ToolTipText = "Cập nhật Trình chiếu"
        '
        'BtnLink
        '
        Me.BtnLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnLink.Enabled = False
        Me.BtnLink.Image = CType(resources.GetObject("BtnLink.Image"), System.Drawing.Image)
        Me.BtnLink.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLink.Name = "BtnLink"
        Me.BtnLink.Size = New System.Drawing.Size(28, 28)
        Me.BtnLink.Text = "Play show"
        Me.BtnLink.ToolTipText = "Liên kết màn hình chiếu"
        '
        'BtnUnlink
        '
        Me.BtnUnlink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnUnlink.Image = CType(resources.GetObject("BtnUnlink.Image"), System.Drawing.Image)
        Me.BtnUnlink.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUnlink.Name = "BtnUnlink"
        Me.BtnUnlink.Size = New System.Drawing.Size(28, 28)
        Me.BtnUnlink.Text = "Pause Show"
        Me.BtnUnlink.ToolTipText = "Ngắt liên kết màn hình chiếu"
        Me.BtnUnlink.Visible = False
        '
        'BtnFollow
        '
        Me.BtnFollow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFollow.Image = CType(resources.GetObject("BtnFollow.Image"), System.Drawing.Image)
        Me.BtnFollow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFollow.Name = "BtnFollow"
        Me.BtnFollow.Size = New System.Drawing.Size(28, 28)
        Me.BtnFollow.Text = "Follow"
        Me.BtnFollow.ToolTipText = "Cập nhật vị trí trình chiếu"
        Me.BtnFollow.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'BtnSetting
        '
        Me.BtnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSetting.Image = CType(resources.GetObject("BtnSetting.Image"), System.Drawing.Image)
        Me.BtnSetting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSetting.Name = "BtnSetting"
        Me.BtnSetting.Size = New System.Drawing.Size(28, 28)
        Me.BtnSetting.Text = "Terra setting"
        Me.BtnSetting.ToolTipText = "Cài đặt Terra"
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
        'DlgColor
        '
        Me.DlgColor.FullOpen = True
        '
        'TxtEvent
        '
        Me.TxtEvent.Location = New System.Drawing.Point(857, 0)
        Me.TxtEvent.Name = "TxtEvent"
        Me.TxtEvent.Size = New System.Drawing.Size(251, 25)
        Me.TxtEvent.TabIndex = 0
        Me.TxtEvent.Visible = False
        '
        'TmrFocus
        '
        Me.TmrFocus.Interval = 500
        '
        'MainSpliter
        '
        Me.MainSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.MainSpliter.Location = New System.Drawing.Point(0, 31)
        Me.MainSpliter.Name = "MainSpliter"
        '
        'MainSpliter.Panel1
        '
        Me.MainSpliter.Panel1.Controls.Add(Me.TabMain)
        Me.MainSpliter.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.MainSpliter.Panel1MinSize = 350
        '
        'MainSpliter.Panel2
        '
        Me.MainSpliter.Panel2.Controls.Add(Me.MapSplitter)
        Me.MainSpliter.Panel2.Controls.Add(Me.MapToolStrip)
        Me.MainSpliter.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.MainSpliter.Panel2MinSize = 700
        Me.MainSpliter.Size = New System.Drawing.Size(1479, 816)
        Me.MainSpliter.SplitterDistance = 376
        Me.MainSpliter.TabIndex = 1
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.PageTree)
        Me.TabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMain.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMain.Location = New System.Drawing.Point(3, 3)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(370, 810)
        Me.TabMain.TabIndex = 0
        '
        'PageTree
        '
        Me.PageTree.Controls.Add(Me.MapTree)
        Me.PageTree.Controls.Add(Me.TreeToolStrip)
        Me.PageTree.Location = New System.Drawing.Point(4, 26)
        Me.PageTree.Name = "PageTree"
        Me.PageTree.Padding = New System.Windows.Forms.Padding(3)
        Me.PageTree.Size = New System.Drawing.Size(362, 780)
        Me.PageTree.TabIndex = 0
        Me.PageTree.Text = "Danh sách"
        Me.PageTree.UseVisualStyleBackColor = True
        '
        'MapTree
        '
        Me.MapTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MapTree.Enabled = True
        Me.MapTree.Location = New System.Drawing.Point(3, 40)
        Me.MapTree.Name = "MapTree"
        Me.MapTree.Size = New System.Drawing.Size(356, 737)
        Me.MapTree.TabIndex = 1
        '
        'TreeToolStrip
        '
        Me.TreeToolStrip.Enabled = False
        Me.TreeToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TreeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddGroup, Me.BtnAddLabel, Me.BtnAddLayer, Me.BtnAddPoly, Me.BtnAddPres, Me.BtnAddDmav, Me.ToolStripSeparator5, Me.BtnAddPresHL, Me.BtnStartHL, Me.btnStopHL})
        Me.TreeToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.TreeToolStrip.Name = "TreeToolStrip"
        Me.TreeToolStrip.Padding = New System.Windows.Forms.Padding(3)
        Me.TreeToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TreeToolStrip.Size = New System.Drawing.Size(356, 37)
        Me.TreeToolStrip.TabIndex = 0
        Me.TreeToolStrip.Text = "TreeToolStrip"
        '
        'BtnAddGroup
        '
        Me.BtnAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddGroup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnAddLocation, Me.BtnExpandGroup, Me.BtnUpdateGroup, Me.BtnCleanGroup, Me.MnRemoveNote})
        Me.BtnAddGroup.Image = CType(resources.GetObject("BtnAddGroup.Image"), System.Drawing.Image)
        Me.BtnAddGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddGroup.Name = "BtnAddGroup"
        Me.BtnAddGroup.Size = New System.Drawing.Size(40, 28)
        Me.BtnAddGroup.Text = "Add Group"
        Me.BtnAddGroup.ToolTipText = "Thêm nhóm"
        '
        'MnAddLocation
        '
        Me.MnAddLocation.Image = CType(resources.GetObject("MnAddLocation.Image"), System.Drawing.Image)
        Me.MnAddLocation.Name = "MnAddLocation"
        Me.MnAddLocation.Size = New System.Drawing.Size(179, 30)
        Me.MnAddLocation.Text = "Thêm vị trí"
        '
        'BtnExpandGroup
        '
        Me.BtnExpandGroup.Image = CType(resources.GetObject("BtnExpandGroup.Image"), System.Drawing.Image)
        Me.BtnExpandGroup.Name = "BtnExpandGroup"
        Me.BtnExpandGroup.Size = New System.Drawing.Size(179, 30)
        Me.BtnExpandGroup.Text = "Mở rộng nhóm"
        '
        'BtnUpdateGroup
        '
        Me.BtnUpdateGroup.Image = CType(resources.GetObject("BtnUpdateGroup.Image"), System.Drawing.Image)
        Me.BtnUpdateGroup.Name = "BtnUpdateGroup"
        Me.BtnUpdateGroup.Size = New System.Drawing.Size(179, 30)
        Me.BtnUpdateGroup.Text = "Cập nhật vị trí"
        '
        'BtnCleanGroup
        '
        Me.BtnCleanGroup.Image = CType(resources.GetObject("BtnCleanGroup.Image"), System.Drawing.Image)
        Me.BtnCleanGroup.Name = "BtnCleanGroup"
        Me.BtnCleanGroup.Size = New System.Drawing.Size(179, 30)
        Me.BtnCleanGroup.Text = "Loại bỏ nhóm con"
        '
        'MnRemoveNote
        '
        Me.MnRemoveNote.Image = CType(resources.GetObject("MnRemoveNote.Image"), System.Drawing.Image)
        Me.MnRemoveNote.Name = "MnRemoveNote"
        Me.MnRemoveNote.Size = New System.Drawing.Size(179, 30)
        Me.MnRemoveNote.Text = "Xóa chú thích"
        '
        'BtnAddLabel
        '
        Me.BtnAddLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddLabel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddImage})
        Me.BtnAddLabel.Image = CType(resources.GetObject("BtnAddLabel.Image"), System.Drawing.Image)
        Me.BtnAddLabel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddLabel.Name = "BtnAddLabel"
        Me.BtnAddLabel.Size = New System.Drawing.Size(40, 28)
        Me.BtnAddLabel.Text = "Add Label"
        Me.BtnAddLabel.ToolTipText = "Thêm nhãn"
        '
        'BtnAddImage
        '
        Me.BtnAddImage.Image = CType(resources.GetObject("BtnAddImage.Image"), System.Drawing.Image)
        Me.BtnAddImage.Name = "BtnAddImage"
        Me.BtnAddImage.Size = New System.Drawing.Size(134, 30)
        Me.BtnAddImage.Text = "Nhãn ảnh"
        Me.BtnAddImage.ToolTipText = "Thêm nhãn ảnh"
        '
        'BtnAddLayer
        '
        Me.BtnAddLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddLayer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRaster, Me.AddGroundObject, Me.AddFlyObject, Me.AddStandObject, Me.MnAddFire, Me.MnAddSmoke, Me.MnAddExp})
        Me.BtnAddLayer.Image = CType(resources.GetObject("BtnAddLayer.Image"), System.Drawing.Image)
        Me.BtnAddLayer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddLayer.Name = "BtnAddLayer"
        Me.BtnAddLayer.Size = New System.Drawing.Size(40, 28)
        Me.BtnAddLayer.Text = "ửa"
        Me.BtnAddLayer.ToolTipText = "Thêm lớp"
        '
        'AddRaster
        '
        Me.AddRaster.Image = CType(resources.GetObject("AddRaster.Image"), System.Drawing.Image)
        Me.AddRaster.Name = "AddRaster"
        Me.AddRaster.Size = New System.Drawing.Size(190, 30)
        Me.AddRaster.Text = "Thêm ảnh nền"
        Me.AddRaster.ToolTipText = "Thêm lớp ảnh nền (raster)"
        '
        'AddGroundObject
        '
        Me.AddGroundObject.Image = CType(resources.GetObject("AddGroundObject.Image"), System.Drawing.Image)
        Me.AddGroundObject.Name = "AddGroundObject"
        Me.AddGroundObject.Size = New System.Drawing.Size(190, 30)
        Me.AddGroundObject.Text = "Đối tượng di chuyển"
        '
        'AddFlyObject
        '
        Me.AddFlyObject.Image = CType(resources.GetObject("AddFlyObject.Image"), System.Drawing.Image)
        Me.AddFlyObject.Name = "AddFlyObject"
        Me.AddFlyObject.Size = New System.Drawing.Size(190, 30)
        Me.AddFlyObject.Text = "Đối tượng bay"
        '
        'AddStandObject
        '
        Me.AddStandObject.Image = CType(resources.GetObject("AddStandObject.Image"), System.Drawing.Image)
        Me.AddStandObject.Name = "AddStandObject"
        Me.AddStandObject.Size = New System.Drawing.Size(190, 30)
        Me.AddStandObject.Text = "Đối tượng mặt đất"
        '
        'MnAddFire
        '
        Me.MnAddFire.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnFire1, Me.MnFire2, Me.MnFire3, Me.MnFire4, Me.MnFire5, Me.MnFire6, Me.MnFire7, Me.MnFire8})
        Me.MnAddFire.Image = CType(resources.GetObject("MnAddFire.Image"), System.Drawing.Image)
        Me.MnAddFire.Name = "MnAddFire"
        Me.MnAddFire.Size = New System.Drawing.Size(190, 30)
        Me.MnAddFire.Text = "Lửa cháy"
        '
        'MnFire1
        '
        Me.MnFire1.Name = "MnFire1"
        Me.MnFire1.Size = New System.Drawing.Size(129, 22)
        Me.MnFire1.Tag = "57"
        Me.MnFire1.Text = "Lửa trại"
        '
        'MnFire2
        '
        Me.MnFire2.Name = "MnFire2"
        Me.MnFire2.Size = New System.Drawing.Size(129, 22)
        Me.MnFire2.Tag = "58"
        Me.MnFire2.Text = "Cháy nhà"
        '
        'MnFire3
        '
        Me.MnFire3.Name = "MnFire3"
        Me.MnFire3.Size = New System.Drawing.Size(129, 22)
        Me.MnFire3.Tag = "59"
        Me.MnFire3.Text = "Hóa chất"
        '
        'MnFire4
        '
        Me.MnFire4.Name = "MnFire4"
        Me.MnFire4.Size = New System.Drawing.Size(129, 22)
        Me.MnFire4.Tag = "60"
        Me.MnFire4.Text = "Lửa tàn"
        '
        'MnFire5
        '
        Me.MnFire5.Name = "MnFire5"
        Me.MnFire5.Size = New System.Drawing.Size(129, 22)
        Me.MnFire5.Tag = "61"
        Me.MnFire5.Text = "Cháy nổ"
        '
        'MnFire6
        '
        Me.MnFire6.Name = "MnFire6"
        Me.MnFire6.Size = New System.Drawing.Size(129, 22)
        Me.MnFire6.Tag = "62"
        Me.MnFire6.Text = "Cháy rừng"
        '
        'MnFire7
        '
        Me.MnFire7.Name = "MnFire7"
        Me.MnFire7.Size = New System.Drawing.Size(129, 22)
        Me.MnFire7.Tag = "63"
        Me.MnFire7.Text = "Cháy dầu"
        '
        'MnFire8
        '
        Me.MnFire8.Name = "MnFire8"
        Me.MnFire8.Size = New System.Drawing.Size(129, 22)
        Me.MnFire8.Tag = "64"
        Me.MnFire8.Text = "Hỏa khói"
        '
        'MnAddSmoke
        '
        Me.MnAddSmoke.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnSmoke1, Me.MnSmoke2, Me.MnSmoke3, Me.MnSmoke4, Me.MnSmoke5, Me.MnSmoke6, Me.MnSmoke7})
        Me.MnAddSmoke.Image = CType(resources.GetObject("MnAddSmoke.Image"), System.Drawing.Image)
        Me.MnAddSmoke.Name = "MnAddSmoke"
        Me.MnAddSmoke.Size = New System.Drawing.Size(190, 30)
        Me.MnAddSmoke.Text = "Khói bụi"
        '
        'MnSmoke1
        '
        Me.MnSmoke1.Name = "MnSmoke1"
        Me.MnSmoke1.Size = New System.Drawing.Size(158, 22)
        Me.MnSmoke1.Tag = "48"
        Me.MnSmoke1.Text = "Ống khói trắng"
        '
        'MnSmoke2
        '
        Me.MnSmoke2.Name = "MnSmoke2"
        Me.MnSmoke2.Size = New System.Drawing.Size(158, 22)
        Me.MnSmoke2.Tag = "49"
        Me.MnSmoke2.Text = "Ống khói xám"
        '
        'MnSmoke3
        '
        Me.MnSmoke3.Name = "MnSmoke3"
        Me.MnSmoke3.Size = New System.Drawing.Size(158, 22)
        Me.MnSmoke3.Tag = "50"
        Me.MnSmoke3.Text = "Ống khói đen"
        '
        'MnSmoke4
        '
        Me.MnSmoke4.Name = "MnSmoke4"
        Me.MnSmoke4.Size = New System.Drawing.Size(158, 22)
        Me.MnSmoke4.Tag = "51"
        Me.MnSmoke4.Text = "Ống khói mỏng"
        '
        'MnSmoke5
        '
        Me.MnSmoke5.Name = "MnSmoke5"
        Me.MnSmoke5.Size = New System.Drawing.Size(158, 22)
        Me.MnSmoke5.Tag = "54"
        Me.MnSmoke5.Text = "Lửa khói trắng"
        '
        'MnSmoke6
        '
        Me.MnSmoke6.Name = "MnSmoke6"
        Me.MnSmoke6.Size = New System.Drawing.Size(158, 22)
        Me.MnSmoke6.Tag = "55"
        Me.MnSmoke6.Text = "Lửa khói xám"
        '
        'MnSmoke7
        '
        Me.MnSmoke7.Name = "MnSmoke7"
        Me.MnSmoke7.Size = New System.Drawing.Size(158, 22)
        Me.MnSmoke7.Tag = "56"
        Me.MnSmoke7.Text = "Lửa khói đen"
        '
        'MnAddExp
        '
        Me.MnAddExp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnExp1, Me.MnExp2, Me.MnExp3})
        Me.MnAddExp.Image = CType(resources.GetObject("MnAddExp.Image"), System.Drawing.Image)
        Me.MnAddExp.Name = "MnAddExp"
        Me.MnAddExp.Size = New System.Drawing.Size(190, 30)
        Me.MnAddExp.Text = "Vụ nổ"
        '
        'MnExp1
        '
        Me.MnExp1.Name = "MnExp1"
        Me.MnExp1.Size = New System.Drawing.Size(116, 22)
        Me.MnExp1.Tag = "65"
        Me.MnExp1.Text = "Nổ khói"
        '
        'MnExp2
        '
        Me.MnExp2.Name = "MnExp2"
        Me.MnExp2.Size = New System.Drawing.Size(116, 22)
        Me.MnExp2.Tag = "66"
        Me.MnExp2.Text = "Nổ lửa"
        '
        'MnExp3
        '
        Me.MnExp3.Name = "MnExp3"
        Me.MnExp3.Size = New System.Drawing.Size(116, 22)
        Me.MnExp3.Tag = "67"
        Me.MnExp3.Text = "Nổ đất"
        '
        'BtnAddPoly
        '
        Me.BtnAddPoly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddPoly.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddLine, Me.BtnAddRec, Me.BtnAddCircle, Me.BtnAddArrow})
        Me.BtnAddPoly.Image = CType(resources.GetObject("BtnAddPoly.Image"), System.Drawing.Image)
        Me.BtnAddPoly.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddPoly.Name = "BtnAddPoly"
        Me.BtnAddPoly.Size = New System.Drawing.Size(40, 28)
        Me.BtnAddPoly.Tag = "5"
        Me.BtnAddPoly.Text = "ToolStripButton1"
        Me.BtnAddPoly.ToolTipText = "Thêm đối tượng hình học"
        '
        'BtnAddLine
        '
        Me.BtnAddLine.Image = CType(resources.GetObject("BtnAddLine.Image"), System.Drawing.Image)
        Me.BtnAddLine.Name = "BtnAddLine"
        Me.BtnAddLine.Size = New System.Drawing.Size(158, 30)
        Me.BtnAddLine.Tag = "4"
        Me.BtnAddLine.Text = "Đường"
        '
        'BtnAddRec
        '
        Me.BtnAddRec.Image = CType(resources.GetObject("BtnAddRec.Image"), System.Drawing.Image)
        Me.BtnAddRec.Name = "BtnAddRec"
        Me.BtnAddRec.Size = New System.Drawing.Size(158, 30)
        Me.BtnAddRec.Tag = "6"
        Me.BtnAddRec.Text = "Hình chữ nhật"
        '
        'BtnAddCircle
        '
        Me.BtnAddCircle.Image = CType(resources.GetObject("BtnAddCircle.Image"), System.Drawing.Image)
        Me.BtnAddCircle.Name = "BtnAddCircle"
        Me.BtnAddCircle.Size = New System.Drawing.Size(158, 30)
        Me.BtnAddCircle.Tag = "9"
        Me.BtnAddCircle.Text = "Hình tròn"
        '
        'BtnAddArrow
        '
        Me.BtnAddArrow.Image = CType(resources.GetObject("BtnAddArrow.Image"), System.Drawing.Image)
        Me.BtnAddArrow.Name = "BtnAddArrow"
        Me.BtnAddArrow.Size = New System.Drawing.Size(158, 30)
        Me.BtnAddArrow.Tag = "8"
        Me.BtnAddArrow.Text = "Mũi tên"
        '
        'BtnAddPres
        '
        Me.BtnAddPres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddPres.Image = CType(resources.GetObject("BtnAddPres.Image"), System.Drawing.Image)
        Me.BtnAddPres.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddPres.Name = "BtnAddPres"
        Me.BtnAddPres.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddPres.Text = "Add Presenstation"
        Me.BtnAddPres.ToolTipText = "Thêm trình chiếu"
        '
        'BtnAddDmav
        '
        Me.BtnAddDmav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddDmav.Image = CType(resources.GetObject("BtnAddDmav.Image"), System.Drawing.Image)
        Me.BtnAddDmav.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddDmav.Name = "BtnAddDmav"
        Me.BtnAddDmav.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddDmav.Text = "Add Dmav Data"
        Me.BtnAddDmav.ToolTipText = "Thêm dữ liệu từ Dmav"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'BtnAddPresHL
        '
        Me.BtnAddPresHL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddPresHL.Image = CType(resources.GetObject("BtnAddPresHL.Image"), System.Drawing.Image)
        Me.BtnAddPresHL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddPresHL.Name = "BtnAddPresHL"
        Me.BtnAddPresHL.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddPresHL.Text = "Add Presentation highlight"
        Me.BtnAddPresHL.ToolTipText = "Thêm nhấp nháy vào trình chiếu "
        '
        'BtnStartHL
        '
        Me.BtnStartHL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnStartHL.Image = CType(resources.GetObject("BtnStartHL.Image"), System.Drawing.Image)
        Me.BtnStartHL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStartHL.Name = "BtnStartHL"
        Me.BtnStartHL.Size = New System.Drawing.Size(28, 28)
        Me.BtnStartHL.Text = "Start Highlight"
        Me.BtnStartHL.ToolTipText = "Bắt đầu nhấp nháy"
        '
        'btnStopHL
        '
        Me.btnStopHL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnStopHL.Image = CType(resources.GetObject("btnStopHL.Image"), System.Drawing.Image)
        Me.btnStopHL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStopHL.Name = "btnStopHL"
        Me.btnStopHL.Size = New System.Drawing.Size(28, 28)
        Me.btnStopHL.Text = "Add Presentation highlight"
        Me.btnStopHL.ToolTipText = "Dừng nhấp nháy"
        '
        'MapSplitter
        '
        Me.MapSplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MapSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.MapSplitter.Location = New System.Drawing.Point(3, 34)
        Me.MapSplitter.Name = "MapSplitter"
        '
        'MapSplitter.Panel1
        '
        Me.MapSplitter.Panel1.Controls.Add(Me.SplSubMap)
        Me.MapSplitter.Panel1MinSize = 400
        '
        'MapSplitter.Panel2
        '
        Me.MapSplitter.Panel2.Controls.Add(Me.TabTool)
        Me.MapSplitter.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.MapSplitter.Panel2MinSize = 250
        Me.MapSplitter.Size = New System.Drawing.Size(1093, 779)
        Me.MapSplitter.SplitterDistance = 685
        Me.MapSplitter.TabIndex = 18
        '
        'SplSubMap
        '
        Me.SplSubMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplSubMap.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplSubMap.IsSplitterFixed = True
        Me.SplSubMap.Location = New System.Drawing.Point(0, 0)
        Me.SplSubMap.Name = "SplSubMap"
        Me.SplSubMap.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplSubMap.Panel1
        '
        Me.SplSubMap.Panel1.Controls.Add(Me.LbPresState)
        Me.SplSubMap.Panel1.Controls.Add(Me.MapView)
        '
        'SplSubMap.Panel2
        '
        Me.SplSubMap.Panel2.Controls.Add(Me.TabControls)
        Me.SplSubMap.Size = New System.Drawing.Size(685, 779)
        Me.SplSubMap.SplitterDistance = 357
        Me.SplSubMap.TabIndex = 2
        Me.SplSubMap.TabStop = False
        '
        'LbPresState
        '
        Me.LbPresState.AutoSize = True
        Me.LbPresState.BackColor = System.Drawing.Color.LemonChiffon
        Me.LbPresState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPresState.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPresState.ForeColor = System.Drawing.Color.DarkRed
        Me.LbPresState.Location = New System.Drawing.Point(14, 13)
        Me.LbPresState.Name = "LbPresState"
        Me.LbPresState.Size = New System.Drawing.Size(154, 39)
        Me.LbPresState.TabIndex = 2
        Me.LbPresState.Text = "Trình chiếu"
        Me.LbPresState.Visible = False
        '
        'MapView
        '
        Me.MapView.Enabled = True
        Me.MapView.Location = New System.Drawing.Point(0, 0)
        Me.MapView.Name = "MapView"
        Me.MapView.Size = New System.Drawing.Size(634, 332)
        Me.MapView.TabIndex = 1
        '
        'TabControls
        '
        Me.TabControls.Controls.Add(Me.TabControl)
        Me.TabControls.Controls.Add(Me.TabInfo)
        Me.TabControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControls.Location = New System.Drawing.Point(0, 0)
        Me.TabControls.Name = "TabControls"
        Me.TabControls.SelectedIndex = 0
        Me.TabControls.Size = New System.Drawing.Size(685, 418)
        Me.TabControls.TabIndex = 1
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.GrObject)
        Me.TabControl.Controls.Add(Me.GrControl)
        Me.TabControl.Controls.Add(Me.GrCoor)
        Me.TabControl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(4, 26)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Windows.Forms.Padding(3)
        Me.TabControl.Size = New System.Drawing.Size(677, 388)
        Me.TabControl.TabIndex = 1
        Me.TabControl.Text = "Điều khiển"
        Me.TabControl.UseVisualStyleBackColor = True
        '
        'GrObject
        '
        Me.GrObject.Controls.Add(Me.CmdHideNote2)
        Me.GrObject.Controls.Add(Me.CmdShowNote2)
        Me.GrObject.Controls.Add(Me.CmdStartHL)
        Me.GrObject.Controls.Add(Me.CmdStopHL)
        Me.GrObject.Location = New System.Drawing.Point(10, 6)
        Me.GrObject.Name = "GrObject"
        Me.GrObject.Size = New System.Drawing.Size(270, 103)
        Me.GrObject.TabIndex = 12
        Me.GrObject.TabStop = False
        Me.GrObject.Text = "Đối tượng"
        '
        'CmdHideNote2
        '
        Me.CmdHideNote2.Image = CType(resources.GetObject("CmdHideNote2.Image"), System.Drawing.Image)
        Me.CmdHideNote2.Location = New System.Drawing.Point(168, 61)
        Me.CmdHideNote2.Name = "CmdHideNote2"
        Me.CmdHideNote2.Size = New System.Drawing.Size(85, 28)
        Me.CmdHideNote2.TabIndex = 3
        Me.CmdHideNote2.Text = "Ẩn"
        Me.CmdHideNote2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdHideNote2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdHideNote2.UseVisualStyleBackColor = True
        '
        'CmdShowNote2
        '
        Me.CmdShowNote2.Image = CType(resources.GetObject("CmdShowNote2.Image"), System.Drawing.Image)
        Me.CmdShowNote2.Location = New System.Drawing.Point(168, 27)
        Me.CmdShowNote2.Name = "CmdShowNote2"
        Me.CmdShowNote2.Size = New System.Drawing.Size(85, 28)
        Me.CmdShowNote2.TabIndex = 2
        Me.CmdShowNote2.Text = "Xem"
        Me.CmdShowNote2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdShowNote2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdShowNote2.UseVisualStyleBackColor = True
        '
        'CmdStartHL
        '
        Me.CmdStartHL.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdStartHL.Image = CType(resources.GetObject("CmdStartHL.Image"), System.Drawing.Image)
        Me.CmdStartHL.Location = New System.Drawing.Point(6, 24)
        Me.CmdStartHL.Name = "CmdStartHL"
        Me.CmdStartHL.Size = New System.Drawing.Size(75, 65)
        Me.CmdStartHL.TabIndex = 0
        Me.CmdStartHL.Text = "Nháy"
        Me.CmdStartHL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdStartHL.UseVisualStyleBackColor = True
        '
        'CmdStopHL
        '
        Me.CmdStopHL.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdStopHL.Image = CType(resources.GetObject("CmdStopHL.Image"), System.Drawing.Image)
        Me.CmdStopHL.Location = New System.Drawing.Point(87, 24)
        Me.CmdStopHL.Name = "CmdStopHL"
        Me.CmdStopHL.Size = New System.Drawing.Size(75, 65)
        Me.CmdStopHL.TabIndex = 1
        Me.CmdStopHL.Text = "Dừng"
        Me.CmdStopHL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdStopHL.UseVisualStyleBackColor = True
        '
        'GrControl
        '
        Me.GrControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrControl.Controls.Add(Me.cmdStep)
        Me.GrControl.Controls.Add(Me.tbrRate)
        Me.GrControl.Controls.Add(Me.CmdZoomIn)
        Me.GrControl.Controls.Add(Me.CmdZoomOut)
        Me.GrControl.Controls.Add(Me.CmdRotateLeft)
        Me.GrControl.Controls.Add(Me.CmdGo)
        Me.GrControl.Controls.Add(Me.CmdRotateRight)
        Me.GrControl.Controls.Add(Me.CmdDown)
        Me.GrControl.Controls.Add(Me.PicControl)
        Me.GrControl.Controls.Add(Me.CmdUp)
        Me.GrControl.Controls.Add(Me.CmdStop)
        Me.GrControl.Enabled = False
        Me.GrControl.Location = New System.Drawing.Point(287, 6)
        Me.GrControl.Name = "GrControl"
        Me.GrControl.Size = New System.Drawing.Size(384, 248)
        Me.GrControl.TabIndex = 13
        Me.GrControl.TabStop = False
        Me.GrControl.Text = "Điều hướng"
        '
        'cmdStep
        '
        Me.cmdStep.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdStep.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStep.Location = New System.Drawing.Point(333, 24)
        Me.cmdStep.Name = "cmdStep"
        Me.cmdStep.Size = New System.Drawing.Size(45, 31)
        Me.cmdStep.TabIndex = 10
        Me.cmdStep.Text = "Step"
        Me.cmdStep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdStep.UseVisualStyleBackColor = True
        '
        'tbrRate
        '
        Me.tbrRate.LargeChange = 3
        Me.tbrRate.Location = New System.Drawing.Point(333, 61)
        Me.tbrRate.Maximum = 15
        Me.tbrRate.Name = "tbrRate"
        Me.tbrRate.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrRate.Size = New System.Drawing.Size(45, 99)
        Me.tbrRate.TabIndex = 9
        Me.tbrRate.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.tbrRate.Value = 7
        '
        'CmdZoomIn
        '
        Me.CmdZoomIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdZoomIn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdZoomIn.Image = CType(resources.GetObject("CmdZoomIn.Image"), System.Drawing.Image)
        Me.CmdZoomIn.Location = New System.Drawing.Point(15, 95)
        Me.CmdZoomIn.Name = "CmdZoomIn"
        Me.CmdZoomIn.Size = New System.Drawing.Size(85, 65)
        Me.CmdZoomIn.TabIndex = 3
        Me.CmdZoomIn.Text = "Phóng"
        Me.CmdZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdZoomIn.UseVisualStyleBackColor = True
        '
        'CmdZoomOut
        '
        Me.CmdZoomOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdZoomOut.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdZoomOut.Image = CType(resources.GetObject("CmdZoomOut.Image"), System.Drawing.Image)
        Me.CmdZoomOut.Location = New System.Drawing.Point(15, 166)
        Me.CmdZoomOut.Name = "CmdZoomOut"
        Me.CmdZoomOut.Size = New System.Drawing.Size(85, 65)
        Me.CmdZoomOut.TabIndex = 5
        Me.CmdZoomOut.Text = "Thu"
        Me.CmdZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdZoomOut.UseVisualStyleBackColor = True
        '
        'CmdRotateLeft
        '
        Me.CmdRotateLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdRotateLeft.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdRotateLeft.Image = CType(resources.GetObject("CmdRotateLeft.Image"), System.Drawing.Image)
        Me.CmdRotateLeft.Location = New System.Drawing.Point(196, 166)
        Me.CmdRotateLeft.Name = "CmdRotateLeft"
        Me.CmdRotateLeft.Size = New System.Drawing.Size(85, 65)
        Me.CmdRotateLeft.TabIndex = 7
        Me.CmdRotateLeft.Text = "Xoay trái"
        Me.CmdRotateLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdRotateLeft.UseVisualStyleBackColor = True
        '
        'CmdGo
        '
        Me.CmdGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdGo.BackColor = System.Drawing.Color.Transparent
        Me.CmdGo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGo.Image = CType(resources.GetObject("CmdGo.Image"), System.Drawing.Image)
        Me.CmdGo.Location = New System.Drawing.Point(15, 24)
        Me.CmdGo.Name = "CmdGo"
        Me.CmdGo.Size = New System.Drawing.Size(85, 65)
        Me.CmdGo.TabIndex = 1
        Me.CmdGo.Text = "Go"
        Me.CmdGo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdGo.UseVisualStyleBackColor = False
        '
        'CmdRotateRight
        '
        Me.CmdRotateRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdRotateRight.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdRotateRight.Image = CType(resources.GetObject("CmdRotateRight.Image"), System.Drawing.Image)
        Me.CmdRotateRight.Location = New System.Drawing.Point(287, 166)
        Me.CmdRotateRight.Name = "CmdRotateRight"
        Me.CmdRotateRight.Size = New System.Drawing.Size(85, 65)
        Me.CmdRotateRight.TabIndex = 8
        Me.CmdRotateRight.Text = "Xoay phải"
        Me.CmdRotateRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdRotateRight.UseVisualStyleBackColor = True
        '
        'CmdDown
        '
        Me.CmdDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdDown.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDown.Image = CType(resources.GetObject("CmdDown.Image"), System.Drawing.Image)
        Me.CmdDown.Location = New System.Drawing.Point(106, 166)
        Me.CmdDown.Name = "CmdDown"
        Me.CmdDown.Size = New System.Drawing.Size(85, 65)
        Me.CmdDown.TabIndex = 6
        Me.CmdDown.Text = "Xuống"
        Me.CmdDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdDown.UseVisualStyleBackColor = True
        '
        'PicControl
        '
        Me.PicControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicControl.Location = New System.Drawing.Point(196, 24)
        Me.PicControl.Name = "PicControl"
        Me.PicControl.Size = New System.Drawing.Size(131, 136)
        Me.PicControl.TabIndex = 6
        Me.PicControl.TabStop = False
        '
        'CmdUp
        '
        Me.CmdUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdUp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdUp.Image = CType(resources.GetObject("CmdUp.Image"), System.Drawing.Image)
        Me.CmdUp.Location = New System.Drawing.Point(106, 95)
        Me.CmdUp.Name = "CmdUp"
        Me.CmdUp.Size = New System.Drawing.Size(85, 65)
        Me.CmdUp.TabIndex = 4
        Me.CmdUp.Text = "Lên"
        Me.CmdUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdUp.UseVisualStyleBackColor = True
        '
        'CmdStop
        '
        Me.CmdStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdStop.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdStop.Image = CType(resources.GetObject("CmdStop.Image"), System.Drawing.Image)
        Me.CmdStop.Location = New System.Drawing.Point(106, 24)
        Me.CmdStop.Name = "CmdStop"
        Me.CmdStop.Size = New System.Drawing.Size(85, 65)
        Me.CmdStop.TabIndex = 2
        Me.CmdStop.Text = "Stop"
        Me.CmdStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdStop.UseVisualStyleBackColor = True
        '
        'GrCoor
        '
        Me.GrCoor.Controls.Add(Me.Label19)
        Me.GrCoor.Controls.Add(Me.Label17)
        Me.GrCoor.Controls.Add(Me.TxY)
        Me.GrCoor.Controls.Add(Me.TxX)
        Me.GrCoor.Controls.Add(Me.CbCoor)
        Me.GrCoor.Location = New System.Drawing.Point(10, 115)
        Me.GrCoor.Name = "GrCoor"
        Me.GrCoor.Size = New System.Drawing.Size(270, 139)
        Me.GrCoor.TabIndex = 14
        Me.GrCoor.TabStop = False
        Me.GrCoor.Text = "Hệ tọa độ"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 91)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 17)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Y:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 17)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "X:"
        '
        'TxY
        '
        Me.TxY.Location = New System.Drawing.Point(28, 88)
        Me.TxY.Name = "TxY"
        Me.TxY.Size = New System.Drawing.Size(225, 25)
        Me.TxY.TabIndex = 3
        '
        'TxX
        '
        Me.TxX.Location = New System.Drawing.Point(28, 57)
        Me.TxX.Name = "TxX"
        Me.TxX.Size = New System.Drawing.Size(225, 25)
        Me.TxX.TabIndex = 2
        '
        'CbCoor
        '
        Me.CbCoor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCoor.FormattingEnabled = True
        Me.CbCoor.IntegralHeight = False
        Me.CbCoor.ItemHeight = 17
        Me.CbCoor.Items.AddRange(New Object() {"VN-2000 / UTM zone 48N", "VN-2000 / UTM zone 49N", "VN-2000 / TM-3 Da Nang zone", "VN-2000 / TM-3 108", "VN-2000 / TM-3 105", "VN-2000 / TM-3 102"})
        Me.CbCoor.Location = New System.Drawing.Point(6, 26)
        Me.CbCoor.Name = "CbCoor"
        Me.CbCoor.Size = New System.Drawing.Size(247, 25)
        Me.CbCoor.TabIndex = 1
        Me.CbCoor.Tag = "1"
        '
        'TabInfo
        '
        Me.TabInfo.Controls.Add(Me.LvInfo)
        Me.TabInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabInfo.Location = New System.Drawing.Point(4, 22)
        Me.TabInfo.Name = "TabInfo"
        Me.TabInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInfo.Size = New System.Drawing.Size(677, 392)
        Me.TabInfo.TabIndex = 0
        Me.TabInfo.Text = "Thông tin"
        Me.TabInfo.UseVisualStyleBackColor = True
        '
        'LvInfo
        '
        Me.LvInfo.AllowDrop = True
        Me.LvInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cIcon, Me.cInfo})
        Me.LvInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvInfo.FullRowSelect = True
        Me.LvInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LvInfo.HideSelection = False
        Me.LvInfo.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LvInfo.Location = New System.Drawing.Point(3, 3)
        Me.LvInfo.Name = "LvInfo"
        Me.LvInfo.ShowGroups = False
        Me.LvInfo.Size = New System.Drawing.Size(671, 386)
        Me.LvInfo.SmallImageList = Me.ImgSmall
        Me.LvInfo.TabIndex = 0
        Me.LvInfo.UseCompatibleStateImageBehavior = False
        Me.LvInfo.View = System.Windows.Forms.View.Details
        '
        'cIcon
        '
        Me.cIcon.Text = "Đối tượng"
        Me.cIcon.Width = 20
        '
        'cInfo
        '
        Me.cInfo.Width = 200
        '
        'ImgSmall
        '
        Me.ImgSmall.ImageStream = CType(resources.GetObject("ImgSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgSmall.Images.SetKeyName(0, "Info")
        Me.ImgSmall.Images.SetKeyName(1, "Warning")
        Me.ImgSmall.Images.SetKeyName(2, "Exclam")
        Me.ImgSmall.Images.SetKeyName(3, "Message")
        Me.ImgSmall.Images.SetKeyName(4, "Accept")
        Me.ImgSmall.Images.SetKeyName(5, "Cancel")
        Me.ImgSmall.Images.SetKeyName(6, "Find")
        Me.ImgSmall.Images.SetKeyName(7, "Wait")
        Me.ImgSmall.Images.SetKeyName(8, "Pivot")
        Me.ImgSmall.Images.SetKeyName(9, "Time")
        '
        'TabTool
        '
        Me.TabTool.Controls.Add(Me.PagePres)
        Me.TabTool.Controls.Add(Me.PageEdit)
        Me.TabTool.Controls.Add(Me.PageSign)
        Me.TabTool.Controls.Add(Me.PageData)
        Me.TabTool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabTool.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabTool.Location = New System.Drawing.Point(3, 3)
        Me.TabTool.Name = "TabTool"
        Me.TabTool.SelectedIndex = 0
        Me.TabTool.Size = New System.Drawing.Size(398, 773)
        Me.TabTool.TabIndex = 0
        '
        'PagePres
        '
        Me.PagePres.Controls.Add(Me.GrEffect)
        Me.PagePres.Controls.Add(Me.LbPres)
        Me.PagePres.Controls.Add(Me.PresTool)
        Me.PagePres.Controls.Add(Me.CmbEdit)
        Me.PagePres.Controls.Add(Me.LvSteps)
        Me.PagePres.Location = New System.Drawing.Point(4, 26)
        Me.PagePres.Name = "PagePres"
        Me.PagePres.Padding = New System.Windows.Forms.Padding(3)
        Me.PagePres.Size = New System.Drawing.Size(390, 743)
        Me.PagePres.TabIndex = 1
        Me.PagePres.Text = "Trình chiếu"
        Me.PagePres.UseVisualStyleBackColor = True
        '
        'GrEffect
        '
        Me.GrEffect.Controls.Add(Me.cmbEffect)
        Me.GrEffect.Controls.Add(Me.LvHighlight)
        Me.GrEffect.Controls.Add(Me.HLTool)
        Me.GrEffect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrEffect.Location = New System.Drawing.Point(3, 502)
        Me.GrEffect.Name = "GrEffect"
        Me.GrEffect.Size = New System.Drawing.Size(384, 238)
        Me.GrEffect.TabIndex = 5
        Me.GrEffect.TabStop = False
        Me.GrEffect.Text = "Hiệu ứng"
        '
        'cmbEffect
        '
        Me.cmbEffect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEffect.FormattingEnabled = True
        Me.cmbEffect.IntegralHeight = False
        Me.cmbEffect.ItemHeight = 17
        Me.cmbEffect.Items.AddRange(New Object() {"Nhấp nháy", "Hiện", "Ẩn"})
        Me.cmbEffect.Location = New System.Drawing.Point(242, 98)
        Me.cmbEffect.Name = "cmbEffect"
        Me.cmbEffect.Size = New System.Drawing.Size(112, 25)
        Me.cmbEffect.TabIndex = 27
        Me.cmbEffect.Tag = "1"
        Me.cmbEffect.Visible = False
        '
        'LvHighlight
        '
        Me.LvHighlight.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cleName, Me.cleType})
        Me.LvHighlight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvHighlight.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvHighlight.FullRowSelect = True
        Me.LvHighlight.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvHighlight.HideSelection = False
        Me.LvHighlight.Location = New System.Drawing.Point(3, 57)
        Me.LvHighlight.Name = "LvHighlight"
        Me.LvHighlight.ShowGroups = False
        Me.LvHighlight.Size = New System.Drawing.Size(378, 178)
        Me.LvHighlight.TabIndex = 26
        Me.LvHighlight.UseCompatibleStateImageBehavior = False
        Me.LvHighlight.View = System.Windows.Forms.View.Details
        '
        'cleName
        '
        Me.cleName.Text = "Đối tượng"
        Me.cleName.Width = 250
        '
        'cleType
        '
        Me.cleType.Text = "Hiệu ứng"
        Me.cleType.Width = 120
        '
        'HLTool
        '
        Me.HLTool.AutoSize = False
        Me.HLTool.Enabled = False
        Me.HLTool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HLTool.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.HLTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddPresHL2, Me.BtnStartPresHL, Me.BtnStopPresHL, Me.btnReLoadEffect, Me.ToolStripSeparator3, Me.BtnDelPresHL})
        Me.HLTool.Location = New System.Drawing.Point(3, 21)
        Me.HLTool.Name = "HLTool"
        Me.HLTool.Padding = New System.Windows.Forms.Padding(3)
        Me.HLTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HLTool.Size = New System.Drawing.Size(378, 36)
        Me.HLTool.TabIndex = 25
        Me.HLTool.Text = "Presenstation Play control"
        '
        'BtnAddPresHL2
        '
        Me.BtnAddPresHL2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddPresHL2.Image = CType(resources.GetObject("BtnAddPresHL2.Image"), System.Drawing.Image)
        Me.BtnAddPresHL2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddPresHL2.Name = "BtnAddPresHL2"
        Me.BtnAddPresHL2.Size = New System.Drawing.Size(28, 27)
        Me.BtnAddPresHL2.Text = "Thêm nhấp nháy"
        Me.BtnAddPresHL2.ToolTipText = "Thêm nhấp nháy"
        '
        'BtnStartPresHL
        '
        Me.BtnStartPresHL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnStartPresHL.Image = CType(resources.GetObject("BtnStartPresHL.Image"), System.Drawing.Image)
        Me.BtnStartPresHL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStartPresHL.Name = "BtnStartPresHL"
        Me.BtnStartPresHL.Size = New System.Drawing.Size(28, 27)
        Me.BtnStartPresHL.Text = "Start Pres Highlight"
        Me.BtnStartPresHL.ToolTipText = "Bắt đầu nhấp nháy"
        '
        'BtnStopPresHL
        '
        Me.BtnStopPresHL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnStopPresHL.Image = CType(resources.GetObject("BtnStopPresHL.Image"), System.Drawing.Image)
        Me.BtnStopPresHL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStopPresHL.Name = "BtnStopPresHL"
        Me.BtnStopPresHL.Size = New System.Drawing.Size(28, 27)
        Me.BtnStopPresHL.Text = "Add Presentation highlight"
        Me.BtnStopPresHL.ToolTipText = "Dừng nhấp nháy"
        Me.BtnStopPresHL.Visible = False
        '
        'btnReLoadEffect
        '
        Me.btnReLoadEffect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReLoadEffect.Image = CType(resources.GetObject("btnReLoadEffect.Image"), System.Drawing.Image)
        Me.btnReLoadEffect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReLoadEffect.Name = "btnReLoadEffect"
        Me.btnReLoadEffect.Size = New System.Drawing.Size(28, 27)
        Me.btnReLoadEffect.Text = "Tải lại hiệu ứng"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'BtnDelPresHL
        '
        Me.BtnDelPresHL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDelPresHL.Image = CType(resources.GetObject("BtnDelPresHL.Image"), System.Drawing.Image)
        Me.BtnDelPresHL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelPresHL.Name = "BtnDelPresHL"
        Me.BtnDelPresHL.Size = New System.Drawing.Size(28, 27)
        Me.BtnDelPresHL.Text = "Xóa hiệu ứng"
        Me.BtnDelPresHL.ToolTipText = "Xóa hiệu ứng"
        '
        'LbPres
        '
        Me.LbPres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbPres.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPres.Location = New System.Drawing.Point(2, 40)
        Me.LbPres.Name = "LbPres"
        Me.LbPres.Size = New System.Drawing.Size(385, 25)
        Me.LbPres.TabIndex = 1
        Me.LbPres.Text = "Trình chiếu"
        '
        'PresTool
        '
        Me.PresTool.AutoSize = False
        Me.PresTool.Enabled = False
        Me.PresTool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PresTool.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.PresTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrivous, Me.BtnPlay, Me.BtnStep, Me.BtnPause, Me.BtnNext, Me.BtnStop, Me.ToolStripSeparator2, Me.BtnAddPresLocation, Me.BtnDelPres, Me.BtnUpdatePreslocation, Me.BtnKeystep, Me.BtnRepres})
        Me.PresTool.Location = New System.Drawing.Point(3, 3)
        Me.PresTool.Name = "PresTool"
        Me.PresTool.Padding = New System.Windows.Forms.Padding(3)
        Me.PresTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.PresTool.Size = New System.Drawing.Size(384, 37)
        Me.PresTool.TabIndex = 0
        Me.PresTool.Text = "Presenstation Play control"
        '
        'BtnPrivous
        '
        Me.BtnPrivous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrivous.Image = CType(resources.GetObject("BtnPrivous.Image"), System.Drawing.Image)
        Me.BtnPrivous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrivous.Name = "BtnPrivous"
        Me.BtnPrivous.Size = New System.Drawing.Size(28, 28)
        Me.BtnPrivous.Text = "Privous"
        Me.BtnPrivous.ToolTipText = "Lùi lại"
        '
        'BtnPlay
        '
        Me.BtnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPlay.Image = CType(resources.GetObject("BtnPlay.Image"), System.Drawing.Image)
        Me.BtnPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(28, 28)
        Me.BtnPlay.Text = "Play"
        Me.BtnPlay.ToolTipText = "Bắt đầu trình chiếu"
        '
        'BtnStep
        '
        Me.BtnStep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnStep.Image = CType(resources.GetObject("BtnStep.Image"), System.Drawing.Image)
        Me.BtnStep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStep.Name = "BtnStep"
        Me.BtnStep.Size = New System.Drawing.Size(28, 28)
        Me.BtnStep.Text = "Continous"
        Me.BtnStep.ToolTipText = "Tiếp tục trình chiếu"
        Me.BtnStep.Visible = False
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
        'BtnNext
        '
        Me.BtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(28, 28)
        Me.BtnNext.Text = "Next"
        Me.BtnNext.ToolTipText = "Kế tiếp"
        '
        'BtnStop
        '
        Me.BtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnStop.Image = CType(resources.GetObject("BtnStop.Image"), System.Drawing.Image)
        Me.BtnStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(28, 28)
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.ToolTipText = "Dừng trình chiếu"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BtnAddPresLocation
        '
        Me.BtnAddPresLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAddPresLocation.Image = CType(resources.GetObject("BtnAddPresLocation.Image"), System.Drawing.Image)
        Me.BtnAddPresLocation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddPresLocation.Name = "BtnAddPresLocation"
        Me.BtnAddPresLocation.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddPresLocation.Text = "Add Location"
        Me.BtnAddPresLocation.ToolTipText = "Thêm vị trí vào trình chiếu"
        '
        'BtnDelPres
        '
        Me.BtnDelPres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDelPres.Image = CType(resources.GetObject("BtnDelPres.Image"), System.Drawing.Image)
        Me.BtnDelPres.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelPres.Name = "BtnDelPres"
        Me.BtnDelPres.Size = New System.Drawing.Size(28, 28)
        Me.BtnDelPres.Text = "Remove steps"
        Me.BtnDelPres.ToolTipText = "Xóa bước trình chiếu"
        '
        'BtnUpdatePreslocation
        '
        Me.BtnUpdatePreslocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnUpdatePreslocation.Image = CType(resources.GetObject("BtnUpdatePreslocation.Image"), System.Drawing.Image)
        Me.BtnUpdatePreslocation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdatePreslocation.Name = "BtnUpdatePreslocation"
        Me.BtnUpdatePreslocation.Size = New System.Drawing.Size(28, 28)
        Me.BtnUpdatePreslocation.Text = "Update Location"
        Me.BtnUpdatePreslocation.ToolTipText = "Cập nhật vị trí"
        '
        'BtnKeystep
        '
        Me.BtnKeystep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnKeystep.Image = CType(resources.GetObject("BtnKeystep.Image"), System.Drawing.Image)
        Me.BtnKeystep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnKeystep.Name = "BtnKeystep"
        Me.BtnKeystep.Size = New System.Drawing.Size(28, 28)
        Me.BtnKeystep.Text = "Mark Keystep"
        Me.BtnKeystep.ToolTipText = "Đánh dấu mục"
        '
        'BtnRepres
        '
        Me.BtnRepres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnRepres.Image = CType(resources.GetObject("BtnRepres.Image"), System.Drawing.Image)
        Me.BtnRepres.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRepres.Name = "BtnRepres"
        Me.BtnRepres.Size = New System.Drawing.Size(28, 28)
        Me.BtnRepres.Text = "Reload Presentation"
        Me.BtnRepres.ToolTipText = "Tải lại danh sách"
        '
        'CmbEdit
        '
        Me.CmbEdit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEdit.FormattingEnabled = True
        Me.CmbEdit.IntegralHeight = False
        Me.CmbEdit.ItemHeight = 17
        Me.CmbEdit.Location = New System.Drawing.Point(70, 262)
        Me.CmbEdit.Name = "CmbEdit"
        Me.CmbEdit.Size = New System.Drawing.Size(112, 25)
        Me.CmbEdit.TabIndex = 0
        Me.CmbEdit.Tag = "1"
        Me.CmbEdit.Visible = False
        '
        'LvSteps
        '
        Me.LvSteps.AllowDrop = True
        Me.LvSteps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvSteps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7})
        Me.LvSteps.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvSteps.FullRowSelect = True
        Me.LvSteps.HideSelection = False
        Me.LvSteps.LabelWrap = False
        Me.LvSteps.Location = New System.Drawing.Point(6, 68)
        Me.LvSteps.Name = "LvSteps"
        Me.LvSteps.ShowGroups = False
        Me.LvSteps.Size = New System.Drawing.Size(375, 427)
        Me.LvSteps.TabIndex = 1
        Me.LvSteps.UseCompatibleStateImageBehavior = False
        Me.LvSteps.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "TT"
        Me.ColumnHeader1.Width = 36
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mô tả"
        Me.ColumnHeader2.Width = 121
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Hành động"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Giây"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 50
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Hiệu ứng"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 77
        '
        'PageEdit
        '
        Me.PageEdit.Controls.Add(Me.TxName)
        Me.PageEdit.Controls.Add(Me.Label18)
        Me.PageEdit.Controls.Add(Me.GrNote)
        Me.PageEdit.Controls.Add(Me.GrEdit)
        Me.PageEdit.Location = New System.Drawing.Point(4, 26)
        Me.PageEdit.Name = "PageEdit"
        Me.PageEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.PageEdit.Size = New System.Drawing.Size(390, 743)
        Me.PageEdit.TabIndex = 3
        Me.PageEdit.Text = "Chỉnh sửa"
        Me.PageEdit.UseVisualStyleBackColor = True
        '
        'TxName
        '
        Me.TxName.Location = New System.Drawing.Point(101, 16)
        Me.TxName.Name = "TxName"
        Me.TxName.Size = New System.Drawing.Size(280, 25)
        Me.TxName.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 17)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Tên:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrNote
        '
        Me.GrNote.Controls.Add(Me.CmdDelNote)
        Me.GrNote.Controls.Add(Me.CmdHideNote)
        Me.GrNote.Controls.Add(Me.CmdSaveNote)
        Me.GrNote.Controls.Add(Me.cmdShowNote)
        Me.GrNote.Controls.Add(Me.TxNote)
        Me.GrNote.Location = New System.Drawing.Point(3, 484)
        Me.GrNote.Name = "GrNote"
        Me.GrNote.Size = New System.Drawing.Size(378, 262)
        Me.GrNote.TabIndex = 40
        Me.GrNote.TabStop = False
        Me.GrNote.Text = "Chú thích"
        '
        'CmdDelNote
        '
        Me.CmdDelNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdDelNote.Image = CType(resources.GetObject("CmdDelNote.Image"), System.Drawing.Image)
        Me.CmdDelNote.Location = New System.Drawing.Point(264, 224)
        Me.CmdDelNote.Name = "CmdDelNote"
        Me.CmdDelNote.Size = New System.Drawing.Size(77, 27)
        Me.CmdDelNote.TabIndex = 20
        Me.CmdDelNote.Text = "Xóa"
        Me.CmdDelNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdDelNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdDelNote.UseVisualStyleBackColor = True
        '
        'CmdHideNote
        '
        Me.CmdHideNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdHideNote.Image = CType(resources.GetObject("CmdHideNote.Image"), System.Drawing.Image)
        Me.CmdHideNote.Location = New System.Drawing.Point(181, 224)
        Me.CmdHideNote.Name = "CmdHideNote"
        Me.CmdHideNote.Size = New System.Drawing.Size(77, 27)
        Me.CmdHideNote.TabIndex = 19
        Me.CmdHideNote.Text = "Ẩn"
        Me.CmdHideNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdHideNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdHideNote.UseVisualStyleBackColor = True
        '
        'CmdSaveNote
        '
        Me.CmdSaveNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSaveNote.Image = CType(resources.GetObject("CmdSaveNote.Image"), System.Drawing.Image)
        Me.CmdSaveNote.Location = New System.Drawing.Point(17, 224)
        Me.CmdSaveNote.Name = "CmdSaveNote"
        Me.CmdSaveNote.Size = New System.Drawing.Size(77, 27)
        Me.CmdSaveNote.TabIndex = 17
        Me.CmdSaveNote.Text = "Lưu"
        Me.CmdSaveNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdSaveNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdSaveNote.UseVisualStyleBackColor = True
        '
        'cmdShowNote
        '
        Me.cmdShowNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdShowNote.Image = CType(resources.GetObject("cmdShowNote.Image"), System.Drawing.Image)
        Me.cmdShowNote.Location = New System.Drawing.Point(98, 224)
        Me.cmdShowNote.Name = "cmdShowNote"
        Me.cmdShowNote.Size = New System.Drawing.Size(77, 27)
        Me.cmdShowNote.TabIndex = 18
        Me.cmdShowNote.Text = "Xem"
        Me.cmdShowNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdShowNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdShowNote.UseVisualStyleBackColor = True
        '
        'TxNote
        '
        Me.TxNote.Location = New System.Drawing.Point(16, 24)
        Me.TxNote.Multiline = True
        Me.TxNote.Name = "TxNote"
        Me.TxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxNote.Size = New System.Drawing.Size(345, 194)
        Me.TxNote.TabIndex = 16
        '
        'GrEdit
        '
        Me.GrEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrEdit.Controls.Add(Me.CbAltmed)
        Me.GrEdit.Controls.Add(Me.Label24)
        Me.GrEdit.Controls.Add(Me.Label21)
        Me.GrEdit.Controls.Add(Me.NrMaxView)
        Me.GrEdit.Controls.Add(Me.Label22)
        Me.GrEdit.Controls.Add(Me.Label23)
        Me.GrEdit.Controls.Add(Me.NrMinView)
        Me.GrEdit.Controls.Add(Me.Label20)
        Me.GrEdit.Controls.Add(Me.TxLabel)
        Me.GrEdit.Controls.Add(Me.CmdApply)
        Me.GrEdit.Controls.Add(Me.lbLabel)
        Me.GrEdit.Controls.Add(Me.Label3)
        Me.GrEdit.Controls.Add(Me.TxtFilename)
        Me.GrEdit.Controls.Add(Me.CmdOpen)
        Me.GrEdit.Controls.Add(Me.NrLinewid)
        Me.GrEdit.Controls.Add(Me.NrFillOpa)
        Me.GrEdit.Controls.Add(Me.Label1)
        Me.GrEdit.Controls.Add(Me.NrLineOpa)
        Me.GrEdit.Controls.Add(Me.Label4)
        Me.GrEdit.Controls.Add(Me.NrDis)
        Me.GrEdit.Controls.Add(Me.Label2)
        Me.GrEdit.Controls.Add(Me.NrScale)
        Me.GrEdit.Controls.Add(Me.Label6)
        Me.GrEdit.Controls.Add(Me.TxtFillColor)
        Me.GrEdit.Controls.Add(Me.Label5)
        Me.GrEdit.Controls.Add(Me.TxtLineColor)
        Me.GrEdit.Controls.Add(Me.Label11)
        Me.GrEdit.Controls.Add(Me.Label9)
        Me.GrEdit.Controls.Add(Me.Label10)
        Me.GrEdit.Controls.Add(Me.Label8)
        Me.GrEdit.Controls.Add(Me.Label7)
        Me.GrEdit.Location = New System.Drawing.Point(6, 47)
        Me.GrEdit.Name = "GrEdit"
        Me.GrEdit.Size = New System.Drawing.Size(378, 431)
        Me.GrEdit.TabIndex = 38
        Me.GrEdit.TabStop = False
        Me.GrEdit.Text = "Cơ bản"
        '
        'CbAltmed
        '
        Me.CbAltmed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAltmed.FormattingEnabled = True
        Me.CbAltmed.IntegralHeight = False
        Me.CbAltmed.ItemHeight = 17
        Me.CbAltmed.Items.AddRange(New Object() {"Tương đối", "Tuyệt đối", "Trên trục", "Trên nền"})
        Me.CbAltmed.Location = New System.Drawing.Point(178, 311)
        Me.CbAltmed.Name = "CbAltmed"
        Me.CbAltmed.Size = New System.Drawing.Size(127, 25)
        Me.CbAltmed.TabIndex = 50
        Me.CbAltmed.Tag = "1"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 314)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(130, 17)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "Phương thức cao độ:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(278, 240)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 17)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Km"
        '
        'NrMaxView
        '
        Me.NrMaxView.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NrMaxView.Location = New System.Drawing.Point(178, 238)
        Me.NrMaxView.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NrMaxView.Name = "NrMaxView"
        Me.NrMaxView.Size = New System.Drawing.Size(94, 25)
        Me.NrMaxView.TabIndex = 11
        Me.NrMaxView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NrMaxView.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(10, 242)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 17)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Ngưỡng nhìn trên:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(278, 273)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 17)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Km"
        '
        'NrMinView
        '
        Me.NrMinView.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NrMinView.Location = New System.Drawing.Point(178, 271)
        Me.NrMinView.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NrMinView.Name = "NrMinView"
        Me.NrMinView.Size = New System.Drawing.Size(94, 25)
        Me.NrMinView.TabIndex = 12
        Me.NrMinView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 275)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(119, 17)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Ngưỡng nhìn dưới:"
        '
        'TxLabel
        '
        Me.TxLabel.Location = New System.Drawing.Point(92, 17)
        Me.TxLabel.Multiline = True
        Me.TxLabel.Name = "TxLabel"
        Me.TxLabel.Size = New System.Drawing.Size(213, 61)
        Me.TxLabel.TabIndex = 2
        '
        'CmdApply
        '
        Me.CmdApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdApply.Image = CType(resources.GetObject("CmdApply.Image"), System.Drawing.Image)
        Me.CmdApply.Location = New System.Drawing.Point(10, 393)
        Me.CmdApply.Name = "CmdApply"
        Me.CmdApply.Size = New System.Drawing.Size(94, 27)
        Me.CmdApply.TabIndex = 15
        Me.CmdApply.Text = "Áp dụng"
        Me.CmdApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdApply.UseVisualStyleBackColor = True
        '
        'lbLabel
        '
        Me.lbLabel.AutoSize = True
        Me.lbLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLabel.Location = New System.Drawing.Point(10, 21)
        Me.lbLabel.Name = "lbLabel"
        Me.lbLabel.Size = New System.Drawing.Size(42, 17)
        Me.lbLabel.TabIndex = 38
        Me.lbLabel.Text = "Nhãn:"
        Me.lbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tập tin:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtFilename
        '
        Me.TxtFilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFilename.Location = New System.Drawing.Point(10, 362)
        Me.TxtFilename.Name = "TxtFilename"
        Me.TxtFilename.ReadOnly = True
        Me.TxtFilename.Size = New System.Drawing.Size(250, 25)
        Me.TxtFilename.TabIndex = 13
        Me.TxtFilename.Tag = "False"
        '
        'CmdOpen
        '
        Me.CmdOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOpen.Image = CType(resources.GetObject("CmdOpen.Image"), System.Drawing.Image)
        Me.CmdOpen.Location = New System.Drawing.Point(266, 362)
        Me.CmdOpen.Name = "CmdOpen"
        Me.CmdOpen.Size = New System.Drawing.Size(74, 27)
        Me.CmdOpen.TabIndex = 14
        Me.CmdOpen.Text = "Mở..."
        Me.CmdOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdOpen.UseVisualStyleBackColor = True
        '
        'NrLinewid
        '
        Me.NrLinewid.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NrLinewid.Location = New System.Drawing.Point(92, 84)
        Me.NrLinewid.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NrLinewid.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.NrLinewid.Name = "NrLinewid"
        Me.NrLinewid.Size = New System.Drawing.Size(77, 25)
        Me.NrLinewid.TabIndex = 3
        Me.NrLinewid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NrLinewid.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'NrFillOpa
        '
        Me.NrFillOpa.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NrFillOpa.Location = New System.Drawing.Point(255, 143)
        Me.NrFillOpa.Name = "NrFillOpa"
        Me.NrFillOpa.Size = New System.Drawing.Size(50, 25)
        Me.NrFillOpa.TabIndex = 7
        Me.NrFillOpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NrFillOpa.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Độ nét:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NrLineOpa
        '
        Me.NrLineOpa.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NrLineOpa.Location = New System.Drawing.Point(255, 112)
        Me.NrLineOpa.Name = "NrLineOpa"
        Me.NrLineOpa.Size = New System.Drawing.Size(50, 25)
        Me.NrLineOpa.TabIndex = 5
        Me.NrLineOpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NrLineOpa.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Màu nền:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NrDis
        '
        Me.NrDis.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NrDis.Location = New System.Drawing.Point(178, 207)
        Me.NrDis.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NrDis.Name = "NrDis"
        Me.NrDis.Size = New System.Drawing.Size(94, 25)
        Me.NrDis.TabIndex = 9
        Me.NrDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NrDis.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Màu viền:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NrScale
        '
        Me.NrScale.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NrScale.Location = New System.Drawing.Point(178, 174)
        Me.NrScale.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NrScale.Name = "NrScale"
        Me.NrScale.Size = New System.Drawing.Size(58, 25)
        Me.NrScale.TabIndex = 8
        Me.NrScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NrScale.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Trong suốt:"
        '
        'TxtFillColor
        '
        Me.TxtFillColor.AutoCompleteCustomSource.AddRange(New String() {"100", "200", "300", "400", "500", "600", "700", "800", "900", "1000", "1100", "1200", "1300", "1400", "1500"})
        Me.TxtFillColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtFillColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtFillColor.BackColor = System.Drawing.Color.Red
        Me.TxtFillColor.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtFillColor.Location = New System.Drawing.Point(92, 143)
        Me.TxtFillColor.Name = "TxtFillColor"
        Me.TxtFillColor.Size = New System.Drawing.Size(77, 25)
        Me.TxtFillColor.TabIndex = 6
        Me.TxtFillColor.Tag = ""
        Me.TxtFillColor.Text = "Red"
        Me.TxtFillColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(175, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Trong suốt:"
        '
        'TxtLineColor
        '
        Me.TxtLineColor.AutoCompleteCustomSource.AddRange(New String() {"100", "200", "300", "400", "500", "600", "700", "800", "900", "1000", "1100", "1200", "1300", "1400", "1500"})
        Me.TxtLineColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtLineColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtLineColor.BackColor = System.Drawing.Color.Yellow
        Me.TxtLineColor.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtLineColor.Location = New System.Drawing.Point(92, 112)
        Me.TxtLineColor.Name = "TxtLineColor"
        Me.TxtLineColor.Size = New System.Drawing.Size(77, 25)
        Me.TxtLineColor.TabIndex = 4
        Me.TxtLineColor.Tag = ""
        Me.TxtLineColor.Text = "Yellow"
        Me.TxtLineColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(311, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(311, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Tầm nhìn mặc định:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(278, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Km"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Kích thước (tỷ lệ):"
        '
        'PageSign
        '
        Me.PageSign.Controls.Add(Me.GrSignlist)
        Me.PageSign.Controls.Add(Me.GrSign)
        Me.PageSign.Location = New System.Drawing.Point(4, 26)
        Me.PageSign.Name = "PageSign"
        Me.PageSign.Padding = New System.Windows.Forms.Padding(3)
        Me.PageSign.Size = New System.Drawing.Size(390, 743)
        Me.PageSign.TabIndex = 2
        Me.PageSign.Text = "Ký hiệu"
        Me.PageSign.UseVisualStyleBackColor = True
        '
        'GrSignlist
        '
        Me.GrSignlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrSignlist.Controls.Add(Me.LvSign)
        Me.GrSignlist.Controls.Add(Me.cbSignGroup)
        Me.GrSignlist.Controls.Add(Me.TxtFind)
        Me.GrSignlist.Enabled = False
        Me.GrSignlist.Location = New System.Drawing.Point(6, 235)
        Me.GrSignlist.Name = "GrSignlist"
        Me.GrSignlist.Size = New System.Drawing.Size(378, 502)
        Me.GrSignlist.TabIndex = 62
        Me.GrSignlist.TabStop = False
        Me.GrSignlist.Text = "Danh sách ký hiệu"
        '
        'LvSign
        '
        Me.LvSign.AllowDrop = True
        Me.LvSign.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvSign.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvSign.FullRowSelect = True
        ListViewGroup1.Header = "Sở chỉ huy"
        ListViewGroup1.Name = "SCH_"
        ListViewGroup2.Header = "Hành động tác chiến"
        ListViewGroup2.Name = "HDTC_"
        ListViewGroup3.Header = "Công binh"
        ListViewGroup3.Name = "CB_"
        ListViewGroup4.Header = "Đặc công"
        ListViewGroup4.Name = "DC_"
        ListViewGroup5.Header = "Hậu cần - Kỹ thuật"
        ListViewGroup5.Name = "HCKT_"
        ListViewGroup6.Header = "Hải quân"
        ListViewGroup6.Name = "HQ_"
        ListViewGroup7.Header = "Địa phương"
        ListViewGroup7.Name = "LLVTDP_"
        ListViewGroup8.Header = "Pháo binh"
        ListViewGroup8.Name = "PB_"
        ListViewGroup9.Header = "Phòng không - không quân"
        ListViewGroup9.Name = "PKKQ_"
        ListViewGroup10.Header = "Quân báo - trinh sát"
        ListViewGroup10.Name = "QBTS_"
        ListViewGroup11.Header = "Tác chiến điện tử"
        ListViewGroup11.Name = "TCDT_"
        ListViewGroup12.Header = "Thông tin"
        ListViewGroup12.Name = "TT_"
        ListViewGroup13.Header = "Tăng thiết giáp"
        ListViewGroup13.Name = "TTG_"
        ListViewGroup14.Header = "Ký hiệu khác"
        ListViewGroup14.Name = "K_"
        Me.LvSign.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4, ListViewGroup5, ListViewGroup6, ListViewGroup7, ListViewGroup8, ListViewGroup9, ListViewGroup10, ListViewGroup11, ListViewGroup12, ListViewGroup13, ListViewGroup14})
        Me.LvSign.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LvSign.HideSelection = False
        Me.LvSign.LargeImageList = Me.ImgLarge
        Me.LvSign.Location = New System.Drawing.Point(6, 57)
        Me.LvSign.MultiSelect = False
        Me.LvSign.Name = "LvSign"
        Me.LvSign.ShowItemToolTips = True
        Me.LvSign.Size = New System.Drawing.Size(366, 439)
        Me.LvSign.SmallImageList = Me.ImgSmall
        Me.LvSign.TabIndex = 2
        Me.LvSign.UseCompatibleStateImageBehavior = False
        '
        'ImgLarge
        '
        Me.ImgLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.ImgLarge.ImageSize = New System.Drawing.Size(48, 48)
        Me.ImgLarge.TransparentColor = System.Drawing.Color.Transparent
        '
        'cbSignGroup
        '
        Me.cbSignGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSignGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSignGroup.Location = New System.Drawing.Point(249, 24)
        Me.cbSignGroup.Name = "cbSignGroup"
        Me.cbSignGroup.Size = New System.Drawing.Size(122, 25)
        Me.cbSignGroup.TabIndex = 1
        '
        'TxtFind
        '
        Me.TxtFind.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFind.Location = New System.Drawing.Point(3, 24)
        Me.TxtFind.Name = "TxtFind"
        Me.TxtFind.Size = New System.Drawing.Size(240, 25)
        Me.TxtFind.TabIndex = 0
        Me.TxtFind.Tag = "False"
        '
        'GrSign
        '
        Me.GrSign.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrSign.Controls.Add(Me.TxtColor6)
        Me.GrSign.Controls.Add(Me.RdKhac)
        Me.GrSign.Controls.Add(Me.CkCap)
        Me.GrSign.Controls.Add(Me.CmdAddSign)
        Me.GrSign.Controls.Add(Me.Label16)
        Me.GrSign.Controls.Add(Me.TxSignName)
        Me.GrSign.Controls.Add(Me.TxMainColor)
        Me.GrSign.Controls.Add(Me.Label15)
        Me.GrSign.Controls.Add(Me.CmdSaveSign)
        Me.GrSign.Controls.Add(Me.NrFont)
        Me.GrSign.Controls.Add(Me.Label14)
        Me.GrSign.Controls.Add(Me.LbSignCap)
        Me.GrSign.Controls.Add(Me.PicPivot)
        Me.GrSign.Controls.Add(Me.TxtColor4)
        Me.GrSign.Controls.Add(Me.TxtColor3)
        Me.GrSign.Controls.Add(Me.TxtColor2)
        Me.GrSign.Controls.Add(Me.TxtColor1)
        Me.GrSign.Controls.Add(Me.Label13)
        Me.GrSign.Controls.Add(Me.Ck2D)
        Me.GrSign.Controls.Add(Me.RdDich)
        Me.GrSign.Controls.Add(Me.RdTa)
        Me.GrSign.Controls.Add(Me.CkFlip)
        Me.GrSign.Controls.Add(Me.CbSignScale)
        Me.GrSign.Controls.Add(Me.Label12)
        Me.GrSign.Controls.Add(Me.TxtColor5)
        Me.GrSign.Controls.Add(Me.PicSign)
        Me.GrSign.Controls.Add(Me.TxSignCap)
        Me.GrSign.Enabled = False
        Me.GrSign.Location = New System.Drawing.Point(6, 6)
        Me.GrSign.Name = "GrSign"
        Me.GrSign.Size = New System.Drawing.Size(378, 223)
        Me.GrSign.TabIndex = 0
        Me.GrSign.TabStop = False
        Me.GrSign.Text = "Biên tập ký hiệu"
        '
        'TxtColor6
        '
        Me.TxtColor6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.TxtColor6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtColor6.Location = New System.Drawing.Point(338, 86)
        Me.TxtColor6.Name = "TxtColor6"
        Me.TxtColor6.ReadOnly = True
        Me.TxtColor6.Size = New System.Drawing.Size(25, 25)
        Me.TxtColor6.TabIndex = 9
        Me.TxtColor6.Tag = "False"
        '
        'RdKhac
        '
        Me.RdKhac.AutoSize = True
        Me.RdKhac.Location = New System.Drawing.Point(263, 58)
        Me.RdKhac.Name = "RdKhac"
        Me.RdKhac.Size = New System.Drawing.Size(55, 21)
        Me.RdKhac.TabIndex = 3
        Me.RdKhac.Text = "Khác"
        Me.RdKhac.UseVisualStyleBackColor = True
        '
        'CkCap
        '
        Me.CkCap.AutoSize = True
        Me.CkCap.Checked = True
        Me.CkCap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CkCap.Location = New System.Drawing.Point(81, 126)
        Me.CkCap.Name = "CkCap"
        Me.CkCap.Size = New System.Drawing.Size(15, 14)
        Me.CkCap.TabIndex = 11
        Me.CkCap.UseVisualStyleBackColor = True
        '
        'CmdAddSign
        '
        Me.CmdAddSign.Image = CType(resources.GetObject("CmdAddSign.Image"), System.Drawing.Image)
        Me.CmdAddSign.Location = New System.Drawing.Point(6, 184)
        Me.CmdAddSign.Name = "CmdAddSign"
        Me.CmdAddSign.Size = New System.Drawing.Size(90, 27)
        Me.CmdAddSign.TabIndex = 17
        Me.CmdAddSign.Text = "Thêm"
        Me.CmdAddSign.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAddSign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdAddSign.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(102, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 17)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Tên ký hiệu:"
        '
        'TxSignName
        '
        Me.TxSignName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxSignName.Location = New System.Drawing.Point(183, 24)
        Me.TxSignName.Name = "TxSignName"
        Me.TxSignName.Size = New System.Drawing.Size(180, 25)
        Me.TxSignName.TabIndex = 0
        Me.TxSignName.Tag = "False"
        '
        'TxMainColor
        '
        Me.TxMainColor.BackColor = System.Drawing.Color.Red
        Me.TxMainColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxMainColor.Location = New System.Drawing.Point(338, 56)
        Me.TxMainColor.Name = "TxMainColor"
        Me.TxMainColor.ReadOnly = True
        Me.TxMainColor.Size = New System.Drawing.Size(25, 25)
        Me.TxMainColor.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(102, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 17)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Màu chính:"
        '
        'CmdSaveSign
        '
        Me.CmdSaveSign.Enabled = False
        Me.CmdSaveSign.Image = CType(resources.GetObject("CmdSaveSign.Image"), System.Drawing.Image)
        Me.CmdSaveSign.Location = New System.Drawing.Point(6, 151)
        Me.CmdSaveSign.Name = "CmdSaveSign"
        Me.CmdSaveSign.Size = New System.Drawing.Size(90, 27)
        Me.CmdSaveSign.TabIndex = 14
        Me.CmdSaveSign.Text = "Lưu"
        Me.CmdSaveSign.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdSaveSign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdSaveSign.UseVisualStyleBackColor = True
        '
        'NrFont
        '
        Me.NrFont.Location = New System.Drawing.Point(170, 121)
        Me.NrFont.Minimum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.NrFont.Name = "NrFont"
        Me.NrFont.Size = New System.Drawing.Size(46, 25)
        Me.NrFont.TabIndex = 12
        Me.NrFont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NrFont.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(107, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Cỡ chữ:"
        '
        'LbSignCap
        '
        Me.LbSignCap.AutoSize = True
        Me.LbSignCap.Font = New System.Drawing.Font("UTM HelvetIns", 20.0!)
        Me.LbSignCap.Location = New System.Drawing.Point(30, 41)
        Me.LbSignCap.Name = "LbSignCap"
        Me.LbSignCap.Size = New System.Drawing.Size(45, 40)
        Me.LbSignCap.TabIndex = 69
        Me.LbSignCap.Text = "97"
        Me.LbSignCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LbSignCap.Visible = False
        '
        'PicPivot
        '
        Me.PicPivot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicPivot.Image = CType(resources.GetObject("PicPivot.Image"), System.Drawing.Image)
        Me.PicPivot.Location = New System.Drawing.Point(303, 154)
        Me.PicPivot.Name = "PicPivot"
        Me.PicPivot.Size = New System.Drawing.Size(60, 60)
        Me.PicPivot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicPivot.TabIndex = 67
        Me.PicPivot.TabStop = False
        '
        'TxtColor4
        '
        Me.TxtColor4.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtColor4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtColor4.Location = New System.Drawing.Point(276, 86)
        Me.TxtColor4.Name = "TxtColor4"
        Me.TxtColor4.ReadOnly = True
        Me.TxtColor4.Size = New System.Drawing.Size(25, 25)
        Me.TxtColor4.TabIndex = 8
        '
        'TxtColor3
        '
        Me.TxtColor3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtColor3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtColor3.Location = New System.Drawing.Point(245, 86)
        Me.TxtColor3.Name = "TxtColor3"
        Me.TxtColor3.ReadOnly = True
        Me.TxtColor3.Size = New System.Drawing.Size(25, 25)
        Me.TxtColor3.TabIndex = 7
        '
        'TxtColor2
        '
        Me.TxtColor2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtColor2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtColor2.Location = New System.Drawing.Point(214, 86)
        Me.TxtColor2.Name = "TxtColor2"
        Me.TxtColor2.ReadOnly = True
        Me.TxtColor2.Size = New System.Drawing.Size(25, 25)
        Me.TxtColor2.TabIndex = 6
        '
        'TxtColor1
        '
        Me.TxtColor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtColor1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtColor1.Location = New System.Drawing.Point(183, 86)
        Me.TxtColor1.Name = "TxtColor1"
        Me.TxtColor1.ReadOnly = True
        Me.TxtColor1.Size = New System.Drawing.Size(25, 25)
        Me.TxtColor1.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(102, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Màu đệm:"
        '
        'Ck2D
        '
        Me.Ck2D.AutoSize = True
        Me.Ck2D.Location = New System.Drawing.Point(204, 155)
        Me.Ck2D.Name = "Ck2D"
        Me.Ck2D.Size = New System.Drawing.Size(43, 21)
        Me.Ck2D.TabIndex = 16
        Me.Ck2D.Text = "2D"
        Me.Ck2D.UseVisualStyleBackColor = True
        '
        'RdDich
        '
        Me.RdDich.AutoSize = True
        Me.RdDich.Location = New System.Drawing.Point(214, 58)
        Me.RdDich.Name = "RdDich"
        Me.RdDich.Size = New System.Drawing.Size(52, 21)
        Me.RdDich.TabIndex = 2
        Me.RdDich.Text = "Địch"
        Me.RdDich.UseVisualStyleBackColor = True
        '
        'RdTa
        '
        Me.RdTa.AutoSize = True
        Me.RdTa.Checked = True
        Me.RdTa.Location = New System.Drawing.Point(177, 58)
        Me.RdTa.Name = "RdTa"
        Me.RdTa.Size = New System.Drawing.Size(39, 21)
        Me.RdTa.TabIndex = 1
        Me.RdTa.TabStop = True
        Me.RdTa.Text = "Ta"
        Me.RdTa.UseVisualStyleBackColor = True
        '
        'CkFlip
        '
        Me.CkFlip.AutoSize = True
        Me.CkFlip.Location = New System.Drawing.Point(107, 155)
        Me.CkFlip.Name = "CkFlip"
        Me.CkFlip.Size = New System.Drawing.Size(91, 21)
        Me.CkFlip.TabIndex = 15
        Me.CkFlip.Text = "Đổi hướng"
        Me.CkFlip.UseVisualStyleBackColor = True
        '
        'CbSignScale
        '
        Me.CbSignScale.DisplayMember = "0"
        Me.CbSignScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSignScale.Items.AddRange(New Object() {"1/250.000", "1/100.000", "1/50.000", "1/25.000", "1/10.000", "1/5.000", "1/1000"})
        Me.CbSignScale.Location = New System.Drawing.Point(148, 186)
        Me.CbSignScale.Name = "CbSignScale"
        Me.CbSignScale.Size = New System.Drawing.Size(118, 25)
        Me.CbSignScale.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(104, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Tỷ lệ:"
        '
        'TxtColor5
        '
        Me.TxtColor5.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TxtColor5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtColor5.Location = New System.Drawing.Point(307, 86)
        Me.TxtColor5.Name = "TxtColor5"
        Me.TxtColor5.ReadOnly = True
        Me.TxtColor5.Size = New System.Drawing.Size(25, 25)
        Me.TxtColor5.TabIndex = 29
        Me.TxtColor5.Tag = "False"
        '
        'PicSign
        '
        Me.PicSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicSign.ErrorImage = CType(resources.GetObject("PicSign.ErrorImage"), System.Drawing.Image)
        Me.PicSign.Image = CType(resources.GetObject("PicSign.Image"), System.Drawing.Image)
        Me.PicSign.Location = New System.Drawing.Point(6, 24)
        Me.PicSign.Name = "PicSign"
        Me.PicSign.Size = New System.Drawing.Size(90, 90)
        Me.PicSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicSign.TabIndex = 42
        Me.PicSign.TabStop = False
        '
        'TxSignCap
        '
        Me.TxSignCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxSignCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxSignCap.Location = New System.Drawing.Point(7, 121)
        Me.TxSignCap.Name = "TxSignCap"
        Me.TxSignCap.Size = New System.Drawing.Size(68, 25)
        Me.TxSignCap.TabIndex = 10
        Me.TxSignCap.Tag = "False"
        Me.TxSignCap.Text = "97"
        Me.TxSignCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PageData
        '
        Me.PageData.Controls.Add(Me.SourceToolStrip)
        Me.PageData.Controls.Add(Me.LvFile)
        Me.PageData.Controls.Add(Me.GroupBox1)
        Me.PageData.Location = New System.Drawing.Point(4, 26)
        Me.PageData.Name = "PageData"
        Me.PageData.Padding = New System.Windows.Forms.Padding(3)
        Me.PageData.Size = New System.Drawing.Size(390, 743)
        Me.PageData.TabIndex = 2
        Me.PageData.Text = "Dữ liệu"
        Me.PageData.UseVisualStyleBackColor = True
        '
        'SourceToolStrip
        '
        Me.SourceToolStrip.Enabled = False
        Me.SourceToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.SourceToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnFileCheck, Me.BtnFileFix})
        Me.SourceToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.SourceToolStrip.Name = "SourceToolStrip"
        Me.SourceToolStrip.Padding = New System.Windows.Forms.Padding(3)
        Me.SourceToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SourceToolStrip.Size = New System.Drawing.Size(384, 37)
        Me.SourceToolStrip.TabIndex = 0
        Me.SourceToolStrip.Text = "ToolStrip1"
        '
        'BtnFileCheck
        '
        Me.BtnFileCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFileCheck.Image = CType(resources.GetObject("BtnFileCheck.Image"), System.Drawing.Image)
        Me.BtnFileCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFileCheck.Name = "BtnFileCheck"
        Me.BtnFileCheck.Size = New System.Drawing.Size(28, 28)
        Me.BtnFileCheck.Text = "Checking files"
        Me.BtnFileCheck.ToolTipText = "Kiểm tra tập tin nguồn"
        '
        'BtnFileFix
        '
        Me.BtnFileFix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFileFix.Image = CType(resources.GetObject("BtnFileFix.Image"), System.Drawing.Image)
        Me.BtnFileFix.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFileFix.Name = "BtnFileFix"
        Me.BtnFileFix.Size = New System.Drawing.Size(28, 28)
        Me.BtnFileFix.Text = "Fixing files"
        Me.BtnFileFix.ToolTipText = "Tìm sửa tập tin nguồn"
        '
        'LvFile
        '
        Me.LvFile.AllowDrop = True
        Me.LvFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.LvFile.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvFile.FullRowSelect = True
        Me.LvFile.HideSelection = False
        Me.LvFile.LabelWrap = False
        Me.LvFile.Location = New System.Drawing.Point(6, 43)
        Me.LvFile.MultiSelect = False
        Me.LvFile.Name = "LvFile"
        Me.LvFile.ShowGroups = False
        Me.LvFile.Size = New System.Drawing.Size(375, 482)
        Me.LvFile.SmallImageList = Me.ImgSmall
        Me.LvFile.TabIndex = 1
        Me.LvFile.UseCompatibleStateImageBehavior = False
        Me.LvFile.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "TT"
        Me.ColumnHeader8.Width = 36
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Tên đối tượng"
        Me.ColumnHeader9.Width = 95
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Tập tin"
        Me.ColumnHeader10.Width = 184
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LstSource)
        Me.GroupBox1.Controls.Add(Me.CmdAddSource)
        Me.GroupBox1.Controls.Add(Me.CmdDelSource)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(3, 531)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thư mục nguồn"
        '
        'LstSource
        '
        Me.LstSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstSource.FormattingEnabled = True
        Me.LstSource.ItemHeight = 17
        Me.LstSource.Location = New System.Drawing.Point(10, 23)
        Me.LstSource.Name = "LstSource"
        Me.LstSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LstSource.Size = New System.Drawing.Size(275, 174)
        Me.LstSource.TabIndex = 0
        '
        'CmdAddSource
        '
        Me.CmdAddSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdAddSource.Image = CType(resources.GetObject("CmdAddSource.Image"), System.Drawing.Image)
        Me.CmdAddSource.Location = New System.Drawing.Point(297, 24)
        Me.CmdAddSource.Name = "CmdAddSource"
        Me.CmdAddSource.Size = New System.Drawing.Size(81, 27)
        Me.CmdAddSource.TabIndex = 1
        Me.CmdAddSource.Text = "Thêm"
        Me.CmdAddSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAddSource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdAddSource.UseVisualStyleBackColor = True
        '
        'CmdDelSource
        '
        Me.CmdDelSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdDelSource.Image = CType(resources.GetObject("CmdDelSource.Image"), System.Drawing.Image)
        Me.CmdDelSource.Location = New System.Drawing.Point(297, 57)
        Me.CmdDelSource.Name = "CmdDelSource"
        Me.CmdDelSource.Size = New System.Drawing.Size(81, 27)
        Me.CmdDelSource.TabIndex = 2
        Me.CmdDelSource.Text = "Xóa"
        Me.CmdDelSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdDelSource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdDelSource.UseVisualStyleBackColor = True
        '
        'MapToolStrip
        '
        Me.MapToolStrip.Enabled = False
        Me.MapToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MapToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPan, Me.BtnSelect, Me.BtnSelectArea, Me.ToolStripSeparator7, Me.BtnCopy, Me.BtnCut, Me.BtnPaste, Me.BtnDel, Me.ToolStripSeparator13, Me.BtnDistance, Me.BtnArea, Me.BtnHeight, Me.ToolStripSeparator8, Me.BtnNavigate, Me.BtnShadow, Me.BtnTimeSlider, Me.BtnOcean, Me.BtnCapture, Me.BtnOption})
        Me.MapToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.MapToolStrip.Name = "MapToolStrip"
        Me.MapToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MapToolStrip.Size = New System.Drawing.Size(1093, 31)
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
        Me.BtnPan.ToolTipText = "Kéo dịch chuyển bản đồ"
        '
        'BtnSelect
        '
        Me.BtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(28, 28)
        Me.BtnSelect.Tag = "True"
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.ToolTipText = "Chọn và chỉnh sửa đối tượng"
        '
        'BtnSelectArea
        '
        Me.BtnSelectArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSelectArea.Image = CType(resources.GetObject("BtnSelectArea.Image"), System.Drawing.Image)
        Me.BtnSelectArea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSelectArea.Name = "BtnSelectArea"
        Me.BtnSelectArea.Size = New System.Drawing.Size(28, 28)
        Me.BtnSelectArea.Tag = "False"
        Me.BtnSelectArea.Text = "Select Area"
        Me.BtnSelectArea.ToolTipText = "Chọn vùng đối tượng"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 31)
        '
        'BtnCopy
        '
        Me.BtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
        Me.BtnDel.Image = CType(resources.GetObject("BtnDel.Image"), System.Drawing.Image)
        Me.BtnDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(28, 28)
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.ToolTipText = "Xóa đối tượng"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 31)
        '
        'BtnDistance
        '
        Me.BtnDistance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDistance.Image = CType(resources.GetObject("BtnDistance.Image"), System.Drawing.Image)
        Me.BtnDistance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDistance.Name = "BtnDistance"
        Me.BtnDistance.Size = New System.Drawing.Size(28, 28)
        Me.BtnDistance.Text = "Measure Distance"
        Me.BtnDistance.ToolTipText = "Đo khoảng cách"
        '
        'BtnArea
        '
        Me.BtnArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnArea.Image = CType(resources.GetObject("BtnArea.Image"), System.Drawing.Image)
        Me.BtnArea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnArea.Name = "BtnArea"
        Me.BtnArea.Size = New System.Drawing.Size(28, 28)
        Me.BtnArea.Text = "Measure Area"
        Me.BtnArea.ToolTipText = "Đo diện tích"
        '
        'BtnHeight
        '
        Me.BtnHeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnHeight.Image = CType(resources.GetObject("BtnHeight.Image"), System.Drawing.Image)
        Me.BtnHeight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHeight.Name = "BtnHeight"
        Me.BtnHeight.Size = New System.Drawing.Size(28, 28)
        Me.BtnHeight.Text = "Measure Height"
        Me.BtnHeight.ToolTipText = "Đo độ cao"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
        '
        'BtnNavigate
        '
        Me.BtnNavigate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNavigate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnNavigate})
        Me.BtnNavigate.Image = CType(resources.GetObject("BtnNavigate.Image"), System.Drawing.Image)
        Me.BtnNavigate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNavigate.Name = "BtnNavigate"
        Me.BtnNavigate.Size = New System.Drawing.Size(40, 28)
        Me.BtnNavigate.Text = "Navigator"
        Me.BtnNavigate.ToolTipText = "La bàn chỉnh hướng"
        '
        'MnNavigate
        '
        Me.MnNavigate.Name = "MnNavigate"
        Me.MnNavigate.Size = New System.Drawing.Size(182, 22)
        Me.MnNavigate.Text = "Điều khiển nâng cao"
        '
        'BtnShadow
        '
        Me.BtnShadow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnShadow.Image = CType(resources.GetObject("BtnShadow.Image"), System.Drawing.Image)
        Me.BtnShadow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnShadow.Name = "BtnShadow"
        Me.BtnShadow.Size = New System.Drawing.Size(28, 28)
        Me.BtnShadow.Text = "Shadow"
        Me.BtnShadow.ToolTipText = "Đổ bóng"
        '
        'BtnTimeSlider
        '
        Me.BtnTimeSlider.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnTimeSlider.Image = CType(resources.GetObject("BtnTimeSlider.Image"), System.Drawing.Image)
        Me.BtnTimeSlider.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnTimeSlider.Name = "BtnTimeSlider"
        Me.BtnTimeSlider.Size = New System.Drawing.Size(28, 28)
        Me.BtnTimeSlider.Text = "Day light slider"
        Me.BtnTimeSlider.ToolTipText = "Thanh ngày đêm"
        '
        'BtnOcean
        '
        Me.BtnOcean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnOcean.Image = CType(resources.GetObject("BtnOcean.Image"), System.Drawing.Image)
        Me.BtnOcean.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOcean.Name = "BtnOcean"
        Me.BtnOcean.Size = New System.Drawing.Size(28, 28)
        Me.BtnOcean.Text = "Oceans toggle"
        Me.BtnOcean.ToolTipText = "Hoạt họa đại dương"
        '
        'BtnCapture
        '
        Me.BtnCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCapture.Image = CType(resources.GetObject("BtnCapture.Image"), System.Drawing.Image)
        Me.BtnCapture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCapture.Name = "BtnCapture"
        Me.BtnCapture.Size = New System.Drawing.Size(28, 28)
        Me.BtnCapture.Text = "Save image..."
        Me.BtnCapture.ToolTipText = "Lưu ảnh..."
        '
        'BtnOption
        '
        Me.BtnOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnOption.Image = CType(resources.GetObject("BtnOption.Image"), System.Drawing.Image)
        Me.BtnOption.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(28, 28)
        Me.BtnOption.Text = "Project option"
        Me.BtnOption.ToolTipText = "Thiết đặt bản đồ"
        '
        'TmrPresWait
        '
        Me.TmrPresWait.Interval = 1000
        '
        'DlgFolder
        '
        Me.DlgFolder.Description = "Chọn thư mục để thêm vào danh sách Nguồn dữ liệu:"
        '
        'BwCheckfile
        '
        Me.BwCheckfile.WorkerReportsProgress = True
        Me.BwCheckfile.WorkerSupportsCancellation = True
        '
        'BwFixFile
        '
        Me.BwFixFile.WorkerReportsProgress = True
        Me.BwFixFile.WorkerSupportsCancellation = True
        '
        'BwHighlight
        '
        Me.BwHighlight.WorkerSupportsCancellation = True
        '
        'BwLoadSign
        '
        Me.BwLoadSign.WorkerReportsProgress = True
        Me.BwLoadSign.WorkerSupportsCancellation = True
        '
        'BwEdit
        '
        Me.BwEdit.WorkerReportsProgress = True
        Me.BwEdit.WorkerSupportsCancellation = True
        '
        'ImgPivot
        '
        Me.ImgPivot.ImageStream = CType(resources.GetObject("ImgPivot.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgPivot.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgPivot.Images.SetKeyName(0, "arrow_bottomright.png")
        Me.ImgPivot.Images.SetKeyName(1, "arrow_down.png")
        Me.ImgPivot.Images.SetKeyName(2, "arrow_bottomleft.png")
        Me.ImgPivot.Images.SetKeyName(3, "arrow_left.png")
        Me.ImgPivot.Images.SetKeyName(4, "arrow_topleft.png")
        Me.ImgPivot.Images.SetKeyName(5, "arrow_Up.png")
        Me.ImgPivot.Images.SetKeyName(6, "arrow_topright.png")
        Me.ImgPivot.Images.SetKeyName(7, "arrow_right.png")
        Me.ImgPivot.Images.SetKeyName(8, "arrow_out.png")
        '
        'TmrLicense
        '
        Me.TmrLicense.Interval = 1000
        Me.TmrLicense.Tag = "600"
        '
        'TmrHighlight
        '
        Me.TmrHighlight.Interval = 600
        Me.TmrHighlight.Tag = ""
        '
        'ImgStep
        '
        Me.ImgStep.ImageStream = CType(resources.GetObject("ImgStep.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgStep.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgStep.Images.SetKeyName(0, "Location")
        '
        'TmrFollow
        '
        Me.TmrFollow.Interval = 20
        Me.TmrFollow.Tag = ""
        '
        'TmrControl
        '
        Me.TmrControl.Interval = 20
        Me.TmrControl.Tag = ""
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 869)
        Me.Controls.Add(Me.MainSpliter)
        Me.Controls.Add(Me.TxtEvent)
        Me.Controls.Add(Me.MainToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1200, 800)
        Me.Name = "FrmMain"
        Me.Text = "Military 3D Map"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.MainSpliter.Panel1.ResumeLayout(False)
        Me.MainSpliter.Panel2.ResumeLayout(False)
        Me.MainSpliter.Panel2.PerformLayout()
        CType(Me.MainSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSpliter.ResumeLayout(False)
        Me.TabMain.ResumeLayout(False)
        Me.PageTree.ResumeLayout(False)
        Me.PageTree.PerformLayout()
        CType(Me.MapTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TreeToolStrip.ResumeLayout(False)
        Me.TreeToolStrip.PerformLayout()
        Me.MapSplitter.Panel1.ResumeLayout(False)
        Me.MapSplitter.Panel2.ResumeLayout(False)
        CType(Me.MapSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MapSplitter.ResumeLayout(False)
        Me.SplSubMap.Panel1.ResumeLayout(False)
        Me.SplSubMap.Panel1.PerformLayout()
        Me.SplSubMap.Panel2.ResumeLayout(False)
        CType(Me.SplSubMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplSubMap.ResumeLayout(False)
        CType(Me.MapView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControls.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.GrObject.ResumeLayout(False)
        Me.GrControl.ResumeLayout(False)
        Me.GrControl.PerformLayout()
        CType(Me.tbrRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrCoor.ResumeLayout(False)
        Me.GrCoor.PerformLayout()
        Me.TabInfo.ResumeLayout(False)
        Me.TabTool.ResumeLayout(False)
        Me.PagePres.ResumeLayout(False)
        Me.GrEffect.ResumeLayout(False)
        Me.HLTool.ResumeLayout(False)
        Me.HLTool.PerformLayout()
        Me.PresTool.ResumeLayout(False)
        Me.PresTool.PerformLayout()
        Me.PageEdit.ResumeLayout(False)
        Me.PageEdit.PerformLayout()
        Me.GrNote.ResumeLayout(False)
        Me.GrNote.PerformLayout()
        Me.GrEdit.ResumeLayout(False)
        Me.GrEdit.PerformLayout()
        CType(Me.NrMaxView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NrMinView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NrLinewid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NrFillOpa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NrLineOpa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NrDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NrScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageSign.ResumeLayout(False)
        Me.GrSignlist.ResumeLayout(False)
        Me.GrSignlist.PerformLayout()
        Me.GrSign.ResumeLayout(False)
        Me.GrSign.PerformLayout()
        CType(Me.NrFont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPivot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageData.ResumeLayout(False)
        Me.PageData.PerformLayout()
        Me.SourceToolStrip.ResumeLayout(False)
        Me.SourceToolStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.MapToolStrip.ResumeLayout(False)
        Me.MapToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents DlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SttBar As System.Windows.Forms.ToolStripStatusLabel
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
    Friend WithEvents BtnLink As ToolStripButton
    Friend WithEvents BtnUnlink As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents BtnFollow As ToolStripButton
    Friend WithEvents BtnReload As ToolStripButton
    Friend WithEvents BtnOpen As ToolStripSplitButton
    Friend WithEvents MnRecent As ToolStripMenuItem
    Friend WithEvents DlgSave As SaveFileDialog
    Friend WithEvents DlgColor As ColorDialog
    Friend WithEvents TxtEvent As TextBox
    Friend WithEvents TmrFocus As Timer
    Friend WithEvents MainSpliter As SplitContainer
    Friend WithEvents LvSteps As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents PresTool As ToolStrip
    Friend WithEvents BtnPrivous As ToolStripButton
    Friend WithEvents BtnPlay As ToolStripButton
    Friend WithEvents BtnStep As ToolStripButton
    Friend WithEvents BtnPause As ToolStripButton
    Friend WithEvents BtnNext As ToolStripButton
    Friend WithEvents BtnStop As ToolStripButton
    Friend WithEvents MapToolStrip As ToolStrip
    Friend WithEvents BtnPan As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents BtnSelect As ToolStripButton
    Friend WithEvents BtnCopy As ToolStripButton
    Friend WithEvents BtnCut As ToolStripButton
    Friend WithEvents BtnPaste As ToolStripButton
    Friend WithEvents BtnDistance As ToolStripButton
    Friend WithEvents BtnHeight As ToolStripButton
    Friend WithEvents BtnArea As ToolStripButton
    Friend WithEvents BtnCapture As ToolStripButton
    Friend WithEvents BtnOcean As ToolStripButton
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents CmbEdit As ComboBox
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents TmrPresWait As Timer
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents BtnSelectArea As ToolStripButton
    Friend WithEvents BtnTimeSlider As ToolStripButton
    Friend WithEvents MapSplitter As SplitContainer
    Friend WithEvents TabTool As TabControl
    Friend WithEvents PagePres As TabPage
    Friend WithEvents TabMain As TabControl
    Friend WithEvents PageTree As TabPage
    Friend WithEvents MapTree As AxTerraExplorerX.AxTEInformationWindowEx
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CmdOpen As Button
    Friend WithEvents TxtFilename As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmdApply As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TreeToolStrip As ToolStrip
    Friend WithEvents LbPres As Label
    Friend WithEvents PageData As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmdAddSource As Button
    Friend WithEvents CmdDelSource As Button
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BtnAddPresLocation As ToolStripButton
    Friend WithEvents BtnUpdatePreslocation As ToolStripButton
    Friend WithEvents BtnDelPres As ToolStripButton
    Friend WithEvents BtnRepres As ToolStripButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtFillColor As TextBox
    Friend WithEvents TxtLineColor As TextBox
    Friend WithEvents PrgBar As ToolStripProgressBar
    Friend WithEvents SourceToolStrip As ToolStrip
    Friend WithEvents BtnFileCheck As ToolStripButton
    Friend WithEvents LvFile As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents BtnDel As ToolStripButton
    Friend WithEvents LstSource As ListBox
    Friend WithEvents DlgFolder As FolderBrowserDialog
    Friend WithEvents BtnFileFix As ToolStripButton
    Friend WithEvents BwCheckfile As System.ComponentModel.BackgroundWorker
    Friend WithEvents ImgSmall As ImageList
    Friend WithEvents BwFixFile As System.ComponentModel.BackgroundWorker
    Friend WithEvents BwHighlight As System.ComponentModel.BackgroundWorker
    Friend WithEvents LvSign As ListView
    Friend WithEvents ImgLarge As ImageList
    Friend WithEvents TxtColor5 As TextBox
    Friend WithEvents TxtFind As TextBox
    Friend WithEvents PicSign As PictureBox
    Friend WithEvents BwLoadSign As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxSignCap As TextBox
    Friend WithEvents RdDich As RadioButton
    Friend WithEvents RdTa As RadioButton
    Friend WithEvents GrSign As GroupBox
    Friend WithEvents NrLinewid As NumericUpDown
    Friend WithEvents NrFillOpa As NumericUpDown
    Friend WithEvents NrLineOpa As NumericUpDown
    Friend WithEvents NrDis As NumericUpDown
    Friend WithEvents NrScale As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents CbSignScale As ComboBox
    Friend WithEvents CkFlip As CheckBox
    Friend WithEvents BwEdit As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbSignGroup As ComboBox
    Friend WithEvents Ck2D As CheckBox
    Friend WithEvents TxtColor1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtColor4 As TextBox
    Friend WithEvents TxtColor3 As TextBox
    Friend WithEvents TxtColor2 As TextBox
    Friend WithEvents PicPivot As PictureBox
    Friend WithEvents ImgPivot As ImageList
    Friend WithEvents LbSignCap As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents NrFont As NumericUpDown
    Friend WithEvents CmdSaveSign As Button
    Friend WithEvents GrSignlist As GroupBox
    Friend WithEvents TxMainColor As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxSignName As TextBox
    Friend WithEvents CmdAddSign As Button
    Friend WithEvents PageSign As TabPage
    Friend WithEvents CkCap As CheckBox
    Friend WithEvents RdKhac As RadioButton
    Friend WithEvents TxtColor6 As TextBox
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents BtnAddPres As ToolStripButton
    Friend WithEvents TmrLicense As Timer
    Friend WithEvents LicenseBar As ToolStripStatusLabel
    Friend WithEvents PageEdit As TabPage
    Friend WithEvents BtnShadow As ToolStripButton
    Friend WithEvents TmrHighlight As Timer
    Friend WithEvents BtnAddDmav As ToolStripButton
    Friend WithEvents BtnAddGroup As ToolStripSplitButton
    Friend WithEvents BtnExpandGroup As ToolStripMenuItem
    Friend WithEvents BtnUpdateGroup As ToolStripMenuItem
    Friend WithEvents BtnCleanGroup As ToolStripMenuItem
    Friend WithEvents BtnAddPoly As ToolStripSplitButton
    Friend WithEvents BtnAddRec As ToolStripMenuItem
    Friend WithEvents BtnAddCircle As ToolStripMenuItem
    Friend WithEvents BtnAddLine As ToolStripMenuItem
    Friend WithEvents BtnAddLayer As ToolStripSplitButton
    Friend WithEvents AddGroundObject As ToolStripMenuItem
    Friend WithEvents AddFlyObject As ToolStripMenuItem
    Friend WithEvents SplSubMap As SplitContainer
    Friend WithEvents LbPresState As Label
    Friend WithEvents MapView As AxTerraExplorerX.AxTE3DWindowEx
    Friend WithEvents AddStandObject As ToolStripMenuItem
    Friend WithEvents BtnStartHL As ToolStripButton
    Friend WithEvents TabControls As TabControl
    Friend WithEvents TabInfo As TabPage
    Friend WithEvents LvInfo As ListView
    Friend WithEvents cIcon As ColumnHeader
    Friend WithEvents cInfo As ColumnHeader
    Friend WithEvents TabControl As TabPage
    Friend WithEvents ImgStep As ImageList
    Friend WithEvents BtnNavigate As ToolStripSplitButton
    Friend WithEvents MnNavigate As ToolStripMenuItem
    Friend WithEvents BtnAddLabel As ToolStripSplitButton
    Friend WithEvents BtnAddImage As ToolStripMenuItem
    Friend WithEvents CmdRotateRight As Button
    Friend WithEvents CmdRotateLeft As Button
    Friend WithEvents TmrFollow As Timer
    Friend WithEvents GrControl As GroupBox
    Friend WithEvents BtnClose As ToolStripButton
    Friend WithEvents PicControl As PictureBox
    Friend WithEvents CmdDown As Button
    Friend WithEvents CmdUp As Button
    Friend WithEvents CmdStop As Button
    Friend WithEvents TmrControl As Timer
    Friend WithEvents CmdZoomIn As Button
    Friend WithEvents CmdZoomOut As Button
    Friend WithEvents CmdGo As Button
    Friend WithEvents GrEdit As GroupBox
    Friend WithEvents TxLabel As TextBox
    Friend WithEvents lbLabel As Label
    Friend WithEvents GrObject As GroupBox
    Friend WithEvents CmdStartHL As Button
    Friend WithEvents CmdStopHL As Button
    Friend WithEvents CmdHideNote2 As Button
    Friend WithEvents CmdShowNote2 As Button
    Friend WithEvents GrNote As GroupBox
    Friend WithEvents CmdHideNote As Button
    Friend WithEvents CmdSaveNote As Button
    Friend WithEvents cmdShowNote As Button
    Friend WithEvents TxNote As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents NrMaxView As NumericUpDown
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents NrMinView As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents CmdDelNote As Button
    Friend WithEvents HLTool As ToolStrip
    Friend WithEvents BtnAddPresHL2 As ToolStripButton
    Friend WithEvents BtnDelPresHL As ToolStripButton
    Friend WithEvents BtnStartPresHL As ToolStripButton
    Friend WithEvents GrEffect As GroupBox
    Friend WithEvents BtnAddPresHL As ToolStripButton
    Friend WithEvents BtnAddArrow As ToolStripMenuItem
    Friend WithEvents MnRemoveNote As ToolStripMenuItem
    Friend WithEvents BtnKeystep As ToolStripButton
    Friend WithEvents MnAddSmoke As ToolStripMenuItem
    Friend WithEvents MnSmoke1 As ToolStripMenuItem
    Friend WithEvents MnSmoke2 As ToolStripMenuItem
    Friend WithEvents MnSmoke3 As ToolStripMenuItem
    Friend WithEvents MnAddFire As ToolStripMenuItem
    Friend WithEvents MnFire1 As ToolStripMenuItem
    Friend WithEvents MnFire2 As ToolStripMenuItem
    Friend WithEvents MnFire3 As ToolStripMenuItem
    Friend WithEvents MnFire4 As ToolStripMenuItem
    Friend WithEvents MnFire5 As ToolStripMenuItem
    Friend WithEvents MnFire6 As ToolStripMenuItem
    Friend WithEvents MnFire7 As ToolStripMenuItem
    Friend WithEvents MnFire8 As ToolStripMenuItem
    Friend WithEvents MnSmoke4 As ToolStripMenuItem
    Friend WithEvents MnSmoke5 As ToolStripMenuItem
    Friend WithEvents MnSmoke6 As ToolStripMenuItem
    Friend WithEvents MnSmoke7 As ToolStripMenuItem
    Friend WithEvents MnAddExp As ToolStripMenuItem
    Friend WithEvents MnExp1 As ToolStripMenuItem
    Friend WithEvents MnExp2 As ToolStripMenuItem
    Friend WithEvents MnExp3 As ToolStripMenuItem
    Friend WithEvents BtnSetting As ToolStripButton
    Friend WithEvents BtnOption As ToolStripButton
    Friend WithEvents GrCoor As GroupBox
    Friend WithEvents CbCoor As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxY As TextBox
    Friend WithEvents TxX As TextBox
    Friend WithEvents LvHighlight As ListView
    Friend WithEvents cleName As ColumnHeader
    Friend WithEvents cleType As ColumnHeader
    Friend WithEvents btnReLoadEffect As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnStopHL As ToolStripButton
    Friend WithEvents BtnStopPresHL As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents cmbEffect As ComboBox
    Friend WithEvents tbrRate As TrackBar
    Friend WithEvents cmdStep As Button
    Friend WithEvents AddRaster As ToolStripMenuItem
    Friend WithEvents MnAddLocation As ToolStripMenuItem
    Friend WithEvents TxName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CbAltmed As ComboBox
    Friend WithEvents Label24 As Label
End Class
