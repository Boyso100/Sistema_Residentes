using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using EnviarCorreo.vistas;
using EnviarCorreo.Modelos_pojos_;
using EnviarCorreo.Daos;
using MySql.Data;
namespace EnviarCorreo.Daos
{
    class Dao_empresa
    {

        Conexion conect = Conexion.obtenerInstanciaConexion();
        private MySqlDataAdapter _adaptador = new MySqlDataAdapter();
        



        public void insertarEmpresa(Empresa e)
        {
            try
            {
                _adaptador.InsertCommand = new MySqlCommand("insert into empresa (rfc,nombre_empresa,ciudad,fax,mision,colonia,cp,direccion,tel) values(@rfc,@nombre_empresa,@ciudad,@fax,@mision,@colonia,@cp,@direccion,@tel)");
                _adaptador.InsertCommand.Parameters.Add("@rfc", MySqlDbType.VarChar, 10).Value = e.RFC;
                _adaptador.InsertCommand.Parameters.Add("@nombre_empresa", MySqlDbType.VarChar, 50).Value = e.nombre_empresa;
                _adaptador.InsertCommand.Parameters.Add("@ciudad", MySqlDbType.VarChar, 30).Value = e.Ciudad;
                _adaptador.InsertCommand.Parameters.Add("@fax", MySqlDbType.VarChar, 10).Value = e.Fax;
                _adaptador.InsertCommand.Parameters.Add("@mision", MySqlDbType.VarChar, 70).Value = e.Mision;
                _adaptador.InsertCommand.Parameters.Add("@colonia", MySqlDbType.VarChar, 30).Value = e.Colonia;
                _adaptador.InsertCommand.Parameters.Add("@cp", MySqlDbType.VarChar, 5).Value = e.Cp;
                _adaptador.InsertCommand.Parameters.Add("@direccion", MySqlDbType.VarChar, 50).Value = e.Direccion;
                _adaptador.InsertCommand.Parameters.Add("@tel", MySqlDbType.VarChar, 10).Value = e.Telefono;


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
