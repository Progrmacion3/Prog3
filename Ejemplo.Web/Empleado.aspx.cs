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

        protected void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnModificarEmpleado_Click(object sender, EventArgs e)
        {

        }

        protected void grillaEmpleados_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    } 
}



<<<<<<< HEAD
}   
=======


       
>>>>>>> bae5745cdac51adbdf04b2326459857e643a6e59
    
