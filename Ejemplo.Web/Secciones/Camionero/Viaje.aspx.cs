using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Camionero
{
    public partial class Viaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Common.Clases.Viaje unViaje = new Common.Clases.Viaje();
            //unViaje.IdViaje = int.Parse(this.txtViaje.Text);
            
            //unViaje.Kilaje = int.Parse(this.txtKilaje.Text);
            
            //unViaje.Estado = this.ddlEstado.SelectedItem.Text;

            //bool verdadero = Dominio.Fachada.ViajeModificar(unViaje);

            //if (verdadero)
            //{
            //    lblResultado.Text = "Se ha modificado el viaje de manera correcta.";
            //}
            //else
            //{
            //    lblResultado.Text = "No se ha podido modificar el viaje.";
            //}
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Common.Clases.Viaje unViaje = new Common.Clases.Viaje();
            unViaje.IdViaje = int.Parse(this.txtIdViaje.Text);
            unViaje.Kilaje = int.Parse(this.txtKilaje.Text);
            unViaje.Estado = this.ddlEstado.SelectedItem.Text;

            bool verdadero = Dominio.Fachada.ViajeModificarCamionero(unViaje);

            if (verdadero)
            {
                lblResultado.Text = "Se ha modificado el viaje de forma correcta";
            }
            else
            {
                lblResultado.Text = "No se ha podido moficiar el viaje";
            }

        }
        protected void Limpiar()
        {
            this.txtIdViaje.Text = string.Empty;
            this.txtKilaje.Text = string.Empty;
            this.ddlEstado.SelectedItem.Text = string.Empty;
        }
        protected void ActualizarLista()
        {
            
        }
        protected void grdViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}