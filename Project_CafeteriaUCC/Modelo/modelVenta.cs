using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modelVenta
    {

        private int _ID_VENTA;
        private string _FECHA;
        private string _NUMERO_DOCUMENTO;
        private string _ID_PRODUCTO;
        private string _NOMBRE_PRODUCTO;
        private string _PRECIO;
        private string _CANTIDAD;
        private double _SUBTOTAL;
        private double _IVA;
        private double _TOTAL;
        private int _CODIGO_VENTA;


        public modelVenta()
        {
            this._ID_VENTA = 0;
            this._FECHA = "GETDATE()";
            this._NUMERO_DOCUMENTO = "";
            this._ID_PRODUCTO = "";
            this._NOMBRE_PRODUCTO = "";
            this._PRECIO = "";
            this._CANTIDAD = "";
            this._SUBTOTAL = 0.0;
            this._IVA = 0.0;
            this._TOTAL = 0.0;
            this._CODIGO_VENTA = 0;

        }

        public modelVenta(String FECHA, String NUMERO_DOCUMENTO, String ID_PRODUCTO, String NOMBRE_PRODUCTO, String PRECIO,String CANTIDAD, Double SUBTOTAL, Double IVA, Double TOTAL,int CODIGO_VENTA)
        {
            this._FECHA = FECHA;
            this._NUMERO_DOCUMENTO = NUMERO_DOCUMENTO;
            this._ID_PRODUCTO = ID_PRODUCTO;
            this._NOMBRE_PRODUCTO = NOMBRE_PRODUCTO;
            this._PRECIO = PRECIO;
            this._CANTIDAD = CANTIDAD;
            this._SUBTOTAL = SUBTOTAL;
            this._IVA = IVA;
            this._TOTAL = TOTAL;
            this._CODIGO_VENTA = CODIGO_VENTA;


        }


        public String FECHA
        {
            get { return _FECHA; }
            set { _FECHA = value; }
        }

        public String NUMERO_DOCUMENTO
        {
            get { return _NUMERO_DOCUMENTO; }
            set { _NUMERO_DOCUMENTO = value; }
        }


        public String ID_PRODUCTO
        {
            get { return _ID_PRODUCTO; }
            set { _ID_PRODUCTO = value; }
        }

        public String NOMBRE_PRODUCTO
        {
            get { return _NOMBRE_PRODUCTO; }
            set { _NOMBRE_PRODUCTO = value; }
        }

        public String PRECIO
        {
            get { return _PRECIO; }
            set { _PRECIO = value; }
        }

        public String CANTIDAD
        {
            get { return _CANTIDAD; }
            set { _CANTIDAD = value; }
        }

        public Double SUBTOTAL
        {
            get { return _SUBTOTAL; }
            set { _SUBTOTAL = value; }
        }

        public Double IVA
        {
            get { return _IVA; }
            set { _IVA = value; }
        }

        public Double TOTAL
        {
            get { return _TOTAL; }
            set { _TOTAL = value; }
        }

        public int CODIGO_VENTA
        {
            get { return _CODIGO_VENTA; }
            set { _CODIGO_VENTA = value; }
        }



    }
}
