
' Import the necessary namespaces
Imports Newtonsoft.Json.Linq
Public Class Form1
    Public Class WebBrowserHelper
        Private Shared appName As String = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)

        Public Shared Sub SetBrowserEmulationVersion()
            'Internet Explorer 7:  7000
            'Internet Explorer 8:   8000
            'Internet Explorer 9:   9000
            'Internet Explorer 10:   10000
            'Internet Explorer 11:   11001
            'Internet Explorer Edge mode:  11000
            Dim ieVersion As Integer = 11000 ' 11001 represents IE 11. Change this value for other versions.
            SetBrowserFeatureControlKey("FEATURE_BROWSER_EMULATION", ieVersion)
        End Sub

        Private Shared Sub SetBrowserFeatureControlKey(feature As String, value As UInteger)
            Dim appNameWithExe As String = appName & ".exe"
            Using key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\" + feature, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                key.SetValue(appName, value, Microsoft.Win32.RegistryValueKind.DWord)
                key.SetValue(appNameWithExe, value, Microsoft.Win32.RegistryValueKind.DWord)
            End Using
        End Sub
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowserHelper.SetBrowserEmulationVersion()

        WebBrowser1.Navigate("file:///C:/casparcg/vimlesh.html")
    End Sub


    ' ... Inside your method or function
    Private Sub ExtractIDsFromJSON()
        Dim jsonString As String = "{...}" ' Your JSON string goes here

        ' Parse the JSON string
        Dim jsonObject As JObject = JObject.Parse(jsonString)

        ' Access the "objects" array
        Dim objects As JArray = jsonObject("objects")

        ' Iterate through the "objects" array and retrieve the "id" values
        For Each obj As JObject In objects
            Dim id As String = obj("id").ToString()
            TextBox1.AppendText("Object ID: " & id & Environment.NewLine)
        Next
    End Sub

    Private Sub ReadHTMLContent()
        ' Ensure that the Document is not null and the WebBrowser is completely loaded
        If WebBrowser1.Document IsNot Nothing AndAlso WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            Dim document As HtmlDocument = WebBrowser1.Document
            Dim htmlContent As String = document.Body.OuterHtml
            TextBox1.AppendText("HTML Content: " & htmlContent & Environment.NewLine)
        Else
            TextBox1.AppendText("WebBrowser document is not ready." & Environment.NewLine)
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ReadHTMLContent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim scriptElements As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("script")
        Dim thirdScriptContent As String = scriptElements(3).InnerText
        Dim splitContent As String() = thirdScriptContent.Split(New String() {"const content ="}, StringSplitOptions.None)
        Dim splitContent2 As String() = splitContent(1).Split(New String() {"; const { core, studio } ="}, StringSplitOptions.None)
        'TextBox1.Text = splitContent2(0)
        TextBox1.Text = ""

        Dim jsonString As String = splitContent2(0) ' Your JSON string goes here

        ' Parse the JSON string
        Dim jsonObject As JObject = JObject.Parse(jsonString)

        ' Access the "objects" array
        Dim objects As JArray = jsonObject("objects")

        ' Iterate through the "objects" array and retrieve the "id" and "type" values
        For Each obj As JObject In objects
            Dim id As String = obj("id").ToString()
            Dim type As String = obj("type").ToString()
            TextBox1.AppendText("Object ID: " & id & ", Type: " & type & Environment.NewLine)
        Next


    End Sub
End Class
