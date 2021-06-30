using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Forms
{
    public partial class frmListaParadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrillaParadas();
        }
        protected void ActualizarGrillaParadas()
        {
            this.grdParadas.DataSource = Dominio.Fachada.ListarParadas();
            this.grdParadas.DataBind();
        }

        protected void LimpiarCampos()
        {
            this.lblIdViaje.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
            
        }

        protected void btnModificarEstado_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(this.lblIdViaje.Text);
            viaje.Estado = this.ddlEstado.Text;
            

            try
            {
                
                bool estadoViaje = Dominio.Fachada.ModificarEstadoViaje(viaje);

                if (estadoViaje)
                {
                    this.LimpiarCampos();
                    this.lblResultado.Text = "Estado modificado correctamente.";                    
                    this.ActualizarGrillaParadas();
                    this.btnModificarEstado.Visible = false;
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
            this.btnModificarEstado.Visible = false;
        }

        protected void grdParadas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {


            TableCell celdaIdViaje = grdParadas.Rows[e.NewSelectedIndex].Cells[4];
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(celdaIdViaje.Text);
            viaje = Dominio.Fachada.TraerViaje(viaje);

            if (viaje != null)
            {
                this.lblIdViaje.Text = viaje.Id.ToString();
                this.btnModificarEstado.Visible = true;               
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);

            }
        }
    }
}