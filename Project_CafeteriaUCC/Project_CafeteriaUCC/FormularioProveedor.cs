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
using Control;


namespace Project_CafeteriaUCC
{
    public partial class FormularioProveedor : Form
    {
        public FormularioProveedor()
        {
            InitializeComponent();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {


            int id_proveedor = 0;
            string nombre_asesor = "";
            string apellido_asesor = "";
            string nit_empresa = "";
            string direccion = "";
            string telefono = "";
            string nombre_empresa = "";
            string productos = "";
            int registros = 0;

            id_proveedor = Convert.ToInt32(txt_id_proveedor.Text);
            nombre_asesor = Convert.ToString(txt_nombre_asesor.Text);
            apellido_asesor = Convert.ToString(txt_apellido_asesor.Text);
            nit_empresa = Convert.ToString(combo_nit_empresa.SelectedItem.ToString());
            direccion = Convert.ToString(txt_direccion.Text);
            telefono = Convert.ToString(txt_telefono);
            nombre_empresa = Convert.ToString(txt_nombre_empresa.Text);
            productos = Convert.ToString(txt_productos.Text);

            daoProveedor proveedor = new daoProveedor();
            DataTable idproveedor = new DataTable();

            registros = proveedor.insertProveedor(id_proveedor, nombre_asesor, apellido_asesor, nit_empresa, direccion, telefono, nombre_asesor, productos);
            idproveedor = proveedor.ConsultarProveedor(id_proveedor);

            if (idproveedor.Rows.Count > 0)
            {
                MessageBox.Show("El Proveedro ya se encuentra Registrado");
            }
            else
            {
                if (registros == 0)
                {
                    MessageBox.Show("No Se Ingreso proveedor");
                }
                else
                {
                    MessageBox.Show("Se Ingreso proveedor Correctamente");
                }
            }

        }
    }
}
