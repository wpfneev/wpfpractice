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
using WindowsStoreClone.Pages;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pages.Main MainWindowContentPage;
        private Pages.AppDetails AppDetailsContentPage;
        public MainWindow()
        {
            InitializeComponent();
            MainWindowContentPage = new Pages.Main();
            //AppDetailsContentPage = new Pages.AppDetails();
            MainWindowContentPage.AppClicked += MainWindowContentPage_AppClicked;
        }

        private void MainWindowContentPage_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppDetailsContentPage = new AppDetails(sender);
            AppDetailsContentPage.BackButtonClicked += MyAppDetails_BackButtonClicked;
            AppDetailsContentPage.AnotherAppClicked += MainWindowContentPage_AppClicked; //Calling the container method. recursive.
            MainWindowFrame.Content = AppDetailsContentPage;

        }

        private void MyAppDetails_BackButtonClicked(object sender, EventArgs e)
        {
            if(MainWindowFrame.NavigationService.CanGoBack)
            {
                MainWindowFrame.NavigationService.GoBack();
            }
        }

        private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = MainWindowContentPage;
            //MainWindowFrame.Content = AppDetailsContentPage;
        }
    }

}
