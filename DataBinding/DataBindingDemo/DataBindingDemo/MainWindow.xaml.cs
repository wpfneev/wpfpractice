using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<int> availableNumbers { get; set; }
        public MainWindow()
        {
            availableNumbers = new ObservableCollection<int>();
            int counter = 0;
            for(int i = 0; i < 10; i++)
            {
                availableNumbers.Add(counter++);
            }
            this.DataContext = this;
            InitializeComponent();
        }

        private void AddNumber(object sender, RoutedEventArgs e)
        {
            availableNumbers.Add(1);
        }

        private void DeleteNumber(object sender, RoutedEventArgs e)
        {
            availableNumbers.Remove(0);
        }
    }
}
