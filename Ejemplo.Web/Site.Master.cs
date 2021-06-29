using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            bool camionero = true;
            if (Session["esCamionero"] != null)
                bool.TryParse(Session["esCamionero"].ToString(), out camionero);
            if (camionero)
            {
                MenuCamionero.Visible = true;
                MenuAdmin.Visible = false;
            }
            else
            {
                MenuCamionero.Visible = false;
                MenuAdmin.Visible = true;
            }
        }
    }
}
