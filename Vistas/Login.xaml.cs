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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        public string Usuario { get; set; }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuarioAdmin = "admin";
            string passAdmin = "123";
            string usuarioVendedor = "vendedor";
            string passVendedor = "456";

            Menu menu = new Menu();

            if ((txtUser.Text == usuarioAdmin) && (txtpassword.Password == passAdmin))
            {
                MessageBox.Show("Bienvenido", "Muebleria LPOO", MessageBoxButton.OK, MessageBoxImage.Information);
                menu.Usuario = usuarioAdmin;
                this.Hide();
                menu.Show();
            }
            else if ((txtUser.Text == usuarioVendedor) && (txtpassword.Password == passVendedor))
            {
                MessageBox.Show("Bienvenido", "Muebleria LPOO", MessageBoxButton.OK, MessageBoxImage.Information);
                menu.Usuario = usuarioVendedor;
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto.", "Atención", MessageBoxButton.OK, MessageBoxImage.Information);
                txtUser.Text = string.Empty;
                txtpassword.Password = "";
            }
        }


        //(prop y tabulador)
        //ctrl k y d para acomodar la pantalla

    }
}
