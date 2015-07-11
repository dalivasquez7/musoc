using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Musoc
{
    public class AdaptadorBD
    {
        private static String password = "Musoc_77";
        private static String user = "dalila7@fajrst5yjb";
        String conexion = "Data Source=tcp:fajrst5yjb.database.windows.net,1433; Initial Catalog=Musoc; user id=" + user + "; password=" + password;
       
        public AdaptadorBD(){
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un SqlDataReader
         */
        public SqlDataReader ejecutarConsulta(String consulta)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlDataReader datos = null;
            SqlCommand comando = null;

            try
            {
                comando = new SqlCommand(consulta, sqlConnection);
                datos = comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
               
            }
            return datos;
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un SqlDataReader
         */
        public SqlDataReader insertarConsulta(String consulta)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlDataReader datos = null;
            SqlCommand comando = null;

            try
            {
                comando = new SqlCommand(consulta, sqlConnection);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
              
            }
            return datos;
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un DataTable
         */
        public DataTable ejecutarConsultaTabla(String consulta)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand comando = new SqlCommand(consulta, sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();

            dataAdapter.Fill(table);
			
			return table;
        }     
    }
}
    
    
    