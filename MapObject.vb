Imports System.Security.Claims
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports TerraExplorerX


Public Class MapObject
#Disable Warning BC42017 ' Late bound resolution
    Public Enum MapObjectType
        Other = 0
        Layer = 1
        Label = 2
        ImageLabel = 3
        Polyline = 4
        Polygon = 5
        Geometry3D = 6
        Raster = 7
        Dynamic = 8
        Model3D = 9
    End Enum
    Private cOb As ITerraExplorerObject71
    Private cLayer As ILayerStyle
    Private ReadOnly cSw As ISGWorld71
    Private cID As String
    Sub New(mSw As ISGWorld71)
        cSw = mSw
    End Sub
    Public Function SetID(mID As String) As Boolean
        Try
            cID = mID
            cOb = cSw.ProjectTree.GetObject(mID)
            If cOb.ObjectType = ObjectTypeCode.OT_FEATURE_LAYER Then cLayer = New ILayerStyle(cOb)
            Return True
        Catch ex As Exception
            cOb = Nothing
            Return False
        End Try
    End Function
    Public Sub SaveToFly()
        cOb.SaveInFlyFile = True
    End Sub
    Public Function MaxView(Optional ByVal nVal As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString
            Dim cVis As IVisibility71 = cOb.Visibility
            If nVal <> vbNullString Then
                If cOb.ObjectType = ObjectTypeCode.OT_LABEL Or cOb.ObjectType = ObjectTypeCode.OT_IMAGE_LABEL Then
                    Dim cStyle As ILabelStyle71 = cOb.Style
                    cStyle.MaxViewingHeight = nVal * 1000
                Else
                    If nVal * 1000 < cVis.MinVisibilityDistance Then nVal = cVis.MinVisibilityDistance \ 1000
                    cVis.MaxVisibilityDistance = nVal * 1000
                End If

                Return Nothing
            Else
                If cOb.ObjectType = ObjectTypeCode.OT_LABEL Or cOb.ObjectType = ObjectTypeCode.OT_IMAGE_LABEL Then
                    Dim cStyle As ILabelStyle71 = cOb.Style
                    nVal = cStyle.MaxViewingHeight \ 1000
                Else
                    nVal = cVis.MaxVisibilityDistance \ 1000
                End If

            End If
            Return nVal
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function
    Public Function MinView(Optional ByVal nVal As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString
            Dim cVis As IVisibility71 = cOb.Visibility
            If nVal <> vbNullString Then
                If cOb.ObjectType = ObjectTypeCode.OT_LABEL Or cOb.ObjectType = ObjectTypeCode.OT_IMAGE_LABEL Then
                    Dim cLab As ITerrainLabel71 = cOb
                    cLab.Style.MinViewingHeight = nVal * 1000
                Else
                    If nVal * 1000 > cVis.MaxVisibilityDistance Then nVal = 0
                    cVis.MinVisibilityDistance = nVal * 1000
                End If

                Return Nothing
            Else
                If cOb.ObjectType = ObjectTypeCode.OT_LABEL Or cOb.ObjectType = ObjectTypeCode.OT_IMAGE_LABEL Then
                    Dim cLab As ITerrainLabel71 = cOb
                    nVal = cLab.Style.MinViewingHeight \ 1000
                Else
                    nVal = cVis.MinVisibilityDistance \ 1000
                End If

            End If
            Return nVal
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function
    Public Property Message As IMessageObject71
        Get
            If IsNothing(cOb) Then Return Nothing Else Return cOb.Message
        End Get
        Set(value As IMessageObject71)
            cOb.message = value
        End Set
    End Property
    Public ReadOnly Property ID As String
        Get
            Return cID
        End Get
    End Property

    Public Function ItemName(Optional ByVal mName As String = vbNullString) As String
        Try
            If mName = vbNullString Then Return cSw.ProjectTree.GetItemName(cID) 'Trả về Tên đối tượng nếu tham số đưa vào là Null
            If IsNothing(cOb) Then 'Nếu đối tượng không phải là Object
                If cSw.ProjectTree.IsGroup(cID) Then cSw.ProjectTree.RenameGroup(cID, mName)
            Else
                Dim cItem As ITreeItem71 = cOb.TreeItem
                cItem.Name = mName
            End If
            Return Nothing
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Public Function LabelText(Optional ByVal mText As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString
            If mText = vbNullString Then
                If cOb.ObjectType = ObjectTypeCode.OT_LABEL Then Return cOb.Text
            Else
                If cOb.ObjectType = ObjectTypeCode.OT_LABEL Then cOb.text = mText
            End If
            Return vbNullString
        Catch ex As Exception
            Return vbNullString
        End Try

    End Function

    Public ReadOnly Property Type As MapObjectType
        Get
            Try
                Select Case cOb.ObjectType
                    Case ObjectTypeCode.OT_FEATURE_LAYER
                        Return MapObjectType.Layer
                    Case ObjectTypeCode.OT_LABEL
                        Return MapObjectType.Label
                    Case ObjectTypeCode.OT_IMAGE_LABEL
                        Return MapObjectType.ImageLabel
                    Case ObjectTypeCode.OT_ARC, ObjectTypeCode.OT_CIRCLE, ObjectTypeCode.OT_ELLIPSE, ObjectTypeCode.OT_POLYGON, ObjectTypeCode.OT_RECTANGLE, ObjectTypeCode.OT_REGULAR_POLYGON, ObjectTypeCode.OT_ARROW
                        Return MapObjectType.Polygon
                    Case ObjectTypeCode.OT_POLYLINE
                        Return MapObjectType.Polyline
                    Case ObjectTypeCode.OT_IMAGERY_LAYER
                        Return MapObjectType.Raster
                    Case ObjectTypeCode.OT_DYNAMIC
                        Return MapObjectType.Dynamic
                    Case ObjectTypeCode.OT_3D_ARROW, ObjectTypeCode.OT_3D_POLYGON
                        Return MapObjectType.Geometry3D
                    Case ObjectTypeCode.OT_MODEL
                        Return MapObjectType.Model3D
                    Case Else
                        Exit Select
                End Select
                Return MapObjectType.Other
            Catch ex As Exception
                Return MapObjectType.Other
            End Try
        End Get
    End Property
    Public Function Order(Optional ByVal mVal As String = vbNullString) As Integer
        Try
            If IsNothing(cOb) Then Return 0
            Select Case cOb.ObjectType
                Case ObjectTypeCode.OT_FEATURE_LAYER
                    If mVal = vbNullString Then Return cLayer.Order
                    cLayer.Order = CInt(mVal)
                Case ObjectTypeCode.OT_LABEL, ObjectTypeCode.OT_IMAGE_LABEL
                    'Nothing to Order a Label
                Case Else
                    Dim cTob As ITerrainObject71 = cOb.Terrain
                    If mVal = vbNullString Then Return cTob.DrawOrder
                    cTob.DrawOrder = CInt(mVal)
            End Select
            Return 0
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public ReadOnly Property ObjectType As ObjectTypeCode
        Get
            Return cOb.ObjectType
        End Get
    End Property
    Public ReadOnly Property LabelStyle As ILabelStyle71

        Get
            Dim cLabel As ITerrainLabel71 = cOb
            Return cLabel.Style
        End Get
    End Property
    Public ReadOnly Property LayerStyle As ILayerStyle
        Get
            Return cLayer
        End Get
    End Property

    Public Function FileName(Optional ByVal nVal As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString
            Select Case cOb.ObjectType
                Case ObjectTypeCode.OT_IMAGE_LABEL
                    Dim cLab As ITerrainImageLabel71 = cOb
                    If nVal <> vbNullString Then cLab.ImageFileName = nVal
                    Return cLab.ImageFileName
                Case ObjectTypeCode.OT_LABEL
                    Dim cLab As ITerrainLabel71 = cOb
                    If nVal <> vbNullString Then cLab.ImageFileName = nVal
                    Return cLab.ImageFileName
                Case ObjectTypeCode.OT_DYNAMIC
                    Dim cDnm As ITerrainDynamicObject71 = cOb
                    If nVal <> vbNullString Then cDnm.FileName = nVal
                    Return cDnm.FileName
                Case ObjectTypeCode.OT_FEATURE_LAYER
                    If nVal <> vbNullString Then cLayer.FileName = nVal
                    Return cLayer.FileName
                Case ObjectTypeCode.OT_MODEL
                    Dim cMod As ITerrainModel71 = cOb
                    If nVal <> vbNullString Then cMod.ModelFileName = nVal
                    Return cMod.ModelFileName
                Case Else
                    Dim cFill As IFillStyle71 = cOb.FillStyle
                    If nVal <> vbNullString Then cFill.Texture.FileName = nVal
                    Return cFill.Texture.FileName
            End Select
            Return vbNullString
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function
    Public Function Scale(Optional ByVal nVal As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString
            Dim sVal As Double = CDbl(nVal)
            Select Case cOb.ObjectType
                Case ObjectTypeCode.OT_IMAGE_LABEL, ObjectTypeCode.OT_LABEL
                    Dim cStyle As ILabelStyle71 = cOb.Style
                    If nVal <> vbNullString Then cStyle.Scale = sVal
                    Return cStyle.Scale.ToString
                Case ObjectTypeCode.OT_DYNAMIC
                    Dim cDm As ITerrainDynamicObject71 = cOb
                    If nVal <> vbNullString Then cDm.ScaleFactor = sVal
                    Return cDm.ScaleFactor.ToString
                Case ObjectTypeCode.OT_MODEL
                    Dim cMod As ITerrainModel71 = cOb
                    If nVal <> vbNullString Then cMod.ScaleFactor = sVal
                    Return cMod.ScaleFactor.ToString
                Case Else
                    Exit Select
            End Select
            Return vbNullString
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Public Function LineWidth(Optional ByVal nVal As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString
            Dim sVal As Integer = CInt(nVal)
            Select Case cOb.ObjectType
                Case ObjectTypeCode.OT_FEATURE_LAYER
                    If nVal <> vbNullString Then cLayer.LineWidth = sVal
                    Return cLayer.LineWidth.ToString
                    'Case ObjectTypeCode.OT_ARC, ObjectTypeCode.OT_CIRCLE, ObjectTypeCode.OT_ELLIPSE, ObjectTypeCode.OT_POLYGON, ObjectTypeCode.OT_POLYLINE, ObjectTypeCode.OT_RECTANGLE, ObjectTypeCode.OT_REGULAR_POLYGON, ObjectTypeCode.OT_ARROW, ObjectTypeCode.OT_IMAGERY_LAYER
                Case Else
                    Dim cLine As ILineStyle71 = cOb.LineStyle
                    If nVal <> vbNullString Then cLine.Width = sVal
                    Return cLine.Width.ToString
            End Select
            Return vbNullString
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Public Function LineColor(Optional ByVal nVal As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString

            Select Case cOb.ObjectType
                Case ObjectTypeCode.OT_FEATURE_LAYER
                    If nVal <> vbNullString Then cLayer.LineColor = nVal
                    Return cLayer.LineColor
                Case ObjectTypeCode.OT_LABEL
                    Dim cStyle As ILabelStyle71 = cOb.Style
                    If nVal <> vbNullString Then
                        cStyle.BackgroundColor.FromHTMLColor(nVal)
                        cStyle.BackgroundColor.SetAlpha(0)
                    End If
                    Return cStyle.BackgroundColor.ToHTMLColor
                Case Else
                    Dim cLine As ILineStyle71 = cOb.LineStyle
                    If nVal <> vbNullString Then cLine.Color.FromHTMLColor(nVal)
                    Return cLine.Color.ToHTMLColor
            End Select
            Return vbNullString
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Public Function LineOpacity(Optional ByVal nVal As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString

            Dim sVal As Double = CDbl(nVal)
            Select Case cOb.ObjectType
                Case ObjectTypeCode.OT_FEATURE_LAYER
                    If nVal <> vbNullString Then cLayer.LineOpacity = sVal / 100
                    Return Format(cLayer.LineOpacity * 100, "0")
                'Case ObjectTypeCode.OT_ARC, ObjectTypeCode.OT_CIRCLE, ObjectTypeCode.OT_ELLIPSE, ObjectTypeCode.OT_POLYGON, ObjectTypeCode.OT_RECTANGLE, ObjectTypeCode.OT_REGULAR_POLYGON, ObjectTypeCode.OT_ARROW, ObjectTypeCode.OT_IMAGERY_LAYER
                Case ObjectTypeCode.OT_LABEL
                    Dim cStyle As ILabelStyle71 = cOb.Style
                    Return Format(cStyle.BackgroundColor.GetAlpha * 100, "0")

                Case Else
                    Dim cLine As ILineStyle71 = cOb.LineStyle
                    If nVal <> vbNullString Then cLine.Color.SetAlpha(sVal / 100)
                    Return Format(cLine.Color.GetAlpha * 100, "0")
            End Select
            Return vbNullString
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function
    Public Function FillColor(Optional ByVal nVal As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString

            Select Case cOb.ObjectType
                Case ObjectTypeCode.OT_FEATURE_LAYER
                    If nVal <> vbNullString Then cLayer.FillColor = nVal
                    Return cLayer.FillColor
                Case ObjectTypeCode.OT_LABEL
                    Dim cStyle As ILabelStyle71 = cOb.Style
                    If nVal <> vbNullString Then cStyle.TextColor.FromHTMLColor(nVal)
                    Return cStyle.TextColor.ToHTMLColor
                Case ObjectTypeCode.OT_IMAGE_LABEL
                    Dim cStyle As ILabelStyle71 = cOb.Style
                    If nVal <> vbNullString Then cStyle.IconColor.FromHTMLColor(nVal)
                    Return cStyle.IconColor.ToHTMLColor
                Case Else
                    Dim cStyle As IFillStyle71 = cOb.FillStyle
                    If nVal <> vbNullString Then cStyle.Color.FromHTMLColor(nVal)
                    Return cStyle.Color.ToHTMLColor
            End Select
            Return vbNullString
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Public Function FillOpacity(Optional ByVal nVal As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString
            Dim sVal As Double = CDbl(nVal)
            Select Case cOb.ObjectType
                Case ObjectTypeCode.OT_FEATURE_LAYER
                    If nVal <> vbNullString Then cLayer.FillOpacity = sVal / 100
                    Return Format(cLayer.FillOpacity * 100, "0")
                Case ObjectTypeCode.OT_LABEL
                    Dim cStyle As ILabelStyle71 = cOb.Style
                    If nVal <> vbNullString Then cStyle.TextColor.SetAlpha(sVal / 100)
                    Return Format(cStyle.TextColor.GetAlpha * 100, "0")
                Case ObjectTypeCode.OT_IMAGE_LABEL
                    Dim cStyle As ILabelStyle71 = cOb.Style
                    If nVal <> vbNullString Then cStyle.IconColor.SetAlpha(sVal / 100)
                    Return Format(cStyle.IconColor.GetAlpha * 100, "0")
                Case Else
                    Dim cFill As IFillStyle71 = cOb.FillStyle
                    If nVal <> vbNullString Then cFill.Color.SetAlpha(sVal / 100)
                    Return Format(cFill.Color.GetAlpha * 100, "0")
            End Select
            Return vbNullString
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Public Function Distance(Optional ByVal nVal As String = vbNullString) As String
        Try
            If IsNothing(cOb) Then Return vbNullString
            Dim sVal As Double = CDbl(nVal) * 1000
            Dim cPos As IPosition71 = cOb.Position
            If nVal <> vbNullString Then cPos.Distance = sVal
            Return (cPos.Distance \ 1000).ToString
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Public Function Visible(Optional ByVal nVal As Boolean = Nothing) As Boolean
        Try
            If IsNothing(cOb) Then Return Nothing
            Dim cVis As IVisibility71 = cOb.Visibility
            If Not IsNothing(nVal) Then cVis.Show = nVal
            Return cVis.Show
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Function ToHexColor(c As Color) As String
        Dim rSt As String
        rSt = "#" & c.R.ToString("X2") & c.G.ToString("X2") & c.B.ToString("X2")
        Return rSt
    End Function

End Class
Public Class ILayerStyle
    Public Enum TerraPattern
        LS_SOLID = &HFFFFFFFF
        LS_XLARGE_DASH = &HFFF00FFF
        LS_LARGE_DASH = &HFF0000FF
        LS_MEDIUM_DASH = &HF00FF00F
        LS_SMALL_DASH = &HC3C3C3C3
        LS_TINY_DASH = &H99999999
        LS_DOTS = &HAAAAAAAA
        LS_DASH_DOT_DASH = &HFF0180FF
        LS_DASH_DOT_DOT_DASH = &HFF0C30FF
    End Enum
    Private ReadOnly cLgr As IFeatureGroup71
    Private ReadOnly cLay As IFeatureLayer71
    Sub New(mOb As ITerraExplorerObject71)
        cLay = mOb
        Select Case cLay.GeometryType
            Case LayerGeometryType.LGT_POINT
                cLgr = cLay.FeatureGroups.Point
            Case LayerGeometryType.LGT_POLYLINE
                cLgr = cLay.FeatureGroups.Polyline
            Case LayerGeometryType.LGT_POLYGON
                cLgr = cLay.FeatureGroups.Polygon
            Case Else
                cLgr = cLay.FeatureGroups.Polygon
        End Select
    End Sub
    Public Property Order As Integer
        Get
            Return cLgr.GetProperty("Order")
        End Get
        Set(value As Integer)
            cLay.FeatureGroups.SetProperty("Order", value)
        End Set
    End Property
    Public Property LineWidth As Integer

        Set(value As Integer)
            cLay.FeatureGroups.SetProperty("Line Width", value)
        End Set
        Get
            Return cLgr.GetProperty("Line Width")
        End Get
    End Property
    Public Property LineColor As String
        Set(value As String)
            Dim sCo As Color = ColorTranslator.FromHtml(value)
            Dim sVal As Integer = ColorTranslator.ToOle(sCo)
            cLay.FeatureGroups.SetProperty("Line Color", sVal)
        End Set
        Get
            Dim rVal As Integer
            Dim rCo As Color
            rVal = cLgr.GetProperty("Line Color")
            rCo = ColorTranslator.FromOle(rVal)
            Return ColorTranslator.ToHtml(rCo)
        End Get
    End Property
    Public Property LineOpacity As Double
        Set(value As Double)
            cLay.FeatureGroups.SetProperty("Line Opacity", value)
        End Set
        Get
            Return cLgr.GetProperty("Line Opacity")
        End Get
    End Property
    Public Property LinePattern As TerraPattern
        Set(value As TerraPattern)
            cLay.FeatureGroups.SetProperty("Line Pattern", value)
        End Set
        Get
            Return cLgr.GetProperty("Line Pattern")
        End Get
    End Property

    Public Property FillColor As String

        Set(value As String)
            Dim sCo As Color = ColorTranslator.FromHtml(value)
            Dim sVal As Integer = ColorTranslator.ToOle(sCo)
            cLay.FeatureGroups.SetProperty("Fill Color", sVal)
        End Set
        Get
            Dim rCo As Color
            Dim rVal As Integer
            rVal = cLgr.GetProperty("Fill Color")
            rCo = ColorTranslator.FromOle(rVal)
            Return ToHexColor(rCo)
        End Get
    End Property
    Private Function ToHexColor(c As Color) As String
        Dim rSt As String
        rSt = "#" & c.R.ToString("X2") & c.G.ToString("X2") & c.B.ToString("X2")
        Return rSt
    End Function
    Public Property FillOpacity As Double
        Set(value As Double)
            cLay.FeatureGroups.SetProperty("Fill Opacity", value)
        End Set
        Get
            Return cLgr.GetProperty("Fill Opacity")
        End Get
    End Property
    Public Property FileName As String
        Set(value As String)
            LayerFileName(value)
        End Set
        Get
            Return LayerFileName()
        End Get
    End Property
    Private Function LayerFileName(Optional ByVal nFile As String = vbNullString) As String
        Try
            Dim cSt As String = cLay.DataSourceInfo.ConnectionString
            Dim Pst() As String = cSt.Split(";")
            Dim mFile As String = vbNullString
            For Each mFile In Pst
                If InStr(mFile, "filename=", CompareMethod.Text) Then
                    mFile = Replace(mFile, "Filename=", vbNullString, 1, -1, CompareMethod.Text)
                    Exit For
                End If
            Next
            If nFile = vbNullString Then
                If InStr(mFile, "\") = 0 Then mFile = "File invalid"
                Return mFile
            Else
                cSt = Replace(cSt, mFile, nFile)
                cLay.DataSourceInfo.ConnectionString = cSt
                Return nFile
            End If
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function
#Enable Warning BC42017 ' Late bound resolution
End Class

