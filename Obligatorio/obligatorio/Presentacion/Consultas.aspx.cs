using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using obligatorio.Dominio;

namespace obligatorio.Presentacion
{
    public partial class Consultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dominio.Login login = new Dominio.Login();
            if (login.TipoLogin == "A")
            {
                this.Master.FindControl("btnEmp").Visible = true;
                this.Master.FindControl("btnCamiones").Visible = true;
                this.Master.FindControl("btnViajes").Visible = true;
                this.Master.FindControl("btnParadas").Visible = true;
                this.Master.FindControl("btnConsultas").Visible = true;
            }
            else if (login.TipoLogin == "C")
            {
                this.Master.FindControl("btnViajes").Visible = true;
                this.Master.FindControl("btnParadas").Visible = true;
            }
        }

        protected void btnC1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnC2_Click(object sender, EventArgs e)
        {
            string ci = this.InputCiCamionero.Text;
            Empresa unaEmpresa = new Empresa();
            this.lstViajesCamionero.DataSource = null;
            this.lstViajesCamionero.DataSource = unaEmpresa.ListaViajes();
            this.lstViajesCamionero.DataBind();

        }

        protected void btnC3_Click(object sender, EventArgs e)
        {

        }
    }
}