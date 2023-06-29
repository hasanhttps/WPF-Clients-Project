using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using WPF_Clients_Application.Models;
using WPF_Clients_Application.ViewModels;

namespace WPF_Clients_Application.Views {
    public partial class AllClientsView : Window {
        public AllClientsView() {
            InitializeComponent();
            DataContext = new AllClientsViewModel();
        }

        private void Window_Closed(object sender, EventArgs e) {
            Application.Current.Shutdown();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            Application.Current.MainWindow.Visibility = Visibility.Hidden;
            HomeView homeView = new HomeView();
            Application.Current.MainWindow = homeView;
            homeView.ShowDialog();
        }
    }
}
