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
    public class ctrlEmpresa
    {
        public static int insert(int identificacion, String nombre, String apellido, String direccion, String telefono_casa, String telefono_personal, String rol, String email, String imagen)
        {
            return new daoEmpresa().insert(new modelUsuario(identificacion, nombre, apellido, direccion, telefono_casa, telefono_personal, rol, email, imagen));
        }

        public static int update(int id_empresa, String nombre, String logo, String direccion, String email, String elefono)
        {
            return new daoEmpresa().update(id_empresa, nombre, logo, direccion, email, elefono);
        }

        public static int delete(int id)
        {
            return new daoEmpresa().delete(id);
        }

        public static modelEmpresa findById(int id)
        {
            return new daoEmpresa().findById(id) as modelEmpresa;
        }


    }
}
