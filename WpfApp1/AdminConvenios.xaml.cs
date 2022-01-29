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
    /// Lógica de interacción para AdminConvenios.xaml
    /// </summary>
    public partial class AdminConvenios : MetroWindow
    {
        public AdminConvenios()
        {
            InitializeComponent();
            cargarConvenios();
            LimpiarControles();
        }

        private void cargarConvenios()
        {
            dgConvenios.ItemsSource = new Convenio().ReadAll();
        }

        private async void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            Convenio convenio = new Convenio()
            {
                descripcion = txtDescripcion.Text,
                descuento = int.Parse(txtDescuento.Text)
                
            };

            if (!convenio.Read())
            {
                if (convenio.Create())
                {
                    await this.ShowMessageAsync("Registro Exitoso!", "Nuevo convenio agregado");
                    LimpiarControles();
                    cargarConvenios();
                }
                else
                {
                    await this.ShowMessageAsync("Atención", "Convenio no pudo ser registrado");
                                       
                }

            }
            else
            {
                await this.ShowMessageAsync("Error!", "El convenio ya existe");
            }
        }

        public void LimpiarControles()
        {
            this.txtIdConvenio.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtDescuento.Text = string.Empty;
            txtIdConvenio.IsEnabled = false;
            tsEditar.IsOn = false;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnBuscarId.IsEnabled = false;
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    txtIdConvenio.IsEnabled = true;
                    btnBuscarId.IsEnabled = true;
                    txtDescripcion.IsEnabled = false;
                    txtDescuento.IsEnabled = false;
                    btnRegistrar.IsEnabled = false; 
                }
                else
                {
                    txtDescripcion.IsEnabled = true;
                    txtDescuento.IsEnabled = true;
                    btnRegistrar.IsEnabled = true;
                    LimpiarControles();
                }
            }
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarControles();
        }

        private async void BtnBuscarId_Click(object sender, RoutedEventArgs e)
        {
            Convenio convenio = new Convenio()
            {
                id_convenio = int.Parse(txtIdConvenio.Text)
            };

            if (convenio.Read())
            {
                txtDescripcion.Text = convenio.descripcion;
                txtDescuento.Text = convenio.descuento.ToString();
                await this.ShowMessageAsync("Información", "Registro encontrado");
                txtDescripcion.IsEnabled = true;
                txtDescuento.IsEnabled = true;
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
            Convenio convenio = new Convenio()
            {
                descripcion = txtDescripcion.Text,
                descuento = int.Parse(txtDescuento.Text),
                id_convenio = int.Parse(txtIdConvenio.Text)             
            };

            if (convenio.Update())
            {
                await this.ShowMessageAsync("Información!", "Convenio " + txtDescripcion.Text + " actualizado");
                LimpiarControles();
                cargarConvenios();
            }
            else
            {
                await this.ShowMessageAsync("Atención!", "Convenio no pudo ser actualizado");
            }
        }

        private async void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Convenio convenio = new Convenio()
            {
                id_convenio = int.Parse(txtIdConvenio.Text)
            };
            
            MessageDialogResult eliminar = await this.ShowMessageAsync("¿Eliminar este Convenio?", "Confirmar", MessageDialogStyle.AffirmativeAndNegative);
            if (eliminar == MessageDialogResult.Affirmative)
            {
                if (convenio.Delete())
                {
                    await this.ShowMessageAsync("Información!", "Convenio "+ txtDescripcion.Text+  " eliminado");
                    LimpiarControles();
                    cargarConvenios();

                }
                else
                {
                    await this.ShowMessageAsync("Error!", "Convenio no pudo ser eliminado");
                }
            }
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            Home acl = new Home() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }
    }
}
