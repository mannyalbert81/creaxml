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

namespace GestionXML
{
    public partial class frmCarpetasCalidadXML : Form
    {
        public frmCarpetasCalidadXML()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ///leer los caminos
            int _counter_caminos = 0;
            string _nombre_camino;

            int _counter_pdf = 0;
            int _counter_xml = 0;
            int _counter_dif = 0;


            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"caminos.txt");
            while ((_nombre_camino = file.ReadLine()) != null)
            {
                System.Console.WriteLine(_nombre_camino);



                ///leo los camino
                DirectoryInfo directory = new DirectoryInfo(@_nombre_camino);
                FileInfo[] filesPDF = directory.GetFiles("*.PDF");
                FileInfo[] filesXML = directory.GetFiles("*.XML");

                DirectoryInfo[] directories = directory.GetDirectories();

                for (int i = 0; i < filesPDF.Length; i++)
                {
                    _counter_pdf++;

                }

                for (int i = 0; i < filesXML.Length; i++)
                {
                    _counter_xml++;

                }

                _counter_dif = _counter_pdf - _counter_xml;
                dataGridView1.Rows.Insert(_counter_caminos, _counter_caminos + 1, _nombre_camino, _counter_pdf, _counter_xml, _counter_dif);

                _counter_caminos++;

                _counter_pdf = 0;
                _counter_xml = 0;
                _counter_dif = 0;

            }

            file.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            string _camino = Convert.ToString(fila.Cells[1].Value); //obtengo el valor de la primer columna
            

            DialogResult result = MessageBox.Show("Deseas Crear XML en esta Carpeta?", "Crear nuevos XML", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                frmListaPendienteTXT Crea = new frmListaPendienteTXT();
                Crea._camino = _camino;
                Crea.Show();
            }
            if (result == DialogResult.No)
            {
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
