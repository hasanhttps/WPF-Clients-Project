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
using WPF_Clients_Application.ViewModels;

namespace WPF_Clients_Application.Views {
    public partial class NewClientView : Window {
        public NewClientView() {
            InitializeComponent();
            DataContext = new NewClientViewModel();
        }

        private void Window_Closed(object sender, EventArgs e) {
            Application.Current.Shutdown();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            Application.Current.MainWindow.Hide();
            AllClientsView allClientsView = new AllClientsView();
            Application.Current.MainWindow = allClientsView;
            allClientsView.ShowDialog();
        }
    }
}
