using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Admin
{
    public partial class ABM_Viaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }

        protected void grdViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celda = grdViajes.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.IdViaje = int.Parse(celda.Text);
            viaje = Dominio.Fachada.MostrarViajeEspecifico(viaje);

            if (viaje != null)
            {
                this.txtIdViaje.Text = Convert.ToString(viaje.IdViaje);
                this.txtIdCamionero.Text = Convert.ToString(viaje.IdCamionero);
                this.txtIdCamion.Text = Convert.ToString(viaje.IdCamion);
                this.ddlTipoCarga.SelectedItem.Text = viaje.TipoCarga;
                this.txtKilaje.Text = Convert.ToString(viaje.Kilaje);
                this.txtOrigen.Text = viaje.Origen;
                this.txtDestino.Text = viaje.Destino;
                this.txtFechaInicio.Text = Convert.ToString(viaje.FechaInicio);
                this.txtFechaFin.Text = Convert.ToString(viaje.FechaFinal);
                this.ddlEstado.SelectedItem.Text = viaje.Estado; 
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert ('ERROR: No se pudo cargar la fila.')", true);
            }
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje unViaje = new Common.Clases.Viaje();
            unViaje.IdCamionero = int.Parse(this.txtIdCamionero.Text);
            unViaje.IdCamion = int.Parse(this.txtIdCamion.Text);
            unViaje.TipoCarga = this.ddlTipoCarga.SelectedItem.Text;
            unViaje.Kilaje = int.Parse(this.txtKilaje.Text);
            unViaje.Origen = this.txtOrigen.Text;
            unViaje.Destino = this.txtDestino.Text;
            unViaje.FechaInicio = Convert.ToDateTime(this.txtFechaInicio.Text);
            unViaje.FechaFinal = Convert.ToDateTime(this.txtFechaFin.Text);
            unViaje.Estado = this.ddlEstado.SelectedItem.Text;

            bool verdadero = Dominio.Fachada.ViajeAgregar(unViaje);

            if (verdadero)
            {
                this.ActualizarLista();
                lblResultado.Text = "Se ha registrado el viaje de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido registrar el viaje.";
            }
            this.Limpiar();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje unViaje = new Common.Clases.Viaje();
            unViaje.IdViaje = int.Parse(this.txtIdViaje.Text);

            bool verdadero = Dominio.Fachada.ViajeEliminar(unViaje);

            if (verdadero)
            {
                this.ActualizarLista();
                lblResultado.Text = "Se ha eliminado el viaje de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido eliminar el viaje.";
            }
            this.Limpiar();
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje unViaje = new Common.Clases.Viaje();
            unViaje.IdViaje = int.Parse(this.txtIdViaje.Text);
            unViaje.IdCamionero = int.Parse(this.txtIdCamionero.Text);
            unViaje.IdCamion = int.Parse(this.txtIdCamion.Text);
            unViaje.TipoCarga = this.ddlTipoCarga.SelectedItem.Text;
            unViaje.Kilaje = int.Parse(this.txtKilaje.Text);
            unViaje.Origen = this.txtOrigen.Text;
            unViaje.Destino = this.txtDestino.Text;
            unViaje.FechaInicio = Convert.ToDateTime(this.txtFechaInicio.Text);
            unViaje.FechaFinal = Convert.ToDateTime(this.txtFechaFin.Text);
            unViaje.Estado = this.ddlEstado.SelectedItem.Text;

            bool verdadero = Dominio.Fachada.ViajeModificar(unViaje);

            if (verdadero)
            {
                this.ActualizarLista();
                this.Limpiar();
                lblResultado.Text = "Se ha modificado el viaje de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido modificar el viaje.";
            }
        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        protected void Limpiar()
        {
            this.txtIdViaje.Text = string.Empty;
            this.txtIdCamion.Text = string.Empty;
            this.txtIdCamionero.Text = string.Empty;
            this.txtKilaje.Text = string.Empty;
            this.txtOrigen.Text = string.Empty;
            this.txtDestino.Text = string.Empty;
            this.txtFechaInicio.Text = string.Empty;
            this.txtFechaFin.Text = string.Empty;
        }
        protected void grdCamiones_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celda = grdCamiones.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Camion camion = new Common.Clases.Camion();
            camion.IdCamion = int.Parse(celda.Text);
            camion = Dominio.Fachada.MostrarCamionEspecifico2(camion);

            if (camion != null)
            {
                this.txtIdCamion.Text = Convert.ToString(camion.IdCamion);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert ('ERROR: No se pudo cargar la fila.')", true);
            }
        }
        protected void grdCamioneros_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celda = grdCamioneros.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Camionero camionero = new Common.Clases.Camionero();
            camionero.IdCamionero = int.Parse(celda.Text);
            camionero = Dominio.Fachada.MostrarCamioneroEspecifico2(camionero);

            if (camionero != null)
            {
                this.txtIdCamionero.Text = Convert.ToString(camionero.IdCamionero);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert ('ERROR: No se pudo cargar la fila.')", true);
            }
        }
        protected void ActualizarLista()
        {
            this.grdCamiones.DataSource = Dominio.Fachada.MostrarCamiones();
            this.grdCamiones.DataBind();

            this.grdCamioneros.DataSource = Dominio.Fachada.MostrarCamionero();
            this.grdCamioneros.DataBind();

            this.grdViajes.DataSource = Dominio.Fachada.MostrarViajes();
            this.grdViajes.DataBind();
        }

        protected void grdCamioneros_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[3].Visible = false;
            e.Row.Cells[8].Visible = false;
            e.Row.Cells[9].Visible = false;
            e.Row.Cells[10].Visible = false;
            e.Row.Cells[11].Visible = false;
            e.Row.Cells[12].Visible = false;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int cedula = int.Parse(this.txtCedulaCamionero.Text);
            this.grdViajes.DataSource = Dominio.Fachada.MostrarViajesPorCamionero(cedula);
            this.grdViajes.DataBind();
            this.txtCedulaCamionero.Text = string.Empty;
            this.txtCedulaCamionero.Focus();
        }

        protected void btnVerTodo_Click(object sender, EventArgs e)
        {
            this.ActualizarLista();
            this.txtCedulaCamionero.Text = string.Empty;
            this.txtCedulaCamionero.Focus();
        }
    }
}