using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION.Logica
{


    public  static class Torneo
    {
        
        public static string crear(int codigo, String nombre, String modalidad, String frecuencia)
        {
            string query = System.String.Format("INSERT INTO TORNEO(torCodigo,torNombre,torFrecuencia,torModalidad) VALUES ({0},'{1}','{2}','{3}')", codigo,nombre,frecuencia,modalidad);
            try
            {
                Datos.Datos.executeNonQuery(query);
                return System.String.Format("exito se ha registrado el torneo {0}.", codigo);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static  string actualizar(int codigo, String nombre, String modalidad, String frecuencia)
        {
            string query = System.String.Format("UPDATE TORNEO SET torNombre = '{1}', torFrecuencia = '{2}', torModalidad = '{3}' WHERE torCodigo = {0}", codigo, nombre, frecuencia, modalidad);
            try
            {
                int rowsAffected = Datos.Datos.executeNonQuery(query);
                if (rowsAffected == 1)
                    return System.String.Format("exito se ha actualizado el torneo {0}.", codigo);
                else
                    return System.String.Format("error el torneo {0} no existe.", codigo);
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
                string query = System.String.Format("DELETE FROM TORNEO WHERE torCodigo = {0}", codigo);
                int rowsAffected = Datos.Datos.executeNonQuery(query);
                if (rowsAffected == 1)
                    return respuesta + System.String.Format("exito se ha eliminado el torneo {0}.", codigo);

                return System.String.Format("El torneo {0} no existe.", codigo);
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
                
                string query = System.String.Format("SELECT torCodigo AS CODIGO, torNombre as NOMBRE, torModalidad AS MODALIDAD, torFrecuencia AS FRECUENCIA FROM TORNEO WHERE torCodigo = {0}", codigo);
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
            if (msg.IndexOf("ckc_torCodigo") != -1)
                return "El codigo no debe ser negativo.";

            if (msg.IndexOf("ckc_torFrecuencia") != -1)
                return "La frecuencia es anual o semestral";
            if (msg.IndexOf("ckc_torModalidad") != -1)
                return "La modalidad es infantil, juvenil o adultos";
            return msg;
        }

    }
}
