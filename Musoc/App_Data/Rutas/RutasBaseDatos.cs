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
            String consultaSQL = "insert into ruta values ('SJO', '11:00', 'San Jose', 'PZ', 'directo', 3540, 'lunes')";
            adaptador.insertarConsulta(consultaSQL);

        }
        internal DataTable getDestino()
        {
            insertar();
            String consultaSQL = "select destino from ruta";
            dt = adaptador.ejecutarConsultaTabla(consultaSQL);
            return dt;
        }
        
    
    }


}