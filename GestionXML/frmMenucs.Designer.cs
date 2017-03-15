namespace GestionXML
{
    partial class frmMenucs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenucs));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlarCalidadXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestionXMLToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1051, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestionXMLToolStripMenuItem
            // 
            this.gestionXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearXMLToolStripMenuItem,
            this.controlarCalidadXMLToolStripMenuItem});
            this.gestionXMLToolStripMenuItem.Name = "gestionXMLToolStripMenuItem";
            this.gestionXMLToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.gestionXMLToolStripMenuItem.Text = "Gestion XML";
            // 
            // crearXMLToolStripMenuItem
            // 
            this.crearXMLToolStripMenuItem.Name = "crearXMLToolStripMenuItem";
            this.crearXMLToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.crearXMLToolStripMenuItem.Text = "Crear XML";
            this.crearXMLToolStripMenuItem.Click += new System.EventHandler(this.crearXMLToolStripMenuItem_Click);
            // 
            // controlarCalidadXMLToolStripMenuItem
            // 
            this.controlarCalidadXMLToolStripMenuItem.Name = "controlarCalidadXMLToolStripMenuItem";
            this.controlarCalidadXMLToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.controlarCalidadXMLToolStripMenuItem.Text = "Controlar Calidad XML";
            this.controlarCalidadXMLToolStripMenuItem.Click += new System.EventHandler(this.controlarCalidadXMLToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.controladoresToolStripMenuItem,
            this.permisosRolesToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click_1);
            // 
            // controladoresToolStripMenuItem
            // 
            this.controladoresToolStripMenuItem.Name = "controladoresToolStripMenuItem";
            this.controladoresToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.controladoresToolStripMenuItem.Text = "Controladores";
            this.controladoresToolStripMenuItem.Click += new System.EventHandler(this.controladoresToolStripMenuItem_Click_1);
            // 
            // permisosRolesToolStripMenuItem
            // 
            this.permisosRolesToolStripMenuItem.Name = "permisosRolesToolStripMenuItem";
            this.permisosRolesToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.permisosRolesToolStripMenuItem.Text = "Permisos Roles";
            this.permisosRolesToolStripMenuItem.Click += new System.EventHandler(this.permisosRolesToolStripMenuItem_Click_1);
            // 
            // frmMenucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 358);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenucs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Archivos XML";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlarCalidadXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosRolesToolStripMenuItem;
    }
}