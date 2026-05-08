Imports System.ComponentModel

Public NotInheritable Class FrmAbout
    Private cpos As Point

    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeTime()
        LbVersion.Text = "Phiên bản: " & My.Application.Info.Version.ToString
        LbCopyright.Text = My.Application.Info.Copyright.ToString
        'LbLicense.Visible = Not CheckLicense()
    End Sub

    Private Sub FrmAbout_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.Close()
    End Sub

    Private Sub PicSun_DoubleClick(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then Me.Location += Control.MousePosition - cpos
        cpos = Control.MousePosition
    End Sub

    Private Sub LbLicense_Click(sender As Object, e As EventArgs) Handles LbLicense.Click
        FrmLicense.ShowDialog(Me)
    End Sub
End Class
