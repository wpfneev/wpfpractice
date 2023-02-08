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
using System.Windows.Shapes;

namespace WpfMastery
{
    /// <summary>
    /// Interaction logic for ButtonDemo.xaml
    /// </summary>
    public partial class ButtonDemo : Window
    {
        public ButtonDemo()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            double lblFontSize = lblText.FontSize;
            lblText.FontSize = lblFontSize + 1;
        }

        private void btnClick_MouseEnter(object sender, MouseEventArgs e)
        {
            lblText.Foreground = Brushes.BlanchedAlmond;
        }

        private void btnClick_MouseLeave(object sender, MouseEventArgs e)
        {
            lblText.Foreground = Brushes.BurlyWood;
        }
    }
}
