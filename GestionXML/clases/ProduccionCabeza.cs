using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Data;
using System.Windows.Forms;
using Npgsql;


namespace GestionXML.clases
{
    class ProduccionCabeza
    {
        public static void InsertaProduccionCabeza()
        {

            int id_usuarios = 0;
            int xml_creados_produccion_cabeza = 0;
            int xml_error_produccion_cabeza = 0;
            int xml_editados_produccion_cabeza = 0;
            int id_caminos = 0;

            DataTable dtProduccion = AccesoLogica.Select2(" * ", "produccion_cabeza", "id_produccion_cabeza > 0");

            foreach (DataRow renglon in dtProduccion.Rows)
            {
                try
                {
                    id_usuarios = Convert.ToInt32(renglon["id_usuarios"].ToString());
                    xml_creados_produccion_cabeza = Convert.ToInt32(renglon["xml_creados_produccion_cabeza"].ToString());
                    xml_error_produccion_cabeza = Convert.ToInt32(renglon["xml_error_produccion_cabeza"].ToString());
                    xml_editados_produccion_cabeza = Convert.ToInt32(renglon["xml_editados_produccion_cabeza"].ToString());
                    id_caminos = Convert.ToInt32(renglon["id_caminos"].ToString());

                    string datos = id_usuarios + "?" + xml_creados_produccion_cabeza + "?" + xml_error_produccion_cabeza + "?" + xml_editados_produccion_cabeza +"?" + id_caminos;
                    string columnas = "id_usuarios?xml_creados_produccion_cabeza?xml_error_produccion_cabeza?xml_editados_produccion_cabeza?id_caminos";
                    string tipodatos = "NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer";

                    try
                    {
                        int result = AccesoLogica.Insert(datos, columnas, tipodatos, "ins_produccion_cabeza");
                        {
                        }
                    }
                    catch (NpgsqlException)
                    {
                        MessageBox.Show("No se Pudo Guardar el registro en la Base de Datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("No se Pudo Guardar el registro en la Base de Datos2", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Se ha Registrado Correctamente", "Guardado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

