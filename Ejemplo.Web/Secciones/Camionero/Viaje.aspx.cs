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
            Common.Clases.Viaje unViaje = new Common.Clases.Viaje();
            unViaje.IdViaje = int.Parse(this.txtIdViaje.Text);
            
            unViaje.Kilaje = int.Parse(this.txtKilaje.Text);
            
            unViaje.Estado = this.ddlEstado.SelectedItem.Text;

            bool verdadero = Dominio.Fachada.ViajeModificar(unViaje);

            if (verdadero)
            {
                lblResultado.Text = "Se ha modificado el viaje de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido modificar el viaje.";
            }
        }
    }
}