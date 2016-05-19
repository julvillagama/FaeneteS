using System.Windows;

namespace FaeneteS
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        // Botón Configuración
        private void btn_configuracion_Click(object sender, RoutedEventArgs e)
        {
            Configuracion frmConfiguracion = new Configuracion(this);
            frmConfiguracion.Show();
            this.Hide();
        }

        // Botón salir de la aplicación
        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Seguro que quiere salir?", "Diálogo de confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        // Método mostrar inicio al cerrar otro form
        public void mostrarInicio()
        {
            this.Show();
        }
    }
}
