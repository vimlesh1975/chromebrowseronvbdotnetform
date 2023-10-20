Imports CefSharp
Imports CefSharp.WinForms
Imports Svt.Caspar

Public Class Form2
    Private WithEvents chromeBrowser As ChromiumWebBrowser
    Dim casparDevice As New CasparDevice
    Dim aa As New CasparCGDataCollection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        casparDevice.Connect("localhost", 5250)
        On Error Resume Next
        AddHandler ChromiumWebBrowser1.FrameLoadEnd, AddressOf OnFrameLoadEnd

        'Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, "vimlesh5.html")
        Dim filePath As String = "c:/casparcg/vimlesh.html"
        Dim fileUrl As String = "file:///" & filePath.Replace("\", "/")
        ChromiumWebBrowser1.LoadUrl(fileUrl)


    End Sub

    Private Sub OnFrameLoadEnd(sender As Object, e As FrameLoadEndEventArgs)
        ChromiumWebBrowser1.SetZoomLevel(-5)
        'Console.WriteLine(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        aa.SetData("ccgf0", "vimlesh Kumar")
        casparDevice.Channels(0).CG.Add(20, 20, "vimlesh", True, aa.ToAMCPEscapedXml)
    End Sub

    Private Sub ChromiumWebBrowser1_LoadingStateChanged(sender As Object, e As LoadingStateChangedEventArgs) Handles ChromiumWebBrowser1.LoadingStateChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        casparDevice.SendString("call 1-20 " + """" + "sheet.sequence.position = 0;sheet.sequence.play({ range: [0, 1], iterationCount: Infinity });" + """")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        casparDevice.SendString("call 1-20 " + """" + "sheet.sequence.pause()" + """")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        casparDevice.SendString("call 1-20 " + """" + "sheet.sequence.play({ range: [0, 1], iterationCount: Infinity })" + """")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        aa.SetData("ccgf0", "vimlesh Kumar Tanti")
        casparDevice.Channels(0).CG.Update(20, 20, aa)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        casparDevice.Channels(0).CG.Invoke(20, 20, "method1(2)")

    End Sub
End Class
