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
        //the connection string contains the information necessary to connect to a database with a specific user
        public static string CONNECTION_STRING = @"Data Source=DESKTOP-HQNIK6L\SQLEXPRESS;Initial Catalog=DIPLOMADO;User ID=sa;Password='sa2016'";
       
        //only insert, drop, update
        public static int executeNonQuery(string query)
        {
            
            int rowsAffected;

            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            //create a command
            SqlCommand command = new SqlCommand(query, connection);
            //open the connection
            connection.Open();
            //execute query, this metod return the number rows affected
            rowsAffected = command.ExecuteNonQuery();
            //Paso 5: close connection
            connection.Close();
            ;
            return rowsAffected;
            
        }
        
        //select
        public static DataTable executeQuery(string query)
        {
            //a DataTable is a tables
            DataTable Dt = new DataTable();
            //create a adapter
            SqlDataAdapter adapter = new SqlDataAdapter(query, CONNECTION_STRING);
            adapter.Fill(Dt);
            return Dt;
        }
    }
}
