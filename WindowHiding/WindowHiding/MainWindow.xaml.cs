using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowHiding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ChildWindow _childWindow;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showChildWindowButton_Click(object sender, RoutedEventArgs e)
        {
            // Create the window if it's not already created
            if (_childWindow == null)
                _childWindow = new ChildWindow();
            _childWindow.Show();
        }

        private void Window_Closing(object sender, RoutedEventArgs e)
        {
            // Close the child window only when this window closes
            _childWindow.Close();
        }
    }
}
