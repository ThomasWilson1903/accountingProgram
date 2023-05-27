using accountingProgram.Windows;
using diplomaISPr22_33_PankovEA.data.api.user;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace accountingProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void mouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void mouseDownMove(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void clEnterSystem(object sender, RoutedEventArgs e)
        {
            var api = new UserApi();

            var response = api.auth(new AuthBody
            {
                Login = tbLogin.Text,
                Password = pbPassword.Password
            });
            if (response.Access_token != "")
            {
                Application.Current.MainWindow.Hide();
                new wdMain().ShowDialog();

                Application.Current.MainWindow.Close();
                tbLogin.Text = "";
                pbPassword.Password = "";
            }
            else
                MessageBox.Show("Error");
        }
    }
}
