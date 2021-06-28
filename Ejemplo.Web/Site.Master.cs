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
            MenuCamionero.Visible = false;
            MenuAdministrador.Visible = false;
            MenuIniciarSersion.Visible = true;

            bool escamionero;
            if (Session["escamionero"] != null)
            {
                escamionero = bool.Parse(Session["escamionero"].ToString());

                if (escamionero)
                {
                    MenuIniciarSersion.Visible = false;
                    MenuCamionero.Visible = true;
                    MenuAdministrador.Visible = false;
                     
                }
                else
                {
                    MenuIniciarSersion.Visible = false;
                    MenuCamionero.Visible = false;
                    MenuAdministrador.Visible = true;
                    
                }
            }

        }
    }
}
