using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION.Logica
{


    public  static class Karateca
    {
        
        public static string crear(int codigo, string nombre, string apellido, int peso, int ciuCodigo)
        {
            string query = System.String.Format("INSERT INTO KARATECA(karatCodigo,karatNombre,karatApellido,karatPeso,ciuCodigo) VALUES ({0},'{1}','{2}',{3},{4})", codigo,nombre,apellido,peso,ciuCodigo);
            try
            {
                Datos.Datos.executeNonQuery(query);
                return System.String.Format("exito se ha registrado el karateca {0}.", codigo);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static  string actualizar(int codigo, string nombre, string apellido, int peso, int ciuCodigo)
        {
            string query = System.String.Format("UPDATE KARATECA SET karatNombre = '{1}', karatApellido = '{2}', karatPeso = {3}, ciuCodigo = {4}  WHERE karatCodigo = {0}", codigo, nombre, apellido, peso,ciuCodigo);
            try
            {
                int rowsAffected = Datos.Datos.executeNonQuery(query);
                if (rowsAffected == 1)
                    return System.String.Format("exito se ha actualizado el estilista {0}.", codigo);
                else
                    return System.String.Format("error el estilista {0} no existe.", codigo);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static string eliminar(int codigo)
        {
            try
            {
                String respuesta = "";
                string query = System.String.Format("DELETE FROM KARATECA WHERE karatCodigo = {0}", codigo);
                int rowsAffected = Datos.Datos.executeNonQuery(query);
                if (rowsAffected == 1)
                    return respuesta + System.String.Format("exito se ha eliminado el estilista {0}.", codigo);

                return System.String.Format("El estilista {0} no existe.", codigo);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static DataRow buscar(int codigo)
        {
            try
            {
                
                string query = System.String.Format("SELECT karatCodigo AS CODIGO, karatNombre as NOMBRE, karatApellido AS APELLIDO, karatPeso AS PESO , ciuCodigo AS CIUDAD FROM KARATECA WHERE karatCodigo = {0}", codigo);
                DataTable dt = Datos.Datos.executeQuery(query);
                if(dt.Rows.Count == 0)
                {
                    return null; // "Error: no existe el carateca
                }
                else
                {
                    return dt.Select(System.String.Format("CODIGO={0}", codigo))[0];//se devuelve la unica fila que devuelve la consulta
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + processException(ex));
                return null;
            }
        }

        private static string processException(Exception ex)
        {
            string msg = ex.Message;
            if (msg.IndexOf("PRIMARY") != -1)
                return "ya existe un diplomado con ese codigo.";
            if (msg.IndexOf("CKC_KARATPESO") != -1)
                return "El peso del carateca debe estar entre 30kg y 60kg.";
            return msg;
        }

    }
}
