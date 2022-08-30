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
using ClaseBase;
namespace Vistas
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public string usuario { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string usuarioAdmin = "admin";
            string passAdmin = "123";
            string usuarioVendedor = "vendedor";
            string passVendedor = "456";

            Main main = new Main();
            if ((textBox1.Text == usuarioAdmin) && (passwordBox1.Password == passAdmin))
            {
                MessageBox.Show("Bienvenido", "Muebleria LPOO", MessageBoxButton.OK, MessageBoxImage.Information);
                main.Usuario = usuarioAdmin;
                main.Show();
            }
            else if ((textBox1.Text == usuarioVendedor) && (passwordBox1.Password == passVendedor))
            {
                MessageBox.Show("Bienvenido", "Muebleria LPOO", MessageBoxButton.OK, MessageBoxImage.Information);
                main.Usuario = usuarioVendedor;
                main.Show();
            }
            else {
                MessageBox.Show("Usuario y/o contraseña incorrecto.", "Atención", MessageBoxButton.OK, MessageBoxImage.Information);
                textBox1.Text = string.Empty;
                passwordBox1.Password = "";
            }

            
        }


      
    }
}
