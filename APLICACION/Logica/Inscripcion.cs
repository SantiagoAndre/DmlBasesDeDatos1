using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION.Logica
{
    public static class Inscripcion
    {
        public static  string enrollingEstilistaInDiplomado(int codeEst, int codeDip, string startDate, string endDate)
        {
            try
            {
                string query = System.String.Format("INSERT INTO REGISTRA(estId,dipId,regFechaInicio,regFechaFin) VALUES ({0},{1},'{2}','{3}')", codeEst, codeDip,startDate,endDate);
                Datos.Datos.executeNonQuery(query);
                return System.String.Format("Exito se ha registrado el estilista {0} en el diplomado {1}.", codeEst, codeDip);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static string dropEstilistaFromAllDiplomados(int codigo)
        {
            try
            {
                string query = System.String.Format("DELETE FROM REGISTRA WHERE estId = {0}", codigo);
                int rowsAffected = Datos.Datos.executeNonQuery(query);
                if(rowsAffected == 0)
                    return System.String.Format("Error, el estilista {0} no tiene matriculas", codigo, rowsAffected);
                return System.String.Format("Exito, el estilista {0} estaba inscrito en {1} diplomado(s)", codigo, rowsAffected);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static string dropAllEstilistasFromDiplomado(int codigo)
        {
            try
            {
                string query = System.String.Format("DELETE FROM REGISTRA WHERE dipId = {0}", codigo);
                int rowsAffected = Datos.Datos.executeNonQuery(query);
                if (rowsAffected == 0)
                    return System.String.Format("El diplomado {0} no tenia  estilistas inscritos.", codigo, rowsAffected);
                return System.String.Format("Exito, el diplomado {0} tenia {1} estilista(s) inscrito(s).", codigo, rowsAffected);
            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }
        public static DataTable getAllInscriptions()
        {
            string query;
            query = "SELECT DIPLOMADO.dipId, dipNombre, dipHorasDuracion,dipModalidad,"+
                           "ESTILISTA.estId, estNombre, estGenero, estFechaNacimiento, "+
             		       "regFechaInicio, regFechaFin "+
                    "FROM (DIPLOMADO  INNER JOIN REGISTRA ON DIPLOMADO.dipId = REGISTRA.dipId) "+
                    "INNER JOIN ESTILISTA ON ESTILISTA.estId = REGISTRA.estId ORDER BY DIPLOMADO.dipId; ";
            return Datos.Datos.executeQuery(query);
            
        }
        public static DataTable findInscription(string fechaInicio)
        {
            string query;
            DataSet ds = new DataSet();
            query = System.String.Format("SELECT DIPLOMADO.dipId as 'Codigo Diplomado', dipNombre as 'Nombre Diplomado', " +
                               "ESTILISTA.estId as 'Codigo estilista',estNombre as 'Nombre estilista', estGenero as 'Genero estilista', " +
                               "regFechaFin as 'Fecha Fin Diplomado' " +
                       "FROM  (DIPLOMADO  INNER JOIN REGISTRA " +
                             "ON DIPLOMADO.dipId = REGISTRA.dipId) INNER JOIN ESTILISTA " +
                             "ON ESTILISTA.estId = REGISTRA.estId " +
                       "WHERE DateDiff(dd, regFechaInicio, '{0}' ) = 0",fechaInicio);
            Console.WriteLine(query);
            return  Datos.Datos.executeQuery(query);
        }
        private static string processException(Exception ex)
        {
            string msg = ex.Message;
            if (msg.IndexOf("PRIMARY") != -1)
                return "el estilista ya esta registrado en el diplomado con esa fecha de inicio.";
            if (msg.IndexOf("fk_estReg") != -1)
                return "no existe el estilista.";
            if (msg.IndexOf("fk_dipReg") != -1)
                return "no existe el diplomado.";
            return msg;
        }
    }
}