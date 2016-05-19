using System;
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
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        private Conexion conexion = Conexion.Instancia;
        private String textoAdd = " ";
        private String textoUpdate = " ";
        private String textoDelete = " ";

        public Configuracion()
        {
            InitializeComponent();
            MenuRegistros.IsChecked = true;
        }
        
        // LOAD FORMULARIO
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Pantalla Registros
            lblRegistros.Content = "Hay " + conexion.numeroDeRegistros() + " registros";
            foreach (String registro in conexion.listadoRegistros()) // Loop llena listBoxRegistros
            {
                listBoxRegistros.Items.Add(registro);
            }
            listBoxRegistros.SelectedIndex = 0;
            // Pantalla Trabajadores
            lblTrabajadores.Content = "Hay " + conexion.numeroDeTrabajadores() + " trabajadores";
            foreach (String trabajador in conexion.listadoTrabajadores()) // Loop llena listBoxTrabajadores
            {
                listBoxTrabajadores.Items.Add(trabajador);
            }
            listBoxTrabajadores.SelectedIndex = 0;
            // Pantalla Vías
            lblVias.Content = "Hay " + conexion.numeroDeVias() + " tipos de vía";
            foreach (String via in conexion.listadoVias()) // Loop llena listBoxVias
            {
                listBoxVias.Items.Add(via);
            }
            listBoxVias.SelectedIndex = 0;
            // Pantalla Preparadores
            lblPreparadores.Content = "Hay " + conexion.numeroDePreparadores() + " preparadores";
            foreach (String preparador in conexion.listadoPreparadores()) // Loop llena listBoxPreparadores
            {
                listBoxPreparadores.Items.Add(preparador);
            }
            listBoxPreparadores.SelectedIndex = 0;
        }
        
// MENUS #############################################################################################################
        // MENU REGISTROS
        private void MenuRegistros_Click(object sender, RoutedEventArgs e)
        {
            MenuRegistros.IsChecked = true;
            MenuTrabajadores.IsChecked = false;
            MenuVias.IsChecked = false;
            MenuPreparadores.IsChecked = false;
            PanelRegistros.Visibility = Visibility.Visible;
            PanelTrabajadores.Visibility = Visibility.Hidden;
            PanelVias.Visibility = Visibility.Hidden;
            PanelPreparadores.Visibility = Visibility.Hidden;
        }

        // MENU TRABAJADORES
        private void MenuTrabajadores_Click(object sender, RoutedEventArgs e)
        {
            MenuRegistros.IsChecked = false;
            MenuTrabajadores.IsChecked = true;
            MenuVias.IsChecked = false;
            MenuPreparadores.IsChecked = false;
            PanelRegistros.Visibility = Visibility.Hidden;
            PanelTrabajadores.Visibility = Visibility.Visible;
            PanelVias.Visibility = Visibility.Hidden;
            PanelPreparadores.Visibility = Visibility.Hidden;
        }

        // MENU VIAS
        private void MenuVias_Click(object sender, RoutedEventArgs e)
        {
            MenuRegistros.IsChecked = false;
            MenuTrabajadores.IsChecked = false;
            MenuVias.IsChecked = true;
            MenuPreparadores.IsChecked = false;
            PanelRegistros.Visibility = Visibility.Hidden;
            PanelTrabajadores.Visibility = Visibility.Hidden;
            PanelVias.Visibility = Visibility.Visible;
            PanelPreparadores.Visibility = Visibility.Hidden;
        }

        // MENU PREPARADORES
        private void MenuPreparadores_Click(object sender, RoutedEventArgs e)
        {
            MenuRegistros.IsChecked = false;
            MenuTrabajadores.IsChecked = false;
            MenuVias.IsChecked = false;
            MenuPreparadores.IsChecked = true;
            PanelRegistros.Visibility = Visibility.Hidden;
            PanelTrabajadores.Visibility = Visibility.Hidden;
            PanelVias.Visibility = Visibility.Hidden;
            PanelPreparadores.Visibility = Visibility.Visible;
        }

        // MENU SALIR DEL FORMULARIO
        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
// FINAL MENUS #######################################################################################################

