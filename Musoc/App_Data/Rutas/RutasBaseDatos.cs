using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace Musoc
{

    public class RutasBaseDatos
    {
        private AdaptadorBD adaptador;
        DataTable dt;

        public RutasBaseDatos()
        {
            adaptador = new AdaptadorBD();
            dt = new DataTable();

        }

        public void insertar()
        {
            String consultaSQL = "insert into ruta values()";
            adaptador.insertarConsulta(consultaSQL);

        }
        internal DataTable getRuta(String origen, String destino)
        {
            
            String consultaSQL = "select * from ruta where origen = '"+origen+"' and destino = '"+destino+"' order by num ";
            dt = adaptador.ejecutarConsultaTabla(consultaSQL);
            return dt;
        }
        
    
    }


}