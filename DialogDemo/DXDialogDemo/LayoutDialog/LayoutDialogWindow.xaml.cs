using DevExpress.Xpf.Core;
using System.Windows;
using System.Windows.Controls;

namespace DXDialogDemo.LayoutDialog
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class LayoutDialogWindow : UserControl
    {
       LayoutDialogWindowViewModel viewModel;
        public LayoutDialogWindow()
        {
            InitializeComponent();
            viewModel = new LayoutDialogWindowViewModel();
            
        }

    }
}
