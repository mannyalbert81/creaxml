namespace GestionXML
{
    partial class frmListaPendienteXML
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCamino = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.cmbEquipos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARCHIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.fecha,
            this.ARCHIVO});
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 389);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblCamino
            // 
            this.lblCamino.AutoSize = true;
            this.lblCamino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamino.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCamino.Location = new System.Drawing.Point(17, 23);
            this.lblCamino.Name = "lblCamino";
            this.lblCamino.Size = new System.Drawing.Size(0, 13);
            this.lblCamino.TabIndex = 2;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(592, 6);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(102, 37);
            this.btnRecargar.TabIndex = 3;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Items.AddRange(new object[] {
            "TODOS",
            "EQUIPO1",
            "EQUIPO2",
            "EQUIPO3",
            "EQUIPO4",
            "EQUIPO5",
            "EQUIPO6",
            "EQUIPO7",
            "EQUIPO8",
            "EQUIPO9",
            "EQUIPO10",
            "EQUIPO11",
            "EQUIPO12",
            "EQUIPO13",
            "EQUIPO14",
            "EQUIPO15",
            "EQUIPO16"});
            this.cmbEquipos.Location = new System.Drawing.Point(130, 46);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(176, 21);
            this.cmbEquipos.TabIndex = 4;
            this.cmbEquipos.SelectedIndexChanged += new System.EventHandler(this.cmbEquipos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecciona el Equipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de Archivo:";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(424, 46);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(270, 20);
            this.txtNombreArchivo.TabIndex = 7;
            this.txtNombreArchivo.TextChanged += new System.EventHandler(this.txtNombreArchivo_TextChanged);
            // 
            // numero
            // 
            this.numero.HeaderText = "#";
            this.numero.Name = "numero";
            this.numero.Width = 30;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "CREADO";
            this.fecha.Name = "fecha";
            this.fecha.Width = 200;
            // 
            // ARCHIVO
            // 
            this.ARCHIVO.HeaderText = "ARCHIVO";
            this.ARCHIVO.Name = "ARCHIVO";
            this.ARCHIVO.Width = 450;
            // 
            // frmListaPendienteXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 477);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEquipos);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.lblCamino);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListaPendienteXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Archivos XML Pendientes";
            this.Load += new System.EventHandler(this.frmCreaXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCamino;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.ComboBox cmbEquipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARCHIVO;
    }
}