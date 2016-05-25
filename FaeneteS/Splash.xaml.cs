using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace FaeneteS
{
    /// <summary>
    /// Lógica de interacción para Splash.xaml
    /// </summary>
    public partial class Splash
    {

        private DispatcherTimer dispatcherTimer;
        private Duration duration;
        private DoubleAnimation doubleanimation;
        private Conexion conexion;
        private ThreadStart delegado;

        public Splash()
        {
            InitializeComponent();
            this.dispatcherTimer = new DispatcherTimer();
            this.duration = new Duration(TimeSpan.FromSeconds(5));
            this.doubleanimation = new DoubleAnimation(200.0, duration);
            // HILO CONEXION BASE DATOS
            //Creamos el delegado 
            delegado = new ThreadStart(CorrerProceso);
            //Creamos la instancia del hilo 
            Thread hilo = new Thread(delegado);
            //Iniciamos el hilo 
            hilo.Start();
        }

        private void CorrerProceso()
        {
            conexion = Conexion.Instancia;   
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value < 100)
            {
                ProgressBar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);
            }
            else
            {
                dispatcherTimer.Stop();
                this.Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Principal ventanaPrincipal = new Principal();
            ventanaPrincipal.Show();
        }

    }
}
