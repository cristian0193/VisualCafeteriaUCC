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

        daoEmpresa empresa = new daoEmpresa();

        public FormularioProveedor()
        {
            InitializeComponent();



            // carga de Combobox con producto
            DataTable tabla_nit_empresa = new DataTable();
            combo_nit_empresa.Items.Clear();
            combo_nit_empresa.SelectedItem = "";
            tabla_nit_empresa = empresa.ConsultaNitEmpresa();

            foreach (DataRow dat in tabla_nit_empresa.Rows)
            {
                combo_nit_empresa.Items.Add(dat[0]);
            }

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


            daoProveedor proveedor = new daoProveedor();
            DataTable idproveedor = new DataTable();

            idproveedor = proveedor.ConsultarProveedor(id_proveedor);
            

            if (idproveedor.Rows.Count > 0)
            {
                MessageBox.Show("El Proveedro ya se encuentra Registrado");
            }
            else
            {
                nombre_asesor = Convert.ToString(txt_nombre_asesor.Text);
                apellido_asesor = Convert.ToString(txt_apellido_asesor.Text);
                nit_empresa = Convert.ToString(combo_nit_empresa.SelectedItem.ToString());
                direccion = Convert.ToString(txt_direccion.Text);
                telefono = Convert.ToString(txt_telefono.Text);
                nombre_empresa = Convert.ToString(txt_nombre_empresa.Text);
                productos = Convert.ToString(txt_productos.Text);

                registros = proveedor.insertProveedor(id_proveedor, nombre_asesor, apellido_asesor, nit_empresa, direccion, telefono, nombre_asesor, productos);
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


        private void combo_nit_empresa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string nombre_empresa = "";

            String nit_empresa = Convert.ToString(this.combo_nit_empresa.SelectedItem);

            // carga de Combobox con producto
            DataTable tabla_empresa = new DataTable();
            tabla_empresa = empresa.ConsultaNombreEmpresa(nit_empresa);
            nombre_empresa = Convert.ToString(tabla_empresa.Rows[0]["NOMBRE_EMPRESA"].ToString());

            txt_nombre_empresa.Text = nombre_empresa;
        }
    }
}
