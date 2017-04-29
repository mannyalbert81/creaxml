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
            string _nombre_usuarios = "";
          
            DataTable dtUsuario = AccesoLogica.Select("nombre_usuarios", "usuarios", "usuario_usuarios = '" + _usuario_usuarios + "' AND clave_usuarios = '" + _clave_usuarios + "'  ");
            foreach (DataRow renglon in dtUsuario.Rows)
            {
                _nombre_usuarios = Convert.ToString(renglon["nombre_usuarios"].ToString());
               
            }

            int registro = dtUsuario.Rows.Count;
            if (registro > 0)
            {

                MessageBox.Show("Bienvenido " + _nombre_usuarios, "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMenucs frm = new frmMenucs();
               
                frm._nombre_usuarios = _nombre_usuarios;
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