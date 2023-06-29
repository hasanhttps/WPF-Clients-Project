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
using WPF_Clients_Application.Models;
using WPF_Clients_Application.ViewModels;

namespace WPF_Clients_Application.Views {
    public partial class NewOrderView : Window {
        private Client? SelectedClient;
        public NewOrderView(Client client) {
            InitializeComponent();
            DataContext = new NewOrderViewModel(client);
            SelectedClient = client;
        }

        private void Window_Closed(object sender, EventArgs eventArgs) {
            Application.Current.Shutdown();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            Application.Current.MainWindow.Hide();
            ClientProfileView clientProfileView = new(SelectedClient!);
            Application.Current.MainWindow = clientProfileView;
            clientProfileView.ShowDialog();
        }
    }
}
