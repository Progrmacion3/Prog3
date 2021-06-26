using Common;
using Dominio;
using System;
using System.Collections.Generic;

namespace Ejemplo.Web
{
    public partial class wfrmViajesDelMes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            var usuario = Session["usuario"];
            if (usuario is Administrador)
            {
                var ordenados = new List<Viaje>();
                if (Fachada.ListarViajesOrdenadosDelMes(ordenados))
                {
                    lstViajes.DataSource = ordenados;
                    lstViajes.DataValueField = "Id";
                    lstViajes.DataTextField = "VerToString";
                    lstViajes.DataBind();
                    lstViajes.Visible = true;
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
            if (Fachada.Obtener(viaje))
            {
                lblDetalle.Text = "Id: " + viaje.Id +
                                  "<br/> Fecha Inicio: " + viaje.Inicio.ToShortDateString() +
                                  "<br/> Fecha final: " + viaje.Fin.ToShortDateString() +
                                  "<br/> Origen: " + viaje.Origen +
                                  "<br/> Destino: " + viaje.Destino +
                                  "<br/> Carga: " + viaje.Carga +
                                  "<br/> Camionero: " + viaje.Camionero.Nombre + " " + viaje.Camionero.Apellido +
                                  "<br/> Viaje realizado  en camión: " + viaje.Camión.Matrícula;
                lblMensajes.Text = "";
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }
    }
}