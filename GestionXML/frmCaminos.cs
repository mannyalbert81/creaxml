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
    public partial class frmCaminos : Form
    {
        public frmCaminos()
        {
            InitializeComponent();
        }
       
        private void llenar_grid(string _parametro)
        {
            clases.Funciones.CargarGridView(dataGridViewPermisosRoles, " caminos.id_caminos AS Id, caminos.nombre_caminos, caminos.path_caminos, usuarios.nombre_usuarios, proyectos.nombre_proyectos, caminos.creado, caminos.modificado", "public.caminos, public.usuarios, public.proyectos", _parametro, "Id?Nombre Camino?Path?Usuario Registra?Nombre Proyecto?Creado?Modificado");

        }
       

        private void frmCaminos_Load_1(object sender, EventArgs e)
        {
            clases.Funciones.CargarCombo(cbm_usuarios, "id_usuarios", "nombre_usuarios", "usuarios");
            clases.Funciones.CargarCombo(cbm_proyectos, "id_proyectos", "nombre_proyectos", "proyectos");
            llenar_grid(" usuarios.id_usuarios = caminos.id_usuarios AND proyectos.id_proyectos = caminos.id_proyectos");
        }

        private void dataGridViewPermisosRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
