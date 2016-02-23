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
        public static int insert(String identificacion, String nombre, String categoria, double precio, int cantidad)
        {
            return new daoProductos().insert(new modelProducto(identificacion, nombre, categoria, precio, cantidad));
        }

        public static int update(String identificacion, String nombre, String categoria, double precio, int cantidad)
        {
            return new daoProductos().update(identificacion, nombre, categoria, precio, cantidad);
        }

        public static int delete(int id)
        {
            return new daoProductos().delete(id);
        }

    }
}
