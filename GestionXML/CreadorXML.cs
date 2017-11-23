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
using System.Xml.Linq;
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace GestionXML
{
    public partial class CreadorXML : Form
    {
        public DateTime _inicio_produccion_detalle;
        public DateTime _fin_produccion_detalle;
        public string nombre_pdf = "";
        public string nombre_carpeta = "";
        public string nombre_carpeta_temporal = @"c:\GESTORXMLDATA\";
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

        public int _id_usuarios;
        public int  _id_camino;
        string _nombre_produccion_detalle = "";

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

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;

            //CreaXML("", "", "", "", "", "", "", "", "", "", "", "");
            LeeIndice(1);

            _inicio_produccion_detalle = DateTime.Now;

            int _totalPaginas = CountPageNo(nombre_pdf);

            LlenarComboPaginas(nombre_pdf);


        }

        public void LeeIndice(int _tipo_carga)
        {

            if (_tipo_carga == 1)
            {
                axAcroPDF1.src  = nombre_pdf;
            }
            else
            {

            }

            //System.IO.StreamReader file = new System.IO.StreamReader(@"indice.txt");


            int _contador = 1;
            
            ////aqui leo lo del detalle del indice


            
            string _nombre_indice_detalle = "";
            string _nombre_tipo_indice = "";
            int _min_indice_detalle = 0;
            int _max_indice_detalle = 0;
            int _orden_indice_detalle = 0;
            int _id_indice_detalle = 0;
            string _nombre_campo_indice_detalle;
            string _nombre_tabla_indice_detalle;
            bool _relacionado_indice_detalle;

            string _parametros = " indice_detalle.id_indice_cabeza = indice_cabeza.id_indice_cabeza AND tipo_indice.id_tipo_indice = indice_detalle.id_tipo_indice AND  indice_detalle.id_indice_cabeza = '" + _id_indice_cabeza + "'  ORDER BY indice_detalle.orden_indice_detalle ";
            
            DataTable dtIndice = AccesoLogica.Select("indice_detalle.id_indice_detalle, indice_cabeza.id_caminos, indice_cabeza.nombre_indice_cabeza, indice_detalle.nombre_indice_detalle, tipo_indice.nombre_tipo_indice,  indice_detalle.min_indice_detalle, indice_detalle.max_indice_detalle, indice_detalle.orden_indice_detalle, indice_detalle.nombre_campo_indice_detalle, indice_detalle.nombre_tabla_indice_detalle, indice_detalle.relacionado_indice_detalle", "  public.indice_cabeza, public.indice_detalle, public.tipo_indice", _parametros);

            int reg = dtIndice.Rows.Count;
            if (reg > 0)
            {
                foreach (DataRow renglon in dtIndice.Rows)
                {
                    _id_indice_detalle = Convert.ToInt32(renglon["id_indice_detalle"].ToString());
                    _nombre_indice_detalle = renglon["nombre_indice_detalle"].ToString();
                    _nombre_tipo_indice = renglon["nombre_tipo_indice"].ToString();
                    _min_indice_detalle = Convert.ToInt32(renglon["min_indice_detalle"].ToString());
                    _max_indice_detalle = Convert.ToInt32(renglon["max_indice_detalle"].ToString());
                    _orden_indice_detalle = Convert.ToInt32(renglon["orden_indice_detalle"].ToString());
                    _nombre_campo_indice_detalle = renglon["nombre_campo_indice_detalle"].ToString();
                    _nombre_tabla_indice_detalle = renglon["nombre_tabla_indice_detalle"].ToString();
                    _relacionado_indice_detalle = Convert.ToBoolean(renglon["relacionado_indice_detalle"].ToString());


                    if (_nombre_indice_detalle.Length > 0)
                    {
                        if (_contador == 1)
                        {
                            if (_tipo_carga == 1)
                            {
                                label1.Text = _nombre_indice_detalle;
                                label1.Visible = true;
                            }

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
                                button1.Visible = true;

                                Autocompletar(_tipo_carga,  textBox1, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);
                                
                                
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
                                button2.Visible = true;
                                Autocompletar(_tipo_carga,textBox2, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);



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
                                button3.Visible = true;
                                Autocompletar(_tipo_carga, textBox3, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);

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
                                button4.Visible = true;
                                Autocompletar(_tipo_carga, textBox4, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);


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
                                button5.Visible = true;
                                Autocompletar(_tipo_carga, textBox5, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);

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
                                button6.Visible = true;
                                Autocompletar(_tipo_carga, textBox6, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);

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
                                button7.Visible = true;
                                Autocompletar(_tipo_carga, textBox7, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);

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
                                button8.Visible = true;
                                Autocompletar(_tipo_carga, textBox8, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);

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
                                _fecha9 = true;
                            }
                            else
                            {
                                button9.Visible = true;
                                Autocompletar(_tipo_carga, textBox9, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);
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
                                _fecha10= true;
                            }
                            else
                            {
                                button10.Visible = true;
                                Autocompletar(_tipo_carga, textBox10, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);

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
                                _fecha11 = true;
                            }
                            else
                            {
                                button11.Visible = true;
                                Autocompletar(_tipo_carga, textBox11, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);

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
                                button12.Visible = true;
                                Autocompletar(_tipo_carga, textBox12, _max_indice_detalle, _relacionado_indice_detalle, _nombre_campo_indice_detalle, _nombre_tabla_indice_detalle);

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



                try
                {
                    CreaXML(_valor1, _valor2, _valor3, _valor4, _valor5, _valor6, _valor7, _valor8, _valor9, _valor10, _valor11, _valor12);


                    try
                    {
                      
                      
                        _nombre_produccion_detalle = @nombre_pdf.Replace(".pdf", ".XML");
                        _fin_produccion_detalle = DateTime.Now;

                        int id_usu = _id_usuarios;

                        clases.ProduccionCabeza.InsertaProduccionCabeza(id_usu, _id_camino, _nombre_produccion_detalle, _inicio_produccion_detalle, _fin_produccion_detalle);


                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show(Ex.Message, "Insertar la Produccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message, "No se Pudo General el XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
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
               new XComment("xml gernerado por GestorXML 2017  -  www.masoft.net"),
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




        public void Autocompletar(int _tipo_carga, TextBox _textBox,   int _max_indice_detalle, bool _relacionado_indice_detalle, string _nombre_campo_indice_detalle, string _nombre_tabla_indice_detalle)
        {
            



            if (_tipo_carga == 1)
            {
                
                if (Convert.ToInt16(_max_indice_detalle) > 0)
                {
                    _textBox.MaxLength = Convert.ToInt16(_max_indice_detalle);
                }

            }
            

            if (_relacionado_indice_detalle)
            {

                _textBox.AccessibleName = _nombre_campo_indice_detalle;
                if (_textBox.Name == "textBox1")
                {
                    button21.Visible = true;
                }
                if (_textBox.Name == "textBox2")
                {
                    button22.Visible = true;
                }
                if (_textBox.Name == "textBox3")
                {
                    button23.Visible = true;
                }
                if (_textBox.Name == "textBox4")
                {
                    button24.Visible = true;
                }
                if (_textBox.Name == "textBox5")
                {
                    button25.Visible = true;
                }
                if (_textBox.Name == "textBox6")
                {
                    button26.Visible = true;
                }
                if (_textBox.Name == "textBox7")
                {
                    button27.Visible = true;
                }
                if (_textBox.Name == "textBox8")
                {
                    button28.Visible = true;
                }
                if (_textBox.Name == "textBox9")
                {
                    button29.Visible = true;
                }
                _textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                _textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                AutoCompleteStringCollection col = new AutoCompleteStringCollection();

                DataSet dtText1 = new DataSet();

                NpgsqlDataAdapter daText1 = new NpgsqlDataAdapter();
                daText1 = null;

                try
                {
                    if (_nombre_tabla_indice_detalle == "banco_tarjetas")
                    {

                        if (_textBox.Text.ToString().Length > 3)
                        {
                            daText1 = AccesoLogica.Select_reporte(_nombre_campo_indice_detalle, _nombre_tabla_indice_detalle, _nombre_campo_indice_detalle + " LIKE '" + _textBox.Text.ToString() + "%' " + "  GROUP BY  " + _nombre_campo_indice_detalle + "   ORDER BY  " + _nombre_campo_indice_detalle + "  ");
                        }
                        else
                        {
                            daText1 = AccesoLogica.Select_reporte(_nombre_campo_indice_detalle, _nombre_tabla_indice_detalle, _nombre_campo_indice_detalle + " = '12345' " + "  GROUP BY  " + _nombre_campo_indice_detalle + "   ORDER BY  " + _nombre_campo_indice_detalle + "  ");
                        }
                            
                        
                    }
                    else
                    {

                        daText1 = AccesoLogica.Select_reporte(_nombre_campo_indice_detalle, _nombre_tabla_indice_detalle, _nombre_campo_indice_detalle + " LIKE '%%' ORDER BY  " + _nombre_campo_indice_detalle);
                    }
                    

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No se conecto a este  Campo-> " + _nombre_campo_indice_detalle + "Error->" + Ex.Message);
                }


                try
                {
                    daText1.Fill(dtText1, _nombre_tabla_indice_detalle);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al llenar Dataset",Ex.Message);
                }

                if (dtText1.Tables[0].Rows.Count > 0)
                {
                    
                    int i = 0;
                    for (i = 0; i <= dtText1.Tables[0].Rows.Count - 1; i++)
                    {
                        col.Add(dtText1.Tables[0].Rows[i][_nombre_campo_indice_detalle].ToString());

                    }

                }
                else
                {
                                    }
                _textBox.AutoCompleteCustomSource = col;
                
            }
            else
            {


            }
            _textBox.Visible = true;
            

        }

        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LeeIndice(2);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeeIndice(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LeeIndice(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LeeIndice(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LeeIndice(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LeeIndice(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LeeIndice(2);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            LeeIndice(2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LeeIndice(2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LeeIndice(2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LeeIndice(2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LeeIndice(2);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
                llenaTextbox(textBox1, textBox2);
                llenaTextbox(textBox1, textBox3);
                llenaTextbox(textBox1, textBox4);
                llenaTextbox(textBox1, textBox5);
                llenaTextbox(textBox1, textBox6);
                llenaTextbox(textBox1, textBox7);
                llenaTextbox(textBox1, textBox8);
                llenaTextbox(textBox1, textBox9);
                llenaTextbox(textBox1, textBox10);

            
        }



        public void llenaTextbox(TextBox _textBoxOrigen,   TextBox _textBox)
        {

            string _parametros = "";

            if (_textBoxOrigen.AccessibleName == "numero_banco_tarjetas") //buscamos por tarjeta
            {
                string _valor = _textBoxOrigen.Text.ToString();
                _parametros = " numero_banco_tarjetas =   '" + _valor + "'    ";
            }
            if (_textBoxOrigen.AccessibleName == "identificacion_banco_tarjetas") //buscamos por cedula
            {
                string _valor = _textBoxOrigen.Text.ToString();
                _parametros = " identificacion_banco_tarjetas =   '" + _valor + "'    ";
            }
            if (_parametros.Length > 0)
            {



                string _numero_banco_tarjetas = "";
                string _tipo_banco_tarjetas = "";
                string _identificacion_banco_tarjetas = "";
                string _nombres_banco_tarjetas = "";
                DataTable dtBanco = AccesoLogica.Select("numero_banco_tarjetas, tipo_banco_tarjetas, identificacion_banco_tarjetas, nombres_banco_tarjetas", "banco_tarjetas", _parametros);
                int reg = dtBanco.Rows.Count;
                if (reg > 0)
                {

                    _textBoxOrigen.BackColor = Color.White;
                    foreach (DataRow renglon in dtBanco.Rows)
                    {
                        _numero_banco_tarjetas = renglon["numero_banco_tarjetas"].ToString();
                        _tipo_banco_tarjetas = renglon["tipo_banco_tarjetas"].ToString();
                        _identificacion_banco_tarjetas = renglon["identificacion_banco_tarjetas"].ToString();
                        _nombres_banco_tarjetas = renglon["nombres_banco_tarjetas"].ToString();

                    }
                }
                else
                {

                    
                }


                if (_textBox.AccessibleName == "numero_banco_tarjetas")
                {
                    _textBox.Text = _numero_banco_tarjetas;
                }
                if (_textBox.AccessibleName == "identificacion_banco_tarjetas")
                {
                    _textBox.Text = _identificacion_banco_tarjetas;
                }
                if (_textBox.AccessibleName == "nombres_banco_tarjetas")
                {
                    _textBox.Text = _nombres_banco_tarjetas;
                }
                if (_textBox.AccessibleName == "tipo_banco_tarjetas")
                {
                    _textBox.Text = _tipo_banco_tarjetas;
                }


            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            llenaTextbox(textBox2, textBox1);
            llenaTextbox(textBox2, textBox3);
            llenaTextbox(textBox2, textBox4);
            llenaTextbox(textBox2, textBox5);
            llenaTextbox(textBox2, textBox6);
            llenaTextbox(textBox2, textBox7);
            llenaTextbox(textBox2, textBox8);
            llenaTextbox(textBox2, textBox9);
            llenaTextbox(textBox2, textBox10);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            llenaTextbox(textBox3, textBox1);
            llenaTextbox(textBox3, textBox2);
            llenaTextbox(textBox3, textBox4);
            llenaTextbox(textBox3, textBox5);
            llenaTextbox(textBox3, textBox6);
            llenaTextbox(textBox3, textBox7);
            llenaTextbox(textBox3, textBox8);
            llenaTextbox(textBox3, textBox9);
            llenaTextbox(textBox3, textBox10);
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }


        public void LlenarComboPaginas(string nombre_pdf)
        {
            int TotalPaginas = CountPageNo(nombre_pdf);
            cmbPaginasRecortar.Items.Clear();
            cmbPaginasInsertar.Items.Clear();
            cmbPaginasAnterior.Items.Clear();
            cmbPaginasOrganizar.Items.Clear();

            cmbPaginasInsertar.Items.Add(0);
            cmbPaginasAnterior.Items.Add(0);
            for (int i = 1; i <= TotalPaginas; i++)
            {
                cmbPaginasRecortar.Items.Add(i);
                cmbPaginasInsertar.Items.Add(i);
                cmbPaginasAnterior.Items.Add(i);
                cmbPaginasOrganizar.Items.Add(i);
            }

            cmbPaginasRecortar.SelectedIndex = 0;
            cmbPaginasInsertar.SelectedIndex = 0;
            cmbPaginasAnterior.SelectedIndex = 0;
            cmbPaginasOrganizar.SelectedIndex = 0;
        }


        


        private static void AddPages(string _nombre_regularizacion, int _id_subcategorias)
        {
            string _nombre_lecturas = "";
            string _path_categorias = "";
            string _path_subcategorias = "";
            string _nombre_archivo_original = "";
            string _nombre_archivo_original_pdf = "";
            int _id_documentos_legal = Convert.ToInt32(_nombre_regularizacion);
            string _nombre_pagina_agregar = "";
            string _nombre_regularizado_final = "";
            string columnas = "documentos_legal.id_documentos_legal, lecturas.nombre_lecturas, categorias.path_categorias, subcategorias.path_subcategorias";
            string tablas = "public.documentos_legal, public.lecturas, public.categorias, public.subcategorias";
            string where = "lecturas.id_lecturas = documentos_legal.id_lecturas AND subcategorias.id_categorias = categorias.id_categorias AND subcategorias.id_subcategorias = documentos_legal.id_subcategorias AND documentos_legal.id_documentos_legal = '" + _id_documentos_legal + "'  AND  documentos_legal.procesado =  'FALSE'     ";

            DataTable dtRegularizar = AccesoLogica.Select(columnas, tablas, where);
            int regReg = dtRegularizar.Rows.Count;
            if (regReg > 0)
            {

                foreach (DataRow renglonSub in dtRegularizar.Rows)
                {

                    _path_categorias = renglonSub["path_categorias"].ToString();
                    _path_subcategorias = renglonSub["path_subcategorias"].ToString();
                    _nombre_lecturas = renglonSub["nombre_lecturas"].ToString();

                    _nombre_archivo_original = _path_categorias + _path_subcategorias + @"\" + _nombre_lecturas;

                    _nombre_archivo_original_pdf = _nombre_archivo_original.Replace(".XML", ".pdf");
                    _nombre_pagina_agregar = @"C:\regularizacion\" + _id_documentos_legal + ".pdf";
                    _nombre_regularizado_final = _path_categorias + _path_subcategorias + @"\procesados\" + _nombre_lecturas.Replace(".XML", ".pdf"); ;


                    //"id_documentos_legal = '" + _id_documentos_legal + "'  "
                    AccesoLogica.Update("documentos_legal", "procesado = 'TRUE' ", " id_documentos_legal = '" + _id_documentos_legal + "'    ");

                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(_nombre_archivo_original_pdf);
                    Console.WriteLine(_nombre_pagina_agregar);
                    Console.WriteLine(_nombre_regularizado_final);
                    Console.WriteLine("------------------------------------------");
                    string[] sourceFiles = new string[] { _nombre_archivo_original_pdf, _nombre_pagina_agregar };


                    //MergeFiles(_nombre_regularizado_final, sourceFiles);

                }
            }

        }





        public static bool MergePDFs(List<String> InFiles, String OutFile)
        {
            bool merged = true;
            try
            {
                List<PdfReader> readerList = new List<PdfReader>();
                foreach (string filePath in InFiles)
                {
                    PdfReader pdfReader = new PdfReader(filePath);
                    readerList.Add(pdfReader);
                }

                //Define a new output document and its size, type
                Document document = new Document(PageSize.A4, 0, 0, 0, 0);
                //Create blank output pdf file and get the stream to write on it.
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(OutFile, FileMode.Create));
                document.Open();

                foreach (PdfReader reader in readerList)
                {
                    PdfReader.unethicalreading = true;
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        PdfImportedPage page = writer.GetImportedPage(reader, i);
                        document.Add(iTextSharp.text.Image.GetInstance(page));
                    }
                }
                document.Close();
                foreach (PdfReader reader in readerList)
                {
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                merged = false;
            }


            return merged;
        }


        public static void MergeFiles(string destinationFile, string[] sourceFiles)
        {
            
                
                try
                {
                PdfReader reader = null;
                int f = 0;
                    // we create a reader for a certain document
                    reader = new PdfReader(sourceFiles[f]);
                    // we retrieve the total number of pages
                    int n = reader.NumberOfPages;
                    //Console.WriteLine("There are " + n + " pages in the original file.");
                    // step 1: creation of a document-object
                    Document document = new Document(reader.GetPageSizeWithRotation(1));
                    // step 2: we create a writer that listens to the document
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationFile, FileMode.Create));
                    // step 3: we open the document
                    document.Open();
                    PdfContentByte cb = writer.DirectContent;
                    PdfImportedPage page;
                    int rotation;
                    // step 4: we add content
                    while (f < sourceFiles.Length)
                    {
                        int i = 0;
                        while (i < n)
                        {
                            i++;
                            document.SetPageSize(reader.GetPageSizeWithRotation(i));
                            document.NewPage();
                            page = writer.GetImportedPage(reader, i);
                            rotation = reader.GetPageRotation(i);
                            if (rotation == 90 || rotation == 270)
                            {
                                cb.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
                            }
                            else
                            {
                                cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                            }
                            //Console.WriteLine("Processed page " + i);
                        }
                        f++;
                        if (f < sourceFiles.Length)
                        {
                            reader = new PdfReader(sourceFiles[f]);
                            // we retrieve the total number of pages
                            n = reader.NumberOfPages;
                            //Console.WriteLine("*********************************************");
                            //Console.WriteLine("There are " + n + " pages in the original file.");
                        }
                    }
                    // step 5: we close the document
                    document.Close();
                    reader.Close();
                    reader.Dispose();
                    document.Dispose();
                    writer.Close();
                    writer.Dispose();
                    cb = null;
                    page = null;
                    rotation = 0;
                }
                catch (Exception e)
                {
                    string strOb = e.Message;
                    Console.WriteLine("************ERRORR***********************");
                    Console.WriteLine(strOb);
                    Console.WriteLine("************ERRORR***********************");


                }
            
            
        }

        public static int CountPageNo(string strFileName)
        {
            // we create a reader for a certain document
            PdfReader reader = new PdfReader(strFileName);
            // we retrieve the total number of pages
            int _paginas = reader.NumberOfPages;
            reader.Close();

            return _paginas;

            
        }


        public static void ExtractPages(string sourcePdfPath, string outputPdfPath,
                                   int startPage, int endPage)
        {
            PdfReader reader = null;
            Document sourceDocument = null;
            PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage = null;

            try
            {
                // Intialize a new PdfReader instance with the contents of the source Pdf file:
                reader = new PdfReader(sourcePdfPath);

                // For simplicity, I am assuming all the pages share the same size
                // and rotation as the first page:
                sourceDocument = new Document(reader.GetPageSizeWithRotation(startPage));

                // Initialize an instance of the PdfCopyClass with the source 
                // document and an output file stream:
                pdfCopyProvider = new PdfCopy(sourceDocument,
                    new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

                sourceDocument.Open();

                // Walk the specified range and add the page copies to the output file:
                for (int i = startPage; i <= endPage; i++)
                {
                    importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                    pdfCopyProvider.AddPage(importedPage);
                }
                sourceDocument.Close();
                reader.Close();
                pdfCopyProvider.Close();
                importedPage = null;

                sourceDocument.Dispose();
                reader.Dispose();
                pdfCopyProvider.Dispose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Exportr Archivos: "+ex.Message);
                
            }
        }






        private void btnCortar_Click_1(object sender, EventArgs e)
        {
            int _paginaCortar = 0;

            _paginaCortar = Convert.ToInt16( cmbPaginasRecortar.SelectedItem.ToString());

            if (_paginaCortar > 0)
            {
                int _totalPaginas = CountPageNo(nombre_pdf);
                int _inicio = 0;
                int _final = 0;

                int _inicio2 = 0;
                int _final2 = 0;

                if (_paginaCortar == 1)
                {
                    _inicio = 2;
                    _final = _totalPaginas;
                    ExtractPages(nombre_pdf, nombre_pdf.Replace(".pdf", "CUT.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), _inicio, _final);

                    axAcroPDF1.LoadFile("none");
                    //axAcroPDF1.Dispose();
                  

                    try
                    {
                        File.Delete(nombre_pdf);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al Eliminar Archivo" + ex.Message);
                    }

                    File.Copy(nombre_pdf.Replace(".pdf", "CUT.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), nombre_pdf);
                    axAcroPDF1.src = nombre_pdf;


                    LlenarComboPaginas(nombre_pdf);
                    

                }





                if (_paginaCortar == _totalPaginas)
                {
                    _inicio = 1;
                    _final = _totalPaginas - 1;
                    ExtractPages(nombre_pdf, nombre_pdf.Replace(".pdf", "CUT.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), _inicio, _final);

                    axAcroPDF1.LoadFile("none");
                    //axAcroPDF1.Dispose();


                    try
                    {
                        File.Delete(nombre_pdf);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al Eliminar Archivo" + ex.Message);
                    }

                    File.Copy(nombre_pdf.Replace(".pdf", "CUT.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), nombre_pdf);
                    axAcroPDF1.src = nombre_pdf;


                    LlenarComboPaginas(nombre_pdf);

                    

                }

                if (_paginaCortar > 1 && _paginaCortar < _totalPaginas)
                {
                    _inicio = 1;
                    _final = _paginaCortar - 1;
                    
                    _inicio2 = _paginaCortar + 1;
                    _final2 = _totalPaginas;
                    ExtractPages(nombre_pdf, nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), _inicio, _final);
                    ExtractPages(nombre_pdf, nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), _inicio2, _final2);
                        

                  
                    List<string> Listaarchivos = new List<string>();
                    Listaarchivos.Add(nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                    Listaarchivos.Add(nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                    
                    axAcroPDF1.LoadFile("none");
                    //axAcroPDF1.Dispose();


                    try
                    {
                        File.Delete(nombre_pdf);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al Eliminar Archivo" + ex.Message);
                    }
                  
                    MergePDFs(Listaarchivos, nombre_pdf);


                    axAcroPDF1.src = nombre_pdf;

                    
                    LlenarComboPaginas(nombre_pdf);

                  
                    try
                    {
                        File.Delete(nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                        File.Delete(nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al Eliminar Archivo PARTES  " + ex.Message);
                    }
                }
                


            }

            else
            {

                MessageBox.Show("Primero Seleccione la página despúes de la cual insertará el archivo seleccionado", "ATENCION !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    
            
            


        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            openFilePDFInsertar.Filter = "Archivos PDF|*.pdf";
            openFilePDFInsertar.Title = "Seleccione un Archivo PDF";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .CUR file was selected, open it.
            if (openFilePDFInsertar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.
                //this.Cursor = new Cursor(openFilePDFInsertar.OpenFile());
                string _nombre_archivo_insertar = openFilePDFInsertar.FileName;

                //MessageBox.Show("Archivo ->" + _camino_archivo_insertar);

                int _paginaCortar = 0;
                _paginaCortar = Convert.ToInt16(cmbPaginasInsertar.SelectedItem.ToString());
                
                    int _totalPaginas = CountPageNo(nombre_pdf);
                    int _inicio = 0;
                    int _final = 0;

                    int _inicio2 = 0;
                    int _final2 = 0;

                    if (_paginaCortar == 0)
                    {
                        _inicio = 1;
                        _final = _totalPaginas;
                        

                        ExtractPages(nombre_pdf, nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), _inicio, _final);
                        
                        List<string> Listaarchivos = new List<string>();
                        Listaarchivos.Add(_nombre_archivo_insertar);
                        Listaarchivos.Add(nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                        

                        axAcroPDF1.LoadFile("none");
                        //axAcroPDF1.Dispose();


                        try
                        {
                            File.Delete(nombre_pdf);

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error al Eliminar Archivo" + ex.Message);
                        }

                        MergePDFs(Listaarchivos, nombre_pdf);


                        axAcroPDF1.src = nombre_pdf;

                        LlenarComboPaginas(nombre_pdf);

                        try
                        {
                            File.Delete(nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                            File.Delete(nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error al Eliminar Archivo PARTES  " + ex.Message);
                        }

                    }
                    if (_paginaCortar == 1)
                    {
                        _inicio = 1;
                        _final = 1;

                        _inicio2 = _paginaCortar + 1;
                        _final2 = _totalPaginas;


                        ExtractPages(nombre_pdf, nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), _inicio, _final);
                        ExtractPages(nombre_pdf, nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), _inicio2, _final2);

                        List<string> Listaarchivos = new List<string>();
                        Listaarchivos.Add(nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                        Listaarchivos.Add(_nombre_archivo_insertar);
                        Listaarchivos.Add(nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));


                        axAcroPDF1.LoadFile("none");
                        //axAcroPDF1.Dispose();


                        try
                        {
                            File.Delete(nombre_pdf);

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error al Eliminar Archivo" + ex.Message);
                        }

                        MergePDFs(Listaarchivos, nombre_pdf);


                        axAcroPDF1.src = nombre_pdf;

                        LlenarComboPaginas(nombre_pdf);

                        try
                        {
                            File.Delete(nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                            File.Delete(nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error al Eliminar Archivo PARTES  " + ex.Message);
                        }

                    }
                    if (_paginaCortar == _totalPaginas)
                    {
                        _inicio = 1;
                        _final = _totalPaginas;

                        

                        ExtractPages(nombre_pdf, nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), _inicio, _final);
                        
                        List<string> Listaarchivos = new List<string>();
                        Listaarchivos.Add(nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                        Listaarchivos.Add(_nombre_archivo_insertar);
                        

                        axAcroPDF1.LoadFile("none");
                        //axAcroPDF1.Dispose();


                        try
                        {
                            File.Delete(nombre_pdf);

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error al Eliminar Archivo" + ex.Message);
                        }

                        MergePDFs(Listaarchivos, nombre_pdf);


                        axAcroPDF1.src = nombre_pdf;

                        LlenarComboPaginas(nombre_pdf);

                        try
                        {
                            File.Delete(nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                            File.Delete(nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error al Eliminar Archivo PARTES  " + ex.Message);
                        }


                    }
                    if (_paginaCortar > 1 && _paginaCortar < _totalPaginas)
                    {
                        _inicio = 1;
                        _final = _paginaCortar - 1;

                        _inicio2 = _paginaCortar + 1;
                        _final2 = _totalPaginas;

                        ExtractPages(nombre_pdf, nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), _inicio, _final);
                        ExtractPages(nombre_pdf, nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal), _inicio2, _final2);

                        List<string> Listaarchivos = new List<string>();
                        Listaarchivos.Add(nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                        Listaarchivos.Add(_nombre_archivo_insertar);
                        Listaarchivos.Add(nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));


                        axAcroPDF1.LoadFile("none");
                        //axAcroPDF1.Dispose();


                        try
                        {
                            File.Delete(nombre_pdf);

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error al Eliminar Archivo" + ex.Message);
                        }

                        MergePDFs(Listaarchivos, nombre_pdf);


                        axAcroPDF1.src = nombre_pdf;

                        LlenarComboPaginas(nombre_pdf);

                        try
                        {
                            File.Delete(nombre_pdf.Replace(".pdf", "PART1.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                            File.Delete(nombre_pdf.Replace(".pdf", "PART2.pdf").Replace(nombre_carpeta, nombre_carpeta_temporal));
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error al Eliminar Archivo PARTES  " + ex.Message);
                        }
                    }

                









            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int _paginas_organizar = Convert.ToInt16(cmbPaginasOrganizar.SelectedItem.ToString()); ;
            int _pagina_anterior = Convert.ToInt16(cmbPaginasAnterior.SelectedItem.ToString());


            if (_paginas_organizar == 1 && _pagina_anterior == 0)
            {
                MessageBox.Show("Esta Página ya es la Primera del Documento", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            }
        }
    }


}
