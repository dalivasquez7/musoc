using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Diagnostics;
namespace Musoc
{
    public partial class FormRutas : System.Web.UI.Page
    {
        private static ControladorRutas controlador = new ControladorRutas();

        protected void Page_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        void llenarGrid()
        {
            DataTable tabla = crearTabla();
       
            try
            {
                Object[] datos = new Object[5];

                DataTable rutas = controlador.getRutas(cbxOrigen.Value, cbxDestino.Value);
                
                if (rutas.Rows.Count > 0)
                {
                    foreach (DataRow fila in rutas.Rows)
                    {

                        datos[0] = fila[2].ToString();
                        datos[1] = fila[3].ToString();
                        datos[2] = fila[1].ToString();
                        datos[3] = fila[4].ToString();
                        datos[4] = fila[5].ToString();
                        tabla.Rows.Add(datos);
                    }
                }
                GridRutas.DataBind();
            }
            catch (Exception e)
            {
                Debug.WriteLine("No se pudo cargar las reservaciones");
            }
        }

        protected DataTable crearTabla()//consultar
        {
            DataTable tabla = new DataTable();
            DataColumn columna;

            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Origen";
            tabla.Columns.Add(columna);

            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Destino";
            tabla.Columns.Add(columna);

            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Hora";
            tabla.Columns.Add(columna);

            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Ruta";
            tabla.Columns.Add(columna);

            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Días Disponibles";
            tabla.Columns.Add(columna);

            GridRutas.DataSource = tabla;
            GridRutas.DataBind();

            return tabla;
        }

        protected void BotonBuscar_click(object sender, EventArgs e)
        {
            llenarGrid();
        }
    }
}