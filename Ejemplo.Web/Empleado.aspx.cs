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

        protected void ModoEdicionEmpleado(bool value)
        {
            if (value)
            {
                this.btnAgregarEmpleado.Visible = false;
                this.btnModificarEmpleado.Visible = true;
                this.btnEliminarEmpleado.Visible = true;
                this.grillaEmpleados.Enabled = false;
            }
            else
            {
                this.btnAgregarEmpleado.Visible = true;
                this.btnModificarEmpleado.Visible = false;
                this.btnEliminarEmpleado.Visible = false;
                this.grillaEmpleados.Enabled = true;
                this.txtNombreEmp.Text = string.Empty;
                this.txtApellidoEmp.Text = string.Empty;
                this.txtContraseña.Text = string.Empty;
                this.txtCI.Text = string.Empty;
                this.txtTelefono.Text = string.Empty;
                this.txtTipoEmp.Text = string.Empty;
                this.txtUsuario.Text = string.Empty;
                
            

            }
  }
         

        protected void Page_Load(object sender, EventArgs e)
        {

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
    }

        protected void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
        Common.Clases.Empleado empleado = new Common.Clases.Empleado();
        //empleado.idEmpleado = int.Parse(lblEm.Text);
        //
        //
        if (Dominio.Fachada.Eliminar_Empleado(empleado))
        {
            ///    Edicion(false)
            lbl.Text = "Se ha eliminado el cliente de manera correcta";
            ///
        }
        else
        {
          ///  lbl.Text = "No se ha eliminado el empleado";
        }
}

    protected void btnModificarEmpleado_Click(object sender, EventArgs e)
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





        protected void grillaEmpleados_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
        try
        {
            ////this.lbl.Text = string.Empty;

            TableCell celdaIdEmpleado = grillaEmpleados.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Empleado empleado = new Common.Clases.Empleado();
            empleado.idEmpleado = int.Parse(celdaIdEmpleado.Text);
            empleado = Dominio.Fachada.


            if (empleado != null)
            {
                this.txtApellidoEmp.Text = empleado.Apellido;
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
    
