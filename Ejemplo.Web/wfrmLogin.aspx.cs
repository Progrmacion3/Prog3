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
                        Camionero camioneroUno = new Camionero(usuario.Id);

                        if (Fachada.Obtener(camioneroUno))
                        {
                            Session["camionero"] = camioneroUno;
                            Response.Redirect("wfrmModificacionesCamionero.aspx");
                        }
                        else
                        {
                            LoginUser.FailureText = "Error de ingreso";
                        }
                    }
                    else
                    {
                        LoginUser.FailureText = "No existe tipo";
                    }
                }
                else
                {
                    LoginUser.FailureText = "Usuario o contraseña no existen";
                }
            }
            else
            {
                LoginUser.FailureText = "Error de base de datos";
            }
        }
    }
}