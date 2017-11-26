using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION.Logica
{


    public  static class Estilista
    {
        
        public static string registrarEstilista(int codigo, string nombre, char genero, string fechaNacimiento)
        {
            string consulta = System.String.Format("INSERT INTO ESTILISTA(estId,estNombre,estGenero,estFechaNacimiento) VALUES ({0},'{1}','{2}','{3}')", codigo,nombre,genero,fechaNacimiento);
            try
            {
                Datos.Datos.ejecutarDML(consulta);
                return System.String.Format("exito se ha registrado el estilista {0}.", codigo);
            }
            catch (Exception ex)
            {
                return "Error: " + procesarExcepcion(ex);
            }
        }
        public static  string actualizarEstilista(int codigo, string nombre, char genero, string fechaNacimiento)
        {
            string consulta = System.String.Format("UPDATE ESTILISTA SET estNombre = '{1}', estGenero = '{2}', estFechaNacimiento = '{3}'  WHERE estId = {0};", codigo, nombre, genero, fechaNacimiento);
            try
            {
                int filasAfectadas = Datos.Datos.ejecutarDML(consulta);
                if (filasAfectadas == 1)
                    return System.String.Format("exito se ha actualizado el estilista {0}.", codigo);
                else
                    return System.String.Format("error el estilista {0} no existe.", codigo);
            }
            catch (Exception ex)
            {
                return "Error: " + procesarExcepcion(ex);
            }
        }
        public static  string eliminarEstilista(int codigo, Boolean cascada)
        {
            try
            {
                String respuesta;
                if (cascada)
                {
                    respuesta = Inscripcion.borrarInscripcionesDeEstilista(codigo);
                }else
                    respuesta = "";
                string consulta = System.String.Format("DELETE FROM DIPLOMADO WHERE dipId = {0}", codigo);
                int filasAfectadas = Datos.Datos.ejecutarDML(consulta);
                if (filasAfectadas == 1)
                    return respuesta + System.String.Format("exito se ha eliminado el estilista {0}.", codigo);
                else if (cascada)
                    return System.String.Format("Error:, el estilista {0} no existe.", codigo);
                return System.String.Format("El estilista {0} no existe.", codigo);
            }
            catch (Exception ex)
            {
                return "Error: " + procesarExcepcion(ex);
            }
        }
        private static string procesarExcepcion(Exception ex)
        {
            string msg = ex.Message;
            if (msg.IndexOf("PRIMARY") != -1)
                return "ya existe un diplomado con ese codigo";
            if (msg.IndexOf("ckc_dipModalidad") != -1)
                return "la columna modalidad no puede tomar ese valor";
            if (msg.IndexOf("fk_dipReg") != -1)
                return "el diplomado no existe";
            return msg;
        }
    }
}
