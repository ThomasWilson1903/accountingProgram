using accountingProgram.data.api.provider;
using accountingProgram.Windows.add;
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

namespace accountingProgram.Windows.edit
{
    /// <summary>
    /// Interaction logic for wdEditProvider.xaml
    /// </summary>
    public partial class wdEditProvider : Window
    {
        Provider Provider;
        Provider Provider1;
        List<User> users;
        public wdEditProvider(Provider provider)
        {
            this.Provider = provider;
            this.Provider1 = provider;
            InitializeComponent();
            DataContext = Provider;
            var api = new UserApi();
            DataContext = Provider;//вывод прикрепленные данные
            tbUserLastName.Text = Provider1.LastName;
            ///и в момент вывода прикрепленных данных происходит выбор элемента 
        }

        private void clEditProvider(object sender, RoutedEventArgs e)
        {

            var api = new ProviderApi();
            api.Update(Provider.Id, new UpdateProviderDto
            {
                FirstName = Provider1.FirstName,
                LastName = Provider1.LastName,
                Login = Provider1.Login,
                MidleName = Provider1.MidleName,
                Address = tbAddres.Text,
                PhoneNumber = tbAddres.Text,
            });

            Close();
        }
    }
}
