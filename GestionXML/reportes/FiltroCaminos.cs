using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionXML.reportes
{
    public partial class FiltroCaminos : Form
    {
        public FiltroCaminos()
        {
            InitializeComponent();
        }

        private void FiltroCaminos_Load(object sender, EventArgs e)
        {
            clases.Funciones.CargarCombo(cbm_proyectos, "id_proyectos", "nombre_proyectos", "proyectos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _id_proyectos =  Convert.ToInt32( cbm_proyectos.SelectedValue.ToString());


            reportes.contCaminos frm = new reportes.contCaminos();
            frm._id_proyectos = _id_proyectos;
            frm.Show();
            

        }
    }
}
