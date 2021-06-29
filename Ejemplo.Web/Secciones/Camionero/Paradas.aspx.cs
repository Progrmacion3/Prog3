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

        }

        protected void ddlEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoParada.SelectedIndex == 0)
            {
                this.Label3.Visible = false;
                this.txtComentario.Visible = false;
            }

            else if (ddlTipoParada.SelectedIndex == 1)
            {
                this.Label3.Visible = true;
                this.txtComentario.Visible = true;
            }
        }

        protected void btnAgregarParada_Click(object sender, EventArgs e)
        {
            Common.Clases.Parada unaParada = new Common.Clases.Parada();
            unaParada.Estado = this.ddlTipoParada.SelectedValue;
            unaParada.IdViaje = int.Parse(this.txtIdViaje.Text);
            unaParada.Comentario = this.txtComentario.Text;

            bool verdadero = Dominio.Fachada.ParadaAgregar(unaParada);

            if (verdadero)
            {
                lblResultado.Text = "Se ha modificado el viaje de forma correcta";
            }
            else
            {
                lblResultado.Text = "No se ha podido moficiar el viaje";
            }
        }
    }
}