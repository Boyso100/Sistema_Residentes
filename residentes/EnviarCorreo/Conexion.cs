using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviarCorreo
{
    public class Conexion
    {
        MySqlConnection conexionMySQL;
        MySqlConnectionStringBuilder cadenaConexion;

        // Al hacer el constructor privado, esta clase no puede ser instanciada
        private Conexion()
        {
            try
            {
                cadenaConexion = new MySqlConnectionStringBuilder
                {
                    Server = "localhost",
                    Database = "sistema_control_residentes",
                    UserID = "root",
                    Password = "root",
                    SslMode = MySqlSslMode.None
                };

                conexionMySQL = new MySqlConnection(cadenaConexion.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Crear el único objeto de la clase Conexion
        private static Conexion conn = new Conexion();

        // Retornar la única instancia de la clase Conexion
        public static Conexion obtenerInstanciaConexion()
        {
            return conn;
        }

        public MySqlConnection obtenerConexion()
        {
            return conexionMySQL;
        }

        public bool abrirConexion()
        {
            try
            {
                conexionMySQL.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No se puede conectar al servidor.");
                        break;
                    case 1045:
                        MessageBox.Show("Datos inválidos. Intente de nuevo.");
                        break;
                }
                return false;
            }
        }

        public bool cerrarConexion()
        {
            try
            {
                conexionMySQL.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
