﻿using accountingProgram.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace accountingProgram.Windows.edit
{
    /// <summary>
    /// Interaction logic for wdEditOrder.xaml
    /// </summary>
    public partial class wdEditOrder : Window
    {
        public wdEditOrder(/*Order order*/)
        {
            /*this.Order = order;
            InitializeComponent();
            var apiProduct = new ProductNetworkApi();

            products = apiProduct.GetAll();

            cbProduct.ItemsSource = products;

            cbProduct.SelectedItem = order.Product.Id;

            DataContext = Order;*/
        }

        private void clSave(object sender, RoutedEventArgs e)
        {
            /*var api = new OrderNetworkApi();
            api.Update(Order.Id, new CreateOrderDto
            {
                Addres = tbAddres.Text,
                ProductId = products[cbProduct.SelectedIndex].Id,
                Quantity = Convert.ToInt32(tbQuantity.Text),

            });*/
            Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
