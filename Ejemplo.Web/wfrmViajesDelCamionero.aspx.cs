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
            if (IsPostBack)
                return;

            var usuario = Session["usuario"];
            if (usuario is Administrador)
            {
                lstCamioneros.DataValueField = "Id";
                lstCamioneros.DataTextField = "VerToString";
                lstViajes.DataValueField = "Id";
                lstViajes.DataTextField = "VerToString";
                MostrarCamioneros();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void lstCamioneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCamioneros.SelectedItem == null)
                return;

            var id = int.Parse(lstCamioneros.SelectedValue);
            var camionero = new Camionero(id);
            if (Fachada.Obtener(camionero))
            {
                MostrarViajes(camionero);
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            lstCamioneros.DataSource = null;

            if (txtCedula.Text == "")
            {
                MostrarCamioneros();
                return;
            }

            int cédula;
            if (!int.TryParse(txtCedula.Text, out cédula))
            {
                lblMensajes.Text = "La cédula debe ser un número.";
                return;
            }

            var camionero = new Camionero { Cédula = cédula };
            if (Fachada.ObtenerCamioneroPorCédula(camionero))
            {
                if (camionero.Id == 0)
                {
                    lblMensajes.Text = "No se encuentra el camionero de cédula " + cédula + ".";
                    return;
                }

                var lista = new List<Camionero> { camionero };
                lstCamioneros.DataSource = lista;
                lstCamioneros.DataBind();
                if (lista.Count == 1)
                {
                    MostrarViajes(lista[0]);
                }
                else
                {
                    lblMensajes.Text = "";
                }
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }

        private void MostrarCamioneros()
        {
            var lista = new List<Camionero>();
            if (Fachada.Listar(lista))
            {
                lstCamioneros.DataSource = lista;
                lstCamioneros.DataBind();
                lblMensajes.Text = "";
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }

        private void MostrarViajes(Camionero camionero)
        {
            var lista = new List<Viaje>();
            if (Fachada.ListarViajes(camionero, lista))
            {
                lstViajes.DataSource = null;
                lstViajes.DataSource = lista;
                lstViajes.DataBind();
                lblMensajes.Text = "";
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }
    }
}