using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Insertar "librerias", son necesarias para que se reconozcan las palabras clave
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace APLICACION.Datos
{
    public static class Datos
    {
        //Creacion de la cadena de conexión
        static string CONNECTION_STRING = "Data Source=localhost; User ID = system; Password=1234";
        //solo insert, drop, update
        public static int executeNonQuery(string query)
        {
            
            int rowsAffected;
            //1.Creación de la conexión
            OracleConnection connection = new OracleConnection(CONNECTION_STRING);

            //2.Creación de un objeto tipo comando || es necesario para poder ejecutar un sentencia insert, update or delete.
            //recibe la consulta, que puede ser cualquier dml y la conexión que trabaja con la cadena de conexión
            OracleCommand command = new OracleCommand(query, connection);


            //3.Abrir la conexión
            connection.Open();

            //4. Ejecución del comando, devuelve el # de filas afectadas
            //comando.ExecuteNonQuery(); || Método: algo que no es select.
            rowsAffected = command.ExecuteNonQuery();

            //5.Cerrar conexión
            connection.Close();


            return rowsAffected;
            
        }
        
        //select
        public static DataTable executeQuery(string query)
        {
             //Creacion de DataSet vacio
            DataTable ds = new DataTable();

            //Creación de adaptador || se usa pa ejecutar consultas de tipo Select

            OracleDataAdapter adapter = new OracleDataAdapter(query, CONNECTION_STRING);
            Console.WriteLine(query);
            //Llenar el dataset a traves del adaptador ||fill: llena con registros el dataSet
            adapter.Fill(ds);
            return ds;
        }
    }
}
