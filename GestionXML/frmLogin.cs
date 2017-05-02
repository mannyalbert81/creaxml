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
            int _id_licencias = 0;
            int _numero_licencias_registradas = 0;
            int _cantidad_licencias = 0;
            string _mac_adres_maquina = "";
            string _nombre_sesion_maquina = "";
            string _ip_maquina = "";
            string _mac = "";
            string _mac1 = "";

            _mac1 = HardwareInfo.GetMACAddress();
            // CONSULTO USUARIO Y CLAVE


            DataTable dtUsuario = AccesoLogica.Select("nombre_usuarios", "usuarios", "usuario_usuarios = '" + _usuario_usuarios + "' AND clave_usuarios = '" + _clave_usuarios + "'  ");
            foreach (DataRow renglon in dtUsuario.Rows)
            {
                _nombre_usuarios = Convert.ToString(renglon["nombre_usuarios"].ToString());
               
            }
            int registro = dtUsuario.Rows.Count;

            // CONSULTO NUMERO DE LICENCIAS

            DataTable dtLicencias = AccesoLogica.Select("licencias.id_licencias, licencias.numero_licencias_registradas, licencias.cantidad_licencias", "licencias", "licencias.id_licencias > 0");
            foreach (DataRow renglon_li in dtLicencias.Rows)
            {
                 _id_licencias = Convert.ToInt32(renglon_li["id_licencias"].ToString());
                 _numero_licencias_registradas = Convert.ToInt32(renglon_li["numero_licencias_registradas"].ToString());
                 _cantidad_licencias = Convert.ToInt32(renglon_li["cantidad_licencias"].ToString());
            }


            ///consulto licencias detalle
            DataTable dtLicencias_detalle1 = AccesoLogica.Select("mac_adres_maquina", "licencias_detalle", "licencias_detalle.id_licencias_detalle > 0");
            foreach (DataRow renglon_de1 in dtLicencias_detalle1.Rows)
            {
                _mac = Convert.ToString(renglon_de1["mac_adres_maquina"].ToString());

            }

             if (registro > 0)
            {

                if (_mac == _mac1)
                {
                    frmMenucs frm = new frmMenucs();
                    frm._nombre_usuarios = _nombre_usuarios;
                    frm.Show();
                    this.Hide();

                }
                
                else if (_cantidad_licencias > 0 )
                {

                    _mac_adres_maquina = HardwareInfo.GetMACAddress();

                    string datos = _id_licencias + "?" + _numero_licencias_registradas + "?" + _mac_adres_maquina + "?" + _nombre_sesion_maquina + "?" + _ip_maquina;
                    string columnas = "_id_licencias?_numero_licencias_registradas?_mac_adres_maquina?_nombre_sesion_maquina?_ip_maquina";
                    string tipodatos = "NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Varchar? NpgsqlDbType.Varchar?NpgsqlDbType.Varchar";
                    int resul = AccesoLogica.Insert(datos, columnas, tipodatos, "ins_licencias_detalle");


                    try
                    {
                        int can_numero = _cantidad_licencias - 1;
                        int numero = _numero_licencias_registradas + 1;
                        int result = AccesoLogica.Update("licencias", "cantidad_licencias = '" + can_numero + "', numero_licencias_registradas = '" + numero + "'", "id_licencias= '" + _id_licencias + "'");




                        DataTable dtLicencias_detalle = AccesoLogica.Select("mac_adres_maquina", "licencias_detalle", "licencias_detalle.id_licencias= '" + _id_licencias + "'");
                        foreach (DataRow renglon_de in dtLicencias_detalle.Rows)
                        {
                            _mac = Convert.ToString(renglon_de["mac_adres_maquina"].ToString());

                        }

                        if (_mac_adres_maquina == _mac)
                        {

                            frmMenucs frm = new frmMenucs();
                            frm._nombre_usuarios = _nombre_usuarios;
                            frm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Maquina No Registrada", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txt_usuario.Text = "";
                            txt_password.Text = "";
                        }

                    }
                    catch (NpgsqlException errores)
                    {

                        MessageBox.Show(errores.Message, "Error");

                    }
              }
                else if (_mac != _mac1)
                {
                    MessageBox.Show("Maquina No Registrada", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_usuario.Text = "";
                    txt_password.Text = "";

                }
            }

            else if (registro <= 0)
            {

                MessageBox.Show("Usuario o Clave Incorrecta", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

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