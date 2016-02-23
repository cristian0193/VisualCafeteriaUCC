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

namespace Project_CafeteriaUCC
{
    public partial class FormularioUsuariosAplicacion : Form
    {
        public FormularioUsuariosAplicacion()
        {
            InitializeComponent();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {

            string identi = "";
            identi = txt_identificacion.Text;

            daoUsuario usuario = new daoUsuario();
            DataTable consultaUsuario = new DataTable();
            consultaUsuario = usuario.ConsultaVerificacionUSERS(identi);


            if (!txt_identificacion.Text.Equals("") && !combo_roles.SelectedIndex.Equals(-1) && !txt_nombre.Text.Equals("") && !txt_apellidos.Text.Equals("") && !txt_contrasena.Text.Equals(""))
            {

                if (consultaUsuario.Rows.Count <= 0)
                {
                    try
                    {
                        // Objetos de conexión y comando               
                        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=ASUS\ASUS;Initial Catalog=DBcafeteria;Integrated Security=SSPI");
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                        // Estableciento propiedades
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO [dbo].[USERS] VALUES (@numero, @nombre, @apellido, @direccion,@telefono,@email,@rol,@image,@contraseña)";

                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@numero", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                        cmd.Parameters.Add("@apellido", System.Data.SqlDbType.NVarChar);
                        cmd.Parameters.Add("@direccion", System.Data.SqlDbType.NVarChar);
                        cmd.Parameters.Add("@telefono", System.Data.SqlDbType.NVarChar);
                        cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar);
                        cmd.Parameters.Add("@rol", System.Data.SqlDbType.NVarChar);
                        cmd.Parameters.Add("@image", System.Data.SqlDbType.Image);
                        cmd.Parameters.Add("@contraseña", System.Data.SqlDbType.NVarChar);

                        // Asignando los valores a los atributos
                        cmd.Parameters["@numero"].Value = int.Parse(txt_identificacion.Text);
                        cmd.Parameters["@nombre"].Value = txt_nombre.Text;
                        cmd.Parameters["@apellido"].Value = txt_apellidos.Text;
                        cmd.Parameters["@direccion"].Value = txt_direccion.Text;
                        cmd.Parameters["@telefono"].Value = txt_telefono.Text;
                        cmd.Parameters["@email"].Value = txt_email.Text;
                        cmd.Parameters["@rol"].Value = combo_roles.SelectedItem.ToString();
                        cmd.Parameters["@contraseña"].Value = txt_contrasena.Text;

                        // Asignando el valor de la imagen

                        // Stream usado como buffer
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        // Se guarda la imagen en el buffer
                        caja_imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        // Se extraen los bytes del buffer para asignarlos como valor para el 
                        // parámetro.
                        cmd.Parameters["@image"].Value = ms.GetBuffer();

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        txt_identificacion.Text = "";
                        txt_nombre.Text = "";
                        txt_apellidos.Text = "";
                        txt_direccion.Text = "";
                        txt_telefono.Text = "";
                        txt_email.Text = "";
                        combo_roles.SelectedIndex = -1;
                        txt_contrasena.Text = "";
                        caja_imagen.Image = null;


                        MessageBox.Show("El USERS Se ingreso Correctamente");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("El USERS Ya se encuenta en la base de Datos");
                }

            }
            else
            {
                MessageBox.Show("Ingrese los Datos correctamente con (*)");
            }



            








        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                caja_imagen.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
