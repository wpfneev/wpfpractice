Imports System.ComponentModel
Imports System.DirectoryServices
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Windows.Markup
Imports DataAccess
Imports DataAccess.Repositories
Imports DataAccess.VeritionDBContext
Public Class Home
    Dim repo As New UserRepository(New VeritionDBContext)
    Dim dataSource As ICollectionView
    Private Sub btn_Fetch_Click(sender As Object, e As RoutedEventArgs) Handles btn_Fetch.Click
        ''The below code is to assign the datasource for the grid
        ''grid_Info.ItemsSource = repo.GetAll
        ''Or we can get the collections view source from the object and assign that
        dataSource = CollectionViewSource.GetDefaultView(repo.GetAll)

        If Len(Trim(txt_search.Text)) > 0 Then dataSource.Filter = New Predicate(Of Object)(Function(x) x.Name.Contains(txt_search.Text))

        grid_Info.ItemsSource = dataSource

        cmb_SortGrid.ItemsSource = GetColumns()
    End Sub

    Private Function GetColumns() As ICollectionView
        Dim cols = GetType(UserInformation).GetProperties().AsEnumerable().Select(Function(prop)
                                                                                      Return prop.Name
                                                                                  End Function)
        Return CollectionViewSource.GetDefaultView(cols)
    End Function
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        ''Window loaded event handler
    End Sub
    Private Sub grid_Info_LoadingRowDetails(sender As Object, e As DataGridRowDetailsEventArgs)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As RoutedEventArgs)
        'Dim src = grid_Info.ItemsSource
        'Debug.WriteLine($"User information {txt_userId.Text}")
        ''validate the empty text boxes.
        If Len(Trim(txt_userId.Text)) > 0 Then
            Dim user As UserInformation = repo.Get(txt_userId.Text)
            repo.Delete(user)
            btn_Fetch_Click(Nothing, New RoutedEventArgs)
            btn_Add_Click(Nothing, New RoutedEventArgs)
        End If
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As RoutedEventArgs)
        Dim userInfo As New UserInformation
        DataContext = userInfo
        SetControlBinding(txt_userId, "UserId")
        SetControlBinding(txt_Name, "Name")
        SetControlBinding(txt_Email, "Email")
        SetControlBinding(txt_Password, "Password")
        ''repo.Add(userInfo)
        ''We have to open a new window or page. End user needs to add these details from UI.
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As RoutedEventArgs)
        Dim email As String = txt_Email.Text
        ''what is datacontext and how we can retrieve that value

        ''Validate the inputs provided by the user, whether the data is correctly entered or not.

        Dim userInfo As UserInformation
        If Len(Trim(txt_userId.Text)) = 0 Then
            userInfo = New UserInformation With {
                .Name = txt_Name.Text,
                .Email = txt_Email.Text,
                .Password = txt_Password.Text,
                .UserId = txt_userId.Text
            }
            repo.Add(userInfo) ''Notify the user about the addition of the data
        Else
            userInfo = repo.Get(txt_userId.Text)
            With userInfo
                .Name = txt_Name.Text
                .Email = txt_Email.Text
                .Password = txt_Password.Text
            End With
            repo.Update(userInfo)
        End If
        btn_Fetch_Click(Nothing, New RoutedEventArgs)

        ''UserInformationDB.Update(DataContext)
    End Sub
    Private Sub grid_Info_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        SetControlBinding(txt_userId, "UserId", True)
        SetControlBinding(txt_Name, "Name", True)
        SetControlBinding(txt_Email, "Email", True)
        SetControlBinding(txt_Password, "Password", True)
    End Sub

    Private Sub SetControlBinding(CtrlTextBox As TextBox, bindProp As String, Optional DoesContainElement As Boolean = False)
        Dim binder As New Binding With {
            .Path = New PropertyPath("SelectedItem." & bindProp),
            .Mode = BindingMode.TwoWay
        }
        If DoesContainElement Then binder.ElementName = "grid_Info"

        CtrlTextBox.SetBinding(TextBox.TextProperty, binder)
    End Sub
    Private Sub cmb_SortGrid_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)

        ''dataSource.SortDescriptions.Add(New SortDescription("Name", SortDirection.Ascending))

        ''grid_Info.Items.SortDescriptions.Add(New SortDescription(cmb_SortGrid.SelectedIndex, direction))
        ''Getting the method used to sort in the grid using reflection
        Dim performSortMethod = GetType(DataGrid).GetMethod("PerformSort", BindingFlags.Instance Or BindingFlags.NonPublic)
        performSortMethod?.Invoke(grid_Info, New Object() {grid_Info.Columns(cmb_SortGrid.SelectedIndex)})

    End Sub

    Private Sub grid_Info_Sorting(sender As Object, e As DataGridSortingEventArgs)
        Dim direction As SortDirection

        If rad_az.IsChecked Then direction = SortDirection.Descending Else direction = SortDirection.Ascending
        e.Column.SortDirection = direction

    End Sub

End Class
