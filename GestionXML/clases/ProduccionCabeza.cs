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
        public static int InsertaProduccionCabeza(int _id_usuarios, int _id_caminos)
        {
            int _id_produccion_cabeza = 0;
            
            int xml_creados_produccion_cabeza = 0;
            int _xml_creados_produccion_cabeza = 0;

            DataTable dtProduccion = AccesoLogica.Select2(" * ", "produccion_cabeza", "id_usuarios = '"+_id_usuarios+"' AND id_caminos = '"+ _id_caminos+"'    ");

            foreach (DataRow renglon in dtProduccion.Rows)
            {
                try
                {
                    _id_usuarios = Convert.ToInt32(renglon["id_usuarios"].ToString());
                    xml_creados_produccion_cabeza = Convert.ToInt32(renglon["xml_creados_produccion_cabeza"].ToString());
                    _id_caminos = Convert.ToInt32(renglon["id_caminos"].ToString());
                    
                }
                catch
                {
                    MessageBox.Show("No se Pudo Guardar el registro en la Base de Datos2", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _xml_creados_produccion_cabeza = xml_creados_produccion_cabeza + 1;

            string datos = _id_usuarios + "?" + _xml_creados_produccion_cabeza  + "?" + _id_caminos;
            string columnas = "id_usuarios?xml_creados_produccion_cabeza?id_caminos";
            string tipodatos = "NpgsqlDbType.Integer?NpgsqlDbType.Integer?NpgsqlDbType.Integer";

            try
            {
                 int result = AccesoLogica.Insert(datos, columnas, tipodatos, "ins_produccion_cabeza");
                
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("No se Pudo Guardar el registro en la Base de Datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return _id_produccion_cabeza;
        }
    }
}