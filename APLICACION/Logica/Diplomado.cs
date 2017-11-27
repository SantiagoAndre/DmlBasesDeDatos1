using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION.Logica
{
    public static class Diplomado
    {
        public static string recorderDiplomado(int code, string name, int hours_duration, string modality)
        {
            string query = System.String.Format("INSERT INTO DIPLOMADO(dipId,dipNombre,dipHorasDuracion,dipModalidad) VALUES ({0},'{1}',{2},'{3}')",code,name,hours_duration,modality);
            try {
                Datos.Datos.executeNonQuery(query);
                return System.String.Format("Exito: se ha registrado el diplomado {0}.", code);

            }catch(Exception ex)
            {
                return "Error: "+ processException(ex);
            }
        }
        public static string updateDiplomado(int code,string name, int hours_duration, string modality)
        {
            string query = System.String.Format("UPDATE DIPLOMADO SET dipNombre = '{1}', dipHorasDuracion = {2}, dipModalidad = '{3}' WHERE dipId = {0}", code, name, hours_duration, modality);
            Console.WriteLine(query);
            try
            {
                int rowsAffected = Datos.Datos.executeNonQuery(query);
                if (rowsAffected == 1)
                    return System.String.Format("Exito: se ha actualizado el diplomado {0}.", code);
                else
                    return System.String.Format("Error:  el diplomado {0} no existe.", code);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static string dropDiplomado(int code,Boolean cascade)
        {
            try
            {
                String msgDropInscriptions = "";
                if (cascade)
                {
                    msgDropInscriptions = Inscripcion.dropAllEstilistasFromDiplomado(code);
                }
                else
                    msgDropInscriptions = "";
                string query = System.String.Format("DELETE FROM DIPLOMADO WHERE dipId = {0}", code);
                int rowsAffected = Datos.Datos.executeNonQuery(query);
                if (rowsAffected == 1)
                    return msgDropInscriptions+ System.String.Format("Exito se ha eliminado el diplomado {0}.", code);
                return System.String.Format("Error: el diplomado {0} no existe",code);
            }
            catch (Exception ex)
            {
                return "Error: "+ processException(ex);
            }
        }
        public static DataTable findDiplomado(int code)
        {
            string query = System.String.Format("SELECT dipId AS 'CODIGO', dipNombre AS 'NOMBRE', dipHorasDuracion AS 'HORAS_DURACION',dipModalidad AS 'MODALIDAD'" +
                                                  "FROM DIPLOMADO " +
                                                  "WHERE dipId={0}", code);
            return Datos.Datos.executeQuery(query);

        }
        private static string processException(Exception ex)
        {
            string msg = ex.Message;
            if (msg.IndexOf("PRIMARY") != -1)
                return "ya existe un diplomado con ese codigo";
            if (msg.IndexOf("ckc_dipModalidad") != -1)
                return "la columna modalidad no puede tomar ese valor";
            if (msg.IndexOf("fk_dipReg") != -1)
                return "el diplomado tiene Estilistas inscritos.";
            if (msg.IndexOf("String") != -1)
                return "hay problemas con la longitud de una o varias cadenas de texto.";
            return msg;
        }
    }
}
