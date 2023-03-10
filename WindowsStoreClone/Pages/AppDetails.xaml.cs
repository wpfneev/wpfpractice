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
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone.Pages
{
  
    /// <summary>
    /// Interaction logic for AppDetails.xaml
    /// </summary>
    public partial class AppDetails : Page
    {
        //This event is inside the Appsviewer app
        public delegate void OnBackButtonClicked(object sender, EventArgs e);
        public event OnBackButtonClicked BackButtonClicked;

        //This event is to capture the overview tab user control app
        public delegate void OnDetailAnotherAppClicked(AnApp anApp, RoutedEventArgs e);
        public event OnDetailAnotherAppClicked AnotherAppClicked;
        public AppDetails(AnApp anApp)
        {
            InitializeComponent();
            AppDetailsAndBackgroundUC.AppNameLabel.Content = anApp.AppNameText.Text;
            AppDetailsAndBackgroundUC.AppImage.Source = anApp.ProductImage.Source;
            AppDetailsAndBackgroundUC.BackButtonClicked += AppDetailsAndBackgroundUC_BackButtonClicked;
            OverviewTabUserControl.AppClicked += OverviewTabUserControl_AppClicked;
        }

        private void OverviewTabUserControl_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AnotherAppClicked(sender, e);
        }

        private void AppDetailsAndBackgroundUC_BackButtonClicked(object sender, EventArgs e)
        {
            BackButtonClicked(sender, e);
        }
    }
}
