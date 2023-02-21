using SimpleNavigatonDemo.pages;
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

namespace SimpleNavigatonDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Page1 firstPage; 
        public Page2 secondPage;
        public Page3 thirdPage;
        public MainWindow()
        {
            InitializeComponent();
            firstPage = new Page1();
            secondPage = new Page2();
            thirdPage = new Page3();

            thirdPage.GoToPage1ButtonClick += Button_Click;
            secondPage.GoToPage1ButtonClick += Button_Click;
            secondPage.GoToPage3ButtonClick += Button_Click_2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = firstPage;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = secondPage;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = thirdPage;
        }
        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoBack){
                MainWindowFrame.GoBack();
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoForward)
            {
                MainWindowFrame.GoForward();
            }
        }
    }
}
