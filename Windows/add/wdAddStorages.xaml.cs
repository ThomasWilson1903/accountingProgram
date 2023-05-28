using accountingProgram.data.api.warehouse;
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
using System.Windows.Shapes;

namespace accountingProgram.Windows.add
{
    /// <summary>
    /// Interaction logic for wdAddStorages.xaml
    /// </summary>
    public partial class wdAddStorages : Window
    {
        public wdAddStorages()
        {
            InitializeComponent();



        }

        private void clWarehouse(object sender, RoutedEventArgs e)
        {
            var api = new WarehouseApi();
            api.Add(new CreateWarehouseDto
            {
                Address = tbAddress.Text,
                Description = tbDescriptions.Text,
            });
            Close();
        }
    }
}
