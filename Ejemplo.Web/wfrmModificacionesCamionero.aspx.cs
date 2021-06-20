using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class wfrmModificacionesCamionero : System.Web.UI.Page
    {
        private Camionero camionero;

        protected void Page_Load(object sender, EventArgs e)
        {
            var usuario = Session["usuario"];
            if (usuario is Camionero)
            {
                camionero = (Camionero)usuario;
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnModificarViaje_Click(object sender, EventArgs e)
        {

        }

        protected void txtCamionero_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtKilaje_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtCamionero1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}