using accountingProgram.data.api.warehouse;
using accountingProgram.Windows.edit;
using diplomaISPr22_33_PankovEA.data.api.user;
using DiplomaOborotovIS.data.api.model.warehouse;
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
    /// Interaction logic for pgStorages.xaml
    /// </summary>
    public partial class pgStorages : Page
    {
        IEnumerable<Warehouse> warehouse;


        public pgStorages()
        {
            InitializeComponent();

            update();

            var api = new UserApi();
            Operations.Visibility = Visibility.Collapsed;
            string UserRoles = api.GetUserRole().ToString();
            if (UserRoles == "AdminUser")
            {
                Operations.Visibility = Visibility.Visible;
            }
            if (UserRoles == "ProviderUser")
            {
                Operations.Visibility = Visibility.Visible;
            }
        }

        private void clDel(object sender, RoutedEventArgs e)
        {
            Warehouse del = (sender as Button).DataContext as Warehouse;
            var api = new WarehouseApi();
            api.Delete(del.Id);
            NavigationService.Navigate(new pgStorages());
        }

        private void clChang(object sender, RoutedEventArgs e)
        {
            Warehouse chang = (sender as Button).DataContext as Warehouse;
            var api = new WarehouseApi();
            new wdEditStorege(chang).ShowDialog();
            NavigationService.Navigate(new pgStorages());
        }

        void update()
        {
            var api = new WarehouseApi();
            warehouse = api.GetAll(tbSerch.Text);
            dgvWarehouse.ItemsSource = warehouse;
        }

        private void tcSerch(object sender, TextChangedEventArgs e)
        {
            warehouse = warehouse.Where(p => p.Address.ToLower().Contains(tbSerch.Text.ToString().ToLower()));
            dgvWarehouse.ItemsSource = warehouse;
        }
    }
}
