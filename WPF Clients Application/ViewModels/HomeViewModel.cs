using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using WPF_Clients_Application.Views;
using WPF_Clients_Application.Commands;

namespace WPF_Clients_Application.ViewModels {
    public class HomeViewModel {
        public ICommand? AllClientsCommand { get; set; }
        public ICommand? CreateNewClientCommand { get; set; }
        public HomeViewModel() {
            AllClientsCommand = new RealCommand(AllClients);
            CreateNewClientCommand = new RealCommand(CreateNewClient);
        }

        private void AllClients(object? param) {
            Application.Current.MainWindow.Hide();
            AllClientsView allClientsView = new AllClientsView();
            Application.Current.MainWindow = allClientsView;
            allClientsView.ShowDialog();
        }

        public void CreateNewClient(object? param) {
            Application.Current.MainWindow.Hide();

            NewClientView newClientView = new();
            Application.Current.MainWindow = newClientView;
            newClientView.ShowDialog();
        }

    }
}
