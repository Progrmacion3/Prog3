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

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int pId = int.Parse(this.txtIdViaje.Text);
            string pUsuario = Session["userName"].ToString();
            this.txtResultado.Text = Dominio.Fachada.MostrarRotura(pId, pUsuario);
            this.txtResultado.DataBind();
        }
    }
}