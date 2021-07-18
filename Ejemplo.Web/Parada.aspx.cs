using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class Parada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrillaParadas();
        }
        protected void ModoEdicionParada(bool pVisible)
        {
            this.txtIdentificadorPar.Enabled = false;
            this.txtIdentificadorPar.Visible = pVisible;
            this.lblIdentificadorPar.Visible = pVisible;
            this.btnModificarParada.Visible = pVisible;
            this.btnCancelarParada.Visible = pVisible;
            this.btnAgregarParada.Visible = !pVisible;

            if (!pVisible)
            {
                this.txtIdentificadorPar.Text = string.Empty;
                this.txtEstadoParada.Text = string.Empty;
                this.txtTipoParada.Text = string.Empty;
                this.txtComentarioAdmin.Text = string.Empty;
                this.grillaParadas.SelectedIndex = -1;
            }
        }


        protected void ActualizarGrillaParadas()
        {
            this.grillaParadas.DataSource = Dominio.Fachada.Traer_Paradas();
            this.grillaParadas.DataBind();
        }

        protected void LimpiarCamposParadas()
        {
            this.txtComentarioAdmin.Text = string.Empty;
            this.txtEstadoParada.Text = string.Empty;
            this.txtTipoParada.Text = string.Empty;
          
        }

        protected void btnAgregarParada_Click(object sender, EventArgs e)
        {
            Common.Clases.Parada parada = new Common.Clases.Parada();
            parada.Comentario = this.txtComentarioAdmin.Text;
            parada.EstadoParada = this.txtEstadoParada.Text;
            parada.Tipo = this.txtTipoParada.Text;

            try
            {
                bool resultadoParada = Dominio.Fachada.Agregar_Parada(parada);

                if (resultadoParada)
                {
                    lblResultadoParada.Text = "Se ha agregado correctamente una parada";
                    LimpiarCamposParadas();
                    ActualizarGrillaParadas();
                }
                else
                {
                    lblResultadoParada.Text = "Error: no se agrego la parada";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnModificarParada_Click(object sender, EventArgs e)
        {
            Common.Clases.Parada parada = new Common.Clases.Parada();
            parada.Comentario = this.txtComentarioAdmin.Text;
            parada.EstadoParada = this.txtEstadoParada.Text;
            parada.Tipo = this.txtTipoParada.Text;

            try
            {
                bool resultadoParada = Dominio.Fachada.Modificar_Parada(parada);

                if (resultadoParada)
                {
                    lblResultadoParada.Text = "Se ha modificado correctamente una parada";
                    ActualizarGrillaParadas();
                    ModoEdicionParada(false);
                }
                else
                {
                    lblResultadoParada.Text = "Error: no se modifico la parada";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grillaParadas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultadoParada.Text = string.Empty;

                TableCell celdaIdpar = grillaParadas.Rows[e.RowIndex].Cells[1];
                Common.Clases.Parada parada = new Common.Clases.Parada();
                parada.identificadorPar = int.Parse(celdaIdpar.Text);

                bool resultado = Dominio.Fachada.Eliminar_Parada(parada);

                if (resultado)
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Parada eliminado exitosamente')", true);

                }

                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Error: no se pudo eliminar la parada')", true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grillaParadas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                this.lblResultadoParada.Text = string.Empty;

                TableCell celdaId = grillaParadas.Rows[e.NewSelectedIndex].Cells[1];
                Common.Clases.Parada parada = new Common.Clases.Parada();
                parada.identificadorPar = int.Parse(celdaId.Text);
                parada = Dominio.Fachada.Traer_UnaParada(parada);


            if (parada != null)
                {
                      
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Error: no se pudo cargar el dato')", true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCancelarParada_Click(object sender, EventArgs e)
        {
            ModoEdicionParada(false);
        }
    }
}
