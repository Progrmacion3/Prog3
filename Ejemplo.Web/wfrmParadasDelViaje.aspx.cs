using Common;
using Dominio;
using System;
using System.Collections.Generic;

namespace Ejemplo.Web
{
    public partial class wfrmParadasDelViaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            var usuario = Session["usuario"];
            if (usuario is Administrador)
            {
                var viajes = new List<Viaje>();
                if (Fachada.Listar(viajes))
                {
                    lstViajes.DataSource = null;
                    lstViajes.DataSource = viajes;
                    lstViajes.DataValueField = "Id";
                    lstViajes.DataTextField = "VerToString";
                    lstViajes.DataBind();
                    lstParadas.DataValueField = "Id";
                    lstParadas.DataTextField = "VerToString";
                }
                else
                {
                    lblMensajes.Text = "Error de base de datos.";
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void lstViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViajes.SelectedItem == null)
                return;

            var id = int.Parse(lstViajes.SelectedValue);
            var viaje = new Viaje(id);
            var paradas = new List<Estado>();
            if (Fachada.ListarParadas(viaje, paradas))
            {
                lstParadas.DataSource = null;
                lstParadas.DataSource = paradas;
                lstParadas.DataBind();
                lblMensajes.Text = "";
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }

        protected void lstParadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViajes.SelectedItem == null || lstParadas.SelectedItem == null)
                return;

            var idViaje = int.Parse(lstViajes.SelectedValue);
            var idEstado = int.Parse(lstParadas.SelectedValue);
            var viaje = new Viaje(idViaje);
            var estado = new Estado(idEstado);
            if (Fachada.Obtener(estado, viaje))
            {
                txtComentario.Text = estado.Comentario;
                lblMensajes.Text = "";
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }

        protected void btnComentar_Click(object sender, EventArgs e)
        {
            if (lstViajes.SelectedItem == null || lstParadas.SelectedItem == null)
                return;

            var idViaje = int.Parse(lstViajes.SelectedValue);
            var idEstado = int.Parse(lstParadas.SelectedValue);
            var viaje = new Viaje(idViaje);
            var estado = new Estado(idEstado);
            if (Fachada.Obtener(estado, viaje))
            {
                estado.Comentario = txtComentario.Text;
                if (Fachada.Alta(estado, viaje))
                {
                    var paradas = new List<Estado>();
                    if (Fachada.ListarParadas(viaje, paradas))
                    {
                        lstParadas.DataSource = null;
                        lstParadas.DataSource = paradas;
                        lstParadas.DataBind();
                        txtComentario.Text = "";
                        lblMensajes.Text = "Comentario guardado.";
                        return;
                    }
                }
            }
            lblMensajes.Text = "Error de base de datos.";
        }
    }
}