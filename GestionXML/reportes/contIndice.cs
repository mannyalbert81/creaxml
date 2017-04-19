using Negocio;
using Npgsql;
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
    public partial class contIndice : Form
    {
        public int _id_proyectos = 0;


        public contIndice()
        {
            InitializeComponent();
        }

        private void ReportViewerIndice_Load(object sender, EventArgs e)
        {
            datas.dtIndice dtIndice = new datas.dtIndice();

            NpgsqlDataAdapter daIndice = new NpgsqlDataAdapter();
            daIndice = AccesoLogica.Select_reporte("indice_cabeza.id_indice_cabeza, indice_cabeza.nombre_indice_cabeza, proyectos.nombre_proyectos, indice_cabeza.creado, indice_cabeza.modificado ", "public.indice_cabeza, public.proyectos", " proyectos.id_proyectos = indice_cabeza.id_proyectos");

            daIndice.Fill(dtIndice, "indice_cabeza");
            int reg = dtIndice.Tables[1].Rows.Count;
            reportes.rptIndice ObjRep = new reportes.rptIndice();
            ObjRep.SetDataSource(dtIndice.Tables[1]);
            ReportViewerIndice.ReportSource = ObjRep;
            // llena_documento.Dispose();
        }
    }
}
