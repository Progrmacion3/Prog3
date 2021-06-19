using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using Dominio;

namespace Ejemplo.Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario(LoginUser.UserName, LoginUser.Password);
            bool correcto;
            char tipo;

            if (Fachada.Ingresar(usuario, out correcto, out tipo))
            {
                if (correcto)
                {
                    if (tipo == 'a')
                    {
                        Response.Redirect("wfrmIngresoUsuarios.aspx");
                    }
                    else if (tipo == 'c')
                    {
                        // Obtener camionero
                        // O por lo menos mandarle el Id del camionero 
                        // al siguiente formulario
                        Response.Redirect("wfrmModificacionesCamionero.aspx");
                    }
                    else
                    {
                        // Error: Tipo no existe...
                    }
                }
                else
                {
                    // Error: Usuario/Contraseña no existen...
                }
            }
            else
            {
                // Error: de base de datos...
            }
        }
    }
}