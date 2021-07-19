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
                this.txtEstadoViajeC.Text = string.Empty;
                this.txtKilajeC.Text = string.Empty;
             
            }

        }

       

        protected void btnActualizarViaje_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje viajeC = new Common.Clases.Viaje();
            viajeC.EstadoViaje = this.txtEstadoViajeC.Text;
            viajeC.Kilaje = int.Parse(this.txtKilajeC.Text);
            

            try
            {
                bool resultadoViaje = Dominio.Fachada.Modificar_ViajeC(viajeC);

                if (resultadoViaje)
                {
                    lblResultadoViaC.Text = "Se ha actualizado correctamente el estado y kilaje del viaje";
                    ActualizarGrilaDeViaje();
                    ModoEdicionViajeC(false);
                }
                else
                {
                    lblResultadoViaC.Text = "Error: no se actualizo ni el kilaje ni el estado";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grillaViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                this.lblResultadoViaC.Text = string.Empty;

                TableCell celdaId = grillaViajes.Rows[e.NewSelectedIndex].Cells[1];
                Common.Clases.Viaje viajeC = new Common.Clases.Viaje();
                viajeC.identificadorViaje = int.Parse(celdaId.Text);
                viajeC = Dominio.Fachada.Traer_UnViaje(viajeC);


            if (viajeC != null)
                {
                    this.txtEstadoViajeC.Text = viajeC.EstadoViaje;
                    this.txtKilajeC.Text = viajeC.Kilaje.ToString();
                     
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Error: no se pudo eliminar')", true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void btnCancelarViaje_Click(object sender, EventArgs e)
        {
            ModoEdicionViajeC(false);
        }
    }
}