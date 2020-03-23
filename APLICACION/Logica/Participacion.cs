using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION.Logica
{
    public static class Participacion
    {
        public static string registrar( int codigoKarateca,  int codigoTorneo,  string fecha,  string hora)
        {
            string query = System.String.Format("INSERT INTO PARTICIPA(partFecha, karatCodigo,torCodigo)  VALUES(TO_DATE('{2} {3}', 'dd/mm/yyyy HH24:MI:SS'),{0},{1})", codigoKarateca, codigoTorneo, fecha, hora);
            try
            {
                Datos.Datos.executeNonQuery(query);
                return "Exito: se ha registrado la participacion.";

            }
            catch (Exception ex)
            {
                return "Error: " + processException(ex);
            }
        }

        internal static DataTable filtrarPorFecha(string fecha)
        {
            string query = "select  KARATECA.karatCodigo as \"CODIGO KARATECA\" , karatNombre AS \"NOMBE CARATECA\", karatNombre AS \"APELLIDO KARATECA\", karatPeso AS \"PESO KARATECA\", TORNEO.torCodigo AS \"CODIGO TORNEO\", torNombre AS \"NOMBRE TORNEO\", torModalidad AS \"MODALIDAD\", torFrecuencia AS \"FRECUENCIA\", TO_CHAR(partFecha, 'yyyy/mm/dd') AS \"FECHA\", TO_CHAR(partFecha, 'hh24:mi:ss') AS \"HORA\" from ciudad inner join karateca on ciudad.ciucodigo = karateca.ciucodigo inner join participa on participa.karatcodigo = karateca.karatcodigo inner join torneo on torneo.torcodigo = participa.torcodigo";
            return Datos.Datos.executeQuery(query);
        }

        public  static DataTable obtenerTodas()
        {
            string query = "select  KARATECA.karatCodigo as \"CODIGO KARATECA\" , karatNombre AS \"NOMBE CARATECA\", karatNombre AS \"APELLIDO KARATECA\", karatPeso AS \"PESO KARATECA\", TORNEO.torCodigo AS \"CODIGO TORNEO\", torNombre AS \"NOMBRE TORNEO\", torModalidad AS \"MODALIDAD\", torFrecuencia AS \"FRECUENCIA\", TO_CHAR(partFecha, 'yyyy/mm/dd') AS \"FECHA\", TO_CHAR(partFecha, 'hh24:mi:ss') AS \"HORA\" from karateca inner join participa on karateca.karatcodigo = participa.karatcodigo inner join torneo on torneo.torcodigo = participa.karatcodigo";
            return Datos.Datos.executeQuery(query);
        }
            
        private static string processException(Exception ex)
        {
            string msg = ex.Message;
            if (msg.IndexOf("fk_participa_torneo ") != -1)
                return "no existe un torneo con ese codigo";
            if (msg.IndexOf("fk_participa_karateca  ") != -1)
                return "no existe un karateca con ese codigo";
            if (msg.IndexOf("uq_participa   ") != -1)
                return "ya hay una participacion  del karateca en ese torneo  en el mismo dia";
            return msg;
        }
    }
}
