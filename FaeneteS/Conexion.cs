using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace FaeneteS
{
    class Conexion
    {
        // variable estatica instanciandola a la misma clase
        private static Conexion conexion = null;

        private MySqlConnection conn;
        // private MySqlDataAdapter adapter;
        private DataSet ds = new DataSet();
        private MySqlCommand cmd;

        private DataTable dt = new DataTable();

        // constructor privado. impide acceso
        private Conexion()
        {

        }

        // propiedad publica estatica 
        public static Conexion Instancia
        {
            get
            {
                if (conexion == null)
                {
                    conexion = new Conexion();
                    conexion.conectarBD();
                }
                return conexion;
            } // end get
        }

        private void conectarBD()
        {
            try
            {
                // Cadena de conexión (especifica los datos al conector)
                MySqlConnectionStringBuilder cadenaConexion = new MySqlConnectionStringBuilder();
                cadenaConexion.Server = "172.31.100.8";
                cadenaConexion.UserID = "cliente";
                cadenaConexion.Password = "faenetes";
                cadenaConexion.Database = "faenetesDB";
                // Conexion (con los datos de la cadena, conecta con la BD)
                conn = new MySqlConnection(cadenaConexion.ToString());
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBoxResult result = MessageBox.Show("La conexión con la base de datos ha fallado", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // CONFIGURACION
        public int numeroDeRegistros()
        {
            int numeroDeRegistros = 0;
            try
            {

                string query = "SELECT COUNT(registro) FROM configuracion";
                cmd = new MySqlCommand(query, conn);
                numeroDeRegistros = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return numeroDeRegistros;
        }

        public int numeroDeTrabajadores()
        {
            int numeroDeTrabajadores = 0;
            try
            {

                string query = "SELECT COUNT(trabajador) FROM configuracion";
                cmd = new MySqlCommand(query, conn);
                numeroDeTrabajadores = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return numeroDeTrabajadores;
        }

        public int numeroDeVias()
        {
            int numeroDeVias = 0;
            try
            {

                string query = "SELECT COUNT(via) FROM configuracion";
                cmd = new MySqlCommand(query, conn);
                numeroDeVias = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return numeroDeVias;
        }

        public int numeroDePreparadores()
        {
            int numeroDePreparadores = 0;
            try
            {

                string query = "SELECT COUNT(preparador) FROM configuracion";
                cmd = new MySqlCommand(query, conn);
                numeroDePreparadores = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return numeroDePreparadores;
        }

        public List<String> listadoRegistros()
        {
            List<String> values = new List<String>();
            string query = "SELECT registro FROM configuracion WHERE registro IS NOT NULL ORDER BY registro";

            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    values.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return values;
        }

        public List<String> listadoTrabajadores()
        {
            List<String> values = new List<String>();
            string query = "SELECT trabajador FROM configuracion WHERE trabajador IS NOT NULL ORDER BY trabajador";

            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    values.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return values;
        }

        public List<String> listadoVias()
        {
            List<String> values = new List<String>();
            string query = "SELECT via FROM configuracion WHERE via IS NOT NULL ORDER BY via";

            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    values.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return values;
        }

        public List<String> listadoPreparadores()
        {
            List<String> values = new List<String>();
            string query = "SELECT preparador FROM configuracion WHERE preparador IS NOT NULL ORDER BY preparador";

            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    values.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return values;
        }

        public void addRegistro(String texto)
        {
            string query = "INSERT INTO configuracion(registro) VALUES('" + texto + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateRegistro(String nombreViejo, string nombreNuevo)
        {
            string query = "UPDATE configuracion SET registro = '" + nombreNuevo + "' WHERE registro = '" + nombreViejo + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteRegistro(String nombreBorrar)
        {
            string query = "DELETE FROM configuracion WHERE registro = '" + nombreBorrar + "' ORDER BY registro";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void addTrabajador(String texto)
        {
            string query = "INSERT INTO configuracion(trabajador) VALUES('" + texto + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateTrabajador(String nombreViejo, string nombreNuevo)
        {
            string query = "UPDATE configuracion SET trabajador = '" + nombreNuevo + "' WHERE trabajador = '" + nombreViejo + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteTrabajador(String nombreBorrar)
        {
            string query = "DELETE FROM configuracion WHERE trabajador = '" + nombreBorrar + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void addVia(String texto)
        {
            string query = "INSERT INTO configuracion(via) VALUES('" + texto + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateVia(String nombreViejo, string nombreNuevo)
        {
            string query = "UPDATE configuracion SET via = '" + nombreNuevo + "' WHERE via = '" + nombreViejo + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteVia(String nombreBorrar)
        {
            string query = "DELETE FROM configuracion WHERE via = '" + nombreBorrar + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void addPreparador(String texto)
        {
            string query = "INSERT INTO configuracion(preparador) VALUES('" + texto + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updatePreparador(String nombreViejo, string nombreNuevo)
        {
            string query = "UPDATE configuracion SET preparador = '" + nombreNuevo + "' WHERE preparador = '" + nombreViejo + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deletePreparador(String nombreBorrar)
        {
            string query = "DELETE FROM configuracion WHERE preparador = '" + nombreBorrar + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // CONSULTAS
        public int idConsulta()
        {
            int idConsulta = 0;
            try
            {

                string query = "SELECT MAX(_id) FROM consultas;";
                cmd = new MySqlCommand(query, conn);
                idConsulta = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return idConsulta;
        }

        public DataTable consultasRecibidas()
        {
            string query = "SELECT * FROM consultas ORDER BY _id DESC";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public void addConsulta(String fecha, String nombre, String consulta, String via, String respuesta)
        {
            string query = "INSERT INTO consultas (_id, fecha, nombre, consulta, via, respuesta) VALUES(NULL, '" + fecha + "', '" + nombre + "', '" + consulta + "', '" + via + "', '" + respuesta + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public void deleteConsulta(int _id)
        {
            string query = "DELETE FROM consultas WHERE _id = '" + _id + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateConsulta(int _id, String fecha, String nombre, String consulta, String via, String respuesta)
        {
            string query = "UPDATE consultas SET fecha = '" + fecha + "', nombre = '" + nombre + "', consulta = '" + consulta + "', via = '" + via + "', respuesta = '" + respuesta + "' WHERE _id = " + _id;
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable FechasConsultasRecibidas(String desde, String hasta)
        {
            string query = "SELECT * FROM consultas WHERE (fecha BETWEEN '" + desde + "' AND '" + hasta + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        // QUEJAS
        public int idQueja()
        {
            int idQueja = 0;
            try
            {

                string query = "SELECT MAX(_id) FROM quejas;";
                cmd = new MySqlCommand(query, conn);
                idQueja = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return idQueja;
        }

        public DataTable quejasRecibidas()
        {
            string query = "SELECT * FROM quejas ORDER BY _id DESC";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public void addQueja(String fecha, String nombre, String queja, String registro, String resolucion)
        {
            string query = "INSERT INTO quejas (_id, fecha, nombre, queja, registro, resolucion) VALUES(NULL, '" + fecha + "', '" + nombre + "', '" + queja + "', '" + registro + "', '" + resolucion + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteQueja(int _id)
        {
            string query = "DELETE FROM quejas WHERE _id = '" + _id + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateQueja(int _id, String fecha, String nombre, String queja, String registro, String resolucion)
        {
            string query = "UPDATE quejas SET fecha = '" + fecha + "', nombre = '" + nombre + "', queja = '" + queja + "', registro = '" + registro + "', resolucion = '" + resolucion + "' WHERE _id = " + _id;
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable FechasQuejasRecibidas(String desde, String hasta)
        {
            string query = "SELECT * FROM quejas WHERE (fecha BETWEEN '" + desde + "' AND '" + hasta + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        // CORREOS
        public int idCorreo()
        {
            int idCorreo = 0;
            try
            {

                string query = "SELECT MAX(_id) FROM correo;";
                cmd = new MySqlCommand(query, conn);
                idCorreo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return idCorreo;
        }

        public DataTable correoPostal()
        {
            string query = "SELECT * FROM correo ORDER BY _id DESC";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public DataTable correoPostalverEntradas()
        {
            string query = "SELECT * FROM correo WHERE darEntrada = 1 ORDER BY _id DESC";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public DataTable correoPostalverSalidas()
        {
            string query = "SELECT * FROM correo WHERE darSalida = 1 ORDER BY _id DESC";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public DataTable correoPostalverPendientes()
        {
            string query = "SELECT * FROM correo WHERE finalizado = 0 ORDER BY _id DESC";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public DataTable correoPostalverFinalizados()
        {
            string query = "SELECT * FROM correo WHERE finalizado = 1 ORDER BY _id DESC";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public void addCorreo(String fecha, bool entrada, bool salida, Boolean certificado, String remite, String contenido, String destino, String empleado, String estado, Boolean finalizado)
        {
            int _entrada = 0, _salida = 0, _certificado = 0, _finalizado = 0;
            if (entrada) { _entrada = 1; } if (salida) { _salida = 1; } if (certificado) { _certificado = 1; } if (finalizado) { _finalizado = 1; }
                                                                                                                                                                                     
            string query = "INSERT INTO correo (_id, fecha, darEntrada, darSalida, certificado, nombreRemite, contenido, destino, personaSeguimiento, estadoGestion, finalizado) VALUES(NULL, '" + fecha + "', '" + _entrada + "', '" + _salida + "', '" + _certificado + "', '" + remite + "', '" + contenido + "', '" + destino + "', '" + empleado + "', '" + estado + "', '" + _finalizado + "')";

            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void deleteCorreo(int _id)
        {
            string query = "DELETE FROM correo WHERE _id = '" + _id + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateCorreo(int _id, String fecha, bool entrada, bool salida, Boolean certificado, String remite, String contenido, String destino, String empleado, String estado, Boolean finalizado)
        {
            int _entrada = 0, _salida = 0, _certificado = 0, _finalizado = 0;
            if (entrada) { _entrada = 1; } if (salida) { _salida = 1; }  if (certificado) { _certificado = 1; }if (finalizado) { _finalizado = 1; }

            string query = "UPDATE correo SET fecha = '" + fecha + "', darEntrada = '" + _entrada + "', darSalida = '" + _salida + "', certificado = '" + _certificado + "',  nombreRemite = '" + remite + "',  contenido = '" + contenido + "', destino = '" + destino + "',  personaSeguimiento = '" + estado + "', estadoGestion = '" + estado + "', finalizado = '" + _finalizado + "' WHERE _id = " + _id;

            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable FechasCorreo(String desde, String hasta)
        {
            string query = "SELECT * FROM correo WHERE (fecha BETWEEN '" + desde + "' AND '" + hasta + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public DataTable informeCorreo(String desde, String hasta)
        {
            string query = "SELECT * FROM correo WHERE (fecha BETWEEN '" + desde + "' AND '" + hasta + "') ORDER BY fecha";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        // LLAMADAS
        public int idLlamada()
        {
            int idLlamada = 0;
            try
            {

                string query = "SELECT MAX(_id) FROM llamadas;";
                cmd = new MySqlCommand(query, conn);
                idLlamada = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return idLlamada;
        }

        public DataTable llamadas()
        {
            string query = "SELECT * FROM llamadas ORDER BY _id DESC";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public void addLlamada(String fecha, String nombre, String consulta)
        {
            string query = "INSERT INTO llamadas (_id, fecha, nombre, consulta) VALUES(NULL, '" + fecha + "', '" + nombre + "', '" + consulta + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteLlamada(int _id)
        {
            string query = "DELETE FROM llamadas WHERE _id = '" + _id + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateLlamada(int _id, String fecha, String nombre, String consulta)
        {
            string query = "UPDATE llamadas SET fecha = '" + fecha + "', nombre = '" + nombre + "', consulta = '" + consulta  + "' WHERE _id = " + _id;
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable FechasLlamadas(String desde, String hasta)
        {
            string query = "SELECT * FROM llamadas WHERE (fecha BETWEEN '" + desde + "' AND '" + hasta + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        // ACADEMIA
        public int idAcademia()
        {
            int idLlamada = 0;
            try
            {

                string query = "SELECT MAX(_id) FROM academia;";
                cmd = new MySqlCommand(query, conn);
                idLlamada = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return idLlamada;
        }

        public DataTable academia()
        {
            string query = "SELECT * FROM academia ORDER BY _id DESC";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public void addAcademia(String fecha, String preparador, String opositor, String material)
        {
            string query = "INSERT INTO academia (_id, fecha, preparador, opositor, material) VALUES(NULL, '" + fecha + "', '" + preparador + "', '" + opositor + "', '" + material + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteAcademia(int _id)
        {
            string query = "DELETE FROM academia WHERE _id = '" + _id + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateAcademia(int _id, String fecha, String preparador, String opositor, String material)
        {
            string query = "UPDATE academia SET fecha = '" + fecha + "', preparador = '" + preparador + "', opositor = '" + opositor + "', material = '" + material + "' WHERE _id = " + _id;
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable FechasAcademia(String desde, String hasta)
        {
            string query = "SELECT * FROM academia WHERE (fecha BETWEEN '" + desde + "' AND '" + hasta + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        // ACTOS
        public int idActo()
        {
            int idActo = 0;
            try
            {

                string query = "SELECT MAX(_id) FROM actos;";
                cmd = new MySqlCommand(query, conn);
                idActo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return idActo;
        }

        public DataTable actos()
        {
            string query = "SELECT * FROM actos ORDER BY _id DESC";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public void addActo(String fecha, String acto, String lugar, String empresaCatering, String nombreMenu, String precioPersona, String notas)
        {
            string query = "INSERT INTO actos(_id, fecha, acto, lugar, empresaCatering, nombreMenu, precioPersona, observaciones) VALUES(NULL, '" + fecha + "', '" + acto + "', '" + lugar + "', '" + empresaCatering + "', '" + nombreMenu + "', '" + precioPersona + "', '" + notas + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteActo(int _id)
        {
            string query = "DELETE FROM actos WHERE _id = '" + _id + "'";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateActo(int _id, String fecha, String acto, String lugar, String empresaCatering, String nombreMenu, String precioPersona, String notas)
        {
            string query = "UPDATE actos SET fecha = '" + fecha + "', acto = '" + acto + "', lugar = '" + lugar + "', empresaCatering = '" + empresaCatering + "', nombreMenu= '" + nombreMenu + "', precioPersona = '" + precioPersona + "', observaciones = '" + notas + "' WHERE _id = " + _id;
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable FechasActos(String desde, String hasta)
        {
            string query = "SELECT * FROM actos WHERE (fecha BETWEEN '" + desde + "' AND '" + hasta + "')";
            try
            {
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

    } // end class
}
