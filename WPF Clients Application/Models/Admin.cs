using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clients_Application.Models {
    public record Admin {

        // Private Fields

        private string? _username;
        private string? _password;

        // Properties

        public string? Username { get { return _username; }
            set {
                if (value!.Length >= 3) { 
                    _username = value;
                }
            }
        }
        public string? Password { get { return _password; }
            set {
                if (value!.Length >= 8)  {
                    _password = value;
                }
            }
        }

        // Constructor

        public Admin(string username, string password) {
            Username = username;
            Password = password;
        }

    }
}
