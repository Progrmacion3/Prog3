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
            this.grdParadas.DataSource = Dominio.Fachada.ListarParadasAvisar();
            this.grdParadas.DataBind();
        }

        protected void LimpiarCampos()
        {
            this.lblIdViaje.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
            this.txtComentarioEstado.Text = string.Empty;
            this.lblResultado2.Text = string.Empty;
        }

        protected void btnModificarEstado_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(this.lblIdViaje.Text);
            viaje.Estado = this.ddlEstado.Text;
            viaje.Comentario = this.txtComentarioEstado.Text;

            Common.Clases.Parada parada = new Common.Clases.Parada();
            parada.Id = short.Parse(this.lblIdParada.Text);
            parada = Dominio.Fachada.TraerParada(parada);
            
            try
            {
                bool estadoViaje = Dominio.Fachada.ModificarEstadoViaje(viaje);
                bool comentarioAgregado = Dominio.Fachada.AgregarComentarioViaje(viaje);
                bool eliminarParadaAviso = Dominio.Fachada.BajaParadaAvisar(parada);

                if (estadoViaje)
                {
                    this.LimpiarCampos();
                    this.lblResultado.Text = "Estado modificado correctamente.";

                    if (comentarioAgregado)
                    {
                        this.lblResultado2.Text = "Comentario Agregado";
                        this.ActualizarGrillaParadas();
                        this.btnModificarEstado.Visible = false;
                    }
                    else
                    {
                        this.lblResultado.Text = "ERROR: No se pudo agregar el comentario.";
                    }
                }
                else
                {
                    this.lblResultado.Text = "ERROR: Estado no cambiado.";
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
            this.LimpiarCampos();
            TableCell celdaIdViaje = grdParadas.Rows[e.NewSelectedIndex].Cells[4];
            TableCell celdaIdParada = grdParadas.Rows[e.NewSelectedIndex].Cells[1];

            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(celdaIdViaje.Text);
            viaje = Dominio.Fachada.TraerViaje(viaje);

            Common.Clases.Parada parada = new Common.Clases.Parada();
            parada.Id = short.Parse(celdaIdParada.Text);
            parada = Dominio.Fachada.TraerParada(parada);

            if (viaje != null && parada != null)
            {
                this.lblIdParada.Text = parada.Id.ToString();
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