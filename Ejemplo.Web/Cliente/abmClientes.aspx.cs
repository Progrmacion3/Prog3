using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Cliente
{
    public partial class abmClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Common.Clases.Cliente cliente = new Common.Clases.Cliente();
            cliente.Apellido = this.txtApellido.Text;
            cliente.Direccion = this.txtDireccion.Text;
            cliente.Nombre = this.txtNombre.Text;

            bool result = Dominio.Fachada.Agregar_cliente(cliente);

            if(result)
            {
                lblResultado.Text = "Se ha ingresado el cliente de manera correcta.";
            }
            else
            {
                lblResultado.Text = "NO se ha ingresado el cliente.";
            }
        }
    }
}