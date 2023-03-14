Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Public Class WindowPropChanger
    ''Changing the parent control property with the help of binding.. https://stackoverflow.com/questions/42659813/binding-wpf-user-control-to-parent-property
    ''Placing controls next to another https://stackoverflow.com/questions/18235010/how-can-i-add-a-clear-button-to-a-textbox-in-wpf
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim itList As New List(Of ItControlList)

        Dim item As New ItControlList()
        item.txtBox = "hello"
        item.btnSearch = "one"

        itList.Add(item)

        icList.ItemsSource = itList
    End Sub
    Private Sub btn_Apply_Click(sender As Object, e As RoutedEventArgs)
        ''Dim bindingExp As BindingExpression = txt_WindowTitle.GetBindingExpression(TextBox.TextProperty)
        ''Window.GetWindow(Me).Title = txt_WindowTitle.Text
        ''bindingExp.UpdateSource()
    End Sub
End Class

Class ItControlList
    Private _txtBox As String
    Public Property txtBox() As String
        Get
            Return _txtBox
        End Get
        Set(ByVal value As String)
            _txtBox = value
        End Set
    End Property
    Private _btnSearch As String
    Public Property btnSearch() As String
        Get
            Return _btnSearch
        End Get
        Set(ByVal value As String)
            _btnSearch = value
        End Set
    End Property
End Class
