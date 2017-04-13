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
    public partial class contCaminos : Form
    {
        public contCaminos()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            /*
            datas.dtParticipantes dtParticipantes = new datas.dtParticipantes();

            NpgsqlDataAdapter daParticipantes = new NpgsqlDataAdapter();
            daParticipantes = AccesoLogica.Select_reporte("participantes.id_participantes, participantes.ci_participantes, participantes.primer_nombre_participantes, participantes.segundo_nombre_participantes, participantes.primer_apellido_participantes,   participantes.segundo_apellido_participantes, participantes.correo_participantes, participantes.telefono_participantes, participantes.celular_participantes, participantes.id_tag", "public.participantes", "ci_participantes LIKE '%' ");

            daParticipantes.Fill(dtParticipantes, "participantes");
            int reg = dtParticipantes.Tables[1].Rows.Count;
            reportes.repParticipantes ObjRep = new reportes.repParticipantes();
            ObjRep.SetDataSource(dtParticipantes.Tables[1]);
            crystalReportViewer1.ReportSource = ObjRep;
            //llena_documento.Dispose();
            */

        }
    }
}
