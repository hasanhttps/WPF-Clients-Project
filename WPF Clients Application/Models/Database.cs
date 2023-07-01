using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static WPF_Clients_Application.Models.Database;
using static WPF_Clients_Application.Models.JsonHandling;

namespace WPF_Clients_Application.Models {
    public static class Database {
        
        public static ObservableCollection<Client>? AllClients { get; set; }
        public static List<Admin>? Admins { get; set; }

        static Database() {
            var admins = ReadData<List<Admin>>("admins");
            if (admins != null) 
                Admins = admins;

            var clients = ReadData<ObservableCollection<Client>>("clients")!;
            if (clients != null)
                AllClients = clients;
        }

    }
}
