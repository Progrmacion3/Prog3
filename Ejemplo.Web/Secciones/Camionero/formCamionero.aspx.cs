using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Camionero
{
    public partial class formCamionero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userName"] != null)
            {
                string UserName = Session["userName"].ToString();
                lblUserName.Text = UserName + ", ¿Seguro que quiere salir?";
            }
            else
            {
                Response.Redirect("~/Secciones/Login/IniciarSesion.aspx");
            }
        }
        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Remove("userName");
            Session.Remove("esCamionero");
            Response.Redirect("~/Secciones/Login/IniciarSesion.aspx");
        }
    }
}