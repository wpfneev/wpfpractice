using System;
using System.Collections.Generic;
using System.IO;
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

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AnApp.xaml
    /// </summary>
    public partial class AnApp : UserControl
    {
        //Delegate needs an APP to be passed in.
        public delegate void onAppClicked(AnApp sender, RoutedEventArgs e);
        public event onAppClicked AppClicked;
        public AnApp()
        {
            InitializeComponent();

            //Need to pick the image randomly instead of static image source
            string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            List<string> availImages = Directory.GetFiles(imagesFolder, "*.png").ToList();
            Random rnd = new Random();
            int imageId = rnd.Next(0,availImages.Count);
            ProductImage.Source = new BitmapImage(new Uri(availImages[imageId], UriKind.RelativeOrAbsolute));
            AppNameText.Text = Path.GetFileName(availImages[imageId]).Split("-").Last().Replace(".png", "");
        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            AppClicked(this, e);
        }
    }
}
