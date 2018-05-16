using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviarCorreo.Modelos_pojos_
{
    class Proyecto
    {

        string _lugar;
        string _Fecha;
        string _noResidente;
        string _nombre_proyecto;
        string _periodo;

        public Proyecto(string lugar, string fecha ,string noresidente, string nombreproyecto, string perido)
        {
            _lugar = lugar;
            _Fecha = fecha;
            _noResidente = noresidente;
            _nombre_proyecto = nombreproyecto;
            _periodo = perido;
           
        }

        public string lugar
        {
            get { return _lugar; }
            set { _lugar = value; }
        }

        public string fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public string noResidente
        {
            get { return _noResidente; }
            set { _noResidente = value; }
        }



        public string nombre_proyecto
        {
            get { return _nombre_proyecto; }
            set { _nombre_proyecto = value; }
        }

        public string periodo
        {
            get { return _periodo; }
            set { _periodo = value; }
        }
        

    }
}

