﻿using System;
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
    /// Lógica de interacción para Llamadas.xaml
    /// </summary>
    public partial class Llamadas : WindowBase
    {
        private int itemSeleccionado = 0;
        private int filtro = 0;

        public Llamadas():base()
        {
            InitializeComponent();
            this.datos.Clear();
            this.datos = conexion.llamadas();
            dataGrid.ItemsSource = datos.DefaultView;
            dataGrid.SelectedIndex = itemSeleccionado;
        }

        private void btnAddLlamada_Click(object sender, RoutedEventArgs e)
        {
            AddLlamada formAnadir = new AddLlamada();
            formAnadir.ShowDialog();
            bool? resultado = formAnadir.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    txtBuscar.Text = "";
                    this.datos.Clear();
                    this.datos = conexion.llamadas();
                    dataGrid.ItemsSource = datos.DefaultView;
                    (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
                    dataGrid.SelectedIndex = conexion.idLlamada();
                }
            }
        }

        private void btnDeleteLlamada_Click(object sender, RoutedEventArgs e)
        {
            itemSeleccionado = dataGrid.SelectedIndex;
            DataRowView dataRow = (DataRowView)dataGrid.SelectedItem;
            string _id = dataRow.Row.ItemArray[0].ToString();
            conexion.deleteLlamada(Convert.ToInt32(_id));
            this.datos.Clear();
            this.datos = conexion.llamadas();
            dataGrid.ItemsSource = datos.DefaultView;
            dataGrid.SelectedIndex = itemSeleccionado - 1;
        }

        private void btnEditLlamada_Click(object sender, RoutedEventArgs e)
        {
            itemSeleccionado = dataGrid.SelectedIndex;
            DataRowView dataRow = (DataRowView)dataGrid.SelectedItem;
            int _id = Convert.ToInt32(dataRow.Row.ItemArray[0]);
            string fecha = dataRow.Row.ItemArray[1].ToString();
            string nombre = dataRow.Row.ItemArray[2].ToString();
            string consulta = dataRow.Row.ItemArray[3].ToString();
            EditLlamada formEdit = new EditLlamada(_id, fecha, nombre, consulta);
            formEdit.ShowDialog();
            bool? resultado = formEdit.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    this.datos.Clear();
                    this.datos = conexion.llamadas();
                    dataGrid.ItemsSource = datos.DefaultView;
                    dataGrid.SelectedIndex = itemSeleccionado;
                }
            }
        }

        private void rbSinFiltro_Checked(object sender, RoutedEventArgs e)
        {
            if (dataGrid != null && datos != null)
            {
                txtBuscar.Text = "";
                filtro = 0;
                this.datos.Clear();
                this.datos = conexion.llamadas();
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
            this.datos = conexion.llamadas();
            dataGrid.ItemsSource = datos.DefaultView;
            (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
            dataGrid.SelectedIndex = itemSeleccionado;
            Filtro_Fecha(true);
        }

        private void rbNombre_Checked(object sender, RoutedEventArgs e)
        {
            txtBuscar.Text = "";
            filtro = 2;
            this.datos.Clear();
            this.datos = conexion.llamadas();
            dataGrid.ItemsSource = datos.DefaultView;
            (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
            dataGrid.SelectedIndex = itemSeleccionado;
            Filtro_Fecha(false);
        }

        private void rbConsulta_Checked(object sender, RoutedEventArgs e)
        {
            txtBuscar.Text = "";
            filtro = 3;
            this.datos.Clear();
            this.datos = conexion.llamadas();
            dataGrid.ItemsSource = datos.DefaultView;
            (dataGrid.ItemsSource as DataView).Sort = "_id DESC";
            dataGrid.SelectedIndex = itemSeleccionado;
            Filtro_Fecha(false);
        }

        private void btnOkFecha_Click(object sender, RoutedEventArgs e)
        {
            this.datos.Clear();
            string a = DateTime.Parse((string)dtDesde.ToString()).ToString("yyyy-MM-dd").ToString();
            string b = DateTime.Parse((string)dtHasta.ToString()).ToString("yyyy-MM-dd").ToString();
            this.datos = conexion.FechasLlamadas(a, b);
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

        private void btnCloseFormLlamada_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.datos.Clear();
            this.Close();
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
    }
}
