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
        public static  string inscribirEstilistaEnDiplomado(int codigoEst, int codigoDip)
        {
            try
            {
                string consulta = System.String.Format("INSERT INTO REGISTRA(estId,dipId,regFechaInicio,regFechaFin) VALUES (100,01,'4/22/2014','11/20/2014')", codigoEst, codigoDip);
                Datos.Datos.ejecutarDML(consulta);
                return System.String.Format("Exito se ha registrado el estilista {0} en el diplomado {1}.", codigoEst, codigoDip);
            }
            catch (Exception ex)
            {
                return "Error: " + procesarExcepcion(ex);
            }
        }
        public static string borrarInscripcionesDeEstilista(int codigo)
        {
            try
            {
                string consulta = System.String.Format("DELETE FROM REGISTRA WHERE estId = {0}", codigo);
                int filasAfectadas = Datos.Datos.ejecutarDML(consulta);
                if(filasAfectadas == 0)
                    return System.String.Format("Error, el estilista {0} no tiene matriculas", codigo, filasAfectadas);
                return System.String.Format("Exito, el estilista {0} estaba inscrito en {1} diplomado(s)", codigo, filasAfectadas);
            }
            catch (Exception ex)
            {
                return "Error: " + procesarExcepcion(ex);
            }
        }
        public static string borrarInscripcionesEnUnDiplomado(int codigo)
        {
            try
            {
                string consulta = System.String.Format("DELETE FROM REGISTRA WHERE dipId = {0}", codigo);
                int filasAfectadas = Datos.Datos.ejecutarDML(consulta);
                if (filasAfectadas == 0)
                    return System.String.Format("El diplomado {0} no tenia  estilistas inscritos.", codigo, filasAfectadas);
                return System.String.Format("Exito, el diplomado {0} tenia {1} estilista(s) inscrito(s).", codigo, filasAfectadas);
            }
            catch (Exception ex)
            {
                return "Error: " + procesarExcepcion(ex);
            }
        }
        public static DataSet consultarTodasLasInscripciones()
        {
            string consulta;
            DataSet ds = new DataSet();
            consulta = "SELECT DIPLOMADO.dipId, dipNombre, dipHorasDuracion,dipModalidad, ESTILISTA.estId, estNombre, estGenero, estFechaNacimiento, regFechaInicio, regFechaFin"
                     +" FROM (DIPLOMADO  INNER JOIN REGISTRA"
                            +" ON DIPLOMADO.dipId = REGISTRA.dipId) INNER JOIN ESTILISTA"
                            +" ON ESTILISTA.estId = REGISTRA.estId"
                     + " ORDER BY DIPLOMADO.dipId";
            ds = Datos.Datos.ejecutarSELECT(consulta);
            return ds;
        }
        public static DataSet buscarInscripcion(string fechaInicio)
        {
            string consulta;
            DataSet ds = new DataSet();
            consulta = System.String.Format("SELECT DIPLOMADO.dipId as 'Codigo Diplomado', dipNombre as 'Nombre Diplomado', " +
                               "ESTILISTA.estId as 'Codigo estilista',estNombre as 'Nombre estilista', estGenero as 'Genero estilista', " +
                               "regFechaFin as 'Fecha Fin Diplomado' " +
                       "FROM  (DIPLOMADO  INNER JOIN REGISTRA " +
                             "ON DIPLOMADO.dipId = REGISTRA.dipId) INNER JOIN ESTILISTA " +
                             "ON ESTILISTA.estId = REGISTRA.estId " +
                       "WHERE DateDiff(dd, regFechaInicio, '{0}' ) = 0",fechaInicio);
            Console.WriteLine(consulta);
            ds = Datos.Datos.ejecutarSELECT(consulta);
            return ds;
        }
        private static string procesarExcepcion(Exception ex)
        {
            string msg = ex.Message;
            if (msg.IndexOf("PRIMARY") != -1)
                return "el estilista ya esta registrado en el diplomado.";
            if (msg.IndexOf("fk_estReg") != -1)
                return "no existe el estilista.";
            if (msg.IndexOf("fk_dipReg") != -1)
                return "no existe el diplomado.";
            return msg;
        }
    }
}