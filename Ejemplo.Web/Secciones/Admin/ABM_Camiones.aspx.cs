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
                lblResultado.Text = "Se ha registrado el camión de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido registrar el camión.";
            }
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Common.Clases.Camion unCamion = new Common.Clases.Camion();
            unCamion.Matricula = this.txtMatricula.Text;

            bool verdadero = Dominio.Fachada.CamionEliminar(unCamion);

            if (verdadero)
            {
                lblResultado.Text = "Se ha eliminado el camión de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido eliminar el camión.";
            }
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
                lblResultado.Text = "Se ha modificado el camión de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido modificar el camión.";
            }
        }
    }
}