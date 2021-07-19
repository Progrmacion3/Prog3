using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class Camion : System.Web.UI.Page
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrillaCamiones();
        }
      
        protected void ModoEdicionCamion(bool pVisible)
        {
            this.txtIdCamion.Enabled = false;
            this.txtIdCamion.Visible = pVisible;
            this.lblIDCamion.Visible = pVisible;
            this.btnModificarCamion.Visible = pVisible;
            this.btnCancelarCamion.Visible = pVisible;
            this.btnAgregarCamion.Visible = !pVisible;

            if(!pVisible)
            {
                this.txtIdCamion.Text = string.Empty;
                this.txtMarca.Text = string.Empty;
                this.txtMatricula.Text = string.Empty;
                this.txtModelo.Text = string.Empty;
                this.txtAñoCam.Text = string.Empty;
                this.grillaCamiones.SelectedIndex = -1;
            }
        }

        protected void ActualizarGrillaCamiones()
        {
            this.grillaCamiones.DataSource = Dominio.Fachada.Traer_Camiones();
            this.grillaCamiones.DataBind();
        }

        protected void LimpiarCamposCamiones()
        {
            this.txtMatricula.Text = string.Empty;
            this.txtMarca.Text = string.Empty;
            this.txtModelo.Text = string.Empty;
            this.txtAñoCam.Text = string.Empty;
        }

        protected void btnAgregarCamion_Click(object sender, EventArgs e)
        {
            Common.Clases.Camion camion = new Common.Clases.Camion();
            camion.Matricula = this.txtMatricula.Text;
            camion.Modelo = this.txtModelo.Text;
            camion.Marca = this.txtMarca.Text;
            camion.Año = int.Parse(this.txtAñoCam.Text);

            try
            {
                bool resultadoCamion = Dominio.Fachada.Agregar_Camion(camion);

                if (resultadoCamion)
                {
                    lblResultadoCam.Text = "Se ha agregado correctamente un camion";
                    LimpiarCamposCamiones();
                    ActualizarGrillaCamiones();
                }
                else
                {
                    lblResultadoCam.Text = "Error: no se agrego el camion";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnModificarCamion_Click(object sender, EventArgs e)
        {
            Common.Clases.Camion camion = new Common.Clases.Camion();
            camion.idCamion = int.Parse(this.txtIdCamion.Text);
            camion.Matricula = this.txtMatricula.Text;
            camion.Modelo = this.txtModelo.Text;
            camion.Marca = this.txtMarca.Text;
            camion.Año = int.Parse(this.txtAñoCam.Text);

            try
            {
                bool resultadoCamion = Dominio.Fachada.Modificar_Camion(camion);

                if (resultadoCamion)
                {
                    lblResultadoCam.Text = "Se ha modificado correctamente un camion";
                    ActualizarGrillaCamiones();
                    ModoEdicionCamion(false);
                }
                else
                {
                    lblResultadoCam.Text = "Error: no se modifico el camion";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        protected void grillaCamiones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultadoCam.Text = string.Empty;

                TableCell celdaIdcam = grillaCamiones.Rows[e.RowIndex].Cells[1];
                Common.Clases.Camion camion = new Common.Clases.Camion();
                camion.idCamion = int.Parse(celdaIdcam.Text);

                bool resultado = Dominio.Fachada.Eliminar_Camion(camion);

                if (resultado)
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Camion eliminado exitosamente')", true);
                    ActualizarGrillaCamiones();
                    ModoEdicionCamion(false);
                }

                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Error: no se pudo eliminar camion')", true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grillaCamiones_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try {
                this.lblResultadoCam.Text = string.Empty;

                TableCell celdaId = grillaCamiones.Rows[e.NewSelectedIndex].Cells[1];
                Common.Clases.Camion camion = new Common.Clases.Camion();
                camion.idCamion = int.Parse(celdaId.Text);
                camion = Dominio.Fachada.Traer_UnCamion(camion);


            if (camion != null)
                {
                    this.txtIdCamion.Text = camion.idCamion.ToString(); 
                    this.txtMatricula.Text = camion.Matricula;
                    this.txtModelo.Text = camion.Modelo;
                    this.txtMarca.Text = camion.Marca;
                    this.txtAñoCam.Text = camion.Año.ToString();
                    ModoEdicionCamion(true);
                }
                else
                {
                    ModoEdicionCamion(false);
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Error: no se pudo eliminar')", true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
    }

        protected void btnCancelarCamion_Click(object sender, EventArgs e)
        {
            ModoEdicionCamion(false);
        }


    }
}