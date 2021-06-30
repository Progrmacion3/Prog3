using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Camionero
{
    public partial class Roturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtIdViaje.Text != string.Empty)
            {
            int pId = int.Parse(this.txtIdViaje.Text);
            string pUsuario = Session["userName"].ToString();
            this.grdParadas.DataSource = Dominio.Fachada.MostrarEstadoRoturas(pId, pUsuario);
            this.grdParadas.DataBind();
            }
            else
            {
                this.txtIdViaje.Focus();           
            }
        }

        protected void ActualizarLista()
        {
            if (Session["userName"] != null)
            {
                string usuario = Session["userName"].ToString();
                this.grdViajes.DataSource = Dominio.Fachada.MostrarViajesDelCamionero(usuario);
                this.grdViajes.DataBind();
            }
        }
        protected void grdViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            TableCell celda = grdViajes.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.IdViaje = int.Parse(celda.Text);
            viaje = Dominio.Fachada.MostrarViajeEspecifico(viaje);

            if (viaje != null)
            {
                this.txtIdViaje.Text = Convert.ToString(viaje.IdViaje);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert ('ERROR: No se pudo cargar la fila.')", true);
            }
        }
        protected void grdParadas_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }

        protected void grdParadas_Unload(object sender, EventArgs e)
        {

        }
    }
}