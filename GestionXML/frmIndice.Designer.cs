﻿namespace GestionXML
{
    partial class frmIndice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndice));
            this.cbm_proyectos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre_indice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridIndice = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.txt_orden = new System.Windows.Forms.TextBox();
            this.cbm_tipo_indice = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombre_indice_detalle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndice)).BeginInit();
            this.SuspendLayout();
            // 
            // cbm_proyectos
            // 
            this.cbm_proyectos.FormattingEnabled = true;
            this.cbm_proyectos.Location = new System.Drawing.Point(532, 75);
            this.cbm_proyectos.Name = "cbm_proyectos";
            this.cbm_proyectos.Size = new System.Drawing.Size(217, 21);
            this.cbm_proyectos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyectos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Indice Cabeza:";
            // 
            // txt_nombre_indice
            // 
            this.txt_nombre_indice.Location = new System.Drawing.Point(216, 30);
            this.txt_nombre_indice.Name = "txt_nombre_indice";
            this.txt_nombre_indice.Size = new System.Drawing.Size(533, 20);
            this.txt_nombre_indice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Indice:";
            // 
            // dataGridIndice
            // 
            this.dataGridIndice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIndice.Location = new System.Drawing.Point(95, 304);
            this.dataGridIndice.Name = "dataGridIndice";
            this.dataGridIndice.Size = new System.Drawing.Size(738, 108);
            this.dataGridIndice.TabIndex = 6;
            this.dataGridIndice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridIndice_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(404, 417);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 67);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(277, 220);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 67);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(404, 220);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 67);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(532, 220);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 67);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(665, 220);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 67);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "MIN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "MAX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "ORDEN:";
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(446, 133);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(57, 20);
            this.txt_min.TabIndex = 36;
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(562, 129);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(57, 20);
            this.txt_max.TabIndex = 37;
            // 
            // txt_orden
            // 
            this.txt_orden.Location = new System.Drawing.Point(690, 126);
            this.txt_orden.Name = "txt_orden";
            this.txt_orden.Size = new System.Drawing.Size(59, 20);
            this.txt_orden.TabIndex = 38;
            // 
            // cbm_tipo_indice
            // 
            this.cbm_tipo_indice.FormattingEnabled = true;
            this.cbm_tipo_indice.Location = new System.Drawing.Point(216, 80);
            this.cbm_tipo_indice.Name = "cbm_tipo_indice";
            this.cbm_tipo_indice.Size = new System.Drawing.Size(222, 21);
            this.cbm_tipo_indice.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Nombre Indice Detalle:";
            // 
            // txt_nombre_indice_detalle
            // 
            this.txt_nombre_indice_detalle.Location = new System.Drawing.Point(216, 132);
            this.txt_nombre_indice_detalle.Name = "txt_nombre_indice_detalle";
            this.txt_nombre_indice_detalle.Size = new System.Drawing.Size(190, 20);
            this.txt_nombre_indice_detalle.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 42;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nombre_indice_detalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbm_tipo_indice);
            this.Controls.Add(this.txt_orden);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridIndice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre_indice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbm_proyectos);
            this.Name = "frmIndice";
            this.Text = "frmIndice";
            this.Load += new System.EventHandler(this.frmIndice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbm_proyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre_indice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridIndice;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.TextBox txt_orden;
        private System.Windows.Forms.ComboBox cbm_tipo_indice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nombre_indice_detalle;
        private System.Windows.Forms.Button button1;
    }
}