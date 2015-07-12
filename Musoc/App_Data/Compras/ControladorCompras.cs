using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Musoc
{
    public class ControladorCompras
    {
        private ComprasBaseDatos baseDatos;

        public ControladorCompras()
        {
            baseDatos = new ComprasBaseDatos();
        }

        public DataTable horasFindeSemana()
        {
            DataTable dt = baseDatos.horasFindeSemana();
            return dt;
        }

        public DataTable horasSemana(String origen, String destino)
        {
            DataTable dt = baseDatos.horasSemana(origen, destino);
            return dt;
        }

        public DataTable horasTodas()
        {
            DataTable dt = baseDatos.horasTodas();
            return dt;
        }

    }
}