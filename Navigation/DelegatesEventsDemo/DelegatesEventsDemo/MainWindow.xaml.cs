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

namespace DelegatesEventsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            valueController.MinThresHoldReached += valueController_MinThresHoldReached;
            valueController.MaxThresHoldReached += valueController_MaxThresHoldReached;
        }

        public void valueController_MinThresHoldReached(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Minimum value reached!");
        }

        public void valueController_MaxThresHoldReached(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Maximum value reached!");
        }
    }
}
