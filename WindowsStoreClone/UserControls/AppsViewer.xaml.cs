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

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AppsViewer.xaml
    /// </summary>
    public partial class AppsViewer : UserControl
    {
        List<AnApp> PresentedApps;
        public AppsViewer()
        {
            InitializeComponent();
            PresentedApps = new List<AnApp>();
            //We are adding the DATA Binding here for the scroll viewer.
            AppsList.ItemsSource = PresentedApps;
            for (int i = 0; i < 9; i++)
            {
                AnApp currApp = new AnApp();
                PresentedApps.Add(currApp);
            }
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            //AppScrollViewer.ScrollToHorizontalOffset(AppScrollViewer.HorizontalOffset+4);
            double widthOfApp = PresentedApps.First().ActualWidth + 2 * PresentedApps.First().Margin.Left;
            AppScrollViewer.ScrollToHorizontalOffset(AppScrollViewer.HorizontalOffset - 4 * widthOfApp);
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            double widthOfApp = PresentedApps.First().ActualWidth + 2 * PresentedApps.First().Margin.Left;
            AppScrollViewer.ScrollToHorizontalOffset(AppScrollViewer.HorizontalOffset + 4 * widthOfApp);
        }
    }
}
