﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace VMS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            //Create the ViewModel and expose it using the View's DataContext
            MainView view = new MainView();
            view.DataContext = new ViewModels.MainViewModel();
            view.Show();
        }
    }
}
