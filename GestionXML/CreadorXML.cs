using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GestionXML
{
    public partial class CreadorXML : Form
    {
        public string nombre_pdf = "";
        public int _id_indice_cabeza = 0;
        public Boolean _fecha1 = false;
        public Boolean _fecha2 = false;
        public Boolean _fecha3 = false;
        public Boolean _fecha4 = false;
        public Boolean _fecha5 = false;
        public Boolean _fecha6 = false;
        public Boolean _fecha7 = false;
        public Boolean _fecha8 = false;
        public Boolean _fecha9 = false;
        public Boolean _fecha10 = false;
        public Boolean _fecha11 = false;
        public Boolean _fecha12 = false;

        DateTimePicker dtFecha1 = new DateTimePicker();
        DateTimePicker dtFecha2 = new DateTimePicker();
        DateTimePicker dtFecha3 = new DateTimePicker();
        DateTimePicker dtFecha4 = new DateTimePicker();
        DateTimePicker dtFecha5 = new DateTimePicker();
        DateTimePicker dtFecha6 = new DateTimePicker();
        DateTimePicker dtFecha7 = new DateTimePicker();
        DateTimePicker dtFecha8 = new DateTimePicker();
        DateTimePicker dtFecha9 = new DateTimePicker();
        DateTimePicker dtFecha10 = new DateTimePicker();
        DateTimePicker dtFecha11 = new DateTimePicker();
        DateTimePicker dtFecha12 = new DateTimePicker();
        public CreadorXML()
        {
            InitializeComponent();
        }

        private void CreadorXML_Load(object sender, EventArgs e)
        {
            dtFecha1.Visible = false;
            dtFecha2.Visible = false;
            dtFecha3.Visible = false;
            dtFecha4.Visible = false;
            dtFecha5.Visible = false;
            dtFecha6.Visible = false;
            dtFecha7.Visible = false;
            dtFecha8.Visible = false;
            dtFecha9.Visible = false;
            dtFecha10.Visible = false;
            dtFecha11.Visible = false;
            dtFecha12.Visible = false;
            CreaXML("", "", "", "", "", "", "", "", "", "", "", "");
            LeeIndice();

        }

        public void LeeIndice()
        {
            acrobat.src = nombre_pdf;

            System.IO.StreamReader file = new System.IO.StreamReader(@"indice.txt");


            int _contador = 1;
            
            ////aqui leo lo del detalle del indice


            
            string _nombre_indice_detalle = "";
            string _nombre_tipo_indice = "";
            int _min_indice_detalle = 0;
            int _max_indice_detalle = 0;
            int _orden_indice_detalle = 0;

            string _parametros = " indice_detalle.id_indice_cabeza = indice_cabeza.id_indice_cabeza AND tipo_indice.id_tipo_indice = indice_detalle.id_tipo_indice AND  indice_detalle.id_indice_cabeza = '" + _id_indice_cabeza + "'  ORDER BY indice_detalle.orden_indice_detalle ";
            int _id_caminos = 0;

            DataTable dtIndice = AccesoLogica.Select("indice_cabeza.nombre_indice_cabeza, indice_detalle.nombre_indice_detalle, tipo_indice.nombre_tipo_indice,  indice_detalle.min_indice_detalle, indice_detalle.max_indice_detalle, indice_detalle.orden_indice_detalle", "  public.indice_cabeza, public.indice_detalle, public.tipo_indice", _parametros); 
            int reg = dtIndice.Rows.Count;
            if (reg > 0)
            {
                foreach (DataRow renglon in dtIndice.Rows)
                {
                    _id_caminos = Convert.ToInt32(renglon["id_caminos"].ToString());
                    _nombre_indice_detalle = renglon["nombre_indice_detalle"].ToString();
                    _nombre_tipo_indice = renglon["nombre_tipo_indice"].ToString();
                    _min_indice_detalle = Convert.ToInt32(renglon["min_indice_detalle"].ToString());
                    _max_indice_detalle = Convert.ToInt32(renglon["max_indice_detalle"].ToString());
                    _orden_indice_detalle = Convert.ToInt32(renglon["orden_indice_detalle"].ToString());




                    if (_nombre_indice_detalle.Length > 0)
                    {
                        if (_contador == 1)
                        {
                            
                            label1.Text = _nombre_indice_detalle;
                            label1.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {

                                dtFecha1.Location = new Point(1045, 46);
                                this.Controls.Add(dtFecha1);
                                dtFecha1.Format = DateTimePickerFormat.Custom;
                                dtFecha1.CustomFormat = "yyyy-MM-dd";

                                dtFecha1.Visible = true;
                                _fecha1 = true;
                            }
                            else
                            {
                                textBox1.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox1.MaxLength = _max_indice_detalle;
                                }
                                
                            }




                        }

                        if (_contador == 2)
                        {
                            

                            label2.Text = _nombre_indice_detalle;
                            label2.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {


                                dtFecha2.Location = new Point(1045, 93);
                                dtFecha2.Visible = true;
                                this.Controls.Add(dtFecha2);
                                dtFecha2.Format = DateTimePickerFormat.Custom;
                                dtFecha2.CustomFormat = "dd-MM-yyyy";

                                _fecha2 = true;

                            }
                            else
                            {
                                textBox2.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox2.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }

                        if (_contador == 3)
                        {
                            
                            label3.Text = _nombre_indice_detalle;
                            label3.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {


                                dtFecha3.Location = new Point(1045, 140);
                                _fecha3 = true;
                                dtFecha3.Visible = true;
                                dtFecha3.CustomFormat = "dd-MM-yyyy";

                                this.Controls.Add(dtFecha3);
                            }
                            else
                            {
                                textBox3.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox3.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }

                        if (_contador == 4)
                        {
                            
                            label4.Text = _nombre_indice_detalle;
                            label4.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {


                                dtFecha4.Location = new Point(1045, 185);
                                dtFecha4.Visible = true;
                                this.Controls.Add(dtFecha4);

                                _fecha4 = true;
                            }
                            else
                            {
                                textBox4.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox4.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }

                        if (_contador == 5)
                        {
                            
                            label5.Text = _nombre_indice_detalle;
                            label5.Visible = true;

                            if (_nombre_indice_detalle == "FECHA")
                            {


                                dtFecha5.Location = new Point(1045, 233);
                                dtFecha5.Visible = true;
                                dtFecha5.Format = DateTimePickerFormat.Custom;
                                dtFecha5.CustomFormat = "dd-MM-yyyy";


                                this.Controls.Add(dtFecha5);
                                _fecha5 = true;


                            }
                            else
                            {
                                textBox5.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox5.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }

                        if (_contador == 6)
                        {
                            
                            label6.Text = _nombre_indice_detalle;
                            label6.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {


                                dtFecha6.Location = new Point(1045, 282);
                                dtFecha6.Visible = true;
                                dtFecha6.Format = DateTimePickerFormat.Custom;
                                dtFecha6.CustomFormat = "dd-MM-yyyy";

                                this.Controls.Add(dtFecha6);
                                _fecha6 = true;
                            }
                            else
                            {
                                textBox6.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox6.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }
                        if (_contador == 7)
                        {
                            
                            label7.Text = _nombre_indice_detalle;
                            label7.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {

                                dtFecha7.Location = new Point(1045, 332);
                                dtFecha7.Visible = true;
                                dtFecha7.Format = DateTimePickerFormat.Custom;
                                dtFecha7.CustomFormat = "dd-MM-yyyy";

                                this.Controls.Add(dtFecha7);
                                _fecha7 = true;
                            }
                            else
                            {
                                textBox7.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox7.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }

                        if (_contador == 8)
                        {
                            
                            label8.Text = _nombre_indice_detalle;
                            label8.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {


                                dtFecha8.Location = new Point(1045, 378);
                                dtFecha8.Visible = true;
                                this.Controls.Add(dtFecha8);
                                _fecha8 = true;
                            }
                            else
                            {
                                textBox8.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox8.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }


                        if (_contador == 9)
                        {
                            
                            label9.Text = _nombre_indice_detalle;
                            label9.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {


                                dtFecha9.Location = new Point(1045, 425);
                                dtFecha9.Visible = true;
                                this.Controls.Add(dtFecha9);
                                _fecha8 = true;
                            }
                            else
                            {
                                textBox9.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox9.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }


                        if (_contador == 10)
                        {
                            
                            label10.Text = _nombre_indice_detalle;
                            label10.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {


                                dtFecha10.Location = new Point(1045, 474);
                                dtFecha10.Visible = true;
                                this.Controls.Add(dtFecha10);
                                _fecha8 = true;
                            }
                            else
                            {
                                textBox10.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox10.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }



                        if (_contador == 11)
                        {
                            
                            label11.Text = _nombre_indice_detalle;
                            label11.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {


                                dtFecha11.Location = new Point(1045, 522);
                                dtFecha11.Visible = true;
                                this.Controls.Add(dtFecha11);
                                _fecha8 = true;
                            }
                            else
                            {
                                textBox11.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox11.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }




                        if (_contador == 12)
                        {
                            
                            label12.Text = _nombre_indice_detalle;
                            label12.Visible = true;

                            if (_nombre_tipo_indice == "FECHA")
                            {


                                dtFecha12.Location = new Point(1045, 567);
                                dtFecha12.Visible = true;
                                this.Controls.Add(dtFecha12);
                                _fecha8 = true;
                            }
                            else
                            {
                                textBox12.Visible = true;
                                if (Convert.ToInt16(_max_indice_detalle) > 0)
                                {
                                    textBox12.MaxLength = Convert.ToInt16(_max_indice_detalle);
                                }
                            }



                        }




                        _contador++;
                    }

                }

            
            }


        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string _error = "";

            if (textBox1.Visible == true)
            {
                if (textBox1.Text.Length == 0)
                {
                    _error = "El campo " + label1.Text + " no puede estar vacio";
                }
            }
            if (textBox2.Visible == true)
            {
                if (textBox2.Text.Length == 0)
                {
                    _error = "El campo " + label2.Text + " no puede estar vacio";
                }
            }

            if (textBox3.Visible == true)
            {
                if (textBox3.Text.Length == 0)
                {
                    _error = "El campo " + label3.Text + " no puede estar vacio";
                }
            }
            if (textBox4.Visible == true)
            {
                if (textBox4.Text.Length == 0)
                {
                    _error = "El campo " + label4.Text + " no puede estar vacio";
                }
            }
            if (textBox5.Visible == true)
            {
                if (textBox5.Text.Length == 0)
                {
                    _error = "El campo " + label5.Text + " no puede estar vacio";
                }
            }
            if (textBox6.Visible == true)
            {
                if (textBox6.Text.Length == 0)
                {
                    _error = "El campo " + label6.Text + " no puede estar vacio";
                }
            }
            if (textBox7.Visible == true)
            {
                if (textBox7.Text.Length == 0)
                {
                    _error = "El campo " + label7.Text + " no puede estar vacio";
                }
            }
            if (textBox8.Visible == true)
            {
                if (textBox8.Text.Length == 0)
                {
                    _error = "El campo " + label8.Text + " no puede estar vacio";
                }
            }

            if (textBox9.Visible == true)
            {
                if (textBox9.Text.Length == 0)
                {
                    _error = "El campo " + label9.Text + " no puede estar vacio";
                }
            }

            if (textBox10.Visible == true)
            {
                if (textBox10.Text.Length == 0)
                {
                    _error = "El campo " + label10.Text + " no puede estar vacio";
                }
            }

            if (textBox11.Visible == true)
            {
                if (textBox11.Text.Length == 0)
                {
                    _error = "El campo " + label11.Text + " no puede estar vacio";
                }
            }

            if (textBox12.Visible == true)
            {
                if (textBox12.Text.Length == 0)
                {
                    _error = "El campo " + label12.Text + " no puede estar vacio";
                }
            }



            if (_error.Length == 0)
            {
                string _valor1 = "";
                string _valor2 = "";
                string _valor3 = "";
                string _valor4 = "";
                string _valor5 = "";
                string _valor6 = "";
                string _valor7 = "";
                string _valor8 = "";
                string _valor9 = "";
                string _valor10 = "";
                string _valor11 = "";
                string _valor12 = "";

                if (_fecha1)
                {
                    _valor1 = dtFecha1.Value.ToString("yyyy.MM.dd"); 
                }
                else
                {
                    _valor1 = textBox1.Text;
                }
                if (_fecha2)
                {
                    _valor2 = dtFecha2.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor2 = textBox2.Text;
                }
                if (_fecha3)
                {
                    _valor3 = dtFecha3.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor3 = textBox3.Text;
                }
                if (_fecha4)
                {
                    _valor4 = dtFecha4.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor4 = textBox4.Text;
                }
                if (_fecha5)
                {
                    _valor5 = dtFecha5.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor5 = textBox5.Text;
                }
                if (_fecha6)
                {
                    _valor6 = dtFecha6.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor6 = textBox6.Text;
                }
                if (_fecha7)
                {
                    _valor7 = dtFecha7.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor7 = textBox7.Text;
                }

                if (_fecha8)
                {
                    _valor8 = dtFecha8.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor8 = textBox8.Text;
                }

                if (_fecha9)
                {
                    _valor9 = dtFecha9.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor9 = textBox9.Text;
                }

                if (_fecha10)
                {
                    _valor10 = dtFecha10.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor10 = textBox10.Text;
                }

                if (_fecha11)
                {
                    _valor11 = dtFecha11.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor11 = textBox11.Text;
                }

                if (_fecha12)
                {
                    _valor12 = dtFecha12.Value.ToString("yyyy.MM.dd");
                }
                else
                {
                    _valor12 = textBox12.Text;
                }





                CreaXML(_valor1, _valor2, _valor3, _valor4, _valor5, _valor6, _valor7, _valor8, _valor9, _valor10, _valor11, _valor12);
            }
            else
            {
                MessageBox.Show(_error, "Falntan Campos por Llenar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        public void CreaXML(string _valor1, string _valor2, string _valor3, string _valor4, string _valor5, string _valor6, string _valor7, string _valor8, string _valor9, string _valor10, string _valor11, string _valor12)

        {

            XDocument miXML = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),
               new XComment("xml gernerado por utilitarios www.masoft.net"),
               new XElement("root",
                  new XElement("document",

                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label1.Text),
                                               new XAttribute("value", _valor1)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label2.Text),
                                               new XAttribute("value", _valor2)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label3.Text),
                                               new XAttribute("value", _valor3)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label4.Text),
                                               new XAttribute("value", _valor4)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label5.Text),
                                               new XAttribute("value", _valor5)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label6.Text),
                                               new XAttribute("value", _valor6)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label7.Text),
                                               new XAttribute("value", _valor7)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label8.Text),
                                               new XAttribute("value", _valor8)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label9.Text),
                                               new XAttribute("value", _valor9)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label10.Text),
                                               new XAttribute("value", _valor10)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label11.Text),
                                               new XAttribute("value", _valor11)
                                           ),
                               new XElement("field",
                                               new XAttribute("level", "document"),
                                               new XAttribute("name", label12.Text),
                                               new XAttribute("value", _valor12)
                                           )








                      )
                  )
              );

            try
            {
                miXML.Save(@nombre_pdf.Replace(".pdf", ".XML"));
                MessageBox.Show("XML Generado Correctamente", "XML Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("XML no fue Generado", "XML Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
