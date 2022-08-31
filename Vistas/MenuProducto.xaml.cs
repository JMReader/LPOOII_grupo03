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
    /// Interaction logic for MenuProducto.xaml
    /// </summary>
    public partial class MenuProducto : Window
    {
        public MenuProducto()
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
            txtCodigo.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        private void HabilitarCampos(bool isEnabled)
        {
            txtCodigo.IsEnabled = isEnabled;
            txtCategoria.IsEnabled = isEnabled;
            txtColor.IsEnabled = isEnabled;
            txtPrecio.IsEnabled = isEnabled;
            txtDescripcion.IsEnabled = isEnabled;
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
            MessageBoxResult result = MessageBox.Show("¿Guardar el Producto?", "Alta Producto", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Producto prod = new Producto();
                prod.CodProducto = txtCodigo.Text;
                prod.Categoria = txtCategoria.Text;
                prod.Color = txtDescripcion.Text;
                prod.Descripcion = txtDescripcion.Text;
                prod.Precio = Convert.ToInt32(txtPrecio.Text);

                MessageBox.Show("Codigo: " + prod.CodProducto + Environment.NewLine +
                    "Categoria: " + prod.Categoria + Environment.NewLine +
                    "Color: " + prod.Color + Environment.NewLine +
                    "Descripcion: " + prod.Descripcion + Environment.NewLine +
                    "Precio: " + prod.Precio, "Producto Agregado", MessageBoxButton.OK, MessageBoxImage.Information);
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
