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

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;
        int temp;
        char op;
        public MainWindow()
        {
            InitializeComponent();
            txtInput.Focus();
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = "";
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            txtInput.Text += b.Content.ToString();
            second = int.Parse(txtInput.Text);
        }

        private void ResultBtn_Click(object sender, RoutedEventArgs e)
        {
            second = int.Parse(txtInput.Text);
            int result = 0;
            if(op == '+')
            {
                result = first + second + temp;
                //txtInput.Text = first + "+" + second + " = " + result.ToString();
            }
            else if (op == '-')
            {
                result = first - second;
                //txtInput.Text = first + "-" + second + " = " + result.ToString();
            }
            else if (op == '/')
            {
                result = first / second;
                //txtInput.Text = first + "/" + second + " = " + result.ToString();
            }
            else if (op == '*')
            {
                result = first * second;
                //txtInput.Text = first + "*" + second + " = " + result.ToString();
            }
            txtInput.Text = result.ToString();
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            first = int.Parse(txtInput.Text);
            op = '+';
            temp += first;
            txtInput.Clear();
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {  
            first = int.Parse(txtInput.Text);
            op = '-';
            txtInput.Clear();
        }

        private void MultiBtn_Click(object sender, RoutedEventArgs e)
        {
            first = int.Parse(txtInput.Text);
            op = '*';
            txtInput.Clear();
        }

        private void DivBtn_Click(object sender, RoutedEventArgs e)
        {
            second = int.Parse(txtInput.Text);
            op = '/';
            txtInput.Clear();
        }

        private void PerBtn_Click(object sender, RoutedEventArgs e)
        {
            second = int.Parse(txtInput.Text);
            op = '%';
            txtInput.Clear();
        }
    }
}
