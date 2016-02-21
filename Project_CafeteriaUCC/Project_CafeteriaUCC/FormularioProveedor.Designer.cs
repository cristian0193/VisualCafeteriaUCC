namespace Project_CafeteriaUCC
{
    partial class FormularioProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.txt_apellido_asesor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre_asesor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_proveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_productos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_nit_empresa = new System.Windows.Forms.ComboBox();
            this.txt_nombre_empresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(198, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 25);
            this.label9.TabIndex = 70;
            this.label9.Text = "REGISTRO DE PROVEEDOR";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(138, 219);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(441, 21);
            this.txt_direccion.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Direccion :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "NIT empresa:";
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(137, 430);
            this.btn_cargar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(130, 32);
            this.btn_cargar.TabIndex = 65;
            this.btn_cargar.Text = "GUARDAR";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // txt_apellido_asesor
            // 
            this.txt_apellido_asesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_asesor.Location = new System.Drawing.Point(138, 145);
            this.txt_apellido_asesor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido_asesor.Name = "txt_apellido_asesor";
            this.txt_apellido_asesor.Size = new System.Drawing.Size(441, 21);
            this.txt_apellido_asesor.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Apellido Asesor :";
            // 
            // txt_nombre_asesor
            // 
            this.txt_nombre_asesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_asesor.Location = new System.Drawing.Point(138, 112);
            this.txt_nombre_asesor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_asesor.Name = "txt_nombre_asesor";
            this.txt_nombre_asesor.Size = new System.Drawing.Size(441, 21);
            this.txt_nombre_asesor.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Nombre Asesor :";
            // 
            // txt_id_proveedor
            // 
            this.txt_id_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_proveedor.ForeColor = System.Drawing.Color.Red;
            this.txt_id_proveedor.Location = new System.Drawing.Point(138, 70);
            this.txt_id_proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_proveedor.Name = "txt_id_proveedor";
            this.txt_id_proveedor.Size = new System.Drawing.Size(165, 21);
            this.txt_id_proveedor.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Id Proveedor :";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(137, 258);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(130, 21);
            this.txt_telefono.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Telefono :";
            // 
            // txt_productos
            // 
            this.txt_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productos.Location = new System.Drawing.Point(138, 343);
            this.txt_productos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_productos.Multiline = true;
            this.txt_productos.Name = "txt_productos";
            this.txt_productos.Size = new System.Drawing.Size(441, 79);
            this.txt_productos.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Productos Ofrece :";
            // 
            // combo_nit_empresa
            // 
            this.combo_nit_empresa.FormattingEnabled = true;
            this.combo_nit_empresa.Location = new System.Drawing.Point(137, 181);
            this.combo_nit_empresa.Name = "combo_nit_empresa";
            this.combo_nit_empresa.Size = new System.Drawing.Size(166, 21);
            this.combo_nit_empresa.TabIndex = 75;
            this.combo_nit_empresa.SelectedIndexChanged += new System.EventHandler(this.combo_nit_empresa_SelectedIndexChanged_1);
            // 
            // txt_nombre_empresa
            // 
            this.txt_nombre_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empresa.Location = new System.Drawing.Point(137, 297);
            this.txt_nombre_empresa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_empresa.Name = "txt_nombre_empresa";
            this.txt_nombre_empresa.Size = new System.Drawing.Size(442, 21);
            this.txt_nombre_empresa.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 300);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Nombre Empresa :";
            // 
            // FormularioProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 475);
            this.Controls.Add(this.txt_nombre_empresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_nit_empresa);
            this.Controls.Add(this.txt_productos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.txt_apellido_asesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre_asesor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id_proveedor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.TextBox txt_apellido_asesor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre_asesor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_productos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_nit_empresa;
        private System.Windows.Forms.TextBox txt_nombre_empresa;
        private System.Windows.Forms.Label label8;
    }
}