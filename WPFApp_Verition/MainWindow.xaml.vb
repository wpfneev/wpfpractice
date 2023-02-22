Imports DataAccess
Imports DataAccess.Repositories
Class MainWindow

    Private Sub btn_SetValue_Click(sender As Object, e As RoutedEventArgs) Handles btn_SetValue.Click
        Dim repo As New UserRepository(New VeritionDBContext)
        Dim allUsers = repo.GetAll().ToList()
        Dim user = From u In allUsers Where u.Name.ToLower().Equals(txt_username.Text, StringComparison.InvariantCultureIgnoreCase) And u.Password.Equals(txt_password.Password, StringComparison.InvariantCulture) Select u

        If user.Any Then
            Me.Hide()
            Dim h As New MDIWindow
            h.Show()
        End If
    End Sub
End Class

