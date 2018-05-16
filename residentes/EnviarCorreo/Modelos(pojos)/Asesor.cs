using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviarCorreo.Modelos_pojos_
{
    public class Asesor
    {
        private int id_asesor;
        private string usuario;
        private string password;
        private string nombre;
        private string apellido_paterno;
        private string apellido_materno;
        private string email;
        private string telefono;

        public int getIdAsesor()
        {
            return id_asesor;
        }

        public void setIdAsesor(int id)
        {
            id_asesor = id;
        }

        public string getUsuario()
        {
            return usuario;
        }

        public void setUsuario(string user)
        {
            usuario = user;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string pass)
        {
            password = pass;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getApellidoPaterno()
        {
            return apellido_paterno;
        }

        public void setApellidoPaterno(string apellidoP)
        {
            apellido_paterno = apellidoP;
        }

        public string getApellidoMaterno()
        {
            return apellido_materno;
        }

        public void setApellidoMaterno(string apellidoM)
        {
            apellido_materno = apellidoM;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getTelefono()
        {
            return telefono;
        }

        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }
    }
}
