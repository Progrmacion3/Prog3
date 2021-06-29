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

        protected void grdParadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}