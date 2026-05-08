Imports System.IO
Imports System.Math
Imports TerraExplorerX

Public Class SignObject
    Private cLab As ITerrainImageLabel71
    Private cID As String
    Private cImageFile As String = AppPath & "\Default.png"
    Private cFontName As String = "UTM HelvetIns"
    Private cFont As New Font(cFontName, 20)
    Private cPos As Point 'Toa do Thumbnail phien hieu tren PicSign
    Private cCap As String = "97" 'Ten phien hieu
    Private cTeam As Byte '0 Ta; 1 Dich; 2 Khac
    Private mColor As Color = Color.Red  'Mau chinh
    Private sColor As Color = Color.FromArgb(255, 252, 153, 204) 'Mau dem
    Private cPivot As Byte 'Vi tri tam
    Private ReadOnly cPic As PictureBox 'Picturebox hien thi Thumbnail
    Private cName As String 'Ten ky hieu
    Private cFlip As Boolean = False 'Lat hinh
    Private c2D As Boolean = False
    Private cThumbScale As Single = 2.6222 'Default.png=236 / picsign=90
    Private cScale As Single = 20
    Private ReadOnly cSw As SGWorld71
    Private ReadOnly Pva() As String = {vbNullString, "Top, Left", "Top, Center", "Top, Right", "Center, Right", "Bottom, Right", "Bottom, Center", "Bottom, Left", "Center, Left", "Center, Center"}
    Public Event ChangedID()
    Sub New(Picbox As PictureBox, mSw As SGWorld71)
        cSw = mSw
        cPic = Picbox
        cPos = New Point(cPic.Width \ 2, cPic.Height \ 2)
    End Sub
    Public ReadOnly Property Position As IPosition71
        Get
            Return cLab.Position
        End Get
    End Property
    Public ReadOnly Property ID As String
        Get
            Return cID
        End Get
    End Property
    Public Property Name As String
        Set(value As String)
            cName = value
        End Set
        Get
            Return cName
        End Get
    End Property
    Public WriteOnly Property ImageFile As String
        Set(value As String)
            cImageFile = value
        End Set
    End Property
    Public Property PrimaryColor As Color
        Set(value As Color)
            mColor = value
        End Set
        Get
            Return mColor
        End Get
    End Property
    Public Property SecondColor As Color
        Set(value As Color)
            sColor = value
        End Set
        Get
            Return sColor
        End Get
    End Property
    Public Property Caption As String
        Set(value As String)
            cCap = value
        End Set
        Get
            Return cCap
        End Get
    End Property
    Public Property Team As Byte
        Set(value As Byte)
            cTeam = value
        End Set
        Get
            Return cTeam
        End Get
    End Property
    Public Property TextPos As Point
        Set(value As Point)
            cPos = value
        End Set
        Get
            Return cPos
        End Get
    End Property
    Public Property Flip As Boolean
        Set(value As Boolean)
            cFlip = value
        End Set
        Get
            Return cFlip
        End Get
    End Property
    Public Property Pivot As Byte
        Set(value As Byte)
            cPivot = value
        End Set
        Get
            Return cPivot
        End Get
    End Property

    Public Property FontSize As Single
        Set(value As Single)
            cFont = New Font(cFontName, value)
        End Set
        Get
            Return cFont.Size
        End Get
    End Property
    Public Property Scale As Single
        Set(value As Single)
            cScale = value
        End Set
        Get
            Return cScale
        End Get
    End Property
    Public ReadOnly Property ThumbScale As Single
        Get
            Return cThumbScale
        End Get
    End Property
    Public Property is2D As Boolean
        Set(value As Boolean)
            c2D = value
        End Set
        Get
            Return c2D
        End Get
    End Property
    Public Function SetID(mID As String) As Boolean
        Try
            Dim mOb As ITerraExplorerObject71
            mOb = cSw.ProjectTree.GetObject(mID)
            If mOb.ObjectType <> ObjectTypeCode.OT_IMAGE_LABEL Then Return False
            cLab = mOb
            If GetSignData() Then
                cID = mOb.ID
                cPivot = GetPivot()
                Redraw(False)
                RaiseEvent ChangedID()
                Return True
            Else
                cID = vbNullString
                cLab = Nothing
                Return False
            End If
        Catch ex As Exception
            cID = vbNullString
            cLab = Nothing
            Return False
        End Try
    End Function

    Private Function GetPivot() As Byte
        Dim Pva() As String = {vbNullString, "LeftTop", "CenterTop", "RightTop", "CenterRight", "RightBottom", "CenterBottom", "LeftBottom", "LeftCenter", "CenterCenter"}
        For i As Byte = 1 To 9
            If Pva(i) = cLab.Style.PivotAlignment Then Return i
        Next
        Return 5
    End Function
    Public Function AddtoMap(X As Double, Y As Double, Optional UsePixel As Boolean = True) As Boolean
        Try

            'Lay ten thu muc cha---
            Dim pID As String = cSw.ProjectTree.RootID
            Dim ob As ITerraExplorerObject71
            pID = cSw.ProjectTree.GetNextItem(pID, ItemCode.SELECTED)
            ob = cSw.ProjectTree.GetObject(pID)

            If cSw.ProjectTree.IsGroup(pID) And Not cSw.ProjectTree.IsLayer(pID) Then

            Else

                pID = cSw.ProjectTree.GetNextItem(pID, ItemCode.PARENT)
            End If

            'Tao thuoc tinh cho ky hieu
            Dim cStyle As ILabelStyle71
            cStyle = cSw.Creator.CreateLabelStyle()
            cStyle.LimitScreenSize = False
            cStyle.SmallestVisibleSize = 1
            ' Lay vi tri---
            Dim cPos As IPosition71
            If UsePixel Then
                Dim wp As IWorldPointInfo71 = cSw.Window.PixelToWorld(X, Y)
                cPos = wp.Position
                cPos.Distance = 50000
            Else
                cPos = cSw.Creator.CreatePosition(X, Y, 0,,,,, 50000)
            End If


            'Tao Image label voi ky hieu mac dinh---
            cLab = cSw.Creator.CreateImageLabel(cPos, AppPath & "\Default.png", cStyle, pID, cName)

            SaveSign(True) 'Dua ky hieu vao Image label---
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function
    Private Function SavePic(fn As String) As Boolean
        Try
            Dim img As Image = cPic.Image
            Dim nH As Integer = 60
            Dim nW As Integer = CInt(img.Width * (60 / img.Height))
            Dim bmp As New Bitmap(nW, nH, Imaging.PixelFormat.Format32bppArgb)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.Transparent)
                g.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
                g.DrawImage(img, 0, 0, nW, nH)
            End Using
            bmp.Save(fn, Imaging.ImageFormat.Png)
            bmp.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function SaveSign(ByVal Optional NewID As Boolean = False) As Boolean
        Try
            Dim pn As String = cSw.Project.Name
            Dim fn As String = Path.GetDirectoryName(pn)
            fn = fn & "\" & Path.GetFileNameWithoutExtension(pn) & "_data\"
            Directory.CreateDirectory(fn)
            fn = fn & cLab.ID & ".png"
            SavePic(fn)
            cLab.TreeItem.Name = cName
            cLab.ImageFileName = fn
            cLab.Style.Scale = cScale
            cLab.Style.LimitScreenSize = True
            cLab.Style.MinViewingHeight = 10
            cLab.Style.PivotAlignment = Pva(cPivot)
            If c2D Then
                cLab.Style.LockMode = LabelLockMode.LM_AXIS

            Else
                cLab.Style.LockMode = LabelLockMode.LM_DECAL
            End If
            cID = cLab.ID
            SaveSignData()
            cLab.SaveInFlyFile = True
            If NewID Then RaiseEvent ChangedID()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Private Sub SaveSignData()
        cLab.ClientData("SignSource") = cImageFile
        cLab.ClientData("SignCaption") = cCap
        cLab.ClientData("SignTextPos") = cPos.X & "-" & cPos.Y
        cLab.ClientData("SignSecondColor") = sColor.ToArgb
        cLab.ClientData("SignPrimaryColor") = mColor.ToArgb
        cLab.ClientData("FontSize") = cFont.Size
    End Sub
    Private Function GetSignData() As Boolean
        Try
            Dim s As String = cLab.ClientData("SignSource")
            If s = vbNullString Then Return False
            cImageFile = s
            cCap = cLab.ClientData("SignCaption")
            Dim st As String = cLab.ClientData("SignTextPos")
            Dim pst() As String = st.Split("-")
            cPos = New Point(Int(pst(0)), Int(pst(1)))

            Dim sc As Integer = cLab.ClientData("SignSecondColor")
            sColor = Color.FromArgb(sc)
            Dim mc As Integer = cLab.ClientData("SignPrimaryColor")
            mColor = Color.FromArgb(mc)

            cName = cLab.TreeItem.Name
            s = cLab.ClientData("FontSize")
            If s <> vbNullString Then cFont = New Font(cFontName, CSng(s))

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Shared Function CheckColor(ByVal mColor As Color) As Byte
        Try
            Dim h As Integer = mColor.GetHue
            Dim s As Integer = mColor.GetSaturation * 100
            Dim b As Integer = mColor.GetBrightness * 100
            If b < 5 Then Return 1
            Select Case h
                Case Is > 340, 0 'Mau ta---
                    If s > 50 And Abs(b - 45) < 15 Then Return 1
                Case 220 To 250 'Mau dich---
                    If s > 50 And Abs(b - 45) < 15 Then Return 2
                Case 295 To 335 'Mau dem---
                    If s > 50 And Abs(b - 75) < 10 Then Return 3
            End Select
            If b < 15 Then Return 4 'Màu đậm---
            If b > 90 Then Return 5 'Màu nhạt---
            Return 0
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Sub Redraw(Optional ByVal SetCursor As Boolean = True)
        Try
            Dim bm = New Bitmap(cImageFile)
            Dim x As Integer
            Dim y As Integer
            Dim oc As Color
            Dim nc As Color
            Dim rc As Byte
            cThumbScale = bm.Width / (cPic.Width - 2)
            If bm.Height > bm.Width Then cThumbScale = bm.Height / (cPic.Height - 2)
            For x = 0 To bm.Width - 1
                For y = 0 To bm.Height - 1
                    oc = bm.GetPixel(x, y)
                    If oc.A = 0 Then Continue For 'Bo qua transparent
                    'oc = Color.FromArgb(oc.A, oc.R, oc.G, oc.B)
                    rc = CheckColor(oc)
                    Select Case rc
                        Case 0

                        Case 1
                            Select Case cTeam
                                Case 1 'Sua mau Ta -> Dich
                                    nc = Color.FromArgb(oc.A, 0, 0, 255)
                                    bm.SetPixel(x, y, nc)
                                Case 2 'Sua mau Ta -> mau tuy chon
                                    bm.SetPixel(x, y, mColor)
                            End Select
                            Continue For
                        Case 3 'Sua mau dem
                            nc = Color.FromArgb(oc.A, sColor)
                            bm.SetPixel(x, y, nc)
                            Continue For
                        Case 2 'Sua mau Dich -> ta
                            If cTeam = 1 Then
                                nc = Color.FromArgb(oc.A, 255, 0, 0)
                                bm.SetPixel(x, y, nc)
                                Continue For
                            End If

                    End Select
                Next
            Next
            'Lật hình---
            If cFlip Then bm.RotateFlip(RotateFlipType.RotateNoneFlipX)
            If cCap <> vbNullString Then DrawText(bm)
            cPic.Image = bm
            cPic.Refresh()
            If SetCursor Then SaveCursor()
        Catch ex As Exception
            cPic.Image = cPic.ErrorImage
        End Try
    End Sub

    Private Sub DrawText(bm As Bitmap)
        Dim Gr = Graphics.FromImage(bm)
        Dim s As Single = cThumbScale
        Dim x As Single = cPos.X
        Dim y As Single = cPos.Y
        'Dich chuyen toa do bo di phan thua chech lenh anh vuong
        If bm.Width > bm.Height Then
            y -= (cPic.Height - 2 - bm.Height / s) / 2
        Else
            x -= (cPic.Width - 2 - bm.Width / s) / 2
        End If
        x -= 1.5
        y += 1.5
        'Chuyen toa do tu Thumb ve anh that--
        x *= s
        y *= s
        Dim rs As SizeF = Gr.MeasureString(cCap, cFont)
        x -= rs.Width / 2
        y -= rs.Height / 2
        Dim rg = New RectangleF(x, y, rs.Width, rs.Height)
        Dim b = New SolidBrush(Color.Black)
        If cTeam > 0 Then b = New SolidBrush(mColor)
        Gr.DrawString(cCap, cFont, b, rg)
    End Sub
    Private Sub SaveCursor()
        Try
            Const cs = 32
            Dim bm = New Bitmap(cs, cs)
            Dim gr As Graphics = Graphics.FromImage(bm)

            'Draw sign---
            Dim w As Single = cPic.Image.Width
            Dim h As Single = cPic.Image.Height
            Dim s As Single = w / cs
            If h > w Then s = h / cs
            w /= s
            h /= s
            gr.DrawImage(cPic.Image, 0, 0, w, h)

            'Draw pointer---
            Dim dc As Cursor = Cursors.Default
            Dim rc = New Rectangle(New Point(0, 0), dc.Size)
            dc.Draw(gr, rc)
            'Save cursor to file---
            Dim fn As String = AppPath & "\Cursor.cur"
            Dim fs = New FileStream(fn, FileMode.Create, FileAccess.Write)
            Dim ic As Icon = Icon.FromHandle(bm.GetHicon)
            ic.Save(fs)
            fs.Close()
            cSw.Window.SetInputMode(MouseInputMode.MI_COM_CLIENT, fn, True)
        Catch ex As Exception

        End Try

    End Sub

End Class
