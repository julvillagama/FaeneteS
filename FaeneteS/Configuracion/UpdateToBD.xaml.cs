﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FaeneteS
{
    /// <summary>
    /// Lógica de interacción para UpdateToBD.xaml
    /// </summary>
    public partial class UpdateToBD : WindowBase
    {
        public String texto { get; set; }

        public UpdateToBD(String name, String trabajador):base()
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
