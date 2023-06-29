using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using WPF_Clients_Application.Views;
using WPF_Clients_Application.Models;
using WPF_Clients_Application.Commands;
using static WPF_Clients_Application.Models.Database;

namespace WPF_Clients_Application.ViewModels {
    public class NewClientViewModel {
        public ICommand? RegisterCommand { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Company { get; set; }
        public string? Place { get; set; }
        public string? Day { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
        public string? Order { get; set; }
        private bool isEdit = false;
        public Client Client { get; set; }
        
        public NewClientViewModel(Client? client = null) {
            RegisterCommand = new RealCommand(Register);
            if (client != null) {
                Name = client.Name;
                Surname = client.Surname;
                PhoneNumber = client.PhoneNumber;
                Company = client.Company;
                Place = client.Place;
                Day = client.Day;
                Month = client.Month;
                Year = client.Year;
                Order = client.Order;
                isEdit = true;
                Client = client;
            }
        }

        public void Register(object? param) {
            try {
                if (!isEdit) {
                    Client? checkedClient = new(Name!, Surname!, Place!, Company!, PhoneNumber!, Order!);
                    AllClients!.Add(checkedClient!);
                }
                else {
                    Client.Name = Name;
                    Client.Surname = Surname;
                    Client.PhoneNumber = PhoneNumber;
                    Client.Company = Company;
                    Client.Place = Place;
                    Client.Day = Day;
                    Client.Month = Month;
                    Client.Year = Year;
                    Client.Order = Order;
                }
                Application.Current.MainWindow.Hide();
                AllClientsView allClientsView = new AllClientsView();
                Application.Current.MainWindow = allClientsView;
                allClientsView.ShowDialog();
            }
            catch (Exception ex) { }
        }
    }
}
