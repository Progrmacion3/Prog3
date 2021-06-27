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
            this.ActualizarLista();
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
                this.ActualizarLista();
                lblResultado.Text = "Se ha registrado el admin de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido registrar el admin.";
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Common.Clases.Admin unAdmin = new Common.Clases.Admin();
            unAdmin.Cedula = int.Parse(this.txtCedula.Text);


            bool verdadero = Dominio.Fachada.AdminEliminar(unAdmin);

            if (verdadero)
            {
                lblResultado.Text = "Se ha eliminado el admin de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido eliminar el admin.";
            }
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        protected void grdAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grdAdmin_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaId = grdAdmin.Rows[e.NewSelectedIndex].Cells[1];
            
        }

        protected void ActualizarLista()
        {
            this.grdAdmin.DataSource = Dominio.Fachada.MostrarAdmin();
            this.grdAdmin.DataBind();
        }

        protected void grdAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}