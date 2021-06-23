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
            unCamion.Modelo = this.txtMatricula.Text;
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
    }
}