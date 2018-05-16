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
    public class ObservacionesDAO
    {

        Conexion conexionObservaciones = Conexion.obtenerInstanciaConexion();

        public bool agregarObservacion(Observacion objObservacion)
        {
            string sqlQuery = "INSERT INTO observaciones VALUES(null, @Fecha,  @Descripcion, @IdAsesor, @Matricula);";

            if (conexionObservaciones.abrirConexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conexionObservaciones.obtenerConexion());
                cmd.Parameters.AddWithValue("@Fecha", objObservacion.getFecha());
                cmd.Parameters.AddWithValue("@Descripcion", objObservacion.getDescripcion());
                cmd.Parameters.AddWithValue("@IdAsesor", objObservacion.getIdAsesor());
                cmd.Parameters.AddWithValue("@Matricula", objObservacion.getMatricula());

                cmd.ExecuteNonQuery();

                // Cerrar conexion
                conexionObservaciones.cerrarConexion();
            }
            return true;
        }

        /*public List<Alumno> seleccionarAlumnosPorAsesor(int idAsesor)
        {
            List<Alumno> alumnos = new List<Alumno>();
            string sqlQuery = "select * from alumnos where idAsesor = " + idAsesor + ";";

            if (openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Alumno alumno = new Alumno();
                    alumno.setMatricula(dr["matricula"] + "");
                    alumno.setUsuario(dr["usuario"] + "");
                    alumno.setNombre(dr["nombre"] + "");
                    alumno.setApellidoPaterno(dr["apellido_paterno"] + "");
                    alumno.setApellidoMaterno(dr["apellido_materno"] + "");
                    alumno.setEmail(dr["email"] + "");
                    alumno.setTelefono(dr["telefono"] + "");
                    alumnos.Add(alumno);
                }

                // Close DataReader
                dr.Close();
                // Close connection
                closeConnection();
            }
            return alumnos;
        }*/
    }
}
