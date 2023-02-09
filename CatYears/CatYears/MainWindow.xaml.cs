﻿using System;
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

namespace CatYears
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TextBlock ResultTextBlock;
        public TextBox InputCatAge;
        public MainWindow()
        {
            InitializeComponent();
            //Image backgroundImage = new Image()
            //{
            //    Source = new BitmapImage(
            //    new Uri(Environment.CurrentDirectory + @"\..\..\images/cat.jpg", UriKind.RelativeOrAbsolute))
            //};

            ResultTextBlock = new TextBlock() { Text = "Your cate is ", FontSize = 18 };
            InputCatAge = new TextBox() { 
                Width = 120,
                FontSize = 16,
                TextAlignment = TextAlignment.Center,
                Margin = new Thickness(5, 0, 0, 0)
            };
            InputCatAge.KeyDown += inputCatAge_KeyUp;

            TextBlock userQuestion = new TextBlock() {Text = "How old is your cat ?", FontSize = 18 };
            StackPanel Horizontalsp = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(1,5,0,0)};
            Horizontalsp.Children.Add(userQuestion);
            Horizontalsp.Children.Add(InputCatAge);

            StackPanel MainVerticalStackPanel = new StackPanel();
            MainVerticalStackPanel.Children.Add(Horizontalsp);
            MainVerticalStackPanel.Children.Add(ResultTextBlock);
            myWindow.Content = MainVerticalStackPanel;
        }

        private void inputCatAge_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                try
                {
                    int inputCatAge = Int32.Parse(InputCatAge.Text);
                    string resultHumanAge = "";
                    if(inputCatAge >=0 && inputCatAge <=10)
                    {
                        resultHumanAge = "0-15";
                        ResultTextBlock.Text = "Your cat is " + resultHumanAge + " Years old.";
                    }
                    else if(inputCatAge >= 2 && inputCatAge < 25){
                        resultHumanAge = (((inputCatAge - 2) * 4) + 24).ToString();
                        ResultTextBlock.Text = "Your cat is " + resultHumanAge + " Years old.";
                    }
                    else
                    {
                        ResultTextBlock.Text = "You entered a value that is not between 0-25" + "Your cat must be super old or not yet born !";
                    }
                }
                catch (Exception myException){ 
                    MessageBox.Show("Not a valid number, Please give a numeric value" +myException.Message);
                }
            }
        }
    }
}
