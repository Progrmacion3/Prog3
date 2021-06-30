using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class Camionero : System.Web.UI.Page
    {
        protected void ModoEdicionCamionero(bool pCamionero)
        {
            this.btnModificarCamionero.Visible = pCamionero;
            this.btnAgregarCamionero.Visible = !pCamionero;

            if (!pCamionero)
            {
                this.
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarCamionero_Click(object sender, EventArgs e)
        {
            Common.Clases.Camionero camionero = new Common.Clases.Camionero();
            camionero.Edad = int.Parse(this.txtEdadCam.Text);
            camionero.Fecha_Vencimiento_Libreta =  DateTime.Parse(this.txtFechaVencimientoLibreta.Text);
            camionero.Tipo_Libreta = this.txtTipoLibreta.Text;

            try
            {
                bool resultadoCamionero = Dominio.Fachada.Agregar_Camionero(camionero);

                if (resultadoCamionero)
                {
                    lblResultadoCamionero.Text = "Se ha agregado correctamente un camionero";
                }
                else
                {
                    lblResultadoCamionero.Text = "Error: no se agrego el camionero";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnModificarCamionero_Click(object sender, EventArgs e)
        {
            Common.Clases.Camionero camionero = new Common.Clases.Camionero();
            camionero.Edad = int.Parse(this.txtEdadCam.Text);
            camionero.Fecha_Vencimiento_Libreta = DateTime.Parse(this.txtFechaVencimientoLibreta.Text);
            camionero.Tipo_Libreta = this.txtTipoLibreta.Text;

            try
            {
                bool resultadoCamionero = Dominio.Fachada.Modificar_Camionero(camionero);

                if (resultadoCamionero)
                {
                    lblResultadoCamionero.Text = "Se ha agregado correctamente un camionero";
                }
                else
                {
                    lblResultadoCamionero.Text = "Error: no se agrego el camionero";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
    }

        protected void grillaCamioneros_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultadoCamionero.Text = string.Empty;

                TableCell celdaIdcamionero = grillaCamioneros.Rows[e.RowIndex].Cells[1];
                Common.Clases.Camionero camionero = new Common.Clases.Camionero();
                camionero.identificadorCam = int.Parse(celdaIdcamionero.Text);

                bool resultado = Dominio.Fachada.Eliminar_Camionero(camionero);

                if (resultado)
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Camionero eliminado exitosamente')", true);

                }

                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Error: no se pudo eliminar camionero')", true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void grillaCamioneros_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                this.lblResultadoCamionero.Text = string.Empty;

                TableCell celdaIdcamionero = grillaCamioneros.Rows[e.NewSelectedIndex].Cells[1];
                Common.Clases.Camionero camionero = new Common.Clases.Camionero();
                camionero.identificadorCam = int.Parse(celdaIdcamionero.Text);
                camionero = Dominio.Fachada.


            if (camionero != null)
                {
                    this.txtEdadCam.Text = camionero.Edad.ToString();
                    this.txtFechaVencimientoLibreta.Text = camionero.Fecha_Vencimiento_Libreta.ToString();
                    this.txtTipoLibreta.Text = camionero.Tipo_Libreta;
                    
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
