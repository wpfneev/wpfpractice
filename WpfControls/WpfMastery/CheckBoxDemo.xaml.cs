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
using System.Windows.Shapes;

namespace WpfMastery
{
    /// <summary>
    /// Interaction logic for CheckBoxDemo.xaml
    /// </summary>
    public partial class CheckBoxDemo : Window
    {
        public CheckBoxDemo()
        {
            InitializeComponent();
        }

        private void cbCheese_Checked(object sender, RoutedEventArgs e)
        {
            lblCheese.Background = Brushes.Gray;
        }

        private void cbCheese_Unchecked(object sender, RoutedEventArgs e)
        {
            lblCheese.Background = Brushes.White;
        }
        private void cbParentCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool isNewVal = (cbParent.IsChecked == true);
            cbCheese.IsChecked = isNewVal;
            cbTauma.IsChecked = isNewVal;
            cbHam.IsChecked = isNewVal;
        }

        private void cbToppingsCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbParent.IsChecked = null;
            if(cbCheese.IsChecked == true && cbCheese.IsChecked == true && cbHam.IsChecked == true) {
                cbCheese.IsChecked = true;
                cbTauma.IsChecked = true;
                cbHam.IsChecked = true;
            }
            if(cbCheese.IsChecked == false && cbTauma.IsChecked == false && cbHam.IsChecked == false)
            {
                cbCheese.IsChecked = false;
                cbTauma.IsChecked = false;
                cbHam.IsChecked = false;
            }
        }
    }
}
