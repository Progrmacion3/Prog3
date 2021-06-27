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
                this.Limpiar();
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
                this.ActualizarLista();
                this.Limpiar();
                lblResultado.Text = "Se ha eliminado el admin de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido eliminar el admin.";
            }
        }
        protected void btnModificar_Click(object sender, EventArgs e)
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

            bool verdadero = Dominio.Fachada.AdminModificar(unAdmin);

            if (verdadero)
            {
                this.ActualizarLista();
                lblResultado.Text = "Se ha modificado el admin de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido modificar el admin.";
            }
            this.Limpiar();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        protected void grdAdmin_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celda = grdAdmin.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Admin admin = new Common.Clases.Admin();
            admin.Cedula = int.Parse(celda.Text);
            admin = Dominio.Fachada.MostrarAdminEspecifico(admin);

            if (admin != null)
            {
                this.txtCedula.Text = Convert.ToString(admin.Cedula);
                this.txtNombre.Text = admin.Nombre;
                this.txtApellido.Text = admin.Apellido;
                this.txtFechaNacimiento.Text = Convert.ToString(admin.FechaNacimiento);
                this.txtCargo.Text = admin.Cargo;
                this.txtTelefono.Text = admin.Telefono;
                this.txtUsuario.Text = admin.Usuario;
                this.txtContraseña.Text = admin.Contraseña;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert ('ERROR: No se pudo cargar la fila.')", true);
            }
        }
        protected void Limpiar()
        {
            this.txtCedula.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtFechaNacimiento.Text = string.Empty;
            this.txtCargo.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;

            this.txtCedula.Focus();
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