using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GestionXML
{
    public partial class frmListaPendienteTXT : Form
    {
        public string _camino = "";

        
        DataSet ds;
        DataTable dtSource;
        int PageCount;
        int maxRec;
        int pageSize;
        int currentPage;
        int recNo;


        public frmListaPendienteTXT()
        {
            InitializeComponent();
        }

        private void frmListaPendienteTXT_Load(object sender, EventArgs e)
        {
          lblCamino.Text = _camino;


            //cargo los pdf
            CargaGrid("");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            string _camino = Convert.ToString(fila.Cells[1].Value); //obtengo el valor de la primer columna

            DialogResult result = MessageBox.Show("Deseas Crear XML de este PDF?", "Crear nuevo XML", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                CreadorTXT Crea = new CreadorTXT();
                Crea.nombre_pdf = _camino;
                Crea.Show();
            }
            if (result == DialogResult.No)
            {
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {

            CargaGrid("");
        }

        public void CargaGrid(string _parametro)
        {
            int i;
            int startRec;
            int endRec;
            
            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("nombre");

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
                dtXML.Rows.Add(_nombre_xml);
                _cantidadXMLCrear++;

            }



            if (_parametro == "")
            {
                DirectoryInfo[] directories = directory.GetDirectories();
                string _nombre_pdf = "";
                int _agregados = 0;
                for (int ii = 0; ii < filesPDF.Length; ii++)
                {
                    _nombre_pdf = ((FileInfo)filesPDF[ii]).FullName;


                    DataRow[] foundRows;
                    foundRows = dtXML.Select("nombre = '" + _nombre_pdf.Replace(".pdf", ".XML") + "'   ");
                    if (foundRows.Length == 0) //no lo encontre 
                    {
                        dtTemp.Rows.Add(_nombre_pdf);
                        //dataGridView1.Rows.Insert(_agregados, _agregados + 1, _nombre_pdf);
                        _agregados++;
                    }
                    else // lo encontre pero debo rrevisarlo
                    {

                        if (BuscarEstadoXML(_nombre_pdf.Replace(".pdf", ".XML")))
                        {

                        }
                        else
                        {
                            dtTemp.Rows.Add(_nombre_pdf);
                            //dataGridView1.Rows.Insert(_agregados, _agregados + 1, _nombre_pdf);
                            _agregados++;
                        }
                    }


                }
            }
            else
            {
                dtTemp.Rows.Add(_parametro.Replace(".XML", ".pdf"));
                //dataGridView1.Rows.Insert(0, 1, );
                
            }


          
            //Clone the source table to create a temporary table.
            //dtTemp = dtSource.Clone();

            if (currentPage == PageCount)
            {
                endRec = maxRec;
            }
            else
            {
                endRec = pageSize * currentPage;
            }
            startRec = recNo;

            //Copy rows from the source table to fill the temporary table.
            for (i = startRec; i < endRec; i++)
            {
                dtTemp.ImportRow(dtSource.Rows[i]);
                recNo += 1;
            }
            dataGridView1.DataSource = dtTemp;
            DisplayPageInfo();

            //_path_completo.Replace(".XML", ".pdf")


            //_path_completo.Replace(".XML", ".pdf")


        }

        private void DisplayPageInfo()
        {
            txtDisplayPageNo.Text = "Page " + currentPage.ToString() + "/ " + PageCount.ToString();
            
        }

        private bool CheckFillButton()
        {
            // Check if the user clicks the "Fill Grid" button.
            if (pageSize == 0)
            {
                MessageBox.Show("Set the Page Size, and then click the Fill Grid button!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool BuscarEstadoXML(string _path)
        {
            Boolean _estado = false;

            string _campo_estado = "";
            
            try
            {
                var xdoc = XDocument.Load(@_path);

                var items = from i in xdoc.Descendants("field")
                            select new
                            {
                                _name = (string)i.Attribute("name"),
                                _value = (string)i.Attribute("value")
                            };

                
                foreach (var item in items)
                {

                    // use item.Action or item.FileName
                    if (item._name.ToString() != "VALIDADO")
                    {
                        _campo_estado = item._value.ToString().Trim();
                    }

                    if (_campo_estado == "1")
                    {
                        _estado = true;

                    }

                }
            }
            catch (Exception Ex)
            {

                
            }

            return _estado;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtTextoBuscar.Text.Length > 0)
            {

                CargaGrid(txtTextoBuscar.Text.Trim());
            }
            else
            {
                MessageBox.Show("Introduzca el nombre completo de ubicacion del archivo XML", "Filtro Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (CheckFillButton() == false)
            {
                return;
            }

            //Check if you are already at the first page.
            if (currentPage == 1)
            {
                MessageBox.Show("You are at the First Page!");
                return;
            }

            currentPage = 1;
            recNo = 0;
            CargaGrid("");
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            //If the user did not click the "Fill Grid" button, then return.
            if (CheckFillButton() == false)
            {
                return;
            }

            //Check if the user clicks the "Fill Grid" button.
            if (pageSize == 0)
            {
                MessageBox.Show("Set the Page Size, and then click the Fill Grid button!");
                return;
            }

            currentPage += 1;
            if (currentPage > PageCount)
            {
                currentPage = PageCount;
                //Check if you are already at the last page.
                if (recNo == maxRec)
                {
                    MessageBox.Show("You are at the Last Page!");
                    return;
                }
            }
            CargaGrid("");
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (CheckFillButton() == false)
            {
                return;
            }

            if (currentPage == PageCount)
            {
                recNo = pageSize * (currentPage - 2);
            }

            currentPage -= 1;
            //Check if you are already at the first page.
            if (currentPage < 1)
            {
                MessageBox.Show("You are at the First Page!");
                currentPage = 1;
                return;
            }
            else
            {
                recNo = pageSize * (currentPage - 1);
            }
            CargaGrid("");

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {

            if (CheckFillButton() == false)
            {
                return;
            }

            //Check if you are already at the last page.
            if (recNo == maxRec)
            {
                MessageBox.Show("You are at the Last Page!");
                return;
            }
            currentPage = PageCount;
            recNo = pageSize * (currentPage - 1);
            CargaGrid(""); 
        }
    }
}
