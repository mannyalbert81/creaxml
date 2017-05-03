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
    public partial class InstalarLicencias : Form
    {
        public InstalarLicencias()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DataTable dtLicencias = AccesoLogica.Select("*", "licencias", "id_licencias > 0");
            int registro = dtLicencias.Rows.Count;

            if (registro > 0)
            {

                MessageBox.Show("Ya existe una licencia registrada", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { 

            string _error = "";
            string _descripcion_licencias = txt_entidad.Text;
            string _cantidad_licencias = txt_cantidad_licencias.Text;
            string _numero_licencias_registradas = txt_serial_inicio.Text;
            
            

            if (_descripcion_licencias.Length == 0)
            {
                _error = "Debe Indicar una Entidad";
            }
            if (_cantidad_licencias.Length == 0)
            {
                _error = "Debe Indicar una Cantidad de Licencias";
            }
            if (_numero_licencias_registradas.Length == 0)
            {
                _error = "Debe Indicar un serial de Inicio";
            }

            

            if (_error.Length == 0)
            {
                string descripcion = AccesoLogica.cifrar(_descripcion_licencias);
                string cantidad = AccesoLogica.cifrar(_cantidad_licencias);
                string numero = AccesoLogica.cifrar(_numero_licencias_registradas);

                string datos = descripcion + "?" + cantidad + "?" + numero;
                string columnas = "descripcion?cantidad?numero";
                string tipodatos = "NpgsqlDbType.Varchar?NpgsqlDbType.Varchar?NpgsqlDbType.Varchar";


                try
                {
                    int resul = AccesoLogica.Insert(datos, columnas, tipodatos, "ins_licencias");
                    if (resul < 0)
                    {
                        MessageBox.Show("La Licencia se ha Registrado Correctamente", "Guardado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiar();
                            txt_entidad.Enabled = false;
                            txt_serial_inicio.Enabled = false;
                            txt_cantidad_licencias.Enabled = false;
                            btnGuardar.Enabled = false;
                            btnLimpiar.Enabled = false;

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
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {

            txt_entidad.Text = "";
            txt_cantidad_licencias.Text = "";
            txt_serial_inicio.Text = "";
           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InstalarLicencias_FormClosing(object sender, FormClosingEventArgs e)
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

        private void InstalarLicencias_Load(object sender, EventArgs e)
        {


            DataTable dtLicencias = AccesoLogica.Select("*", "licencias", "id_licencias > 0");
            int registro = dtLicencias.Rows.Count;

            if (registro > 0)
            {
                txt_entidad.Enabled = false;
                txt_serial_inicio.Enabled = false;
                txt_cantidad_licencias.Enabled = false;
                btnGuardar.Enabled = false;
                btnLimpiar.Enabled = false;
               

            }
            else {

                txt_entidad.Enabled = true;
                txt_serial_inicio.Enabled = true;
                txt_cantidad_licencias.Enabled = true;
                btnGuardar.Enabled = true;
                btnLimpiar.Enabled = true;
            }


            }
    }
}
