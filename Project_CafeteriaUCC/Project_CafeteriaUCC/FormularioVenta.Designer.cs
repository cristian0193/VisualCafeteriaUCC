namespace Project_CafeteriaUCC
{
    partial class FormularioVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_categoria = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_registrar_producto = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_producto = new System.Windows.Forms.ComboBox();
            this.grid_productos = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.lb_numero_venta = new System.Windows.Forms.Label();
            this.txt_codigo_venta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "VENTAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_categoria);
            this.groupBox1.Location = new System.Drawing.Point(26, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria de Productos";
            // 
            // combo_categoria
            // 
            this.combo_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_categoria.FormattingEnabled = true;
            this.combo_categoria.Items.AddRange(new object[] {
            "SNATS",
            "ALMUERZO",
            "COMIDA",
            "BEBIDAS",
            "FRITOS"});
            this.combo_categoria.Location = new System.Drawing.Point(16, 32);
            this.combo_categoria.Name = "combo_categoria";
            this.combo_categoria.Size = new System.Drawing.Size(165, 24);
            this.combo_categoria.TabIndex = 0;
            this.combo_categoria.SelectedIndexChanged += new System.EventHandler(this.combo_categoria_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_registrar_producto);
            this.groupBox2.Controls.Add(this.txt_cantidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.combo_producto);
            this.groupBox2.Location = new System.Drawing.Point(257, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // btn_registrar_producto
            // 
            this.btn_registrar_producto.Location = new System.Drawing.Point(195, 61);
            this.btn_registrar_producto.Name = "btn_registrar_producto";
            this.btn_registrar_producto.Size = new System.Drawing.Size(176, 23);
            this.btn_registrar_producto.TabIndex = 14;
            this.btn_registrar_producto.Text = "Registrar Producto";
            this.btn_registrar_producto.UseVisualStyleBackColor = true;
            this.btn_registrar_producto.Click += new System.EventHandler(this.btn_registrar_producto_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.AcceptsTab = true;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(80, 61);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 23);
            this.txt_cantidad.TabIndex = 3;
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad : ";
            // 
            // combo_producto
            // 
            this.combo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_producto.FormattingEnabled = true;
            this.combo_producto.Location = new System.Drawing.Point(16, 28);
            this.combo_producto.Name = "combo_producto";
            this.combo_producto.Size = new System.Drawing.Size(512, 24);
            this.combo_producto.TabIndex = 1;
            // 
            // grid_productos
            // 
            this.grid_productos.AllowUserToAddRows = false;
            this.grid_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.PROD,
            this.CO,
            this.PRECIO,
            this.TOTAL});
            this.grid_productos.Location = new System.Drawing.Point(257, 172);
            this.grid_productos.MultiSelect = false;
            this.grid_productos.Name = "grid_productos";
            this.grid_productos.Size = new System.Drawing.Size(546, 212);
            this.grid_productos.TabIndex = 5;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 60;
            // 
            // PROD
            // 
            this.PROD.HeaderText = "Producto";
            this.PROD.Name = "PROD";
            this.PROD.Width = 180;
            // 
            // CO
            // 
            this.CO.HeaderText = "Cantidad";
            this.CO.Name = "CO";
            this.CO.Width = 60;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "Precio";
            this.PRECIO.MinimumWidth = 10;
            this.PRECIO.Name = "PRECIO";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.MinimumWidth = 10;
            this.TOTAL.Name = "TOTAL";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.Location = new System.Drawing.Point(106, 172);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(120, 23);
            this.txt_subtotal.TabIndex = 5;
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SUBTOTAL : ";
            // 
            // txt_iva
            // 
            this.txt_iva.Enabled = false;
            this.txt_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iva.Location = new System.Drawing.Point(106, 210);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(120, 23);
            this.txt_iva.TabIndex = 7;
            this.txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IVA : ";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(106, 250);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(120, 23);
            this.txt_total.TabIndex = 9;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL : ";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(25, 296);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(91, 41);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(78, 343);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(91, 41);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(135, 296);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(91, 41);
            this.btn_imprimir.TabIndex = 13;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // lb_numero_venta
            // 
            this.lb_numero_venta.AutoSize = true;
            this.lb_numero_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero_venta.ForeColor = System.Drawing.Color.Red;
            this.lb_numero_venta.Location = new System.Drawing.Point(636, 21);
            this.lb_numero_venta.Name = "lb_numero_venta";
            this.lb_numero_venta.Size = new System.Drawing.Size(30, 31);
            this.lb_numero_venta.TabIndex = 14;
            this.lb_numero_venta.Text = "#";
            this.lb_numero_venta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_codigo_venta
            // 
            this.txt_codigo_venta.Enabled = false;
            this.txt_codigo_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_venta.ForeColor = System.Drawing.Color.Red;
            this.txt_codigo_venta.Location = new System.Drawing.Point(669, 18);
            this.txt_codigo_venta.Name = "txt_codigo_venta";
            this.txt_codigo_venta.Size = new System.Drawing.Size(134, 38);
            this.txt_codigo_venta.TabIndex = 15;
            this.txt_codigo_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormularioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 396);
            this.Controls.Add(this.txt_codigo_venta);
            this.Controls.Add(this.lb_numero_venta);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_productos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormularioVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_productos;
        private System.Windows.Forms.ComboBox combo_categoria;
        private System.Windows.Forms.ComboBox combo_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_registrar_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.Label lb_numero_venta;
        private System.Windows.Forms.TextBox txt_codigo_venta;
    }
}