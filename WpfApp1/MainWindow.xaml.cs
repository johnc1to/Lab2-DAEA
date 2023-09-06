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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Realiza la lógica de autenticación aquí (por ejemplo, verificación de credenciales en una base de datos).
            // Si la autenticación es exitosa, puedes abrir la ventana de trabajo con datos.
            if (Autenticar(username, password))
            {
                DataWindow dataWindow = new DataWindow();
                dataWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private bool Autenticar(string username, string password)
        {
            // Implementa la lógica de autenticación aquí (por ejemplo, verifica en una base de datos o servicios de autenticación).
            // Devuelve true si la autenticación es exitosa, de lo contrario, devuelve false.
            // Aquí, se muestra un ejemplo simple:
            return username == "john" && password == "123";
        }
    }
}
