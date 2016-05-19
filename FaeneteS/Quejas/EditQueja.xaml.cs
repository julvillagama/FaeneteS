using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FaeneteS.Quejas
{
    /// <summary>
    /// Lógica de interacción para EditQueja.xaml
    /// </summary>
    public partial class EditQueja : Window
    {

        private Conexion conexion = Conexion.Instancia;
        private String fecha, nombre, queja, registro, resolucion;
        private int _id;

        public EditQueja(int _id, String fecha, String nombre, String queja, String registro, String resolucion)
        {
            InitializeComponent();
            this._id = _id;
            datePicker.Text = fecha;
            txtNombre.Text = nombre;
            txtQueja.Text = queja;
            foreach (String vias in conexion.listadoRegistros()) // Loop llena listBoxRegistros
            {
                cbRegistros.Items.Add(vias);
            }
            cbRegistros.SelectedIndex = 0;
            txtResolucion.Text = resolucion;
        }

        private void validar(TextCompositionEventArgs e)
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

        private void limpiarTexto(String texto)
        {
            if (!string.IsNullOrWhiteSpace(texto))
            {
                texto = texto.Trim();
            }
            else
            {
                texto = " ";
            }
        }


        private void txtNombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtQueja_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtResolucion_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtNombre.Text);
        }

        private void txtQueja_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtQueja.Text);
        }

        private void txtResolucion_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtResolucion.Text);
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            fecha = DateTime.Parse((string)datePicker.ToString()).ToString("yyyy-MM-dd");
            nombre = txtNombre.Text;
            queja = txtQueja.Text;
            registro = cbRegistros.Text;
            resolucion = txtResolucion.Text;
            if (nombre != String.Empty && queja != String.Empty && registro != String.Empty && resolucion != String.Empty)
            {
                conexion.updateQueja(_id, fecha, nombre, queja, registro, resolucion);
            }
            DialogResult = false;
        }
    }
}
