using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Musoc
{
    public partial class FormFinCompra : System.Web.UI.Page
    {
        public static String codigo;
        public static String hora;
        public static String asientos;
        public static DateTime fecha;
        public ControladorFinCompra controlador = new ControladorFinCompra();
        int[] asiento = asientos.Split(',').Select(int.Parse).ToArray();



        protected void Page_Load(object sender, EventArgs e)
        {
            calcularMonto();
        }

        protected void calcularMonto()
        {
            int valor = (3350 * (asiento.Length));
            montoTotal.Value = valor.ToString();
            montoTotal.Disabled = true;
            txtAsientos.Value = asientos;
          
        }

      protected void BotonFinCompra_click(object sender, EventArgs e)
        {
           
            String fech = fecha.ToString("dd/MM/yyyy");

            for (int i = 0; i < asiento.Length; i++)
            {

                controlador.finalizar(asiento[i], fech, "ocupado", codigo, hora);
            }

            Response.Redirect("~/FormFin.aspx");
        }

    }
}