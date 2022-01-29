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
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Controls;
/* Add's*/
using BibliotecaClases;

namespace ServiExpress
{
    /// <summary>
    /// Lógica de interacción para AdminClientes.xaml
    /// </summary>
    public partial class AdminClientes : MetroWindow
    {
        public AdminClientes()
        {
            InitializeComponent();
            CargarClientes();
            CargarTipos();

        }

        private void CargarTipos()
        {
            cboConvenio.ItemsSource = new Convenio().ReadAll();
            cboConvenio.DisplayMemberPath = "descripcion";
            cboConvenio.SelectedValuePath = "id_convenio";
            cboConvenio.SelectedIndex = 0;

        }

        private void CargarClientes()
        {
            //Cargar todos los clientes
            Cliente cli = new Cliente();
            //gdClientes.ItemsSource = cli.ReadAll();
            gdClientes.ItemsSource = new Cliente().ReadAll();

        }

        private void BtnMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            Home acl = new Home() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Click_GuardarCli(object sender, RoutedEventArgs e)
        {
            if (txtRut.Text != string.Empty)
            {
                if (txtNombre.Text != string.Empty)
                {
                    if (txtMail.Text != string.Empty)
                    {
                        if (txtTelefono.Text != string.Empty)
                        {
                            if (txtDireccion.Text != string.Empty)
                            {
                                Cliente cli = new Cliente()
                                {
                                    rut_cliente = txtRut.Text,
                                    nombre = txtNombre.Text,
                                    direccion = txtDireccion.Text,
                                    telefono = int.Parse(txtTelefono.Text),
                                    email = txtMail.Text,
                                    id_convenio = (int)cboConvenio.SelectedValue
                                };
                                if (cli.Create())
                                {
                                    this.ShowMessageAsync("Confirmacion : ",
                                       string.Format("cliente registrado exitosamente"));
                                    CargarClientes();
                                    this.txtRut.Text = string.Empty;
                                    this.txtNombre.Text = string.Empty;
                                    this.txtMail.Text = string.Empty;
                                    this.txtTelefono.Text = string.Empty;
                                    this.txtDireccion.Text = string.Empty;

                                }
                                else
                                {
                                    this.ShowMessageAsync("Atencion: ",
                                                 string.Format("Error al registrar"));
                                }


                            }
                            else
                            {
                                this.ShowMessageAsync("¡Validacion!: ",
                                                  string.Format("¡Debe ingresar una direccion de contacto!"));
                            }

                        }
                        else
                        {
                            this.ShowMessageAsync("¡Validacion!: ",
                                                  string.Format("¡Debe ingresar un telefono de contacto!"));
                        }

                    }

                    else
                    {
                        this.ShowMessageAsync("¡Validacion!: ",
                                                  string.Format("¡Debe ingresar un Mail!"));
                    }

                }
                else
                {
                    this.ShowMessageAsync("¡Validacion!: ",
                                                  string.Format("¡Debe ingresar un Nombre!"));
                }

            }
            else
            {
                this.ShowMessageAsync("¡Validacion!: ",
                                                   string.Format("¡Debe ingresar un Rut!"));

            }


        }

        private void bntLimpiar_Click(object sender, RoutedEventArgs e)
        {

            this.txtRut.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtMail.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Click_BuscarCli(object sender, RoutedEventArgs e)
        {

            if (txtRut.Text != string.Empty)
            {
                Cliente cli = new Cliente()
                {
                    rut_cliente = txtRut.Text,

                };
                if (cli.Read())
                {
                    txtNombre.Text = cli.nombre;
                    txtDireccion.Text = cli.direccion;
                    txtTelefono.Text = cli.telefono.ToString();
                    txtMail.Text = cli.email;

                    this.ShowMessageAsync("¡Validacion!: ",
                                   string.Format("Cliente  Leido"));
                }
                else
                {
                    this.ShowMessageAsync("¡Atencion!: ",
                                                       string.Format("Cliente no existe "));
                }

            }
            else
            {
                this.ShowMessageAsync("¡Validacion!: ",
                                     string.Format("¡Debe ingresar una Rut!"));

            }

        }

        private void btnModificarCli_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente()
            {
                rut_cliente = txtRut.Text,
                nombre = txtNombre.Text,
                direccion = txtDireccion.Text,
                telefono = int.Parse(txtTelefono.Text),
                email = txtMail.Text,
                id_convenio = (int)cboConvenio.SelectedValue

            };
            if (cli.Update())
            {
                this.ShowMessageAsync("¡Información!",
                                                     string.Format("¡Cliente Actualizado !"));
                CargarClientes();
                this.txtRut.Text = string.Empty;
                this.txtNombre.Text = string.Empty;
                this.txtMail.Text = string.Empty;
                this.txtTelefono.Text = string.Empty;
                this.txtDireccion.Text = string.Empty;

            }
            else
            {
                this.ShowMessageAsync("¡Atencion!: ",
                                           string.Format("¡Cliente No pudo ser Modificado !"));
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Click_EliminarCli(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente()
            {
                rut_cliente = txtRut.Text,
            };
            if (cli.Delete())
            {


                this.ShowMessageAsync("¡Atencion!: ",
                                                          string.Format("¡Cliente Eliminado !")); CargarClientes();

            }
            else
            {
                this.ShowMessageAsync("¡Atencion!: ",
                                                          string.Format("¡Cliente No pudo ser Eliminado !"));
            }


        }

        private void cboConvenio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}
