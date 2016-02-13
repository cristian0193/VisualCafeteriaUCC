using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public interface crudUsuarios
    {
        int insert(Object obj);
        int update(int identificacion, String nombre, String apellido, String direccion, String telefono_casa, String telefono_personal, String rol, String email, String imagen);
        int delete(int id);
        Object findById(int id);
    }
}
