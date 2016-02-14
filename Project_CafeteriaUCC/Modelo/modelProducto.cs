using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modelProducto
    {
        private int _ID_PRODUCTO;
        private String _NOMBRE_PRODUCTO;
        private String _CATEGORIA;
        private Double _PRECIO;
        private int _CANTIDAD;

        public modelProducto()
        {
            this._ID_PRODUCTO = 0;
            this._NOMBRE_PRODUCTO = "";
            this._CATEGORIA = "";
            this._PRECIO = 0.0;
            this._CANTIDAD = 0;

        }

        public modelProducto(int ID_NUMERO_DOCUMENT, String NOMBRE, String CATEGORIA, Double PRECIO, int CANTIDAD)
        {
            this._ID_PRODUCTO = ID_NUMERO_DOCUMENT;
            this._NOMBRE_PRODUCTO = NOMBRE.ToUpper();
            this._CATEGORIA = CATEGORIA.ToUpper();
            this._PRECIO = PRECIO;
            this._CANTIDAD = CANTIDAD;
        }

        public int ID_PRODUCTO
        {
            get { return _ID_PRODUCTO; }
            set { _ID_PRODUCTO = value; }
        }

        public String NOMBRE
        {
            get { return _NOMBRE_PRODUCTO; }
            set { _NOMBRE_PRODUCTO = value; }
        }

        public String CATEGORIA
        {
            get { return _CATEGORIA; }
            set { _CATEGORIA = value; }
        }

        public Double PRECIO
        {
            get { return _PRECIO; }
            set { _PRECIO = value; }
        }

        public int CANTIDAD
        {
            get { return _CANTIDAD; }
            set { _CANTIDAD = value; }
        }

    }
}
