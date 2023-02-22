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
    Dim isHeaderChecked = False
    Private Sub cbx_selectAll_Checked(sender As Object, e As RoutedEventArgs)
        Dim isHeaderSelected As Boolean = False
        isHeaderChecked = True
        If cbx_selectAll.IsChecked = True Then isHeaderSelected = True
        cbx_cheese.IsChecked = isHeaderSelected
        cbx_garlic.IsChecked = isHeaderSelected
        cbx_tuna.IsChecked = isHeaderSelected
    End Sub

    Private Sub cbx_garlic_Checked(sender As Object, e As RoutedEventArgs)
        cbx_selectAll.IsChecked = Nothing
        If cbx_cheese.IsChecked = True AndAlso cbx_garlic.IsChecked = True AndAlso cbx_tuna.IsChecked = True Then
            cbx_selectAll.IsChecked = True
        End If
        If cbx_cheese.IsChecked = False AndAlso cbx_garlic.IsChecked = False AndAlso cbx_tuna.IsChecked = False Then
            cbx_selectAll.IsChecked = False
        End If
    End Sub
End Class
