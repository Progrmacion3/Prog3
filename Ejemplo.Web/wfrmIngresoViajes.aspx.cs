using Common;
using Dominio;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class wfrmIngresoViajes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var usuario = Session["usuario"];
                if (usuario is Administrador)
                {
                    var ciudades = new List<Ciudad>();
                    Fachada.Listar(ciudades);
                    lstCiudIni.DataSource = ciudades;
                    lstCiudFin.DataSource = ciudades;
                    lstCiudIni.DataValueField = "Id";
                    lstCiudFin.DataValueField = "Id";
                    lstCiudIni.DataTextField = "VerToString";
                    lstCiudFin.DataTextField = "VerToString";
                    lstCiudIni.DataBind();
                    lstCiudFin.DataBind();

                    var camiones = new List<Camión>();
                    Fachada.Listar(camiones);
                    lstCamion.DataSource = camiones;
                    lstCamion.DataValueField = "Id";
                    lstCamion.DataTextField = "VerToString";
                    lstCamion.DataBind();

                    var camioneros = new List<Camionero>();
                    Fachada.Listar(camioneros);
                    lstCamionero.DataSource = camioneros;
                    lstCamionero.DataValueField = "Id";
                    lstCamionero.DataTextField = "VerToString";
                    lstCamionero.DataBind();

                    ListarViajes();
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        private void ListarViajes()
        {
            var lista = new List<Viaje>();
            Fachada.Listar(lista);
            lstViajes.DataSource = null;
            lstViajes.DataSource = lista;
            lstViajes.DataValueField = "Id";
            lstViajes.DataTextField = "VerToString";
            lstViajes.DataBind();
        }

        protected void lstViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViajes.SelectedItem == null)
                return;

            var id = int.Parse(lstViajes.SelectedValue);
            var viaje = new Viaje(id);
            Fachada.Obtener(viaje);
            txtIdViaje.Text = id.ToString();
            ddlCarga.SelectedValue = viaje.Carga;
            txtFecIni.Text = viaje.Inicio.ToString();
            txtFecFin.Text = viaje.Fin.ToString();
            lstCamion.SelectedValue = viaje.Camión.Id.ToString();
            lstCamionero.SelectedValue = viaje.Camionero.Id.ToString();
            lstCiudIni.SelectedValue = viaje.Origen.Id.ToString();
            lstCiudFin.SelectedValue = viaje.Origen.Id.ToString();
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            DateTime inicio, fin;
            int idCamión, idCamionero, idOrigen, idDestino;
            if (IntentarLeerFecha(txtFecIni, "La fecha de inicio del viaje no se ingresó correctamente", out inicio) &&
                IntentarLeerFecha(txtFecFin, "La fecha de fin del viaje no se ingresó correctamente", out fin) &&
                IntentarLeerId(lstCamion, "Debe elegir un camión.", out idCamión) &&
                IntentarLeerId(lstCamionero, "Debe elegir un camionero.", out idCamionero) &&
                IntentarLeerId(lstCiudIni, "Debe elegir una ciudad de origen.", out idOrigen) &&
                IntentarLeerId(lstCiudFin, "Debe elegir una ciudad de destino.", out idDestino))
            {
                var camión = new Camión(idCamión);
                var camionero = new Camionero(idCamionero);
                var origen = new Ciudad(idOrigen);
                var destino = new Ciudad(idDestino);
                var viaje = new Viaje(
                    ddlCarga.SelectedValue,
                    inicio,
                    fin,
                    origen,
                    destino,
                    camión,
                    camionero
                );
                if (Fachada.Alta(viaje))
                {
                    lblMensajes.Text = "Ingreso correcto";
                    txtIdViaje.Text = viaje.Id.ToString();
                    ListarViajes();
                }
                else
                {
                    lblMensajes.Text = "Error de base de datos.";
                }
            }
        }

        private bool IntentarLeerFecha(TextBox caja, string error, out DateTime fecha)
        {
            if (DateTime.TryParse(caja.Text, out fecha))
                return true;

            lblMensajes.Text = error;
            return false;
        }

        private bool IntentarLeerId(ListControl lista, string error, out int id)
        {
            if (lista.SelectedItem == null)
            {
                lblMensajes.Text = error;
                id = 0;
                return false;
            }
            else
            {
                id = int.Parse(lista.SelectedValue);
                return true;
            }
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtIdViaje.Text, out id))
            {
                lblMensajes.Text = "Error: No se pudo dar de baja";
                return;
            }

            var viaje = new Viaje(id);
            if (Fachada.Baja(viaje))
            {
                lblMensajes.Text = "Viaje dado de baja correctamente";
                ListarViajes();
                Limpiar();
            }
            else
            {
                lblMensajes.Text = "No se pudo dar de baja";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

            // lista.SelectedIndex --> basededatos.ObtenerPorIndice()
            // lista.SelectedItem --> ToString --> i = Find(" ") --> SubString(0, i) --> id
        }

        private void Limpiar()
        {
            txtIdViaje.Text = "";
            ddlCarga.ClearSelection();
            txtFecIni.Text = "";
            txtFecFin.Text = "";
            lstViajes.ClearSelection();
        }
    }
}