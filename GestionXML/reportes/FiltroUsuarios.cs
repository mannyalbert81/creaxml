﻿using System;
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
    public partial class FiltroUsuarios : Form
    {
        public FiltroUsuarios()
        {
            InitializeComponent();
        }

        private void FiltroProduccion_Load(object sender, EventArgs e)
        {
            clases.Funciones.CargarCombo(cbm_usuarios, "id_usuarios", "nombre_usuarios", "usuarios");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _id_usuario = Convert.ToInt32(cbm_usuarios.SelectedValue.ToString());


            reportes.contProduccion frm = new reportes.contProduccion();
            frm._id_usuario = _id_usuario;
            frm.Show();
        }
    }
}