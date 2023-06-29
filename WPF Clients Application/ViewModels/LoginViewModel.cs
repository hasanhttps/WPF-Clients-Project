using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_Clients_Application.Commands;
using WPF_Clients_Application.Views;

namespace WPF_Clients_Application.ViewModels {

    public class LoginViewModel {
        public ICommand? LoginCommand { get; set; }

        public LoginViewModel() {
            LoginCommand = new RealCommand(login);
        }

        public void login(object? param) {
            Application.Current.MainWindow.Visibility = Visibility.Hidden;
            HomeView homeView = new HomeView();
            Application.Current.MainWindow = homeView;
            homeView.ShowDialog();
        }

    }
}
