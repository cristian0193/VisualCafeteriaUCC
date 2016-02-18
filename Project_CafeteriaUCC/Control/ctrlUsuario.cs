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
    public class ctrlUsuario
    {
        public static int insert(int identificacion, String nombre, String apellido, String direccion, String telefono_casa, String telefono_personal, String rol, String email, String imagen)
        {
            return new daoUsuario().insert(new modelUsuario(identificacion, nombre, apellido, direccion, telefono_casa, telefono_personal, rol, email, imagen));
        }

        public static int update(int identificacion, String nombre, String apellido, String direccion, String telefono_casa, String telefono_personal, String rol, String email, String imagen)
        {
            return new daoUsuario().update(identificacion,nombre,apellido,direccion,telefono_casa,telefono_personal,rol,email,imagen);
        }

        public static int delete(int id)
        {
            return new daoUsuario().delete(id);
        }

        public static modelUsuario findById(int id)
        {
            return new daoUsuario().findById(id) as modelUsuario;
        }

        public static modelUsuario ConsultarSQL(int id)
        {
            return new daoUsuario().ConsultarSQL(id) as modelUsuario;
        }
    }
}
