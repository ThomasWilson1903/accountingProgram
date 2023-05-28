using accountingProgram.data.api.order;
using accountingProgram.data.api.product;
using diplomaISPr22_33_PankovEA.data.api.user;
using DiplomaOborotovIS.data.api.model.order;
using DiplomaOborotovIS.data.api.model.product;
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

        List<Product> products;

        public wdAddOrder()
        {
            InitializeComponent();

            var api = new OrderApi();

            var apiProduct = new ProductApi();

            var apiUser = new UserApi();

            products = apiProduct.GetAll();


            cbProduct.ItemsSource = products;

        }

        private void clSave(object sender, RoutedEventArgs e)
        {
            var api = new OrderApi();
            api.Add(new CreateOrderDto()
            {
                Addres = tbAddres.Text,
                ProductId = products[cbProduct.SelectedIndex].Id,
                Quantity = Convert.ToInt32(tbQuantity.Text)
            });
            Close();
        }
    }
}
