Imports System.ComponentModel.DataAnnotations
Imports DataAccess
''validation styles https://www.codeproject.com/tips/1113391/validation-in-wpf-various-wpf-validation-ways. Here I used IDataErrorInfo implementation with the indexers.
''https://existek.com/blog/wpf-validation-whole-form-button-click/
Public Class DataBindingValidations
    Dim SourceData As New ExampleValidation

    Protected Overrides Sub OnActivated(e As EventArgs)
        DataContext = SourceData
        MyBase.OnActivated(e)
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        Console.Write(Validation.GetHasError(sender))

        txtBlock_valid.Text = "Source Data Object props Name: " & SourceData.Name & " Age: " & SourceData.Age & " Description: " & SourceData.Description
    End Sub

    Private Function IsValid(Obj As DependencyObject) As Boolean
        Return Not Validation.GetHasError(Obj)
        ''And LogicalTreeHelper.GetChildren(Obj).OfType(Of DependencyObject)().All(IsValid)
    End Function
End Class
