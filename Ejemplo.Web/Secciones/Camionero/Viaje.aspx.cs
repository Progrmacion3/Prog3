using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Camionero
{
    public partial class Viaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }

        protected void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje unViaje = new Common.Clases.Viaje();
            unViaje.IdViaje = int.Parse(this.txtIdViaje.Text);
            unViaje.Kilaje = int.Parse(this.txtKilaje.Text);
            unViaje.Estado = this.ddlEstado.SelectedItem.Text;

            bool verdadero = Dominio.Fachada.ViajeModificarCamionero(unViaje);

            if (verdadero)
            {
                this.ActualizarLista();
                lblResultado.Text = "Se ha modificado el viaje de forma correcta";
            }
            else
            {
                lblResultado.Text = "No se ha podido moficiar el viaje";
            }

        }
        protected void Limpiar()
        {
            this.txtIdViaje.Text = string.Empty;
            this.txtKilaje.Text = string.Empty;
            this.ddlEstado.SelectedItem.Text = string.Empty;
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
            this.lblResultado.Text = string.Empty;

            TableCell celda = grdViajes.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.IdViaje = int.Parse(celda.Text);
            viaje = Dominio.Fachada.MostrarViajeEspecifico(viaje);

            if (viaje != null)
            {
                this.txtIdViaje.Text = Convert.ToString(viaje.IdViaje);
                this.txtKilaje.Text = Convert.ToString(viaje.Kilaje);
                this.ddlEstado.SelectedItem.Text = viaje.Estado;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert ('ERROR: No se pudo cargar la fila.')", true);
            }
        }
    }
}