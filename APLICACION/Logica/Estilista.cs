using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION.Logica
{


    public  static class Estilista
    {
        
        public static string recorderEstilista(int code, string name, char gender, string birthdate)
        {
            string query = System.String.Format("INSERT INTO ESTILISTA(estId,estNombre,estGenero,estFechaNacimiento) VALUES ({0},'{1}','{2}','{3}')", code,name,gender,birthdate);
            try
            {
                Datos.Datos.executeNonQuery(query);
                return System.String.Format("exito se ha registrado el estilista {0}.", code);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static  string updateEstilista(int code, string name, char gender, string birthdate)
        {
            string query = System.String.Format("UPDATE ESTILISTA SET estNombre = '{1}', estGenero = '{2}', estFechaNacimiento = '{3}'  WHERE estId = {0};", code, name, gender, birthdate);
            try
            {
                int rowsAffected = Datos.Datos.executeNonQuery(query);
                if (rowsAffected == 1)
                    return System.String.Format("exito se ha actualizado el estilista {0}.", code);
                else
                    return System.String.Format("error el estilista {0} no existe.", code);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static  string dropEstilista(int code, Boolean cascada)
        {
            try
            {
                String respuesta;
                if (cascada)
                {
                    respuesta = Inscripcion.dropEstilistaFromAllDiplomados(code);
                }else
                    respuesta = "";
                string query = System.String.Format("DELETE FROM ESTILISTA WHERE estId = {0}", code);
                int rowsAffected = Datos.Datos.executeNonQuery(query);
                if (rowsAffected == 1)
                    return respuesta + System.String.Format("exito se ha eliminado el estilista {0}.", code);
                else if (cascada)
                    return System.String.Format("Error:, el estilista {0} no existe.", code);
                return System.String.Format("El estilista {0} no existe.", code);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static DataTable findEstilista(int code)
        {
            string query = System.String.Format("SELECT estId AS 'CODIGO', estNombre AS 'NOMBRE', estGenero AS 'GENERO', estFechaNacimiento AS 'FECHA_NACIMIENTO' " +
                                                   "FROM ESTILISTA " +
                                                   "WHERE estId = {0}", code);
            return  Datos.Datos.executeQuery(query);

        }
        public static DataTable findEstilista(int code, string name, char gender, string birthdate)
        {
            string condition = "";
            if (code != -1)
                condition = System.String.Format("AND estId = {0} ", code);
            if (name != null)
                condition = condition + System.String.Format("AND estNombre like '{0}' " , name);
            if (gender != ' ')
                condition = condition + System.String.Format(" AND estGenero = '{0}'", gender);
            if (birthdate != null)
                condition = condition + System.String.Format(" AND DateDiff(dd,estFechaNacimiento,'{0}') = 0 ", birthdate);
            if (!condition.Equals(""))
                condition = "WHERE " + condition.Substring(3);
            string query = "SELECT estId AS 'CODIGO', estNombre AS 'NOMBRE', "+
                                  "CASE estGenero "+
                                  "WHEN 'F' THEN 'FEMENINO' "+
                                  "WHEN 'M' THEN 'MASCULINO' "+
                                  "ELSE 'OTRO' " +
                                  "END AS 'GENERO', "+
	                              "estFechaNacimiento AS 'FECHA_NACIMIENTO' " +
                            "FROM ESTILISTA " + condition;
            return Datos.Datos.executeQuery(query);
        }
        private static string processException(Exception ex)
        {
            string msg = ex.Message;
            if (msg.IndexOf("PRIMARY") != -1)
                return "ya existe un diplomado con ese codigo.";
            if (msg.IndexOf("fk_estReg") != -1)
                return "el estilista esta matriculado en en varios diplomados.";
            if (msg.IndexOf("ckc_estGenero") != -1)
                return "El valor en la columna genero solo puede ser 'F' o 'M'";
            return msg;
        }
    }
}
