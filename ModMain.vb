Imports System.Runtime.InteropServices

Module ModMain
    Public Structure SYSTEMTIME
        Public wYear As Integer
        Public wMonth As Integer
        Public wDayOfWeek As Integer
        Public wDay As Integer
        Public wHour As Integer
        Public wMinute As Integer
        Public wSecond As Integer
        Public wMilliseconds As Integer
    End Structure
    Public WithEvents TimeHack As LocalHook
    Sub Main()
        TimeHack = New LocalHook
        TimeHack.InstallHook()
        FrmMain.Show()
    End Sub

    Private Sub TimeHack_HookInvoked(Sender As Object, e As HookEventArgs) Handles TimeHack.HookInvoked
        'Dim Faketime As SYSTEMTIME
        'Faketime = Marshal.PtrToStructure(e.lParam, GetType(SYSTEMTIME))
        'Faketime.wYear = 2019
        MsgBox(Chr(e.wParam))
    End Sub
End Module
