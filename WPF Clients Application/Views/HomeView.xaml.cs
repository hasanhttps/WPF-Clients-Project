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
using WPF_Clients_Application.Commands;
using WPF_Clients_Application.ViewModels;

namespace WPF_Clients_Application.Views {
    public partial class HomeView : Window {

        public HomeView() {
            InitializeComponent();
            DataContext = new HomeViewModel();
        }

        private void Window_Closed(object sender, EventArgs e) {
            Application.Current.Shutdown();
        }
    }
}
