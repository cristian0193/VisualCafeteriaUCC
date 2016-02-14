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
    public class ctrlCantidad
    {
        public static int insert(int identificacion, String nombre, String categoria, double precio, int cantidad)
        {
            return new daoProductos().insert(new modelProducto(identificacion, nombre, categoria, precio, cantidad));
        }

        public static int update(int identificacion, String nombre, String categoria, double precio, int cantidad)
        {
            return new daoProductos().update(identificacion, nombre, categoria, precio, cantidad);
        }

        public static int delete(int id)
        {
            return new daoProductos().delete(id);
        }

        //public static modelProducto findById(int id)
        //{
        //    return new daoProductos().findById(id) as modelProducto;
        //}

        //public static modelProducto ConsultarSQL(int id)
        //{
        //    return new daoProductos().ConsultarSQL(id) as modelProducto;
        //}
    }
}
