Imports System.Data.OleDb

Public Class DataObject
    Private ReadOnly Con As OleDbConnection
    Private ReadOnly Da As OleDbDataAdapter
    Private ReadOnly Cm As OleDbCommand
    Private mDt As DataTable
    Private mFileName As String
    Sub New(Optional ByVal FileName As String = vbNullString)
        Con = New OleDbConnection
        Da = New OleDbDataAdapter
        Cm = New OleDbCommand
        mFileName = FileName
        ConnectData()
    End Sub
    Friend Function ConnectData() As Boolean
        If mFileName = vbNullString Then Return False
        Con.Close()
        Con.ConnectionString = "Provider=microsoft.ace.oledb.12.0; data source=" & mFileName & ";Jet OLEDB:Database Password=bbdqk5 ;"
        Con.Open()
        If Con.State = ConnectionState.Open Then
            Cm.Connection = Con
            Da.SelectCommand = Cm
            Return True
        Else
            Return False
        End If
    End Function
    Friend Sub CloseData()
        Try
            Cm.Dispose()
            Da.Dispose()
            Con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Friend Function Execute(sCmd As String) As Integer
        Cm.CommandText = sCmd
        Return Cm.ExecuteNonQuery()
    End Function

    Friend Function Filldata(sCmd As String) As DataTable
        Dim dt As New DataTable
        If Con.State <> ConnectionState.Open Then
            Cm.CommandText = sCmd
            Da.Fill(dt)
        End If
        Return dt
    End Function
    Friend Sub Opendata(sCmd As String)

        If Con.State = ConnectionState.Open Then
            mDt = New DataTable
            Cm.CommandText = sCmd
            Da.Fill(mDt)
        End If
    End Sub

    Friend Function GetState() As ConnectionState
        Return Con.State
    End Function

    Friend Property FileName As String
        Set(value As String)
            mFileName = value
            ConnectData()
        End Set
        Get
            Return mFileName
        End Get
    End Property
    Friend ReadOnly Property Table As DataTable
        Get
            Return mDt
        End Get
    End Property

    Protected Overrides Sub Finalize()
        CloseData()
        MyBase.Finalize()
    End Sub
End Class
