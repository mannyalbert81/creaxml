namespace GestionXML
{
    partial class frmCarpetasCalidadXML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarpetasCalidadXML));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 463);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivos por Carpetas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.camino,
            this.PDF,
            this.SI,
            this.dif});
            this.dataGridView1.Location = new System.Drawing.Point(6, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numero
            // 
            this.numero.HeaderText = "#";
            this.numero.Name = "numero";
            this.numero.Width = 30;
            // 
            // camino
            // 
            this.camino.HeaderText = "CAMINO";
            this.camino.Name = "camino";
            this.camino.Width = 645;
            // 
            // PDF
            // 
            this.PDF.HeaderText = "PDF";
            this.PDF.Name = "PDF";
            this.PDF.Width = 40;
            // 
            // SI
            // 
            this.SI.HeaderText = "SI";
            this.SI.Name = "SI";
            this.SI.Width = 40;
            // 
            // dif
            // 
            this.dif.HeaderText = "NO";
            this.dif.Name = "dif";
            this.dif.Width = 40;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCargar.Image = global::GestionXML.Properties.Resources.carpeta__4_;
            this.btnCargar.Location = new System.Drawing.Point(739, 41);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(108, 74);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar Carpetas";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmCarpetasCalidadXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(883, 504);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarpetasCalidadXML";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carpetas Calidad XML";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn camino;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn SI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dif;
    }
}