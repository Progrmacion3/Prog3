using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Camionero
{
    public partial class Paradas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }

        protected void btnAgregarParada_Click(object sender, EventArgs e)
        {
            Common.Clases.Parada unaParada = new Common.Clases.Parada();
            unaParada.IdViaje = int.Parse(this.txtIdViaje.Text);
            unaParada.Tipo = this.ddlTipoParada.SelectedValue;
            unaParada.Comentario = this.txtComentario.Text;

            bool verdadero = Dominio.Fachada.ParadaAgregar(unaParada);

            if (verdadero)
            {
                this.ActualizarLista();
                lblResultado.Text = "Se ha agregado una parada.";
            }
            else
            {
                lblResultado.Text = "No se ha podido agregar una parada.";
            }
        }
        protected void ActualizarLista()
        {
            if (Session["userName"] != null)
            {
                string usuario = Session["userName"].ToString();
                this.grdViaje.DataSource = Dominio.Fachada.MostrarViajesDelCamionero(usuario);
                this.grdViaje.DataBind();
            }
        }

        protected void grdParadas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celda = grdViaje.Rows[e.NewSelectedIndex].Cells[1];
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

        protected void ddlTipoParada_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (ddlTipoParada.SelectedItem.Value == "Rotura")
            {
                this.txtComentario.Enabled = false;
            }
            else
            {
                this.txtComentario.Enabled = true;
            }
        }
    }
}