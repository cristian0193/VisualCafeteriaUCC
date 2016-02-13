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
    public class ctrlLogin
    {

        public static int consultaSQLUsuarios(int identificacion, String password)
        {
            return new daoLogin().ConsultaUsuario(identificacion,password);
        }

        public static string consultaSQLRoles(int identificacion, String password)
        {
            return new daoLogin().ConsultaRoles(identificacion, password);
        }

    }
}
