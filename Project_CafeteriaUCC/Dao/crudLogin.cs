using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public interface crudLogin
    {
        //int insert(Object obj);
        //int update( String usuario, String password);
        //int delete(int id);
        int ConsultaUsuario(int identificacion,String password);
        string ConsultaRoles(int identificacion, String password);
        //Object findById(int id);
    }
}
