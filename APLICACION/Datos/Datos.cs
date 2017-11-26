using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace APLICACION.Datos
{
    public static class Datos
    {
        //Paso 1: construir la cadena de conexion
        public static string CADENA_CONECCION = @"Data Source=DESKTOP-HQNIK6L\SQLEXPRESS;Initial Catalog=DIPLOMADO;User ID=sa;Password='sa2016'";
        //Metodo para insertar,actualizar  y borrar
        public static int ejecutarDML(string consulta)
        {
            try
            {
                int filasAfectadas;
                //Paso 1: creo una conexion
                SqlConnection coneccion = new SqlConnection(CADENA_CONECCION);
                //Paso 2: crear un comando
                SqlCommand comando = new SqlCommand(consulta, coneccion);
                //Paso 3: abro la conexion
                coneccion.Open();
                //Paso 4: ejecuto el comando,este metodo devuelve el numero de filas que se afectaron
                filasAfectadas = comando.ExecuteNonQuery();
                //Paso 5: cerrar conexion
                coneccion.Close();
                return filasAfectadas;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public static DataSet ejecutarSELECT(string consulta)
        {
            //Paso 1: crear un dataset vacio
            DataSet miDS = new DataSet();
            //Paso 2: crear un adaptador 
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, CADENA_CONECCION);
            Console.WriteLine(consulta);
            adaptador.Fill(miDS, "ResultadoDatos");
            return miDS;
        }
    }
}
