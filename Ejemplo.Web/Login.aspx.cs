using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Ejemplo.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnAceptarLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Common.Clases.Empleado empleado = new Common.Clases.Empleado();
                empleado.Usuario = this.txtUsuarioLogin.Text;
                empleado.Contraseña = this.txtContraseñaLogin.Text;
                empleado = Dominio.Fachada.Revisar_Usuario_Contraseña(empleado);
               

                if(empleado != null)
                {
                    Response.Redirect("~/SeccionLogin.aspx"); 
                }
                else
                {
                    lblErrorLogin.Text = "Usuario y/o Contraseña incorrectas,por favor ingrese de nuevo los datos";
                }
            }
    
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}