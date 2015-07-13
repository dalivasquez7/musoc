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

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}