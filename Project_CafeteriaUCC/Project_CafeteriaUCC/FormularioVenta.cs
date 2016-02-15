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
using Microsoft.VisualBasic;

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
            int codigo = 0;

            String categoria = Convert.ToString(this.combo_categoria.SelectedItem);
            String nombre_producto = Convert.ToString(this.combo_producto.SelectedItem);
            int cantidad = Convert.ToInt32(this.txt_cantidad.Text);
            
            DataTable precio = new DataTable();
            precio = producto.ConsultarPrecio(nombre_producto,categoria);
            precio_producto = Convert.ToDouble((precio.Rows[0]["PRECIO"].ToString()));

            DataTable codigo_producto = new DataTable();
            codigo_producto = producto.ConsultarCodigoProducto(nombre_producto, categoria);
            codigo = Convert.ToInt32((codigo_producto.Rows[0]["ID_PRODUCTO"].ToString()));


            double total = 0.0;
            total = precio_producto * cantidad;

            grid_productos.Rows.Add(codigo, nombre_producto, cantidad, precio_producto, total);

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

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            string identifica = "";
            string nombre = "";
            string apellido = "";
            string id_product = "";
            string nombre_producto = "";
            string precio = "";
            string cantidad = "";
            double subtotal = 0.0;
            double iva = 0.0;
            double total = 0.0;
            string fecha = "GETDATE()";
            int productosComprados = 0;


            string cedula = Interaction.InputBox("Ingrese Cedular del Cliente para Verificar si se encuentra en la Base de Datos", "Verificacion de Cliente", "");


            daoUsuario usuario = new daoUsuario();
            daoVenta venta = new daoVenta();
            DataTable verificacion_usuario = new DataTable();
            verificacion_usuario = usuario.ConsultaVerificacionUsuario(cedula);

            if (verificacion_usuario.Rows.Count > 0)
            {
                identifica = Convert.ToString((verificacion_usuario.Rows[0]["NUMERO_DOCUMENTO"].ToString()));
                nombre = Convert.ToString((verificacion_usuario.Rows[0]["NOMBRES"].ToString()));
                apellido = Convert.ToString((verificacion_usuario.Rows[0]["APELLIDOS"].ToString()));

                subtotal = Convert.ToDouble(txt_subtotal.Text);
                iva = Convert.ToDouble(txt_iva.Text);
                total = Convert.ToDouble(txt_total.Text);

                foreach (DataGridViewRow row in grid_productos.Rows)
                {
                    id_product = Convert.ToString(row.Cells["CODIGO"].Value);
                    nombre_producto = Convert.ToString(row.Cells["PROD"].Value);
                    precio = Convert.ToString(row.Cells["PRECIO"].Value);
                    cantidad = Convert.ToString(row.Cells["CO"].Value);


                    productosComprados += venta.insertVenta(fecha, identifica, id_product, nombre_producto, precio, cantidad, subtotal, iva, total);

                }

                string mensaje = string.Format("MUCHAS GRACIAS POR SU COMPRA{0} Identificacion : {1}{0}Nombre : {2}{0}Apellido : {3}{0}Prodcutos Comprados : {4} ", Environment.NewLine, identifica, nombre, apellido, productosComprados);
                MessageBox.Show(mensaje);

            }
            else
            {
                MessageBox.Show("USUARIO NO REGISTRADO POR FAVOR PROCESA A INGRESARLO");

                FormularioUsuario user = new FormularioUsuario();
                user.Show();
            }



            

        }
    }
}
