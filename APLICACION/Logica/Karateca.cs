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
            //REGISTRA UN KARATECA RN LA BASE DE DATOS
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
            //ACTUALIZA LA INFORMACION DE UN KARATECA EN LA BASE DE DATOS
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
            //ELIMINA UN KARATECA DE LA BASE DE DATOS
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
            //BUSCA UN CARATECA EN LA BASE DE DATOS
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
        internal static int contarParticipanModalidadAnio(string modalidad,int anio)
        {
            /*Buscar por fecha de participación: Se solicitará al usuario que ingrese (seleccione)
            la fecha de participación, se desplegará el nombre torneo, código, nombre, apellido del Karateca
              nombre ciudad de donde es oriundo y hora participación.*/
            string query = System.String.Format("select count(karateca.karatcodigo) as \"CANTIDAD\" from karateca inner join participa on karateca.karatcodigo = participa.karatcodigo inner join torneo on torneo.torcodigo = participa.karatcodigo where TORMODALIDAD= '{0}' and extract (year from participa.partfecha) = {1}", modalidad,anio);
            DataTable dt = Datos.Datos.executeQuery(query);
            string cantidad = dt.Rows[0]["CANTIDAD"].ToString();
            return Int32.Parse(cantidad);
        }
        private static string processException(Exception ex)
        {
            string msg = ex.Message;
            if (msg.IndexOf("PK_KARATECA") != -1)
                return "ya existe un karateca con ese codigo.";
            if (msg.IndexOf("CKC_KARATPESO") != -1)
                return "El peso del karateca debe estar entre 30kg y 60kg.";
            return msg;
        }

    }
}
