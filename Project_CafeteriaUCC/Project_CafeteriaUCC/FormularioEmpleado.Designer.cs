namespace Project_CafeteriaUCC
{
    partial class FormularioEmpleado
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pAGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTURASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pAGOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pAGOSToolStripMenuItem
            // 
            this.pAGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fACTURASToolStripMenuItem,
            this.vENTAToolStripMenuItem});
            this.pAGOSToolStripMenuItem.Name = "pAGOSToolStripMenuItem";
            this.pAGOSToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pAGOSToolStripMenuItem.Text = "PAGOS";
            // 
            // fACTURASToolStripMenuItem
            // 
            this.fACTURASToolStripMenuItem.Name = "fACTURASToolStripMenuItem";
            this.fACTURASToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fACTURASToolStripMenuItem.Text = "FACTURAS";
            this.fACTURASToolStripMenuItem.Click += new System.EventHandler(this.fACTURASToolStripMenuItem_Click);
            // 
            // vENTAToolStripMenuItem
            // 
            this.vENTAToolStripMenuItem.Name = "vENTAToolStripMenuItem";
            this.vENTAToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.vENTAToolStripMenuItem.Text = "VENTA";
            this.vENTAToolStripMenuItem.Click += new System.EventHandler(this.vENTAToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(967, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "CAMBIAR DE ROL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pAGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACTURASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTAToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}