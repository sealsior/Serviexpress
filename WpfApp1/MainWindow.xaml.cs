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
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DisableTiles();

        }

        public void DisableTiles()
        {
            tIngresos.IsEnabled = false;
            tListadoIngresos.IsEnabled = false;
            tAdminClientes.IsEnabled = false;
            tConvenios.IsEnabled = false;
            tServicios.IsEnabled = false;
            tListadoClientes.IsEnabled = false;
            btnLogout.Visibility = Visibility.Hidden;
        }

        public void EnableTiles()
        {
            tIngresos.IsEnabled = true;
            tListadoIngresos.IsEnabled = true;
            tAdminClientes.IsEnabled = true;
            tConvenios.IsEnabled = true;
            tServicios.IsEnabled = true;
            tListadoClientes.IsEnabled = true;
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

        private void TLogin_Click(object sender, RoutedEventArgs e)
        {
            flyLogin.IsOpen = true;
        }

        private async void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                email = txtEmail.Text
            };

            if (usuario.Read())
            {
                if(txtPassword.Password == usuario.password)
                {
                    await this.ShowMessageAsync("Ingreso exitoso", "Bienvenido " + usuario.nombreusuario);
                    EnableTiles();
                    txtEmail.Text = string.Empty;
                    txtPassword.Password = string.Empty;
                    tLogin.IsEnabled = false;
                    btnLogout.Visibility = Visibility.Visible;
                    flyLogin.IsOpen = false;
                    tLogin.Title = usuario.nombreusuario;
                }
                else
                {
                    await this.ShowMessageAsync("Error!", "Contraseña incorrecta");
                }
                
            }
            else
            {
                await this.ShowMessageAsync("Error!", "Credenciales incorrectas");
            }
        }

        
        private async void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("Información", "Sesión cerrada");
            DisableTiles();
            tLogin.IsEnabled = true;
            tLogin.Title = "Login";
        }
    }
}
