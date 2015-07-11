using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace Musoc
{
  
    public class ControladorRutas
    {
        private RutasBaseDatos bd;

        public ControladorRutas()
        {

            bd = new RutasBaseDatos();
        }

        public DataTable getRutas(String origen, String destino)
        {
            DataTable dt = bd.getRuta(origen, destino);
            return dt;
        }

    
    }
}