// BOTONES AÑADIR ####################################################################################################
        private void btnAddRegistros_Click(object sender, RoutedEventArgs e)
        {
            AddToBD formAnadir  = new AddToBD("Registro");
            formAnadir.ShowDialog();
            bool? resultado = formAnadir.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formAnadir.texto != " ")
                    {
                        textoAdd = formAnadir.texto;

                        conexion.addRegistro(textoAdd);
                        listBoxRegistros.Items.Clear();
                        foreach (String registro in conexion.listadoRegistros()) // Loop llena listBoxRegistros
                        {
                            listBoxRegistros.Items.Add(registro);
                        }
                        listBoxRegistros.SelectedIndex = 0;
                        lblRegistros.Content = "Hay " + conexion.numeroDeRegistros() + " Registros";
                    }

                }
            }
        }

        private void btnAddTrabajadores_Click(object sender, RoutedEventArgs e)
        {
            AddToBD formAnadir = new AddToBD("trabajador");
            formAnadir.ShowDialog();
            bool? resultado = formAnadir.DialogResult;
            if(resultado != null)
            {
                if (resultado == false)
                {
                        if(formAnadir.texto != " ")
                        {
                            textoAdd = formAnadir.texto;

                            conexion.addTrabajador(textoAdd);
                            listBoxTrabajadores.Items.Clear();
                            foreach (String trabajador in conexion.listadoTrabajadores()) // Loop llena listBoxTrabajadores
                            {
                                listBoxTrabajadores.Items.Add(trabajador);
                            }
                            listBoxTrabajadores.SelectedIndex = 0;
                            lblTrabajadores.Content = "Hay " + conexion.numeroDeTrabajadores() + " trabajadores";
                    }
                        
                }   
            }
        }

        private void btnAddVias_Click(object sender, RoutedEventArgs e)
        {
            AddToBD formAnadir = new AddToBD("Via");
            formAnadir.ShowDialog();
            bool? resultado = formAnadir.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formAnadir.texto != " ")
                    {
                        textoAdd = formAnadir.texto;

                        conexion.addVia(textoAdd);
                        listBoxVias.Items.Clear();
                        foreach (String via in conexion.listadoVias()) // Loop llena listBoxVias
                        {
                            listBoxVias.Items.Add(via);
                        }
                        listBoxVias.SelectedIndex = 0;
                        lblVias.Content = "Hay " + conexion.numeroDeVias() + " vias";
                    }

                }
            }
        }

        private void btnAddPreparadores_Click(object sender, RoutedEventArgs e)
        {
            AddToBD formAnadir = new AddToBD("preparador");
            formAnadir.ShowDialog();
            bool? resultado = formAnadir.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formAnadir.texto != " ")
                    {
                        textoAdd = formAnadir.texto;

                        conexion.addPreparador(textoAdd);
                        listBoxPreparadores.Items.Clear();
                        foreach (String preparador in conexion.listadoPreparadores()) // Loop llena listBoxPreparadores
                        {
                            listBoxPreparadores.Items.Add(preparador);
                        }
                        listBoxPreparadores.SelectedIndex = 0;
                        lblPreparadores.Content = "Hay " + conexion.numeroDePreparadores() + " preparadores";
                    }

                }
            }
        }

// BOTONES UPDATE ####################################################################################################
        private void btnUpdateRegistros_Click(object sender, RoutedEventArgs e)
        {
            String editarRegistro = listBoxRegistros.SelectedItem.ToString();
            UpdateToBD formUpdate = new UpdateToBD("Registro", editarRegistro);
            formUpdate.ShowDialog();
            bool? resultado = formUpdate.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formUpdate.texto != " ")
                    {
                        textoUpdate = formUpdate.texto;

                        conexion.updateRegistro(editarRegistro, textoUpdate);
                        listBoxRegistros.Items.Clear();
                        foreach (String registro in conexion.listadoRegistros()) // Loop llena listBoxRegistros
                        {
                            listBoxRegistros.Items.Add(registro);
                        }
                        listBoxRegistros.SelectedIndex = 0;
                        lblRegistros.Content = "Hay " + conexion.numeroDeRegistros() + " Registros";
                    }

                }
            }
        }

        private void btnUpdateTrabajadores_Click(object sender, RoutedEventArgs e)
        {
            String editarTrabajador = listBoxTrabajadores.SelectedItem.ToString();
            UpdateToBD formUpdate = new UpdateToBD("trabajador", editarTrabajador);
            formUpdate.ShowDialog();
            bool? resultado = formUpdate.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formUpdate.texto != " ")
                    {
                        textoUpdate = formUpdate.texto;

                        conexion.updateTrabajador(editarTrabajador, textoUpdate);
                        listBoxTrabajadores.Items.Clear();
                        foreach (String trabajador in conexion.listadoTrabajadores()) // Loop llena listBoxTrabajadores
                        {
                            listBoxTrabajadores.Items.Add(trabajador);
                        }
                        listBoxTrabajadores.SelectedIndex = 0;
                        lblTrabajadores.Content = "Hay " + conexion.numeroDeTrabajadores() + " trabajadores";
                    }

                }
            }
        }

        private void btnUpdateVias_Click(object sender, RoutedEventArgs e)
        {
            String editarVia = listBoxVias.SelectedItem.ToString();
            UpdateToBD formUpdate = new UpdateToBD("Via", editarVia);
            formUpdate.ShowDialog();
            bool? resultado = formUpdate.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formUpdate.texto != " ")
                    {
                        textoUpdate = formUpdate.texto;

                        conexion.updateVia(editarVia, textoUpdate);
                        listBoxVias.Items.Clear();
                        foreach (String via in conexion.listadoVias()) // Loop llena listBoxVias
                        {
                            listBoxVias.Items.Add(via);
                        }
                        listBoxVias.SelectedIndex = 0;
                        lblVias.Content = "Hay " + conexion.numeroDeVias() + " vias";
                    }

                }
            }
        }

        private void btnUpdatePreparadores_Click(object sender, RoutedEventArgs e)
        {
            String editarPreparador = listBoxPreparadores.SelectedItem.ToString();
            UpdateToBD formUpdate = new UpdateToBD("preparador", editarPreparador);
            formUpdate.ShowDialog();
            bool? resultado = formUpdate.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formUpdate.texto != " ")
                    {
                        textoUpdate = formUpdate.texto;

                        conexion.updatePreparador(editarPreparador, textoUpdate);
                        listBoxPreparadores.Items.Clear();
                        foreach (String preparador in conexion.listadoPreparadores()) // Loop llena listBoxPreparadores
                        {
                            listBoxPreparadores.Items.Add(preparador);
                        }
                        listBoxPreparadores.SelectedIndex = 0;
                        lblPreparadores.Content = "Hay " + conexion.numeroDePreparadores() + " preparadores";
                    }

                }
            }
        }

