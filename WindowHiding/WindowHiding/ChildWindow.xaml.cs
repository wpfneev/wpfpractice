using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace WindowHiding
{
    /// <summary>
    /// Interaction logic for ChildWindow.xaml
    /// </summary>
    public partial class ChildWindow : Window
    {
        private bool _Close;
        public ChildWindow()
        {
            InitializeComponent();
            firstShownTome.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture);
        }

        public new void Close()
        {
            _Close= true;
            base.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // If Close() was called, close the window (instead of hiding it)
            if (_Close) return;

            // Hide the window (instead of closing it)
            e.Cancel = true;
            Hide();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            // Get date/time the window is shown now (ie when it becomes visible)
            if ((bool) e.NewValue)
            {
                shownThisTime.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
