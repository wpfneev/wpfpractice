using DevExpress.Xpf.Docking;
using DXDialogDemo.Dialog;
using DXDialogDemo.LayoutDialog;
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

namespace DXDialogDemo.Views
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            dockLayoutManager=new DockLayoutManager();
        }

        public DockLayoutManager dockLayoutManager { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialogWindow = new DialogWindow();
            dialogWindow.Title = "Dialog Demo";
            dialogWindow.ShowDialog();
        }

        private void ShowLayout_Click(object sender, RoutedEventArgs e)
        {
            LayoutDialogWindow dialogWindow = new LayoutDialogWindow();

            LayoutPanel panel = new LayoutPanel();
            panel.AllowClose = false;
            

            FloatGroup floatGroup = new FloatGroup();
            floatGroup.AllowClose = false;
            floatGroup.Caption = "Float Group";
            floatGroup.RenderSize = new Size(500, 500);
            floatGroup.Add(panel);
            dockLayoutManager.FloatGroups.Add(floatGroup);
            dialogWindow.dockLayoutManager = dockLayoutManager;

            //dialogWindow.HorizontalContentAlignment = HorizontalAlignment.Center;
            //dialogWindow.SizeToContent = SizeToContent.WidthAndHeight;
            //dialogWindow.ShowDialog();
        }
    }
}
