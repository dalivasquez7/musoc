using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Musoc
{
    public partial class FormCompras : System.Web.UI.Page
    {
        private String fecha;
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarHora();
        }

        protected void dias()
        {
            DateTime diaSelec = DateTime.Parse(diaSeleccionado.Value);
           // fecha = diaSelec.ToString("MM/dd/yyyy");
            String dia = diaSelec.ToString("dddd");
        }

        protected void btnShowNew_click(object sender, EventArgs e)
        {
            Response.Redirect("FormFinCompra");
        }

        protected void clickMostrarAsientos(object sender, EventArgs e)
        {
            dias();

        }

        protected void llenarHora()
        {
            listHora.Items.Add("5:00am");
            listHora.Items.Add("6:00am");
        }
        
    }
}