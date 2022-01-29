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
using System.Text.RegularExpressions;

namespace ServiExpress
{
    /// <summary>
    /// Lógica de interacción para ListarIngresosTaller.xaml
    /// </summary>
    public partial class ListarIngresosTaller : MetroWindow
    {
        public ListarIngresosTaller()
        {
            InitializeComponent();
            CargarServicios();
            CargarListaIngresos();
            CargarClientes();
            CargarFabricantes();
        }

        private void CargarServicios()
        {
            cboServicios.ItemsSource = new Servicio().ReadAll();
            cboServicios.DisplayMemberPath = "descripcion";
            cboServicios.SelectedValuePath = "id_servicio";
            cboServicios.SelectedIndex = 0;
        }

        private void CargarFabricantes()
        {
            cboFabricante.ItemsSource = new Fabricante().ReadAll();
            cboFabricante.DisplayMemberPath = "nombrefabricante";
            cboFabricante.SelectedValuePath = "id_fabricante";
            cboFabricante.SelectedIndex = 0;
        }

        private void CargarClientes()
        {
            cboCliente.ItemsSource = new Cliente().ReadAll();
            cboCliente.DisplayMemberPath = "nombre";
            cboCliente.SelectedValuePath = "rut_cliente";
            cboCliente.SelectedIndex = 0;
        }


        private void CargarListaIngresos()
        {
            dgListadoIngresos.ItemsSource = new IngresoTaller().ReadAll();
        }

        

        private void BtnIngresarTaller_Click(object sender, RoutedEventArgs e)
        {
            InTaller acl = new InTaller() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.cboCliente.SelectedIndex = 0;
            this.cboFabricante.SelectedIndex = 0;
            this.cboServicios.SelectedIndex = 0;
            CargarListaIngresos();
        }

       

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            Home acl = new Home() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private void BtnFabricante_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboFabricante.SelectedValue;
            dgListadoIngresos.ItemsSource = new IngresoTaller().ReadByFabricante(id);
        }

        private void BtnBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            string rut = cboCliente.SelectedValue.ToString();
            dgListadoIngresos.ItemsSource = new IngresoTaller().ReadByCliente(rut);
        }

        private void BtnBuscarServicio_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)cboServicios.SelectedValue;
            dgListadoIngresos.ItemsSource = new IngresoTaller().ReadByServicio(id);
        }
    }
}
