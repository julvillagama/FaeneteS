using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para AddActo.xaml
    /// </summary>
    public partial class AddActo : Window
    {

        private Conexion conexion = Conexion.Instancia;
        private String fecha, acto, lugar, empresa, menu, precio, notas;

        public AddActo()
        {
            InitializeComponent();
        }

        private void txtActo_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtActo.Text);
        }

        private void txtLugar_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtLugar.Text);
        }

        private void txtEmpresa_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtEmpresa.Text);
        }

        private void txtMenu_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtMenu.Text);
        }

        private void txtPrecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtPrecio.Text);
        }

        private void txtNotas_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtNotas.Text);
        }

        private void txtActo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtLugar_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtEmpresa_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtMenu_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtPrecio_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {    
            char letra = Convert.ToChar(e.Text);
            if (letra == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecio.Text.Length; i++)
            {
                if (txtPrecio.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }

            }

            if (letra >= 48 && letra <= 57)
                e.Handled = false;
            else if (letra == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;         
        }

        private void txtNotas_PreviewTextInput(object sender, TextCompositionEventArgs e)
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
            acto = txtActo.Text;
            lugar = txtLugar.Text;
            empresa = txtEmpresa.Text;
            menu = txtMenu.Text;
            precio = txtPrecio.Text;
            notas = txtNotas.Text;

            if (acto != String.Empty && lugar != String.Empty && empresa != String.Empty && menu != String.Empty && precio != String.Empty && notas != String.Empty)
            {
                conexion.addActo(fecha, acto, lugar, empresa, menu, precio, notas);
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
