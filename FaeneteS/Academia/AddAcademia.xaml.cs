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
    /// Lógica de interacción para AddAcademia.xaml
    /// </summary>
    public partial class AddAcademia : WindowBase
    {

        private Conexion conexion = Conexion.Instancia;
        private String fecha, preparador, opositor, material;

        public AddAcademia():base()
        {
            InitializeComponent();
            foreach (String preparador in conexion.listadoPreparadores()) // Loop llena listBoxPreparadores
            {
                cbPreparador.Items.Add(preparador);
            }
            cbPreparador.SelectedIndex = 0;
        }

        private void txtOpositor_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtMaterial_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validar(e);
        }

        private void txtOpositor_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtOpositor.Text);
        }

        private void txtMaterial_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpiarTexto(txtMaterial.Text);
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            fecha = DateTime.Parse((string)datePicker.ToString()).ToString("yyyy-MM-dd");
            preparador = cbPreparador.Text;
            opositor = txtOpositor.Text;
            material = txtMaterial.Text;
            if (preparador != String.Empty && opositor != String.Empty && material != String.Empty)
            {
                conexion.addAcademia(fecha, preparador, opositor, material);
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
