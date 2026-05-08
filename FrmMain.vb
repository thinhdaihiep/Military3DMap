
Imports System.ComponentModel
Imports System.Diagnostics.Contracts
Imports System.IO
Imports System.Math
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.Threading
Imports Microsoft.VisualBasic.Devices
Imports TerraExplorerX
Imports Font = System.Drawing.Font

Public Class FrmMain

#Region "Main Application"

    Private Exitting As Boolean = False
    Private EndLicense As Boolean = False
    Private WinState As FormWindowState

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False 'Bo qua loi chen thread
        InitTerra()
        LoadRecent()
        LoadSource()
        LoadSigns()
        'Kiem tra ban quyen-------------
        'If CheckLicense() Then
        LicenseBar.Visible = False
        'Else
        '    TmrLicense.Enabled = True
        '    LicenseBar.Visible = True
        'End If
        If Year(Now) = 2021 Then SetStatus("Đã cập nhật năm hệ thống thành năm 2021!", IconType.Time)
    End Sub

    Private Sub SetStatus(mText As String, ByVal Optional mIcon As IconType = IconType.Info)
        On Error Resume Next
        If mIcon <> IconType.Wait Then
            Dim cItem As ListViewItem
            cItem = LvInfo.Items.Add("", mIcon)
            cItem.SubItems.Add(mText)
            cItem.EnsureVisible()
        End If
        If PrgBar.Visible Then Exit Sub
        SttBar.Text = mText
        SttBar.Image = ImgSmall.Images(mIcon)
    End Sub

    Private Sub LoadRecent()
        Try
            Dim cs As String
            Dim i As Integer = 0
            SetStatus("Nạp danh sách các file đã mở", IconType.Message)
            BtnOpen.DropDownItems.Clear()
            If My.Settings.Recent.Count = 0 Then
                BtnOpen.DropDownItems.Add("Chưa có file được mở")
            Else
                For Each cs In My.Settings.Recent
                    Dim cItem As New ToolStripMenuItem With {.Text = cs, .Name = "MnRecent" & i}
                    AddHandler cItem.Click, AddressOf MnRecent_Click
                    i += 1
                    BtnOpen.DropDownItems.Add(cItem)
                    If i = 9 Then Exit For
                Next
            End If
        Catch

        End Try

    End Sub

    Private Sub AddRecent(ByVal mFile As String)
        On Error Resume Next
        My.Settings.Recent.Remove(mFile)
        My.Settings.Recent.Insert(0, mFile)
        If My.Settings.Recent.Count = 10 Then My.Settings.Recent.RemoveAt(9)
        LoadRecent()
    End Sub

    Private Sub FrmMain_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then Exit Sub
        If Me.WindowState <> WinState Then
            ResizeMap()
            WinState = Me.WindowState
        End If
    End Sub

    Private Sub MainSpliter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles MainSpliter.SplitterMoved
        ResizeMap()
        'MainSpliter.ResumeLayout()
    End Sub

    Private Sub ResizeMap()
        On Error Resume Next
        SplSubMap.SplitterDistance = SplSubMap.Width * 9 \ 16
        MapView.Dock = DockStyle.Fill
        MapTree.Dock = DockStyle.Fill
        MapTree.Dock = DockStyle.None
        MapView.Dock = DockStyle.None
        LvInfo.Columns(1).Width = LvInfo.Width - 26
        LvHighlight.Columns(0).Width = LvHighlight.Width - 126
        If Not Exitting Then MapTree.AttachTo3dWindow(MapView.GetOcx)
    End Sub

    Private Sub SetParent(sCtr As Control, ByVal pCtr As Control, Optional ByVal SetTrans As Boolean = True)
        Dim Pos As Point = PointToScreen(sCtr.Location)
        Pos = pCtr.PointToClient(Pos)
        sCtr.Parent = pCtr
        sCtr.Location = Pos
        If SetTrans Then sCtr.BackColor = Color.Transparent
    End Sub

    Private Sub FrmMain_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        StopCamera()
    End Sub

    Private Sub FrmMain_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        ResizeMap()
    End Sub

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Exitting = True
            If CloseFile(EndLicense) = vbCancel Then
                Exitting = False
                e.Cancel = True
                Exit Sub
            End If
            Me.Visible = False
            FrmShow.Visible = False
            FrmShow.Close() 'Dong cua so trinh chieu
            CloseData() 'Dong du lieu
            RestoreTime() 'Khoi phuc thoi gian
        Catch
            RestoreTime()
            Application.Exit()
        End Try
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        BwCheckfile.CancelAsync()
        BwEdit.CancelAsync()
        BwFixFile.CancelAsync()
        BwHighlight.CancelAsync()
        BwLoadSign.CancelAsync()
    End Sub

    Private Sub TmrLicense_Tick(sender As Object, e As EventArgs) Handles TmrLicense.Tick

        Dim s As Integer = TmrLicense.Tag
        s -= 1
        LicenseBar.Text = "Thời hạn sử dụng: " & s \ 60 & ":" & s Mod 60
        If s < 1 Then
            TmrLicense.Enabled = False
            If CheckLicense() = False Then
                LicenseBar.Text = "Yêu cầu kích hoạt bản quyền !"
                FrmLicense.ShowDialog(Me)
                If CheckLicense() = False Then
                    EndLicense = True
                    Me.Close()
                End If
            End If
        End If
        TmrLicense.Tag = s
    End Sub

    Private Sub FrmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        On Error Resume Next
        Select Case e.KeyValue
            Case Keys.Escape
                Sw.ProjectTree.EnableRedraw(True)
                StopCamera(True)
                StopHighlight()
            Case Keys.F2

        End Select

    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub BtnAddPres_Click(sender As Object, e As EventArgs) Handles BtnAddPres.Click

        Try
            Dim nPres As IPresentation71
            Dim pID As String = CurrentGroup()
            Dim cPos As IPosition71 = Sw.Navigate.GetPosition
            nPres = Sw.Creator.CreatePresentation(pID, "Trình chiếu mới")
            nPres.CreateLocationStep(PresentationStepContinue.PSC_MOUSECLICK, 0, "Location", cPos)
            nPres.TreeItem.Name = "Trình chiếu - #" & nPres.ID
            LoadPres(nPres.ID)
            Sw.ProjectTree.ExpandGroup(pID, True)
        Catch

        End Try

    End Sub
    Private Function CurrentGroup() As String
        Dim pID As String = CurID
        Try
            If Not Sw.ProjectTree.IsGroup(pID) Or Sw.ProjectTree.IsLayer(pID) Then pID = Sw.ProjectTree.GetNextItem(pID, ItemCode.PARENT)
            Return pID
        Catch ex As Exception
            Return Sw.ProjectTree.RootID
        End Try
    End Function
    Private Sub BtnSetting_Click(sender As Object, e As EventArgs) Handles BtnSetting.Click
        Sw.Command.Execute(1011, 0)
    End Sub

    Private Sub BtnEndShow_Click(sender As Object, e As EventArgs) Handles BtnHide.Click
        ShowScreen(False)
    End Sub

    Private Sub BtnOpen_ButtonClick(sender As Object, e As EventArgs) Handles BtnOpen.ButtonClick
        DlgOpen.DefaultExt = "*.fly"
        DlgOpen.Filter = "TerraExplorer Files|*.fly"
        If DlgOpen.ShowDialog() = DialogResult.OK Then OpenFile(DlgOpen.FileName)
    End Sub

    Private Sub MnRecent_Click(sender As Object, e As EventArgs) Handles MnRecent.Click
        On Error Resume Next
        Dim cFile As String = CType(sender, ToolStripMenuItem).Text
        OpenFile(cFile)
    End Sub

    Private Sub BtnFollow_Click(sender As Object, e As EventArgs) Handles BtnFollow.Click
        On Error Resume Next
        Dim cPos As IPosition71 = Sw.Navigate.GetPosition
        Swex.Navigate.FlyTo(cPos)
    End Sub

    Private Sub BtnUnlink_Click(sender As Object, e As EventArgs) Handles BtnUnlink.Click
        LinkShow(False)
    End Sub

    Private Sub BtnLink_Click(sender As Object, e As EventArgs) Handles BtnLink.Click
        LinkShow(True)
    End Sub

    Private Sub BtnRedo_Click(sender As Object, e As EventArgs) Handles BtnRedo.Click
        Sw.Command.Execute(2346, 0)
        MsgBox("Chức năng này chỉ hỗ trợ ở phiên bản TerraExplorer 7.3", vbInformation, "Redo")
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        ReloadShow()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If My.Computer.Keyboard.ShiftKeyDown Then
            Sw.Command.Execute(1004, 0)
        Else
            SaveFile()
        End If

    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        'If Screen.AllScreens.Count = 1 Then
        '    MsgBox("Không tìm thấy màn hình trình chiếu !", vbExclamation, "Trình chiếu")
        'Else
        SetMornitor(FrmShow, 1)
        ShowScreen(True)
        'End If

    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        Sw.Command.Execute(2345, 0)
        MsgBox("Chức năng này chỉ hỗ trợ ở phiên bản TerraExplorer 7.3", vbInformation, "Undo")

    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        FrmAbout.ShowDialog(Me)
    End Sub

#End Region

#Region "Main Terra"

    Private WithEvents Sw As SGWorld71
    Private WithEvents Swex As SGWorld71
    Private MainPres As IPresentation71
    Private EditSubIndex As Integer
    Private MainHighlight As String = ""
    Private CurObject As MapObject
    Private CurID As String
    Private FileChanged As Boolean = False

    Private Sub InitTerra()
        Try

            SetStatus("Khởi tạo hệ sinh thái TerraExplorer 7.1", IconType.Wait)
            Sw = MapView.CreateInstance("TerraExplorerX.SGWorld71")
            Sw.ProjectTree.ShowSearchTool = True
            MapTree.AttachTo3dWindow(MapView.GetOcx)
            Swex = FrmShow.MapShow.CreateInstance("TerraExplorerX.SGWorld71")
            Swex.Window.DisablePresentationControl = True
            Sw.Window.DisablePresentationControl = True
            Swex.SetOptionParam("HeadUpDisplay", 8)
            'Sw.SetOptionParam("HeadUpDisplay", 290)
            Sw.ProjectTree.ShowSearchTool = True
            SetOptimize3D()
            CurObject = New MapObject(Sw)
            ResizeMap()
            'Navigation control----
            Dim val As Integer
            val = Sw.GetOptionParam("UseSimplifiedNavigationControl")
            MnNavigate.Checked = Not CBool(val)
            If Sw.Version.Type = TEVersionType.TEVT_VIEWER Then SetStatus("Không tìm thấy bản quyền TerraExplorer Pro...", IconType.Exclamation)
        Catch ex As Exception
            SetStatus("Init TerraExplorer Instance message: " & ex.Message, 2)
        End Try
    End Sub

    Private Sub SetOptimize3D()
        Swex.SetOptionParam("TerrainCacheSize", 2000000)
        Sw.SetOptionParam("TerrainCacheSize", 2000000)
        Swex.SetOptionParam("ModelsCacheSize", 500000)
        Sw.SetOptionParam("ModelsCacheSize", 500000)
        Sw.SetOptionParam("TerrainModelQuality", 0)
        Swex.SetOptionParam("TerrainModelQuality", 0)
    End Sub

    Private Sub OpenFile(ByVal mFile As String)
        Try
            If Not IO.File.Exists(mFile) Then Exit Sub
            If CloseFile() = vbCancel Then Exit Sub
            SetStatus("Đang mở file: " & mFile, IconType.Wait)
            Sw.Project.Open(mFile, True)
        Catch ex As Exception
            SetStatus(ex.Message, 2)
        End Try
    End Sub

    Private Sub SaveFile()
        Try
            SetStatus("Đang lưu file: " & Sw.Project.Name, IconType.Wait)
            Sw.Project.Save()
            FileChanged = False
        Catch
            SetStatus("Lưu file thất bại!", IconType.Cancel)
        End Try

    End Sub

    Private Function CloseFile(Optional ByVal ForceClose As Boolean = False) As MsgBoxResult
        On Error Resume Next
        Dim mRs As MsgBoxResult = vbNo
        If ForceClose Then GoTo Tiep
        If FileChanged Then
            mRs = MsgBox("Bạn có muốn lưu lại thay đổi trên bản đồ không?", vbQuestion Or vbYesNoCancel, "Thông báo")
            Select Case mRs
                Case vbCancel
                    Return vbCancel
                Case vbYes
                    SaveFile()
                Case Else
                    Exit Select
            End Select
        End If
