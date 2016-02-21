using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modelProveedor
    {

        private int _ID_PROVEEDOR;
        private string _NOMBRE_ASESOR;
        private string _APELLIDO_ASESOR;
        private string _NIT_EMPRESA;
        private string _DIRECCION;
        private string _TELEFONO;
        private string _NOMBRE_EMPRESA;
        private string _PRODUCTOS_OFRECE;



        public modelProveedor()
        {
            this._ID_PROVEEDOR = 0;
            this._NOMBRE_ASESOR = "";
            this._APELLIDO_ASESOR = "";
            this._NIT_EMPRESA = "";
            this._DIRECCION = "";
            this._TELEFONO = "";
            this._NOMBRE_EMPRESA = "";
            this._PRODUCTOS_OFRECE = "";

        }

        public modelProveedor(int ID_PROVEEDOR, String NOMBRE_ASESOR, String APELLIDO_ASESOR, String NIT_EMPRESA, String DIRECCION, String TELEFONO,String NOMBRE_EMPRESA,String PRODUCTOS_OFRECEN)
        {
            this._ID_PROVEEDOR = ID_PROVEEDOR;
            this._NOMBRE_ASESOR = NOMBRE_EMPRESA;
            this._APELLIDO_ASESOR = APELLIDO_ASESOR;
            this._NIT_EMPRESA = NIT_EMPRESA;
            this._DIRECCION = DIRECCION;
            this._TELEFONO = TELEFONO;
            this._NOMBRE_EMPRESA = NOMBRE_EMPRESA;
            this._PRODUCTOS_OFRECE = PRODUCTOS_OFRECEN;


        }


        public int ID_PROVEEDOR
        {
            get { return _ID_PROVEEDOR; }
            set { _ID_PROVEEDOR = value; }
        }

        public String NOMBRE_ASESOR
        {
            get { return _NOMBRE_ASESOR; }
            set { _NOMBRE_ASESOR = value; }
        }

        public String APELLIDO_ASESOR
        {
            get { return _APELLIDO_ASESOR; }
            set { _APELLIDO_ASESOR = value; }
        }

        public String NIT_EMPRESA
        {
            get { return _NIT_EMPRESA; }
            set { _NIT_EMPRESA = value; }
        }

        public String DIRECCION
        {
            get { return _DIRECCION; }
            set { _DIRECCION = value; }
        }

        public String TELEFONO
        {
            get { return _TELEFONO; }
            set { _TELEFONO = value; }
        }

        public String NOMBRE_EMPRESA
        {
            get { return _NOMBRE_EMPRESA; }
            set { _NOMBRE_EMPRESA = value; }
        }

        public String PRODUCTOS_OFRECE
        {
            get { return _PRODUCTOS_OFRECE; }
            set { _PRODUCTOS_OFRECE = value; }
        }

    }
}
