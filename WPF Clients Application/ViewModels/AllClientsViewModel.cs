using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Collections.Generic;
using WPF_Clients_Application.Views;
using WPF_Clients_Application.Models;
using System.Collections.ObjectModel;
using WPF_Clients_Application.Commands;
using static WPF_Clients_Application.Models.Database;

namespace WPF_Clients_Application.ViewModels {
    public class AllClientsViewModel {
        public ObservableCollection<Client> Clients { get; set; }
        public ICommand? MoreCommand { get; set; }
        public ICommand? NewClientCommand { get; set; }

        public AllClientsViewModel() {

            Clients = AllClients!;

            MoreCommand = new RealCommand(More);
            NewClientCommand = new RealCommand(NewClient);
        }


        public void More(object? param) {
            Client? SelectedClient = new();
            Guid Id =  (Guid)param!;

            Application.Current.MainWindow.Hide();

            foreach (var client in Clients) { 
                if (client.Id == Id) 
                    SelectedClient = client;
            }

            ClientProfileView clientProfileView = new(SelectedClient);
            Application.Current.MainWindow = clientProfileView;
            clientProfileView.ShowDialog();
        }

        public void NewClient(object? param) {

            Application.Current.MainWindow.Hide();
            NewClientView newClientView = new();
            Application.Current.MainWindow = newClientView;
            newClientView.ShowDialog();
        }
    }
}
