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

namespace ServiExpress
{
    /// <summary>
    /// Lógica de interacción para IngresoTaller.xaml
    /// </summary>
    public partial class IngresoTaller : MetroWindow
    {
        public IngresoTaller()
        {
            InitializeComponent();
        }

        //TERMINAR ESTE METODO*************      
        private void BtnIngresoTaller_Click(object sender, RoutedEventArgs e)
        {
            BibliotecaClases.InTaller ita = new BibliotecaClases.InTaller();

           
            



        }

        private void BtnListarMantenciones_Click(object sender, RoutedEventArgs e)
        {
            ListarIngresosTaller acl = new ListarIngresosTaller() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.txtNroIngreso.Text = string.Empty;
            this.txtRutCliente.Text = string.Empty;
            this.txtPatente.Text = string.Empty;
            this.txtModelo.Text = string.Empty;
            this.cboAnno.SelectedIndex = 0;
            this.cboFabricante.SelectedIndex = 0;
            this.cboServicio.SelectedIndex = 0;
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow acl = new MainWindow() { Owner = this };
            acl.ShowDialog();
            this.Close();
        }
    }
}
