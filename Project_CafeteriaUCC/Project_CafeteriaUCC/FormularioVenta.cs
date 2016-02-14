using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Dao;
using System.Data.SqlClient;

namespace Project_CafeteriaUCC
{
    public partial class FormularioVenta : Form
    {
        daoProductos producto = new daoProductos();

        public FormularioVenta()
        {
            InitializeComponent();
        }

        private void combo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            String categoria = Convert.ToString(this.combo_categoria.SelectedItem);

            // carga de Combobox con producto
            DataTable tabla_categoria = new DataTable();
            combo_producto.Items.Clear();
            combo_producto.SelectedItem = "";
            tabla_categoria = producto.ConsultarCategoria(categoria);

            foreach (DataRow dat in tabla_categoria.Rows)
            {
                combo_producto.Items.Add(dat[0]);
            }

        }

        private void btn_registrar_producto_Click(object sender, EventArgs e)
        {
            double precio_producto = 0.0;

            String categoria = Convert.ToString(this.combo_categoria.SelectedItem);
            String nombre_producto = Convert.ToString(this.combo_producto.SelectedItem);
            int cantidad = Convert.ToInt32(this.txt_cantidad.Text);
            
            DataTable precio = new DataTable();
            precio = producto.ConsultarPrecio(nombre_producto,categoria);

            precio_producto = Convert.ToDouble((precio.Rows[0]["PRECIO"].ToString()));

            double total = 0.0;
            total = precio_producto * cantidad;

            grid_productos.Rows.Add(nombre_producto, cantidad, precio_producto, total);

            double subtotal = 0;
            double iva = 0;
            double totaApagar = 0;

            foreach (DataGridViewRow row in grid_productos.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["TOTAL"].Value);
            }

            txt_subtotal.Text = Convert.ToString(subtotal);

            iva = subtotal * 0.16;
            txt_iva.Text = Convert.ToString(iva);

            totaApagar = subtotal + iva;
            txt_total.Text = Convert.ToString(totaApagar);

            txt_cantidad.Text = "";
            combo_categoria.SelectedIndex = -1;
            combo_producto.Items.Clear();


        }
    }
}
