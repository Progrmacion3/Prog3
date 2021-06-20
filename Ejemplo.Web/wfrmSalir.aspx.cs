using System;

namespace Ejemplo.Web
{
    public partial class wfrmSalir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}