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

namespace FaeneteS
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        // Instancia ventana inicio
        private MainWindow frmInicio;

        public Configuracion(MainWindow frmInicio)
        {
            InitializeComponent();
            this.frmInicio = frmInicio;
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Seguro que quiere salir de Configuración?", "Diálogo de confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {  
                ((MainWindow)frmInicio).mostrarInicio();
            }
        }
    }
}
