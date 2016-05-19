using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FaeneteS
{
    /// <summary>
    /// Lógica de interacción para AddToBD.xaml
    /// </summary>
    public partial class AddToBD : Window
    {
        public String texto { get; set; }

        public AddToBD(String name)
        {
            InitializeComponent();
            titulo.Content = titulo.Content.ToString() + " " + name;
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

        private void txtAdd_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAdd.Text))
                {
                    this.texto = txtAdd.Text.Trim();
                }
            else
                {
                this.texto = " ";
                }
        }

        // VALIDA TEXTO TEXTBOX
        private void txtAdd_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

