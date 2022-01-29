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
using MahApps.Metro.Controls;
using BibliotecaClases;
using System.Text.RegularExpressions;
using MahApps.Metro.Controls.Dialogs;

namespace ServiExpress
{
    /// <summary>
    /// Lógica de interacción para IngresoTaller.xaml
    /// </summary>
    public partial class InTaller : MetroWindow
    {
        public InTaller()
        {
            InitializeComponent();
            LimpiarControles();
            CargarIngresos();
            CargarServicios();
            CargarFabricantes();
            DisableFields();


        }

        private void CargarIngresos()
        {
           dgIngresos.ItemsSource = new IngresoTaller().ReadAll();
        }

        private void CargarFabricantes()
        {
            cboFabricante.ItemsSource = new Fabricante().ReadAll();
            cboFabricante.DisplayMemberPath = "nombrefabricante";
            cboFabricante.SelectedValuePath = "id_fabricante";
            cboFabricante.SelectedIndex = 0;
        }

        private void CargarServicios()
        {
            cboServicio.ItemsSource = new Servicio().ReadAll();
            cboServicio.DisplayMemberPath = "descripcion";
            cboServicio.SelectedValuePath = "id_servicio";
            cboServicio.SelectedIndex = 0;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private async void BtnIngresoTaller_Click(object sender, RoutedEventArgs e)
        {
            IngresoTaller ingreso = new IngresoTaller()
            {
                patente = txtPatente.Text,
                id_fabricante = int.Parse(cboFabricante.SelectedValue.ToString()),
                anno = int.Parse(txtAnno.Text),
                modelo = txtModelo.Text,
                id_servicio = int.Parse(cboServicio.SelectedValue.ToString()),
                rut_cliente = txtRutCliente.Text


            };

            if (!ingreso.Read())
            {
                if (ingreso.Create())
                {
                    await this.ShowMessageAsync("Registro exitoso", "Vehículo patente " + txtPatente.Text + " ingresado a taller");
                    LimpiarControles();
                    CargarIngresos();
                }
                else
                {
                    await this.ShowMessageAsync("Atención", "Ingreso no pudo ser registrado");
                    lblValidaRut.Content = "Debe ingresar un rut registrado";
                }

            }
            else
            {
                await this.ShowMessageAsync("Error!", "El registro ya existe");
            }
        }

        private void BtnListarMantenciones_Click(object sender, RoutedEventArgs e)
        {
            ListarIngresosTaller acl = new ListarIngresosTaller() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        public void LimpiarControles()
        {
            this.txtNroIngreso.Text = string.Empty;
            this.txtRutCliente.Text = string.Empty;
            this.txtPatente.Text = string.Empty;
            this.txtModelo.Text = string.Empty;
            this.txtAnno.Text = string.Empty;
            this.cboFabricante.SelectedIndex = 0;
            this.cboServicio.SelectedIndex = 0;
            lblValidaRut.Content = "";
            txtRutCliente.IsEnabled = true;
            tsEditar.IsOn = false;
            DisableFields();
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnIngresoTaller.IsEnabled = false;
            btnBuscarIngreso.IsEnabled = false;
        }

        public void EnableFields()
        {
            
            txtPatente.IsEnabled = true;
            txtModelo.IsEnabled = true;
            txtAnno.IsEnabled = true;
            cboFabricante.IsEnabled = true;
            cboServicio.IsEnabled = true;
        }

        public void EnableFields2()
        {
            txtRutCliente.IsEnabled = true;
            txtPatente.IsEnabled = true;
            txtModelo.IsEnabled = true;
            txtAnno.IsEnabled = true;
            cboFabricante.IsEnabled = true;
            cboServicio.IsEnabled = true;
        }

        public void DisableFields()
        {
            txtNroIngreso.IsEnabled = false;
            txtPatente.IsEnabled = false;
            txtModelo.IsEnabled = false;
            txtAnno.IsEnabled = false;
            cboFabricante.IsEnabled = false;
            cboServicio.IsEnabled = false;

        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarControles();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            Home acl = new Home() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private async void BtnBuscarIngreso_Click(object sender, RoutedEventArgs e)
        {
            IngresoTaller ingreso = new IngresoTaller()
            {
                num_ingreso = int.Parse(txtNroIngreso.Text)
            };

            if (ingreso.Read())
            {
                txtPatente.Text = ingreso.patente;
                cboFabricante.SelectedValue = ingreso.id_fabricante;
                txtAnno.Text = ingreso.anno.ToString();
                txtModelo.Text = ingreso.modelo;
                cboServicio.SelectedValue = ingreso.id_servicio;
                txtRutCliente.Text = ingreso.rut_cliente;
                await this.ShowMessageAsync("Información", "Registro encontrado");
                txtNroIngreso.IsEnabled = false;
                btnActualizar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnIngresoTaller.IsEnabled = false;
                btnBuscarCliente.IsEnabled = true;
                EnableFields2();


            }
            else
            {
                await this.ShowMessageAsync("Error!", "Numero de ingreso no existe ");
            }
        }

        private async void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            IngresoTaller ingresoTaller = new IngresoTaller()
            {
                num_ingreso = int.Parse(txtNroIngreso.Text),
                patente = txtPatente.Text,
                id_fabricante = int.Parse(cboFabricante.SelectedValue.ToString()),
                anno = int.Parse(txtAnno.Text),
                modelo = txtModelo.Text,
                id_servicio = int.Parse(cboServicio.SelectedValue.ToString()),
                rut_cliente = txtRutCliente.Text
            };

            if (ingresoTaller.Update())
            {
                await this.ShowMessageAsync("Información", "Ingreso de vehículo patente " + txtPatente.Text + " actualizado");
                LimpiarControles();
                CargarIngresos();
            }
            else
            {
                await this.ShowMessageAsync("Atención!", "Ingreso no pudo ser actualizado");
            }
        }

        private async void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            IngresoTaller ingresoTaller = new IngresoTaller()
            {
                num_ingreso = int.Parse(txtNroIngreso.Text)
            };

            MessageDialogResult eliminar = await this.ShowMessageAsync("¿Eliminar este ingreso?", "Confirmar", MessageDialogStyle.AffirmativeAndNegative);
            if (eliminar == MessageDialogResult.Affirmative)
            {
                if (ingresoTaller.Delete())
                {
                    await this.ShowMessageAsync("Información", "Ingreso ID: " + txtNroIngreso.Text +  " eliminado");
                    LimpiarControles();
                    CargarIngresos();

                }
                else
                {
                    await this.ShowMessageAsync("Atención", "Ingreso no pudo ser eliminado");
                   
                }
            }
        }

        private async void BtnBuscarCliente_Click(object sender, RoutedEventArgs e)
        {

            Cliente cliente = new Cliente()
            {
                rut_cliente = txtRutCliente.Text
            };

            if (cliente.Read())
            {
                await this.ShowMessageAsync("Información", "Cliente " + cliente.nombre + " encontrado");
                lblValidaRut.Foreground = Brushes.Green;
                lblValidaRut.Content = "Cliente valido";
                txtRutCliente.IsEnabled = false;
                btnIngresoTaller.IsEnabled = true;
                EnableFields();
            }
            else
            {
                await this.ShowMessageAsync("Error!", "Cliente rut " + txtRutCliente.Text + " no registrado");
                lblValidaRut.Content = "Debe ingresar un rut registrado";
                lblValidaRut.Foreground = Brushes.Red;
            }

        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    txtNroIngreso.IsEnabled = true;
                    txtRutCliente.IsEnabled = false;
                    btnBuscarIngreso.IsEnabled = true;
                    btnBuscarCliente.IsEnabled = false;

                }
                else
                {
                    txtNroIngreso.IsEnabled = false;
                    txtRutCliente.IsEnabled = true;
                    btnBuscarCliente.IsEnabled = true;
                    LimpiarControles();
                }
            }
        }
    }
}
