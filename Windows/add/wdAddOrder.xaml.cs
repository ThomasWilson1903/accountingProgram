using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace accountingProgram.Windows.add
{
    /// <summary>
    /// Interaction logic for wdAddOrder.xaml
    /// </summary>
    public partial class wdAddOrder : Window
    {

        //List<Product> products;

        public wdAddOrder()
        {
            InitializeComponent();

            /*var api = new OrderNetworkApi();

            var apiProduct = new ProductNetworkApi();

            var apiUser = new UserNetworkApi();

            products = apiProduct.GetAll();*/


            //cbProduct.ItemsSource = products;

        }

        private void clSave(object sender, RoutedEventArgs e)
        {
            /*var api = new OrderNetworkApi();
            api.Add(new data.api.model.order.CreateOrderDto()
            {
                Addres = tbAddres.Text,
                ProductId = products[cbProduct.SelectedIndex].Id,
                Quantity = Convert.ToInt32(tbQuantity.Text)
            });*/
            Close();
        }
    }
}
