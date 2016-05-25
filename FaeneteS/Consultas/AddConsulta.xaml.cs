using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FaeneteS
{
    /// <summary>
    /// Lógica de interacción para AddConsulta.xaml
    /// </summary>
    public partial class AddConsulta : WindowBase
    {

        private String fecha, nombre, consulta, via, respuesta;

        public AddConsulta():base()
        {
            InitializeComponent();
            foreach (String via in conexion.listadoVias()) // Loop llena listBoxVias
            {
                cbVia.Items.Add(via);
            }
            cbVia.SelectedIndex = 0;
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
            consulta = txtConsulta.Text;
            via = cbVia.Text;
            respuesta = txtRespuesta.Text;
            if (nombre != String.Empty && consulta != String.Empty && via != String.Empty && respuesta != String.Empty)
            {
                conexion.addConsulta(fecha, nombre, consulta, via, respuesta);
            }
            
            DialogResult = false;
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

        private void txtConsulta_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtRespuesta_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtNombre.Text);
        }

        private void txtConsulta_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtConsulta.Text);
        }

        private void txtRespuesta_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtRespuesta.Text);
        }
    }
}
