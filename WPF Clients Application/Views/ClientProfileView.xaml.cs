using System;
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
using WPF_Clients_Application.Models;
using WPF_Clients_Application.ViewModels;

namespace WPF_Clients_Application.Views {
    public partial class ClientProfileView : Window {
        private Client? Client;
        public ClientProfileView(Client client) {
            InitializeComponent();
            DataContext = new ClientProfileViewModel(client);
            Client = client;
        }

        private void Window_Closed(object sender, EventArgs e) {
            Application.Current.Shutdown();
        }

        private void TextBlock_GotFocus(object sender, RoutedEventArgs e) {
            Application.Current.MainWindow.Hide();
            AllClientsView allClientsView = new AllClientsView();
            Application.Current.MainWindow = allClientsView;
            allClientsView.ShowDialog();
        }

        private void ClientEdit_Clicked(object sender, MouseButtonEventArgs e) {
            Application.Current.MainWindow.Hide();
            NewClientView newClientView = new();
            NewClientViewModel newClientViewModel = new(Client!);
            newClientView.DataContext = newClientViewModel;
            Application.Current.MainWindow = newClientView;
            newClientView.ShowDialog();
        }
    }
}
