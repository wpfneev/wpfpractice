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
    /// Interaction logic for SliderDemo.xaml
    /// </summary>
    public partial class SliderDemo : Window
    {
        public SliderDemo()
        {
            InitializeComponent();
        }

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //if(myTextBlock != null && mySlider.Value > 0)
            //{
            //    myTextBlock.Text = "My Slider Value is " + mySlider.Value.ToString();
            //    myTextBlock.FontSize = mySlider.Value;
            //}
        }
    }
}
