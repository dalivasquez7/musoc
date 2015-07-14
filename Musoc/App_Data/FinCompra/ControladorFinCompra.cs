using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musoc
{
    public class ControladorFinCompra
    {
        FinCompraBaseDatos baseDatos;

        public ControladorFinCompra()
        {
            baseDatos = new FinCompraBaseDatos();
        }

        public void finalizar(int asiento, String fecha, String estado, String codigo, String hora)
        {
            baseDatos.finalizar(asiento, fecha, estado, codigo, hora);
        }
    }
}