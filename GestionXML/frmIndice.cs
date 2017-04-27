using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Npgsql;

namespace GestionXML
{
    public partial class frmIndice : Form
    {
        public frmIndice()
        {
            InitializeComponent();
        }

        private void frmIndice_Load(object sender, EventArgs e)
        {
            {
                clases.Funciones.CargarCombo(cbm_caminos, "id_caminos", "nombre_caminos", "caminos");
                clases.Funciones.CargarCombo(cbm_tipo_indice, "id_tipo_indice", "nombre_tipo_indice", "tipo_indice");
                
                llenar_grid("tipo_indice.id_tipo_indice = temp_indice.id_tipo_indice");

            }
        }
        private void llenar_grid(string _parametro)
        {
            clases.Funciones.CargarGridView(dataGridIndice, "temp_indice.id_temp_indice AS Id, tipo_indice.nombre_tipo_indice, temp_indice.nombre_indice_detalle, temp_indice.min_indice_detalle, temp_indice.max_indice_detalle, temp_indice.orden_indice_detalle", "public.temp_indice, public.tipo_indice", _parametro, "Id?Tipo?Nombre Indice?Min?Max?Orden");


        }

        public void limpiar()
        {

            txt_nombre_indice_detalle.Text = "";
            txt_min.Text = "";
            txt_max.Text = "";
            comboBox1.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int _id_tipo_indice = 0;
            string _nombre_indice_detalle = "";
            int _min_indice_detalle = 0;
            int _max_indice_detalle = 0;
            int _orden_indice_detalle = 0;
            int _id_indice_cabeza = 0;
            int numeros = 0;
            int registros = 0;

            string columnas1 = "temp_indice.id_temp_indice, tipo_indice.id_tipo_indice, tipo_indice.nombre_tipo_indice, temp_indice.nombre_indice_detalle, temp_indice.min_indice_detalle, temp_indice.max_indice_detalle, temp_indice.orden_indice_detalle";
            string tablas = "public.tipo_indice,  public.temp_indice";
            string where = "temp_indice.id_tipo_indice = tipo_indice.id_tipo_indice";


            DataTable dtTemporal = AccesoLogica.Select(columnas1, tablas, where);
             registros = dtTemporal.Rows.Count;
            if (registros <= 0)
            {
                MessageBox.Show("No existe datos para Guardar", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (registros > 0)
            {


                string _error = "";
                string _nombre_indice_cabeza = txt_nombre_indice.Text;
                int _id_caminos = Convert.ToInt16(cbm_caminos.SelectedValue.ToString());


                if (_nombre_indice_cabeza.Length == 0)
                {
                    _error = "Debe Indicar un Nombre de Indice Cabeza";
                }

                if (_error.Length == 0)

                {
                    string datos = _nombre_indice_cabeza + "?" + _id_caminos;
                    string columnas = "_nombre_indice_cabeza?_id_caminos";
                    string tipodatos = "NpgsqlDbType.Varchar?NpgsqlDbType.Integer";


                    try
                    {
                        int resul = AccesoLogica.Insert(datos, columnas, tipodatos, "ins_indice_cabeza");

                        string columnas3 = "indice_cabeza.id_indice_cabeza";
                        string tablas3 = "public.indice_cabeza";
                        string where3 = "indice_cabeza.nombre_indice_cabeza = '" + _nombre_indice_cabeza + "' AND indice_cabeza.id_caminos = '" + _id_caminos + "'";

                        DataTable dtCabeza = AccesoLogica.Select(columnas3, tablas3, where3);

                        foreach (DataRow renglon in dtCabeza.Rows)
                        {
                            _id_indice_cabeza = Convert.ToInt32(renglon["id_indice_cabeza"].ToString());
                        }



                        foreach (DataRow renglon in dtTemporal.Rows)
                        {
                            

                            try
                            {

                                _id_tipo_indice = Convert.ToInt32(renglon["id_tipo_indice"].ToString());
                                _nombre_indice_detalle = Convert.ToString(renglon["nombre_indice_detalle"].ToString());
                                _min_indice_detalle = Convert.ToInt32(renglon["min_indice_detalle"].ToString());
                                _max_indice_detalle = Convert.ToInt32(renglon["max_indice_detalle"].ToString());
                                _orden_indice_detalle = Convert.ToInt32(renglon["orden_indice_detalle"].ToString());

                                string datos2 = _id_indice_cabeza + "?" + _id_tipo_indice + "?" + _nombre_indice_detalle + "?" + _min_indice_detalle + "?" + _max_indice_detalle + "?" + _orden_indice_detalle;
                                string columnas2 = "_id_indice_cabeza?_id_tipo_indice?_min_indice_detalle?_max_indice_detalle?_orden_indice_detalle?_nombre_indice_detalle";
                                string tipodatos2 = "NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Varchar";

                                try
                                {

                                    int result = AccesoLogica.Insert(datos2, columnas2, tipodatos2, "ins_indice_detalle");
                                    numeros = numeros + 1;
                                    limpiar();
                                    int resulT = AccesoLogica.Delete("nombre_indice_detalle = '" + _nombre_indice_detalle + "' ", "temp_indice");
                                    llenar_grid("tipo_indice.id_tipo_indice = temp_indice.id_tipo_indice");

                                   
                                   
                                }
                                catch (NpgsqlException)
                                {
                                    MessageBox.Show("No se Pudo Guardar en la Base de Datos " + registros + " Registros", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch
                            {

                            }
                        }

                       if(numeros>0) { 

                        MessageBox.Show("Se ha Registrado Correctamente " + numeros + " Registros", "Guardado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }


                    }
                    catch (NpgsqlException)
                    {
                        MessageBox.Show("No se Pudo Guardar el registro en la Base de Datos " + registros + " Registros", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(_error, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                {
                    string _nombre_indice_detalle = txt_nombre_indice_detalle.Text;

                    if (_nombre_indice_detalle.Length == 0)
                    {
                        _nombre_indice_detalle = "%";
                    }

                    llenar_grid("tipo_indice.id_tipo_indice = temp_indice.id_tipo_indice AND temp_indice.nombre_indice_detalle LIKE '" + _nombre_indice_detalle + "'");
                }
            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string _error = "";
            if (txt_nombre_indice_detalle.Text.Length == 0)
            {
                _error = "EL nombre de indice detalle no Puede estar Vacio";
            }
            if (_error.Length == 0)
            {
                try
                {
                    string _nombre_indice_detalle = txt_nombre_indice_detalle.Text;
                    int resul = AccesoLogica.Delete("nombre_indice_detalle = '" + _nombre_indice_detalle + "' ", "temp_indice");

                    if (resul == 1)
                    {
                        MessageBox.Show("El Detalle se ha Eliminado Correctamente", "Eliminado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        llenar_grid("tipo_indice.id_tipo_indice = temp_indice.id_tipo_indice");
                        limpiar();


                    }
                }
                catch (NpgsqlException)
                {
                    MessageBox.Show(_error, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(_error, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void frmIndice_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
             "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string _error = "";
            string _nombre_indice_detalle = txt_nombre_indice_detalle.Text;
            string _min_indice_detalle = txt_min.Text;
            string _max_indice_detalle = txt_max.Text;
            string _orden_indice_detalle = comboBox1.Text;
            int _id_tipo_indice = Convert.ToInt16(cbm_tipo_indice.SelectedValue.ToString());


            if (_nombre_indice_detalle.Length == 0)
            {
                _error = "Debe Indicar un Nombre de Indice Detalle";
            }

            if (_min_indice_detalle.Length == 0)
            {
                _error = "Debe Indicar un Min";
            }

            if (_max_indice_detalle.Length == 0)
            {
                _error = "Debe Indicar un Max";
            }

            if (_orden_indice_detalle.Length == 0)
            {
                _error = "Debe Indicar un Orden";
            }


            if (_error.Length == 0)

            {
                string datos = _id_tipo_indice + "?" + _nombre_indice_detalle + "?" + _min_indice_detalle + "?" + _max_indice_detalle + "?" + _orden_indice_detalle;
                string columnas = "_id_tipo_indice?_nombre_indice_detalle?_min_indice_detalle?_max_indice_detalle?_orden_indice_detalle";
                string tipodatos = "NpgsqlDbType.Integer?NpgsqlDbType.Varchar?NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer";


                try
                {
                    int resul = AccesoLogica.Insert(datos, columnas, tipodatos, "ins_temp_indice");
                    if (resul < 0)
                    {
                        MessageBox.Show("El Detalle se ha Registrado Correctamente", "Guardado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        llenar_grid("tipo_indice.id_tipo_indice = temp_indice.id_tipo_indice");
                        limpiar();


                    }
                }
                catch (NpgsqlException)
                {
                    MessageBox.Show("No se Pudo Guardar el registro en la Base de Datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(_error, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridIndice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridIndice.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
            txt_nombre_indice_detalle.Text = Convert.ToString(fila.Cells[2].Value);
            cbm_tipo_indice.Text = Convert.ToString(fila.Cells[1].Value);
            txt_min.Text = Convert.ToString(fila.Cells[3].Value);
            txt_max.Text = Convert.ToString(fila.Cells[4].Value);
            comboBox1.Text = Convert.ToString(fila.Cells[5].Value);
        }
       
    }
}
    

