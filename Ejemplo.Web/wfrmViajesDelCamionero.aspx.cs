using Common;
using Dominio;
using System;
using System.Collections.Generic;

namespace Ejemplo.Web
{
    public partial class wfrmViajesDelCamionero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var usuario = Session["usuario"];
                if (usuario is Administrador)
                {
                    var lista = new List<Camionero>();
                    lstCamioneros.DataSource = null;
                    if (Fachada.Listar(lista))
                    {
                        lstCamioneros.DataSource = lista;
                        lstCamioneros.DataValueField = "Id";
                        lstCamioneros.DataTextField = "VerToString";
                        lstCamioneros.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            int cédula;
            if (!int.TryParse(txtCedula.Text, out cédula))
            {
                lstCamioneros.DataSource = null;
                return;
            }

            var lista = new List<Camionero>();
            lstCamioneros.DataSource = null;
            if (Fachada.ListarCamioneros(cédula, lista))
            {
                lstCamioneros.DataSource = lista;
                lstCamioneros.DataBind();
                if (lista.Count == 1)
                    MostrarViajes(lista[0]);
            }
        }

        private void MostrarViajes(Camionero camionero)
        {

        }

        protected void lstCamioneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCamioneros.SelectedItem == null)
                return;

            var id = int.Parse(lstCamioneros.SelectedValue);
            var camionero = new Camionero(id);
            if (Fachada.Obtener(camionero))
            {
                var lista = new List<Viaje>();
                if (Fachada.ListarViajes(camionero, lista))
                {
                    lstViajes.DataSource = null;
                    lstViajes.DataSource = lista;
                    lstViajes.DataValueField = "Id";
                    lstViajes.DataTextField = "VerToString";
                    lstViajes.DataBind();
                    return;
                }
            }
            lblMensajes.Text = "Error de base de datos.";
        }
    }
}