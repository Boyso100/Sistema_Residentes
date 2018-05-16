using EnviarCorreo.Modelos_pojos_;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviarCorreo.Daos
{
    public class LoginDAO
    {
        Conexion conexionLogin = Conexion.obtenerInstanciaConexion();

        public Asesor getAsesor(string user)
        {
            Asesor asesor = new Asesor();
            string sqlQuery = "SELECT * FROM asesores WHERE usuario LIKE '@Usuario';";

            if (conexionLogin.abrirConexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conexionLogin.obtenerConexion());
                cmd.Parameters.AddWithValue("@Usuario", user);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
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
                conexionLogin.cerrarConexion();
            }
            return asesor;
        }
    }
}
