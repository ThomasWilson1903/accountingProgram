using accountingProgram.data.api.provider;
using diplomaISPr22_33_PankovEA.data.api.user;
using DiplomaOborotovIS.data.api.model.provider;
using DiplomaOborotovIS.data.api.model.user;
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
    /// Interaction logic for wdProvider.xaml
    /// </summary>
    public partial class wdProvider : Window
    {
        List<User> users;
        public wdProvider()
        {
            InitializeComponent();
            var api = new UserApi();
            users = api.GetUsers();
            cbUser.ItemsSource = users;
        }

        private void clAddProvider(object sender, RoutedEventArgs e)
        {
            var api = new ProviderApi();
            api.Add(new CreateProviderDto
            {
                Address = tbAddres.Text,
                PhoneNumber = tbPhone.Text,
                UserId = users[cbUser.SelectedIndex].Id,
            });
            Close();
        }
    }
}
