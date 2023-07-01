using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static WPF_Clients_Application.Models.MainFunctions;


namespace WPF_Clients_Application.Models {
    public class Client {

        // Private Fields

        private string? _name;
        private string? _surname;
        private string? _phoneNumber;
        private DateTime _registerDate;

        // Constructors

        public Client() { }
        public Client(string name, string surname, string place, string company, string phonenumber, string order) {
            _registerDate = DateTime.Now;
            Name = name;
            Surname = surname;
            Place = place;
            Company = company;
            PhoneNumber = phonenumber;
            Order = order;
            Orders = new ObservableCollection<Order>() { };
        }

        // Properties

        public string? Name { get { return _name; }
            set {
                if (value!.Length < 3 || !Regex.Match(value!, @"\b[A-Z][a-z]+\b").Success) {
                    ErrorMessage(new Exception("Name format is not valid!"));
                }
                _name = value;
            }

        }
        public string? Surname { get { return _surname; }
            set {
                if (!Regex.Match(value!, @"\b[A-Z][a-z]+\b").Success) {
                    ErrorMessage(new Exception("Surname format is not valid!"));
                } _surname = value!;
            }
        }
        public string? PhoneNumber { get { return _phoneNumber; }
            set {
                if (!Regex.Match(value!, "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{2}[-\\s\\.]?[0-9]{2}$").Success) {
                    ErrorMessage(new Exception("Phone Number format is not valid!"));
                }
                _phoneNumber = value!;
            }
        }
        public Guid Id { get; } = Guid.NewGuid();
        public ObservableCollection<Order> Orders { get; set; }
        public string? RegisterDate { get {
                return _registerDate.ToShortDateString();
            } 
        }
        public string? Day { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
        public string? Place { get; set; }
        public string? Company { get; set; }
        public string? Order { get; set; } 
         
    }
}
