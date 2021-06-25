using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Forms
{
    public partial class frmInicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string password = this.txtPassword.Text;
            Ejemplo.Web.SiteMaster site = new SiteMaster();
            try
            {
                //string resultado = Dominio.Fachada.AltaCamion();

                //if (resultado == "camionero")
                //{
                //    site.Seccion(true);
                //}
                //else
                //{
                //    site.Seccion(false);
                //}

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}