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
   public class ctrlVenta
    {
        public static int insertVenta(String fecha, String numero_identificacion, String id_producto, String nombre_producto,String precio,String cantidad, Double subtotal, Double iva, Double total,int codigo_venta)
        {
            return new daoVenta().insertVenta(fecha, numero_identificacion, id_producto, nombre_producto, precio, cantidad, subtotal, iva, total, codigo_venta);
        }
    }
}
