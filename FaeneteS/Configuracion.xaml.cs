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
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        // Instancia ventana inicio
        private MainWindow frmInicio;

        private DataBase baseDatos;
        private DataSet dataset;

        public Configuracion(MainWindow frmInicio)
        {
            InitializeComponent();
            this.frmInicio = frmInicio;
            baseDatos = new DataBase();
            dataset = new DataSet();
            cargarListBoxConfiguracion();
        }

        private void cargarListBoxConfiguracion()
        {
            baseDatos.conectarBD();
            dataset = baseDatos.tablaConfiguracion();
            baseDatos.desconectarBD();
            
                foreach (DataRow row in dataset.Tables[0].Rows)
                {

                    if (row["registro"].ToString() != string.Empty)
                    {
                        listBoxRegistros.Items.Add(row["registro"].ToString());  
                    }

                    if (row["trabajador"].ToString() != string.Empty)
                    {
                        listBoxTrabajadores.Items.Add(row["trabajador"].ToString());
                    }

                    if (row["via"].ToString() != string.Empty)
                    {
                        listBoxVias.Items.Add(row["via"].ToString());
                    }

                    if (row["preparador"].ToString() != string.Empty)
                    {
                        listBoxPreparadores.Items.Add(row["preparador"].ToString());
                    }
                } // end foreach     
        } // end cargarListBoxConfiguracion

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
