using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WPF_Clients_Application.Models {
    public class Order {

        // Constructors

        public Order() { }
        public Order(string name, string orderday, string deliveryday, int orderquantity, bool isdelivered = false) { 
            Name = name; 
            OrderDay = orderday;
            DeliveryDay = deliveryday;
            OrderQuantity = orderquantity;
            isDelivered = isdelivered;
        }

        public string? Name { get; set; }
        public string? DeliveryDay { get; set; }
        public string? OrderDay { get; set; }
        public int OrderQuantity { get; set; }
        public bool isDelivered { get; set; }
        public string status {
            get { if (!isDelivered) return "#EE0F0F"; else return "#07DA42"; }
        }
    }
}
