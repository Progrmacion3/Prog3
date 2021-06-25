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
        }
        public void Seccion(bool pTipo)
        {
            bool escamionero = true;
            Session["escamionero"] = pTipo;
            if (Session["escamionero"] != null)
            {
                escamionero = bool.Parse(Session["escamionero"].ToString());
            }

            if (escamionero)
            {
                MenuCamionero.Visible = true;
                MenuAdministrador.Visible = false;
                MenuIniciarSersion.Visible = false;
            }
            else
            {
                MenuCamionero.Visible = false;
                MenuAdministrador.Visible = true;
                MenuIniciarSersion.Visible = false;
            }
        }
    }
}
