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

namespace Project_CafeteriaUCC
{
    public partial class FormularioProducto : Form
    {
        public FormularioProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            daoProductos producto = new daoProductos();
            DataTable consuta_producto = new DataTable();

            int codigo_producto = 0;
            string nombre_producto = "";
            string categoria = "";
            double precio = 0.0;
            int cantidad = 0;
            int registro = 0;

            codigo_producto = Convert.ToInt32(txt_codigo_producto.Text);

            consuta_producto = producto.ConsultarProduto(codigo_producto);

            if (consuta_producto.Rows.Count > 0)
            {
                MessageBox.Show("YA SE ENCUENTRA EL PRODUCTO REGISTRADO");
            }
            else
            {
                nombre_producto = Convert.ToString(txt_nombre_producto.Text);
                categoria = Convert.ToString(combo_categoria.SelectedItem.ToString());
                precio = Convert.ToDouble(txt_precio.Text);
                cantidad = Convert.ToInt32(txt_cantidad.Text);

                registro = ctrlProducto.insert(codigo_producto, nombre_producto, categoria, precio, cantidad);

                if (registro > 0)
                {
                    MessageBox.Show("PRODUCTO INGRESADO CORRECTAMENTE");

                    DataTable todosProdcutos = new DataTable();
                    todosProdcutos = producto.ConsultarTodosProdutos();

                    carga_productos.DataSource = todosProdcutos;

                    txt_codigo_producto.Text = "";
                    txt_nombre_producto.Text = "";
                    txt_cantidad.Text = "";
                    txt_precio.Text = "";
                    combo_categoria.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("PRODCUTO NO INGRESADO ");
                }
            }



            


        }
    }
}
