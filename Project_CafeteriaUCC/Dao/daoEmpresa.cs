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
    public class daoEmpresa : crudEmpresa
    {
        private ConexionBD conexion = new ConexionBD();

        public int insert(object obj)
        {

            try
            {
                if (obj is modelEmpresa)
                {
                    modelEmpresa newEmpresa = (modelEmpresa)obj;
                    String sql = String.Format("insert into dbo.EMPRESA values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", newEmpresa.NIT_EMPRESA, newEmpresa.NOMBRE_EMPRESA, newEmpresa.LOGO_EMPRESA, newEmpresa.EMAIL, newEmpresa.TELEFONO);
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

        public int update(int id_empresa, String nombre, String logo, String direccion, String email, String elefono)
        {
            try
            {
                String sql = String.Format(" UPDATE [dbo].[EMPRESA] SET  [NOMBRE_EMPRESA] = '{1}' ,[LOGO_EMPRESA] = '{2}', [DIRECCION] = '{3}',[EMAIL] = '{4}', [TELEFONO] = '{5}'  WHERE [NIT_EMPRESA] = {0}",
                                              id_empresa, nombre, logo,direccion,direccion,email,elefono);
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
                    String sql = String.Format("DELETE FROM dbo.EMPRESA WHERE NIT_EMPRESA = {0}", id);
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
                String sql = String.Format("SELECT * FROM dbo.EMPRESA");

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
                String sql = String.Format("SELECT * FROM dbo.EMPRESA where NIT_EMPRESA = {0}", id);

                DataTable tblResults = conexion.ExecuteQuery(sql);

                if (tblResults.Rows.Count > 0)
                {
                    DataRow row = tblResults.Rows[0];

                    modelEmpresa newEmpresa = new modelEmpresa()
                    {
                        NIT_EMPRESA = int.Parse(row["NIT_EMPRESA"].ToString()),
                        NOMBRE_EMPRESA = row["NOMBRE_EMPRESA"].ToString(),
                        LOGO_EMPRESA = row["LOGO_EMPRESA"].ToString(),
                        DIRECCION = row["DIRECCION"].ToString(),
                        EMAIL = row["EMAIL"].ToString(),
                        TELEFONO = row["TELEFONO"].ToString(),
                    };
                    return newEmpresa;
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

        public DataTable ConsultaVerificacionEmpresa(string identificacion)
        {
            DataTable dt = conexion.consulta("exec cons_verificacion_empresa '" + identificacion + "'");
            return dt;
        }
    }
}
