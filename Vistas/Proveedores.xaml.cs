using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for Proveedores.xaml
    /// </summary>
    public partial class Proveedores : Window
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtBoxCuit.Text = "";
            txtBoxDireccion.Text = "";
            txtBoxRazon.Text = "";
            txtBoxTelefono.Text = "";
            txtBoxCuit.IsEnabled = true;
            txtBoxDireccion.IsEnabled = true;
            txtBoxRazon.IsEnabled = true;
            txtBoxTelefono.IsEnabled = true;

            btnGuardar.IsEnabled = true;
            btnCancelar.IsEnabled = true;


            btnNuevo.IsEnabled = false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnPrimero.IsEnabled =false;
            btnSiguiente.IsEnabled = false;
            btnAnterior.IsEnabled = false;
            btnUltimo.IsEnabled = false;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtBoxCuit.Text + "/n" + txtBoxDireccion.Text + "/n" + txtBoxRazon.Text + "/n" + txtBoxTelefono.Text);
            txtBoxCuit.IsEnabled = false;
            txtBoxDireccion.IsEnabled = false;
            txtBoxRazon.IsEnabled = false;
            txtBoxTelefono.IsEnabled = false;

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = false;

            btnNuevo.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnPrimero.IsEnabled = true;
            btnSiguiente.IsEnabled = true;
            btnAnterior.IsEnabled = true;
            btnUltimo.IsEnabled = true;

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtBoxCuit.Text = "";
            txtBoxDireccion.Text = "";
            txtBoxRazon.Text = "";
            txtBoxTelefono.Text = "";

            txtBoxCuit.IsEnabled = false;
            txtBoxDireccion.IsEnabled = false;
            txtBoxRazon.IsEnabled = false;
            txtBoxTelefono.IsEnabled = false;

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = false;

            btnNuevo.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnPrimero.IsEnabled = true;
            btnSiguiente.IsEnabled = true;
            btnAnterior.IsEnabled = true;
            btnUltimo.IsEnabled = true;

        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      

       

        
    }
}
