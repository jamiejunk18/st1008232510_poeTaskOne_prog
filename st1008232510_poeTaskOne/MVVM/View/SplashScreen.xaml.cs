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
using System.Threading;
using System.Windows.Threading;

namespace st1008232510_poeTaskOne
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public SplashScreen()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
            
        }
        private void Window_Loaded(object sender , RoutedEventArgs e)
        {
            
        }
        private void ProgressBarOne_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

      public void timer_tick(object sender , EventArgs e)
        {
            
            MainWindow window = new MainWindow();
            window.Show();
            timer.Stop();
            this.Close();

        }
    }
}
