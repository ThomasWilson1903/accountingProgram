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
    /// Interaction logic for wdEditStorege.xaml
    /// </summary>
    public partial class wdEditStorege : Window
    {
        //Warehouse Warehouse;

        public wdEditStorege(/*Warehouse warehouse*/)
        {
            //this.Warehouse = warehouse;
            InitializeComponent();
            //DataContext = Warehouse;
        }

        private void clWarehouse(object sender, RoutedEventArgs e)
        {
            /*var api = new WarehouseNetworkApi();
            api.Update(Warehouse.Id, new CreateWarehouseDto
            {
                Address = tbAddress.Text,
                Description = tbDescriptions.Text
            });*/
            Close();
        }
    }
}
