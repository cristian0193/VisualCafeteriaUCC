using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Dao;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Dao
{
    public class daoVenta : crudVenta
    {
        private ConexionBD conexion = new ConexionBD();

        public int insertVenta(String fecha, String numero_identificacion, String id_producto, String nombre_producto, String precio, String cantidad, Double subtotal, Double iva, Double total)
        {
            try
            {
                if (true)
                {
                    string sql = "INSERT INTO[dbo].[VENTA] values ("+ fecha+ ","+ numero_identificacion + "," + id_producto + ", '" + nombre_producto + "' ," + precio + "," + cantidad + ",'" + subtotal + "','" + iva + "','" + total + "')";
                    return conexion.ExecuteStatementNoneReturnRows(sql);
                }
                else
                {
                    throw new Exception("Usuario de objeto no valido");
                }
            }
            catch (Exception ex)
            {

                throw new Exception("UsuarioDao: " + ex.Message);

            }
        }
       
    }

}
