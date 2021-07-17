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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Common.Clases.Camionero cam = new Common.Clases.Camionero();
            cam.Nombre = this.txtNombre.Text;
            cam.Apellido = this.txtApellido.Text;
            cam.Cedula = this.txtCedula.Text;
            cam.Cargo = this.txtCargo.Text;
            cam.Tipo = this.txtTipo.Text;
            cam.Telefono = this.txtTelefono.Text;
            cam.Usuario = this.txtUsuario.Text;
            cam.Contrasenia = this.txtContrasenia.Text;
            
            cam.Edad= this.txtEdad.Text;
            cam.Estado= this.txtEstado.Text;
            cam.FechaVenLib= this.txtFecVenLib.Text;
            cam.TipoLibreta= this.txtLibreta.Text;
            try
            {
                bool resultado = Dominio.Fachada.Camionero_Agregar(cam);

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
            this.grdCategorias.DataSource = Dominio.Fachada.camionero_TraerTodos();
            this.grdCategorias.DataBind();
        }

        protected void LimpiarCampos() 
        {
            this.txtId.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
        }

        protected void grdCamionero_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultado.Text = string.Empty;

                TableCell celdaId = grdCamionero.Rows[e.RowIndex].Cells[1];
                Common.Clases.Camionero cat = new Common.Clases.Camionero();
                cat.Identificador = int.Parse(celdaId.Text);
                
                bool resultado = Dominio.Fachada.Camionero_Eliminar(cam);

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

        protected void grdCamionero_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaId = grdCamionero.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Camionero cam = new Common.Clases.Camionero();
            cam.Cedula= int.Parse(celdaId.Text);
            cam = Dominio.Fachada.Camionero_TraerEspecifico(cam);
            
           

            if (cam != null)
            {
                this.txtId.Text = cam.Cedula.ToString();
                this.txtNombre.Text = cam.Nombre;
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
            this.txtId.Enabled = false;
            this.txtId.Visible = pVisible;
            this.lblIdentificador.Visible = pVisible;
            this.btnActualizar.Visible = pVisible;
            this.btnCancelar.Visible = pVisible;
            this.btnAgregar.Visible = !pVisible;
            
            if(!pVisible)
            {
                this.txtId.Text = string.Empty;
                this.txtNombre.Text = string.Empty;
                this.grdCamionero.SelectedIndex = -1;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ModoEdicion(false);
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Common.Clases.Camionero cam = new Common.Clases.Camionero();
            cam.Cedula = int.Parse(this.txtId.Text);
            cam.Nombre = this.txtNombre.Text;
            
            try
            {
                bool resultado = Dominio.Fachada.Camionero_Modificar(cam);

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
