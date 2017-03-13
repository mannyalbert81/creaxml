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
            string _nombre_campo;

            string _titulo_campo = "";
            string _tipo_campo = "";
            string _max_campo = "";


            while ((_nombre_campo = file.ReadLine()) != null)
            {


                if (_nombre_campo.Length > 0)
                {
                    if (_contador == 1)
                    {
                        string[] vector1 = Vector(_nombre_campo);
                        for (int i = 0; i < vector1.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector1[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector1[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector1[i];
                            }

                        }

                        label1.Text = _titulo_campo;
                        label1.Visible = true;

                        if (_tipo_campo == "FECHA")
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
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox1.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }




                    }

                    if (_contador == 2)
                    {
                        string[] vector2 = Vector(_nombre_campo);
                        for (int i = 0; i < vector2.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector2[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector2[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector2[i];
                            }

                        }

                        label2.Text = _titulo_campo;
                        label2.Visible = true;

                        if (_tipo_campo == "FECHA")
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
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox2.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }

                    if (_contador == 3)
                    {
                        string[] vector3 = Vector(_nombre_campo);
                        for (int i = 0; i < vector3.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector3[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector3[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector3[i];
                            }

                        }

                        label3.Text = _titulo_campo;
                        label3.Visible = true;

                        if (_tipo_campo == "FECHA")
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
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox3.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }

                    if (_contador == 4)
                    {
                        string[] vector4 = Vector(_nombre_campo);
                        for (int i = 0; i < vector4.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector4[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector4[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector4[i];
                            }

                        }

                        label4.Text = _titulo_campo;
                        label4.Visible = true;

                        if (_tipo_campo == "FECHA")
                        {


                            dtFecha4.Location = new Point(1045, 185);
                            dtFecha4.Visible = true;
                            this.Controls.Add(dtFecha4);

                            _fecha4 = true;
                        }
                        else
                        {
                            textBox4.Visible = true;
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox4.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }

                    if (_contador == 5)
                    {
                        string[] vector5 = Vector(_nombre_campo);
                        for (int i = 0; i < vector5.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector5[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector5[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector5[i];
                            }

                        }

                        label5.Text = _titulo_campo;
                        label5.Visible = true;

                        if (_tipo_campo == "FECHA")
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
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox5.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }

                    if (_contador == 6)
                    {
                        string[] vector6 = Vector(_nombre_campo);
                        for (int i = 0; i < vector6.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector6[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector6[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector6[i];
                            }

                        }

                        label6.Text = _titulo_campo;
                        label6.Visible = true;

                        if (_tipo_campo == "FECHA")
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
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox6.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }
                    if (_contador == 7)
                    {
                        string[] vector7 = Vector(_nombre_campo);
                        for (int i = 0; i < vector7.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector7[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector7[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector7[i];
                            }

                        }

                        label7.Text = _titulo_campo;
                        label7.Visible = true;

                        if (_tipo_campo == "FECHA")
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
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox7.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }

                    if (_contador == 8)
                    {
                        string[] vector8 = Vector(_nombre_campo);
                        for (int i = 0; i < vector8.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector8[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector8[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector8[i];
                            }

                        }

                        label8.Text = _titulo_campo;
                        label8.Visible = true;

                        if (_tipo_campo == "FECHA")
                        {


                            dtFecha8.Location = new Point(1045, 378);
                            dtFecha8.Visible = true;
                            this.Controls.Add(dtFecha8);
                            _fecha8 = true;
                        }
                        else
                        {
                            textBox8.Visible = true;
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox8.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }


                    if (_contador == 9)
                    {
                        string[] vector9 = Vector(_nombre_campo);
                        for (int i = 0; i < vector9.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector9[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector9[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector9[i];
                            }

                        }

                        label9.Text = _titulo_campo;
                        label9.Visible = true;

                        if (_tipo_campo == "FECHA")
                        {


                            dtFecha9.Location = new Point(1045, 425);
                            dtFecha9.Visible = true;
                            this.Controls.Add(dtFecha9);
                            _fecha8 = true;
                        }
                        else
                        {
                            textBox9.Visible = true;
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox9.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }


                    if (_contador == 10)
                    {
                        string[] vector10 = Vector(_nombre_campo);
                        for (int i = 0; i < vector10.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector10[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector10[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector10[i];
                            }

                        }

                        label10.Text = _titulo_campo;
                        label10.Visible = true;

                        if (_tipo_campo == "FECHA")
                        {


                            dtFecha10.Location = new Point(1045, 474);
                            dtFecha10.Visible = true;
                            this.Controls.Add(dtFecha10);
                            _fecha8 = true;
                        }
                        else
                        {
                            textBox10.Visible = true;
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox10.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }



                    if (_contador == 11)
                    {
                        string[] vector11 = Vector(_nombre_campo);
                        for (int i = 0; i < vector11.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector11[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector11[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector11[i];
                            }

                        }

                        label11.Text = _titulo_campo;
                        label11.Visible = true;

                        if (_tipo_campo == "FECHA")
                        {


                            dtFecha11.Location = new Point(1045, 522);
                            dtFecha11.Visible = true;
                            this.Controls.Add(dtFecha11);
                            _fecha8 = true;
                        }
                        else
                        {
                            textBox11.Visible = true;
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox11.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }




                    if (_contador == 12)
                    {
                        string[] vector12 = Vector(_nombre_campo);
                        for (int i = 0; i < vector12.Length; i++)
                        {
                            if (i == 0)
                            {
                                _titulo_campo = vector12[i];
                            }
                            if (i == 1)
                            {
                                _tipo_campo = vector12[i];
                            }
                            if (i == 2)
                            {
                                _max_campo = vector12[i];
                            }

                        }

                        label12.Text = _titulo_campo;
                        label12.Visible = true;

                        if (_tipo_campo == "FECHA")
                        {


                            dtFecha12.Location = new Point(1045, 567);
                            dtFecha12.Visible = true;
                            this.Controls.Add(dtFecha12);
                            _fecha8 = true;
                        }
                        else
                        {
                            textBox12.Visible = true;
                            if (Convert.ToInt16(_max_campo) > 0)
                            {
                                textBox12.MaxLength = Convert.ToInt16(_max_campo);
                            }
                        }



                    }




                    _contador++;
                }
            }


        }

        public static string[] Vector(string cadena)
        {
            string[] vector;

            if (cadena.Contains('?'))
            {
                vector = cadena.Split('?');
            }
            else
            {
                vector = new string[1];
                vector[0] = cadena;
            }
            return vector;
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
