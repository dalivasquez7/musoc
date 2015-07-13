using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Musoc
{
    public class FinCompraBaseDatos
    {

        private AdaptadorBD adaptador;
        DataTable dt;

        public FinCompraBaseDatos()
        {
            adaptador = new AdaptadorBD();
            dt = new DataTable();
        }

        public void finalizar(int asiento, String fecha, String estado, String codigo, String hora)
        {
            String consultaSQL = "insert into asientos values("+ asiento +", '" + fecha + "', '"+ estado +"', '"+ codigo +"', '"+ hora +"')";
            adaptador.insertarConsulta(consultaSQL);
        }
    }
}