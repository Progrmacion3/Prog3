using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Admin
{
    public partial class ABM_Camiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Common.Clases.Camion unCamion = new Common.Clases.Camion();
            unCamion.Matricula = this.txtMatricula.Text;
            unCamion.Marca = this.txtMarca.Text;
            unCamion.Modelo = this.txtModelo.Text;
            unCamion.Año = int.Parse(this.txtAño.Text);

            bool verdadero = Dominio.Fachada.CamionAgregar(unCamion);

            if (verdadero)
            {
                this.ActualizarLista();
                lblResultado.Text = "Se ha registrado el camión de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido registrar el camión.";
            }
            this.Limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Common.Clases.Camion unCamion = new Common.Clases.Camion();
            unCamion.Matricula = this.txtMatricula.Text;

            bool verdadero = Dominio.Fachada.CamionEliminar(unCamion);

            if (verdadero)
            {
                this.ActualizarLista();
                lblResultado.Text = "Se ha eliminado el camión de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido eliminar el camión.";
            }
            this.Limpiar();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Common.Clases.Camion unCamion = new Common.Clases.Camion();
            unCamion.Matricula = this.txtMatricula.Text;
            unCamion.Marca = this.txtMarca.Text;
            unCamion.Modelo = this.txtModelo.Text;
            unCamion.Año = int.Parse(this.txtAño.Text);

            bool verdadero = Dominio.Fachada.CamionModificar(unCamion);

            if (verdadero)
            {
                this.ActualizarLista();
                lblResultado.Text = "Se ha modificado el camión de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido modificar el camión.";
            }
            this.Limpiar();
        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        protected void ActualizarLista()
        {
            this.grdCamiones.DataSource = Dominio.Fachada.MostrarCamiones();
            this.grdCamiones.DataBind();
        }
        protected void grdCamiones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void grdCamiones_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celda = grdCamiones.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Camion camion = new Common.Clases.Camion();
            camion.Matricula = celda.Text;
            camion = Dominio.Fachada.MostrarCamionEspecifico(camion);

            if(camion != null)
            {
                this.txtMatricula.Text = camion.Matricula;
                this.txtMarca.Text = camion.Marca;
                this.txtModelo.Text = camion.Modelo;
                this.txtAño.Text = Convert.ToString(camion.Año);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert ('ERROR: No se pudo cargar la fila.')", true);
            }
        }
        protected void Limpiar()
        {
            this.txtMatricula.Text = string.Empty;
            this.txtMarca.Text = string.Empty;
            this.txtModelo.Text = string.Empty;
            this.txtAño.Text = string.Empty;
            this.txtMatricula.Focus();
        }
    }
}