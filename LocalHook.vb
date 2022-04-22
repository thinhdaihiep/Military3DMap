Imports System.Runtime.InteropServices

Public Class LocalHook
    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Overloads Shared Function GetModuleHandle(name As String) As IntPtr
    End Function
    <DllImport("User32.dll", SetLastError:=True)> 'CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function SetWindowsHookEx(ByVal HookType As Integer, ByVal HookProc As HookDelegate, ByVal hInstance As IntPtr, ByVal wParam As Integer) As IntPtr
    End Function
    <DllImport("User32.dll", SetLastError:=True)>
    Private Overloads Shared Function UnhookWindowsHookEx(ByVal idHook As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Private Overloads Shared Function CallNextHookEx(ByVal idHook As IntPtr, ByVal nCode As IntPtr, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    Public Enum HookTypes
        WH_JOURNALRECORD = 0
        WH_JOURNALPLAYBACK = 1
        WH_KEYBOARD = 2
        WH_GETMESSAGE = 3
        WH_CALLWNDPROC = 4
        WH_CBT = 5
        WH_SYSMSGFILTER = 6
        WH_MOUSE = 7
        WH_HARDWARE = 8
        WH_DEBUG = 9
        WH_SHELL = 10
        WH_FOREGROUNDIDLE = 11
        WH_CALLWNDPROCRET = 12
        WH_KEYBOARD_LL = 13
        WH_MOUSE_LL = 14
    End Enum

    Public Delegate Function HookDelegate(ByVal code As IntPtr, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Public Delegate Sub HookEventHandler(ByVal Sender As Object, ByVal e As HookEventArgs)
    Public Event HookInvoked As HookEventHandler
    Protected m_hookType As HookTypes
    Protected m_HookHandle As HookDelegate
    Protected m_HookID As IntPtr = IntPtr.Zero

    Public Sub InstallHook(Optional ByVal HookType As HookTypes = HookTypes.WH_KEYBOARD_LL)
        Dim ModuleID As IntPtr
        Dim ModuleName As String = Process.GetCurrentProcess().MainModule.ModuleName
        Dim ThreadID As Integer = AppDomain.GetCurrentThreadId
        ModuleID = GetModuleHandle(ModuleName)
        m_HookHandle = New HookDelegate(AddressOf HookProdurce)
        m_HookID = SetWindowsHookEx(HookType, m_HookHandle, ModuleID, ThreadID)
        If m_HookID = 0 Then 'Hook fail!
            UnhookWindowsHookEx(m_HookID)
        End If
    End Sub
    Protected Function HookProdurce(ByVal Code As IntPtr, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If Code = IntPtr.Zero Then Return CallNextHookEx(m_HookID, Code, wParam, lParam)
        Dim e = New HookEventArgs
        e.HookCode = Code
        e.wParam = wParam
        e.lParam = lParam
        RaiseEvent HookInvoked(Me, e)
        CallNextHookEx(m_HookID, Code, wParam, lParam)
    End Function
    Protected Overrides Sub Finalize()
        If Not m_HookID = IntPtr.Zero Then UnhookWindowsHookEx(m_HookID)
        MyBase.Finalize()
    End Sub
End Class

Public Class HookEventArgs
    Inherits EventArgs
    Public HookCode As IntPtr
    Public wParam As IntPtr
    Public lParam As IntPtr
End Class

