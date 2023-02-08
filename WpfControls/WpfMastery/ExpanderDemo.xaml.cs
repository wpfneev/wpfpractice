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
    /// Interaction logic for ExpanderDemo.xaml
    /// </summary>
    public partial class ExpanderDemo : Window
    {
        public ExpanderDemo()
        {
            InitializeComponent();
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Expander is clicked!");
        }
    }
}
