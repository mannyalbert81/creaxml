namespace GestionXML.reportes
{
    partial class contTipoIndice
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
            this.ReportViewerTipoIndice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewerTipoIndice
            // 
            this.ReportViewerTipoIndice.ActiveViewIndex = -1;
            this.ReportViewerTipoIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewerTipoIndice.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewerTipoIndice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerTipoIndice.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerTipoIndice.Name = "ReportViewerTipoIndice";
            this.ReportViewerTipoIndice.Size = new System.Drawing.Size(284, 261);
            this.ReportViewerTipoIndice.TabIndex = 0;
            this.ReportViewerTipoIndice.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // contTipoProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ReportViewerTipoIndice);
            this.Name = "contTipoProyectos";
            this.Text = "contTipoProyectos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerTipoIndice;
    }
}