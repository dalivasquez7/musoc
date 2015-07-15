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
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "Init", "init();", true);
            //ScriptManager.RegisterStartupScript(this, GetType(), "init", "init();", true);  
            //ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "init", "<script>init();</script>", true);
        }


        protected String dias()
        {
            String dia;
            DateTime diaSelec = DateTime.Parse(diaSeleccionado.Value);
            return dia = diaSelec.ToString("dddd");
            
        }

        protected void clickMostrarAsientos(object sender, EventArgs e)
        {
            asignarValores();
            String fechx = fecha.ToString("dd/MM/yyyy");
          
            DataTable asientosOcupados = controlador.obtenerOcupados(fechx, codigo, horaViaje);
            int[] ocupados;
           
            int i = 0;

            if (asientosOcupados.Rows.Count > 0)
            {
                ocupados = new int[asientosOcupados.Rows.Count-1]; //pone los numeros de asientos en un array de int

                foreach (DataRow fila in asientosOcupados.Rows)
                {
                    ocupados[i] = int.Parse(fila[0].ToString());
            
                }

                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Init", "init('" + ocupados + "');", true);
                ClientScript.RegisterStartupScript(this.GetType(), "Init", "init('" + ocupados + "');", true);
        }
        }

        protected void clickAgregarHora(object sender, EventArgs e)
        {
            try
            {
                listHora.Items.Clear();
            llenarHora();
            }
            catch (Exception ee)
            {
                mostrarMensaje("danger", "Error:", "Seleccione una fecha");
            }


        }

        protected void llenarHora()
        {
            String dia = dias();
            DateTime horaActual = DateTime.Parse(DateTime.Now.ToString("h:mm:sstt"));
            DateTime horasDisponibles;
            if (cbxOrigen.Value.Equals("San Jose") && cbxDestino.Value.Equals("San Isidro") && ((dia.Equals("sábado") || dia.Equals("Saturday")) || (dia.Equals("domingo") || dia.Equals("Sunday"))))
            {
                DataTable horas = controlador.horasFindeSemana(); //no incluye los horarios que son Lunes-Viernes
                if (horas.Rows.Count > 0)
                {
                    for (int i = 0; i < horas.Rows.Count; i++)
                    {
                        horasDisponibles = DateTime.Parse(horas.Rows[i][0].ToString());
                        if (DateTime.Parse(diaSeleccionado.Value) > DateTime.Today)
                        {
                            listHora.Items.Add(horas.Rows[i][0].ToString());
                        }
                        else if (horasDisponibles > horaActual)
                        {
                        listHora.Items.Add(horas.Rows[i][0].ToString());
                    }
                        else if (DateTime.Parse(diaSeleccionado.Value) < DateTime.Today)
                        {
                            mostrarMensaje("danger", "Error:", "La fecha ya pasó");
                        }
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
                        horasDisponibles = DateTime.Parse(horas.Rows[i][0].ToString());
                        if (DateTime.Parse(diaSeleccionado.Value) > DateTime.Today)
                        {
                            listHora.Items.Add(horas.Rows[i][0].ToString());
                        }
                        else if (horasDisponibles > horaActual)
                        {
                        listHora.Items.Add(horas.Rows[i][0].ToString());
                    }
                        else if (DateTime.Parse(diaSeleccionado.Value) < DateTime.Today)
                        {
                            mostrarMensaje("danger", "Error:", "La fecha ya pasó");
                        }

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
                        horasDisponibles = DateTime.Parse(horas.Rows[i][0].ToString());
                        if (DateTime.Parse(diaSeleccionado.Value) > DateTime.Today)
                        {
                            listHora.Items.Add(horas.Rows[i][0].ToString());
                        }
                        else if (horasDisponibles > horaActual)
                        {
                        listHora.Items.Add(horas.Rows[i][0].ToString());
                    }
                        else if (DateTime.Parse(diaSeleccionado.Value) < DateTime.Today)
                        {
                            mostrarMensaje("danger", "Error:", "La fecha ya pasó");
                        }
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

        protected void mostrarMensaje(String tipoAlerta, String alerta, String mensaje)
        {
            alertAlerta.Attributes["class"] = "alert alert-" + tipoAlerta + " alert-dismissable fade in";
            labelTipoAlerta.Text = alerta + " ";
            labelAlerta.Text = mensaje;
            alertAlerta.Attributes.Remove("hidden");
            this.SetFocus(alertAlerta);
        }

        protected void BotonComprar_click(object sender, EventArgs e)
        {
            asignarValores();
            if (txtNumAsiento.Text == "")
            {
               // mostrarMensaje("danger", "Error:", "Seleccione almenos un asiento");
            }
            else
            {
                asientos = txtNumAsiento.Text;
                FormFinCompra.asientos = asientos;
                FormFinCompra.codigo = codigo;
                FormFinCompra.fecha = fecha;
                FormFinCompra.hora = horaViaje;
                Response.Redirect("~/FormFinCompra.aspx");
            }
        }
        


    }
}