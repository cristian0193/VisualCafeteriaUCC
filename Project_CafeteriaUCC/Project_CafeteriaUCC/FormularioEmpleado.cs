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
    public partial class FormularioEmpleado : Form
    {
        public FormularioEmpleado()
        {
            InitializeComponent();
        }

        private void fACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioFacturas facturas = new FormularioFacturas();
            facturas.Show();
        }

        private void vENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioVenta venta = new FormularioVenta();
            venta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioLogin login = new FormularioLogin();
            login.Show();
        }
    }
}
