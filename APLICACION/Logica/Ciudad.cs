using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION.Logica
{
    public static class Ciudad
    {
        public static string guardar(int codigo, string nombre)
        {
            string query = System.String.Format("INSERT INTO CIUDAD(ciuCodigo,ciuNombre) VALUES ({0},'{1}')", codigo, nombre);
            try
            {
                Datos.Datos.executeNonQuery(query);
                return System.String.Format("Exito: se ha registrado el Ciudad {0}.", codigo);

            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }

        public static DataTable listar()
        {
            string query = "SELECT ciuCodigo AS CODIGO ,ciuNombre AS NOMBRE  FROM CIUDAD";
            try
            {
                return Datos.Datos.executeQuery(query);


            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private static string processException(Exception ex)
        {
            string msg = ex.Message;
            if (msg.IndexOf("unique") != -1)
                return "ya existe un Ciudad con ese codigo";
            return msg;
        }
    }
}
