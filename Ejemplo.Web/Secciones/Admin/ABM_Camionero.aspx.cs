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
            this.ActualizarLista();
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
                this.ActualizarLista();
                this.Limpiar();
                lblResultado.Text = "Se ha registrado el camionero de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido registrar el camionero.";
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Common.Clases.Camionero unCamionero = new Common.Clases.Camionero();
            unCamionero.Cedula = int.Parse(this.txtCedula.Text);


            bool verdadero = Dominio.Fachada.CamioneroEliminar(unCamionero);

            if (verdadero)
            {
                this.ActualizarLista();
                this.Limpiar();
                lblResultado.Text = "Se ha eliminado el camionero de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido eliminar el camionero.";
            }
        }
        protected void btnModificar_Click(object sender, EventArgs e)
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

            bool verdadero = Dominio.Fachada.CamioneroModificar(unCamionero);

            if (verdadero)
            {
                this.ActualizarLista();
                this.Limpiar();
                lblResultado.Text = "Se ha modificado el camionero de manera correcta.";
            }
            else
            {
                lblResultado.Text = "No se ha podido modificar el camionero.";
            }
        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
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
            this.txtCatLibreta.Text = string.Empty;
            this.txtFechaVencimiento.Text = string.Empty;

            this.txtCedula.Focus();
        }
        protected void ActualizarLista()
        {
            this.grdCamioneros.DataSource = Dominio.Fachada.MostrarCamionero();
            this.grdCamioneros.DataBind();
        }
        protected void grdCamioneros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void grdCamioneros_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celda = grdCamioneros.Rows[e.NewSelectedIndex].Cells[4];
            Common.Clases.Camionero camionero = new Common.Clases.Camionero();
            camionero.Cedula = int.Parse(celda.Text);
            camionero = Dominio.Fachada.MostrarCamioneroEspecifico(camionero);

            if (camionero != null)
            {
                this.txtCedula.Text = Convert.ToString(camionero.Cedula);
                this.txtNombre.Text = camionero.Nombre;
                this.txtApellido.Text = camionero.Apellido;
                this.txtFechaNacimiento.Text = Convert.ToString(camionero.FechaNacimiento);
                this.txtCargo.Text = camionero.Cargo;
                this.txtTelefono.Text = camionero.Telefono;
                this.txtUsuario.Text = camionero.Usuario;
                this.txtContraseña.Text = camionero.Contraseña;
                this.txtCatLibreta.Text = camionero.CategoriaLibreta;
                this.txtFechaVencimiento.Text = Convert.ToString(camionero.FechaVencimiento);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert ('ERROR: No se pudo cargar la fila.')", true);
            }
        }

        protected void grdCamioneros_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
        }
    }
}