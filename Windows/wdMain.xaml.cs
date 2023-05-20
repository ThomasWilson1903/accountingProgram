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

namespace accountingProgram.Windows
{
    /// <summary>
    /// Interaction logic for wdMain.xaml
    /// </summary>
    public partial class wdMain : Window
    {
        public wdMain()
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
            tbTitleFrame.Text = "Заказы";
        }

        private void clOpenPageDoctors(object sender, RoutedEventArgs e)
        {
            tbTitleFrame.Text = "Склады";

        }

        private void clOpenPageRecept(object sender, RoutedEventArgs e)
        {

            tbTitleFrame.Text = "Поставщики";
        }
    }
}
