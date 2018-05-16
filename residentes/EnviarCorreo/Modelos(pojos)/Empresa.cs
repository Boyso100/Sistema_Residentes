using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviarCorreo.Modelos_pojos_
{
    class Empresa
    {
        string _rfc;
        string _nombre_empresa;
        string _ciudad;
        string _fax;
        string _mision;
        string _colonia;
        string _cp;
        string _nombreTitular;
        string _direccion;
        string _asesor_externo;
        string _tel;


        public Empresa(string rfc, string nombre, string ciudad, string fax, string mision, string colonia, string cp, string direccion, string tele)
        {

            _rfc = rfc;
            _nombre_empresa = nombre;
            _ciudad = ciudad;
            _fax = fax;
            _mision = mision;
            _colonia = colonia;
            _cp = cp;
            _direccion = direccion;
            _tel = tele;
        }


        public string RFC
        {
            get { return _rfc; }
            set { _rfc = value; }
        }




        public string nombre_empresa
        {
            get { return _nombre_empresa; }
            set { _nombre_empresa = value; }
        }

        public string Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }


        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        public string Mision
        {
            get { return _mision; }
            set { _mision = value; }
        }

        public string Colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }
        public string Cp
        {
            get { return _cp; }
            set { _cp = value; }
        }
        public string Nombretitular
        {
            get { return _nombreTitular; }
            set { _nombreTitular = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Asesor_ext
        {
            get { return _asesor_externo; }
            set { _asesor_externo = value; }
        }
        public string Telefono
        {
            get { return _tel; }
            set { _tel = value; }
        }

    }
}

    