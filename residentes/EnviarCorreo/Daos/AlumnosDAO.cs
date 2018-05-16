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
    public class AlumnosDAO
    {
        Conexion conexionAlumnos = Conexion.obtenerInstanciaConexion();

        public bool insertarAlumno(Alumno alumno)
        {
            string sqlQuery = "INSERT INTO alumnos VALUES(@Matricula, @Nombre, @ApellidoP, @ApellidoM, @Carrera);";

            if (conexionAlumnos.abrirConexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conexionAlumnos.obtenerConexion());
                cmd.Parameters.AddWithValue("@Matricula", alumno.getMatricula());
                cmd.Parameters.AddWithValue("@Nombre", alumno.getNombre());
                cmd.Parameters.AddWithValue("@ApellidoP", alumno.getApellidoPaterno());
                cmd.Parameters.AddWithValue("@ApellidoM", alumno.getApellidoMaterno());

                cmd.ExecuteNonQuery();

                // Cerrar conexion
                conexionAlumnos.cerrarConexion();
            }
            return true;
        }

        public List<Alumno> seleccionarAlumnosPorAsesor(int idAsesor)
        {
            List<Alumno> alumnos = new List<Alumno>();
            string sqlQuery = "SELECT * FROM alumnos WHERE idAsesor = " + idAsesor + ";";

            if (conexionAlumnos.abrirConexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conexionAlumnos.obtenerConexion());
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

                // Cerrar DataReader
                dr.Close();
                // Cerrar conexion
                conexionAlumnos.cerrarConexion();
            }
            return alumnos;
        }

        public Alumno seleccionarAlumnoPorMatricula(string matricula)
        {
            Alumno  alumno = new Alumno();
            string sqlQuery = "SELECT * FROM alumnos WHERE matricula LIKE '" + matricula + "';";

            if (conexionAlumnos.abrirConexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conexionAlumnos.obtenerConexion());
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    alumno.setMatricula(dr["matricula"] + "");
                    alumno.setUsuario(dr["usuario"] + "");
                    alumno.setNombre(dr["nombre"] + "");
                    alumno.setApellidoPaterno(dr["apellido_paterno"] + "");
                    alumno.setApellidoMaterno(dr["apellido_materno"] + "");
                    alumno.setEmail(dr["email"] + "");
                    alumno.setTelefono(dr["telefono"] + "");
                }

                // Cerrar DataReader
                dr.Close();
                // Cerrar conexion
                conexionAlumnos.cerrarConexion();
            }
            return alumno;
        }

    }
}
