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
    /// Interaction logic for DatePickerDemo.xaml
    /// </summary>
    public partial class DatePickerDemo : Window
    {
        public DatePickerDemo()
        {
            InitializeComponent();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            //if((sender as DatePicker).SelectedDate != null){ 
            //    string myDate = (sender as DatePicker).SelectedDate.ToString();
            //}
        }
    }
}
