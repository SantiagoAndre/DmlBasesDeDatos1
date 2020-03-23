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
            //GUARDA UNA CIUDAD EN LA BASE DE DATOS
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
            //OBTIENE TODOS LAS CIUDADES DE LA BASE DE DATOS
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
        internal static string getNombre(decimal codigo)
        {
            //OBTIENE EL NOMBRE DE UNA CIUDAD
            string query = "SELECT ciuNombre AS NOMBRE  FROM CIUDAD WHERE ciuCodigo = "+codigo.ToString();
            try
            {
                DataTable dt = Datos.Datos.executeQuery(query);
                if (dt.Rows.Count == 0)
                    return "";

                return dt.Rows[0]["NOMBRE"].ToString();


            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private static string processException(Exception ex)
        {
            //PROCESA LAS EXCEPCIONES DE LA BASE DEDATOS PARA COLOCAR MENSAJES ENTENDIBLES AL USUARIO
            string msg = ex.Message;
            if (msg.IndexOf("unique") != -1)
                return "ya existe un Ciudad con ese codigo";
            return msg;
        }

       
    }
}
