using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Forms
{
    public partial class frmCamion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActualizarGrillaDeDatos();
        }

        protected void ActualizarGrillaDeDatos()
        {
            this.grdCamion.DataSource = Dominio.Fachada.ListarCamiones();
            this.grdCamion.DataBind();
        }

        protected void LimpiarCampos()
        {
            this.txtMatricula.Text = string.Empty;
            this.txtMarca.Text = string.Empty;
            this.txtModelo.Text = string.Empty;
            this.txtYear.Text = string.Empty;
        }

        protected void ModoEdicion(bool pVisible)
        {
            this.txtMatricula.Visible = pVisible;
            this.txtMarca.Visible = pVisible;
            this.txtModelo.Visible = pVisible;
            this.txtYear.Visible = pVisible;
            this.btnActualizar.Visible = pVisible;
            this.btnCancelar.Visible = pVisible;
            this.btnAgregar.Visible = !pVisible;

            if (!pVisible)
            {
                this.txtMatricula.Visible = !pVisible;
                this.txtMarca.Visible = !pVisible;
                this.txtModelo.Visible = !pVisible;
                this.txtYear.Visible = !pVisible;
                this.LimpiarCampos();
                this.grdCamion.SelectedIndex = -1;
            }
        }


        protected void btnAltaCamion(object sender, EventArgs e)
        {
            Common.Clases.Camion camion = new Common.Clases.Camion();
            camion.Matricula = this.txtMatricula.Text;
            camion.Marca = this.txtMarca.Text;
            camion.Modelo = this.txtModelo.Text;
            camion.Year = short.Parse(this.txtYear.Text);

            try
            {
                bool resultado = Dominio.Fachada.AltaCamion(camion);

                if (resultado)
                {
                    this.lblResultado.Text = "Agregado correctamente.";
                    this.LimpiarCampos();
                    this.ActualizarGrillaDeDatos();
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

        protected void btnModificarCamion_Click(object sender, EventArgs e)
        {
            Common.Clases.Camion camion = new Common.Clases.Camion();
            camion.Matricula = this.txtMatricula.Text;
            camion.Marca = this.txtMarca.Text;
            camion.Modelo = this.txtModelo.Text;
            camion.Year = short.Parse(this.txtYear.Text);

            try
            {
                bool resultado = Dominio.Fachada.ModificarCamion(camion);

                if (resultado)
                {
                    this.lblResultado.Text = "Modificado correctamente.";
                    this.ActualizarGrillaDeDatos();
                    this.ModoEdicion(false);
                }
                else
                {
                    lblResultado.Text = "ERROR: No se pudo modificar.";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion(false);
        }

        protected void grdCamion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultado.Text = string.Empty;

                TableCell celdaId = grdCamion.Rows[e.RowIndex].Cells[1];
                Common.Clases.Camion camion = new Common.Clases.Camion();
                camion.Matricula = celdaId.Text;

                bool resultado = Dominio.Fachada.BajaCamion(camion);

                if (resultado)
                {
                    this.lblResultado.Text = "Eliminado exitosamente";
                    this.ActualizarGrillaDeDatos();
                    this.ModoEdicion(false);
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo eliminar.')", true);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grdCamion_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaId = grdCamion.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Camion camion = new Common.Clases.Camion();
            camion.Matricula = celdaId.Text;
            camion = Dominio.Fachada.TraerCamion(camion);



            if (camion != null)
            {
                this.txtMatricula.Text = camion.Matricula.ToString();
                this.txtMarca.Text = camion.Marca.ToString();
                this.txtModelo.Text = camion.Modelo.ToString();
                this.txtYear.Text = camion.Year.ToString();
                this.ModoEdicion(true);
            }
            else
            {
                ModoEdicion(false);
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
            }
        }

        
    }
}