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
        public static frmMenucs mdiobj;
        public frmMenucs()
        {
            InitializeComponent();
            
        }

        private void frmMenucs_Load(object sender, EventArgs e)
        {
   
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

       

        private void rolesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRoles frm = new frmRoles();
            frm.Show();
        }

        private void controladoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmControladores frm = new frmControladores();
            frm.Show();
        }

        private void permisosRolesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPermisosRoles frm = new frmPermisosRoles();
            frm.Show();
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyectos frm = new frmProyectos();
            frm.Show();
        }

        private void formulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormularios frm = new frmFormularios();
            frm.Show();
        }

        private void tipoIndiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoIndice frm = new frmTipoIndice();
            frm.Show();
        }

        private void caminosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaminos frm = new frmCaminos();
            frm.Show();
        }

        private void cartonDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCartonDocumentos frm = new frmCartonDocumentos();
            frm.Show();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstado frm = new frmEstado();
            frm.Show();
        }

        private void indiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIndice frm = new frmIndice();
            frm.Show();
        }

        private void caminosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportes.contProyectos frm = new reportes.contProyectos();
            frm.Show();
        }

        private void caminosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            reportes.contTipoIndice frm = new reportes.contTipoIndice();
            frm.Show();
        }

        private void caminosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            reportes.FiltroCaminos frm = new reportes.FiltroCaminos();
            frm.Show();
        }

        private void cartónDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportes.contCartonDocumentos frm = new reportes.contCartonDocumentos();
            frm.Show();
        }

        private void estadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportes.contEstado frm = new reportes.contEstado();
            frm.Show();
        }

        private void indiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reportes.FiltroIndice frm = new reportes.FiltroIndice();
            frm.Show();
        }

        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmProyectos frm = new frmProyectos();
            frm.Show();
        }

        private void btn_TipoIndice_Click(object sender, EventArgs e)
        {
            frmTipoIndice frm = new frmTipoIndice();
            frm.Show();
        }

        private void btn_Caminos_Click(object sender, EventArgs e)
        {
            frmCaminos frm = new frmCaminos();
            frm.Show();
        }

        private void btn_Caminos_Click_1(object sender, EventArgs e)
        {
            frmCaminos frm = new frmCaminos();
            frm.Show();
        }

        private void btn_Caminos_Click_2(object sender, EventArgs e)
        {
            frmCaminos frm = new frmCaminos();
            frm.Show();
        }

        private void btn_CartonDocumentos_Click(object sender, EventArgs e)
        {
            frmCartonDocumentos frm = new frmCartonDocumentos();
            frm.Show();
        }

        private void btn_Estado_Click(object sender, EventArgs e)
        {
            frmEstado frm = new frmEstado();
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmIndice frm = new frmIndice();
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmCarpetasCalidad frm = new frmCarpetasCalidad();
            frm.Show();

        }

       

        private void btn_control_calidad_Click(object sender, EventArgs e)
        {
            frmCarpetasCalidadXML frm = new frmCarpetasCalidadXML();
            frm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmProyectos frm = new frmProyectos();
            frm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmTipoIndice frm = new frmTipoIndice();
            frm.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmCaminos frm = new frmCaminos();
            frm.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmCartonDocumentos frm = new frmCartonDocumentos();
            frm.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            frmEstado frm = new frmEstado();
            frm.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            frmIndice frm = new frmIndice();
            frm.Show();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            frmCarpetasCalidad frm = new frmCarpetasCalidad();
            frm.Show();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            frmCarpetasCalidadXML frm = new frmCarpetasCalidadXML();
            frm.Show();
        }
    }
}
