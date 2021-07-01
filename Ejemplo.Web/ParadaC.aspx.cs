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

        }

        protected void btnActualizarParada_Click(object sender, EventArgs e)
        {
            Common.Clases.Parada paradaC = new Common.Clases.Parada();
            paradaC.Comentario = this.txtComentarioCam.Text;
            paradaC.EstadoParada = this.txtEstadoParadaC.Text;
            paradaC.Tipo = this.txtTipoParadaC.Text;

            try
            {
                bool resultadoParada = Dominio.Fachada.Modificar_Parada(paradaC);

                if (resultadoParada)
                {
                    lblResultadoParadaC.Text = "Se ha agregado correctamente una parada";
                }
                else
                {
                    lblResultadoParadaC.Text = "Error: no se agrego la parada";
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
                    this.txtComentarioCam.Text = paradaC.Comentario;
                    this.txtEstadoParadaC.Text = paradaC.EstadoParada;
                    this.txtTipoParadaC.Text = paradaC.Tipo;
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

    }
}
