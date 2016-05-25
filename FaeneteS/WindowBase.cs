using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FaeneteS
{
    public class WindowBase : Window
    {
        private Conexion conn = Conexion.Instancia;
        private DataTable dt = new DataTable();

        public WindowBase()
        {

        }

        public Conexion conexion
        {
            get { return conn; }
            set { conn = value; }
        }

        public DataTable datos
        {
            get { return dt; }
            set { dt = value; }
        }
    }
}
