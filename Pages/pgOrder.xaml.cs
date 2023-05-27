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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace accountingProgram.Pages
{
    /// <summary>
    /// Interaction logic for pgOrder.xaml
    /// </summary>
    public partial class pgOrder : Page
    {
        //IEnumerable<Order> orders;


        public pgOrder()
        {
            InitializeComponent();

            /*var api = new UserNetworkApi();
            //Operations.Visibility = Visibility.Collapsed;
            string UserRoles = api.GetUserRole().ToString();

            if (UserRoles == "BaseUser")
            {
                Operations.Visibility = Visibility.Visible;
            }*/

            update();

        }

        private void clDel(object sender, RoutedEventArgs e)
        {
            /*Order del = (sender as Button).DataContext as Order;
            var api = new OrderNetworkApi();
            api.Delete(del.Id);
            NavigationService.Navigate(new pgOrder());*/
        }

        void update()
        {
            /*var api = new OrderNetworkApi();
            orders = api.GetAll(tbSerch.Text);
            dgvOrder.ItemsSource = orders;*/
        }

        private void clChang(object sender, RoutedEventArgs e)
        {
            /*Order chang = (sender as Button).DataContext as Order;
            var api = new OrderNetworkApi();
            new wdEditOrder(chang).ShowDialog();
            NavigationService.Navigate(new pgOrder());*/
        }

        private void tcSerch(object sender, TextChangedEventArgs e)
        {
            /*orders = orders.Where(p => p.Addres.ToLower().Contains(tbSerch.Text.ToString().ToLower()));
            dgvOrder.ItemsSource = orders;*/
        }
    }
}
