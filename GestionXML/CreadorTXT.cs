using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GestionXML
{
    public partial class CreadorTXT : Form
    {
        public string nombre_pdf = "";
        public string nombre_xml = "";

        public CreadorTXT()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {

                XDocument miXML = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("xml grnerado por utilitarios www.masoft.net"),
                new XElement("root",
                   new XElement("document",
                                new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label1.Text),
                                                new XAttribute("value", textBox1.Text)
                                            ),
                                new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label2.Text),
                                                new XAttribute("value", textBox2.Text)
                                            ),
                                new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label3.Text),
                                                new XAttribute("value", textBox3.Text)
                                            ),
                                new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label4.Text),
                                                new XAttribute("value", textBox4.Text)
                                            ),
                                new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label5.Text),
                                                new XAttribute("value", textBox5.Text)
                                            ),
                                new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label6.Text),
                                                new XAttribute("value", textBox6.Text)
                                            ),
                                new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label7.Text),
                                                new XAttribute("value", textBox7.Text)
                                            ),
                                new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label8.Text),
                                                new XAttribute("value", textBox8.Text)
                                            ),
                                 new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label9.Text),
                                                new XAttribute("value", textBox9.Text)
                                            ),
                                  new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label10.Text),
                                                new XAttribute("value", textBox10.Text)
                                            ),
                                   new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label11.Text),
                                                new XAttribute("value", textBox11.Text)
                                            ),
                                    new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", label12.Text),
                                                new XAttribute("value", textBox12.Text)
                                            ),
                                     new XElement("field",
                                                new XAttribute("level", "document"),
                                                new XAttribute("name", "VALIDADO"),
                                                new XAttribute("value", "1")
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
            catch (Exception Ex)
            {


            }


        }

        private void CreadorTXT_Load(object sender, EventArgs e)
        {
            acrobat.src = nombre_pdf;

            int _contador = 1;
            string _nombre_xml = nombre_pdf.Replace(".pdf", ".XML");
            string _titulo_text = "";
            string _valor_text = "";

            try
            {
                var xdoc = XDocument.Load(@_nombre_xml);

                var items = from i in xdoc.Descendants("field")
                            select new
                            {
                                _name = (string)i.Attribute("name"),
                                _value = (string)i.Attribute("value")
                            };


                foreach (var item in items)
                {

                    // use item.Action or item.FileName
                    if (item._name.ToString() != "")
                    {
                        _titulo_text = item._name.ToString();
                        _valor_text = item._value.ToString();

                    }

                    if (_contador == 1)
                    {
                        label1.Text = _titulo_text;
                        textBox1.Text = _valor_text;
                        label1.Visible = true;
                        textBox1.Visible = true;
                    }

                    if (_contador == 2)
                    {
                        label2.Text = _titulo_text;
                        textBox2.Text = _valor_text;
                        label2.Visible = true;
                        textBox2.Visible = true;
                    }

                    if (_contador == 3)
                    {
                        label3.Text = _titulo_text;
                        textBox3.Text = _valor_text;
                        label3.Visible = true;
                        textBox3.Visible = true;
                    }

                    if (_contador == 4)
                    {
                        label4.Text = _titulo_text;
                        textBox4.Text = _valor_text;
                        label4.Visible = true;
                        textBox4.Visible = true;
                    }

                    if (_contador == 5)
                    {
                        label5.Text = _titulo_text;
                        textBox5.Text = _valor_text;
                        label5.Visible = true;
                        textBox5.Visible = true;
                    }

                    if (_contador == 6)
                    {
                        label6.Text = _titulo_text;
                        textBox6.Text = _valor_text;
                        label6.Visible = true;
                        textBox6.Visible = true;
                    }
                    if (_contador == 7)
                    {
                        label7.Text = _titulo_text;
                        textBox7.Text = _valor_text;
                        label7.Visible = true;
                        textBox7.Visible = true;
                    }

                    if (_contador == 8)
                    {
                        label8.Text = _titulo_text;
                        textBox8.Text = _valor_text;
                        label8.Visible = true;
                        textBox8.Visible = true;
                    }
                    if (_contador == 9)
                    {
                        label9.Text = _titulo_text;
                        textBox9.Text = _valor_text;
                        label9.Visible = true;
                        textBox9.Visible = true;
                    }
                    if (_contador == 10)
                    {
                        label10.Text = _titulo_text;
                        textBox10.Text = _valor_text;
                        label10.Visible = true;
                        textBox10.Visible = true;
                    }
                    if (_contador == 11)
                    {
                        label11.Text = _titulo_text;
                        textBox11.Text = _valor_text;
                        label11.Visible = true;
                        textBox11.Visible = true;
                    }
                    if (_contador == 12)
                    {
                        label12.Text = _titulo_text;
                        textBox12.Text = _valor_text;
                        label12.Visible = true;
                        textBox12.Visible = true;
                    }

                    _contador++;

                }
            }
            catch (Exception Ex)
            {


            }
            
        }





        
    }
}
