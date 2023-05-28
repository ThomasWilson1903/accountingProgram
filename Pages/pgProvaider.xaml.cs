using accountingProgram.data.api.provider;
using accountingProgram.Windows.add;
using accountingProgram.Windows.edit;
using diplomaISPr22_33_PankovEA.data.api.user;
using DiplomaOborotovIS.data.api.model.provider;
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

        IEnumerable<Provider> provider;

        public pgProvaider()
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
            if (UserRoles == "EmployeeUser")
            {
                Operations.Visibility = Visibility.Visible;
            }
        }

        private void clDel(object sender, RoutedEventArgs e)
        {
            Provider del = (sender as Button).DataContext as Provider;
            var api = new ProviderApi();
            api.Delete(del.Id);
            NavigationService.Navigate(new pgProvaider());
        }

        private void clChang(object sender, RoutedEventArgs e)
        {
            Provider chang = (sender as Button).DataContext as Provider;
            var api = new ProviderApi();
            new wdEditProvider(chang).ShowDialog();
            NavigationService.Navigate(new pgProvaider());
        }

        void update()
        {
            var api = new ProviderApi();
            provider = api.GetAll(tbSerch.Text);
            dgvProvader.ItemsSource = provider;
        }

        private void tcSerch(object sender, TextChangedEventArgs e)
        {
            provider = provider.Where(p => p.LastName.ToLower().Contains(tbSerch.Text.ToString().ToLower()));
            dgvProvader.ItemsSource = provider;
        }
    }
    
}

