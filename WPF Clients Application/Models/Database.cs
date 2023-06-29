using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WPF_Clients_Application.Models.Database;
using static WPF_Clients_Application.Models.JsonHandling;

namespace WPF_Clients_Application.Models {
    public static class Database {
        public static ObservableCollection<Client>? AllClients { get; set; }

        static Database() {
            AllClients = ReadData<ObservableCollection<Client>>("clients")!;
        }

    }
}
