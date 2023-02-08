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

namespace WpfMastery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock myTb = new TextBlock();
            myTb.Height = 100;
            myTb.Width = 100;
            //myTb.HorizontalAlignment = HorizontalAlignment.Right;
            myTb.VerticalAlignment = VerticalAlignment.Center;
            myTb.Text = "Hello, I am Abhay!";
            myTb.Inlines.Add(" ,I am from Jharkhand");
            myTb.TextWrapping = TextWrapping.Wrap;
            myTb.Foreground = Brushes.Black;
            myTb.Background = Brushes.Blue;
            this.Content = myTb;
            //TextboxDemo txtDemo = new TextboxDemo();
            //this.Visibility = Visibility.Hidden;
            //txtDemo.Show();
            //ButtonDemo bd = new ButtonDemo();
            //this.Visibility = Visibility.Hidden;
            //bd.Show();
            //RadioButtonDemo rbd = new RadioButtonDemo();
            //this.Visibility = Visibility.Hidden;
            //rbd.Show();
            //CheckBoxDemo cbd = new CheckBoxDemo();
            //this.Visibility = Visibility.Hidden;
            //cbd.Show();
            //MenuItemDemo mid = new MenuItemDemo();
            //this.Visibility = Visibility.Hidden;
            //mid.Show();
            //ImageDemo id = new ImageDemo();
            //this.Visibility = Visibility.Hidden;
            //id.Show();
            //SliderDemo sd = new SliderDemo();
            //this.Visibility = Visibility.Hidden;
            //sd.Show();
            //CalenderDemo cd = new CalenderDemo();
            //this.Visibility = Visibility.Hidden;
            //cd.Show();
            //DatePickerDemo dpd = new DatePickerDemo();
            //this.Visibility = Visibility.Hidden;
            //dpd.Show();
            ExpanderDemo ed = new ExpanderDemo();
            this.Visibility = Visibility.Hidden;
            ed.Show();
        }
    }
}
