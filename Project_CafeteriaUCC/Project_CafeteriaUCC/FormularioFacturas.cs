using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Project_CafeteriaUCC
{
    public partial class FormularioFacturas : Form
    {
        public FormularioFacturas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.txt_numero_factura.Text);

            daoVenta venta = new daoVenta();
            DataTable consultarFacturaExistente = new DataTable();
            consultarFacturaExistente = venta.ConsultarVentaExistente(codigo);

            if (consultarFacturaExistente.Rows.Count > 0 && !codigo.Equals(""))
            {
                DataTable detalleFactura = new DataTable();
                detalleFactura = venta.ConsultaVenta(codigo);

                data_grid_producto.DataSource = detalleFactura;

                DataTable sumatoriasValores = new DataTable();
                sumatoriasValores = venta.ConsultarSumaVentas(codigo);

                double subtotales = Convert.ToDouble((sumatoriasValores.Rows[0]["SUMA_SUBTOTAL"].ToString()));
                double iva = Convert.ToDouble((sumatoriasValores.Rows[0]["SUMA_IVA"].ToString()));
                double total = Convert.ToDouble((sumatoriasValores.Rows[0]["SUMA_TOTAL"].ToString()));
                string cliente = sumatoriasValores.Rows[0]["NOMBRES"].ToString();

                txt_subtotal.Text = Convert.ToString(subtotales);
                txt_iva.Text = Convert.ToString(iva);
                txt_totales.Text = Convert.ToString(total);
                txt_cliente.Text = Convert.ToString(cliente);

            }
            else
            {
                MessageBox.Show("NO EXISTE FACTURA EN BASE DE DATOS");
            }


           


        }
    }
}
