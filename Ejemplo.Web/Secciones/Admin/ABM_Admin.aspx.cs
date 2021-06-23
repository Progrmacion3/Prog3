using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Admin
{
    public partial class ABM_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Common.Clases.Admin unAdmin = new Common.Clases.Admin();
            unAdmin.Cedula = int.Parse(this.txtCedula.Text);
            unAdmin.Nombre = this.txtNombre.Text;
            unAdmin.Apellido = this.txtApellido.Text;
            unAdmin.FechaNacimiento = Convert.ToDateTime(this.txtFechaNacimiento.Text);
            unAdmin.Cargo = this.txtCargo.Text;
            unAdmin.Telefono = this.txtTelefono.Text;
            unAdmin.Usuario = this.txtUsuario.Text;
            unAdmin.Contraseña = this.txtContraseña.Text;

            bool verdadero = Dominio.Fachada.AdminAgregar(unAdmin);

            if (verdadero)
            {
                lblResultado.Text = "Se ha registrado el admin de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido registrar el admin.";
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