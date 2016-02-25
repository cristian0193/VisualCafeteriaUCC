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

            string usuario = "";
            string password = "";

            usuario = Convert.ToString(txt_usuario.Text);
            password = Convert.ToString(txt_contrasena.Text);


            if (usuario == "" || password.Equals(""))
            {
                MessageBox.Show("INGRESE USUARIO O CONTRASEÑA");
            }
             else
            {
                if (ctrlLogin.consultaSQLUsuarios(usuario, password) > 0)
                {

                    if (ctrlLogin.consultaSQLRoles(usuario, password).Equals("ADMINISTRADOR"))
                    {
                        FormularioAdministrador frmMenu = new FormularioAdministrador();
                        frmMenu.Show();

                        this.Hide();
                    }
                    else if (ctrlLogin.consultaSQLRoles(usuario, password).Equals("EMPLEADO"))
                    {
                        FormularioEmpleado frmMenu = new FormularioEmpleado();
                        frmMenu.Show();

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("USUARIO NO EXISTE EN BASE DE DATOS:");
                }
            }           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_nuevo_usuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioUsuariosAplicacion user = new FormularioUsuariosAplicacion();
            user.ShowDialog();
        }
    }
}
