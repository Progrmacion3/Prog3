using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrillaDeDatos();
        }

        protected void btnAgregar_Click_Empleado(object sender, EventArgs e)
        {
            Common.Clases.Empleado emp = new Common.Clases.Empleado();
            emp.Nombre = this.txtNombre.Text;
           emp.Apellido = this.txtApellido.Text;
            emp.Cedula = Convert.ToInt32(this.txtCedula.Text);
            emp.Cargo = this.txtCargo.Text;
            emp.Tipo = this.txtTipo.Text;
            emp.Telefono = this.txtTelefono.Text;
            emp.Usuario = this.txtUsuario.Text;
            emp.Contrasenia = this.txtContrasenia.Text;
            emp.Estado= this.txtEstado.Text;
            
            ////emp.Edad= this.txtEdad.Text;
            //emp.FechaVenLib= this.txtFecVenLib.Text;
            //emp.TipoLibreta= this.txtLibreta.Text;
            try
            {
                bool resultado = Dominio.Fachada.Agregar_Empleado(emp);

                if (resultado)
                {
                    lblResultado.Text = "Agregado correctamente.";
                    LimpiarCampos();
                    ActualizarGrillaDeDatos();
                }
                else 
                {
                    lblResultado.Text = "ERROR: No se pudo agregar.";
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void ActualizarGrillaDeDatos() 
        {
            this.grdEmpleado.DataSource = Dominio.Fachada.Empleados_TraerTodos();
            this.grdEmpleado.DataBind();
        }

        protected void LimpiarCampos() 
        {
            this.txtCedula.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
        }

        protected void btnEliminar_Click_Empleado(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultado.Text = string.Empty;

                TableCell celdaId = grdEmpleado.Rows[e.RowIndex].Cells[1];
                Common.Clases.Empleado emp = new Common.Clases.Empleado();
                emp.Cedula = int.Parse(celdaId.Text);
                
                bool resultado = Dominio.Fachada.EliminarEmpleado(emp);

                if (resultado)
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('Eliminado exitosamente.')", true);
                    ActualizarGrillaDeDatos();
                    ModoEdicion(false);
                }
                else 
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo eliminar.')", true);
                }
    
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void grdEmpleado_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaId = grdEmpleado.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Empleado emp = new Common.Clases.Empleado();
            emp.Cedula= int.Parse(celdaId.Text);
            emp = Dominio.Fachada.Empleados_TraerEspecifico(emp);
            
           

            if (emp != null)
            {
                this.txtCedula.Text = emp.Cedula.ToString();
                this.txtNombre.Text = emp.Nombre;
                ModoEdicion(true);
            }
            else
            {
                ModoEdicion(false);
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
            }
        }


        protected void ModoEdicion(bool pVisible) 
        {
            this.txtCedula.Enabled = false;
            this.txtCedula.Visible = pVisible;
            //this.txtCedula.Visible = pVisible;
            this.btnModificar.Visible = pVisible;
            this.btnCancelar.Visible = pVisible;
            this.btnAgregar.Visible = !pVisible;
            
            if(!pVisible)
            {
                this.txtCedula.Text = string.Empty;
                this.txtNombre.Text = string.Empty;
                this.grdEmpleado.SelectedIndex = -1;
            }
        }

        protected void btnCancelar_Click_Empleado(object sender, EventArgs e)
        {
            ModoEdicion(false);
        }

        protected void btnModificar_Click_Empleado(object sender, EventArgs e)
        {
            Common.Clases.Empleado emp = new Common.Clases.Empleado();
            emp.Cedula = int.Parse(this.txtCedula.Text);
            //emp.Nombre = this.txtNombre.Text;
            
            try
            {
                bool resultado = Dominio.Fachada.ModificarEmpleado(emp);

                if (resultado)
                {
                    lblResultado.Text = "Modificado correctamente.";
                    ActualizarGrillaDeDatos();
                    ModoEdicion(false);
                }
                else
                {
                    lblResultado.Text = "ERROR: No se pudo modificar.";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     
    }
}
