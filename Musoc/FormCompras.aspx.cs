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

        private ControladorCompras controlador = new ControladorCompras();
        string[] arr = new string[] { "1", "2", "3" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindSeats();
            }   
    
            listHora.Items.Clear();
        }

        public void BindSeats()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Init", "init();", true);
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
            if (cbxOrigen.Value.Equals("San Jose") && cbxDestino.Value.Equals("San Isidro") && ((dia.Equals("sábado") || dia.Equals("Saturday")) || (dia.Equals("domingo") || dia.Equals("Sunday"))))
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
        }

        protected void BotonComprar_click(object sender, EventArgs e)
        {
            String asientos = txtNumAsiento.Text;
            string sel = "1,4,5";
            ClientScript.RegisterStartupScript(this.GetType(), "Init", "init(" + arr + ");", true);
        }
        


    }
}