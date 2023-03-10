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
        //The event has to be listed by the parent, so we are adding the delegate here which is raised from AnApp User Control
        public delegate void onAppClicked(AnApp sender, RoutedEventArgs e);
        public event onAppClicked AppClicked;

        public AppsViewer()
        {
            InitializeComponent();
            PresentedApps = new List<AnApp>();
            //We are adding the DATA Binding here for the scroll viewer.
            AppsList.ItemsSource = PresentedApps;
            for (int i = 0; i < 9; i++)
            {
                AnApp currApp = new AnApp();
                //To handle the events with the heirarchy we need to add the below statement.
                currApp.AppClicked += CurrApp_AppClicked;
                PresentedApps.Add(currApp);
            }
        }

        private void CurrApp_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender,e);
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

        private void AppScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
            var objEvent = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            objEvent.RoutedEvent = UIElement.MouseWheelEvent;
            objEvent.Source = sender;
            var parent = ((Control)sender).Parent as UIElement; //UI Element is the one that will raise the events.
            parent.RaiseEvent(objEvent);
        }
    }
}
