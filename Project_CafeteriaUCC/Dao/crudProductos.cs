using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public interface crudProductos
    {
        int insert(Object obj);
        int update(String identificacion, String nombre, String categoria , Double precio, int cantidad);
        int delete(int id);
    }
}
