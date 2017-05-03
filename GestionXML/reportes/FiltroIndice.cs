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
    public partial class FiltroIndice : Form
    {

        public FiltroIndice()
        {
            InitializeComponent();
        }

        private void FiltroIndice_Load(object sender, EventArgs e)
     

        {


            clases.Funciones.CargarCombo(cbm_proyectos, "id_proyectos", "nombre_proyectos", "proyectos");

            int _id_proyectos = Convert.ToInt32(cbm_proyectos.SelectedValue.ToString());
            
            clases.Funciones.CargarComboWhere(cmb_Caminos, "id_caminos", "nombre_caminos", "public.proyectos, public.caminos", "caminos.id_proyectos = proyectos.id_proyectos AND proyectos.id_proyectos = '" + _id_proyectos + "' ");

           
            


        }

        private void button1_Click(object sender, EventArgs e)
        {

          

            int _id_proyectos = Convert.ToInt32(cbm_proyectos.SelectedValue.ToString());
            int _id_caminos = Convert.ToInt32(cmb_Caminos.SelectedValue.ToString());


            reportes.contIndice frm = new reportes.contIndice();
            frm._id_proyectos = _id_proyectos;
            frm._id_caminos = _id_caminos;
            frm.Show();

            

        }

        private void cbm_proyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void cmb_Caminos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int _id_proyectos = Convert.ToInt32(cbm_proyectos.SelectedValue.ToString());

            clases.Funciones.CargarComboWhere(cmb_Caminos, "id_caminos", "nombre_caminos", "public.proyectos, public.caminos", "caminos.id_proyectos = proyectos.id_proyectos AND proyectos.id_proyectos = '" + _id_proyectos + "' ");

           
        }
    }
}
