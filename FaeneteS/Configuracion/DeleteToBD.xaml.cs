using System;
using System.Windows;

namespace FaeneteS
{
    /// <summary>
    /// Lógica de interacción para DeleteToBD.xaml
    /// </summary>
    public partial class DeleteToBD : WindowBase
    {
        public String texto { get; set; }

        public DeleteToBD(String name, String borrarTrabajador):base()
        {
            InitializeComponent();
            titulo.Content = titulo.Content.ToString() + " " + name;
            this.texto = borrarTrabajador;
            labelDelete.Content = "¿Borrar " + name + " " + borrarTrabajador + "?";
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

    }
}
