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
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for MenuVendedores.xaml
    /// </summary>
    public partial class MenuVendedores : Window
    {
        public MenuVendedores()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            btnCancelar.IsEnabled = false;
            btnGuardar.IsEnabled = false;

            HabilitarCampos(false);
        }

        private void LimpiezaCampos()
        {
            txtLegajo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
        }

        private void HabilitarCampos(bool isEnabled)
        {
            txtLegajo.IsEnabled = isEnabled;
            txtNombre.IsEnabled = isEnabled;
            txtApellido.IsEnabled = isEnabled;
        }

        private void HabilitarBotones(bool enabled)
        {
            btnNuevo.IsEnabled = enabled;
            btnModificar.IsEnabled = enabled;
            btnEliminar.IsEnabled = enabled;
            btnPrimero.IsEnabled = enabled;
            btnAnterior.IsEnabled = enabled;
            btnSiguiente.IsEnabled = enabled;
            btnUltimo.IsEnabled = enabled;
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            LimpiezaCampos();
            HabilitarCampos(true);

            btnGuardar.IsEnabled = true;
            btnCancelar.IsEnabled = true;
            HabilitarBotones(false);
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Guardar el Vendedor?", "Alta Vendedor", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Vendedor vend = new Vendedor();
                vend.Legajo = txtLegajo.Text;
                vend.Nombre = txtNombre.Text;
                vend.Apellido = txtApellido.Text;

                MessageBox.Show("Legajo: " + vend.Legajo + Environment.NewLine +
                    "Nombre : " + vend.Nombre + Environment.NewLine +
                    "Apellido : " + vend.Apellido, "Vendedor Agregado", MessageBoxButton.OK, MessageBoxImage.Information);

                LimpiezaCampos();
                HabilitarCampos(false);
                btnCancelar.IsEnabled = false;
                btnGuardar.IsEnabled = false;
                HabilitarBotones(true);
            }
            else
            {
                LimpiezaCampos();
                HabilitarCampos(false);
                btnCancelar.IsEnabled = false;
                btnGuardar.IsEnabled = false;
                HabilitarBotones(true);
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            LimpiezaCampos();
            HabilitarCampos(false);
            btnGuardar.IsEnabled = true;
            btnCancelar.IsEnabled = true;
            HabilitarBotones(true);
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
