using DevExpress.Xpf.Core;
using DevExpress.Xpf.Docking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DXFloating2.Views
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            
        }

        private void SimpleButton_Click(object sender, RoutedEventArgs e)
        {
            DockLayoutManager dockLayoutManager= DockLayoutManager.GetDockLayoutManager((DockLayoutManager)this.Content);
            dockLayoutManager.RemoveFromVisualTree();
        }
    }
}
