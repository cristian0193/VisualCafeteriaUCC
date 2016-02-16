using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public interface crudVenta
    {
        int insertVenta(String fecha, String numero_identificacion, String id_producto, String nombre_producto, String precio, String cantidad, Double subtotal, Double iva, Double total,int codigo_venta);
    }
}
