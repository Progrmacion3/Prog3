using Common;
using Dominio;
using System;

namespace Ejemplo.Web
{
    public partial class wfrmModificacionesCamionero : System.Web.UI.Page
    {
        private Camionero camionero;
        private Viaje viaje;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var usuario = Session["usuario"];
                if (usuario is Camionero)
                {
                    camionero = (Camionero)usuario;
                    txtCamionero.Text = camionero.ToString();
                    if (Fachada.ViajeActual(camionero, out viaje))
                    {
                        txtViaje.Text = viaje.ToString();
                    }
                    else
                    {
                        // lblMensajes.Text = "Error de base de datos.";
                        txtViaje.Text = "Ninguno";
                    }
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        protected void btnModificarViaje_Click(object sender, EventArgs e)
        {
            int kilaje;
            if (txtKilaje.Text == "")
            {
                kilaje = 0;
            }
            else if (!int.TryParse(txtKilaje.Text, out kilaje))
            {
                lblMensajes.Text = "No se pudo ingresar porque el kilaje no es un número.";
                return;
            }

            var tipo = ddlEstado.SelectedValue;
            var comentario = txtComentario.Text;
            var estado = new Estado(tipo, kilaje, comentario);
            if (Fachada.Alta(estado, viaje))
            {
                lblMensajes.Text = "Ingreso correcto";
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }

        protected void txtCamionero_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtKilaje_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtCamionero1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}