using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;



namespace GestionXML
{
    public partial class frmLogin : Form
    {
       

        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string _usuario_usuarios = txt_usuario.Text;
            string _clave_usuarios = txt_password.Text;

            DataTable dtUsuario = AccesoLogica.Select("nombre_usuarios", "usuarios", "usuario_usuarios = '" + _usuario_usuarios + "' AND clave_usuarios = '" + _clave_usuarios + "'  ");
            int registro = dtUsuario.Rows.Count;
            if (registro > 0)
            {

                frmMenucs frm = new frmMenucs();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_usuario.Text = "";
                txt_password.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {


           
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}