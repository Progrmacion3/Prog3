using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Forms
{
    public partial class frmModificarKilaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActualizarGrillaViajes();
        }

        protected void ActualizarGrillaViajes()
        {
            Common.Clases.Camionero emp = new Common.Clases.Camionero();
            emp.CI = int.Parse(Session["CiEmpleadoInicioSesion"].ToString());

            this.grdViajes.DataSource = Dominio.Fachada.ListarViajesPorCamionero(emp);
            this.grdViajes.DataBind();
        }

        protected void LimpiarCampos()
        {
            this.lblIdViaje.Text = string.Empty;
            this.txtKilaje.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
            this.lblResultado2.Text = string.Empty;
            this.lblKilajeViejo.Text = string.Empty;
        }

        protected void btnModificarKilaje_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(this.lblIdViaje.Text);
            viaje.Kilaje = int.Parse(this.txtKilaje.Text);
            viaje.Estado = "Parado";

            try
            {
                bool resultado = Dominio.Fachada.ModificarKilajeViaje(viaje);
                bool estadoViaje = Dominio.Fachada.ModificarEstadoViaje(viaje);

                if (resultado && estadoViaje)
                {
                    this.LimpiarCampos();
                    this.lblResultado.Text = "Kilaje actualizado correctamente.";
                    this.lblResultado2.Text = "Estado del viaje cambiado a Parado.";
                    this.ActualizarGrillaViajes();
                    this.btnModificarKilaje.Visible = false;
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

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.btnModificarKilaje.Visible = false;
        }

        protected void grdViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;
            this.lblResultado2.Text = string.Empty;

            TableCell celdaId = grdViajes.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(celdaId.Text);
            viaje = Dominio.Fachada.TraerViaje(viaje);

            if (viaje != null)
            {
                this.lblIdViaje.Text = viaje.Id.ToString();
                this.btnModificarKilaje.Visible = true;
                this.lblKilajeViejo.Visible = true;
                this.txtKilaje.Text = viaje.Kilaje.ToString();
                this.lblKilajeViejo.Text = "Kilaje anterior: "+ viaje.Kilaje.ToString();
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);

            }
        }
    }
}