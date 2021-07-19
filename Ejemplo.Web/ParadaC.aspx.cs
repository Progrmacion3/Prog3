using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class ParadaC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrillaParadas();
        }
        protected void ModoEdicionParadaC(bool pVisible)
        {
            this.txtIdentificadorParC.Enabled = false;
            this.txtIdentificadorParC.Visible = pVisible;
            this.lblIdentificadorParC.Visible = pVisible;
            this.btnActualizarParada.Visible = pVisible;
            this.btnCancelarParada.Visible = pVisible;

            if (!pVisible)
            {
                this.txtIdentificadorParC.Text = string.Empty;
                this.txtEstadoParadaC.Text = string.Empty;
                this.txtTipoParadaC.Text = string.Empty;
                this.txtComentarioCam.Text = string.Empty;
                this.grillaParadas.SelectedIndex = -1;
            }
        }

        protected void ActualizarGrillaParadas()
        {
            this.grillaParadas.DataSource = Dominio.Fachada.Traer_Paradas();
            this.grillaParadas.DataBind();
        }

        protected void btnActualizarParada_Click(object sender, EventArgs e)
        {
            Common.Clases.Parada paradaC = new Common.Clases.Parada();
            paradaC.identificadorPar = int.Parse(this.txtIdentificadorParC.Text);
            paradaC.Comentario = this.txtComentarioCam.Text;
            paradaC.EstadoParada = this.txtEstadoParadaC.Text;
            paradaC.Tipo = this.txtTipoParadaC.Text;

            try
            {
                bool resultadoParada = Dominio.Fachada.Modificar_Parada(paradaC);

                if (resultadoParada)
                {

                    lblResultadoParadaC.Text = "Se ha actualizado correctamente una parada";
                    ActualizarGrillaParadas();
                    ModoEdicionParadaC(false);
                    
                }
                else
                {
                    lblResultadoParadaC.Text = "Error: no se actualizo la parada";
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
                this.lblResultadoParadaC.Text = string.Empty;

                TableCell celdaId = grillaParadas.Rows[e.NewSelectedIndex].Cells[1];
                Common.Clases.Parada paradaC = new Common.Clases.Parada();
                paradaC.identificadorPar = int.Parse(celdaId.Text);
                paradaC = Dominio.Fachada.Traer_UnaParada(paradaC);


            if (paradaC != null)
                {
                    this.txtIdentificadorParC.Text = paradaC.identificadorPar.ToString();
                    this.txtComentarioCam.Text = paradaC.Comentario;
                    this.txtEstadoParadaC.Text = paradaC.EstadoParada;
                    this.txtTipoParadaC.Text = paradaC.Tipo;
                    ModoEdicionParadaC(true);
                }
                else
                {
                    ModoEdicionParadaC(false);
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Error: no se pudo eliminar')", true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCancelarParada_Click(object sender, EventArgs e)
        {
            ModoEdicionParadaC(false);
        }
    }
}
