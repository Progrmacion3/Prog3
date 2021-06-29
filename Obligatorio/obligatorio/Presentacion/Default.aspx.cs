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
        bool boolean = true;
        protected void Page_Load(object sender, EventArgs e)
        {

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
            }
            else if(login.TipoLogin == "C")
            {
                this.Master.FindControl("btnParadas").Visible = true;
            }
        }
    }
}