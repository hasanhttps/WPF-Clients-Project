using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_Clients_Application.Commands;
using WPF_Clients_Application.Models;
using WPF_Clients_Application.Views;

namespace WPF_Clients_Application.ViewModels {
    public class ClientProfileViewModel {

        public ICommand? NewOrderCommand { get; set; }
        public ICommand? NewOrderEditCommand { get; set; }
        public Client? SelectedClient { get; set; }
        public ClientProfileViewModel(Client client) {
            SelectedClient = client;
            NewOrderCommand = new RealCommand(NewOrder);
            NewOrderEditCommand = new RealCommand(NewOrderEdit);
        }

        public void NewOrder(object? param) {
            Application.Current.MainWindow.Hide();

            NewOrderView newOrderView = new(SelectedClient!);
            Application.Current.MainWindow = newOrderView;
            newOrderView.ShowDialog();
        }

        public void NewOrderEdit(object? param) {
            Application.Current.MainWindow.Hide();
            NewOrderView newOrderView = new(SelectedClient!);
            NewOrderViewModel newOrderViewModel = new(SelectedClient!, (param as Order));
            newOrderView.DataContext = newOrderViewModel;
            Application.Current.MainWindow = newOrderView;
            newOrderView.ShowDialog();
        }
    }
}
