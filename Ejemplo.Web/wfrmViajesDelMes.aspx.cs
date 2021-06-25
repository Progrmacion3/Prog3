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
            var ordenados = new List<Viaje>();
            lstViajes.DataSource = null;
            if (Fachada.ListarViajesOrdenadosDelMes(ordenados))
            {
                lstViajes.DataSource = ordenados;
                lstViajes.DataBind();
                lstViajes.Visible = true;
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }

        protected void lstViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViajes.SelectedItem == null)
            {
                return;
            }
            var seleccionado = lstViajes.SelectedItem.ToString();
            var i = seleccionado.IndexOf(' ');
            var id = int.Parse(seleccionado.Substring(0, i));

            var viaje = new Viaje(id);
            Fachada.Obtener(viaje);
            lblDetalle.Text = "Id: " + viaje.Id + "\n"
                + "Fecha: " + "...";
            // Completar detalle del viaje.
        }
    }
}