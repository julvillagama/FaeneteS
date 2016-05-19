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
    public partial class Informe : Window
    {

        private Conexion conexion = Conexion.Instancia;
        private DataTable datos = new DataTable();

        public Informe()
        {
            InitializeComponent();
        }

        private void btnCloseFormConsulta_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.datos.Clear();
            this.Close();
        }

        private void btnOkFecha_Click(object sender, RoutedEventArgs e)
        {
            this.datos.Clear();
            string a = DateTime.Parse((string)dtDesde.ToString()).ToString("yyyy-MM-dd").ToString();
            string b = DateTime.Parse((string)dtHasta.ToString()).ToString("yyyy-MM-dd").ToString();
            this.datos = conexion.informeCorreo(a, b);
            InformeCorreos informeCorreos = new InformeCorreos(datos);

            // Y lo mostramos
            informeCorreos.Show();
        }
    }
}
