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

namespace WindowStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AppViewer.xaml
    /// </summary>
    public partial class AppViewer : UserControl
    {
        List<AnApp> PresentedApps;
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;
        public AppViewer()
        {
            InitializeComponent();
            PresentedApps = new List<AnApp>();
            AppList.ItemsSource = PresentedApps;
            for(int i = 0; i < 9; i++)
            {
                AnApp curr = new AnApp();
                curr.AppClicked += curr_AppClicked;
                PresentedApps.Add(curr);
            }
        }

        private void curr_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            curr_AppClicked(sender, e);
        }

        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfOneApp = (int)PresentedApps.First().ActualWidth +
                                2 * (int)PresentedApps.First().Margin.Left;
            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset - 4 * widthOfOneApp);
        }
        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfOneApp = (int)PresentedApps.First().ActualWidth +
                                2 * (int)PresentedApps.First().Margin.Left;
            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset + 4 * widthOfOneApp);
        }

        private void AppsScrollView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
            var eventArgs = new MouseWheelEventArgs(e.MouseDevice,e.Timestamp, e.Delta);
            eventArgs.RoutedEvent = UIElement.MouseWheelEvent;
            eventArgs.Source = sender;
            var parent = ((Control)sender).Parent as UIElement;
            parent.RaiseEvent(eventArgs);
        }
    }
}
