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
    /// Interaction logic for CalenderDemo.xaml
    /// </summary>
    public partial class CalenderDemo : Window
    {
        public CalenderDemo()
        {
            InitializeComponent();
        }

        private void myCalender_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if(myTextBlock != null)
            myTextBlock.Text = myCalender.SelectedDate.ToString();
        }
    }
}
