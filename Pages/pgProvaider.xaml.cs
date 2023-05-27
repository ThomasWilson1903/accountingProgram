using accountingProgram.Windows.add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for pgProvaider.xaml
    /// </summary>
    public partial class pgProvaider : Page
    {
        //IEnumerable<Provider> provider;

        public pgProvaider()
        {
            InitializeComponent();

            update();

            /*var api = new UserNetworkApi();
            Operations.Visibility = Visibility.Collapsed;
            string UserRoles = api.GetUserRole().ToString();
            if (UserRoles == "AdminUser")
            {
                Operations.Visibility = Visibility.Visible;
            }
            if (UserRoles == "EmployeeUser")
            {
                Operations.Visibility = Visibility.Visible;
            }*/
        }

        private void clDel(object sender, RoutedEventArgs e)
        {
            /* Provider del = (sender as Button).DataContext as Provider;
             var api = new ProviderNetworkApi();
             api.Delete(del.Id);
             NavigationService.Navigate(new pgProvider());*/
        }

        private void clChang(object sender, RoutedEventArgs e)
        {
            /*Provider chang = (sender as Button).DataContext as Provider;
            var api = new ProviderNetworkApi();
            new wdEditProvider(chang).ShowDialog();
            NavigationService.Navigate(new pgProvider());*/
        }

        void update()
        {
            /*var api = new ProviderNetworkApi();
            provider = api.GetAll(tbSerch.Text);
            dgvProvader.ItemsSource = provider;*/
        }

        private void tcSerch(object sender, TextChangedEventArgs e)
        {
            /*provider = provider.Where(p => p.LastName.ToLower().Contains(tbSerch.Text.ToString().ToLower()));
            dgvProvader.ItemsSource = provider;*/
        }
    }
    
}

