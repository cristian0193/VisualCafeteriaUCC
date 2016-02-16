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
        public string cadena = "";

        public int insertVenta(String fecha, String numero_identificacion, String id_producto, String nombre_producto, String precio, String cantidad, Double subtotal, Double iva, Double total,int codigo_venta)
        {
            try
            {
                if (true)
                {
              
                    string sql = "INSERT INTO[dbo].[VENTA] ([FECHA],[NUMERO_DOCUMENTO],[ID_PRODUCTO],[NOMBRE_PRODUCTO],[PRECIO] ,[CANTIDAD],[SUBTOTAL],[IVA],[TOTAL],[CODIGO_VENTA]) VALUES(" + fecha+","+ numero_identificacion+","+ id_producto + ",'" + nombre_producto + "',"+precio+","+cantidad+","+ subtotal.ToString().Replace(",", ".") + ","+ iva.ToString().Replace(",", ".") + ","+ total.ToString().Replace(",", ".") + ","+codigo_venta+")";                    
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

        public DataTable ConsultaCodigoVenta()
        {
            DataTable dt = conexion.consulta("exec consulta_codigo_mayor_venta");
            return dt;
        }

    }

}
