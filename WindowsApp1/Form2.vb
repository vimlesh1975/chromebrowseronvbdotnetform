Imports CefSharp
Imports CefSharp.WinForms

Public Class Form2
    Private WithEvents chromeBrowser As ChromiumWebBrowser

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        On Error Resume Next
        AddHandler ChromiumWebBrowser1.FrameLoadEnd, AddressOf OnFrameLoadEnd

        Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, "vimlesh5.html")
        Dim fileUrl As String = "file:///" & filePath.Replace("\", "/")
        ChromiumWebBrowser1.LoadUrl(fileUrl)


    End Sub

    Private Sub OnFrameLoadEnd(sender As Object, e As FrameLoadEndEventArgs)
        ChromiumWebBrowser1.SetZoomLevel(-5)
        'Console.WriteLine(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
