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

namespace Project_CafeteriaUCC
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ctrlUsuario.insert(Convert.ToInt32(this.txt_usuario.Text), Convert.ToString(this.txt_contrasena.Text),"","","","","","","") > 0)
            {
                MessageBox.Show("Datos Guardados con Exito");
            }
            else
            {
                MessageBox.Show("Error al Guardar los Datos:");
            }
        }
    }
}
