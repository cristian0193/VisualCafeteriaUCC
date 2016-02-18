﻿using System;
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
    public partial class FormularioUsuarios : Form
    {
        public FormularioUsuarios()
        {
            InitializeComponent();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            string identi = "";
            identi = txt_identificacion.Text;

            daoUsuario usuario = new daoUsuario();
            DataTable consultaUsuario = new DataTable();
            consultaUsuario = usuario.ConsultaVerificacionUsuario(identi);

            if (consultaUsuario.Rows.Count <= 0 && !txt_identificacion.Text.Equals(""))
            {
                try
                {
                    // Objetos de conexión y comando               
                    System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=ASUS\ASUS;Initial Catalog=DBcafeteria;Integrated Security=SSPI");
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                    // Estableciento propiedades
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO [dbo].[INFO_USUARIOS] VALUES (@numero, @nombre, @apellido, @direccion,@telefono_ca,@telefono_pe,@rol,@email, @image)";

                    // Creando los parámetros necesarios
                    cmd.Parameters.Add("@numero", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@apellido", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@direccion", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@telefono_ca", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@telefono_pe", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@rol", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@image", System.Data.SqlDbType.Image);

                    // Asignando los valores a los atributos
                    cmd.Parameters["@numero"].Value = int.Parse(txt_identificacion.Text);
                    cmd.Parameters["@nombre"].Value = txt_nombre.Text;
                    cmd.Parameters["@apellido"].Value = txt_apellidos.Text;
                    cmd.Parameters["@direccion"].Value = txt_direccion.Text;
                    cmd.Parameters["@telefono_ca"].Value = txtx_casa.Text;
                    cmd.Parameters["@telefono_pe"].Value = txt_personal.Text;
                    cmd.Parameters["@rol"].Value = combo_roles.SelectedItem.ToString();
                    cmd.Parameters["@email"].Value = txt_email.Text;

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
                    txtx_casa.Text = "";
                    txt_personal.Text = "";
                    combo_roles.SelectedIndex = -1;
                    txt_email.Text = "";
                    caja_imagen.Image = null;


                    MessageBox.Show("El Usuario Se ingreso Correctamente");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("El usuario Ya se encuenta en la base de Datos");
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