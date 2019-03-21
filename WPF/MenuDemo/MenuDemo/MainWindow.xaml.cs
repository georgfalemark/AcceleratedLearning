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

namespace MenuDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoToOtherWindow_Click(object sender, RoutedEventArgs e)
        {
            //Gå till en annan sida
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Page1.xaml", UriKind.Relative);
            window.Show();

            //Gå till ett annat fönster
            //window2 win2 = new window2();
            //win2.Show();
            //Close();
        }
    }
}
