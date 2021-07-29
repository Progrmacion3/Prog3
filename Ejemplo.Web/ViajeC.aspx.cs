using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class ViajeC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrilaDeViaje();
        }

        protected void ActualizarGrilaDeViaje()
        {
            this.grillaViajes.DataSource = Dominio.Fachada.Traer_Viaje();
            this.grillaViajes.DataBind();
        }

        protected void ModoEdicionViajeC(bool value)
        {
            if (value)
            {
                this.btnActualizarViaje.Visible = true;
                this.btnCancelarViaje.Visible = true;

            }
            else
            {

                this.btnActualizarViaje.Visible = false;
                this.btnCancelarViaje.Visible = false;
                this.lblIDviaje.Text = string.Empty;
                this.lblIDcamionC.Text = string.Empty;
                this.lblIDcamioneroC.Text = string.Empty;
                this.txtTipoCargaC.Text = string.Empty;
                this.txtEstadoViajeC.Text = string.Empty;
                this.txtKilajeC.Text = string.Empty;
                this.txtOrigenC.Text = string.Empty;
                this.txtDestinoC.Text = string.Empty;
                this.txtFechaInicioC.Text = string.Empty;
                this.txtFechaFinalizacionC.Text = string.Empty;

            }
        }

        protected bool validarCampoCamion()
        {
            bool resultado = true;
            if (Session["idCamion"] == null)
            {
                resultado = false;
            }

            if (Session["idCamion"] != null && int.Parse(Session["idCamion"].ToString()) == 0)
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


        protected void btnActualizarViaje_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje viajeC = new Common.Clases.Viaje();
            viajeC.identificadorViaje = int.Parse(this.lblIDviaje.Text);
            viajeC.Tipo_Carga = this.txtTipoCargaC.Text;
            viajeC.Origen = this.txtOrigenC.Text;
            viajeC.Destino = this.txtDestinoC.Text;
            viajeC.Fecha_Inicio = DateTime.Parse(this.txtFechaInicioC.Text);
            viajeC.Fecha_Finalizacion = DateTime.Parse(this.txtFechaFinalizacionC.Text);
            viajeC.EstadoViaje = this.txtEstadoViajeC.Text;
            viajeC.Kilaje = int.Parse(this.txtKilajeC.Text);
            if (validarCampoCamion() && validarCampoCamionero())
            {
                int idCam = 0;
                int.TryParse(Session["idCamion"].ToString(), out idCam);
                viajeC.Camion = new Common.Clases.Camion() { idCamion = idCam };

                int idCami = 0;
                int.TryParse(Session["idCamionero"].ToString(), out idCami);
                viajeC.Camionero = new Common.Clases.Camionero() { identificadorCam = idCami };

                if (Dominio.Fachada.Modificar_Viaje(viajeC))
                {
                    lblResultadoViaC.Text = "Se ha agregado el viaje de manera exitosa";
                    ActualizarGrilaDeViaje();
                    ModoEdicionViajeC(false);
                }
                else
                {
                    lblResultadoViaC.Text = "No se ha agregado el viaje";
                }
            }
            else
            {
                lblResultadoViaC.Text = "No se ha seleccionado ni un camion ni un camionero";
            }
        }

        protected void btnCancelarViaje_Click(object sender, EventArgs e)
        {
            ModoEdicionViajeC(false);
        }

        protected void grillaViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultadoViaC.Text = string.Empty;


            TableCell celdaId = grillaViajes.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Viaje viajeC = new Common.Clases.Viaje();
            viajeC.identificadorViaje = int.Parse(celdaId.Text);
            this.lblIDviaje.Text = celdaId.Text;
            viajeC = Dominio.Fachada.Traer_UnViaje(viajeC);

            if(viajeC != null)
            {
                this.lblIDcamionC.Text = viajeC.Camion.Matricula;
                Session["idCamion"] = viajeC.Camion.idCamion;
                this.lblIDcamioneroC.Text = viajeC.Camionero.Tipo_Libreta;
                Session["idCamionero"] = viajeC.Camionero.identificadorCam;
                this.txtTipoCargaC.Text = viajeC.Tipo_Carga;
                this.txtOrigenC.Text = viajeC.Origen;
                this.txtDestinoC.Text = viajeC.Destino;
                this.txtFechaInicioC.Text = viajeC.Fecha_Inicio.ToString();
                this.txtFechaFinalizacionC.Text = viajeC.Fecha_Finalizacion.ToString();
                this.txtKilajeC.Text = viajeC.Kilaje.ToString();
                this.txtEstadoViajeC.Text = viajeC.EstadoViaje;
                ModoEdicionViajeC(true);              
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
                ModoEdicionViajeC(false);

            }
        }
    }


    

       
    }
