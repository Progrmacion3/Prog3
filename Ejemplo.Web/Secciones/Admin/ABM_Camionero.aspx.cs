using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Admin
{
    public partial class ABM_Camionero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Common.Clases.Camionero unCamionero = new Common.Clases.Camionero();
            unCamionero.Cedula = int.Parse(this.txtCedula.Text);
            unCamionero.Nombre = this.txtNombre.Text;
            unCamionero.Apellido = this.txtApellido.Text;
            unCamionero.FechaNacimiento = Convert.ToDateTime(this.txtFechaNacimiento.Text);
            unCamionero.Cargo = this.txtCargo.Text;
            unCamionero.Telefono = this.txtTelefono.Text;
            unCamionero.Usuario = this.txtUsuario.Text;
            unCamionero.Contraseña = this.txtContraseña.Text;
            unCamionero.CategoriaLibreta = this.txtCatLibreta.Text;
            unCamionero.FechaVencimiento = Convert.ToDateTime(this.txtFechaVencimiento.Text);

            bool verdadero = Dominio.Fachada.CamioneroAgregar(unCamionero);

            if (verdadero)
            {
                lblResultado.Text = "Se ha registrado el camionero de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido registrar el camionero.";
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