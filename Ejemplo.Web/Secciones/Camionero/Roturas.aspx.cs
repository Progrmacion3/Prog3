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
            if (this.txtIdViaje.Text != string.Empty)
            {
            int pId = int.Parse(this.txtIdViaje.Text);
            string pUsuario = Session["userName"].ToString();
            this.grdParadas.DataSource = Dominio.Fachada.MostrarEstadoRoturas(pId, pUsuario);
            this.grdParadas.DataBind();
            }
            else
            {
                this.txtIdViaje.Focus();           
            }
        }

        protected void grdParadas_RowCreated(object sender, GridViewRowEventArgs e)
        {
            //e.Row.Cells[0].Visible = false;
            //e.Row.Cells[2].Visible = false;
            //e.Row.Cells[4].Visible = false;
        }
    }
}