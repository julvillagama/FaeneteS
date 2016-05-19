using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FaeneteS.Quejas
{
    /// <summary>
    /// Lógica de interacción para AddQueja.xaml
    /// </summary>
    public partial class AddQueja : Window
    {

        private Conexion conexion = Conexion.Instancia;
        private String fecha, nombre, queja, registro, resolucion;

        public AddQueja()
        {
            InitializeComponent();
            foreach (String via in conexion.listadoRegistros()) // Loop llena listBoxRegistros
            {
                cbRegistros.Items.Add(via);
            }
            cbRegistros.SelectedIndex = 0;
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtNombre.Text);
        }

        private void txtNombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtQueja_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtQueja_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtQueja.Text);
        }

        private void txtResolucion_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtResolucion.Text);
        }

        private void txtResolucion_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
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
            if(nombre != String.Empty && queja != String.Empty && registro != String.Empty && resolucion != String.Empty)
            {
                conexion.addQueja(fecha, nombre, queja, registro, resolucion);
            }  
            DialogResult = false;
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
    }
}
