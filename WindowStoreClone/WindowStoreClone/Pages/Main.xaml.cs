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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowStoreClone.UserControls;

namespace WindowStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;
        public Main()
        {
            InitializeComponent();
            DealsAppsViewer.AppClicked += AnAppClicked;
            
            
        }

        private void AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

        private void HomeTab_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MainScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            UIElement element= (UIElement)sender;
            element.Opacity = 0;
            DoubleAnimation animation = new DoubleAnimation() {
                From = 0,
                To = 0.5,
                Duration = new Duration(new TimeSpan(0, 0, 20))
            };
            element.BeginAnimation(UIElement.OpacityProperty, animation);
        }

        private void GameTab_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
