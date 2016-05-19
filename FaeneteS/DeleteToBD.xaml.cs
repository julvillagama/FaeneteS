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
    /// Lógica de interacción para DeleteToBD.xaml
    /// </summary>
    public partial class DeleteToBD : Window
    {
        public String texto { get; set; }

        public DeleteToBD(String name, String borrarTrabajador)
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
