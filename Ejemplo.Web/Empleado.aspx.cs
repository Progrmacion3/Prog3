using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class Empleado : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrillaEmpleados();
        }

        protected void ModoEdicionEmpleado(bool pVisible)
        {
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Visible = pVisible;
            this.lblIDempleado.Visible = pVisible;
            this.btnModificarEmpleado.Visible = pVisible;
            this.btnEliminarEmpleado.Visible = pVisible;
            this.btnAgregarEmpleado.Visible = !pVisible;

            if (!pVisible)
            {
                this.txtIdEmpleado.Text = string.Empty;
                this.txtCI.Text = string.Empty;
                this.txtNombreEmp.Text = string.Empty;
                this.txtApellidoEmp.Text = string.Empty;
                this.txtTelefono.Text = string.Empty;
                this.txtTipoEmp.Text = string.Empty;
                this.txtCargo.Text = string.Empty;
                this.txtUsuario.Text = string.Empty;
                this.txtContraseña.Text = string.Empty;
                this.grillaEmpleados.SelectedIndex = -1;
            }
        }


        protected void ActualizarGrillaEmpleados()
        {
            this.grillaEmpleados.DataSource = Dominio.Fachada.Traer_Empleados();
            this.grillaEmpleados.DataBind();
        }

        protected void LimpiarCamposEmpleados()
        {
            this.txtApellidoEmp.Text = string.Empty;
            this.txtCargo.Text = string.Empty;
            this.txtCI.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;
            this.txtNombreEmp.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtTipoEmp.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
        }

        protected void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Common.Clases.Empleado empleado = new Common.Clases.Empleado();
            empleado.Apellido = this.txtApellidoEmp.Text;
            empleado.CI = int.Parse(this.txtCI.Text);
            empleado.Contraseña = this.txtContraseña.Text;
            empleado.Nombre = this.txtNombreEmp.Text;
            empleado.Telefono = int.Parse(this.txtTelefono.Text);
            empleado.Tipo = this.txtTipoEmp.Text;
            empleado.Usuario = this.txtUsuario.Text;
       

            try
            {
                bool resultadoEmpleado = Dominio.Fachada.Agregar_Empleado(empleado);

                if (resultadoEmpleado)
                {
                    lblResultadoEmpleado.Text = "Se ha agregado correctamente un empleado";
                }
                else
                {
                    lblResultadoEmpleado.Text = "Error: no se agrego el empleado";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            Common.Clases.Empleado empleado = new Common.Clases.Empleado();
            empleado.idEmpleado = int.Parse(lblIdEmp.Text);
            int estado = (int)Common.Clases.Constantes.Estado.Eliminado;
            empleado.Estado = estado;
            if (Dominio.Fachada.Eliminar_Empleado(empleado))
            {
                lblResultadoEmpleado.Text = "Se ha eliminado empleado de manera correcta";
                ActualizarGrillaEmpleados();
            }
            else
            {
                lblResultadoEmpleado.Text = "No se ha eliminado el empleado";
            }
}

        protected void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            Common.Clases.Empleado empleado = new Common.Clases.Empleado();
            empleado.Apellido = this.txtApellidoEmp.Text;
            empleado.Cargo = this.txtCargo.Text;
            empleado.Contraseña = this.txtContraseña.Text;
            empleado.CI = int.Parse(this.txtCI.Text);
            empleado.Nombre = this.txtNombreEmp.Text;
            empleado.Telefono = int.Parse(this.txtTelefono.Text);
            empleado.Tipo = this.txtTipoEmp.Text;
            empleado.Usuario = this.txtUsuario.Text;

            try
            {
                bool resultadoEmpleado = Dominio.Fachada.Modificar_Empleado(empleado);

                if (resultadoEmpleado)
                {
                    lblResultadoEmpleado.Text = "Se ha agregado correctamente un empleado";
                }
                else
                {
                    lblResultadoEmpleado.Text = "Error: no se agrego el empleado";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void grillaEmpleados_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                this.lblResultadoEmpleado.Text = string.Empty;

                TableCell celdaId = grillaEmpleados.Rows[e.NewSelectedIndex].Cells[1];
                Common.Clases.Empleado empleado = new Common.Clases.Empleado();
                empleado.idEmpleado = int.Parse(celdaId.Text);
                empleado = Dominio.Fachada.Traer_UnEmpleado(empleado);


            if (empleado != null)
                {
                    this.txtApellidoEmp.Text = empleado.Apellido;
                    this.txtCargo.Text = empleado.Cargo;
                    this.txtCI.Text = empleado.CI.ToString();
                    this.txtContraseña.Text = empleado.Contraseña;
                    this.txtNombreEmp.Text = empleado.Nombre;
                    this.txtTelefono.Text = empleado.Telefono.ToString();
                    this.txtTipoEmp.Text = empleado.Tipo;
                    this.txtUsuario.Text = empleado.Usuario;
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Error: no se pudo eliminar')", true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
    
}




    