// BOTONES DELETE ####################################################################################################
        private void btnDeleteRegistros_Click(object sender, RoutedEventArgs e)
        {
            String deleteRegistro = listBoxRegistros.SelectedItem.ToString();
            DeleteToBD formDelete = new DeleteToBD("Registro", deleteRegistro);
            formDelete.ShowDialog();
            bool? resultado = formDelete.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formDelete.texto != " ")
                    {
                        textoDelete = formDelete.texto;

                        conexion.deleteRegistro(textoDelete);
                        listBoxRegistros.Items.Clear();
                        foreach (String registro in conexion.listadoRegistros()) // Loop llena listBoxRegistros
                        {
                            listBoxRegistros.Items.Add(registro);
                        }
                        listBoxRegistros.SelectedIndex = 0;
                        lblRegistros.Content = "Hay " + conexion.numeroDeRegistros() + " Registros";
                    }

                }
            }
        }

        private void btnDeleteTrabajadores_Click(object sender, RoutedEventArgs e)
        {
            String deleteTrabajador = listBoxTrabajadores.SelectedItem.ToString();
            DeleteToBD formDelete = new DeleteToBD("trabajador", deleteTrabajador);
            formDelete.ShowDialog();
            bool? resultado = formDelete.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formDelete.texto != " ")
                    {
                        textoDelete = formDelete.texto;

                        conexion.deleteTrabajador(textoDelete);   
                        listBoxTrabajadores.Items.Clear();
                        foreach (String trabajador in conexion.listadoTrabajadores()) // Loop llena listBoxTrabajadores
                        {
                            listBoxTrabajadores.Items.Add(trabajador);
                        }
                        listBoxTrabajadores.SelectedIndex = 0;
                        lblTrabajadores.Content = "Hay " + conexion.numeroDeTrabajadores() + " trabajadores";
                    }

                }
            }
        }

        private void btnDeleteVias_Click(object sender, RoutedEventArgs e)
        {
            String deleteVias = listBoxVias.SelectedItem.ToString();
            DeleteToBD formDelete = new DeleteToBD("via", deleteVias);
            formDelete.ShowDialog();
            bool? resultado = formDelete.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formDelete.texto != " ")
                    {
                        textoDelete = formDelete.texto;

                        conexion.deleteVia(textoDelete);
                        listBoxVias.Items.Clear();
                        foreach (String via in conexion.listadoVias()) // Loop llena listBoxVias
                        {
                            listBoxVias.Items.Add(via);
                        }
                        listBoxVias.SelectedIndex = 0;
                        lblVias.Content = "Hay " + conexion.numeroDeVias() + " vias";
                    }

                }
            }
        }

        private void btnDeletePreparadores_Click(object sender, RoutedEventArgs e)
        {
            String deletePreparador = listBoxPreparadores.SelectedItem.ToString();
            DeleteToBD formDelete = new DeleteToBD("preparador", deletePreparador);
            formDelete.ShowDialog();
            bool? resultado = formDelete.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    if (formDelete.texto != " ")
                    {
                        textoDelete = formDelete.texto;

                        conexion.deletePreparador(textoDelete);
                        listBoxPreparadores.Items.Clear();
                        foreach (String preparador in conexion.listadoPreparadores()) // Loop llena listBoxPreparadores
                        {
                            listBoxPreparadores.Items.Add(preparador);
                        }
                        listBoxPreparadores.SelectedIndex = 0;
                        lblPreparadores.Content = "Hay " + conexion.numeroDePreparadores() + " preparadores";
                    }

                }
            }
        }
    }  // end class    

} // end namespace

