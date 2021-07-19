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
                this.btnCancelarViaje.Visible = true;
                this.grillaCamiones.Enabled = false;
                this.grillaCamioneros.Enabled = false;
            }
            else
            {
                this.btnAgregarViaje.Visible = true;
                this.btnModificarViaje.Visible = false;
                this.btnCancelarViaje.Visible = false;
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
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Tipo_Carga = this.txtTipoCarga.Text;
            viaje.Kilaje = int.Parse(this.txtKilaje.Text);
            viaje.Origen = this.txtOrigen.Text;
            viaje.Destino = this.txtDestino.Text;
            viaje.Fecha_Inicio = DateTime.Parse(this.txtFechaInicio.Text);
            viaje.Fecha_Finalizacion= DateTime.Parse(this.txtFechaFinalizacion.Text);

            if(validarCampoCamion() && validarCampoCamionero())
            {
                int idCam = 0;
                int.TryParse(Session["idCamion"].ToString(), out idCam);
                viaje.Camion = new Common.Clases.Camion() { idCamion = idCam };

                int idCami = 0;
                int.TryParse(Session["idCamionero"].ToString(), out idCami);
                viaje.Camionero = new Common.Clases.Camionero() { identificadorCam = idCami };

                if(Dominio.Fachada.Agregar_Viaje(viaje))
                {
                    lblResultadoVia.Text = "Se ha agregado el viaje de manera exitosa";
                    ActualizarGrilaDeViaje();
                }
                else
                {
                    lblResultadoVia.Text = "No se ha agregado el viaje";
                }
            }
            else
            {
                lblResultadoVia.Text = "No se ha seleccionado ni un camion ni un camionero";
            }
        }

        protected void btnModificarViaje_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Tipo_Carga = this.txtTipoCarga.Text;
            viaje.Kilaje = int.Parse(this.txtKilaje.Text);
            viaje.Origen = this.txtOrigen.Text;
            viaje.Destino = this.txtDestino.Text;
            viaje.Fecha_Inicio = DateTime.Parse(this.txtFechaInicio.Text);
            viaje.Fecha_Finalizacion = DateTime.Parse(this.txtFechaFinalizacion.Text);
            viaje.identificadorViaje = int.Parse(this.lblIdViaje.Text);

            if (Dominio.Fachada.Modificar_Viaje(viaje))
            {
                lblResultadoVia.Text = "Se ha Modificado el viaje de manera correcta";
            }
            else
            {
                lblResultadoVia.Text = "No se ha modificado el viaje";
            }

        }

        protected void grillaViajes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultadoVia.Text = string.Empty;

                TableCell celdaId = grillaViajes.Rows[e.RowIndex].Cells[1];
                Common.Clases.Viaje via = new Common.Clases.Viaje();
                via.identificadorViaje = int.Parse(celdaId.Text);

                bool resultado = Dominio.Fachada.Eliminar_Viaje(via);

                if (resultado)
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Eliminado exitosamente.')", true);
                    ActualizarGrilaDeViaje();
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo eliminar.')", true);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grillaViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultadoVia.Text = string.Empty;


            TableCell celdaId = grillaViajes.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Viaje via = new Common.Clases.Viaje();
            via.identificadorViaje = int.Parse(celdaId.Text);
            this.lblIdViaje.Text = celdaId.Text;
            via = Dominio.Fachada.Traer_UnViaje(via);

            if (via != null)
            {
                via.Tipo_Carga = this.txtTipoCarga.Text;
                via.Kilaje = int.Parse(this.txtKilaje.Text);
                via.Origen = this.txtOrigen.Text;
                via.Destino = this.txtDestino.Text;
                via.Fecha_Inicio = DateTime.Parse(this.txtFechaInicio.Text);
                via.Fecha_Finalizacion = DateTime.Parse(this.txtFechaFinalizacion.Text);
                ModoEdicionViaje(true);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
                ModoEdicionViaje(false);
            }
        }

        protected void grillaCamioneros_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultadoVia.Text = string.Empty;

            TableCell celdaId = grillaCamioneros.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Camionero camionero = new Common.Clases.Camionero();
            camionero.identificadorCam = int.Parse(celdaId.Text);
            camionero = Dominio.Fachada.Traer_UnCamionero(camionero);

            if (camionero != null)
            {
                limpiarCamposCamionero();
                this.lblIDcamionero.Text = camionero.Tipo_Libreta;
                Session["idCamionero"] = camionero.identificadorCam;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
                limpiarCamposCamionero();
            }

        }

        protected void grillaCamiones_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultadoVia.Text = string.Empty;

            TableCell celdaId = grillaCamiones.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Camion camion = new Common.Clases.Camion();
            camion.idCamion = int.Parse(celdaId.Text);
            camion = Dominio.Fachada.Traer_UnCamion(camion);

            if (camion != null)
            {
                limpiarCamposCamion();
                this.lblIDcamion.Text = camion.Matricula;
                Session["idCamion"] = camion.idCamion;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
                limpiarCamposCamion();
            }

        }

        protected void btnCancelarViaje_Click(object sender, EventArgs e)
        {
            ModoEdicionViaje(false);
        }
    }
}