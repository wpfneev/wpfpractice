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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public delegate void onAppClicked(AnApp sender, RoutedEventArgs e);
        public event onAppClicked AppClicked;
        public Main()
        {
            InitializeComponent();
            DealsAppsViewer.AppClicked += AnAppClicked;
            ProductivityAppsViewer.AppClicked += AnAppClicked;
            FeaturesAppViewer.AppClicked += AnAppClicked;
            MostPopularAppViewer.AppClicked += AnAppClicked;
            GamingAppsViewer.AppClicked += AnAppClicked;
        }


        void AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

        private void MainScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
