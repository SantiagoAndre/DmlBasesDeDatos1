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
        public static string registrat( int codigoKarateca,  int codigoTorneo,  string fecha,  string hora)
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
