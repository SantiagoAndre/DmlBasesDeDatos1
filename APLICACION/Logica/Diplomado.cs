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
        public static string registrarDiplomado(int codigo, string nombre, int horas_duracion, string modalidad)
        {
            string consulta = System.String.Format("INSERT INTO DIPLOMADO(dipId,dipNombre,dipHorasDuracion,dipModalidad) VALUES ({0},'{1}',{2},'{3}')",codigo,nombre,horas_duracion,modalidad);
            try {
                Datos.Datos.ejecutarDML(consulta);
                return System.String.Format("exito se ha registrado el diplomado {0}.", codigo);

            }catch(Exception ex)
            {
                return "Error: "+ procesarExcepcion(ex);
            }
        }
        public static string actualizarDiplomado(int codigo,string nombre, int horas_duracion, string modalidad)
        {
            string consulta = System.String.Format("UPDATE DIPLOMADO SET dipNombre = '{1}', dipHorasDuracion = {2}, dipModalidad = '{3}' WHERE dipId = {0}", codigo, nombre, horas_duracion, modalidad);
            Console.WriteLine(consulta);
            try
            {
                int filasAfectadas = Datos.Datos.ejecutarDML(consulta);
                if (filasAfectadas == 1)
                    return System.String.Format("Exito: se ha actualizado el diplomado {0}.", codigo);
                else
                    return System.String.Format("Error:  el diplomado {0} no existe.", codigo);
            }
            catch (Exception ex)
            {
                return "Error: " + procesarExcepcion(ex);
            }
        }
        public static string eliminarDiplomado(int codigo,Boolean cascada)
        {
            try
            {
                String respuesta;
                if (cascada)
                {
                    respuesta = Inscripcion.borrarInscripcionesEnUnDiplomado(codigo);
                }
                else
                    respuesta = "";
                string consulta = System.String.Format("DELETE FROM DIPLOMADO WHERE dipId = {0}", codigo);
                int filasAfectadas = Datos.Datos.ejecutarDML(consulta);
                if (filasAfectadas == 1)
                    return respuesta+ System.String.Format("Exito se ha eliminado el diplomado {0}.", codigo);
                return System.String.Format("Error: el diplomado {0} no existe",codigo);
            }
            catch (Exception ex)
            {
                return "Error: "+ procesarExcepcion(ex);
            }
        }
        public static DataTable buscarDiplomado(int codigo)
        {
            string consulta = System.String.Format("SELECT dipId AS 'CODIGO', dipNombre AS 'NOMBRE', dipHorasDuracion AS 'HORAS_DURACION',dipModalidad AS 'MODALIDAD'" +
                                                  "FROM DIPLOMADO " +
                                                  "WHERE dipId={0}", codigo);
            DataSet datos = Datos.Datos.ejecutarSELECT(consulta);
            if (datos.Tables[0].Rows.Count > 0)
            {
                return datos.Tables[0];
            }
            return null;
        }
        private static string procesarExcepcion(Exception ex)
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
