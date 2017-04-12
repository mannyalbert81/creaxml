using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Npgsql;

namespace GestionXML
{
    public partial class frmIndice : Form
    {
        public frmIndice()
        {
            InitializeComponent();
        }
        private void llenar_grid(string _parametro)
        {
            clases.Funciones.CargarGridView(dataGridViewIndice, " indice_cabeza.id_indice_cabeza, indice_cabeza.nombre_indice_cabeza, caminos.nombre_caminos, indice_cabeza.total_indice_cabeza, usuarios.nombre_usuarios, indice_cabeza.creado, indice_cabeza.modificado", "  public.indice_cabeza, public.caminos, public.usuarios", _parametro, "Id?Nombre Indice Cabeza?Caminos?Total Indice?Nombre Usuarios?Creado?Modificado");
        }

        private void frmIndice_Load(object sender, EventArgs e)
        {
            clases.Funciones.CargarCombo(cbm_caminos, "id_caminos", "nombre_caminos", "caminos");
            clases.Funciones.CargarCombo(cbm_usuarios, "id_usuarios", "nombre_usuarios", "usuarios");
            llenar_grid(" usuarios.id_usuarios = caminos.id_usuarios AND proyectos.id_proyectos = caminos.id_proyectos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _error = "";
            string _nombre_caminos = txt_nombres_indice.Text;
            string _path_caminos = txt_total_indice.Text;
            int _id_caminos = Convert.ToInt16(cbm_caminos.SelectedValue.ToString());
            int _id_usuarios = Convert.ToInt16(cbm_usuarios.SelectedValue.ToString());
        }
    }
}
