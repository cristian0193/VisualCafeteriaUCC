﻿namespace Project_CafeteriaUCC
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
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.nUEVOUSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.eMPRESAToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem,
            this.nUEVOUSERSToolStripMenuItem});
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
            this.pROVEEDORESToolStripMenuItem.Click += new System.EventHandler(this.pROVEEDORESToolStripMenuItem_Click);
            // 
            // eMPRESAToolStripMenuItem
            // 
            this.eMPRESAToolStripMenuItem.Name = "eMPRESAToolStripMenuItem";
            this.eMPRESAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eMPRESAToolStripMenuItem.Text = "EMPRESA";
            this.eMPRESAToolStripMenuItem.Click += new System.EventHandler(this.eMPRESAToolStripMenuItem_Click);
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            this.pRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTOSToolStripMenuItem_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(969, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "CAMBIAR DE ROL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nUEVOUSERSToolStripMenuItem
            // 
            this.nUEVOUSERSToolStripMenuItem.Name = "nUEVOUSERSToolStripMenuItem";
            this.nUEVOUSERSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nUEVOUSERSToolStripMenuItem.Text = "NUEVO USERS";
            this.nUEVOUSERSToolStripMenuItem.Click += new System.EventHandler(this.nUEVOUSERSToolStripMenuItem_Click);
            // 
            // FormularioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem nUEVOUSERSToolStripMenuItem;
    }
}