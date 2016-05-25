using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FaeneteS.Correo
{
    /// <summary>
    /// Lógica de interacción para EditCorreo.xaml
    /// </summary>
    public partial class EditCorreo : WindowBase
    {
        private String fecha, remite, contenido, destino, empleado, estado;
        private Boolean entrada, salida, certificado, finalizado;
        private int _id;

        public EditCorreo(int _id, String fecha, bool entrada, bool salida, Boolean certificado, String remite, String contenido, String destino, String empleado, String estado, Boolean finalizado):base()
        {
            InitializeComponent();
            this._id = _id;
            datePicker.Text = fecha;
            rbEntrada.IsChecked = entrada;
            rbSalida.IsChecked = salida;
            checkBoxCertificado.IsChecked = certificado;
            txtRemite.Text = remite;
            txtContenido.Text = contenido;
            txtDestino.Text = destino;
            txtEmpleado.Text = empleado;
            txtEstado.Text = estado;
            checkBoxFinalizado.IsChecked = finalizado;
        }

        private void txtRemite_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtContenido_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtDestino_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtEmpleado_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtEstado_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtRemite_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtRemite.Text);
        }

        private void txtContenido_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtContenido.Text);
        }

        private void txtDestino_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtDestino.Text);
        }

        private void txtEmpleado_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtEmpleado.Text);
        }

        private void txtEstado_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtEstado.Text);
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            fecha = DateTime.Parse((string)datePicker.ToString()).ToString("yyyy-MM-dd");
            entrada = rbEntrada.IsChecked.Value;
            salida = rbSalida.IsChecked.Value;
            certificado = checkBoxCertificado.IsChecked.Value;
            remite = txtRemite.Text;
            contenido = txtContenido.Text;
            destino = txtDestino.Text;
            empleado = txtEmpleado.Text;
            estado = txtEstado.Text;
            finalizado = checkBoxFinalizado.IsChecked.Value;

            if (remite != String.Empty && destino != String.Empty && empleado != String.Empty && estado != String.Empty)
            {
                conexion.updateCorreo(_id, fecha, entrada, salida, certificado, remite, contenido, destino, empleado, estado, finalizado);
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

    }
}
