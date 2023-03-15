Public Class CalculatorItemsCtrl
    Public Property calcText As String
    Private Sub CalculatorItemsCtrl_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim blockNames As New List(Of Block) From {
            New Block("1"),
            New Block("2"),
            New Block("3"),
            New Block("+"),
            New Block("4"),
            New Block("5"),
            New Block("6"),
            New Block("-"),
            New Block("7"),
            New Block("8"),
            New Block("9"),
            New Block("*"),
            New Block("0"),
            New Block("."),
            New Block("="),
            New Block("/")
        }

        itemsCtrl.ItemsSource = blockNames
    End Sub
End Class
Public Class Block
    Public Property blockName As String
    Public Sub New(name)
        blockName = name
    End Sub
End Class