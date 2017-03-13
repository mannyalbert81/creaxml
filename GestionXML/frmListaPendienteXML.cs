﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionXML
{
    public partial class frmListaPendienteXML : Form
    {
        public  string _camino = "";

        public frmListaPendienteXML()
        {
            InitializeComponent();
        }

        private void frmCreaXML_Load(object sender, EventArgs e)
        {
            cmbEquipos.SelectedIndex = 0;


            lblCamino.Text = _camino;


            //cargo los pdf
            CargaGrid(0);
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            string _camino = Convert.ToString(fila.Cells[2].Value); //obtengo el valor de la primer columna

            DialogResult result = MessageBox.Show("Deseas Crear XML de este PDF?", "Crear nuevo XML", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                CreadorXML Crea = new CreadorXML();   
                Crea.nombre_pdf = _camino;
                Crea.Show();
            }
            if (result == DialogResult.No)
            {
            }

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (cmbEquipos.SelectedItem.ToString().Length >0 )
            {

                CargaGrid(1);
            }

            
           
        }


        public void CargaGrid(int _tipo)
        {
            dataGridView1.Rows.Clear();

            DirectoryInfo directory = new DirectoryInfo(@_camino);
            
            FileInfo[] filesPDF = directory.GetFiles("*.PDF");
            FileInfo[] filesXML = directory.GetFiles("*.XML");

            DataTable dtXML = new DataTable();
            dtXML.Columns.Add("nombre");

            string _nombre_xml = "";
            int _cantidadXMLCrear = 0;

            for (int ii = 0; ii < filesXML.Length; ii++)
            {
                _nombre_xml = ((FileInfo)filesXML[ii]).FullName;
                //MessageBox.Show(_nombre_xml.Substring(0, 7));

                dtXML.Rows.Add(_nombre_xml);
                _cantidadXMLCrear++;

            }

            DirectoryInfo[] directories = directory.GetDirectories();
            string _nombre_pdf = "";
            DateTime _date_creado_pdf = DateTime.Now;
            string _nombre_pdf_name = "";
            int _agregados = 0;
            string _equipo = "";
            for (int i = 0; i < filesPDF.Length; i++)
            {
                _nombre_pdf = ((FileInfo)filesPDF[i]).FullName;
                _date_creado_pdf = File.GetLastWriteTime(filesPDF[i].FullName);
                _nombre_pdf_name = ((FileInfo)filesPDF[i]).Name;
           
                DataRow[] foundRows = null;
                try
                {
                    foundRows = dtXML.Select("nombre = '" + _nombre_pdf.Replace(".pdf", ".XML") + "'   ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Archivo: ----  "+ _nombre_pdf );
                }

                
                if (foundRows.Length == 0)
                {
                    
                    if (_tipo == 1)
                    {
                    
                        _equipo = cmbEquipos.SelectedItem.ToString();

                        if (_equipo == "TODOS")
                        {

                            dataGridView1.Rows.Insert(_agregados, _agregados + 1, _date_creado_pdf , _nombre_pdf);
                            _agregados++;
                        }
                        else if (_equipo == _nombre_pdf_name.Substring(0, 7))
                        {
                            dataGridView1.Rows.Insert(_agregados, _agregados + 1, _date_creado_pdf , _nombre_pdf);
                            _agregados++;
                        }

                    }
                    if (_tipo == 2)
                    {

                        _equipo = cmbEquipos.SelectedItem.ToString();

                        bool b = _nombre_pdf_name.Contains(_equipo);

                        if (_equipo == "TODOS")
                        {

                            dataGridView1.Rows.Insert(_agregados, _agregados + 1, _date_creado_pdf, _nombre_pdf);
                            _agregados++;
                        }
                        else if (b)
                        {
                            dataGridView1.Rows.Insert(_agregados, _agregados + 1, _date_creado_pdf, _nombre_pdf);
                            _agregados++;

                        }
                    }



                   
                    
                }
                


            }

            //_path_completo.Replace(".XML", ".pdf")


        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {

        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {

        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargaGrid(1);

        }

        private void txtNombreArchivo_TextChanged(object sender, EventArgs e)
        {
            CargaGrid(2);
        }
    }
}
