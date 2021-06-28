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
            Common.Clases.Empleado emp = new Common.Clases.Empleado();
            emp.Usuario = this.txtUsuario.Text;
            emp.Password = this.txtPassword.Text;

            try
            {
                string resultado = Dominio.Fachada.TraerTipoEmpleado(emp);

                if (resultado == "Camionero")
                {
                    Session["escamionero"] = true;
                }
                else
                {
                    Session["escamionero"] = false;
                }

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