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
using BibliotecaClases;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace ServiExpress
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Home : MetroWindow
    {
        public Home()
        {
            InitializeComponent();
            tLogin.IsEnabled = false;
                       
        }
        

        private void DeployDuoc(object sender, RoutedEventArgs e)
        {
            // web Duoc...
        }

        private void TIngresos_Click(object sender, RoutedEventArgs e)
        {
            InTaller acl = new InTaller() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            ListarIngresosTaller acl = new ListarIngresosTaller() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private void TConvenios_Click(object sender, RoutedEventArgs e)
        {
            AdminConvenios acl = new AdminConvenios() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private void TServicios_Click(object sender, RoutedEventArgs e)
        {
            AdminServicios acl = new AdminServicios() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private void TAdminClientes_Click(object sender, RoutedEventArgs e)
        {
            AdminClientes acl = new AdminClientes() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private void TListadoClientes_Click(object sender, RoutedEventArgs e)
        {
            ListarClientes acl = new ListarClientes() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

       
        private async void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("Información", "Sesión cerrada");
            MainWindow acl = new MainWindow() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }
    }
}
