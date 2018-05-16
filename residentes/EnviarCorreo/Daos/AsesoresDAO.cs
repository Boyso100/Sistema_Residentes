using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnviarCorreo.Modelos_pojos_;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EnviarCorreo.Daos
{
    public class AsesoresDAO
    {
        Conexion conexionAsesores = Conexion.obtenerInstanciaConexion();

        public Asesor obtenerAsesor(string user)
        {

            Asesor asesor = new Asesor();
            string sqlQuery = "SELECT * FROM asesores WHERE usuario LIKE '" + user + "';";

            if (conexionAsesores.abrirConexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conexionAsesores.obtenerConexion());
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    asesor.setIdAsesor(Convert.ToInt32(dr["id_asesor"] + ""));
                    asesor.setUsuario(dr["usuario"] + "");
                    asesor.setPassword(dr["pass"] + "");
                    asesor.setNombre(dr["nombre"] + "");
                    asesor.setApellidoPaterno(dr["apellido_paterno"] + "");
                    asesor.setApellidoMaterno(dr["apellido_materno"] + "");
                    asesor.setEmail(dr["email"] + "");
                    asesor.setTelefono(dr["telefono"] + "");
                }

                // Close DataReader
                dr.Close();
                // Close connection
                conexionAsesores.cerrarConexion();
            }
            return asesor;
        }

    }
}
