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
    public partial class frmControladores : Form
    {
        public frmControladores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string _error = "";
            string _nombre_controladores = txt_controladores.Text;


            if (_nombre_controladores.Length == 0)
            {
                _error = "Debe Indicar un nombre de Controladores";
            }



            if (_error.Length == 0)
            {
                string datos = _nombre_controladores;
                string columnas = "_nombre_controladores";
                string tipodatos = "NpgsqlDbType.Varchar";


                try
                {
                    int resul = AccesoLogica.Insert(datos, columnas, tipodatos, "ins_controladores");
                    if (resul < 0)
                    {
                        MessageBox.Show("El Controlador se ha Registrado Correctamente", "Guardado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        llenar_grid("id_controladores > 0");
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

        private void frmControladores_Load(object sender, EventArgs e)
        {
            llenar_grid("id_controladores > 0");
        }


        private void llenar_grid(string _parametro)
        {
            clases.Funciones.CargarGridView(dataGridViewControladores, "controladores.id_controladores AS Id, controladores.nombre_controladores, controladores.creado, controladores.modificado", "controladores", _parametro, "Id?Nombre Controlador?Creado?Modificado");

        }

        public void limpiar()
        {
            txt_controladores.Text = "";


        }

        private void dataGridViewControladores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridViewControladores.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
            txt_controladores.Text = Convert.ToString(fila.Cells[1].Value); //obtengo el valor de la primer columna

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string _nombre_controladores = txt_controladores.Text;


            if (_nombre_controladores.Length == 0)
            {
                _nombre_controladores = "%";
            }


            llenar_grid("controladores.nombre_controladores LIKE '" + _nombre_controladores + "'");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string _error = "";
            if (txt_controladores.Text.Length == 0)
            {
                _error = "EL nombre controladores no Puede estar Vacio";
            }
            if (_error.Length == 0)
            {
                try
                {
                    string _controladores = txt_controladores.Text;
                    int resul = AccesoLogica.Delete("nombre_controladores = '" + _controladores + "' ", "controladores");

                    if (resul == 1)
                    {
                        MessageBox.Show("El Controlador se ha Eliminado Correctamente", "Eliminado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        llenar_grid("id_controladores > 0");
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void frmControladores_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
