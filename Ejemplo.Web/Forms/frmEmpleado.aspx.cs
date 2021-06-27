using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common.Clases;
using Common.Utilidades;

namespace Ejemplo.Web.Forms
{
    public partial class frmEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActualizarGrillaDeDatos();
        }

        protected void ActualizarGrillaDeDatos()
        {
           
            this.grdAdministradores.DataSource = Dominio.Fachada.ListarAdministradores();
            this.grdAdministradores.DataBind();
            this.grdCamioneros.DataSource = Dominio.Fachada.ListarCamioneros();
            this.grdCamioneros.DataBind();
        }

        protected void rdbCamionero_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCamionero.Checked)
            {
                txtEdad.Visible = true;
                txtTipoLibreta.Visible = true;
                txtVencimientoLibreta.Visible = true;
                lblEdad.Visible = true;
                lblTipoLibreta.Visible = true;
                lblVencimientoLibreta.Visible = true;
                
            }
            else {
                txtEdad.Visible = false;
                txtTipoLibreta.Visible = false;
                txtVencimientoLibreta.Visible = false;
                lblEdad.Visible = false;
                lblTipoLibreta.Visible = false;
                lblVencimientoLibreta.Visible = false;

            }

        }

        protected void rdbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAdministrador.Checked)
            {
                txtEdad.Visible = false;
                txtTipoLibreta.Visible = false;
                txtVencimientoLibreta.Visible = false;
                lblEdad.Visible = false;
                lblTipoLibreta.Visible = false;
                lblVencimientoLibreta.Visible = false;
            }
            else
            {
                txtEdad.Visible = true;
                txtTipoLibreta.Visible = true;
                txtVencimientoLibreta.Visible = true;
                lblEdad.Visible = true;
                lblTipoLibreta.Visible = true;
                lblVencimientoLibreta.Visible = true;

            }
        }

        protected void LimpiarCampos()
        {
            this.txtCedula.Text = string.Empty;
            this.txtNombre.Text= string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtCargo.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtEdad.Text = string.Empty;
            this.txtTipoLibreta.Text = string.Empty;
            this.txtVencimientoLibreta.Text = string.Empty;
        }

        protected void ModoEdicion(bool pVisible)
        {
            if (pVisible == true) {

                this.txtCedula.Visible = true;
                this.txtNombre.Visible = true;
                this.txtApellido.Visible = true;
                this.txtCargo.Visible = true;
                this.txtTelefono.Visible = true;
                this.txtUsuario.Visible = true;
                this.txtPassword.Visible = true;
                this.txtEdad.Text = string.Empty;
                this.txtTipoLibreta.Text = string.Empty;
                this.txtVencimientoLibreta.Text = string.Empty;
                this.txtEdad.Visible = false;
                this.txtTipoLibreta.Visible = false;
                this.txtVencimientoLibreta.Visible = false;
                this.lblEdad.Visible = false;
                this.lblTipoLibreta.Visible = false;
                this.lblVencimientoLibreta.Visible = false;
                this.btnAltaEmpleado.Visible = true;
                this.rdbCamionero.Checked = false;
                this.rdbAdministrador.Checked = true;
                this.btnActualizarEmpleado.Visible = true;
                this.btnCancelar.Visible = true;
                this.btnAltaEmpleado.Visible = false;
            }
            
            else 
            {
                             
                this.btnAltaEmpleado.Visible = true;
                this.btnActualizarEmpleado.Visible = false;
                this.btnCancelar.Visible = false;
                this.LimpiarCampos();
                this.grdAdministradores.SelectedIndex = -1;
            }
        }

        protected void ModoEdicionCamionero(bool pVisible)
        {
            if (pVisible == true)
            {
                this.txtCedula.Visible = true;
                this.txtNombre.Visible = true;
                this.txtApellido.Visible = true;
                this.txtCargo.Visible = true;
                this.txtTelefono.Visible = true;
                this.txtUsuario.Visible = true;
                this.txtPassword.Visible = true;
                this.btnActualizarEmpleado.Visible = true;
                this.btnCancelar.Visible = true;
                this.btnAltaEmpleado.Visible = false;
            }
            else
            {
                this.LimpiarCampos();
                this.txtEdad.Visible = false;
                this.txtTipoLibreta.Visible = false;
                this.txtVencimientoLibreta.Visible = false;
                this.lblEdad.Visible = false;
                this.lblTipoLibreta.Visible = false;
                this.lblVencimientoLibreta.Visible = false;
                this.btnAltaEmpleado.Visible = true;
                this.rdbCamionero.Checked = false;
                this.rdbAdministrador.Checked = true;
                this.btnActualizarEmpleado.Visible = false;
                this.btnCancelar.Visible = false;                
                this.grdCamioneros.SelectedIndex = -1;
            }
        }

        protected void btnAltaEmpleado_Click(object sender, EventArgs e)
        {

            if (rdbAdministrador.Checked)
            {
                Common.Clases.Administrador administrador = new Common.Clases.Administrador();
                administrador.CI = int.Parse(this.txtCedula.Text);
                administrador.Nombre = this.txtNombre.Text;
                administrador.Apellido = this.txtApellido.Text;
                administrador.Cargo = this.txtCargo.Text;
                administrador.Telefono = this.txtTelefono.Text;
                administrador.Tipo = "Administrador";
                administrador.Usuario = this.txtUsuario.Text;
                administrador.Password = this.txtPassword.Text;


                try
                {
                    bool resultado = Dominio.Fachada.AltaAdministrador(administrador);

                    if (resultado)
                    {
                        this.lblResultado.Text = "Agregado correctamente.";
                        this.LimpiarCampos();
                        this.RequiredFieldValidator2.Visible = false;
                        this.RequiredFieldValidator3.Visible = false;
                        this.RequiredFieldValidator4.Visible = false;
                        this.ActualizarGrillaDeDatos();
                    }
                    else
                    {
                        this.lblResultado.Text = "ERROR: No se pudo agregar.";
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else {
                Common.Clases.Camionero camionero = new Common.Clases.Camionero();
                camionero.CI = int.Parse(this.txtCedula.Text);
                camionero.Nombre = this.txtNombre.Text;
                camionero.Apellido = this.txtApellido.Text;
                camionero.Cargo = this.txtCargo.Text;
                camionero.Telefono = this.txtTelefono.Text;
                camionero.Tipo = "Camionero";
                camionero.Usuario = this.txtUsuario.Text;
                camionero.Password = this.txtPassword.Text;
                camionero.Edad = short.Parse(this.txtEdad.Text);
                camionero.Tipo_Libreta = this.txtTipoLibreta.Text;
                camionero.FechaVencimientoLibreta = this.txtVencimientoLibreta.Text;

                try
                {
                    bool resultado = Dominio.Fachada.AltaCamionero(camionero);

                    if (resultado)
                    {
                        this.lblResultado.Text = "Agregado correctamente.";
                        this.LimpiarCampos();
                       this.ActualizarGrillaDeDatos();
                    }
                    else
                    {
                        this.lblResultado.Text = "ERROR: No se pudo agregar.";
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }



            }
        }

        protected void grdAdministradores_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultado.Text = string.Empty;

                TableCell celdaId = grdAdministradores.Rows[e.RowIndex].Cells[1];
                Common.Clases.Administrador administrador = new Common.Clases.Administrador();
                administrador.CI = int.Parse(celdaId.Text);
                int estado = (int)constantesEstado.Estado.Eliminado;
                administrador.Estado = estado;

                bool resultado = Dominio.Fachada.BajaAdministrador(administrador);

                if (resultado)
                {
                    this.lblResultado.Text = "Eliminado exitosamente";
                    this.ActualizarGrillaDeDatos();
                    this.ModoEdicion(false);
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo eliminar.')", true);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void grdAdministradores_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaId = grdAdministradores.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Administrador administrador = new Common.Clases.Administrador();
            administrador.CI = int.Parse(celdaId.Text);
            administrador = Dominio.Fachada.TraerAdministrador(administrador);



            if (administrador != null)
            {
                this.txtCedula.Text = administrador.CI.ToString();
                this.txtNombre.Text = administrador.Nombre.ToString();
                this.txtApellido.Text = administrador.Apellido.ToString();
                this.txtCargo.Text = administrador.Cargo.ToString();
                this.txtTelefono.Text = administrador.Telefono.ToString();
                this.txtUsuario.Text = administrador.Usuario.ToString();
                this.txtPassword.Text = administrador.Password.ToString();
                this.rdbAdministrador.Checked = true;
                this.RequiredFieldValidator2.Visible = false;
                this.RequiredFieldValidator3.Visible = false;
                this.RequiredFieldValidator4.Visible = false;


                this.ModoEdicion(true);
            }
            else
            {
                ModoEdicion(false);
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
            }
        }

        protected void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            if (rdbAdministrador.Checked)
            {
                Common.Clases.Administrador administrador = new Common.Clases.Administrador();
                administrador.CI = int.Parse(this.txtCedula.Text);
                administrador.Nombre = this.txtNombre.Text;
                administrador.Apellido = this.txtApellido.Text;
                administrador.Cargo = this.txtCargo.Text;
                administrador.Telefono = this.txtTelefono.Text;
                administrador.Tipo = "Administrador";
                administrador.Usuario = this.txtUsuario.Text;
                administrador.Password = this.txtPassword.Text;


                try
                {
                    bool resultado = Dominio.Fachada.ModificarAdministrador(administrador);

                    if (resultado)
                    {
                        this.lblResultado.Text = "Modificado correctamente.";
                        this.LimpiarCampos();
                        this.RequiredFieldValidator2.Visible = false;
                        this.RequiredFieldValidator3.Visible = false;
                        this.RequiredFieldValidator4.Visible = false;
                        this.ActualizarGrillaDeDatos();
                        this.ModoEdicion(false);

                    }
                    else
                    {
                        this.lblResultado.Text = "ERROR: No se pudo Modificar.";
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
            {
                Common.Clases.Camionero camionero = new Common.Clases.Camionero();
                camionero.CI = int.Parse(this.txtCedula.Text);
                camionero.Nombre = this.txtNombre.Text;
                camionero.Apellido = this.txtApellido.Text;
                camionero.Cargo = this.txtCargo.Text;
                camionero.Telefono = this.txtTelefono.Text;
                camionero.Tipo = "Camionero";
                camionero.Usuario = this.txtUsuario.Text;
                camionero.Password = this.txtPassword.Text;
                camionero.Edad = short.Parse(this.txtEdad.Text);
                camionero.Tipo_Libreta = this.txtTipoLibreta.Text;
                camionero.FechaVencimientoLibreta = this.txtVencimientoLibreta.Text;

                try
                {
                    bool resultado = Dominio.Fachada.ModificarCamionero(camionero);

                    if (resultado)
                    {
                        this.lblResultado.Text = "Modificado correctamente.";
                        this.LimpiarCampos();
                        this.ActualizarGrillaDeDatos();
                        this.ModoEdicionCamionero(false);
                    }
                    else
                    {
                        this.lblResultado.Text = "ERROR: No se pudo Modificar.";
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ModoEdicionCamionero(false);
          
        }

        protected void grdCamioneros_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultado.Text = string.Empty;

                TableCell celdaId = grdCamioneros.Rows[e.RowIndex].Cells[4];
                Common.Clases.Camionero camionero = new Common.Clases.Camionero();
                camionero.CI = int.Parse(celdaId.Text);
                int estado = (int)constantesEstado.Estado.Eliminado;
                camionero.Estado = estado;

                bool resultado = Dominio.Fachada.BajaCamionero(camionero);

                if (resultado)
                {
                    this.lblResultado.Text = "Eliminado exitosamente";
                    this.ActualizarGrillaDeDatos();
                    this.ModoEdicionCamionero(false);
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo eliminar.')", true);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grdCamioneros_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaId = grdCamioneros.Rows[e.NewSelectedIndex].Cells[4];
            Common.Clases.Camionero camionero = new Common.Clases.Camionero();
            camionero.CI = int.Parse(celdaId.Text);
            camionero = Dominio.Fachada.TraerCamionero(camionero);



            if (camionero != null)
            {
                this.txtCedula.Text = camionero.CI.ToString();
                this.txtNombre.Text = camionero.Nombre.ToString();
                this.txtApellido.Text = camionero.Apellido.ToString();
                this.txtCargo.Text = camionero.Cargo.ToString();
                this.txtTelefono.Text = camionero.Telefono.ToString();
                this.txtUsuario.Text = camionero.Usuario.ToString();
                this.txtPassword.Text = camionero.Password.ToString();
                this.txtEdad.Text = camionero.Edad.ToString();
                this.txtTipoLibreta.Text = camionero.Tipo_Libreta.ToString();
                this.txtVencimientoLibreta.Text = camionero.FechaVencimientoLibreta.ToString();
                this.rdbCamionero.Checked = true;
                this.txtEdad.Visible = true;
                this.txtTipoLibreta.Visible = true;
                this.txtVencimientoLibreta.Visible = true;                
                this.lblEdad.Visible = true;
                this.lblTipoLibreta.Visible = true;
                this.lblVencimientoLibreta.Visible = true;


                this.ModoEdicionCamionero(true);
            }
            else
            {
                ModoEdicionCamionero(false);
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
            }
        }

        
    }
}