Imports System.Data.OleDb
Imports System.Management
Imports System.Text
Imports System.Security.Cryptography

Module ModMain

    Public Const AppTitle = "Military 3D Map"
    Public AppPath As String = My.Application.Info.DirectoryPath
    Private CurDate As String
    Private ReadOnly Con As New OleDbConnection
    Private ReadOnly Da As New OleDbDataAdapter
    Private ReadOnly Cm As New OleDbCommand

    Public Enum IconType
        Info = 0
        Warning = 1
        Exclamation = 2
        Message = 3
        Accept = 4
        Cancel = 5
        Find = 6
        Wait = 7
        Pivot = 8
        Time = 9
    End Enum
    Private Function ConnectData() As Boolean
        Try
            If Con.State = ConnectionState.Closed Then
                Con.ConnectionString = "Provider=microsoft.ace.oledb.12.0; data source=" & AppPath & "\Data.accdb; Jet OLEDB:Database Password=bbdqk5 ;"
                Con.Open()
                Cm.Connection = Con
                Da.SelectCommand = Cm
            End If

            If Con.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Filldata(sCmd As String) As DataTable
        Dim dt As New DataTable
        Try
            If ConnectData() Then
                Cm.CommandText = sCmd
                Da.Fill(dt)
            End If

        Catch ex As Exception

        End Try

        Return dt
    End Function
    Public Sub CloseData()
        Try
            Cm.Dispose()
            Da.Dispose()
            Con.Close()
        Catch ex As Exception
            MsgBox("Lỗi khi đóng kết nối")
        End Try
    End Sub
    Public Sub AttachTime()
        Try
            Dim st As String = AppPath
            st = st & "\runasdate.exe \immediate 05\10\2021 Attach:TE3DAX.exe"
            Shell(st)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function ChangeTime() As Boolean
        Try
            CurDate = Format(Now, "MM/dd/yyyy")
            DateString = Format(Now, "MM/dd/2021")
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Sub RestoreTime()
        On Error Resume Next
        Microsoft.VisualBasic.DateString = CurDate
    End Sub
#Region "License"
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
    Public Function CheckLicense() As Boolean
        Try
            Dim hs As String = GetAppID()
            Dim ps() As String = hs.Split("-")
            Dim cKey As String = GetSetting(AppTitle, "License", "Key", vbNullString)
            Dim pc() As String = cKey.Split("-")
            Dim i As Integer = GetRandom(0, UBound(ps) - 1)
            Dim rKey As String = SHA1(ps(i))
            If rKey = pc(i) Then Return True Else Return False
        Catch ex As Exception
            Return False
        End Try

    End Function
    Private Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Randomize()
        Dim Generator As New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Public Function Unzip(sFn As String, dFn As String) As Boolean
        Try
            IO.Compression.ZipFile.ExtractToDirectory(sFn, dFn)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region
End Module
