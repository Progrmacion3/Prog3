using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class wfrmParadasDelViaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cargar todos los viajes
            }
        }

        protected void lstViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargas las paradas
        }
    }
}