using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;
using WPF_Clients_Application.Models;
using System.Collections.ObjectModel;
using static WPF_Clients_Application.Models.Database;
using static WPF_Clients_Application.Models.JsonHandling;

namespace WPF_Clients_Application {
    public partial class App : Application {
        private void Application_Exit(object sender, ExitEventArgs e) {
            if (Admins != null) WriteData<List<Admin>>(Admins, "admins");
            if (AllClients != null) WriteData<ObservableCollection<Client>>(AllClients, "clients");
        }
    }
}
