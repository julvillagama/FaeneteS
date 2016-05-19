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
    /// Lógica de interacción para ConsultasRecibidas.xaml
    /// </summary>
    public partial class ConsultasRecibidas : Window
    {
        private Conexion conexion = Conexion.Instancia;
        private DataTable datos = new DataTable();
        private int itemSeleccionado = 0;

        public ConsultasRecibidas()
        {
            InitializeComponent();
            this.datos = conexion.consultasRecibidas();
            dataGrid.ItemsSource = datos.DefaultView;
            dataGrid.SelectedIndex = itemSeleccionado;
        }

        private void btnCloseFormConsulta_Click(object sender, RoutedEventArgs e)
        {
            this.datos.Clear();
            DialogResult = false;
            this.Close();
        }

        private void btnAddConsulta_Click(object sender, RoutedEventArgs e)
        {
            itemSeleccionado = dataGrid.SelectedIndex;
            AddConsulta formAnadir = new AddConsulta();
            formAnadir.ShowDialog();
            bool? resultado = formAnadir.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    this.datos.Clear();
                    this.datos = conexion.consultasRecibidas();
                    dataGrid.ItemsSource = datos.DefaultView;
                    dataGrid.SelectedIndex = itemSeleccionado;
                }
            }
        }

        private void btnDeleteConsulta_Click(object sender, RoutedEventArgs e)
        {
            itemSeleccionado = dataGrid.SelectedIndex;
            DataRowView dataRow = (DataRowView)dataGrid.SelectedItem;
            string _id = dataRow.Row.ItemArray[0].ToString(); 
            conexion.deleteConsulta(Convert.ToInt32(_id));
            this.datos.Clear();
            this.datos = conexion.consultasRecibidas();
            dataGrid.ItemsSource = datos.DefaultView;
            dataGrid.SelectedIndex = itemSeleccionado - 1;
        }
    }
}
