using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_Clients_Application.Models;
using static WPF_Clients_Application.Models.JsonHandling;
using static WPF_Clients_Application.Models.Database;

namespace WPF_Clients_Application {
    public partial class App : Application {
        private void Application_Exit(object sender, ExitEventArgs e) {
            if (Admins != null) WriteData<List<Admin>>(Admins, "admins");
            if (AllClients != null) WriteData<ObservableCollection<Client>>(AllClients, "clients");
        }
    }
}
