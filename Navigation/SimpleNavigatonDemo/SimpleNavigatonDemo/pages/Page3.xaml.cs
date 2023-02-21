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

namespace SimpleNavigatonDemo.pages
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public delegate void OnGoToPage1ButtonClick(object sender, RoutedEventArgs e);
        public event OnGoToPage1ButtonClick GoToPage1ButtonClick;
        public Page3()
        {
            InitializeComponent();
        }

        private void goToPage1_Click(object sender, RoutedEventArgs e)
        {
            GoToPage1ButtonClick(sender, e);
        }
    }
}
