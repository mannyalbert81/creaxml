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
    class ProduccionDetalle
    {
        public static void InsertaProduccionDetalle()
        {
            int id_produccion_cabeza = 0;
            int id_caminos = 0;
            string nombre_produccion_detalle = "";
            string inicio_produccion_detalle = "";
            string fin_produccion_detalle = "";
            int id_usuarios_crea = 0;

            DataTable dtProduccionDetalle = AccesoLogica.Select2(" * ", "produccion_detalle", "id_produccion_detalle > 0");
            foreach (DataRow renglon in dtProduccionDetalle.Rows)
            {
                try
                {
                    id_produccion_cabeza = Convert.ToInt32(renglon["id_produccion_cabeza"].ToString());
                    id_caminos = Convert.ToInt32(renglon["id_caminos"].ToString());
                    nombre_produccion_detalle = Convert.ToString(renglon["nombre_produccion_detalle"].ToString());
                    inicio_produccion_detalle = Convert.ToString(renglon["inicio_produccion_detalle"].ToString());
                    fin_produccion_detalle = Convert.ToString(renglon["fin_produccion_detalle"].ToString());
                    id_usuarios_crea = Convert.ToInt32(renglon["id_usuarios_crea"].ToString());

                    string datos = id_produccion_cabeza + "?" + id_caminos + "?" + nombre_produccion_detalle + "?" + inicio_produccion_detalle + "?" + fin_produccion_detalle + "?" + id_usuarios_crea;
                    string columnas = "id_usuarios?xml_creados_produccion_cabeza?xml_error_produccion_cabeza?xml_editados_produccion_cabeza?id_caminos";
                    string tipodatos = "NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer";

                    try
                    {
                        int result = AccesoLogica.Insert(datos, columnas, tipodatos, "ins_produccion_detalle");
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