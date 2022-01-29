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
using ServiExpress;
using BibliotecaClases;

using MahApps.Metro.Controls.Dialogs;

using MahApps.Metro.Controls;

namespace ServiExpress
{
    /// <summary>
    /// Lógica de interacción para ListarClientes.xaml
    /// </summary>
    public partial class ListarClientes : MetroWindow

    {
        public bool ClientList = true;

        public ListarClientes()
        {
            InitializeComponent();
            CargarClientes();
            LimpiarControles();
            CargarTipoConvenio();

        }

        private void CargarTipoConvenio()
        {
            cboConvenio.ItemsSource = new Convenio().ReadAll();
            cboConvenio.DisplayMemberPath = "descripcion";
            cboConvenio.SelectedValuePath = "id_convenio";
            cboConvenio.SelectedIndex = 0;
        }

        private void LimpiarControles()
        {
            txtBuscarRut.Text = string.Empty;
        }

        private void CargarClientes()
        {
            //Cargar todos los clientes
            Cliente cli = new Cliente();
            //gdClientes.ItemsSource = cli.ReadAll();
            dgClientes.ItemsSource = new Cliente().ReadAll();
        }

        private void BtnMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            Home acl = new Home() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private void dgClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnBuscarRut_Click(object sender, RoutedEventArgs e)
        {
            if (txtBuscarRut.Text != string.Empty)
            {
                Cliente cli = new Cliente()
                {

                    rut_cliente = txtBuscarRut.Text
                };

                if (cli.Read())
                {
                    dgClientes.ItemsSource = new Cliente().ReadByRut(txtBuscarRut.Text);
                }
                else
                {
                    this.ShowMessageAsync("¡Error!: ",
                        string.Format("Rut no encontrado"));
                }

            }
            else
            {
                dgClientes.ItemsSource = new Cliente().ReadAll();

            }


        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSeleccionClientes_Click(object sender, RoutedEventArgs e)
        {
            if (dgClientes.SelectedIndex != -1)
            {
                if (ClientList == true)
                {
                    Cliente cli = dgClientes.SelectedItem as Cliente;
                    AdminClientes ac = new AdminClientes()
                    {
                    };

                    if (cli.Read())
                    {
                        ac.txtRut.Text = cli.rut_cliente;
                        ac.txtNombre.Text = cli.nombre;
                        ac.txtMail.Text = cli.email;
                        ac.txtTelefono.Text = cli.telefono.ToString();
                        ac.txtDireccion.Text = cli.direccion;
                        ac.cboConvenio.SelectedIndex = cli.id_convenio;
                    }
                    ac.Show();
                    this.Close();
                }
                else
                {
                    Cliente cli = dgClientes.SelectedItem as Cliente;
                    AdminClientes aco = new AdminClientes()
                    {

                    };
                    if (cli.Read())
                    {
                        aco.txtRut.Text = cli.rut_cliente;
                    }
                    aco.Show();
                    this.Close();

                }

            }
            else
            {
                this.ShowMessageAsync("¡Atencion!: ",
                          string.Format("Porfavor seleccione una fila"));
            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnTipoConvenio_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboConvenio.SelectedValue;
            dgClientes.ItemsSource = new Cliente().ReadByConvenio(id);


            // dgClientes.ItemsSource = new Cliente()

            //if (!cboConvenio.SelectedIndex.Equals(1))
            // {
            //    dgClientes.ItemsSource = new Cliente().ReadByConvenio((int)cboConvenio.SelectedValue);
            // }else
            // {
            //     this.ShowMessageAsync("¡Error!: ",
            //               string.Format("Porfavor seleccione una actividad"));

            // }

        }

        private void btnLimpiarBusqueda_Click(object sender, RoutedEventArgs e)
        {
            LimpiarControles();

        }
    }
}
