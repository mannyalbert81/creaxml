namespace GestionXML
{
    partial class frmPortada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortada));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Image = global::GestionXML.Properties.Resources.portada2;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(602, 409);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.ForeColor = System.Drawing.Color.Olive;
            this.progressBar1.Location = new System.Drawing.Point(23, 372);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(309, 17);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Value = 5;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 85;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // frmPortada
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 393);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPortada";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer3;
    }
}