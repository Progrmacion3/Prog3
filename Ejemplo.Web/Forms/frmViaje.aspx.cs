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

        protected void grdCamioneros_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaCI = grdCamioneros.Rows[e.NewSelectedIndex].Cells[4];
            Common.Clases.Camionero camionero = new Common.Clases.Camionero();
            camionero.CI = int.Parse(celdaCI.Text);
            camionero = Dominio.Fachada.TraerCamionero(camionero);

            if (camionero != null)
            {
                
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
                
                this.lblCamion.Text = camion.Matricula + " " + camion.Marca;

                Session["IdentificadorCamion"] = camion.Matricula;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
                
            }

        }

        protected void grdViajes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grdViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

      
    }
}