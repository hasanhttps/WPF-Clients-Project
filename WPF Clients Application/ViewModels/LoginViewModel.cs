using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Collections.Generic;
using WPF_Clients_Application.Views;
using WPF_Clients_Application.Commands;
using static WPF_Clients_Application.Models.Database;

namespace WPF_Clients_Application.ViewModels {

    public class LoginViewModel {

        private TextBox _usernametb;
        private TextBox _passwordtb;
        public ICommand? LoginCommand { get; set; }

        public LoginViewModel(ref TextBox username, ref TextBox password) {

            LoginCommand = new RealCommand(login);
            _usernametb = username;
            _passwordtb = password;
        }

        public void login(object? param) {

            foreach (var admin in Admins!) {

                if (admin.Username == _usernametb.Text && admin.Password == _passwordtb.Text) {

                    Application.Current.MainWindow.Visibility = Visibility.Hidden;
                    HomeView homeView = new HomeView();
                    Application.Current.MainWindow = homeView;
                    homeView.ShowDialog();

                    return;
                }
            }
        }

    }
}
