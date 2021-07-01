using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Admin
{
    public partial class Paradas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }
        protected void ActualizarLista()
        {
            this.grdParadas.DataSource = Dominio.Fachada.MostrarParadas();
            this.grdParadas.DataBind();
        }

        protected void grdParadas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            TableCell celda = grdParadas.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Parada parada = new Common.Clases.Parada();
            parada.IdParada= int.Parse(celda.Text);
            parada = Dominio.Fachada.MostrarParadaEspecifica(parada);

            if (parada != null)
            {
                this.txtIdViaje.Text = Convert.ToString(parada.IdViaje);
                this.txtIdParada.Text = Convert.ToString(parada.IdParada);
                this.txtComentario.Text = Convert.ToString(parada.Comentario);
                this.ddlEstado.SelectedItem.Value = Convert.ToString(parada.Estado);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert ('ERROR: No se pudo cargar la fila.')", true);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Common.Clases.Parada unParada = new Common.Clases.Parada();
            unParada.IdViaje = int.Parse(this.txtIdViaje.Text);
            unParada.IdParada = int.Parse(this.txtIdParada.Text);
            unParada.Comentario = this.txtComentario.Text;
            unParada.Estado = this.ddlEstado.SelectedItem.Text;

            bool verdadero = Dominio.Fachada.ParadaModificar(unParada);

            if (verdadero)
            {
                this.ActualizarLista();
                this.Limpiar();
                lblMensaje.Text = "Se ha modificado el viaje de forma correcta";
            }
            else
            {
                lblMensaje.Text = "No se ha podido moficiar el viaje";
            }
        }
        protected void Limpiar()
        {
            this.txtIdViaje.Text = string.Empty;
            this.txtComentario.Text = string.Empty;
        }
    }
}