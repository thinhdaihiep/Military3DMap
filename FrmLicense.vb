Imports System.Windows.Forms

Public Class FrmLicense

    Private Sub CmdCLose_Click(sender As Object, e As EventArgs) Handles CmdCLose.Click
        Me.Close()
    End Sub

    Private Sub FrmLicense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxUser.Text = GetSetting(AppTitle, "License", "User", "Unknown")
        TxAppID.Text = GetAppID()
        If CheckLicense() Then
            LbLicensed.Visible = True
            LbLicensing.Visible = False
            TxLicense.ReadOnly = True

        Else
            LbLicensed.Visible = False
            LbLicensing.Visible = True
        End If
    End Sub

    Private Sub CmdLicense_Click(sender As Object, e As EventArgs) Handles CmdLicense.Click
        SaveSetting(AppTitle, "License", "Key", TxLicense.Text)
        SaveSetting(AppTitle, "License", "User", TxUser.Text)
        If CheckLicense() Then
            MsgBox("Bản đã đăng ký sử dụng phần mềm thành công !", vbInformation, "Licensing")
            LbLicensed.Visible = True
            TxLicense.ReadOnly = True
            LbLicensing.Visible = False
            FrmMain.LicenseBar.Visible = False
            FrmMain.TmrLicense.Enabled = False
            FrmAbout.LbLicense.Visible = False
            CmdLicense.Enabled = False
        Else
            MsgBox("Key bản quyền không đúng, Vui lòng liên hệ tác giả !", vbExclamation, "Licensing")
            LbLicensed.Visible = False
            LbLicensing.Visible = True
        End If
    End Sub
End Class
