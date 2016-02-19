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
            
            FormularioFacturas facturas = new FormularioFacturas();
            facturas.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioUsuarios usuario = new FormularioUsuarios();
            usuario.Show();
        }

        private void fACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioVenta venta = new FormularioVenta();
            venta.Show();
        }

        private void eMPRESAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioEmpresa empresa = new FormularioEmpresa();
            empresa.Show();
        }
    }
}
