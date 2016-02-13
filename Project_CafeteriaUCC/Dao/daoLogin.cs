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
    public class daoLogin : crudLogin
    {
        private ConexionBD conexion = new ConexionBD();
        public int contador = 0;
        public string roles = "";


        public int ConsultaUsuario(int usuario, string password)
        {
            try
            {
                String sql = String.Format("SELECT ID_USUARIO,NUMERO_IDENTIFICACION FROM dbo.USERS WHERE NUMERO_IDENTIFICACION = '" + usuario + "' AND CONTRASENA = '" + password + "'");

                DataTable tblResults = conexion.ExecuteQuery(sql);

                if (tblResults.Rows.Count > 0)
                {
                    contador++;
                    return contador;
                }
                else
                    return contador;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return 0;
            }
        }

        public string ConsultaRoles(int usuario, string password)
        {
            try
            {
                String sql = String.Format("SELECT ROL FROM dbo.USERS WHERE NUMERO_IDENTIFICACION = '" + usuario + "' AND CONTRASENA = '" + password + "'");

                DataTable tblResults = conexion.ExecuteQuery(sql);

                if (tblResults.Rows.Count > 0)
                {
                    DataRow row = tblResults.Rows[0];
                    roles = row["ROL"].ToString();
                    return roles;
                }
                else
                {
                    return "";
                }

            }
            catch (Exception ex)
            {

                throw new Exception(String.Format("Error desconocido {0} ", ex.Message));
            }



            //public object findById(int id)
            //{
            //    try
            //    {
            //        String sql = String.Format("SELECT * FROM dbo.INFO_USUARIOS where NUMERO_DOCUMENTO = {0}", id);

            //        DataTable tblResults = conexion.ExecuteQuery(sql);

            //        if (tblResults.Rows.Count > 0)
            //        {
            //            DataRow row = tblResults.Rows[0];

            //            modelUsuario newUsuarios = new modelUsuario()
            //            {
            //                ID_NUMERO_DOCUMENTO = int.Parse(row["NUMERO_DOCUMENTO"].ToString()),
            //                NOMBRES = row["NOMBRES"].ToString(),
            //                APELLIDOS = row["APELLIDOS"].ToString(),
            //                DIRECCION = row["DIRECCION"].ToString(),
            //                TELEFONO_CASA = row["TELEFONO_CASA"].ToString(),
            //                TELEFONO_PERSONAL = row["TELEFONO_PERSONAL"].ToString(),
            //                ROL = row["ROL"].ToString(),
            //                EMAIL = row["EMAIL"].ToString(),
            //                IMAGEN = row["IMAGEN"].ToString(),
            //            };
            //            return newUsuarios;
            //        }
            //        else
            //        {
            //            return null;
            //        }

            //    }
            //    catch (Exception ex)
            //    {

            //        throw new Exception(String.Format("Error desconocido {0} ", ex.Message));
            //    }
            //}

            //public object ConsultarSQL(int id)
            //{
            //    try
            //    {
            //        String sql = String.Format("SELECT * FROM dbo.INFO_USUARIOS WHERE NUMERO_DOCUMENTO = {0}", id);

            //        DataTable tblResults = conexion.ExecuteQuery(sql);

            //        if (tblResults.Rows.Count > 0)
            //        {
            //            DataRow row = tblResults.Rows[0];

            //            modelUsuario newUsuario = new modelUsuario()
            //            {
            //                ID_NUMERO_DOCUMENTO = int.Parse(row["NUMERO_DOCUMENTO"].ToString()),
            //                NOMBRES = row["NOMBRES"].ToString(),
            //                APELLIDOS = row["APELLIDOS"].ToString(),
            //                DIRECCION = row["DIRECCION"].ToString(),
            //                TELEFONO_CASA = row["TELEFONO_CASA"].ToString(),
            //                TELEFONO_PERSONAL = row["TELEFONO_PERSONAL"].ToString(),
            //                ROL = row["ROL"].ToString(),
            //                EMAIL = row["EMAIL"].ToString(),
            //                IMAGEN = row["IMAGEN"].ToString(),
            //            };
            //            return newUsuario;
            //        }
            //        else
            //        {
            //            return null;
            //        }

            //    }
            //    catch (Exception ex)
            //    {

            //        throw new Exception(String.Format("Error desconocido {0} ", ex.Message));
            //    }
            //}

            //public DataTable ConsultarSQLTodosLIKE(String nombre)
            //{
            //    try
            //    {
            //        String sql = String.Format("SELECT * FROM dbo.INFO_USUARIOS WHERE NUMERO_DOCUMENTO LIKE '%{0}%'", nombre);

            //        DataTable tblResults = conexion.ExecuteQuery(sql);

            //        if (tblResults.Rows.Count > 0)
            //        {
            //            return tblResults;
            //        }
            //        else
            //            return null;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.Write(ex.Message);
            //        return null;
            //    }
            //}

            //public DataTable findByIdDatabale(int id)
            //{
            //    try
            //    {
            //        String sql = String.Format("SELECT * FROM dbo.INFO_USUARIOS WHERE NUMERO_DOCUMENTO = {0}", id);

            //        DataTable tblResults = conexion.ExecuteQuery(sql);

            //        if (tblResults.Rows.Count > 0)
            //        {
            //            return tblResults;
            //        }
            //        else
            //            return null;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.Write(ex.Message);
            //        return null;
            //    }
            //}

            //public DataTable ConsultarSQLTodosLIKEParametros(String nombreColumnaTabla, String PalabraClave)
            //{
            //    try
            //    {
            //        String sql = String.Format("SELECT * FROM dbo.INFO_USUARIOS WHERE " + nombreColumnaTabla + " LIKE '%{0}%'", PalabraClave);

            //        DataTable tblResults = conexion.ExecuteQuery(sql);

            //        if (tblResults.Rows.Count > 0)
            //        {
            //            return tblResults;
            //        }
            //        else
            //            return null;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.Write(ex.Message);
            //        return null;
            //    }
            //}

            //public DataTable LlenarGridView()
            //{
            //    DataTable dt = conexion.consulta("exec consulta_estados");
            //    return dt;
            //}
        }
    }
}
