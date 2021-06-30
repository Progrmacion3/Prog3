using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace obligatorio
{
    public partial class _Default : Page
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
            }
            else if (login.TipoLogin == "C")
            {
                this.Master.FindControl("btnParadas").Visible = true;
                this.Master.FindControl("btnViajes").Visible = true;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string user = this.InputUser.Text;
            string contra = this.InputContra.Text;
            
            
            Dominio.Login login = new Dominio.Login();
            login.loginCheck(user, contra);

            if(login.TipoLogin == "A")
            {
                this.Master.FindControl("btnEmp").Visible = true;
                this.Master.FindControl("btnCamiones").Visible = true;
                this.Master.FindControl("btnViajes").Visible = true;
                this.Master.FindControl("btnParadas").Visible = true;
                this.Master.FindControl("btnConsultas").Visible = true;
                this.lblMsg.Text = "Logeado con exito";
                this.InputUser.Text = "";
                this.InputContra.Text = "";
                return;
            }
            else if(login.TipoLogin == "C")
            {
                this.Master.FindControl("btnParadas").Visible = true;
                this.Master.FindControl("btnViajes").Visible = true;
                this.lblMsg.Text = "Logeado con exito";
                this.InputUser.Text = "";
                this.InputContra.Text = "";
                return;
            }
            this.lblMsg.Text = "Ha habido un error";
        }
    }
}