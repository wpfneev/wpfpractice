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

namespace DelegatesEventsDemo
{
    /// <summary>
    /// Interaction logic for ValueUc.xaml
    /// </summary>
    public partial class ValueUc : UserControl
    {
        public delegate void OnMinThresHoldReached(object sender, RoutedEventArgs e);
        public delegate void OnMaxThresHoldReached(object sender, RoutedEventArgs e);
        public event OnMinThresHoldReached MinThresHoldReached;
        public event OnMaxThresHoldReached MaxThresHoldReached;
        public ValueUc()
        {
            InitializeComponent();
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            ValueLabel.Text = (Int32.Parse(ValueLabel.Text) - 10).ToString();
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            ValueLabel.Text = (Int32.Parse(ValueLabel.Text) + 10).ToString();
        }

        private void ValueLabel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Int32.Parse(((TextBox)sender).Text) < 0){
                (sender as TextBox).Text = "0";
                MinThresHoldReached(sender, e);
            }
            if (Int32.Parse(((TextBox)sender).Text) > 100)
            {
                (sender as TextBox).Text = "100";
                MaxThresHoldReached(sender, e);
            }
        }
    }
}
