using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CafeteriaUCC
{
    public partial class FormularioAdministrador : Form
    {
        public FormularioAdministrador()
        {
            InitializeComponent();
        }

        private void vENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioVenta venta = new FormularioVenta();
            venta.ShowDialog();
            venta.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormularioUsuarios usuario = new FormularioUsuarios();
            usuario.ShowDialog();
            usuario.Show();
        }

        private void fACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioFacturas facturas = new FormularioFacturas();
            facturas.ShowDialog();
            facturas.Show();
        }

        private void eMPRESAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEmpresa empresa = new FormularioEmpresa();
            empresa.ShowDialog();
            empresa.Show();
        }

        private void pROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioProveedor proveedor = new FormularioProveedor();
            proveedor.ShowDialog();
            proveedor.Show();
            
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioProducto prodcuto = new FormularioProducto();
            prodcuto.ShowDialog();
            prodcuto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioLogin login = new FormularioLogin();
            login.Show();
        }
    }
}
