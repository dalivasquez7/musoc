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
        public String asientos;
        public String codigo;
        public DateTime fecha;
        public String horaViaje;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindSeats();
            }   
    
        }

        public void BindSeats()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Init", "init();", true);
        }
 

        protected String dias()
        {
            String dia;
            DateTime diaSelec = DateTime.Parse(diaSeleccionado.Value);
            return dia = diaSelec.ToString("dddd");
            
        }

        protected void clickMostrarAsientos(object sender, EventArgs e)
        {
            

        }

        protected void clickAgregarHora(object sender, EventArgs e)
        {
            listHora.Items.Clear();
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

        protected void asignarValores()
        {
            if (cbxOrigen.Value.Equals("San Isidro") && cbxDestino.Value.Equals("San Jose"))
            {
                codigo = "PZ";
            }
            else if (cbxOrigen.Value.Equals("San Jose") && cbxDestino.Value.Equals("San Isidro"))
            {
                codigo = "SJO";
            }

            fecha = DateTime.Parse(diaSeleccionado.Value);
            horaViaje = listHora.Text;

        }

        protected void BotonComprar_click(object sender, EventArgs e)
        {
            asignarValores();
            asientos = txtNumAsiento.Text;
            FormFinCompra.asientos = asientos;
            FormFinCompra.codigo = codigo;
            FormFinCompra.fecha = fecha;
            FormFinCompra.hora = horaViaje;
            Response.Redirect("~/FormFinCompra.aspx");
        }
        


    }
}