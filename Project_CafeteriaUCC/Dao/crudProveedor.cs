using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public interface crudProveedor
    {
        int insertProveedor(string id_proveedor, String nombre_asesor, String apellido_asesor, String nit_empresa, String direccion, String telefono, String nombre_empresa, String productos_ofrece);
        int update(int id_proveedor, String nombre_asesor, String apellido_asesor, String nit_empresa, String direccion, String telefono, String nombre_empresa, String productos_ofrece);
        int delete(int id);
        Object findById(int id);
    }
}
