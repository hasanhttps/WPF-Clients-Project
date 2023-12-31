﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using WPF_Clients_Application.Models;
using System.Windows.Input;
using WPF_Clients_Application.Commands;
using WPF_Clients_Application.Views;
using System.Windows.Media.Animation;

namespace WPF_Clients_Application.ViewModels {

    public class NewOrderViewModel {
        public string? Name { get; set; }
        public string? Quantity { get; set; }
        public string? OrderDay { get; set; }
        public string? OrderMonth { get; set; }
        public string? OrderYear { get; set; }
        public string? DeliveryDay { get; set; }
        public string? DeliveryMonth { get; set; }
        public string? DeliveryYear{ get; set; }
        public Client? Client { get; set; }
        public Order? Order { get; set; }
        public ICommand? RegisterCommand { get; set; }
        private bool isEdit = false;

        public NewOrderViewModel(Client client, Order? order = null) { 

            Client = client;
            RegisterCommand = new RealCommand(Register);
            if (order != null) {
                Name = order.Name;
                Quantity = order.OrderQuantity.ToString();
                int len = order.OrderDay.Length;
                OrderYear = order.OrderDay.Substring(order.OrderDay.LastIndexOf(".") + 1);
                string datemonth = order.OrderDay.Substring(0, order.OrderDay.LastIndexOf("."));
                OrderMonth = datemonth.Substring(datemonth.LastIndexOf(".") + 1);
                OrderDay = datemonth.Substring(0, datemonth.IndexOf("."));
                DeliveryYear = order.DeliveryDay.Substring(order.OrderDay.LastIndexOf(".") + 1);
                string ddatemonth = order.DeliveryDay.Substring(0, order.OrderDay.LastIndexOf("."));
                DeliveryMonth = ddatemonth.Substring(ddatemonth.LastIndexOf(".") + 1);
                DeliveryDay = ddatemonth.Substring(0, ddatemonth.IndexOf("."));
                Order = order;
                isEdit = true;
            }
        }
        
        public void Register(object? param) {
            
            try {
                if (!isEdit) {
                    int.TryParse(Quantity, out var quantity);
                    Order neworder = new(Name!, OrderDay + "." + OrderMonth + "." + OrderYear, DeliveryDay + "." + DeliveryMonth + "." + DeliveryYear, quantity, false);
                    Client!.Orders.Add(neworder);
                }
                else {
                    Order.Name = Name;
                    Order.OrderQuantity = Convert.ToInt32(Quantity);
                    Order.OrderDay = OrderDay + "." + OrderMonth + "." + OrderYear;
                    Order.DeliveryDay = DeliveryDay + "." + DeliveryMonth + "." + DeliveryYear;
                    Order.OrderQuantity = Convert.ToInt32(Quantity);
                }

                Application.Current.MainWindow.Hide();
                ClientProfileView clientProfileView = new(Client!);
                Application.Current.MainWindow = clientProfileView;
                clientProfileView.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

    }
}
