﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionXML
{
    public partial class frmPortada : Form
    {
        public frmPortada()
        {
            InitializeComponent();

            timer2.Interval = 5000;
            timer2.Start();
            timer2.Tick += (s, e) => {

                frmMenucs frm = new frmMenucs();
                frm.Show();
                this.Hide();
                timer2.Stop();
            };
        }

        private void frmPortada_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
