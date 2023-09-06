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
    /// Lógica de interacción para DataWindow.xaml
    /// </summary>
    public partial class DataWindow : Window
    {
        public DataWindow()
        {
            InitializeComponent();
        }

        private void OperacionesButton_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de Operaciones (reemplaza "OperacionesWindow" con el nombre de tu ventana).
            OperacionesWindow operacionesWindow = new OperacionesWindow();
            operacionesWindow.Show();
        }

        private void MantenimientosButton_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de Mantenimientos (reemplaza "MantenimientosWindow" con el nombre de tu ventana).
            MantenimientosWindow mantenimientosWindow = new MantenimientosWindow();
            mantenimientosWindow.Show();
        }

        private void ReportesButton_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de Reportes (reemplaza "ReportesWindow" con el nombre de tu ventana).
            ReportesWindow reportesWindow = new ReportesWindow();
            reportesWindow.Show();
        }

        private void RegresarButton_Click(object sender, RoutedEventArgs e)
        {
            // Cierra la ventana actual (DataWindow) para regresar al menú principal.
            Close();
        }
    }
}
