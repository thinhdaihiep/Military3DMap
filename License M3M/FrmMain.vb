Imports System.Management
Imports System.Text
Imports System.Security.Cryptography
Public Class FrmMain
    Private Sub CmdGetID_Click(sender As Object, e As EventArgs) Handles CmdGetSerial.Click
        TxtSerial.Text = GetAppID()
    End Sub

    Public Function GetAppID() As String
        Dim hdd As New ManagementObjectSearcher("select * from Win32_DiskDrive")
        Dim hd As ManagementObject
        Dim hs As String = vbNullString
        For Each hd In hdd.Get()
            hs = hd("SerialNumber")
        Next
        hs = Trim(hs)
        hs = hs.Replace(".", vbNullString)
        hs = hs.Replace("0000_", vbNullString)
        hs = hs.Replace("_", "-")
        Return hs
    End Function
    Public Function SHA1(ByVal number As String) As String
        Dim ASCIIENC As New ASCIIEncoding
        Dim strreturn As String
        strreturn = vbNullString
        Dim bytesourcetxt() As Byte = ASCIIENC.GetBytes(number)
        Dim SHA1Hash As New SHA1CryptoServiceProvider
        Dim bytehash() As Byte = SHA1Hash.ComputeHash(bytesourcetxt)
        For Each b As Byte In bytehash
            strreturn &= b.ToString("X8")
        Next
        strreturn = strreturn.Replace("000000", "")
        strreturn = strreturn.Substring(0, 5)
        Return strreturn
    End Function

    Private Sub CmdCreateKey_Click(sender As Object, e As EventArgs) Handles CmdCreateKey.Click
        Try
            Dim ps() As String = Split(TxtSerial.Text, "-")
            Dim i As Integer
            Dim rKey As String = SHA1(ps(0))
            For i = 1 To UBound(ps)
                rKey = rKey & "-" & SHA1(ps(i))
            Next
            TxtLicense.Text = rKey
        Catch ex As Exception
            TxtLicense.Text = "Wrong serial!"
        End Try

    End Sub

    Private Sub CmdCLose_Click(sender As Object, e As EventArgs) Handles CmdCLose.Click
        Me.Close()
    End Sub

    Private Sub CmdCopy_Click(sender As Object, e As EventArgs) Handles CmdCopy.Click
        Try
            TxtLicense.Select()
            TxtLicense.SelectAll()

            My.Computer.Clipboard.SetText(TxtLicense.Text)
        Catch ex As Exception

        End Try

    End Sub
End Class
