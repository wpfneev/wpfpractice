Public Class MDIWindow
    Private Sub MenuItem_Click(sender As Object, e As RoutedEventArgs)
        Dim staticform As Window

        Select Case DirectCast(sender, MenuItem).Header
            Case "Static-Examples"
                staticform = New ElementsOverview()
                ViewWindow.Content = staticform.Content
            Case "Validations"
                staticform = New DataBindingValidations()
                ViewWindow.Content = staticform.Content
            Case "DataGrid"
                staticform = New Home()
                ViewWindow.Content = staticform.Content
            Case "DataGrid-window"
                staticform = New Home()
                staticform.ShowDialog()
        End Select
    End Sub
End Class
