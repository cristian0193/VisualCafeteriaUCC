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
    public class daoProductos : crudProductos
    {
        private ConexionBD conexion = new ConexionBD();

        public int insert(object obj)
        {

            try
            {
                if (obj is modelProducto)
                {
                    modelProducto newProducto = (modelProducto)obj;
                    String sql = String.Format("insert into dbo.PRODUCTOS values ({0},'{1}','{2}',{3},{4})", newProducto.ID_PRODUCTO, newProducto.NOMBRE, newProducto.CATEGORIA, newProducto.PRECIO, newProducto.CANTIDAD);
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

        public int update(int identificacion, String nombre, String categoria, double precio, int cantidad)
        {
            try
            {
                String sql = String.Format(" UPDATE [dbo].[PRODUCTOS] SET  [NOMBRE_PRODUCTO] = '{1}' ,[CATEGORIA_PRODUCTO] = '{2}', [PRECIO] = {3},[CANTIDAD] = {4} WHERE [ID_PRODUCTO] = {0}",
                                              identificacion, nombre, categoria, precio, cantidad);
                Console.Write(sql);
                return conexion.ExecuteStatementNoneReturnRows(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("EstadoDao: " + ex.Message);
            }
        }

        public int delete(int id)
        {
            try
            {
                if (!id.Equals(""))
                {
                    String sql = String.Format("DELETE FROM dbo.PRODUCTOS WHERE ID_PRODUCTO = {0}", id);
                    return conexion.ExecuteStatementNoneReturnRows(sql);
                }
                else
                {
                    throw new Exception("Estado de ID no valido");
                }
            }
            catch (Exception ex)
            {

                throw new Exception("EstadoDao: " + ex.Message);
            }
        }

        public DataTable ConsultarSQLTodos()
        {
            try
            {
                String sql = String.Format("SELECT * FROM dbo.PRODUCTOS");

                DataTable tblResults = conexion.ExecuteQuery(sql);

                if (tblResults.Rows.Count > 0)
                {
                    return tblResults;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }
        }

        public DataTable ConsultarCategoriaSQL(String categoria)
        {
            try
            {
                String sql = String.Format("SELECT NOMBRE_PRODUCTO FROM [dbo].[PRODUCTOS] WHERE CATEGORIA_PRODUCTO = '{0}';", categoria);

                DataTable tblResults = conexion.ExecuteQuery(sql);

                if (tblResults.Rows.Count > 0)
                {
                    return tblResults;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }
        }

        public DataTable findByIdDatabale(int id)
        {
            try
            {
                String sql = String.Format("SELECT * FROM dbo.PRODUCTO WHERE ID_PRODCUTO = {0}", id);

                DataTable tblResults = conexion.ExecuteQuery(sql);

                if (tblResults.Rows.Count > 0)
                {
                    return tblResults;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }
        }

        public DataTable ConsultarCategoria(string categoria)
        {
            DataTable dt = conexion.consulta("exec cons_producto_categoria '"+ categoria + "'");
            return dt;
        }

        public DataTable ConsultarPrecio(string producto,string categoria)
        {
            DataTable dt = conexion.consulta("exec cons_precio_producto '" + producto + "','"+ categoria  + "'");
            return dt;
        }

        public DataTable ConsultarCodigoProducto(string producto, string categoria)
        {
            DataTable dt = conexion.consulta("exec cons_codigo_producto '" + producto + "','" + categoria + "'");
            return dt;
        }

        public DataTable ConsultarProduto(int codigo)
        {
            DataTable dt = conexion.consulta("exec consultar_producto '" + codigo + "'");
            return dt;
        }

        public DataTable ConsultarTodosProdutos()
        {
            DataTable dt = conexion.consulta("exec consultar_todos_productos");
            return dt;
        }

        //public DataTable InsertarVenta(string fecha, string numero_documento,string id_producto, string nombre_producto, string precio, string cantidad, string subtotal, string iva,string total)
        //{
        //    String sql = "exec insert_venta " + fecha + "," + numero_documento + "," + id_producto + ",'" + nombre_producto + "'," + precio + "," + cantidad + "," + subtotal + "," + iva + "," + total + "";
        //    DataTable dt = conexion.consulta(sql);
        //    return dt;
        //}

    }



}
