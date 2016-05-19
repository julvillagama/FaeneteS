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
    /// Lógica de interacción para UpdateToBD.xaml
    /// </summary>
    public partial class UpdateToBD : Window
    {
        public String texto { get; set; }

        public UpdateToBD(String name, String trabajador)
        {
            InitializeComponent();
            titulo.Content = titulo.Content.ToString() + " " + name;
            this.txtEdit.Text = trabajador;
            this.texto = " ";
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void btnCANCEL_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void txtEdit_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEdit.Text))
            {
                this.texto = txtEdit.Text.Trim();
            }
            else
            {
                this.texto = " ";
            }
        }

        // VALIDA TEXTO TEXTBOX
        private void txtEdit_PreviewTextInput(object sender, TextCompositionEventArgs e)
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
