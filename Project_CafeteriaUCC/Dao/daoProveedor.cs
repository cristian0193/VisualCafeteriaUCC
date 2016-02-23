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
using System.IO;
using System.Windows.Forms;


namespace Dao
{
    public class daoProveedor : crudProveedor
    {
        private ConexionBD conexion = new ConexionBD();

        public int insertProveedor(String id_proveedor, String nombre_asesor, String apellido_asesor, String nit_empresa, String direccion, String telefono, String nombre_empresa, String producto_ofrece)
        {
            try
            {
                if (true)
                {
                    string sql = "INSERT INTO[dbo].[PROVEEDOR] ([ID_PROVEEDOR],[NOMBRE_ASESOR],[APELLIDO_ASESOR],[NIT_EMPRESA],[DIRECCION] ,[TELEFONO],[NOMBRE_EMPRESA],[PRODUCTOS_OFRECE]) VALUES(" + id_proveedor + ",'" + nombre_asesor + "','" + apellido_asesor + "','" + nit_empresa + "','" + direccion + "','" + telefono + "','" + nombre_empresa + "','" + producto_ofrece + "')";
                    return conexion.ExecuteStatementNoneReturnRows(sql);
                }
                else
                {
                    throw new Exception("Proveedor de objeto no valido");
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ProveedorDao: " + ex.Message);

            }
        }

        public int update(int id_proveedor, String nombre_asesor, String apellido_asesor, String nit_empresa, String direccion, String telefono,String nombre_empresa,String productos_ofrece)
        {
            try
            {
                String sql = String.Format(" UPDATE [dbo].[PROVEEDOR] SET  [NOMBRE_ASESOR] = '{1}' ,[APELLIDO_ASESOR] = '{2}', [NIT_EMPRESA] = {3},[DIRECCION] = '{4}', [TELEFONO] = '{5}', [NOMBRE_EMPRESA] = '{6}', [PRODUCTOS_OFRECE] = '{7}'  WHERE [ID_PROVEEDOR] = {0}",
                                              id_proveedor, nombre_asesor, apellido_asesor, nit_empresa, direccion, telefono, nombre_empresa, productos_ofrece);
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
                    String sql = String.Format("DELETE FROM dbo.PROVEEDOR WHERE ID_PROVEEDOR = {0}", id);
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
                String sql = String.Format("SELECT * FROM dbo.PROVEEDOR");

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

        public object findById(int id)
        {
            try
            {
                String sql = String.Format("SELECT * FROM dbo.PROVEEDOR where ID_PROVEEDOR = {0}", id);

                DataTable tblResults = conexion.ExecuteQuery(sql);

                if (tblResults.Rows.Count > 0)
                {
                    DataRow row = tblResults.Rows[0];

                    modelProveedor newProveedor = new modelProveedor()
                    {
                        ID_PROVEEDOR = int.Parse(row["ID_PROVEEDOR"].ToString()),
                        NOMBRE_ASESOR = row["NOMBRE_ASESOR"].ToString(),
                        APELLIDO_ASESOR = row["APELLIDO_ASESOR"].ToString(),
                        NIT_EMPRESA = row["NIT_EMPRESA"].ToString(),
                        DIRECCION = row["DIRECCION"].ToString(),
                        TELEFONO = row["TELEFONO"].ToString(),
                        NOMBRE_EMPRESA = row["NOMBRE_EMPRESA"].ToString(),
                        PRODUCTOS_OFRECE = row["PRODUCTOS_OFRECE"].ToString(),
                    };
                    return newProveedor;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(String.Format("Error desconocido {0} ", ex.Message));
            }
        }
        
        public DataTable ConsultarProveedor(string id_proveedor)
        {
            DataTable dt = conexion.consulta("exec consulta_proveedor '" + id_proveedor + "'");
            return dt;
        }


    }
}
