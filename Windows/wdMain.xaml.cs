using accountingProgram.Pages;
using accountingProgram.Windows.add;
using diplomaISPr22_33_PankovEA.data.api.user;
using DiplomaOborotovIS.data.api.model.user;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace accountingProgram.Windows
{
    /// <summary>
    /// Interaction logic for wdMain.xaml
    /// </summary>
    public partial class wdMain : Window
    {
        User User;

        public wdMain()
        {
            InitializeComponent();
            update();
            frMain.Navigate(new pgMainChart());
        }

        void update()
        {
            var api = new UserApi();
            User = api.GetUser();

            DataContext = User;
            UserGET.Text = User.FirstName + " " + User.LastName;
            //var Photo = User.Photo;
            //var uri = new Uri(Photo);
            // var bitmap = new BitmapImage(uri);
            //Image.ImageSource = bitmap;
        }

        private void mouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void mouseDownMove(object sender, MouseButtonEventArgs e)
        {
            
        }
        private bool IsMaxWindow = false;
        private void mouseDownMax(object sender, MouseButtonEventArgs e)
        {
            if (IsMaxWindow)
            {
                this.WindowState = WindowState.Normal;
                this.Width = 1080;
                this.Height = 720;
                IsMaxWindow = false;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                IsMaxWindow = true;
            }
        }

        private void mouseDownMin(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        bool isWiden = false;

        private void clOpenWindowRegister(object sender, RoutedEventArgs e)
        {
            switch1 = 1;
            frMain.Navigate(new pgOrder());
            tbTitleFrame.Text = "Заказы";

            var api = new UserApi();

            btAddOpenWindow.Visibility = Visibility.Visible;

            string role = api.GetUserRole().ToString();

            if (role == "AdminUser")
            {
                btAddOpenWindow.Visibility = Visibility.Visible;
            }

            if (role == "EmployeeUser")
            {
                btAddOpenWindow.Visibility = Visibility.Visible;
            }

            if (role == "ProviderUser")
            {
                btAddOpenWindow.Visibility = Visibility.Visible;
            }

            if (role == "BaseUser")
            {
                btAddOpenWindow.Visibility = Visibility.Visible;
            }
        }
        int switch1 = 1;
        private void clOpenPageDoctors(object sender, RoutedEventArgs e)
        {
            tbTitleFrame.Text = "Склады";


            switch1 = 2;
            frMain.Navigate(new pgStorages());
            tbTitleFrame.Text = "Склады";

            var api = new UserApi();

            btAddOpenWindow.Visibility = Visibility.Visible;

            string role = api.GetUserRole().ToString();

            if (role == "AdminUser")
            {
                btAddOpenWindow.Visibility = Visibility.Visible;
            }

            if (role == "ProviderUser")
            {
                btAddOpenWindow.Visibility = Visibility.Visible;
            }


        }

        private void clOpenPageRecept(object sender, RoutedEventArgs e)
        {

            switch1 = 3;
            frMain.Navigate(new pgProvaider());
            tbTitleFrame.Text = "Поставщики";

            var api = new UserApi();

            btAddOpenWindow.Visibility = Visibility.Collapsed;

            string role = api.GetUserRole().ToString();

            if (role == "AdminUser")
            {
                btAddOpenWindow.Visibility = Visibility.Visible;
            }

            if (role == "EmployeeUser")
            {
                btAddOpenWindow.Visibility = Visibility.Visible;
            }
        }

        private void clAdd(object sender, RoutedEventArgs e)
        {
            switch (switch1)
            {
                case 1:
                    new wdAddOrder().ShowDialog();
                    frMain.Navigate(new pgOrder());

                    break;
                case 2:
                    new wdAddStorages().ShowDialog();
                    frMain.Navigate(new pgStorages());

                    break;
                case 3:
                    new wdProvider().ShowDialog();
                    frMain.Navigate(new pgProvaider());

                    break;
            }
        }

        private void clExit(object sender, RoutedEventArgs e)
        {
            var api = new UserApi();
            api.SignOut();
            Close();
        }

        private void clOpenWindowChart(object sender, RoutedEventArgs e)
        {
            frMain.Navigate(new pgMainChart());
        }

        private void mdDomlodeImage(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog { Filter = "Jpeg files|*.jpg|All file|*.*" };

            if (openFile.ShowDialog() == true)
            {
                //User.Photo = File.ReadAllBytes(openFile.FileName);

                var api = new UserApi();
                var uri = new Uri(openFile.FileName);
                var bitmap = new BitmapImage(uri);
                api.updatePhoto(File.ReadAllBytes(openFile.FileName));
                ImagePrifile.ImageSource = bitmap;


            }
        }
    }
}
