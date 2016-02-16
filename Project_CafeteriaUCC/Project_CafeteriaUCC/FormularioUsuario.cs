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
using System.IO;

namespace Project_CafeteriaUCC
{
    public partial class FormularioUsuario : Form
    {
        public FormularioUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daoUsuario usu = new daoUsuario();

            try
            {
                this.openFileDialog1.ShowDialog();

                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    caja_imagen.Load(this.openFileDialog1.FileName);
                    int cantoadro = usu.insertImagen(1256789,caja_imagen);
                    MessageBox.Show(""+ cantoadro);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("NO SE PUDO CARGAR LA IMAGEN");
            }

            







        }
    }
}