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
    /// Interaction logic for ImageDemo.xaml
    /// </summary>
    public partial class ImageDemo : Window
    {
        public ImageDemo()
        {
            InitializeComponent();
        }

        private void myImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri(@"/images/obama.jpg", UriKind.Relative));
        }
    }
}
