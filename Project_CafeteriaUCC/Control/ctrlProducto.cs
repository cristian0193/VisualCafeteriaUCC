using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Dao;
using Control;
namespace Control
{
    public class ctrlProducto
    {
        public static int insert(int id_codigo,string nombre_producto,string categoria,double precio, int cantidad)
        {
            return new daoProductos().insert(new modelProducto(id_codigo,nombre_producto,categoria,precio,cantidad));
        }

        public static int update(int id_proveedor, String nombre_asesor, String apellido_asesor, String nit_empresa, String direccion, String telefono, String nombre_empresa, String productos_ofrece)
        {
            return new daoProveedor().update(id_proveedor, nombre_asesor, apellido_asesor, nit_empresa, direccion, telefono, nombre_empresa, productos_ofrece);
        }

        public static int delete(int id)
        {
            return new daoProveedor().delete(id);
        }

        public static modelProveedor findById(int id)
        {
            return new daoProveedor().findById(id) as modelProveedor;
        }


    }
}
