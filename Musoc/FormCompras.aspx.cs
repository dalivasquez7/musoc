using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Musoc
{
    public partial class FormCompras : System.Web.UI.Page
    {
        private String fecha;
        private ControladorCompras controlador = new ControladorCompras();

        protected void Page_Load(object sender, EventArgs e)
        {
            listHora.Items.Clear();
        }

        protected String dias()
        {
            String dia;
           // String fecha = DateTime.Parse(diaSeleccionado.Value).ToString("dd/MM/yyyy");
            DateTime diaSelec = DateTime.Parse(diaSeleccionado.Value);
            return dia = diaSelec.ToString("dddd");
            
        }

        protected void clickMostrarAsientos(object sender, EventArgs e)
        {
            

        }

        protected void clickAgregarHora(object sender, EventArgs e)
        {
           
            llenarHora();


        }

        protected void llenarHora()
        {
            String dia = dias();
            if (cbxOrigen.Value.Equals("San Jose") && cbxDestino.Value.Equals("San Isidro") && (dia.Equals("sábado") || dia.Equals("Saturday")) || (dia.Equals("domingo") || dia.Equals("Sunday")))
            {
                DataTable horas = controlador.horasFindeSemana(); //no incluye los horarios que son Lunes-Viernes
                if (horas.Rows.Count > 0)
                {
                    for (int i = 0; i < horas.Rows.Count; i++)
                    {
                        listHora.Items.Add(horas.Rows[i][0].ToString());
                    }
                }
            }
            else if ((cbxOrigen.Value.Equals("San Jose") && cbxDestino.Value.Equals("San Isidro")) || (cbxOrigen.Value.Equals("San Isidro") && cbxDestino.Value.Equals("San Jose")))
            {
                
                DataTable horas = controlador.horasSemana(cbxOrigen.Value, cbxDestino.Value);  //todas las horas entre semana, no incluye domingos
                if (horas.Rows.Count > 0)
                {
                    for (int i = 0; i < horas.Rows.Count; i++)
                    {
                        listHora.Items.Add(horas.Rows[i][0].ToString());
                    }
                }
            }
            else if (cbxOrigen.Value.Equals("San Isidro") && cbxDestino.Value.Equals("San Jose") && dia.Equals("domingo") || dia.Equals("Sunday")) //todos + domingos.
            {
                DataTable horas = controlador.horasTodas();  //todas las horas entre semana, no incluye domingos
                if (horas.Rows.Count > 0)
                {
                    for (int i = 0; i < horas.Rows.Count; i++)
                    {
                        listHora.Items.Add(horas.Rows[i][0].ToString());
                    }
                }
            }
        }


        protected void btnShowNew_click(object sender, EventArgs e)
        {
            Response.Redirect("FormFinCompra");
        }
        
        
    }
}