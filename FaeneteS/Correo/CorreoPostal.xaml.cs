using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FaeneteS.Correo
{
    /// <summary>
    /// Lógica de interacción para CorreoPostal.xaml
    /// </summary>
    public partial class CorreoPostal : WindowBase
    {
        private int itemSeleccionado = 0;
        private int filtro = 0;
        private Boolean entrada;

        public CorreoPostal():base()
        {
            InitializeComponent();
            this.datos.Clear();
            this.datos = conexion.correoPostal();
            dataGrid.ItemsSource = datos.DefaultView;
            dataGrid.SelectedIndex = itemSeleccionado;
        }

        private void btnAddCorreo_Click(object sender, RoutedEventArgs e)
        {
            AddCorreo formAnadir = new AddCorreo();
            formAnadir.ShowDialog();
            bool? resultado = formAnadir.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    txtBuscar.Text = "";
                    this.datos.Clear();
                    this.datos = conexion.correoPostal();
                    dataGrid.ItemsSource = datos.DefaultView;
                    (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
                    dataGrid.SelectedIndex = conexion.idCorreo();
                }
            }
        }

        private void btnDeleteCorreo_Click(object sender, RoutedEventArgs e)
        {
            itemSeleccionado = dataGrid.SelectedIndex;
            DataRowView dataRow = (DataRowView)dataGrid.SelectedItem;
            string _id = dataRow.Row.ItemArray[0].ToString();
            conexion.deleteCorreo(Convert.ToInt32(_id));
            this.datos.Clear();
            this.datos = conexion.correoPostal();
            dataGrid.ItemsSource = datos.DefaultView;
            dataGrid.SelectedIndex = itemSeleccionado - 1;
        }

        private void btnEditCorreo_Click(object sender, RoutedEventArgs e)
        {
            itemSeleccionado = dataGrid.SelectedIndex;
            DataRowView dataRow = (DataRowView)dataGrid.SelectedItem;
            int _id = Convert.ToInt32(dataRow.Row.ItemArray[0]);
            string fecha = dataRow.Row.ItemArray[1].ToString();
            if(dataRow.Row.ItemArray[2] != null)
            {
                entrada = Convert.ToBoolean(dataRow.Row.ItemArray[2]);
            }
            
            Boolean salida = Convert.ToBoolean(dataRow.Row.ItemArray[3]);
            Boolean certificado = Convert.ToBoolean(dataRow.Row.ItemArray[4]);
            string remite = dataRow.Row.ItemArray[5].ToString();
            string contenido = dataRow.Row.ItemArray[6].ToString();
            string destino = dataRow.Row.ItemArray[7].ToString();
            string empleado = dataRow.Row.ItemArray[8].ToString();
            string estado = dataRow.Row.ItemArray[9].ToString();
            Boolean finalizado = Convert.ToBoolean(dataRow.Row.ItemArray[10]);
            EditCorreo formEdit = new EditCorreo(_id, fecha, entrada, salida, certificado, remite, contenido, destino, empleado, estado, finalizado);
            formEdit.ShowDialog();
            bool? resultado = formEdit.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    this.datos.Clear();
                    this.datos = conexion.correoPostal();
                    dataGrid.ItemsSource = datos.DefaultView;
                    dataGrid.SelectedIndex = itemSeleccionado;
                }
            }
       
            
        }

        private void btnCloseFormCorreo_Click(object sender, RoutedEventArgs e)
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
            this.datos = conexion.FechasCorreo(a, b);
            dataGrid.ItemsSource = datos.DefaultView;
        }

        private void txtBuscar_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char letra = Convert.ToChar(e.Text);
            if ((letra >= 65 && letra <= 90) || (letra >= 97 && letra <= 122)
                                    || letra == 'ñ' || letra == 'Ñ'
                                    || letra == 'á' || letra == 'Á'
                                    || letra == 'é' || letra == 'É'
                                    || letra == 'í' || letra == 'Í'
                                    || letra == 'ó' || letra == 'Ó'
                                    || letra == 'ú' || letra == 'Ú')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            string fieldName = string.Concat("[", datos.Columns[filtro].ColumnName, "]");
            datos.DefaultView.Sort = fieldName;
            DataView view = datos.DefaultView;
            view.RowFilter = string.Empty;
            if (txtBuscar.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + txtBuscar.Text + "%'";
            dataGrid.DataContext = view;
        }

        private void rbSinFiltro_Checked(object sender, RoutedEventArgs e)
        {
            if (dataGrid != null && datos != null)
            {
                txtBuscar.Text = "";
                filtro = 0;
                this.datos.Clear();
                this.datos = conexion.correoPostal();
                dataGrid.ItemsSource = datos.DefaultView;
                (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
                dataGrid.SelectedIndex = itemSeleccionado;
            }

            if (lblDesde != null && dtDesde != null && lblHasta != null && dtHasta != null && btnOkFecha != null && lblTextoBuscar != null && txtBuscar != null)
            {
                lblDesde.IsEnabled = false;
                dtDesde.IsEnabled = false;
                lblHasta.IsEnabled = false;
                dtHasta.IsEnabled = false;
                btnOkFecha.IsEnabled = false;
                lblTextoBuscar.IsEnabled = false;
                txtBuscar.Text = "";
                txtBuscar.IsEnabled = false;
            }
        }

        private void rbFecha_Checked(object sender, RoutedEventArgs e)
        {
            txtBuscar.Text = "";
            filtro = 0;
            this.datos.Clear();
            this.datos = conexion.correoPostal();
            dataGrid.ItemsSource = datos.DefaultView;
            (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
            dataGrid.SelectedIndex = itemSeleccionado;
            Filtro_Fecha(true);
        }

        private void rbRemite_Checked(object sender, RoutedEventArgs e)
        {
            txtBuscar.Text = "";
            filtro = 5;
            this.datos.Clear();
            this.datos = conexion.correoPostal();
            dataGrid.ItemsSource = datos.DefaultView;
            (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
            dataGrid.SelectedIndex = itemSeleccionado;
            Filtro_Fecha(false);
        }

        private void rbContenido_Checked(object sender, RoutedEventArgs e)
        {
            txtBuscar.Text = "";
            filtro = 6;
            this.datos.Clear();
            this.datos = conexion.correoPostal();
            dataGrid.ItemsSource = datos.DefaultView;
            (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
            dataGrid.SelectedIndex = itemSeleccionado;
            Filtro_Fecha(false);
        }

        private void rbDestino_Checked(object sender, RoutedEventArgs e)
        {
            txtBuscar.Text = "";
            filtro = 7;
            this.datos.Clear();
            this.datos = conexion.correoPostal();
            dataGrid.ItemsSource = datos.DefaultView;
            (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
            dataGrid.SelectedIndex = itemSeleccionado;
            Filtro_Fecha(false);
        }

        private void rbEmpleado_Checked(object sender, RoutedEventArgs e)
        {
            txtBuscar.Text = "";
            filtro = 8;
            this.datos.Clear();
            this.datos = conexion.correoPostal();
            dataGrid.ItemsSource = datos.DefaultView;
            (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
            dataGrid.SelectedIndex = itemSeleccionado;
            Filtro_Fecha(false);
        }

        private void rbEstado_Checked(object sender, RoutedEventArgs e)
        {
            txtBuscar.Text = "";
            filtro = 9;
            this.datos.Clear();
            this.datos = conexion.correoPostal();
            dataGrid.ItemsSource = datos.DefaultView;
            (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
            dataGrid.SelectedIndex = itemSeleccionado;
            Filtro_Fecha(false);
        }

        private void Filtro_Fecha(Boolean bandera)
        {
            if (bandera)
            {
                lblDesde.IsEnabled = true;
                dtDesde.IsEnabled = true;
                lblHasta.IsEnabled = true;
                dtHasta.IsEnabled = true;
                btnOkFecha.IsEnabled = true;
                lblTextoBuscar.IsEnabled = false;
                txtBuscar.IsEnabled = false;
            }
            else
            {
                lblDesde.IsEnabled = false;
                dtDesde.IsEnabled = false;
                lblHasta.IsEnabled = false;
                dtHasta.IsEnabled = false;
                btnOkFecha.IsEnabled = false;
                lblTextoBuscar.IsEnabled = true;
                txtBuscar.Text = "";
                txtBuscar.IsEnabled = true;

            }
        }

        private void rbEntradas_Checked(object sender, RoutedEventArgs e)
        {
            if (dataGrid != null && datos != null)
            {
                txtBuscar.Text = "";
                filtro = 0;
                this.datos.Clear();
                this.datos = conexion.correoPostalverEntradas();
                dataGrid.ItemsSource = datos.DefaultView;
                (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
                dataGrid.SelectedIndex = itemSeleccionado;
            }

            if (lblDesde != null && dtDesde != null && lblHasta != null && dtHasta != null && btnOkFecha != null && lblTextoBuscar != null && txtBuscar != null)
            {
                lblDesde.IsEnabled = false;
                dtDesde.IsEnabled = false;
                lblHasta.IsEnabled = false;
                dtHasta.IsEnabled = false;
                btnOkFecha.IsEnabled = false;
                lblTextoBuscar.IsEnabled = false;
                txtBuscar.Text = "";
                txtBuscar.IsEnabled = false;
            }
        }

        private void rbSalidas_Checked(object sender, RoutedEventArgs e)
        {
            if (dataGrid != null && datos != null)
            {
                txtBuscar.Text = "";
                filtro = 0;
                this.datos.Clear();
                this.datos = conexion.correoPostalverSalidas();
                dataGrid.ItemsSource = datos.DefaultView;
                (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
                dataGrid.SelectedIndex = itemSeleccionado;
            }

            if (lblDesde != null && dtDesde != null && lblHasta != null && dtHasta != null && btnOkFecha != null && lblTextoBuscar != null && txtBuscar != null)
            {
                lblDesde.IsEnabled = false;
                dtDesde.IsEnabled = false;
                lblHasta.IsEnabled = false;
                dtHasta.IsEnabled = false;
                btnOkFecha.IsEnabled = false;
                lblTextoBuscar.IsEnabled = false;
                txtBuscar.Text = "";
                txtBuscar.IsEnabled = false;
            }
        }

        private void rbPendientes_Checked(object sender, RoutedEventArgs e)
        {
            if (dataGrid != null && datos != null)
            {
                txtBuscar.Text = "";
                filtro = 0;
                this.datos.Clear();
                this.datos = conexion.correoPostalverPendientes();
                dataGrid.ItemsSource = datos.DefaultView;
                (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
                dataGrid.SelectedIndex = itemSeleccionado;
            }

            if (lblDesde != null && dtDesde != null && lblHasta != null && dtHasta != null && btnOkFecha != null && lblTextoBuscar != null && txtBuscar != null)
            {
                lblDesde.IsEnabled = false;
                dtDesde.IsEnabled = false;
                lblHasta.IsEnabled = false;
                dtHasta.IsEnabled = false;
                btnOkFecha.IsEnabled = false;
                lblTextoBuscar.IsEnabled = false;
                txtBuscar.Text = "";
                txtBuscar.IsEnabled = false;
            }
        }

        private void rbFinalizados_Checked(object sender, RoutedEventArgs e)
        {
            if (dataGrid != null && datos != null)
            {
                txtBuscar.Text = "";
                filtro = 0;
                this.datos.Clear();
                this.datos = conexion.correoPostalverFinalizados();
                dataGrid.ItemsSource = datos.DefaultView;
                (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
                dataGrid.SelectedIndex = itemSeleccionado;
            }

            if (lblDesde != null && dtDesde != null && lblHasta != null && dtHasta != null && btnOkFecha != null && lblTextoBuscar != null && txtBuscar != null)
            {
                lblDesde.IsEnabled = false;
                dtDesde.IsEnabled = false;
                lblHasta.IsEnabled = false;
                dtHasta.IsEnabled = false;
                btnOkFecha.IsEnabled = false;
                lblTextoBuscar.IsEnabled = false;
                txtBuscar.Text = "";
                txtBuscar.IsEnabled = false;
            }
        }
    }
}
