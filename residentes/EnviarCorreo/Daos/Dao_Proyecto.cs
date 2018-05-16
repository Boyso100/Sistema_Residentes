using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using EnviarCorreo.Modelos_pojos_;
using EnviarCorreo.Daos;
using System.Windows.Forms;

namespace EnviarCorreo.Daos
{
    class Dao_Proyecto
    {

        Conexion conect = Conexion.obtenerInstanciaConexion();
        private MySqlDataAdapter _adaptador = new MySqlDataAdapter();



        public void insertarProyecto(Proyecto p)
        {
            try
            {
                _adaptador.InsertCommand = new MySqlCommand("insert into proyecto (lugar,fecha,noResidente,nombres_proyecto,periodo,tipo_proyecto) values(@lugar,@fecha,@noResidente,@nombres_proyecto,@periodo,@tipo_proyecto)");
                _adaptador.InsertCommand.Parameters.Add("@lugar", MySqlDbType.VarChar, 9).Value = p.lugar;
                _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.VarChar, 9).Value = p.fecha;
                _adaptador.InsertCommand.Parameters.Add("@noResidente", MySqlDbType.VarChar, 9).Value = p.noResidente;
                _adaptador.InsertCommand.Parameters.Add("@nombres_proyecto", MySqlDbType.VarChar, 25).Value = p.nombre_proyecto;
                _adaptador.InsertCommand.Parameters.Add("@periodo", MySqlDbType.VarChar, 30).Value = p.periodo;
               

                conect.abrirConexion();
                _adaptador.InsertCommand.Connection = conect.obtenerConexion();
                _adaptador.InsertCommand.ExecuteNonQuery();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conect.cerrarConexion();
            }
        }
    }
}

