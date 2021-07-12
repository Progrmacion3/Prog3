using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class Viaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrilaDeViaje();
            ActualizarGrillaCamioneros();
            ActualizarGrillaCamiones();
        }

        protected bool validarCampoCamion()
        {
            bool resultado = true;
            if(Session["idCamion"] == null)
            {
                resultado = false;
            }

            if(Session["idCamion"] !=null && int.Parse(Session["idCamion"].ToString())==0)
            {
                resultado = false;
            }
            return resultado;
        }

        protected bool validarCampoCamionero()
        {
            bool resultado = true;
            if (Session["idCamionero"] == null)
            {
                resultado = false;
            }

            if (Session["idCamionero"] != null && int.Parse(Session["idCamionero"].ToString()) == 0)
            {
                resultado = false;
            }
            return resultado;
        }

        protected void limpiarCamposCamion()
        {
            this.lblIDcamion.Text = string.Empty;
            Session["idCamion"] = 0;
        }

        protected void limpiarCamposCamionero()
        {
            this.lblIDcamionero.Text = string.Empty;
            Session["idCamionero"] = 0;
        }

       protected void ActualizarGrilaDeViaje()
        {
            this.grillaViajes.DataSource = Dominio.Fachada.Traer_Viaje();
            this.grillaViajes.DataBind();
        }

        protected void ActualizarGrillaCamiones()
        {
            this.grillaCamiones.DataSource = Dominio.Fachada.Traer_Camiones();
            this.grillaCamiones.DataBind();
        }

        protected void ActualizarGrillaCamioneros()

        {
            this.grillaCamioneros.DataSource = Dominio.Fachada.Traer_Camioneros();
            this.grillaCamioneros.DataBind();
        }

        protected void ModoEdicionViaje(bool value)
        {
            if (value)
            {
                this.btnAgregarViaje.Visible = false;
                this.btnModificarViaje.Visible = true;
                this.grillaCamiones.Enabled = false;
                this.grillaCamioneros.Enabled = false;
            }
            else
            {
                this.btnAgregarViaje.Visible = true;
                this.btnModificarViaje.Visible = false;
                this.grillaCamiones.Enabled= true;
                this.grillaCamioneros.Enabled = true;
                this.lblIDcamion.Text = string.Empty;
                this.lblIDcamionero.Text = string.Empty;
                this.txtTipoCarga.Text = string.Empty;
                this.txtEstadoViaje.Text = string.Empty;
                this.txtKilaje.Text = string.Empty;
                this.txtOrigen.Text = string.Empty;
                this.txtDestino.Text = string.Empty;
                this.txtFechaInicio.Text = string.Empty;
                this.txtFechaFinalizacion.Text = string.Empty; 
            }

        }

        protected void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnModificarViaje_Click(object sender, EventArgs e)
        {

        }

        protected void grillaViajes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grillaViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void grillaCamioneros_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void grillaCamiones_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}