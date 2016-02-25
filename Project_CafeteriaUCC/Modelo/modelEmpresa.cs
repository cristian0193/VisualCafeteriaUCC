using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modelEmpresa
    {

        private int _NIT_EMPRESA;
        private string _NOMBRE_EMPRESA;
        private string _LOGO_EMPRESA;
        private string _DIRECCION;
        private string _EMAIL;
        private string _TELEFONO;



        public modelEmpresa()
        {
            this._NIT_EMPRESA = 0;
            this._NOMBRE_EMPRESA = "";
            this._LOGO_EMPRESA = "";
            this._DIRECCION = "";
            this._EMAIL = "";
            this._TELEFONO = "";

        }

        public modelEmpresa(int NIT_EMPRESA, String NOMBRE_EMPRESA, String LOGO_EMPRESA, String DIRECCION, String EMAIL, String TELEFONO)
        {
            this._NIT_EMPRESA = NIT_EMPRESA;
            this._NOMBRE_EMPRESA = NOMBRE_EMPRESA;
            this._LOGO_EMPRESA = LOGO_EMPRESA;
            this._DIRECCION = DIRECCION;
            this._EMAIL = EMAIL;
            this._TELEFONO = TELEFONO;


        }


        public int NIT_EMPRESA
        {
            get { return _NIT_EMPRESA; }
            set { _NIT_EMPRESA = value; }
        }

        public String NOMBRE_EMPRESA
        {
            get { return _NOMBRE_EMPRESA; }
            set { _NOMBRE_EMPRESA = value; }
        }

        public String LOGO_EMPRESA
        {
            get { return _LOGO_EMPRESA; }
            set { _LOGO_EMPRESA = value; }
        }

        public String DIRECCION
        {
            get { return _DIRECCION; }
            set { _DIRECCION = value; }
        }

        public String EMAIL
        {
            get { return _EMAIL; }
            set { _EMAIL = value; }
        }

        public String TELEFONO
        {
            get { return _TELEFONO; }
            set { _TELEFONO = value; }
        }
      
    }
}
