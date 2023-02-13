Imports System.Net.Http

Public Class ElementsOverview

    Private Sub Hyperlink_RequestNavigate(sender As Object, e As RequestNavigateEventArgs)
        Dim client As New HttpClient
        Dim taskResult = client.GetAsync(e.Uri.AbsoluteUri)
        Dim httpResponse = taskResult.GetAwaiter().GetResult()
        Dim stringResult = httpResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult()
        Console.WriteLine(stringResult)
        ''System.Diagnostics.Process.Start(e.Uri.AbsoluteUri)
    End Sub
End Class
