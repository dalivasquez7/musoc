using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Musoc
{
    public partial class FormRutas : System.Web.UI.Page
    {
        private static ControladorRutas controlador = new ControladorRutas();

        protected void Page_Load(object sender, EventArgs e)
        {
            datos();
        }

        private void datos()
        {
            DataTable dest = controlador.getDestino();
            txtDestino.Value = dest.Rows[0][0].ToString();
        }
    }
}