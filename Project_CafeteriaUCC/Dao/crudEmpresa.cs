using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public interface crudEmpresa
    {
        int insert(Object obj);
        int update(int id_empresa, String nombre, String logo, String direccion, String email, String elefono);
        int delete(int id);
        Object findById(int id);
    }
}
