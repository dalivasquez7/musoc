using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Musoc
{
   
    public class ComprasBaseDatos
    {
        private AdaptadorBD adaptador;
        DataTable dt;

        public ComprasBaseDatos(){

            adaptador = new AdaptadorBD();
            dt = new DataTable();
        }

        internal DataTable horasFindeSemana() //no lunes-viernes
        {
            String consultaSQL = "select hora from ruta where origen = 'San Jose' and destino = 'San Isidro' and diasDisponibles <> 'Lunes-Viernes' order by num ";
            dt = adaptador.ejecutarConsultaTabla(consultaSQL);
            return dt;
        }

        internal DataTable horasSemana(String origen, String destino)// todos
        { 
            String consultaSQL = "select hora from ruta where origen = '"+ origen +"' and destino = '"+ destino +"'  and diasDisponbiles <> 'Domingo' order by num";
            dt = adaptador.ejecutarConsultaTabla(consultaSQL);
            return dt;
        }

        internal DataTable horasTodas() //incluye domingos
        {
            String consultaSQL = "select hora from ruta where origen = 'San Isidro' and destino = 'San Jose'  and diasDisponbiles <> 'Lunes-Viernes' order by num";
            dt = adaptador.ejecutarConsultaTabla(consultaSQL);
            return dt;
        }
        
    }
}