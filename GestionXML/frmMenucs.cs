using System;
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
    public partial class frmMenucs : Form
    {
        public frmMenucs()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarpetasCalidad frm = new frmCarpetasCalidad();
            frm.Show();


        }

        private void controlarCalidadXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarpetasCalidadXML frm = new frmCarpetasCalidadXML(); 
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
        }

        private void frmMenucs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
              "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
