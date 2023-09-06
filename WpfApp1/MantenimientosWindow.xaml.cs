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
using WpfApp1;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MantenimientosWindow.xaml
    /// </summary>
    public partial class MantenimientosWindow : Window
    {
        public MantenimientosWindow()
        {
            InitializeComponent();
        }
        private void GuardarConductor_Click(object sender, RoutedEventArgs e)
        {
            string nombreConductor = NombreConductorTextBox.Text;
            string licencia = LicenciaTextBox.Text;
            string transporte = TransporteTextBox.Text;

            // Realizar la lógica de registro aquí, como guardar los datos en una base de datos.

            // Puedes mostrar un mensaje de éxito o realizar otras acciones después del registro.
        }
    }
}
