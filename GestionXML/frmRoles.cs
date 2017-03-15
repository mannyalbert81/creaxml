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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string _error = "";
            string _nombre_roles = txt_roles.Text;
           
            


            if (_nombre_roles.Length == 0)
            {
                _error = "Debe Indicar un nombre de rol";
            }
            


            if (_error.Length == 0)
            {
                string datos = _nombre_roles;
                string columnas = "_nombre_roles";
                string tipodatos = "NpgsqlDbType.Varchar";


                try
                {
                    int resul = AccesoLogica.Insert(datos, columnas, tipodatos, "ins_roles");
                    if (resul < 0)
                    {
                        MessageBox.Show("El Rol se ha Registrado Correctamente", "Guardado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        llenar_grid();
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

        private void frmRoles_Load(object sender, EventArgs e)
        {

            llenar_grid();
        }


        private void llenar_grid()
        {
            clases.Funciones.CargarGridView(dataGridViewRoles, "usuarios.nombre_usuarios, usuarios.telefono_usuarios, usuarios.celular_usuarios, usuarios.correo_usuarios, rol.nombre_rol, estado.nombre_estado, ciudad.nombre_ciudad, usuarios.usuario_usuarios, usuarios.creado, usuarios.modificado", "rol",  "Nombre?Creado?Modificado");

        }

        public void limpiar()
        {

           

        }

        private void dataGridViewRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
