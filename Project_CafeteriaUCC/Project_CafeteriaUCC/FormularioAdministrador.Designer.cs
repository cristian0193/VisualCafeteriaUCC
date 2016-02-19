namespace Project_CafeteriaUCC
{
    partial class FormularioAdministrador
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
            this.aDMINISTRADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPRESAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRADORToolStripMenuItem,
            this.pAGOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINISTRADORToolStripMenuItem
            // 
            this.aDMINISTRADORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.pROVEEDORESToolStripMenuItem,
            this.eMPRESAToolStripMenuItem});
            this.aDMINISTRADORToolStripMenuItem.Name = "aDMINISTRADORToolStripMenuItem";
            this.aDMINISTRADORToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.aDMINISTRADORToolStripMenuItem.Text = "ADMINISTRADOR";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            this.uSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOSToolStripMenuItem_Click);
            // 
            // pROVEEDORESToolStripMenuItem
            // 
            this.pROVEEDORESToolStripMenuItem.Name = "pROVEEDORESToolStripMenuItem";
            this.pROVEEDORESToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pROVEEDORESToolStripMenuItem.Text = "PROVEEDORES";
            // 
            // eMPRESAToolStripMenuItem
            // 
            this.eMPRESAToolStripMenuItem.Name = "eMPRESAToolStripMenuItem";
            this.eMPRESAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eMPRESAToolStripMenuItem.Text = "EMPRESA";
            this.eMPRESAToolStripMenuItem.Click += new System.EventHandler(this.eMPRESAToolStripMenuItem_Click);
            // 
            // pAGOToolStripMenuItem
            // 
            this.pAGOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fACTURAToolStripMenuItem,
            this.vENTAToolStripMenuItem});
            this.pAGOToolStripMenuItem.Name = "pAGOToolStripMenuItem";
            this.pAGOToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pAGOToolStripMenuItem.Text = "PAGO";
            // 
            // fACTURAToolStripMenuItem
            // 
            this.fACTURAToolStripMenuItem.Name = "fACTURAToolStripMenuItem";
            this.fACTURAToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fACTURAToolStripMenuItem.Text = "FACTURAS";
            this.fACTURAToolStripMenuItem.Click += new System.EventHandler(this.fACTURAToolStripMenuItem_Click);
            // 
            // vENTAToolStripMenuItem
            // 
            this.vENTAToolStripMenuItem.Name = "vENTAToolStripMenuItem";
            this.vENTAToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.vENTAToolStripMenuItem.Text = "VENTAS";
            this.vENTAToolStripMenuItem.Click += new System.EventHandler(this.vENTAToolStripMenuItem_Click);
            // 
            // FormularioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 641);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRADORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPRESAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACTURAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTAToolStripMenuItem;
    }
}