using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Data;

namespace FaeneteS
{
    class DataBase
    {

        private MySqlConnection conexion;
        private MySqlDataAdapter adapter;
        private DataSet ds;

        public DataBase()
        {
            ds = new DataSet();       
        }

        public void conectarBD()
        {
            try
            {
                // Cadena de conexión (especifica los datos al conector)
                MySqlConnectionStringBuilder cadenaConexion = new MySqlConnectionStringBuilder();
                cadenaConexion.Server = "192.168.56.101";
                cadenaConexion.UserID = "cliente";
                cadenaConexion.Password = "faenetes";
                cadenaConexion.Database = "faenetesDB";
                // Conexion (con los datos de la cadena, conecta con la BD)
                conexion = new MySqlConnection(cadenaConexion.ToString());
                conexion.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void desconectarBD()
        {
            conexion.Close();
        }

        public DataSet tablaConfiguracion()
        {
            String consulta = "SELECT * FROM configuracion; ";
            adapter = new MySqlDataAdapter(consulta, conexion);
            adapter.Fill(ds);
            return ds;
        }
  
    } // end class

} // end namespace
