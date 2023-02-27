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

namespace InstaUserControl.UserControls
{
    /// <summary>
    /// Interaction logic for PostOperationsUc.xaml
    /// </summary>
    public partial class PostOperationsUc : UserControl
    {
        public bool postLiked { get; set; }
        public PostOperationsUc()
        {
            InitializeComponent();
        }

        public void postLike()
        {
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\icons\like.png", UriKind.RelativeOrAbsolute));
            postLiked = true;
        }

        public void unLikePost()
        {
            Heart.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\icons\nolike.png", UriKind.RelativeOrAbsolute));
            postLiked = false;
        }
        private void Heart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!postLiked)
            {
                postLike();
            }
            else
            {
                unLikePost();
            }
        }
    }
}
