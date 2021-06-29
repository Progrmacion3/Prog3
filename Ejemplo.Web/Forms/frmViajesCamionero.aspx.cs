using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Forms
{
    public partial class frmViajesCamionero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            Common.Clases.Camionero camionero = new Common.Clases.Camionero();
            camionero.CI = int.Parse(this.txtCedula.Text);

            this.grdViajesCamionero.DataSource = Dominio.Fachada.ListarViajesPorCamionero(camionero);
            this.grdViajesCamionero.DataBind();
            this.txtCedula.Text = string.Empty;
        }
        
    }
}