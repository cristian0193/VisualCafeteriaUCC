using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modelLogin
    {

        private int _IDENTIFICACION;
        private String _PASSWORD;

        public modelLogin()
        {
            this._IDENTIFICACION = 0;
            this._PASSWORD = "";
        }

        public modelLogin(int IDENTIFICACION, String PASSWORD)
        {
            this._IDENTIFICACION = IDENTIFICACION;
            this._PASSWORD = PASSWORD;
        }

        public int IDENTIFICACION
        {
            get { return _IDENTIFICACION; }
            set { _IDENTIFICACION = value; }
        }

        public String PASSWORD
        {
            get { return _PASSWORD; }
            set { _PASSWORD = value; }
        }
       

    }
}