Tiep:
        Dim fn As String = Sw.Project.Name
        SetStatus("Đang đóng file: " & fn, IconType.Wait)
        ClosePres()
        Swex.Project.Close()
        Sw.Project.Close()
        Return mRs
    End Function

    Private Sub SetCopyRight()
        Try
            Sw.Project.Settings("CopyrightText”) = "Phần mềm bản quyền của Ban Bản đồ Quân khu 5"
            Sw.Project.Settings("RemoveSkylineCopyright") = 1
            Swex.Project.Settings("RemoveSkylineCopyright") = 1
        Catch

        End Try
    End Sub

#End Region

#Region "Terra Show"

    Private Sub ReloadShow()
        On Error Resume Next
        Dim mRs As MsgBoxResult
        mRs = MsgBox("Cập nhật lại bản đồ có thể làm gián đoạn màn hình trình chiếu" & vbCrLf & "Bạn có muốn tiếp tục không?", vbQuestion Or vbYesNo, "Cập nhật bản đồ")
        Application.DoEvents()
        If mRs = vbYes Then
            CaptureShow()
            Application.DoEvents()
            LoadShow(True)

            SetStatus("Đã cập lại màn hình trình chiếu!", IconType.Accept)
        End If

    End Sub

    Private Sub SyncVisible(ID As String)
        If ID = "" Then Exit Sub
        Dim nID As String
        If Sw.ProjectTree.IsGroup(ID) Then
            Dim cID As String
            cID = Sw.ProjectTree.GetNextItem(ID, ItemCode.CHILD)
            SyncVisible(cID)
        Else
            Dim cVal As Boolean = Sw.ProjectTree.GetVisibility(ID)
            Swex.ProjectTree.SetVisibility(ID, cVal)
        End If
        nID = Sw.ProjectTree.GetNextItem(ID, ItemCode.NEXT)
        SyncVisible(nID)
    End Sub
    Private Sub LoadShow(Optional ByVal Sync As Boolean = False)
        On Error Resume Next
        Dim cFile As String
        cFile = Sw.Project.Name
        If cFile = "" Then Exit Sub
        FrmShow.MapShow.Visible = False
        Swex.Project.Open(cFile, False)
        If Sync Then
            Dim fID As String = Sw.ProjectTree.GetNextItem(Sw.ProjectTree.RootID, ItemCode.CHILD)
            SyncVisible(fID)
        End If
        FrmShow.MapShow.Visible = True
    End Sub

    Private Sub CaptureShow()
        If Screen.AllScreens.Count = 1 Then Exit Sub
        Dim Rec As Rectangle = Screen.AllScreens(1).Bounds
        Dim cImg As New Bitmap(Rec.Width, Rec.Height)
        Dim cGrp As Graphics = Graphics.FromImage(cImg)
        cGrp.CopyFromScreen(Rec.X, Rec.Y, 0, 0, Rec.Size, CopyPixelOperation.SourceCopy)
        FrmShow.BackgroundImage = cImg
    End Sub

    Private Function SetMornitor(Frm As Form, nS As Byte) As Boolean
        Try
            Dim Pnt As Rectangle = Screen.AllScreens(nS).Bounds
            Frm.SetBounds(Pnt.X, Pnt.Y, Pnt.Width, Pnt.Height)
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub LinkShow(mValue As Boolean)
        Try
            Dim cPos As IPosition71 = Sw.Navigate.GetPosition
            Application.DoEvents()
            If mValue Then
                'Swex.Application.Multiple3DWindows.UnlinkPosition()
                Sw.Application.Multiple3DWindows.SetAsLeader()
                Swex.Application.Multiple3DWindows.LinkPosition(Sw)
                Sw.SetOptionParam("HUDcolor", Drawing.Color.Yellow)
                SetStatus("Đã liên kết màn hình trình chiếu")
            Else
                'Sw.Application.Multiple3DWindows.UnlinkPosition()
                Swex.Navigate.SetPosition(cPos)
                Swex.Application.Multiple3DWindows.UnlinkPosition()
                Sw.SetOptionParam("HUDcolor", Drawing.Color.White)
                SetStatus("Đã ngắt liên kết màn hình trình chiếu")
            End If
            BtnLink.Visible = Not mValue
            BtnUnlink.Visible = mValue
            BtnFollow.Enabled = Not mValue
        Catch ex As Exception
            SetStatus("Không thể liên kết màn hình trình chiếu: " & ex.Message, IconType.Warning)
        End Try
    End Sub

    Private Sub ShowScreen(mVal As Boolean)
        FrmShow.Visible = mVal
        BtnHide.Visible = mVal
        BtnShow.Visible = Not mVal
        BtnFollow.Visible = mVal
        Me.Select()
    End Sub

    Private Sub SyncVisible(cID As String, nVal As String)
        If TmrHighlight.Enabled Then Exit Sub
        Dim mVal As Boolean = nVal
        mVal = Not mVal
        Swex.ProjectTree.SetVisibility(cID, mVal)
    End Sub

#End Region

#Region "Terra Event"

    Private Function Sw_OnMouseWheel(Flags As Integer, zDelta As Short, X As Integer, Y As Integer) As Boolean Handles Sw.OnMouseWheel
        SendEvent("MouseDown")
        Return Nothing
    End Function

    Private Function Sw_OnSGWorldMessage(MessageID As String, SourceObjectID As String) As Boolean Handles Sw.OnSGWorldMessage
        If SourceObjectID <> "MessageBarText" Then SendEvent("Message-" & MessageID & "-" & SourceObjectID)
        Return Nothing
    End Function

    Private Function MapMouseDown() As Boolean Handles Sw.OnLButtonDown, Sw.OnMButtonDown, Sw.OnRButtonDown
        SendEvent("MouseDown")
        Return Nothing
    End Function

    Private Sub Sw_OnDateTimeChanged(DateTime As Object) Handles Sw.OnDateTimeChanged
        Swex.DateTime.FixedLocalTime = DateTime
    End Sub

    Private Sub Sw_OnInputModeChanged(NewMode As MouseInputMode) Handles Sw.OnInputModeChanged
        SendEvent("InputmodeChanged")
    End Sub

    Private Sub Sw_OnFileClosed() Handles Sw.OnFileClosed
        SendEvent("FileClosed")
    End Sub

    Private Sub Sw_OnSGWorld(EventID As Integer, EventParam As Object) Handles Sw.OnSGWorld
        If EventID = 9 Then SendEvent("FileSaved") Else SendEvent("Msgbox-" & EventID & ": " & EventParam.ToString)
    End Sub

    Private Sub Sw_OnObjectAction(ObjectID As String, Action As IAction71) Handles Sw.OnObjectAction
        Try

            Select Case Action.Code
                Case 15, 16, 17, 23, 24, 26, 27, 28, 29, 32
                    SendEvent("FileChanged-" & ObjectID & "-" & Action.Param.ToString)
                Case ActionCode.AC_EDIT_STARTED
                    SendEvent("EditStarted")
                Case ActionCode.AC_SELCHANGED
                    SendEvent("MapSelected-" & ObjectID)
                Case ActionCode.AC_SHOW
                    SendEvent("ShowHideItem-" & ObjectID & "-" & Action.Param.ToString)

                Case ActionCode.AC_STOP
                    SendEvent("CameraStop")
                Case Else
                    Exit Select
            End Select
        Catch

        End Try
    End Sub

    Private Sub Sw_OnProjectTreeAction(ID As String, Action As IAction71) Handles Sw.OnProjectTreeAction
        Try
            Select Case Action.Code
                Case 15, 16, 17, 23, 24, 26, 27, 28, 29, 32
                    SendEvent("FileChanged-" & ID & "-" & Action.Param.ToString)
                Case ActionCode.AC_EDIT_STARTED
                    SendEvent("EditStarted")
                Case ActionCode.AC_SELCHANGED
                    SendEvent("TreeSelected-" & ID)
                Case ActionCode.AC_SHOW
                    SendEvent("ShowHideItem-" & ID & "-" & Action.Param.ToString)
                Case ActionCode.AC_STOP
                    SendEvent("CameraStop")
                Case Else
                    Exit Select
            End Select
        Catch

        End Try
    End Sub

    Private Sub Sw_OnLoadFinished(bSuccess As Boolean) Handles Sw.OnLoadFinished
        If bSuccess Then 'Turn off effect to optimize speed
            Sw.Command.Execute(1154, 0) 'Turn off dynamic cloud
            Sw.Command.Execute(2206, 0) 'Turn off Rain effect
            Sw.Command.Execute(2207, 0) 'Turn off Snow effect
            Sw.Command.Execute(2208, 0) 'Turn off Fog effect
            Sw.Command.Execute(2209, 0) 'Turn off Sky texture
            SendEvent("FileLoaded")
        Else
            SendEvent("FileLoadFail")
        End If

    End Sub

    Private Sub Swex_OnLoadFinished(bSuccess As Boolean) Handles Swex.OnLoadFinished
        If bSuccess Then 'Turn off effect to optimize speed
            Swex.Command.Execute(1154, 0) 'Turn off dynamic cloud
            Swex.Command.Execute(2206, 0) 'Turn off Rain effect
            Swex.Command.Execute(2207, 0) 'Turn off Snow effect
            Swex.Command.Execute(2208, 0) 'Turn off Fog effect
            Swex.Command.Execute(2209, 0) 'Turn off Sky texture
            SendEvent("ShowLoaded")
        Else
            SendEvent("ShowLoadFail")
        End If
    End Sub

#Disable Warning BC42353 ' Function doesn't return a value on all code paths

    Private Function Sw_OnKeyboard(Message As Integer, [Char] As Integer, KeyState As Integer) As Boolean Handles Sw.OnKeyboard
        SendEvent("KeyPress-" & [Char] & "-" & KeyState)
    End Function

#Enable Warning BC42353 ' Function doesn't return a value on all code paths

    Private Sub SendEvent(mText As String)
        If Exitting Then Exit Sub
        Dim thr = New Thread(New ThreadStart(Sub() InvokeTextBox(mText)))
        thr.SetApartmentState(ApartmentState.MTA)
        thr.Start()
    End Sub

    Private Sub InvokeTextBox(mText As String)
        Dim mik = New MethodInvoker(Sub() SetText(mText))
        Me.Invoke(mik)
    End Sub

    Private Sub SetText(mText As String)
        TxtEvent.Text = mText
    End Sub

    Private Async Sub TxtEvent_TextChanged(sender As Object, e As EventArgs) Handles TxtEvent.TextChanged

        Try
            If TxtEvent.Text = "" Then Exit Sub
            Dim msg() As String
            msg = TxtEvent.Text.Split("-")
            Select Case msg(0)
                Case "TreeSelected"
                    ChangeSelect(msg(1))
                Case "FileChanged"
                    Me.Text = "Military 3D Map - " & Sw.Project.Name & "*"
                    FileChanged = True
                Case "FileLoaded"
                    SetStatus("Đã mở file: " & Sw.Project.Name)
                    FileChanged = False
                    Me.Text = "Military 3D Map - " & Sw.Project.Name
                    AddRecent(Sw.Project.Name)
                    LoadShow()
                    SetCopyRight()
                    MapToolStrip.Enabled = True
                    TreeToolStrip.Enabled = True
                    SourceToolStrip.Enabled = True
                    Sw.ProjectTree.ShowSearchTool = True
                    BtnSave.Enabled = True
                    GrControl.Enabled = True
                Case "FileLoadFail"
                    BtnSave.Enabled = False
                    BtnLink.Enabled = False
                    BtnReload.Enabled = False
                    MapToolStrip.Enabled = False
                    TreeToolStrip.Enabled = False
                    SourceToolStrip.Enabled = False
                    SetStatus("Không thể mở file", IconType.Exclamation)
                    GrControl.Enabled = False
                Case "ShowLoaded"
                    BtnLink.Enabled = True
                    BtnFollow.Enabled = True
                    BtnReload.Enabled = False
                    LinkShow(True)
                Case "ShowLoadFail"
                    BtnLink.Enabled = False
                    BtnFollow.Enabled = False
                    BtnReload.Enabled = True
                    SetStatus("Không tải được dữ liệu trình chiếu. Thử lưu và tải lại màn hình trình chiếu!", IconType.Exclamation)
                Case "FileSaved"
                    Me.Text = "Military 3D Map - " & Sw.Project.Name
                    BtnReload.Enabled = True
                    SetStatus("Đã lưu file thành công!", IconType.Accept)
                Case "FileClosed"
                    MapToolStrip.Enabled = False
                    TreeToolStrip.Enabled = False
                    SourceToolStrip.Enabled = False
                    BtnReload.Enabled = False
                    BtnSave.Enabled = False
                    GrControl.Enabled = False
                    SetStatus("Đã đóng file")
                Case "InputmodeChanged"
                    SetInputMode()
                Case "MapSelected"
                    MsgBox("Map select")
                Case "ObjectAction"
                    SetStatus("Object action: " & msg(1), IconType.Message)
                Case "EditStarted"
                    StopCamera(True)
                    StopHighlight()
                    ResizeMap()
                Case "PresentationChanged"
                    SetPresState(msg(1))
                    GetStep()
                Case "StepBegin"
                    StopHighlight()
                    LoadPres(msg(1))
                    StopCamera()
                    StartPresSH(msg(2))
                Case "StepReached"
                    StartPresHL(msg(2))
                Case "ShowHideItem"
                    SyncVisible(msg(1), msg(2))
                Case "KeyPress"
                    Select Case msg(1)
                        Case "27"
                            StopCamera(True)
                            StopHighlight()
                        Case "114"
                            Sw.ProjectTree.ShowSearchTool = True
                        Case Else
                            Exit Select
                    End Select

                Case "CameraStop"
                    TmrFollow.Enabled = False
                Case "MouseDown"
                    StopCamera()
                Case "Message"
                    ChangeSelect(msg(2))
                    sMessage.Activate()
                Case "Msgbox"
                    SetStatus(msg(1))
                Case Else
                    Exit Select
            End Select
        Catch ex As Exception
            SetStatus("Event Exception: " & ex.Message, IconType.Warning)
        Finally
            TxtEvent.Text = ""
        End Try
    End Sub

    Private Sub SyncFlyObject()
        Dim cStep As IPresentationStep71 = MainPres.Steps(MainPres.Steps.Current)
        If cStep.Type = PresentationStepType.ST_RESTARTDYNAMICOBJECT Then

        End If
    End Sub

#End Region

#Region "Terra Map"

    Private Sub SetInputMode()
        On Error Resume Next
        Dim mIp As MouseInputMode = Sw.Window.GetInputMode()
        Dim mBt As ToolStripButton
        For Each mBt In MapToolStrip.Items.OfType(Of ToolStripButton)
            mBt.Checked = False
        Next
        Select Case mIp
            Case MouseInputMode.MI_FREE_FLIGHT
                BtnPan.Checked = True
            Case MouseInputMode.MI_EDIT
                BtnSelect.Checked = BtnSelect.Tag
                BtnSelectArea.Checked = BtnSelectArea.Tag
            Case MouseInputMode.MI_MEASUREMENT
                BtnDistance.Checked = BtnDistance.Tag
                BtnHeight.Checked = BtnHeight.Tag
                BtnArea.Checked = BtnArea.Tag
            Case MouseInputMode.MI_COM_CLIENT

        End Select

    End Sub

    Private Sub MnNavigate_Click(sender As Object, e As EventArgs) Handles MnNavigate.Click
        Dim value As Integer = Sw.GetOptionParam("UseSimplifiedNavigationControl")
        value = Abs(value - 1)
        Sw.SetOptionParam("UseSimplifiedNavigationControl", value)
        MnNavigate.Checked = Not CBool(value)
    End Sub

    Private Sub BtnPan_Click(sender As Object, e As EventArgs) Handles BtnPan.Click
        On Error Resume Next
        Swex.Window.SetInputMode(MouseInputMode.MI_FREE_FLIGHT,, True)
        Sw.Window.SetInputMode(MouseInputMode.MI_FREE_FLIGHT,, True)
        SetInputMode()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        BtnSelect.Tag = True
        BtnSelectArea.Tag = False
        Sw.Command.Execute(1021, 0)
        SetInputMode()

    End Sub

    Private Sub BtnSelectArea_Click(sender As Object, e As EventArgs) Handles BtnSelectArea.Click
        BtnSelect.Tag = False
        BtnSelectArea.Tag = True
        Sw.Command.Execute(1024, 0)
        SetInputMode()
    End Sub

    Private Sub BtnDistance_Click(sender As Object, e As EventArgs) Handles BtnDistance.Click
        BtnDistance.Tag = True
        BtnHeight.Tag = False
        BtnArea.Tag = False
        Sw.Command.Execute(1034, 0)
        SetInputMode()
    End Sub

    Private Sub BtnHeight_Click(sender As Object, e As EventArgs) Handles BtnHeight.Click
        BtnDistance.Tag = False
        BtnHeight.Tag = True
        BtnArea.Tag = False
        Sw.Command.Execute(1036, 0)
        SetInputMode()
    End Sub

    Private Sub BtnArea_Click(sender As Object, e As EventArgs) Handles BtnArea.Click
        BtnDistance.Tag = False
        BtnHeight.Tag = False
        BtnArea.Tag = True
        Sw.Command.Execute(1037, 0)
        SetInputMode()
    End Sub

    Private Sub BtnOcean_Click(sender As Object, e As EventArgs) Handles BtnOcean.Click
        Sw.Command.Execute(1155, 0) 'Turn off Ocean
        Swex.Command.Execute(1155, 0) 'Turn off Ocean
    End Sub

    Private Sub BtnNavigate_Click(sender As Object, e As EventArgs) Handles BtnNavigate.ButtonClick
        Sw.Command.Execute(1065, 0)
    End Sub

    Private Sub BtnCapture_Click(sender As Object, e As EventArgs) Handles BtnCapture.Click
        Sw.Command.Execute(1067, 0) 'Save Map screen
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Sw.Command.Execute(1031, 0)
        SetStatus("Đã sao chép đối tượng")
    End Sub

    Private Sub BtnCut_Click(sender As Object, e As EventArgs) Handles BtnCut.Click
        Sw.Command.Execute(1032, 0)
        SetStatus("Đã cắt đối tượng")
    End Sub

    Private Sub BtnPaste_Click(sender As Object, e As EventArgs) Handles BtnPaste.Click
        Sw.Command.Execute(1030, 0)
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Sw.Command.Execute(1033, 0)
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        If Sw.Version.Type = TEVersionType.TEVT_VIEWER Then
            MsgBox("Phiên bản Terraexplorer hiện tại không hỗ trợ thiết đặt cho dự án", vbInformation, "Thiết đặt")
        Else
            Sw.Command.Execute(1020, 0)
        End If
    End Sub

    Private Sub MapSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles MapSplitter.SplitterMoved
        ResizeMap()
    End Sub

    Private Sub BtnTimeSlider_Click(sender As Object, e As EventArgs) Handles BtnTimeSlider.Click
        Try
            Dim cs As Integer = Sw.GetOptionParam("HeadUpDisplay")
            Sw.Command.Execute(1065, 4)
            Dim ns As Integer = Sw.GetOptionParam("HeadUpDisplay")
            Swex.DateTime.DisplaySun = (cs < ns)
            Sw.DateTime.DisplaySun = (cs < ns)
        Catch ex As Exception
            SetStatus("Không hiển thị được thanh điều chỉnh thời gian: " & ex.Message, IconType.Warning)
        End Try

    End Sub

    Private Sub BtnShadow_Click(sender As Object, e As EventArgs) Handles BtnShadow.Click
        Sw.Command.Execute(2118, 0)
        Swex.Command.Execute(2118, 0)
    End Sub

    Private Sub BtnPanel_Click(sender As Object, e As EventArgs)
        MapSplitter.Panel2Collapsed = Not MapSplitter.Panel2Collapsed
        MapView.Dock = DockStyle.Fill
        MapView.Dock = DockStyle.None
    End Sub

#End Region

#Region "Terra Object"

    Private Sub ChangeSelect(nID As String)
        Try
            If nID = Sw.ProjectTree.RootID Then Exit Sub
            CurID = nID
            GetProperty()
            If CurObject.ObjectType = ObjectTypeCode.OT_PRESENTATION Then LoadPres(CurID)
            BtnAddPresHL.Enabled = Not IsNothing(MainPres)
            BtnAddPresHL2.Enabled = BtnAddPresHL.Enabled
            GetNote()
        Catch

        End Try
    End Sub

    Private Sub GetPres()
        If IsNothing(MainPres) Then
            LoadPres(CurID)
        Else
            If MainPres.PresentationStatus = PresentationStatus.PS_NOTPLAYING Then LoadPres(CurID)
        End If
    End Sub

    Private Sub GetProperty()
        Try
            CurObject.SetID(CurID)
            CurSign.SetID(CurID)
            TxName.Text = CurObject.ItemName
            TxLabel.Text = CurObject.LabelText

            NrLinewid.Value = CurObject.LineWidth
            NrLineOpa.Value = CurObject.LineOpacity
            NrFillOpa.Value = CurObject.FillOpacity

            TxtLineColor.Text = CurObject.LineColor
            TxtFillColor.Text = CurObject.FillColor
            TxtFillColor.BackColor = ColorTranslator.FromHtml(TxtFillColor.Text)
            TxtLineColor.BackColor = ColorTranslator.FromHtml(TxtLineColor.Text)

            NrDis.Value = CurObject.Distance
            NrScale.Value = CurObject.Scale
            NrMaxView.Value = CurObject.MaxView
            NrMinView.Value = CurObject.MinView
            TxtFilename.Text = CurObject.FileName
            ResetEditTag()
            GrEdit.Enabled = (CurObject.Type <> 0)
            GrNote.Enabled = GrEdit.Enabled
        Catch ex As Exception
            GrEdit.Enabled = False
            GrNote.Enabled = False
        End Try

    End Sub
    Private Sub ResetEditTag()
        For Each ct As Control In GrEdit.Controls
            ct.Tag = ""
        Next
    End Sub
    Private Sub CmdApply_Click(sender As Object, e As EventArgs) Handles CmdApply.Click

        If BwEdit.IsBusy Then Exit Sub
        SetStatus("Đang áp dụng chỉnh sửa cho các đối tượng...", IconType.Wait)
        PrgBar.Visible = True
        PrgBar.Value = 0
        PrgBar.Maximum = 100
        BwEdit.RunWorkerAsync()
    End Sub

    Private Sub CmdOpen_Click(sender As Object, e As EventArgs) Handles CmdOpen.Click
        Select Case CurObject.Type
            Case MapObject.MapObjectType.Layer
                DlgOpen.DefaultExt = "shp"
                DlgOpen.Filter = "Shape Files|*.shp;*.gpkg;*.kml;*.kmlz|All Files|*.*"
            Case MapObject.MapObjectType.Label, MapObject.MapObjectType.Raster
                DlgOpen.DefaultExt = "jpg"
                DlgOpen.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;*.png;*.gif;*.tif|All Files|*.*"
            Case MapObject.MapObjectType.Dynamic
                DlgOpen.DefaultExt = "xpl2"
                DlgOpen.Filter = "3D Model Files|*.xpl;*.xpl2;*.x;*.xpc;*.dae;*.3ds;*.flt;*.fpc|All Files|*.*"
            Case Else
                DlgOpen.DefaultExt = "*"
                DlgOpen.Filter = "All Files|*.*"
        End Select
        If DlgOpen.ShowDialog() = DialogResult.OK Then
            TxtFilename.Text = DlgOpen.FileName
            CurObject.FileName(DlgOpen.FileName)

        End If
    End Sub

    Private Sub NrMaxView_LostFocus(sender As Object, e As EventArgs) Handles NrMaxView.LostFocus
        CurObject.MaxView(NrMaxView.Value)
        NrMaxView.Tag = NrMaxView.Value
        FileChanged = True
    End Sub

    Private Sub NrMinView_LostFocus(sender As Object, e As EventArgs) Handles NrMinView.LostFocus
        CurObject.MinView(NrMinView.Value)
        NrMinView.Tag = NrMinView.Value
        FileChanged = True
    End Sub

    Private Sub NrLine_LostFocus(sender As Object, e As EventArgs) Handles NrLinewid.LostFocus
        CurObject.LineWidth(NrLinewid.Value)
        NrLinewid.Tag = CurObject.LineWidth
        FileChanged = True
    End Sub

    Private Sub NrLineOpa_LostFocus(sender As Object, e As EventArgs) Handles NrLineOpa.LostFocus
        CurObject.LineOpacity(NrLineOpa.Value)
        NrLineOpa.Tag = CurObject.LineOpacity
        FileChanged = True
    End Sub

    Private Sub NrFillOpa_LostFocus(sender As Object, e As EventArgs) Handles NrFillOpa.LostFocus
        CurObject.FillOpacity(NrFillOpa.Value)
        NrFillOpa.Tag = CurObject.FillOpacity
        FileChanged = True
    End Sub

    Private Sub NrScale_LostFocus(sender As Object, e As EventArgs) Handles NrScale.LostFocus
        CurObject.Scale(NrScale.Value)
        NrScale.Tag = CurObject.Scale
        FileChanged = True
    End Sub

    Private Sub NrDis_LostFocus(sender As Object, e As EventArgs) Handles NrDis.LostFocus
        CurObject.Distance(NrDis.Value)
        NrDis.Tag = CurObject.Distance
        FileChanged = True
    End Sub
    Private Sub TxName_LostFocus(sender As Object, e As EventArgs) Handles TxName.LostFocus
        CurObject.ItemName(TxName.Text)
        TxName.Tag = TxName.Text
        FileChanged = True
    End Sub
    Private Sub TxLabel_LostFocus(sender As Object, e As EventArgs) Handles TxLabel.LostFocus
        CurObject.LabelText(TxLabel.Text)
        TxLabel.Tag = TxLabel.Text
        FileChanged = True
    End Sub

    Private Sub BtnFillColor_DoubleClick(sender As Object, e As EventArgs) Handles TxtFillColor.DoubleClick
        DlgColor.Color = TxtFillColor.BackColor
        If DlgColor.ShowDialog() = DialogResult.OK Then
            TxtFillColor.BackColor = DlgColor.Color
            TxtFillColor.Text = ToHexColor(DlgColor.Color)
            CurObject.FillColor(TxtFillColor.Text)
            CurObject.FillOpacity(NrFillOpa.Value)
            TxtFillColor.Tag = TxtFillColor.Text
            FileChanged = True
        End If

    End Sub

    Private Sub BtnLineColor_DoubleClick(sender As Object, e As EventArgs) Handles TxtLineColor.DoubleClick
        DlgColor.Color = TxtLineColor.BackColor
        If DlgColor.ShowDialog() = DialogResult.OK Then
            TxtLineColor.Text = ToHexColor(DlgColor.Color)
            TxtLineColor.BackColor = DlgColor.Color
            CurObject.LineColor(TxtLineColor.Text)
            CurObject.LineOpacity(NrLineOpa.Value)
            TxtLineColor.Tag = CurObject.LineColor
            FileChanged = True
        End If
    End Sub

    Private Sub TxtLineColor_LostFocus(sender As Object, e As EventArgs) Handles TxtLineColor.LostFocus
        Try
            If TxtLineColor.Tag = TxtLineColor.Text Then Exit Sub
            TxtLineColor.BackColor = FromHexColor(TxtLineColor.Text)
            CurObject.LineColor(TxtLineColor.Text)
            TxtLineColor.Tag = CurObject.LineColor
            FileChanged = True
        Catch

        End Try

    End Sub

    Private Sub TxtFillColor_LostFocus(sender As Object, e As EventArgs) Handles TxtFillColor.LostFocus
        Try
            If TxtFillColor.Tag = TxtFillColor.Text Then Exit Sub
            TxtFillColor.BackColor = FromHexColor(TxtFillColor.Text)
            CurObject.FillColor(TxtFillColor.Text)
            TxtFillColor.Tag = CurObject.FillColor
            FileChanged = True
        Catch

        End Try
    End Sub

    Private Function FromHexColor(hSt As String) As Color
        hSt = Replace(hSt, "#", "&H")
        Dim rColor As Color = ColorTranslator.FromHtml(hSt)
        Return rColor
    End Function

    Private Function ToHexColor(c As Color) As String
        Dim rSt As String
        rSt = "#" & c.R.ToString("X2") & c.G.ToString("X2") & c.B.ToString("X2")
        Return rSt
    End Function

    Private Sub BwEdit_DoWork(sender As Object, e As DoWorkEventArgs) Handles BwEdit.DoWork
        On Error Resume Next
        Dim mOb As New MapObject(Sw)
        Dim pID() As String = GetSelects()
        Dim cID As String
        Dim i As Integer = 0
        For Each cID In pID
            If mOb.SetID(cID) Then
                'Using tag for changed property-----
                'mOb.ItemName = TxName.Tag
                mOb.LabelText(TxLabel.Tag)
                mOb.LineColor(TxtLineColor.Tag)
                mOb.FillColor(TxtFillColor.Tag)
                mOb.LineWidth(NrLinewid.Tag)
                mOb.LineOpacity(NrLineOpa.Tag)
                mOb.FillOpacity(NrFillOpa.Tag)
                mOb.Scale(NrScale.Tag)
                mOb.Distance(NrDis.Tag)
                mOb.MaxView(NrMaxView.Tag)
                mOb.MinView(NrMinView.Tag)
            End If
            i += 1
            If Not Exitting Then BwEdit.ReportProgress(i * 100 \ pID.Length)
        Next
        ResetEditTag()
    End Sub

    Private Sub BwEdit_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BwEdit.RunWorkerCompleted
        PrgBar.Visible = False
        FileChanged = True
        SetStatus("Đã áp dụng chỉnh sửa cho các đối tượng", IconType.Accept)
    End Sub

    Private Sub BwEdit_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BwEdit.ProgressChanged
        PrgBar.Value = e.ProgressPercentage
    End Sub

#End Region

#Region "Terra Tree"

    Private Sub ShowEditTab()
        If TabTool.SelectedIndex = 0 Or TabTool.SelectedIndex = 3 Then TabTool.SelectTab(1)
    End Sub

    Private Sub BtnAddGroup_Click(sender As Object, e As EventArgs) Handles BtnAddGroup.ButtonClick
        Try
            Dim pID As String = CurrentGroup()
            Dim nID As String = Sw.ProjectTree.CreateGroup("New group", pID)
            Sw.ProjectTree.RenameGroup(nID, "New group #" & nID)
            Sw.ProjectTree.ExpandGroup(pID, True)
        Catch ex As Exception
            SetStatus("Không tạo được thư mục: " & ex.Message, IconType.Warning)
        End Try
    End Sub

    Private Function GetSelects() As String()
        Dim pst() As String = {}
        Dim s As String = Sw.ProjectTree.RootID
        Dim i As Integer = 0
        Do
            s = Sw.ProjectTree.GetNextItem(s, ItemCode.SELECTED)
            If s = "" Then Exit Do
            ReDim Preserve pst(i)
            pst(i) = s
            i += 1
        Loop Until s = ""
        Return pst
    End Function

    Private Sub BtnAddLocation_Click(sender As Object, e As EventArgs) Handles MnAddLocation.Click
        Sw.Command.Execute(1016, 0)
    End Sub

    Private Sub BtnAddLayer_Click(sender As Object, E As EventArgs) Handles BtnAddLayer.ButtonClick
        Sw.Command.Execute(1013, 0)
    End Sub

    Private Sub BtnAddLabel_Click(sender As Object, e As EventArgs) Handles BtnAddLabel.ButtonClick
        Sw.Command.Execute(1012, 0)
    End Sub

    Private Sub BtnAddImageLabel_Click(sender As Object, e As EventArgs) Handles BtnAddImage.Click
        Sw.Command.Execute(1012, 1)
    End Sub

    Private Sub BtnUpdateLocation_Click(sender As Object, e As EventArgs) Handles BtnUpdateGroup.Click
        Dim nloc As ITerrainLocation71
        Try

            If IsGroup(CurID) Then
                nloc = Sw.Creator.CreateLocationHere(Sw.ProjectTree.HiddenGroupID)
                Dim cPos As IPosition71 = Sw.Creator.CreatePosition(nloc.Position.X, nloc.Position.Y, 0, AltitudeTypeCode.ATC_TERRAIN_RELATIVE, nloc.Position.Yaw, nloc.Position.Pitch, 0, nloc.Position.Distance)
                Sw.ProjectTree.SetGroupLocation(CurID, cPos)
                SetStatus("Đã cập nhật vị trí cho đối tượng")
            End If
        Catch ex As Exception
            SetStatus("Không thể cập nhật vị trí: " & ex.Message, IconType.Warning)
        End Try
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        If Not IsNothing(nloc) Then Sw.ProjectTree.DeleteItem(nloc.ID)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value

    End Sub

    Private Sub AddGroundObject_Click(sender As Object, e As EventArgs) Handles AddGroundObject.Click
        Sw.Command.Execute(1012, 26)
    End Sub

    Private Sub AddFlyObject_Click(sender As Object, e As EventArgs) Handles AddFlyObject.Click
        Sw.Command.Execute(1012, 27)
    End Sub

    Private Sub AddStandObject_Click(sender As Object, e As EventArgs) Handles AddStandObject.Click
        Sw.Command.Execute(1012, 13)
    End Sub

    Private Sub BtnProperty_Click(sender As Object, e As EventArgs)
        Try
            'If Sw.Version.Type = TEVersionType.TEVT_VIEWER Then
            '    MsgBox("Phiên bản Terraexplorer hiện tại không hỗ trợ chỉnh sửa đối tượng", MsgBoxStyle.Information, "Chỉnh sửa")
            '    Exit Sub
            'End If
            Dim sID() As String

            sID = GetSelects()
            If sID.Count > 1 Then
                Sw.ProjectTree.EditItems(sID)
            Else
                Sw.ProjectTree.EditItem(CurID, EditItemFlags.EDIT_ITEM_USE_PROPERTY)
            End If
        Catch ex As Exception
            SetStatus("Không mở được Property của đối tượng: " & ex.Message, IconType.Warning)
        End Try

    End Sub

    Private Sub Expand(pID As String, Optional ByVal IsRoot As Boolean = False)
        Dim cID As String

        'Mo rong va mo thu muc con
        If IsGroup(pID) Then
            Sw.ProjectTree.ExpandGroup(pID, True)
            cID = Sw.ProjectTree.GetNextItem(pID, ItemCode.CHILD)
            Expand(cID)
        End If
        'Mo doi tuong tiep theo
        If Not IsRoot Then
            Dim nID As String = Sw.ProjectTree.GetNextItem(pID, ItemCode.NEXT)
            If nID <> "" Then Expand(nID)
        End If

    End Sub

    Private Sub BtnExpand_Click(sender As Object, e As EventArgs) Handles BtnExpandGroup.Click
        Expand(CurID, True)

    End Sub

    Private Sub BtnAddDmav_Click(sender As Object, e As EventArgs) Handles BtnAddDmav.Click
        Try
            DlgOpen.DefaultExt = "*.mdb"
            DlgOpen.Filter = "Dmav database|dataSkyline.mdb|Microsoft Database|*.mdb"
            If DlgOpen.ShowDialog() = DialogResult.OK Then
                Dim Fn As String = DlgOpen.FileName
                Dim Dmav = New DataObject(Fn)
                Dmav.Opendata("Select * From tbl3DDoiTuong")
                Dim rw As DataRow
                PrgBar.Maximum = Dmav.Table.Rows.Count
                PrgBar.Value = 0
                PrgBar.Visible = True
                For Each rw In Dmav.Table.Rows
                    PrgBar.Value += 1
                    AddDmavData(rw)
                Next
                PrgBar.Visible = False
                Dmav.CloseData()
            End If
        Catch ex As Exception
            PrgBar.Visible = False
            SetStatus("Lỗi thêm đối tượng Dmav: " & ex.Message, IconType.Warning)

        End Try

    End Sub

    Private Sub AddDmavData(crw As DataRow)
        'Lấy vị trí---
        Dim x As Double = crw("KinhDo")
        Dim y As Double = crw("ViDo")
        Dim x2 As Double = crw("PhaiDuoiX")
        Dim x1 As Double = crw("TraiTrenX")
        Dim y1 As Double = crw("TraiTrenY")
        Dim y2 As Double = crw("PhaiDuoiY")
        Dim pID As String = GetGroup()
        Dim Fn As String = Path.GetDirectoryName(DlgOpen.FileName) & "\" & crw("ID").ToString & ".png"
        Dim cPiv As Byte = crw("MaTamKH")
        If crw("GhiChu").ToString = "3D" Then 'Thêm cờ 3D
            Select Case cPiv
                Case 1, 2, 3
                    y = y1
                Case 5, 6, 7
                    y = y2
            End Select
            Select Case cPiv
                Case 1, 7, 8
                    x = x1
                Case 3, 4, 5
                    x = x2
            End Select
            If CurSign.AddtoMap(x, y, False) Then
                CurSign.Pivot = cPiv
                CurSign.Caption = ""
                CurSign.Name = "3D-#" & CurSign.ID
                CurSign.ImageFile = Fn
                CurSign.Redraw()
                CurSign.SaveSign()
            End If
        Else 'Them polygon 2D
            Dim aVert() As Double = {x2, y1, 0, x1, y1, 0, x1, y2, 0, x2, y2, 0}
            Dim cRing As ILinearRing
            Dim cGeo As IGeometry
            Dim cPol As ITerrainPolygon71
            Dim pn As String = Sw.Project.Name
            Dim dFn As String = Path.GetDirectoryName(pn)
            Dim nColor As Color = Color.FromArgb(0, 255, 255, 255)
            dFn = dFn & "\" & Path.GetFileNameWithoutExtension(pn) & "_data\"
            Directory.CreateDirectory(dFn)
            'Create Polygon to store image
            cRing = Sw.Creator.GeometryCreator.CreateLinearRingGeometry(aVert)
            cGeo = Sw.Creator.GeometryCreator.CreatePolygonGeometry(cRing)
            cPol = Sw.Creator.CreatePolygon(cGeo, &HFFFFFF, &HFFFFFF,, pID)
            'Copy image to Data File---
            dFn &= cPol.ID & ".png"
            IO.File.Copy(Fn, dFn)
            cPol.LineStyle.Color.SetAlpha(0)
            cPol.FillStyle.Texture.FileName = dFn
        End If

    End Sub

    Private Function GetGroup() As String 'Lay thu muc hien hanh

        Dim pID As String = Sw.ProjectTree.RootID
        Try
            Dim ob As ITerraExplorerObject71
            pID = Sw.ProjectTree.GetNextItem(pID, ItemCode.SELECTED)
            ob = Sw.ProjectTree.GetObject(pID)
            If Sw.ProjectTree.IsGroup(pID) And Not Sw.ProjectTree.IsLayer(pID) Then
            Else
                pID = Sw.ProjectTree.GetNextItem(pID, ItemCode.PARENT)
            End If
        Catch
        End Try
        Return pID
    End Function

    Private Sub BtnUnGroupChild_Click(sender As Object, e As EventArgs) Handles BtnCleanGroup.Click
        If Not IsGroup(CurID) Then Exit Sub
        If CurID = Sw.ProjectTree.RootID Then Exit Sub
        Dim mRs As MsgBoxResult
        mRs = MsgBox("Bạn có muốn loại bỏ các nhóm con của mục này?", vbQuestion Or vbYesNo, "Cây dự án")
        If mRs = vbNo Then Exit Sub
        Sw.ProjectTree.EnableRedraw(False)
        SetStatus("Đang bỏ nhóm con...", IconType.Wait)
        Dim pID As String = Sw.ProjectTree.GetNextItem(CurID, ItemCode.CHILD)
        Dim cID As String
        Dim nID As String
        Dim mID As String
        Do Until pID = ""
            mID = Sw.ProjectTree.GetNextItem(pID, ItemCode.NEXT)
            If IsGroup(pID) Then
                cID = Sw.ProjectTree.GetNextItem(pID, ItemCode.CHILD)
                Do Until cID = ""
                    nID = Sw.ProjectTree.GetNextItem(cID, ItemCode.NEXT)
                    Sw.ProjectTree.SetParent(cID, CurID)
                    cID = nID
                Loop
                Sw.ProjectTree.DeleteItem(pID)
            End If
            pID = mID
        Loop
        Sw.ProjectTree.EnableRedraw(True)
        SetStatus("Đã hoàn tất bỏ nhóm con", IconType.Accept)
    End Sub

    Private Sub MnRemoveNote_Click(sender As Object, e As EventArgs) Handles MnRemoveNote.Click
        Try
            Dim pst() As String = GetSelects()
            Dim cID As String
            Dim cMs As IMessageObject71
            TxNote.Text = ""
            For Each cID In pst
                cMs = Sw.ProjectTree.GetObject(cID).Message
                cMs.MessageID = -1
            Next
        Catch

        End Try

    End Sub

    Private Function IsGroup(cID As String) As Boolean
        Try
            If Sw.ProjectTree.IsLayer(cID) Then Return False
            If Sw.ProjectTree.IsGroup(cID) Then Return True
            Return False
        Catch
            Return False
        End Try

    End Function

    Private Sub MnFire_Click(sender As Object, e As EventArgs) Handles MnFire1.Click, MnFire2.Click, MnFire3.Click, MnFire4.Click,
        MnFire5.Click, MnFire6.Click, MnFire7.Click, MnExp1.Click, MnExp2.Click, MnExp3.Click, MnSmoke1.Click, MnSmoke2.Click, MnSmoke3.Click,
        MnSmoke4.Click, MnSmoke5.Click, MnSmoke6.Click
        Dim cMn As ToolStripMenuItem = sender
        Sw.Command.Execute(1012, cMn.Tag)
    End Sub

    Private Sub AddRaster_Click(sender As Object, e As EventArgs) Handles AddRaster.Click
        Try
            DlgOpen.DefaultExt = "*.tif"
            DlgOpen.Multiselect = True
            DlgOpen.Filter = "Raster images|*.tif"
            If DlgOpen.ShowDialog() = DialogResult.OK Then
                Dim Fns() As String = DlgOpen.FileNames
                Dim pId As String = CurrentGroup()
                Sw.Project.LoadFiles(Fns, pId)
                SetRaster(pId)
            End If
            DlgOpen.Multiselect = False
        Catch ex As Exception
            DlgOpen.Multiselect = False
            SetStatus("Lỗi thêm lớp ảnh nền: " & ex.Message, IconType.Warning)

        End Try
    End Sub
    Private Sub SetRaster(pID As String)
        On Error Resume Next
        Dim cID As String = Sw.ProjectTree.GetNextItem(pID, ItemCode.CHILD)
        Dim cRas As ITerrainRasterLayer71
        Dim cOb As ITerraExplorerObject71
        Dim nColor As IColor71 = Sw.Creator.CreateColor(70, 100, 40, 255)
        While cID <> ""
            cOb = Sw.ProjectTree.GetObject(cID)
            If cOb.ObjectType = ObjectTypeCode.OT_IMAGERY_LAYER Then
                cRas = cOb
                cRas.UseNull = True
                cRas.Visibility.MaxVisibilityDistance = 5000
                cRas.NullValue = &H223322
            End If
            cID = Sw.ProjectTree.GetNextItem(cID, ItemCode.NEXT)
        End While
    End Sub
#Region "Highlight"

    Private Sub TmrHighlight_Tick(sender As Object, e As EventArgs) Handles TmrHighlight.Tick
        On Error Resume Next
        Dim hID As String
        Dim cVal As Boolean
        Dim Pst() As String = MainHighlight.Split(";")
        cVal = Swex.ProjectTree.GetVisibility(Pst(0))
        cVal = Not cVal
        For Each hID In Pst
            Sw.ProjectTree.SetVisibility(hID, cVal)
            Swex.ProjectTree.SetVisibility(hID, cVal)
        Next
    End Sub

    Private Sub StopHighlight()
        On Error Resume Next
        TmrHighlight.Stop()
        If MainHighlight = "" Then Exit Sub
        Dim pSt() As String
        Dim hID As String
        pSt = MainHighlight.Split(";")
        For Each hID In pSt
            If hID <> "" Then
                Sw.ProjectTree.SetVisibility(hID, True)
                Swex.ProjectTree.SetVisibility(hID, True)
            End If
        Next
        BtnStartPresHL.Visible = True
        BtnStopPresHL.Visible = False
    End Sub

    Private Sub StartSelectHL()
        Try
            StopHighlight()
            Dim Pst() As String = GetSelects()
            MainHighlight = Join(Pst, ";")
            If Pst.Length > 0 Then TmrHighlight.Start()
        Catch

        End Try
    End Sub

#End Region

#End Region

#Region "Terra Presentation"

    Private Sub Sw_OnPresentationStatusChanged(PresentationID As String, Status As PresentationStatus) Handles Sw.OnPresentationStatusChanged
        SendEvent("PresentationChanged-" & Status.ToString)
    End Sub

    Private Sub BtnPrivous_Click(sender As Object, e As EventArgs) Handles BtnPrivous.Click
        MainPres.PreviousStep()
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        Try
            Select Case MainPres.PresentationStatus
                Case PresentationStatus.PS_PAUSED
                    MainPres.Resume()
                Case PresentationStatus.PS_NOTPLAYING
                    MainPres.Play(0)
                Case PresentationStatus.PS_WAITINGCLICK
                    MainPres.Continue()
            End Select
        Catch

        End Try
    End Sub

    Private Sub LoadPres(ByVal pID As String)
        Try
            If IsNothing(MainPres) Then GoTo Tiep
            If MainPres.ID = pID Then Exit Sub 'Already get this ID
            MainPres.Stop()
Tiep:
            Dim Mob As ITerraExplorerObject71 = Sw.Creator.GetObject(pID)
            If Mob.ObjectType <> ObjectTypeCode.OT_PRESENTATION Then Exit Sub
            MainPres = Sw.ProjectTree.GetObject(pID)
            MapSplitter.Panel2Collapsed = False
            TabTool.SelectTab(PagePres)
            LbPres.Text = MainPres.TreeItem.Name
            PresTool.Enabled = True
            HLTool.Enabled = True
            LoadSteps()
        Catch ex As Exception
            SetStatus("không thể lấy các đối tượng trình chiếu: " & ex.Message, IconType.Warning)
            MainPres = Nothing
        End Try

    End Sub

    Private Sub GetStep()
        Try
            LvSteps.MultiSelect = False
            LvSteps.Items(MainPres.Steps.Current).Focused = True
            LvSteps.Items(MainPres.Steps.Current).Selected = True
            LoadEffect()
        Catch

        End Try
    End Sub

    Private Sub StopPres()
        Try
            StopCamera()
            StopHighlight()
            MainPres.Stop()
            LvSteps.MultiSelect = True
            SetStatus("Đã dừng trình chiếu!")
        Catch

        End Try
    End Sub

    Private Sub LoadSteps()
        Try
            Dim cStep As IPresentationStep71
            Dim cItem As ListViewItem
            Dim pSt() As String
            Dim cEff As String
            LvSteps.BeginUpdate()
            LvSteps.Items.Clear()
            For Each cStep In MainPres.Steps
                cItem = LvSteps.Items.Add(cStep.ID, Str(cStep.Index + 1), "")
                cItem.SubItems.Add(cStep.Description)
                cEff = Sw.ProjectTree.GetClientData(MainPres.ID, cStep.ID)
                cItem.Tag = getEffect(cEff)
                'Sw.ProjectTree.SetClientData(MainPres.ID, cStep.ID, cItem.Tag)
                'Thêm phương thức chuyển tiếp----
                If cStep.Continue = PresentationStepContinue.PSC_MOUSECLICK Then
                    cItem.SubItems.Add("Kích chuột")
                    cItem.SubItems.Add("")
                Else
                    If cStep.WaitTime = 0 Then
                        cItem.SubItems.Add("Tiếp tục")
                        cItem.SubItems.Add("")
                    Else
                        cItem.SubItems.Add("Chờ")
                        cItem.SubItems.Add(cStep.WaitTime)
                    End If

                End If
                'Đếm số lượng hiệu ứng ---
                If cItem.Tag = "" Then
                    cItem.SubItems.Add("0")
                Else
                    pSt = Split(cItem.Tag, ";")
                    cItem.SubItems.Add(pSt.Length)
                End If
                SetItemBold(cItem, cStep.KeyStep)
            Next
        Catch ex As Exception
            SetStatus("Không thể lấy danh sách các đối tượng trình chiếu: " & ex.Message, IconType.Warning)
        Finally
            LvSteps.EndUpdate()
        End Try

    End Sub

    Private Sub SetItemBold(ByRef mItem As ListViewItem, ByVal mBold As Boolean)
        Dim cFont As Font
        If mBold Then
            cFont = New Font(mItem.Font, FontStyle.Bold)
        Else
            cFont = New Font(mItem.Font, FontStyle.Regular)
        End If
        mItem.Font = cFont
    End Sub

    Private Sub RelistSteps()
        Try

            Dim cItem As ListViewItem
            LvSteps.BeginUpdate()
            For Each cItem In LvSteps.Items
                cItem.Text = cItem.Index + 1
            Next
            LvSteps.EndUpdate()
        Catch

        End Try
    End Sub

    Private Sub ClosePres()
        PresTool.Enabled = False
        HLTool.Enabled = False
        BtnAddPresHL.Enabled = False
        BtnAddPresHL2.Enabled = False
        MainPres = Nothing
        LbPres.Text = "Trình chiếu"
        LbPresState.Visible = False
        LvSteps.Items.Clear()
        LvHighlight.Items.Clear()
    End Sub

    Private Sub SetPresState(nVal As String)
        Try
            Dim cHL As Boolean = TmrHighlight.Enabled
            TmrHighlight.Stop()
            TmrFocus.Enabled = False
            TmrPresWait.Enabled = False
            LvSteps.MultiSelect = False
            Dim cStep As IPresentationStep71 = MainPres.Steps(MainPres.Steps.Current)
            LbPresState.Text = cStep.Index + 1 & " - "
            LbPresState.Visible = True
            Select Case nVal
                Case "PS_WAITINGCLICK", "PS_BEFORE_SWITCHING_TO_ANOTHER_PRESENTATION", "PS_AFTER_SWITCHING_FROM_ANOTHER_PRESENTATION"
                    BtnStep.Visible = True
                    BtnPause.Visible = False
                    BtnPlay.Visible = False
                    LbPresState.Text &= cStep.Description & ": Chờ kích chuột"
                    TmrHighlight.Enabled = cHL
                Case "PS_PAUSED"
                    BtnStep.Visible = False
                    BtnPause.Visible = False
                    BtnPlay.Visible = True
                    LbPresState.Text &= cStep.Description & ": Tạm dừng"
                Case "PS_PLAYING"
                    BtnStep.Visible = False
                    BtnPause.Visible = True
                    BtnPlay.Visible = False
                    TmrFocus.Enabled = True
                    LbPresState.Text &= cStep.Description & ": Đang chuyển đến"

                Case "PS_WAITINGTIME"
                    BtnPause.Visible = True
                    TmrFocus.Enabled = True
                    StartWaiting()
                Case Else
                    StopHighlight()
                    BtnStep.Visible = False
                    BtnPause.Visible = False
                    BtnPlay.Visible = True
                    LvSteps.MultiSelect = True
                    LbPresState.Text = LbPres.Text
                    LbPresState.Visible = False
            End Select
        Catch
        End Try
    End Sub

    Private Sub StartWaiting()
        Dim cStep As IPresentationStep71 = MainPres.Steps(MainPres.Steps.Current)
        LbPresState.Tag = cStep.WaitTime
        TmrPresWait.Enabled = True
    End Sub

    Private Sub BtnRepres_Click(sender As Object, e As EventArgs) Handles BtnRepres.Click
        LoadSteps()
        GetStep()
    End Sub

    Private Sub BtnKeystep_ButtonClick(sender As Object, e As EventArgs) Handles BtnKeystep.Click
        Try
            Dim cItem As ListViewItem = LvSteps.FocusedItem
            Dim cStep As IPresentationStep71 = MainPres.Steps(cItem.Index)
            Dim cVal As Boolean = Not cStep.KeyStep
            cStep.KeyStep = cVal
            SetItemBold(cItem, cVal)
        Catch

        End Try
    End Sub

    Private Sub BtnDelPres_Click(sender As Object, e As EventArgs) Handles BtnDelPres.Click
        Try
            Dim cItem As ListViewItem
            Dim i As Integer
            Dim mRs As MsgBoxResult
            If LvSteps.SelectedItems.Count = 0 Then Exit Sub
            mRs = MsgBox("Xóa các bước trình chiếu ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Trình chiếu")
            If mRs = MsgBoxResult.No Then Exit Sub
            MainPres.Stop()
            For Each cItem In LvSteps.SelectedItems
                i = cItem.Index
                LvSteps.Items.Remove(cItem)
                MainPres.DeleteStep(i)
            Next
            RelistSteps()
        Catch

        End Try

    End Sub

    Private Sub BtnAddPresLocation_Click(sender As Object, e As EventArgs) Handles BtnAddPresLocation.Click
        Try
            Dim cPos As IPosition71 = Sw.Navigate.GetPosition
            Dim cStep As IPresentationStep71
            Dim cItem = New ListViewItem

            Dim cIndex As Integer
            Dim cName As String = Sw.ProjectTree.GetItemName(CurID)
            If cName = "" Then cName = "Location"
            If LvSteps.Items.Count = 0 Then
                cIndex = 0
            Else
                cIndex = LvSteps.FocusedItem.Index + 1
            End If
            MainPres.Stop()
            Application.DoEvents()
            cStep = MainPres.CreateLocationStep(PresentationStepContinue.PSC_MOUSECLICK, 0, cName, cPos)
            MainPres.MoveStepTo(cStep.Index, cIndex)
            cItem.Text = cIndex + 1
            cItem.SubItems.Add(cName)
            cItem.SubItems.Add("Kích chuột")
            cItem.SubItems.Add("")
            cItem.SubItems.Add(0)
            cItem.Tag = ""
            LvSteps.Items.Insert(cIndex, cItem)
            LvSteps.MultiSelect = False
            cItem.Focused = True
            cItem.Selected = True
            LvSteps.MultiSelect = True
            LvSteps.Select()
            If CurObject.Type = MapObject.MapObjectType.Label Then AddPresHL() Else LvHighlight.Items.Clear()
            RelistSteps()
        Catch

        End Try
    End Sub

#Region "Step List"

    Private Sub LvSteps_Click(sender As Object, e As EventArgs) Handles LvSteps.Click
        LoadEffect()
    End Sub

    Private Sub LvSteps_MouseClick(sender As Object, e As MouseEventArgs) Handles LvSteps.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim cItem As ListViewItem = LvSteps.FocusedItem
            Dim i As Integer
            For i = 1 To cItem.SubItems.Count - 1
                If cItem.SubItems(i).Bounds.Contains(e.X, e.Y) Then Exit For
            Next
            StartEditList(i)
        End If
    End Sub

    Private Sub LvSteps_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LvSteps.MouseDoubleClick
        Try
            Dim i As Int32
            i = LvSteps.SelectedItems(0).Index
            MainPres.Stop()
            If My.Computer.Keyboard.ShiftKeyDown = True Then
                MainPres.PlayStep(i)
            Else
                MainPres.Play(i)
            End If
        Catch

        End Try
    End Sub

    Private Sub LvSteps_DragEnter(sender As Object, e As DragEventArgs) Handles LvSteps.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub LvSteps_KeyUp(sender As Object, e As KeyEventArgs) Handles LvSteps.KeyUp
        If e.KeyCode = Keys.F2 Then StartEditList()
    End Sub

    Private Sub LvSteps_ItemDrag(sender As Object, e As ItemDragEventArgs) Handles LvSteps.ItemDrag
        Try
            If MainPres.PresentationStatus <> PresentationStatus.PS_NOTPLAYING Then
                SetStatus("Vui lòng dừng trình chiếu trước khi sắp xếp lại các bước!", IconType.Message)
                Exit Sub
            End If
            LvSteps.DoDragDrop(e.Item, DragDropEffects.Move)
        Catch

        End Try
    End Sub

    Private Sub LvSteps_DragDrop(sender As Object, e As DragEventArgs) Handles LvSteps.DragDrop
        Try
            Dim DragTarget As Integer = LvSteps.InsertionMark.Index
            Dim DragItem As ListViewItem = CType(e.Data.GetData(GetType(ListViewItem)), ListViewItem)
            Dim DropItem As ListViewItem
            Dim OldIndex As Integer = DragItem.Index
            If LvSteps.InsertionMark.Index = -1 Then Exit Sub

            If LvSteps.InsertionMark.AppearsAfterItem Then DragTarget += 1
            DropItem = DragItem.Clone
            LvSteps.Items.Insert(DragTarget, DropItem)
            LvSteps.Items.Remove(DragItem)

            MainPres.MoveStepTo(OldIndex, DropItem.Index)

            RelistSteps()
            DropItem.Selected = True
            LvSteps.Select()
            SaveEffect()
            SetStatus("Đã thay đổi thứ tự trình chiếu")
        Catch ex As Exception
            LvSteps.InsertionMark.Index = -1
            SetStatus("Không thể thay đổi thứ tự trình chiếu: " & ex.Message, IconType.Warning)
        End Try
    End Sub

    Private Sub LvSteps_DragOver(sender As Object, e As DragEventArgs) Handles LvSteps.DragOver
        Try
            Dim TargetPoint As Point = LvSteps.PointToClient(New Point(e.X, e.Y))
            Dim DragTarget As Integer = LvSteps.InsertionMark.NearestIndex(TargetPoint)
            LvSteps.InsertionMark.Index = DragTarget
            If TargetPoint.X > (LvSteps.Width \ 2) Then
                LvSteps.InsertionMark.AppearsAfterItem = True
            Else
                LvSteps.InsertionMark.AppearsAfterItem = False
            End If
            LvSteps.InsertionMark.Color = Drawing.Color.Green
        Catch

        End Try
    End Sub

    Private Sub StartEditList(Optional ByVal sIndex As Integer = 1)
        Try
            If sIndex = 0 Then sIndex = 1
            Dim cItem = LvSteps.FocusedItem.SubItems(sIndex)
            Dim cBnd As Rectangle = cItem.Bounds
            CmbEdit.Items.Clear()
            CmbEdit.Tag = cItem.Text
            Select Case sIndex
                Case 1
                    CmbEdit.DropDownStyle = ComboBoxStyle.Simple
                    CmbEdit.Text = cItem.Text

                Case 2
                    CmbEdit.DropDownStyle = ComboBoxStyle.DropDownList
                    CmbEdit.Items.Add("Kích chuột")
                    CmbEdit.Items.Add("Tiếp tục")
                    CmbEdit.Items.Add("Chờ")
                    CmbEdit.SelectedIndex = CmbEdit.FindStringExact(cItem.Text)
                    CmbEdit.Tag = CmbEdit.SelectedIndex
                Case 3
                    If LvSteps.FocusedItem.SubItems(1).Text <> "Chờ" Then
                        cItem.Text = ""
                        Exit Sub
                    End If
                    CmbEdit.DropDownStyle = ComboBoxStyle.DropDown
                    For i As Integer = 0 To 20
                        CmbEdit.Items.Add(i)
                    Next
                    CmbEdit.Text = cItem.Text
            End Select
            EditSubIndex = sIndex
            CmbEdit.SetBounds(cBnd.X + LvSteps.Left, cBnd.Y + LvSteps.Top, cBnd.Width, cBnd.Height)
            CmbEdit.Visible = True
            CmbEdit.Select()
        Catch

        End Try
    End Sub

    Private Sub CmbEdit_LostFocus(sender As Object, e As EventArgs) Handles CmbEdit.LostFocus
        Try
            CmbEdit.Visible = False
            Dim cStep As IPresentationStep71
            Dim cSub As ListViewItem.ListViewSubItem
            Dim cItem As ListViewItem
            LvSteps.BeginUpdate()
            For Each cItem In LvSteps.SelectedItems
                cSub = cItem.SubItems(EditSubIndex)
                cStep = MainPres.Steps(cItem.Index)
                Select Case EditSubIndex
                    Case 1
                        cStep.Description = CmbEdit.Text
                    Case 2
                        Select Case CmbEdit.SelectedIndex
                            Case 0 'Kích chuột
                                cStep.Continue = PresentationStepContinue.PSC_MOUSECLICK
                            Case 1 'Tiếp tục
                                cStep.Continue = PresentationStepContinue.PSC_WAIT
                                cItem.SubItems(3).Text = ""
                            Case 2 'Chờ
                                cStep.Continue = PresentationStepContinue.PSC_WAIT
                                cItem.SubItems(3).Text = cStep.WaitTime
                        End Select
                    Case 3
                        CmbEdit.Text = Val(CmbEdit.Text)
                        cStep.WaitTime = CmbEdit.Text
                End Select
                cSub.Text = CmbEdit.Text
            Next
        Catch
        Finally
            LvSteps.EndUpdate()
        End Try
    End Sub

    Private Sub CmbEdit_GotFocus(sender As Object, e As EventArgs) Handles CmbEdit.GotFocus
        CmbEdit.SelectAll()
    End Sub

    Private Sub CmbEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEdit.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                LvSteps.Select()
            Case Chr(27)
                If EditSubIndex = 2 Then
                    CmbEdit.SelectedIndex = CmbEdit.Tag
                Else
                    CmbEdit.Text = CmbEdit.Tag
                End If
                LvSteps.Select()
            Case Else
                Exit Select
        End Select
    End Sub

#End Region

#Region "Terra Effect"

    Private Sub SaveEffect()
        On Error Resume Next
        If IsNothing(MainPres) Then Exit Sub
        Dim cItem As ListViewItem
        Dim sEff As String
        For Each cItem In LvSteps.Items
            Dim cStep As IPresentationStep71 = MainPres.Steps(cItem.Index)
            sEff = cItem.Tag
            If sEff = "" Then Continue For
            Sw.ProjectTree.SetClientData(MainPres.ID, cStep.ID, sEff)
        Next
    End Sub

    Private Sub LoadEffect()
        On Error Resume Next
        Dim Pst() As String
        Dim sEff As String
        Dim cName As String
        Dim cID As String
        Dim cEff() As String
        Dim eItem As ListViewItem
        LvHighlight.Items.Clear()
        sEff = LvSteps.FocusedItem.Tag
        'Get Highlight---
        Pst = sEff.Split(";")
        For Each cSt In Pst
            If cSt <> "" Then
                cEff = cSt.Split("-")
                cID = cEff(0)
                cName = Sw.ProjectTree.GetItemName(cID)
                eItem = LvHighlight.Items.Add(cName)
                eItem.Tag = cID
                Select Case cEff(1)
                    Case "0"
                        eItem.SubItems.Add("Nhấp nháy")
                    Case "1"
                        eItem.SubItems.Add("Hiện")
                    Case "2"
                        eItem.SubItems.Add("Ẩn")
                End Select
            End If
        Next
Tiep:
        LvSteps.FocusedItem.SubItems(4).Text = LvHighlight.Items.Count
    End Sub

    Private Sub AddPresHL()
        Try
            Dim pID() As String = GetSelects()
            Dim sItem As ListViewItem = LvSteps.FocusedItem
            Dim sEff As String = sItem.Tag
            Dim cID As String

            If pID.Length = 0 Then Exit Sub
            For Each cID In pID
                If InStr(sEff, cID) = 0 Then sEff += ";" & cID & "-0"
            Next
            sItem.Tag = sEff.TrimStart(";"c)
            LoadEffect()
            Dim cStep As IPresentationStep71 = MainPres.Steps(LvSteps.FocusedItem.Index)
            Sw.ProjectTree.SetClientData(MainPres.ID, cStep.ID, sEff)
            SetStatus("Đã thêm đối tượng nhấp nháy vào bước trình chiếu")
        Catch ex As Exception
            SetStatus("Không thêm được đối tượng nhấp nháy: " & ex.Message, IconType.Warning)
        End Try
    End Sub

    Private Function GetPresHL(Optional ByVal mIndex As Integer = -1) As String
        Try
            Dim sItem As ListViewItem
            If mIndex = -1 Then mIndex = LvSteps.FocusedItem.Index
            sItem = LvSteps.Items(mIndex)
            Dim cSt As String = sItem.Tag
            Dim cHL As String = ""
            Dim cID As String
            Dim Est() As String = cSt.Split(";")
            For Each ce In Est
                If InStr(ce, "-0") Then
                    cID = ce.Replace("-0", "")
                    cHL += ";" & cID
                End If
            Next
            cHL = cHL.TrimStart(";"c)
            Return cHL
        Catch
            Return ""
        End Try
    End Function

    Private Function getEffect(oEff As String) As String
        On Error Resume Next
        If oEff = "" Or oEff = "|" Then Return ""
        If oEff.Contains("-") Then Return oEff 'Nếu là kiểu Effect mới thì bỏ qua
        Dim Pst() As String = oEff.Split("|"c)
        Dim pHL() As String = Pst(0).Split(";"c)
        Dim Rs As New List(Of String)
        Dim cs As String
        For Each cs In pHL
            If Not cs.Contains("-0") Then cs += "-0"
            Rs.Add(cs)
        Next
        If Pst.Length > 1 Then
            Dim pSH() As String = Pst(1).Split(";"c)
            For Each cs In pSH
                If cs.Trim = "" Then Continue For
                If cs.Contains("%") Then
                    cs = cs.Replace("%", "") & "-1"
                Else
                    cs += "-2"
                End If
                Rs.Add(cs)
            Next
        End If
        Return String.Join(";", Rs)

    End Function

    Private Function GetPresSH(Optional ByVal mIndex As Integer = -1) As String
        Try
            Dim cItem As ListViewItem
            If mIndex = -1 Then cItem = LvSteps.FocusedItem Else cItem = LvSteps.Items(mIndex)
            Dim cSt As String = cItem.Tag
            Dim Est() As String = cSt.Split("|")
            Return Est(1)
        Catch
            Return ""
        End Try
    End Function

    Private Sub BtnAddPresHL_Click(sender As Object, e As EventArgs) Handles BtnAddPresHL.Click, BtnAddPresHL2.Click
        AddPresHL()
    End Sub

    Private Sub BtnStartHL_Click(sender As Object, e As EventArgs) Handles BtnStartHL.Click
        StartSelectHL()
    End Sub

    Private Sub StartPresSH(Optional ByVal mIndex As Integer = -1)
        On Error Resume Next
        Dim cSH As String
        If mIndex = -1 Then cSH = LvSteps.FocusedItem.Tag Else cSH = LvSteps.Items(mIndex).Tag
        If cSH = "" Then Exit Sub
        Dim Pst() As String = cSH.Split(";")
        Dim cID As String
        Dim cVal As Boolean = False
        For Each cSt In Pst
            If cSt.Contains("-0") Or cSt = "" Then Continue For
            If cSt.Contains("-1") Then cVal = True
            If cSt.Contains("-2") Then cVal = False
            cID = cSt.Substring(0, cSt.Length - 2)
            Sw.ProjectTree.SetVisibility(cID, cVal)
            Swex.ProjectTree.SetVisibility(cID, cVal)
        Next

    End Sub

    Private Sub StartPresHL(Optional ByVal mIndex As Integer = -1)
        Try
            'StopHighlight()
            MainHighlight = GetPresHL(mIndex)
            If MainHighlight <> "" Then
                BtnStartPresHL.Visible = False
                BtnStopPresHL.Visible = True
                TmrHighlight.Start()
            End If
            LvSteps.FocusedItem.EnsureVisible()
        Catch

        End Try

    End Sub

    Private Sub RemovePresHL()
        Try
            If LvHighlight.Items.Count = 0 Or LvHighlight.SelectedItems.Count = 0 Then Exit Sub
            Dim cHL As String = ""
            Dim sItem As ListViewItem = LvSteps.FocusedItem
            Dim sEff As String = sItem.Tag
            Dim eItem As ListViewItem

            For Each eItem In LvHighlight.SelectedItems
                Dim cID As String = eItem.Tag
                sEff = sEff.Remove(sEff.IndexOf(cID), cID.Length + 2)
                eItem.Remove()
            Next
            sItem.Tag = sEff.Replace(";;", ";")
            sItem.SubItems(4).Text = LvHighlight.Items.Count
            Dim cStep As IPresentationStep71 = MainPres.Steps(LvSteps.FocusedItem.Index)
            Sw.ProjectTree.SetClientData(MainPres.ID, cStep.ID, sEff)
            SetStatus("Đã xóa đối tượng nhấp nháy khỏi trình chiếu")
        Catch ex As Exception
            SetStatus("Không xóa được đối tượng nhấp nháy: " & ex.Message, IconType.Warning)
        End Try
    End Sub

    Private Sub BtnStartPresHL_Click(sender As Object, e As EventArgs) Handles BtnStartPresHL.Click
        StartPresHL()
    End Sub

    Private Sub LvHighlight_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LvHighlight.MouseDoubleClick
        Try
            Dim cItem As ListViewItem = LvHighlight.FocusedItem
            If cItem.SubItems(1).Bounds.Contains(e.X, e.Y) Then
                ChangeEffect()

            Else
                Dim cID = cItem.Tag
                Sw.ProjectTree.SelectItem(cID)
                Sw.Navigate.FlyTo(cID)
            End If
        Catch

        End Try
    End Sub
    Private Sub ChangeEffect()
        Try
            Dim sItem As ListViewItem = LvSteps.FocusedItem
            Dim eItem As ListViewItem = LvHighlight.FocusedItem
            Dim cCell As String = eItem.SubItems(1).Text
            Dim cID As String = eItem.Tag
            Dim sEff = sItem.Tag
            Select Case cCell
                Case "Nhấp nháy"
                    sEff = sEff.Replace(cID & "-0", cID & "-1")
                    eItem.SubItems(1).Text = "Hiện"
                Case "Hiện"
                    sEff = sEff.Replace(cID & "-1", cID & "-2")
                    eItem.SubItems(1).Text = "Ẩn"
                Case "Ẩn"
                    sEff = sEff.Replace(cID & "-2", cID & "-0")
                    eItem.SubItems(1).Text = "Nhấp nháy"
            End Select
            sItem.Tag = sEff
            Dim cStep As IPresentationStep71 = MainPres.Steps(sItem.Index)
            Sw.ProjectTree.SetClientData(MainPres.ID, cStep.ID, sEff)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LvHighlight_MouseClick(sender As Object, e As MouseEventArgs) Handles LvHighlight.MouseClick
        If e.Button = MouseButtons.Right Then ChangeEffect()

    End Sub

    Private Sub btnReLoadEffect_Click(sender As Object, e As EventArgs) Handles btnReLoadEffect.Click
        LoadEffect()
    End Sub

    'Private Sub RemovePresSH()
    '    Try
    '        If LvShowHide.Items.Count = 0 Or LvShowHide.SelectedItems.Count = 0 Then Exit Sub
    '        Dim cSH As String = ""
    '        Dim cItem As ListViewItem
    '        For Each cItem In LvShowHide.SelectedItems
    '            cItem.Remove()
    '        Next
    '        If LvShowHide.Items.Count > 0 Then
    '            For Each cItem In LvHighlight.Items
    '                cSH += ";" & cItem.Tag
    '            Next
    '            cSH = cSH.Remove(0, 1)
    '        End If
    '        SetPresEffect(cSH, 1)
    '        SetStatus("Đã xóa đối tượng nhấp nháy khỏi trình chiếu")
    '    Catch ex As Exception
    '        SetStatus("Không xóa được đối tượng nhấp nháy: " & ex.Message, IconType.Warning)
    '    End Try
    'End Sub
    Private Sub CmdDelPresHL_Click(sender As Object, e As EventArgs) Handles BtnDelPresHL.Click
        RemovePresHL()
    End Sub

#End Region

    Private Sub BtnUpdatePreslocation_Click(sender As Object, e As EventArgs) Handles BtnUpdatePreslocation.Click
        Try
            Dim cStep As IPresentationStep71 = MainPres.Steps(LvSteps.FocusedItem.Index)
            Dim cID As String = cStep.ID
            Dim cOb As ITerraExplorerObject71
            cOb = Sw.Creator.GetObject(cID)
            If cOb.ObjectType = ObjectTypeCode.OT_LOCATION Then
                Dim nlot As ITerrainLocation71
                Dim clot As ITerrainLocation71 = cOb
                nlot = Sw.Creator.CreateLocationHere(Sw.ProjectTree.HiddenGroupID)
                clot.Position = nlot.Position.Copy
                Sw.ProjectTree.DeleteItem(nlot.ID)
                SetStatus("Cập nhật vị trí trình chiếu", IconType.Message)
            End If
        Catch ex As Exception
            SetStatus("Không thể cập nhật vị trí: " & ex.Message, IconType.Warning)
        End Try
    End Sub

    Private Sub TmrPresWait_Tick(sender As Object, e As EventArgs) Handles TmrPresWait.Tick
        Try
            Dim i As Integer
            Dim cStep As IPresentationStep71 = MainPres.Steps(MainPres.Steps.Current)
            i = Val(LbPresState.Tag) - 1
            LbPresState.Text = cStep.Index + 1 & " - " & cStep.Description & ": chờ " & i & "s"
            LbPresState.Tag = i
            If i = 0 Then
                TmrPresWait.Enabled = False
                LbPresState.Text = cStep.Index + 1 & " - " & cStep.Description & ": Tiếp tục trình chiếu..."
            End If
        Catch
            TmrPresWait.Enabled = False
        End Try

    End Sub

    Private Sub BtnStep_Click(sender As Object, e As EventArgs) Handles BtnStep.Click, cmdStep.Click
        TmrHighlight.Stop()
        MainPres.Continue()
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        MainPres.Pause()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        StopPres()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        MainPres.NextStep()
    End Sub

    Private Sub Sw_OnBeforePresentationItemActivation(PresentationID As String, [Step] As IPresentationStep71) Handles Sw.OnBeforePresentationItemActivation
        SendEvent("StepBegin-" & PresentationID & "-" & [Step].Index)
    End Sub

    Private Sub TmrFocus_Tick(sender As Object, e As EventArgs) Handles TmrFocus.Tick
        Me.Activate()
    End Sub

    Private Sub Sw_OnPresentationFlyToReachedDestination(PresentationID As String, [Step] As IPresentationStep71) Handles Sw.OnPresentationFlyToReachedDestination
        SendEvent("StepReached-" & PresentationID & "-" & [Step].Index)
    End Sub

#End Region

#Region "Terra Data"

    Private Sub AddSource(mDir As String)

        Try
            For Each sDir As String In LstSource.Items
                If mDir = sDir Then Exit Sub
            Next
            Dim sFile As String = My.Application.Info.DirectoryPath & "\Source.txt"
            Dim sw As StreamWriter
            sw = File.AppendText(sFile)
            sw.WriteLine(mDir)
            LstSource.Items.Add(mDir)
            sw.Close()
        Catch ex As Exception
            SetStatus("Không thêm được thư mục nguồn này: " & ex.Message, IconType.Warning)
        End Try

    End Sub

    Private Sub SaveSource()
        Dim sFile As String = AppPath & "\Source.txt"
        Try
            Dim sw As New StreamWriter(sFile, False)
            Dim cs As String
            For Each cs In LstSource.Items
                sw.WriteLine(cs)
            Next
            sw.Close()
        Catch ex As Exception
            SetStatus("Không lưu được các thư mục nguồn: " & ex.Message, IconType.Warning)
        End Try
    End Sub

    Private Sub LoadSource()
        Dim sFile As String = AppPath & "\Source.txt"
        SetStatus("Nạp danh sách thư mục nguồn", IconType.Message)
        Try
            Dim sr As New StreamReader(sFile)
            Dim cs As String
            LstSource.Items.Clear()
            Do Until sr.EndOfStream
                cs = sr.ReadLine
                LstSource.Items.Add(cs)
            Loop
            sr.Close()
        Catch

        End Try
    End Sub

    Private Sub CmdAddSource_Click(sender As Object, e As EventArgs) Handles CmdAddSource.Click
        Dim dRs As DialogResult

        dRs = DlgFolder.ShowDialog()
        If dRs = DialogResult.OK Then
            AddSource(DlgFolder.SelectedPath)
            SaveSetting(AppTitle, "Last Path", "Source", DlgFolder.SelectedPath)
        End If
    End Sub

    Private Sub CmdDelSource_Click(sender As Object, e As EventArgs) Handles CmdDelSource.Click
        For i As Integer = LstSource.SelectedItems.Count - 1 To 0 Step -1
            LstSource.Items.Remove(LstSource.SelectedItems(i))
        Next i
        SaveSource()
    End Sub

    Private Sub BtnFileCheck_Click(sender As Object, e As EventArgs) Handles BtnFileCheck.Click
        If BwCheckfile.IsBusy Then Exit Sub
        SetStatus("Đang kiểm tra tập tin...", IconType.Find)
        LvFile.Items.Clear()
        LvFile.Refresh()
        PrgBar.Maximum = 100
        PrgBar.Value = 0
        PrgBar.Visible = True
        BwCheckfile.RunWorkerAsync()
    End Sub

    Private Sub BtnFileFix_Click(sender As Object, e As EventArgs) Handles BtnFileFix.Click
        If BwFixFile.IsBusy Then Exit Sub
        If LstSource.Items.Count = 0 Then
            MsgBox("Vui lòng thêm thư mục nguồn chứa dữ liệu", vbExclamation, "Sửa lỗi dữ liệu")
        Else
            SetStatus("Đang tìm sửa tập tin nguồn...", IconType.Find)
            PrgBar.Maximum = 100
            PrgBar.Value = 0
            PrgBar.Visible = True
            BwFixFile.RunWorkerAsync()
        End If
    End Sub

    Private Sub LvFile_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LvFile.MouseDoubleClick
        Dim cID As String = LvFile.FocusedItem.Tag
        Sw.Navigate.FlyTo(cID)
    End Sub

    Private Sub BwCheckfile_DoWork(sender As Object, e As DoWorkEventArgs) Handles BwCheckfile.DoWork
        Dim mOb As New MapObject(Sw)
        Dim cDr As String
        Dim cItem As ListViewItem
        Dim cID As String = Sw.ProjectTree.RootID
        Dim pID() As String = {cID}
        Dim Cnt As Integer = 0
        Dim i As Integer = 0

        Try
            Do
                'Lay phan tu con dau tien---
                cID = Sw.ProjectTree.GetNextItem(pID(i), ItemCode.CHILD)
                Do Until cID = ""
                    mOb.SetID(cID)
                    If mOb.Type = MapObject.MapObjectType.Other And Sw.ProjectTree.IsGroup(cID) Then 'Them thu muc
                        Cnt += 1
                        ReDim Preserve pID(Cnt)
                        pID(Cnt) = cID
                    End If
                    cDr = mOb.FileName
                    If Not IsNothing(cDr) Then
                        If cDr = "" Then
                            'Nếu mục file name rỗng
                        Else
                            If (Not File.Exists(cDr)) Then 'Nếu tập tin không tồn tại
                                cItem = LvFile.Items.Add("")
                                cItem.Tag = cID
                                cItem.ImageIndex = 5
                                cItem.SubItems.Add(mOb.ItemName)
                                cItem.SubItems.Add(mOb.FileName)
                                cItem.Focused = True
                                cItem.EnsureVisible()
                            End If
                        End If
                    End If

                    cID = Sw.ProjectTree.GetNextItem(cID, ItemCode.NEXT)

                Loop
                If Not Exitting Then BwCheckfile.ReportProgress(i * 100 \ (Cnt + 1))
                i += 1
            Loop Until i > Cnt
        Catch

        End Try

    End Sub

    Private Sub BwCheckfile_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BwCheckfile.ProgressChanged
        PrgBar.Value = e.ProgressPercentage
    End Sub

    Private Sub BwCheckfile_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BwCheckfile.RunWorkerCompleted
        PrgBar.Visible = False
        SetStatus("Đã kiểm tra tập tin xong", IconType.Accept)
    End Sub

    Private Sub BwFixFile_DoWork(sender As Object, e As DoWorkEventArgs) Handles BwFixFile.DoWork
        Dim mOb As New MapObject(Sw)
        Dim sFn As String
        Dim sDr As String
        Dim cItem As ListViewItem
        Dim st As String
        Try

            For Each cItem In LvFile.Items
                If cItem.ImageIndex = IconType.Accept Then Continue For
                mOb.SetID(cItem.Tag)
                st = mOb.FileName
                st = Replace(st, "G:\", "D:\")
                mOb.FileName(st)
                cItem.ImageIndex = IconType.Accept
                sFn = cItem.SubItems(1).Text
                sFn = Path.GetFileName(sFn)
                cItem.Focused = True
                cItem.EnsureVisible()
                For Each sDr In LstSource.Items
                    st = sDr & "\"
                    Dim dFn() As String = Directory.GetFiles(st, sFn, SearchOption.AllDirectories)
                    If dFn.Length > 0 Then
                        mOb.SetID(cItem.Tag)
                        mOb.FileName(dFn(0))
                        cItem.ImageIndex = IconType.Accept
                        cItem.SubItems(1).Text = dFn(0)
                        Exit For
                    End If
                Next
                If Not Exitting Then BwFixFile.ReportProgress(cItem.Index * 100 \ LvFile.Items.Count)
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BwFixFile_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BwFixFile.ProgressChanged
        PrgBar.Value = e.ProgressPercentage
    End Sub

    Private Sub BwFixFile_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BwFixFile.RunWorkerCompleted
        PrgBar.Visible = False
        SetStatus("Quá trình tìm sửa lỗi hoàn tất", IconType.Accept)
    End Sub

#End Region

#Region "Terra Signs"

    Private mp As Point
    Private np As Point
    Private BackupList As List(Of ListViewItem)
    Private WithEvents CurSign As SignObject = Nothing
    Private ReadOnly Psc() As Single = {20, 12, 6, 3.5, 2.5, 2, 1} '250,100,50,25,10,5,10

#Region "Load Signs"


    Private Sub LoadSigns()
        If BwLoadSign.IsBusy Then Exit Sub
        SetStatus("Đang nạp danh sách ký hiệu quân sự...", IconType.Wait)
        PrgBar.Maximum = 100
        PrgBar.Visible = True
        LvSign.Visible = False
        CurSign = New SignObject(PicSign, Sw)
        CbSignScale.SelectedIndex = 0
        LoadSignCombo()
        BwLoadSign.RunWorkerAsync()
    End Sub

    Private Sub LoadSignCombo()
        Dim i As Integer
        Dim st As String
        cbSignGroup.Items.Add("Tất cả")
        For i = 0 To LvSign.Groups.Count - 1
            st = LvSign.Groups(i).Header
            cbSignGroup.Items.Add(st)
        Next
    End Sub

    Private Sub AddImagelist(fn As String)
        Dim bm As New Bitmap(fn)
        Dim im As New Bitmap(48, 48)
        Dim gp As Graphics = Graphics.FromImage(im)
        Dim h As Integer = bm.Size.Height
        Dim w As Integer = bm.Size.Width
        Dim s As Integer = ImgLarge.ImageSize.Height
        If h > w Then
            w = s * w / h
            h = s
        Else
            h = s * h / w
            w = s
        End If
        gp.DrawImage(bm, s - w, s - h, w, h)
        ImgLarge.Images.Add(fn, im)
    End Sub

    Private Sub BwLoadSign_DoWork(sender As Object, e As DoWorkEventArgs) Handles BwLoadSign.DoWork
        Dim dt As DataTable
        Dim dr As DataRow
        Dim fn As String
        Dim gr As String
        Dim tn As String
        Dim ct As ListViewItem
        Try
            dt = Filldata("SELECT * FROM KHQS")
            For Each dr In dt.Rows
                fn = AppPath & "\KHQS\" & dr("TenFile").ToString
                If Not File.Exists(fn) Then Continue For
                AddImagelist(fn)
                gr = dr("MaNhom").ToString
                tn = dr("TenKH").ToString
                ct = LvSign.Items.Add(tn, fn)
                ct.Tag = dr("TamKH")
                ct.Group = LvSign.Groups(gr)
                If Not Exitting Then BwLoadSign.ReportProgress(ct.Index * 100 \ dt.Rows.Count)
            Next
            BackupSignlist()
            cbSignGroup.SelectedIndex = 0
            GrSignlist.Enabled = True
            dt.Dispose()
        Catch ex As Exception
            SetStatus("Lỗi khi tải danh sách ký hiệu" & vbCrLf & ex.Message, IconType.Exclamation)
        End Try

    End Sub

    Private Sub BwLoadSign_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BwLoadSign.ProgressChanged
        Try
            PrgBar.Value = e.ProgressPercentage
        Catch
            BwLoadSign.CancelAsync()
        End Try
    End Sub

    Private Sub BwLoadSign_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BwLoadSign.RunWorkerCompleted
        PrgBar.Visible = False
        LvSign.Visible = True
        GrSign.Enabled = True
        SetParent(LbSignCap, PicSign)
        SetStatus("Đã nạp xong danh sách ký hiệu quân sự", IconType.Accept)
    End Sub

    Private Sub cbSignGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSignGroup.SelectedIndexChanged

        Try
            If cbSignGroup.SelectedIndex = 0 Then
                RestoreSignlist()
            Else
                LvSign.Items.Clear()

                For Each cItem As ListViewItem In BackupList
                    If cItem.Group.Header = cbSignGroup.Text Then
                        LvSign.Items.Add(cItem.Clone)
                    End If
                Next
            End If
        Catch
        End Try
    End Sub

    Private Sub TxtFind_LostFocus(sender As Object, e As EventArgs) Handles TxtFind.LostFocus
        FindSignlist(TxtFind.Text)
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyValue = 13 Then FindSignlist(TxtFind.Text)
    End Sub

#End Region

    Private Overloads Sub DrawPivot(mP As Byte)
        Try
            Dim bm As New Bitmap(60, 60)
            Dim im As Image = ImgSmall.Images("Pivot")
            Dim Grp As Graphics = Graphics.FromImage(bm)
            Dim x As Integer
            Dim y As Integer
            Select Case mP
                Case 1, 2, 3
                    x = mP * 20 - 20
                    y = 0
                Case 5, 6, 7
                    x = (7 - mP) * 20
                    y = 40
                Case 4, 8
                    y = 20
                    x = Abs(mP - 8) / 2 * 20
                Case 9
                    x = 20
                    y = 20
                Case Else
                    Exit Select
            End Select
            x += 2
            y += 2
            Grp.DrawImage(im, x, y)
            PicPivot.Image = bm
            CurSign.Pivot = mP
        Catch

        End Try
    End Sub

    Private Overloads Sub DrawPivot(ByVal x As Integer, ByVal y As Integer)
        Try
            'Get Pivot Number
            Dim pa = {{1, 8, 7}, {2, 9, 6}, {3, 4, 5}}
            x \= 20
            y \= 20
            Dim pv As Byte = pa(x, y)
            DrawPivot(pv)
        Catch

        End Try
    End Sub

    Private Sub LvSign_Click(sender As Object, e As EventArgs) Handles LvSign.Click
        Dim cItem As ListViewItem = LvSign.FocusedItem
        TxSignName.Text = cItem.Text & " " & TxSignCap.Text
        CurSign.Name = TxSignName.Text
        CurSign.ImageFile = cItem.ImageKey
        DrawPivot(cItem.Tag)
        CurSign.Redraw()
    End Sub

    Private Sub TxtColor_Click(sender As Object, e As EventArgs) Handles TxtColor5.Click, TxtColor4.Click, TxtColor3.Click, TxtColor2.Click, TxtColor1.Click
        Dim c As TextBox = sender
        If Control.ModifierKeys = Keys.Shift Then
            DlgColor.Color = c.BackColor
            If DlgColor.ShowDialog() = DialogResult.OK Then
                If SignObject.CheckColor(DlgColor.Color) > 0 Then
                    SetStatus("Màu chọn không hợp lệ!", IconType.Warning)
                    Exit Sub
                End If
                c.BackColor = DlgColor.Color
            End If
        End If
        CurSign.SecondColor = c.BackColor
        CurSign.Redraw()
    End Sub

    Private Sub PicPivot_MouseClick(sender As Object, e As MouseEventArgs) Handles PicPivot.MouseClick
        DrawPivot(e.X, e.Y)
    End Sub

    Private Sub NrFont_ValueChanged(sender As Object, e As EventArgs) Handles NrFont.ValueChanged
        If IsNothing(CurSign) Then Exit Sub
        CurSign.FontSize = NrFont.Value
        CurSign.Redraw()
    End Sub

    Private Sub TxSign_TextChanged(sender As Object, e As EventArgs) Handles TxSignCap.TextChanged
        If IsNothing(CurSign) Then Exit Sub
        CurSign.Caption = TxSignCap.Text
        LbSignCap.Text = TxSignCap.Text

    End Sub

    Private Sub PicSign_MouseDown(sender As Object, e As MouseEventArgs) Handles PicSign.MouseDown
        If CurSign.Caption = "" Then Exit Sub
        PicSign.Cursor = Cursors.Cross
        mp = e.Location
        Dim s As Single = CurSign.ThumbScale
        LbSignCap.Font = New Font("UTM HelvetIns", NrFont.Value / s * 3)
        LbSignCap.BackColor = Color.Transparent
        If CurSign.Team = 0 Then LbSignCap.ForeColor = Color.Black Else LbSignCap.ForeColor = CurSign.PrimaryColor
        LbSignCap.Refresh()
        Dim x As Integer = CurSign.TextPos.X - LbSignCap.Width \ 2
        Dim y As Integer = CurSign.TextPos.Y - LbSignCap.Height \ 2
        LbSignCap.Location = New Point(x, y)
        np = LbSignCap.Location
        LbSignCap.Visible = True
    End Sub

    Private Sub PicSign_MouseMove(sender As Object, e As MouseEventArgs) Handles PicSign.MouseMove
        If e.Button = MouseButtons.Left Then LbSignCap.Location = np + e.Location - mp
    End Sub

    Private Sub PicSign_MouseUp(sender As Object, e As MouseEventArgs) Handles PicSign.MouseUp
        Dim x As Integer = LbSignCap.Left + LbSignCap.Width \ 2
        Dim y As Integer = LbSignCap.Top + LbSignCap.Height \ 2
        CurSign.TextPos = New Point(x, y)
        CurSign.Redraw()
        LbSignCap.Visible = False
        PicSign.Cursor = Cursors.Default
    End Sub

    Private Function Sw_OnLButtonDblClk(Flags As Integer, X As Integer, Y As Integer) As Boolean Handles Sw.OnLButtonDblClk
        Dim ipm As MouseInputMode = Sw.Window.GetInputMode
        If ipm = MouseInputMode.MI_COM_CLIENT Then CurSign.AddtoMap(X, Y)
        Return Nothing
    End Function

    Private Sub RdDich_Click(sender As Object, e As EventArgs) Handles RdDich.Click
        CkFlip.Checked = True
        CurSign.Team = 1
        CurSign.Flip = True
        CurSign.PrimaryColor = Color.Blue
        CurSign.Redraw()
    End Sub

    Private Sub RdTa_Click(sender As Object, e As EventArgs) Handles RdTa.Click
        CurSign.Flip = False
        CkFlip.Checked = False
        CurSign.Team = 0
        CurSign.PrimaryColor = Color.Red
        CurSign.Redraw()
    End Sub

    Private Sub RdKhac_Click(sender As Object, e As EventArgs) Handles RdKhac.Click
        CurSign.Team = 2
        CurSign.PrimaryColor = TxMainColor.BackColor
        CurSign.Redraw()
    End Sub

    Private Sub CmdSaveSign_Click(sender As Object, e As EventArgs) Handles CmdSaveSign.Click
        If CurSign.SaveSign() Then
            SetStatus("Đã lưu ký hiệu", IconType.Accept)
        Else
            SetStatus("Không lưu được ký hiệu...", IconType.Warning)
        End If
    End Sub

    Private Sub CurSign_ChangedID() Handles CurSign.ChangedID
        Select Case CurSign.Team
            Case 0
                RdTa.Checked = True
                RdDich.Checked = False
            Case 1
                RdDich.Checked = True
                RdTa.Checked = False
            Case Else
                Exit Select
        End Select
        TxMainColor.BackColor = CurSign.PrimaryColor
        TxSignName.Text = CurSign.Name
        TxSignCap.Text = CurSign.Caption
        If CurSign.Caption = "" Then CkCap.Checked = False Else CkCap.Checked = True
        TxSignCap.Enabled = CkCap.Checked
        DrawPivot(CurSign.Pivot)
        CmdSaveSign.Enabled = True
    End Sub

    Private Sub Ck2D_CheckedChanged(sender As Object, e As EventArgs) Handles Ck2D.CheckedChanged
        CurSign.is2D = Ck2D.Checked
    End Sub

    Private Sub FlipCaption()
        Dim x As Integer = CurSign.TextPos.X
        Dim y As Integer = CurSign.TextPos.Y
        Dim m As Integer = PicSign.Width \ 2
        If x < m Then
            x += (m - x) * 2
        Else
            x -= (x - m) * 2
        End If
        CurSign.TextPos = New Point(x, y)
    End Sub

    Private Sub FlipPivot()
        Dim c As Byte
        Select Case CurSign.Pivot
            Case 5
                c = 7
            Case 7
                c = 5
            Case 4
                c = 8
            Case 8
                c = 4
            Case 1
                c = 3
            Case 3
                c = 1
        End Select
        DrawPivot(c)
    End Sub

    Private Sub TxSignName_TextChanged(sender As Object, e As EventArgs) Handles TxSignName.TextChanged
        CurSign.Name = TxSignName.Text
    End Sub

    Private Sub AddSigntoCenter()
        Try
            Dim ct As IWorldPointInfo71 = Sw.Window.CenterPixelToWorld
            Dim cw As IScreenPointInfo71 = Sw.Window.PixelFromWorld(ct.Position)
            If CurSign.AddtoMap(cw.X, cw.Y) Then
                SetStatus("Đã thêm ký hiệu vào bản đồ", IconType.Accept)
            Else
                SetStatus("Không thêm được ký hiệu...", IconType.Warning)
            End If
        Catch ex As Exception
            SetStatus("Không thêm được ký hiệu: " & ex.Message, IconType.Warning)
        End Try

    End Sub

    Private Sub CbSignScale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbSignScale.SelectedIndexChanged
        If IsNothing(CurSign) Then Exit Sub
        Dim i As Integer = CbSignScale.SelectedIndex
        CurSign.Scale = Psc(i)
    End Sub

    Private Sub CkCap_CheckedChanged(sender As Object, e As EventArgs) Handles CkCap.CheckedChanged

    End Sub

    Private Sub TxSignCap_LostFocus(sender As Object, e As EventArgs) Handles TxSignCap.LostFocus
        CurSign.Redraw()
    End Sub

    Private Sub CmdFlySign_Click(sender As Object, e As EventArgs) Handles CmdAddSign.Click
        CurSign.Redraw()
    End Sub

    Private Sub TxMainColor_Click(sender As Object, e As EventArgs) Handles TxMainColor.Click
        Dim c As TextBox = sender

        DlgColor.Color = c.BackColor
        If DlgColor.ShowDialog() = DialogResult.OK Then
            RdKhac.Checked = True
            c.BackColor = DlgColor.Color
            CurSign.Team = 3
            CurSign.PrimaryColor = c.BackColor
            CurSign.Redraw()
        End If

    End Sub

    Private Sub CkCap_Click(sender As Object, e As EventArgs) Handles CkCap.Click
        If IsNothing(CurSign) Then Exit Sub
        If CkCap.Checked Then
            CurSign.Caption = TxSignCap.Text
        Else
            CurSign.Caption = ""
        End If
        TxSignCap.Enabled = CkCap.Checked
        CurSign.Redraw()
    End Sub

    Private Sub CkFlip_Click(sender As Object, e As EventArgs) Handles CkFlip.Click
        CurSign.Flip = CkFlip.Checked
        FlipPivot()
        FlipCaption()
        CurSign.Redraw()
    End Sub

    Private Sub PicPivot_Click(sender As Object, e As EventArgs) Handles PicPivot.Click

    End Sub

    Private Sub BtnAddPoly_ButtonClick(sender As Object, e As EventArgs) Handles BtnAddArrow.Click, BtnAddPoly.ButtonClick, BtnAddCircle.Click, BtnAddLine.Click, BtnAddRec.Click
        Dim i As Integer = 0
        i = sender.tag
        Sw.Command.Execute(1012, i)
    End Sub

#Region "Map Control"

    Private Yaw As Double = 0
    Private ScreenPosition As IPosition71
    Private Pitch As Double
    Private Radius As Double
    Private Angle As Double
    Private Speed As Double
    Private Zoom As Double
    Private Go As Double
    Private Delta As Double = 0.07
    Private MarkPoint As Point

    'Private Sub GetCoordinate()
    'Dim cPos As IPosition71 = Sw.Navigate.GetPosition(AltitudeTypeCode.ATC_TERRAIN_ABSOLUTE)
    'TxX.Text = cPos.X
    'TxY.Text = cPos.Y
    'TxZ.Text = cPos.Altitude
    'TxYaw.Text = cPos.Yaw
    'TxRoll.Text = cPos.Roll
    'TxPitch.Text = cPos.Pitch
    'End Sub
    'Private Sub CmdSlide_Click(sender As Object, e As EventArgs)
    '    Sw.Command.Execute(1050, 0)
    'End Sub

    'Private Sub CmdNorth_Click(sender As Object, e As EventArgs)
    '    Sw.Command.Execute(1056, 0)
    'End Sub
    'Private Sub CmdRotate_Click(sender As Object, e As EventArgs)
    '    If My.Computer.Keyboard.ShiftKeyDown Then
    '        Yaw = -0.2
    '        TmrFollow.Start()
    '        Exit Sub
    '    End If
    '    If TmrFollow.Enabled Then
    '        Yaw = 0
    '        TmrFollow.Stop()
    '    Else
    '        Yaw = 0.2
    '        TmrFollow.Start()
    '    End If

    'End Sub

    Private Sub CmdRotateLeft_MouseClick(sender As Object, e As MouseEventArgs) Handles CmdRotateLeft.MouseClick
        If Yaw <> Delta Then
            Yaw = Delta
            CmdRotateLeft.BackColor = Color.PaleGreen
            CmdRotateRight.BackColor = Color.White
            TmrFollow.Start()

        Else
            Yaw = 0
            CmdRotateLeft.BackColor = Color.White
        End If
    End Sub

    Private Sub CmdRotateRight_MouseClick(sender As Object, e As MouseEventArgs) Handles CmdRotateRight.MouseClick
        If Yaw <> -Delta Then
            Yaw = -Delta
            CmdRotateRight.BackColor = Color.PaleGreen
            CmdRotateLeft.BackColor = Color.White
            TmrFollow.Start()

        Else
            Yaw = 0
            CmdRotateRight.BackColor = Color.White
        End If
    End Sub

    Private Sub CmdUp_MouseClick(sender As Object, e As MouseEventArgs) Handles CmdUp.MouseClick
        If Pitch <> -Delta Then
            Pitch = -Delta
            CmdUp.BackColor = Color.PaleGreen
            CmdDown.BackColor = Color.White
            TmrFollow.Start()

        Else
            Pitch = 0
            CmdUp.BackColor = Color.White
        End If
    End Sub

    Private Sub CmdDown_MouseClick(sender As Object, e As MouseEventArgs) Handles CmdDown.MouseClick
        If Pitch <> Delta Then
            Pitch = Delta
            CmdDown.BackColor = Color.PaleGreen
            CmdUp.BackColor = Color.White
            TmrFollow.Start()
        Else
            Pitch = 0
            CmdDown.BackColor = Color.White
        End If
    End Sub

    Private Sub CmdZoomOut_MouseClick(sender As Object, e As MouseEventArgs) Handles CmdZoomOut.MouseClick
        If Zoom <> Delta Then
            Zoom = Delta
            CmdZoomOut.BackColor = Color.PaleGreen
            CmdZoomIn.BackColor = Color.White
            TmrFollow.Start()
        Else
            Zoom = 0
            CmdZoomOut.BackColor = Color.White
        End If
    End Sub

    Private Sub CmdZoomIn_MouseClick(sender As Object, e As MouseEventArgs) Handles CmdZoomIn.MouseClick
        If Zoom <> -Delta Then
            Zoom = -Delta
            TmrFollow.Start()
            CmdZoomIn.BackColor = Color.PaleGreen
            CmdZoomOut.BackColor = Color.White
        Else
            Zoom = 0
            CmdZoomIn.BackColor = Color.White
        End If
    End Sub

    Private Sub CmdGo_MouseClick(sender As Object, e As MouseEventArgs) Handles CmdGo.MouseClick
        TmrFollow.Interval = 15
        If Go = 0 Then
            Go = 0.0000001 * Delta
            CmdGo.BackColor = Color.PaleGreen
            TmrFollow.Start()
        Else
            Go = 0
            CmdGo.BackColor = Color.White
        End If
    End Sub

    Private Sub TmrFollow_Tick(sender As Object, e As EventArgs) Handles TmrFollow.Tick
        SetFollow()
    End Sub

    Private Sub SetFollow()
        Try
            If (Yaw = 0 And Pitch = 0 And Zoom = 0 And Go = 0) Or My.Computer.Keyboard.ShiftKeyDown Then 'Dừng nếu không có tham số quay
                TmrFollow.Stop()
                Exit Sub
            End If
            Dim cPos As IPosition71 = Sw.Navigate.GetPosition(AltitudeTypeCode.ATC_TERRAIN_ABSOLUTE) 'Vị trí của camera
            Dim sPos As IPosition71 = Sw.Window.CenterPixelToWorld.Position() 'Vị trí tâm màn hình (screen)
            Dim r As Double
            Dim x As Double
            Dim y As Double
            Dim a As Double
            Dim dx As Double
            Dim dy As Double

            'Lấy bán kính mặt cắt ngang (khoảng cách từ chân camera đến
            r = (cPos.X - sPos.X) ^ 2 + (cPos.Y - sPos.Y) ^ 2
            r = Sqrt(r)
            ' Lay góc ngang
            a = cPos.Yaw * PI / 180
            ' Lay khoảng cách X, Y từ camera đến tâm bản đồ
            x = r * Sin(a)
            y = r * Cos(a)
            'Tim vi tri xoay---
            If Yaw <> 0 Or Go <> 0 Then
                dx = x
                dy = y
                r -= Go * cPos.Altitude
                cPos.Yaw += Yaw
                a = cPos.Yaw * PI / 180
                x = r * Sin(a)
                y = r * Cos(a)
                dx -= x
                dy -= y
                cPos.X += dx
                cPos.Y += dy
            End If
            'Tim vi tri Pitch---
            If Pitch <> 0 Or Zoom <> 0 Then
                Dim d1 As Double
                Dim d2 As Double
                Dim z As Double
                a = (360 - cPos.Pitch) * PI / 180 'Lay goc doc
                r = cPos.Altitude / Sin(a)
                d1 = r * Cos(a)
                r += Zoom * (cPos.Altitude / 25)
                If r < 100 Then r = 100
                cPos.Pitch += Pitch
                If cPos.Pitch <= 270.1 Then GoTo Tiep
                a = (360 - cPos.Pitch) * PI / 180
                z = r * Sin(a)
                d2 = r * Cos(a)

                dx = x * d2 / d1 'Tinh khoang X,Y tu vi tri mói tới tâm
                dy = y * d2 / d1

                dx = x - dx ' Tính độ lệch 2 vị trí cũ và mới
                dy = y - dy

                cPos.Altitude = z
                cPos.X += dx
                cPos.Y += dy
            End If
Tiep:
            Sw.Navigate.SetPosition(cPos)
        Catch ex As Exception
            SetStatus(ex.Message, IconType.Warning)
            StopCamera()
        End Try

    End Sub
    Private Sub CmdStop_MouseClick(sender As Object, e As MouseEventArgs) Handles CmdStop.MouseClick
        StopHighlight()
        StopCamera(True)
        Dim cmd As Button
        For Each cmd In GrControl.Controls.OfType(Of Button)()
            cmd.BackColor = Color.White
        Next
    End Sub

    Private Sub StopCamera(Optional ByVal StopNavigate As Boolean = False)
        On Error Resume Next
        Yaw = 0
        Pitch = 0
        Zoom = 0
        Go = 0
        TmrFollow.Stop()
        TmrControl.Stop()
        If StopNavigate Then Sw.Navigate.Stop()
    End Sub

    Private Sub PicControl_MouseMove(sender As Object, e As MouseEventArgs) Handles PicControl.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim r As Double
            Dim dX As Double = e.X - MarkPoint.X
            Dim dY As Double = MarkPoint.Y - e.Y
            r = dX ^ 2 + dY ^ 2
            Speed = CInt(Sqrt(r)) / 200000
            Angle = Math.Atan2(dY, dX)
            'drawing---
            Dim bm As New Bitmap(PicControl.Width, PicControl.Height)
            Dim Gph As Graphics = Graphics.FromImage(bm)
            Dim p As New Pen(Color.Black, 2)
            Gph.DrawEllipse(p, MarkPoint.X - 2, MarkPoint.Y - 2, 4, 4)
            Gph.DrawLine(p, MarkPoint.X, MarkPoint.Y, e.X, e.Y)
            PicControl.Image = bm

        End If
    End Sub

    Private Sub PicControl_MouseDown(sender As Object, e As MouseEventArgs) Handles PicControl.MouseDown
        MarkPoint.X = e.X
        MarkPoint.Y = e.Y
        PicControl.Cursor = Cursors.SizeAll
        TmrControl.Start()
    End Sub

    Private Sub PicControl_MouseUp(sender As Object, e As MouseEventArgs) Handles PicControl.MouseUp
        Speed = 0
        PicControl.Image = Nothing
        PicControl.Cursor = Cursors.Default
        TmrControl.Stop()
    End Sub

    Private Sub TmrControl_Tick(sender As Object, e As EventArgs) Handles TmrControl.Tick
        Dim cPos As IPosition71 = Sw.Navigate.GetPosition(AltitudeTypeCode.ATC_TERRAIN_ABSOLUTE)
        Dim x As Double
        Dim y As Double
        Dim r As Double = Speed * cPos.Altitude / 10000
        Dim a As Double = Angle - (cPos.Yaw * PI / 180)
        y = r * Sin(a)
        x = r * Cos(a)
        cPos.X += x
        cPos.Y += y
        Sw.Navigate.SetPosition(cPos)
    End Sub

    Private Sub CmdStartHL_Click(sender As Object, e As EventArgs) Handles CmdStartHL.Click
        On Error Resume Next
        If My.Computer.Keyboard.ShiftKeyDown Then
            StartPresHL()
        Else

            If (CurID <> MainPres.ID) And LvHighlight.Items.Count = 0 Then
                StartSelectHL()
            Else
                StartPresHL()
            End If
        End If
    End Sub

    Private Sub CmdStopHL_Click(sender As Object, e As EventArgs) Handles CmdStopHL.Click, btnStopHL.Click, BtnStopPresHL.Click
        StopHighlight()
    End Sub

    Private Sub tbrRate_Scroll(sender As Object, e As EventArgs) Handles tbrRate.Scroll
        Delta = tbrRate.Value / 100
    End Sub
#End Region

#End Region

#Region "Terra Note"

    Private cNote As IPopupMessage71
    Private cMessage As IMessageObject71
    Private sMessage As IMessageObject71
    Private sNote As IPopupMessage71

    Private Sub GetNote(Optional cID As String = "")
        Try
            If cID = "" Then cID = CurID
            cMessage = Sw.ProjectTree.GetObject(cID).Message
            cNote = cMessage.GetMessageObject
            cNote.Flags = 2
            TxNote.Text = cNote.InnerText
            GetShowNote(cID)
        Catch
            cNote = Nothing
            sNote = Nothing
            TxNote.Text = ""
        Finally
            GrNote.Text = "Chú thích"
        End Try
    End Sub

    Private Function GetShowNote(Optional ByVal cID As String = "") As Boolean
        Try
            If cID = "" Then cID = CurID
            sMessage = Swex.ProjectTree.GetObject(cID).Message
            sNote = sMessage.GetMessageObject
            sNote.InnerText = toHTML(cNote.InnerText)
            sNote.Flags = _HTML_POPUP_FLAGS.HTML_POPUP_USE_TEXT_AS_INNER_HTML
            SetNoteSize()
            Return True
        Catch
            sNote = Nothing
            Return False
        End Try
    End Function

    Private Sub SaveNote()
        Try
            TxNote.Text = Trim(TxNote.Text)
            Dim st As String = TxNote.Text
            If st = "" Then Exit Sub
            cNote = Nothing
            cNote = Sw.Creator.CreatePopupMessage
            cMessage = CurObject.Message
            cMessage.MessageID = cNote.ID
            st = Replace(st, "m2", "m²")
            st = Replace(st, "m3", "m³")
            cNote.Flags = 2
            cNote.InnerText = st
            GrNote.Text = "Chú thích"
            sMessage = Swex.ProjectTree.GetObject(CurID).Message
            sNote = Nothing
            sMessage.MessageID = -1
            sNote = Swex.Creator.CreatePopupMessage
            sMessage.MessageID = sNote.ID
            sNote.Flags = _HTML_POPUP_FLAGS.HTML_POPUP_USE_TEXT_AS_INNER_HTML
            sNote.InnerText = toHTML(st)
            Me.Text = "Military 3D Map - " & Sw.Project.Name & "*"
            FileChanged = True
        Catch

        End Try
        SetNoteSize()
    End Sub

    Private Sub ShowNote()
        Try
            Dim st As String = Trim(cNote.InnerText)
            If st = "" Then Exit Sub
            If GrNote.Text.Contains("*") Then SaveNote()
            cNote.Flags = 2
            sNote.Flags = _HTML_POPUP_FLAGS.HTML_POPUP_USE_TEXT_AS_INNER_HTML
            cMessage.Activate()
        Catch
        End Try

    End Sub

    Private Sub HideNote()
        Try
            Sw.Window.RemovePopup(cNote)
            Swex.Window.RemovePopup(sNote)
        Catch

        End Try

    End Sub

    Private Sub HideAllnote()
        Dim Pst As String = Sw.ProjectTree.RootID
        Do Until Pst = ""

        Loop
    End Sub
    Private Function toHTML(st As String) As String
        If st = "" Then Return ""
        Dim pst() As String = st.Split(vbCrLf)
        Dim i As Integer
        ' Tiêu đề: Arial, size 20, in đậm, căn giữa, viết hoa
        Dim html As String = "<html><div style=""font-family:Arial,sans-serif;line-height:1.2;text-align:center;text-transform:uppercase;font-size:20px;""><b>"
        html += pst(0) & "</b></div>" & vbCrLf
        ' Nội dung: Arial, size 18, căn đều
        html += "<div style=""font-family:Arial,sans-serif;text-align:justify;font-size:18px;"">"
        For i = 1 To UBound(pst)
            ' Bọc số trong <b>...</b>
            Dim line As String = System.Text.RegularExpressions.Regex.Replace(
            pst(i),
            "(\d+([\.,]\d+)*)",
            "<b>$1</b>"
        )
            html += line & "<br>" & vbCrLf
        Next
        html += "</div></html>"
        html = Replace(html, "m2", "m<sup>2</sup>")
        html = Replace(html, "m3", "m<sup>3</sup>")
        Return html
    End Function



    Private Sub DeleteNote()
        Try
            TxNote.Text = ""
            cMessage.MessageID = -1
            sMessage.MessageID = -1
        Catch ex As Exception
        End Try

    End Sub


    Private Sub SetNoteSize()
        Try
            ' Lấy nội dung ghi chú, tách dòng
            Dim pst() As String = TxNote.Text.Split({vbCrLf}, StringSplitOptions.None)
            If pst.Length = 0 Then Exit Sub

            ' Font cho tiêu đề và nội dung
            Dim fontTitle As New Font("Arial", 20, FontStyle.Bold)
            Dim fontBody As New Font("Arial", 18, FontStyle.Regular)

            ' Tính chiều rộng lớn nhất và tổng chiều cao
            Dim maxWidth As Integer = 0
            Dim totalHeight As Integer = 0

            ' Đo tiêu đề (dòng đầu)
            Dim szTitle As Size = TextRenderer.MeasureText(pst(0), fontTitle)
            maxWidth = szTitle.Width
            totalHeight = szTitle.Height + 8 ' padding trên/dưới

            ' Đo các dòng nội dung còn lại
            For i As Integer = 1 To pst.Length - 1
                Dim szBody As Size = TextRenderer.MeasureText(pst(i), fontBody)
                If szBody.Width > maxWidth Then maxWidth = szBody.Width
                totalHeight += szBody.Height
            Next

            'Thêm Padding ngang, giới hạn tối đa
            maxWidth -= 100
            If maxWidth > 700 Then maxWidth = 700
            If totalHeight < 60 Then totalHeight = 60
            If totalHeight > 600 Then totalHeight = 600

            If sNote IsNot Nothing Then
                sNote.Width = maxWidth
                sNote.Height = totalHeight
                sNote.SaveInFlyFile = True
            End If
        Catch
            ' Bỏ qua lỗi
        End Try
    End Sub

    Private Sub CmdHideNote_Click(sender As Object, e As EventArgs) Handles CmdHideNote.Click, CmdHideNote2.Click
        HideNote()
    End Sub

    Private Sub cmdShowNote_Click(sender As Object, e As EventArgs) Handles cmdShowNote.Click, CmdShowNote2.Click
        ShowNote()
    End Sub

    Private Sub TxNote_TextChanged(sender As Object, e As EventArgs) Handles TxNote.TextChanged
        GrNote.Text = "Chú thích*"
    End Sub

    Private Sub CmdSaveNote_Click(sender As Object, e As EventArgs) Handles CmdSaveNote.Click
        SaveNote()
    End Sub

    Private Sub CmdDelNote_Click(sender As Object, e As EventArgs) Handles CmdDelNote.Click
        DeleteNote()
    End Sub



    Private Sub BackupSignlist()
        BackupList = New List(Of ListViewItem)
        For Each cItem As ListViewItem In LvSign.Items
            BackupList.Add(cItem.Clone)
        Next
    End Sub

    Private Sub RestoreSignlist()
        Try
            If LvSign.Items.Count = BackupList.Count Then Exit Sub
            LvSign.Items.Clear()
            For Each cItem As ListViewItem In BackupList
                LvSign.Items.Add(cItem.Clone)
                If LvSign.Items.Count Mod 10 = 0 Then LvSign.Refresh()
            Next
        Catch

        End Try

    End Sub

    Private Sub FindSignlist(ByVal mVal As String)
        If mVal = "" Then
            RestoreSignlist()
            Exit Sub
        End If
        Try
            LvSign.Items.Clear()
            mVal = UCase(mVal)
            Dim pst() As String
            Dim rs As Boolean
            Dim cs As String
            For Each cItem As ListViewItem In BackupList
                pst = mVal.Split(" ")
                rs = True
                For Each st As String In pst
                    cs = UCase(cItem.Text)
                    If Not cs.Contains(st) Then rs = False
                Next
                If rs Then LvSign.Items.Add(cItem.Clone)
            Next
        Catch
            RestoreSignlist()
        End Try

    End Sub

    Private Sub CmdUp_Click(sender As Object, e As EventArgs) Handles CmdUp.Click

    End Sub

    Private Sub CmdGo_Click(sender As Object, e As EventArgs) Handles CmdGo.Click

    End Sub

#End Region

End Class