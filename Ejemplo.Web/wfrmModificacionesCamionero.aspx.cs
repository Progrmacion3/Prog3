using Common;
using Dominio;
using System;

namespace Ejemplo.Web
{
    public partial class wfrmModificacionesCamionero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var usuario = Session["usuario"];
                if (usuario is Camionero)
                {
                    var camionero = (Camionero)usuario;
                    txtCamionero.Text = camionero.ToString();
                    Viaje viaje;
                    if (Fachada.ViajeActual(camionero, out viaje))
                    {
                        txtViaje.Text = viaje.ToString();
                        lblIdViaje.Text = viaje.Id.ToString();
                    }
                    else
                    {
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

            int idViaje;
            if (!int.TryParse(lblIdViaje.Text, out idViaje))
            {
                lblMensajes.Text = "No se pudo ingresar porque no hay ningún viaje.";
                return;
            }

            var tipo = ddlEstado.SelectedValue;
            var comentario = txtComentario.Text;
            var estado = new Estado(tipo, kilaje, comentario);
            var viaje = new Viaje(idViaje);
            if (Fachada.Alta(estado, viaje))
            {
                lblMensajes.Text = "Ingreso correcto";
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }
    }
}