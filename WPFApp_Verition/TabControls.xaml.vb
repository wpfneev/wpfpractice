Imports Microsoft.EntityFrameworkCore.Metadata.Internal
''Good example to work on the commands binding to the window objects
''https://stackoverflow.com/questions/13359518/xaml-tabcontrol-in-the-top-of-window
Public Class TabControls

    Public Shared ReadOnly CloseCommandProperty As DependencyProperty = DependencyProperty.Register("CloseCommand", GetType(ICommand), GetType(TabControls), New PropertyMetadata(Nothing))
    Public Shared ReadOnly MinimizeCommandProperty As DependencyProperty = DependencyProperty.Register("MinimizeCommand", GetType(ICommand), GetType(TabControls), New PropertyMetadata(Nothing))
    Public Shared ReadOnly MaximizeCommandProperty As DependencyProperty = DependencyProperty.Register("MaximizeCommand", GetType(ICommand), GetType(TabControls), New PropertyMetadata(Nothing))

    Public Property CloseCommand() As ICommand
        Get
            Return DirectCast(GetValue(CloseCommandProperty), ICommand)
        End Get
        Set(ByVal value As ICommand)
            SetValue(CloseCommandProperty, value)
        End Set
    End Property

    Public Property MinimizeCommand() As ICommand
        Get
            Return DirectCast(GetValue(MinimizeCommandProperty), ICommand)
        End Get
        Set(value As ICommand)
            SetValue(MinimizeCommandProperty, value)
        End Set
    End Property
    Public Property MaximizeCommand() As ICommand
        Get
            Return DirectCast(GetValue(MaximizeCommandProperty), ICommand)
        End Get
        Set(value As ICommand)
            SetValue(MaximizeCommandProperty, value)
        End Set
    End Property

    Public Sub New()
        CloseCommand = New RoutedCommand("CloseCommand", GetType(TabControls))
        MinimizeCommand = New RoutedCommand("MinimizeCommand", GetType(TabControls))
        MaximizeCommand = New RoutedCommand("MaximizeCommand", GetType(TabControls))

        CommandBindings.Add(New CommandBinding(CloseCommand, New ExecutedRoutedEventHandler(Sub(Obj, e) Me.Close()), New CanExecuteRoutedEventHandler(Sub(Obj, e) e.CanExecute = True)))
        CommandBindings.Add(New CommandBinding(MinimizeCommand, New ExecutedRoutedEventHandler(Sub(Obj, e) Me.WindowState = WindowState.Minimized), New CanExecuteRoutedEventHandler(Sub(Obj, e) e.CanExecute = True)))
        CommandBindings.Add(New CommandBinding(MaximizeCommand, New ExecutedRoutedEventHandler(Sub(Obj, e) Me.WindowState = WindowState.Maximized), New CanExecuteRoutedEventHandler(Sub(obj, e) e.CanExecute = True)))

    End Sub
End Class
