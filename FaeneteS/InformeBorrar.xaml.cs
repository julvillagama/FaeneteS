using System;
using System.Collections.Generic;
using System.Data;
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

namespace FaeneteS
{
    /// <summary>
    /// Lógica de interacción para Informe.xaml
    /// </summary>
    public partial class InformeCorreos : Window
    {

        private Conexion conexion = Conexion.Instancia;
        private DataTable datos = new DataTable();

        public InformeCorreos()
        {
            InitializeComponent();
            cargarDataSetCorreos();
        }

        private void btnCorreos_Click(object sender, RoutedEventArgs e)
        {
            cargarDataSetCorreos();
        }

        private void btnConsultas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnQuejas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLlamadas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cargarDataSetCorreos()
        {
            this.datos.Clear();
            this.datos = conexion.correoPostal();
        }

        private void btnCloseFormConsulta_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ReportCorreo informe = new ReportCorreo(datos);
            informe.Show();
        }
    }
}
