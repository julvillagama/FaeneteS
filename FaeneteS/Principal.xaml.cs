using FaeneteS.Correo;
using FaeneteS.Quejas;
using System;
using System.Windows;
using System.Windows.Threading;

namespace FaeneteS
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {

        private DispatcherTimer dispatcherTimer; // timer para reloj
        private Configuracion frmConfiguracion;
        private ConsultasRecibidas frmConsultasRecibidas;
        private QuejasPresentadas frmQuejasPresentadas;
        private CorreoPostal frmCorreoPostal;
        private Llamadas frmLlamadas;
        private Academia frmAcademia;
        private ActosOrganizados frmActos;
        private Informe frmInformes;
        private Conexion conexion;

        public Principal()
        {
            InitializeComponent();
            this.dispatcherTimer = new DispatcherTimer();
        }

        // LOAD DEL FORMULARIO
        private void Principal1_Loaded(object sender, RoutedEventArgs e)
        {
            // inicializa en timer
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Start();

            // inicializa la fecha
            lblFecha.Content = DateTime.Now.ToShortDateString();
        }

        // EVENTO TIMER RELOJ
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            lblHora.Content = DateTime.Now.ToLongTimeString();
        }

        // MINIMIZAR APLICACIÓN
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // CONTROLA EL BOTON MINIMIZAR PARA QUITARLE EL ESTADO FOCUSABLE
        private void Principal1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            btnMinimizar.Focusable = false;
        }

        // SALIR APLICACIÓN
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // ABRE FORM CONFIGURACION
        private void btnConfiguracion_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                frmConfiguracion = new Configuracion();
                frmConfiguracion.Owner = this;
                image.Visibility = Visibility.Hidden;
                frmConfiguracion.ShowDialog();

                bool?
                resultado = frmConfiguracion.DialogResult;
                if (resultado != null)
                {
                    if (resultado == false)
                    {
                        image.Visibility = Visibility.Visible;
                        btnInvisible.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                frmConfiguracion.Close();
                btnInvisible.Focus();
                image.Visibility = Visibility.Visible;
            }

        }
        
        // ABRE FORM CONSULTAS RECIBIDAS
        private void btnConsultasRecibidas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                frmConsultasRecibidas = new ConsultasRecibidas();
                frmConsultasRecibidas.Owner = this;
                image.Visibility = Visibility.Hidden;
                frmConsultasRecibidas.ShowDialog();

                bool?
                resultado = frmConsultasRecibidas.DialogResult;
                if (resultado != null)
                {
                    if (resultado == false)
                    {
                        image.Visibility = Visibility.Visible;
                        btnInvisible.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                frmConsultasRecibidas.Close();
                btnInvisible.Focus();
                image.Visibility = Visibility.Visible;
            }
        }
        
        // ABRE FORM QUEJAS PRESENTADAS
        private void btnQuejasPresentadas_Click(object sender, RoutedEventArgs e)
        {
            try
            { 

            frmQuejasPresentadas = new QuejasPresentadas();
            frmQuejasPresentadas.Owner = this;
            image.Visibility = Visibility.Hidden;
            frmQuejasPresentadas.ShowDialog();

            bool?
                resultado = frmQuejasPresentadas.DialogResult;
            if (resultado != null)
            {
                if (resultado == false)
                {
                    image.Visibility = Visibility.Visible;
                    btnInvisible.Focus();
                }
            }

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                frmQuejasPresentadas.Close();
                btnInvisible.Focus();
                image.Visibility = Visibility.Visible;
            }
}
        
        // ABRE FORM CORREO POSTAL
        private void btnCorreoPostal_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                frmCorreoPostal = new CorreoPostal();
                frmCorreoPostal.Owner = this;
                image.Visibility = Visibility.Hidden;
                frmCorreoPostal.ShowDialog();

                bool?
                    resultado = frmCorreoPostal.DialogResult;
                if (resultado != null)
                {
                    if (resultado == false)
                    {
                        image.Visibility = Visibility.Visible;
                        btnInvisible.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                frmCorreoPostal.Close();
                btnInvisible.Focus();
                image.Visibility = Visibility.Visible;
            }
        }
        
        // ABRE FORM LLAMADAS
        private void btnLlamadasInstitucionales_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                frmLlamadas = new Llamadas();
                frmLlamadas.Owner = this;
                image.Visibility = Visibility.Hidden;
                frmLlamadas.ShowDialog();

                bool?
                    resultado = frmLlamadas.DialogResult;
                if (resultado != null)
                {
                    if (resultado == false)
                    {
                        image.Visibility = Visibility.Visible;
                        btnInvisible.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                frmLlamadas.Close();
                btnInvisible.Focus();
                image.Visibility = Visibility.Visible;
            }
        }

        // ABRE FORM ACADEMIA DE OPOSITORES
        private void btnAcademiaOpositores_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                frmAcademia = new Academia();
                frmAcademia.Owner = this;
                image.Visibility = Visibility.Hidden;
                frmAcademia.ShowDialog();

                bool?
                    resultado = frmAcademia.DialogResult;
                if (resultado != null)
                {
                    if (resultado == false)
                    {
                        image.Visibility = Visibility.Visible;
                        btnInvisible.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                frmAcademia.Close();
                btnInvisible.Focus();
                image.Visibility = Visibility.Visible;
            }

        }

        // ABRE FORM ACTOS
        private void btnActosOrganizados_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                frmActos = new ActosOrganizados();
                frmActos.Owner = this;
                image.Visibility = Visibility.Hidden;
                frmActos.ShowDialog();

                bool?
                    resultado = frmActos.DialogResult;
                if (resultado != null)
                {
                    if (resultado == false)
                    {
                        image.Visibility = Visibility.Visible;
                        btnInvisible.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                frmActos.Close();
                btnInvisible.Focus();
                image.Visibility = Visibility.Visible;
            }

        }

        // ABRE FORM INFORMES
        private void btnGenerarInforme_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                frmInformes = new Informe();
                frmInformes.Owner = this;
                image.Visibility = Visibility.Hidden;
                frmInformes.ShowDialog();

                bool?
                    resultado = frmInformes.DialogResult;
                if (resultado != null)
                {
                    if (resultado == false)
                    {
                        image.Visibility = Visibility.Visible;
                        btnInvisible.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                frmInformes.Close();
                btnInvisible.Focus();
                image.Visibility = Visibility.Visible;
            }

        }

    } // end class

} // end namespace
