using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviarCorreo.Modelos_pojos_
{
    public class Observacion
    {
        private int id_observacion;
        private string fecha;
        private string descripcion;
        private int id_asesor;
        private string matricula_alumno;

        public int getIdObservacion()
        {
            return id_observacion;
        }

        public void setIdObservacion(int id_observacion)
        {
            this.id_observacion = id_observacion;
        }

        public string getFecha()
        {
            return fecha;
        }

        public void setFecha(string fecha)
        {
            this.fecha = fecha;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public int getIdAsesor()
        {
            return id_asesor;
        }

        public void setIdAsesor(int id_asesor)
        {
            this.id_asesor = id_asesor;
        }

        public string getMatricula()
        {
            return matricula_alumno;
        }

        public void setMatricula(string matricula)
        {
            this.matricula_alumno = matricula;
        }

    }
}
