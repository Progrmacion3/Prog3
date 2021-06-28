using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Forms
{
    public partial class frmViaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrillaCamioneros();
            ActualizarGrillaCamiones();
            ActualizarGrillaViajes();
        }
        protected void ActualizarGrillaCamioneros()
        {
            this.grdCamioneros.DataSource = Dominio.Fachada.ListarCamioneros();
            this.grdCamioneros.DataBind();
        }

         protected void ActualizarGrillaCamiones()
        {
            this.grdCamiones.DataSource = Dominio.Fachada.ListarCamiones();
            this.grdCamiones.DataBind();
        }
        
        protected void ActualizarGrillaViajes()
        {
            this.grdViajes.DataSource = Dominio.Fachada.ListarViajes();
            this.grdViajes.DataBind();
        }        

        protected void LimpiarCampos()
        {
            this.lblMatriculaCamion.Text = string.Empty;
            this.lblCICamionero.Text = string.Empty;
            this.lblCamion.Text = string.Empty;
            this.lblCamionero.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
            this.txtFechaFinalización.Text = string.Empty;
            this.txtFechaInicio.Text = string.Empty;
            this.txtKilaje.Text = string.Empty;
            this.txtOrigen.Text = string.Empty;
            this.txtDestino.Text = string.Empty;
        }

        protected void grdCamioneros_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaCI = grdCamioneros.Rows[e.NewSelectedIndex].Cells[4];
            Common.Clases.Camionero camionero = new Common.Clases.Camionero();
            camionero.CI = int.Parse(celdaCI.Text);
            camionero = Dominio.Fachada.TraerCamionero(camionero);

            if (camionero != null)
            {
                this.lblCICamionero.Text = camionero.CI.ToString();
                this.lblCamionero.Text = camionero.Nombre + " " + camionero.Apellido;
              
                Session["IdentificadorCamionero"] = camionero.CI;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
                
            }


        }

        protected void grdCamiones_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaMatricula = grdCamiones.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Camion camion = new Common.Clases.Camion();
            camion.Matricula = celdaMatricula.Text;
            camion = Dominio.Fachada.TraerCamion(camion);

            if (camion != null)
            {
                this.lblMatriculaCamion.Text = camion.Matricula;
                this.lblCamion.Text = camion.Matricula + " " + camion.Marca;

                Session["IdentificadorCamion"] = camion.Matricula;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
                
            }

        }

        protected void grdViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaIdViaje = grdViajes.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(celdaIdViaje.Text);
            viaje = Dominio.Fachada.TraerViaje(viaje);

            if (viaje != null)
            {
                this.LimpiarCampos();
                this.ddlTipoCarga.SelectedItem.Text = viaje.TipoCarga;
                this.txtOrigen.Text = viaje.Origen;
                this.txtDestino.Text = viaje.Destino;
                this.txtKilaje.Text = viaje.Kilaje.ToString();
                this.txtFechaInicio.Text = viaje.FechaInicio;
                this.txtFechaFinalización.Text = viaje.FechaFinalizacion;
                this.ddlEstado.SelectedItem.Text = viaje.Estado;

                Session["IdentificadorViaje"] = viaje.Id;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);

            }
        }

        protected void grdViajes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultado.Text = string.Empty;

                TableCell celdaId = grdViajes.Rows[e.RowIndex].Cells[1];
                Common.Clases.Viaje viaje = new Common.Clases.Viaje();
                viaje.Id = short.Parse(Session["idenficadorViaje"].ToString());

                bool resultado = Dominio.Fachada.BajaViaje(viaje);

                if (resultado)
                {
                    this.lblResultado.Text = "Eliminado exitosamente";
                    this.ActualizarGrillaViajes();
                    this.LimpiarCampos();
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

        protected void btnAltaViaje_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            Common.Clases.Camion camion = new Common.Clases.Camion();
            camion.Matricula = this.lblMatriculaCamion.Text;
            camion = Dominio.Fachada.TraerCamion(camion);
            viaje.Camion = camion;
            Common.Clases.Camionero camionero = new Common.Clases.Camionero();
            camionero.CI = int.Parse(this.lblCICamionero.Text);
            camionero = Dominio.Fachada.TraerCamionero(camionero);
            viaje.Camionero = camionero;
            viaje.TipoCarga = this.ddlTipoCarga.SelectedItem.Text;
            viaje.Kilaje = int.Parse(this.txtKilaje.Text);
            viaje.Origen = this.txtOrigen.Text;
            viaje.Destino = this.txtDestino.Text;
            viaje.FechaInicio = this.txtFechaInicio.Text;
            viaje.FechaFinalizacion = this.txtFechaFinalización.Text;
            viaje.Estado = this.ddlEstado.Text;

            try
            {
                bool resultado = Dominio.Fachada.AltaViaje(viaje);

                if (resultado)
                {
                    this.lblResultado.Text = "Agregada correctamente.";
                    this.LimpiarCampos();
                    this.ActualizarGrillaViajes();
                }
                else
                {
                    this.lblResultado.Text = "ERROR: No se pudo agregar.";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnModificarViaje_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();

            viaje.Camion = new Common.Clases.Camion();
            viaje.Camion.Matricula = this.lblMatriculaCamion.Text;
            viaje.Camion = Dominio.Fachada.TraerCamion(viaje.Camion);
            viaje.TipoCarga = this.ddlTipoCarga.SelectedItem.Text;


            //viaje.Marca = this.txtMarca.Text;
            //viaje.Modelo = this.txtModelo.Text;
            //viaje.Year = short.Parse(this.txtYear.Text);

            try
            {
                bool resultado = Dominio.Fachada.ModificarViaje(viaje);

                if (resultado)
                {
                    this.lblResultado.Text = "Modificado correctamente.";
                    this.ActualizarGrillaViajes();
                    this.LimpiarCampos();
                }
                else
                {
                    lblResultado.Text = "ERROR: No se pudo modificar.";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        
    }
}