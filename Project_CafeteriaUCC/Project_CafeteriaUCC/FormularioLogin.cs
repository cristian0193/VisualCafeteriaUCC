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

            int usuario = Convert.ToInt32(this.txt_usuario.Text);
            string password = Convert.ToString(this.txt_contrasena.Text);


            if (usuario.Equals("") || password.Equals(""))
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

                        FormularioLogin frmLogin = new FormularioLogin();
                        frmLogin.Visible = false;
                        
                    }
                    else if (ctrlLogin.consultaSQLRoles(usuario, password).Equals("EMPLEADO"))
                    {
                        FormularioEmpleado frmMenu = new FormularioEmpleado();
                        frmMenu.Show();

                        FormularioLogin frmLogin = new FormularioLogin();
                        frmLogin.Visible = false;
                    }


                }
                else
                {
                    MessageBox.Show("USUARIO NO EXISTE EN BASE DE DATOS:");
                }
            }


           
        }
    }
}
