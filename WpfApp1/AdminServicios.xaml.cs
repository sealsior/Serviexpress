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
using MahApps.Metro.Controls;
using BibliotecaClases;
using MahApps.Metro.Controls.Dialogs;

namespace ServiExpress
{
    /// <summary>
    /// Lógica de interacción para AdminServicios.xaml
    /// </summary>
    public partial class AdminServicios : MetroWindow
    {
        public AdminServicios()
        {
            InitializeComponent();
            cargarServicios();
            LimpiarControles();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            Home acl = new Home() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }
        private void cargarServicios()
        {
            dgServicios.ItemsSource = new Servicio().ReadAll();
        }

        public void LimpiarControles()
        {
            this.txtIdServicio.Text = String.Empty;
            this.txtDescripcion.Text = String.Empty;
            this.txtPrecio.Text = String.Empty;
            txtIdServicio.IsEnabled = false;
            tsEditar.IsOn = false;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnBuscarId.IsEnabled = false;

        }

        private async void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = new Servicio()
            {
                descripcion = txtDescripcion.Text,
                precio = int.Parse(txtPrecio.Text)


            };

            if (!servicio.Read())
            {
                if (servicio.Create())
                {   
                    await this.ShowMessageAsync("Registro Exitoso!", "Nuevo servicio agregado");
                    LimpiarControles();
                    cargarServicios();

                }
                else
                {
                    await this.ShowMessageAsync("Atención", "Servicio no pudo ser registrado");
                }

            }
            else
            {
                await this.ShowMessageAsync("Error!", "El servicio ya existe");
            }
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    txtIdServicio.IsEnabled = true;
                    btnBuscarId.IsEnabled = true;
                    txtDescripcion.IsEnabled = false;
                    txtPrecio.IsEnabled = false;
                    btnRegistrar.IsEnabled = false;
                }
                else
                {
                    txtDescripcion.IsEnabled = true;
                    txtPrecio.IsEnabled = true;
                    btnRegistrar.IsEnabled = true;
                    LimpiarControles();
                }
            }
        }

        private async void BtnBuscarId_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = new Servicio()
            {
                id_servicio = int.Parse(txtIdServicio.Text)
            };

            if (servicio.Read())
            {
                txtDescripcion.Text = servicio.descripcion;
                txtPrecio.Text = servicio.precio.ToString();
                await this.ShowMessageAsync("Información", "Registro encontrado");
                txtDescripcion.IsEnabled = true;
                txtPrecio.IsEnabled = true;
                btnActualizar.IsEnabled = true;
                btnBuscarId.IsEnabled = false;
                btnEliminar.IsEnabled = true;

            }
            else
            {
                await this.ShowMessageAsync("Error!", "Numero de ID no existe");
                
            }
        }

        private async void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = new Servicio()
            {
                descripcion = txtDescripcion.Text,
                precio = int.Parse(txtPrecio.Text),
                id_servicio = int.Parse(txtIdServicio.Text)
            };

            if (servicio.Update())
            {
                await this.ShowMessageAsync("Información!", "Servicio ID :" + txtIdServicio.Text + " actualizado");
                LimpiarControles();
                cargarServicios();
            }
            else
            {
                await this.ShowMessageAsync("Error!", "El servicio no pudo ser actualizado");
            }
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarControles();
        }

        private async void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Servicio servicio = new Servicio()
            {
                id_servicio = int.Parse(txtIdServicio.Text)
            };

            MessageDialogResult eliminar = await this.ShowMessageAsync("¿Eliminar este Servicio?", "Confirmar", MessageDialogStyle.AffirmativeAndNegative);
            if (eliminar == MessageDialogResult.Affirmative)
            {
                if (servicio.Delete())
                {
                    
                    await this.ShowMessageAsync("Información", "Servicio ID: " + txtIdServicio.Text + " eliminado exitosamente");
                    LimpiarControles();
                    cargarServicios();

                }
                else
                {
                    await this.ShowMessageAsync("Error!", "El servicio no pudo ser eliminado");
                }
            }
        }
    }
}

