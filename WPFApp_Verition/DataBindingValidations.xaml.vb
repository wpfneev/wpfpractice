Imports DataAccess

Public Class DataBindingValidations
    Dim SourceData As New ExampleValidation

    Protected Overrides Sub OnActivated(e As EventArgs)
        DataContext = SourceData
        MyBase.OnActivated(e)
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        txtBlock_valid.Text = "Source Data Object props Name: " & SourceData.Name & " Age: " & SourceData.Age & " Description: " & SourceData.Description
    End Sub
End Class
