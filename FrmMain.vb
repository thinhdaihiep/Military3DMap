Imports System.ComponentModel
Imports System.Threading
Imports TerraExplorerX

Public Class FrmMain
    Friend WithEvents Sw As TerraExplorerX.SGWorld71
    Friend WithEvents Swex As TerraExplorerX.SGWorld71
    Private RecentFiles As Collection
    Private Exitting As Boolean = False
    Private CurrentID As String

    Friend Sub ReloadShow()
        On Error Resume Next
        Dim mRs As MsgBoxResult
        mRs = MsgBox("Cập nhật lại bản đồ có thể làm gián đoạn màn hình trình chiếu" & vbCrLf & "Bạn có muốn tiếp tục không?", vbQuestion Or vbYesNo, "Cập nhật bản đồ")
        If mRs = vbNo Then Exit Sub
        If DlgOpen.FileName <> vbNullString Then Swex.Project.Open(DlgOpen.FileName, True)

    End Sub

    Friend Function SetMornitor(Frm As Form, nS As Int16) As Boolean
        Try
            Dim Pnt As Rectangle = Screen.AllScreens(nS).Bounds
            Frm.SetBounds(Pnt.X, Pnt.Y, Pnt.Width, Pnt.Height)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Friend Sub UpdateShow(Optional ByVal Flymode As Boolean = True)
        On Error Resume Next
        Dim cPos As IPosition71 = Sw.Navigate.GetPosition
        Swex.Navigate.FlyTo(cPos)
    End Sub
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Sw.Command.Execute(1162, 1)
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Sw.Command.Execute(1031, 0)
    End Sub

    Private Sub BtnCut_Click(sender As Object, e As EventArgs) Handles BtnCut.Click
        Sw.Command.Execute(1032, 0)
    End Sub
    Private Sub BtnEndShow_Click(sender As Object, e As EventArgs) Handles BtnHide.Click
        ShowScreen(False)
    End Sub

    Private Sub BtnFollow_Click(sender As Object, e As EventArgs) Handles BtnFollow.Click
        On Error Resume Next
        UpdateShow()
    End Sub

    Private Sub OpenFile()
        Try
            If Not DlgOpen.CheckFileExists Or DlgOpen.FileName = vbNullString Then Exit Sub
            If CloseFile() = vbCancel Then Exit Sub
            SetStatus("Đang mở file: " & DlgOpen.FileName)
            Sw.Project.Open(DlgOpen.FileName, True)
        Catch ex As Exception
            SetStatus(ex.Message, 1)
        End Try
    End Sub
    Private Sub BtnPaste_Click(sender As Object, e As EventArgs) Handles BtnPaste.Click
        Sw.Command.Execute(1030, 0)
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        PlayShow(False)

    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        PlayShow(True)
    End Sub

    Private Sub BtnRedo_Click(sender As Object, e As EventArgs) Handles BtnRedo.Click
        Sw.Command.Execute(2346, 0)
        MsgBox("Chức năng này chỉ hỗ trợ ở phiên bản TerraExplorer 7.3", vbInformation, "Redo")
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        ReloadShow()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        SaveFile()
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        'If Screen.AllScreens.Count = 1 Then
        '    MsgBox("Không tìm thấy màn hình trình chiếu !", vbExclamation, "Trình chiếu")
        '    Exit Sub
        'Else
        'SetMornitor(FrmShow, 2)
        'End If
        ShowScreen(True)
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        Sw.Command.Execute(2345, 0)
        MsgBox("Chức năng này chỉ hỗ trợ ở phiên bản TerraExplorer 7.3", vbInformation, "Undo")

    End Sub

    Private Function CloseFile(Optional ByVal mPrompt As String = "Bạn có muốn lưu bản đồ trước khi tiếp tục ?") As MsgBoxResult
        Dim mRs As MsgBoxResult = vbNo
        If BtnSave.Enabled Then
            mRs = MsgBox(mPrompt, vbQuestion Or vbYesNoCancel, "Thông báo")
            Select Case mRs
                Case vbCancel
                    Return vbCancel
                Case vbYes
                    SaveFile()
                Case Else
                    Exit Select
            End Select
        End If
        PlayShow(False)
        Swex.Project.Close()
        Sw.Project.Close()
        Return mRs
    End Function

    Private Sub EnableSave()
        BtnSave.Enabled = True
    End Sub
    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Exitting = True
            If CloseFile("Bạn có muốn lưu bản đồ trước khi thoát?") = vbCancel Then
                Exitting = False
                e.Cancel = True
                Exit Sub
            End If
            SaveRecent()
            FrmShow.Visible = False
            FrmShow.Close()
        Catch ex As Exception
            Application.Exit()
        End Try

    End Sub

    Friend Sub InitTerra()
        Try
            Sw = MapView.CreateInstance("TerraExplorerX.SGWorld71")
            TreeView.AttachTo3dWindow(MapView.GetOcx)
            Swex = FrmShow.MapShow.CreateInstance("TerraExplorerX.SGWorld71")

            Swex.SetOptionParam("HeadUpDisplay", 8)
            'Sw.SetOptionParam("HeadUpDisplay", 262)
            Sw.Window.ShowControls(262)
            Swex.Window.DisablePresentationControl = True

            Sw.Project.Settings("CopyrightText”) = "Ban Bản đồ - Quân khu 5"
            Swex.Project.Settings("CopyrightText”) = "Ban Bản đồ - Quân khu 5"
            Sw.Project.Settings("RemoveSkylineCopyright") = 1
            Swex.Project.Settings("RemoveSkylineCopyright") = 1
        Catch ex As Exception
            SetStatus("Init TerraExplorer Instance message: " & ex.Message, 1)
        End Try
    End Sub

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        InitTerra()
        LoadRecent()
    End Sub
    Private Sub PlayShow(mValue As Boolean)
        Try
            If mValue Then
                Sw.Application.Multiple3DWindows.SetAsLeader()
                Swex.Application.Multiple3DWindows.LinkPosition(Sw)
                Sw.SetOptionParam("HUDcolor", Drawing.Color.Yellow)
            Else
                Sw.Application.Multiple3DWindows.UnlinkPosition()
                Swex.Application.Multiple3DWindows.UnlinkPosition()
                Sw.SetOptionParam("HUDcolor", Drawing.Color.White)
            End If
            BtnPlay.Visible = Not mValue
            BtnPause.Visible = mValue
            BtnFollow.Enabled = Not mValue
        Catch ex As Exception
            SetStatus(ex.Message, 1)
        End Try

    End Sub

    Private Sub SaveFile()
        Try
            SetStatus("Đang lưu file: " & DlgOpen.FileName)
            Sw.Project.Save()
        Catch ex As Exception
            SetStatus("Lưu file thất bại!", 2)
        End Try

    End Sub



    Private Sub SetStatus(mText As String, ByVal Optional mIcon As Byte = 0)
        SttBar.Text = mText
        Select Case mIcon
            Case 0
                SttBar.Image = My.Resources.information
            Case 1
                SttBar.Image = My.Resources.Warning
            Case 2
                SttBar.Image = My.Resources.Exclamation
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub ShowScreen(mVal As Boolean)
        FrmShow.Visible = mVal
        BtnHide.Visible = mVal
        BtnShow.Visible = Not mVal
        BtnFollow.Visible = mVal
        Me.Activate()
    End Sub
    Private Sub Sw_OnObjectAction(ObjectID As String, Action As IAction71) Handles Sw.OnObjectAction
        Try
            Select Case Action.Code
                Case 15, 17, 23, 24, 26, 27, 28, 29, 32
                    Dim obj As ITerraExplorerObject71
                    obj = Sw.Creator.GetObject(ObjectID)
                    If Not IsNothing(obj) Then SendEvent("FileChanged-" & ObjectID)
                Case ActionCode.AC_EDIT_STARTED
                    SendEvent("EditStarted")
                Case ActionCode.AC_EDIT_FINISHED
                    SendEvent("EditFinished")
                Case ActionCode.AC_SELCHANGED
                    SendEvent("Selected-" & ObjectID)
                Case Else
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Sw_OnProjectTreeAction(ID As String, Action As IAction71) Handles Sw.OnProjectTreeAction
        Try
            Select Case Action.Code
                Case 17, 15, 16, 23, 24, 26, 27, 28, 29, 32
                    SendEvent("FileChanged-" & ID)
                Case ActionCode.AC_SELCHANGED
                    SendEvent("Selected-" & ID)
                Case Else

                    Exit Select
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SetEditTool(mValue As Boolean)
        BtnCopy.Enabled = mValue
        BtnCut.Enabled = mValue
        BtnPaste.Enabled = mValue
        BtnEdit.Enabled = mValue
        BtnDel.Enabled = mValue
        BtnLocateGroup.Enabled = Sw.ProjectTree.IsGroup(CurrentID)
    End Sub
    Private Sub Sw_OnLoadFinished(bSuccess As Boolean) Handles Sw.OnLoadFinished
        If bSuccess Then 'Turn off effect to optimize speed
            Sw.Command.Execute(1154, 0)
            Sw.Command.Execute(2206, 0)
            Sw.Command.Execute(2207, 0)
            Sw.Command.Execute(2208, 0)
            Sw.Command.Execute(2209, 0)
            SendEvent("FileLoaded")
        Else
            SendEvent("FileLoadFail")
        End If

    End Sub
    Private Sub Swex_OnLoadFinished(bSuccess As Boolean) Handles Swex.OnLoadFinished
        If bSuccess Then 'Turn off effect to optimize speed
            Swex.Command.Execute(1154, 0)
            Swex.Command.Execute(2206, 0)
            Swex.Command.Execute(2207, 0)
            Swex.Command.Execute(2208, 0)
            Swex.Command.Execute(2209, 0)
            SendEvent("ShowLoaded")
        Else
            SendEvent("ShowLoadFail")
        End If
    End Sub

    Private Sub BtnOcean_Click(sender As Object, e As EventArgs) Handles BtnOcean.Click
        Sw.Command.Execute(1155, 0)
        Swex.Command.Execute(1155, 0)
    End Sub

    Private Sub SendEvent(mText As String)
        If Exitting Then Exit Sub
        Thread.CurrentThread.IsBackground = True
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
    Private Sub TxtEvent_TextChanged(sender As Object, e As EventArgs) Handles TxtEvent.TextChanged
        If TxtEvent.Text = vbNullString Then Exit Sub
        Try
            Dim msg() As String
            msg = TxtEvent.Text.Split("-")
            Select Case msg(0)
                Case "FileChanged"
                    BtnSave.Enabled = True
                    Me.Text = "Military 3D Map - " & DlgOpen.FileName & "*"
                Case "FileLoaded"
                    SetStatus(DlgOpen.FileName)
                    Me.Text = "Military 3D Map - " & DlgOpen.FileName
                    AddRecent(DlgOpen.FileName, True)
                    Swex.Project.Open(DlgOpen.FileName, False)
                    MapToolStrip.Enabled = True
                    TreeToolStrip.Enabled = True
                Case "FileloadFail"
                    BtnSave.Enabled = False
                    BtnPlay.Enabled = False
                    BtnUpdate.Enabled = False
                    MapToolStrip.Enabled = False
                    TreeToolStrip.Enabled = False
                Case "ShowLoaded"
                    BtnPlay.Enabled = True
                    BtnFollow.Enabled = True
                    BtnUpdate.Enabled = False
                Case "ShowLoadFail"
                    BtnPlay.Enabled = False
                    BtnFollow.Enabled = False
                    BtnUpdate.Enabled = False
                    MsgBox("Không mở được file cho màn hình trình chiếu" & vbCrLf & "Vui lòng kiểm tra lại file bản đồ", MsgBoxStyle.Exclamation, "Trình chiếu")
                Case "FileSaved"
                    BtnSave.Enabled = False
                    BtnUpdate.Enabled = True
                    Me.Text = "Military 3D Map - " & DlgOpen.FileName
                    SetStatus("Đã lưu file thành công!")
                Case "InputmodeChanged"
                    SetInputMode()
                Case "Selected"
                    CurrentID = msg(1)
                    SetEditTool(CurrentID.Length)
                Case "EditStarted"
                    SetEditTool(True)
                Case "EditFinished"
                    BtnSave.Enabled = True
                    Me.Text = "Military 3D Map - " & DlgOpen.FileName & "*"
                Case Else
                    Exit Select
            End Select
        Catch ex As Exception
            SetStatus(ex.Message, 1)
        Finally
            TxtEvent.Text = vbNullString
        End Try
    End Sub
    Private Sub SetInputMode()
        Dim mIp As MouseInputMode = Sw.Window.GetInputMode()
        Dim mBt As ToolStripButton
        For Each mBt In MapToolStrip.Items.OfType(Of ToolStripButton)
            mBt.Checked = False
        Next
        Select Case mIp
            Case MouseInputMode.MI_FREE_FLIGHT
                BtnPan.Checked = True
            Case MouseInputMode.MI_EDIT
                BtnSelect.Checked = True
            Case MouseInputMode.MI_MEASUREMENT
                BtnDistance.Checked = BtnDistance.Tag
                BtnHeight.Checked = BtnHeight.Tag
                BtnArea.Checked = BtnArea.Tag
        End Select

    End Sub

    Private Sub LoadRecent()
        Dim mItem As ToolStripMenuItem
        Dim s As String
        RecentFiles = New Collection
        For Each mItem In BtnOpen.DropDownItems
            s = GetSetting("Military 3D Map", "Recent files", mItem.Tag)
            AddRecent(s)
        Next
        AddRecent(, True)
    End Sub
    Private Sub AddRecent(Optional ByVal mFile As String = vbNullString, Optional ByVal mRebuild As Boolean = False)
        Try
            If mFile <> vbNullString Then RecentFiles.Add(mFile, mFile, 1)
            If mRebuild = True Then
                Dim mItem As ToolStripMenuItem
                For Each mItem In BtnOpen.DropDownItems
                    mItem.Text = RecentFiles(Val(mItem.Tag))
                    If mItem.Text <> vbNullString Then mItem.Visible = True
                Next

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SaveRecent()
        Dim mItem As ToolStripMenuItem
        For Each mItem In BtnOpen.DropDownItems
            SaveSetting("Military 3D Map", "Recent files", mItem.Tag, mItem.Text)
        Next
    End Sub
    Private Function GetFileName(mPath As String) As String
        Dim pst() As String
        pst = mPath.Split("\")
        Return pst(UBound(pst))
    End Function
    Private Sub BtnOpen_ButtonClick(sender As Object, e As EventArgs) Handles BtnOpen.ButtonClick
        If DlgOpen.ShowDialog() = DialogResult.OK Then OpenFile()
    End Sub

    Private Sub MnRecent_Click(sender As Object, e As EventArgs) Handles MnRecent1.Click, MnRecent2.Click, MnRecent3.Click, MnRecent4.Click, MnRecent5.Click
        DlgOpen.FileName = CType(sender, ToolStripMenuItem).Text
        OpenFile()
    End Sub

    Private Sub Sw_OnInputModeChanged(NewMode As MouseInputMode) Handles Sw.OnInputModeChanged
        SendEvent("InputmodeChanged")
    End Sub

    Private Sub Sw_OnFileClosed() Handles Sw.OnFileClosed
        MapToolStrip.Enabled = False
        TreeToolStrip.Enabled = False
    End Sub

    Private Sub Sw_OnSGWorld(EventID As Integer, EventParam As Object) Handles Sw.OnSGWorld
        If EventID = 9 Then SendEvent("FileSaved")
    End Sub

    Private Sub Sw_OnFileClosing() Handles Sw.OnFileClosing
        SendEvent("Message-Đang đóng file hiện tại...")
    End Sub

    Private Sub BtnNavigate_Click(sender As Object, e As EventArgs) Handles BtnNavigate.Click
        Sw.Window.ShowControls(258)
    End Sub

    Private Sub MapView_Enter(sender As Object, e As EventArgs) Handles MapView.Enter

    End Sub

    Private Sub CmdCapture_Click(sender As Object, e As EventArgs) Handles CmdCapture.Click

        Sw.Command.Execute(1068, 0)
    End Sub

    Private Sub BtnCopy_Click_1(sender As Object, e As EventArgs)
        Sw.Command.Execute(1031, 0)
    End Sub

    Private Sub BtnCut_Click_1(sender As Object, e As EventArgs)
        Sw.Command.Execute(1032, 0)
    End Sub

    Private Sub BtnPaste_Click_1(sender As Object, e As EventArgs)
        Sw.Command.Execute(1030, 0)
    End Sub

    Private Sub BtnDel_Click_1(sender As Object, e As EventArgs)
        Sw.Command.Execute(1033, 0)
    End Sub

    Private Sub BtnFolderAdd_Click(sender As Object, e As EventArgs)
        Try
            Dim pID As String
            Dim nID As String
            If Sw.ProjectTree.IsGroup(CurrentID) Then
                pID = CurrentID
            Else
                pID = Sw.ProjectTree.GetNextItem(CurrentID, ItemCode.PARENT)
            End If
            nID = Sw.ProjectTree.CreateGroup("New group", pID)
            Sw.ProjectTree.RenameGroup(nID, "New group #" & nID)
            Sw.ProjectTree.ExpandGroup(pID, True)
        Catch ex As Exception
            SetStatus("Không tạo được thư mục: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnItemDel_Click(sender As Object, e As EventArgs)
        Try
            TreeView.Select()
            SendKeys.SendWait("{Delete}")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try

            If Sw.Version.Type = TEVersionType.TEVT_VIEWER Then
                MsgBox("Phiên bản Terraexplorer hiện tại không hỗ trợ chỉnh sửa đối tượng", MsgBoxStyle.Information, "Chỉnh sửa")
                Exit Sub
            End If
            Dim sID() As String
            sID = GetSelects()
            If sID.Count > 1 Then
                Sw.ProjectTree.EditItems(sID)
            Else
                Sw.ProjectTree.EditItem(CurrentID, EditItemFlags.EDIT_ITEM_USE_PROPERTY)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetSelects() As String()
        Dim pst() As String = {}
        Dim s As String = Sw.ProjectTree.RootID
        Dim i As Int16 = 0
        Do
            s = Sw.ProjectTree.GetNextItem(s, ItemCode.SELECTED)
            If s = vbNullString Then Exit Do
            ReDim Preserve pst(i)
            pst(i) = s
            i += 1
        Loop Until s = vbNullString
        Return pst
    End Function

    Private Sub BtnAddLocation_Click(sender As Object, e As EventArgs) Handles BtnAddLocation.Click
        Sw.Command.Execute(1016, 0)
    End Sub

    Private Sub BtnAddLabel_Click(sender As Object, e As EventArgs) Handles BtnAddLabel.Click
        Sw.Command.Execute(1012, 0)
    End Sub

    Private Sub BtnSetting_Click(sender As Object, e As EventArgs) Handles BtnSetting.Click
        Sw.Command.Execute(1020, 0)
    End Sub

    Private Sub BtnAddImage_Click(sender As Object, e As EventArgs) Handles BtnAddImage.Click
        Sw.Command.Execute(1012, 1)
    End Sub

    Private Sub BtnPan_Click(sender As Object, e As EventArgs) Handles BtnPan.Click
        Try
            Swex.Window.SetInputMode(MouseInputMode.MI_FREE_FLIGHT,, True)
            Sw.Window.SetInputMode(MouseInputMode.MI_FREE_FLIGHT,, True)
            SetInputMode()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Try
            Sw.Command.Execute(1021, 0)
            SetInputMode()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDistance_Click(sender As Object, e As EventArgs) Handles BtnDistance.Click
        Try
            BtnDistance.Tag = True
            BtnHeight.Tag = False
            BtnArea.Tag = False
            Sw.Command.Execute(1035, 0)
            SetInputMode()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnHeight_Click(sender As Object, e As EventArgs) Handles BtnHeight.Click
        Try
            BtnDistance.Tag = False
            BtnHeight.Tag = True
            BtnArea.Tag = False
            Sw.Command.Execute(1036, 0)
            SetInputMode()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnArea_Click(sender As Object, e As EventArgs) Handles BtnArea.Click
        Try
            BtnDistance.Tag = False
            BtnHeight.Tag = False
            BtnArea.Tag = True
            Sw.Command.Execute(1037, 0)

            SetInputMode()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnLocateGroup_Click(sender As Object, e As EventArgs) Handles BtnLocateGroup.Click
        On Error Resume Next
        Dim cPos As IPosition71 = Sw.Navigate.GetPosition
        If Sw.ProjectTree.IsGroup(CurrentID) Then
            Sw.ProjectTree.SetGroupLocation(CurrentID, cPos)
        Else

        End If
    End Sub
End Class