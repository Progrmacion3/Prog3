using Common;
using Dominio;
using System;
using System.Collections.Generic;

namespace Ejemplo.Web
{
    public partial class FormularioIngresoUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            var usuario = Session["usuario"];
            if (usuario is Administrador)
            {
                lstUsuarios.DataValueField = "Id";
                lstUsuarios.DataTextField = "VerToString";
                AdminOCamionero();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem == null)
                return;

            var id = int.Parse(lstUsuarios.SelectedValue);
            if (rdbAdm.Checked)
            {
                var administrador = new Administrador(id);
                Fachada.Obtener(administrador);
                txtId.Text = administrador.Id.ToString();
                txtNombre.Text = administrador.Nombre;
                txtApellido.Text = administrador.Apellido;
                txtCedula.Text = administrador.Cédula.ToString();
                txtTelefono.Text = administrador.Teléfono;
                txtUsuario.Text = administrador.UsuarioLogin;
                txtContra.Text = administrador.Contraseña;
            }
            else
            {
                var camionero = new Camionero(id);
                Fachada.Obtener(camionero);
                txtId.Text = camionero.Id.ToString();
                txtNombre.Text = camionero.Nombre;
                txtApellido.Text = camionero.Apellido;
                txtCedula.Text = camionero.Cédula.ToString();
                txtTelefono.Text = camionero.Teléfono;
                txtUsuario.Text = camionero.UsuarioLogin;
                txtContra.Text = camionero.Contraseña;
                txtFecNac.Text = camionero.Nacimiento.ToString();
                txtLibTipo.Text = camionero.TipoLibreta;
                txtLibVenc.Text = camionero.VencimientoLibreta.ToString();
            }
        }

        protected void rdbAdm_CheckedChanged(object sender, EventArgs e)
        {
            AdminOCamionero();
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            int cedula;
            if (!int.TryParse(txtCedula.Text, out cedula))
            {
                lblMensajes.Text = "No se pudo ingresar porque la cédula no es un número.";
                return;
            }

            if (rdbAdm.Checked)
            {
                Administrador adm = new Administrador(
                    txtNombre.Text,
                    txtApellido.Text,
                    cedula,
                    txtTelefono.Text,
                    txtUsuario.Text,
                    txtContra.Text
                );
                if (Fachada.Alta(adm))
                {
                    lblMensajes.Text = "Ingreso correcto";
                    txtId.Text = adm.Id.ToString();
                    ListarAdministradores();
                }
                else
                {
                    lblMensajes.Text = "Error de base de datos.";
                }
            }
            else
            {
                DateTime nacimiento;
                if (!DateTime.TryParse(txtFecNac.Text, out nacimiento))
                {
                    lblMensajes.Text = "La fecha de nacimiento no se ingresó correctamente";
                    return;
                }

                DateTime vencLibreta;
                if (!DateTime.TryParse(txtLibVenc.Text, out vencLibreta))
                {
                    lblMensajes.Text = "El vencimiento de la libreta no se ingresó correctamente";
                    return;
                }

                Camionero cam = new Camionero(
                    txtNombre.Text,
                    txtApellido.Text,
                    cedula,
                    txtTelefono.Text,
                    txtUsuario.Text,
                    txtContra.Text,
                    nacimiento,
                    txtLibTipo.Text,
                    vencLibreta
                );
                if (Fachada.Alta(cam))
                {
                    lblMensajes.Text = "Ingreso correcto";
                    txtId.Text = cam.Id.ToString();
                    ListarCamioneros();
                }
                else
                {
                    lblMensajes.Text = "Error de base de datos.";
                }
            }
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                lblMensajes.Text = "Error: No se pudo dar de baja";
                return;
            }

            var usuario = new Usuario(id);
            if (Fachada.Baja(usuario))
            {
                if (rdbAdm.Checked)
                {
                    lblMensajes.Text = "Administrador dado de baja correctamente";
                    ListarAdministradores();
                }
                else
                {
                    lblMensajes.Text = "Camionero dado de baja correctamente";
                    ListarCamioneros();
                }
                Limpiar();
            }
            else
            {
                lblMensajes.Text = "No se pudo dar de baja";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                lblMensajes.Text = "Error: No se pudo modificar.";
                return;
            }

            int cedula;
            if (!int.TryParse(txtCedula.Text, out cedula))
            {
                lblMensajes.Text = "No se pudo modificar porque la cédula no es un número.";
                return;
            }

            if (rdbAdm.Checked)
            {
                Administrador adm = new Administrador(
                    id,
                    txtNombre.Text,
                    txtApellido.Text,
                    cedula,
                    txtTelefono.Text,
                    txtUsuario.Text,
                    txtContra.Text
                );
                if (Fachada.Modificar(adm))
                {
                    lblMensajes.Text = "Modificación correcta";
                    ListarAdministradores();
                }
                else
                {
                    lblMensajes.Text = "Error de base de datos.";
                }
            }
            else
            {
                DateTime nacimiento;
                if (!DateTime.TryParse(txtFecNac.Text, out nacimiento))
                {
                    lblMensajes.Text = "La fecha de nacimiento no se ingresó correctamente";
                    return;
                }

                DateTime vencLibreta;
                if (!DateTime.TryParse(txtLibVenc.Text, out vencLibreta))
                {
                    lblMensajes.Text = "El vencimiento de la libreta no se ingresó correctamente";
                    return;
                }

                Camionero cam = new Camionero(
                    id,
                    txtNombre.Text,
                    txtApellido.Text,
                    cedula,
                    txtTelefono.Text,
                    txtUsuario.Text,
                    txtContra.Text,
                    nacimiento,
                    txtLibTipo.Text,
                    vencLibreta
                );
                if (Fachada.Modificar(cam))
                {
                    lblMensajes.Text = "Se modificó correctamente";
                    ListarCamioneros();
                }
                else
                {
                    lblMensajes.Text = "Error de base de datos.";
                }
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void AdminOCamionero()
        {
            if (rdbAdm.Checked)
            {
                lblFecNac.Visible = false;
                lblLibTipo.Visible = false;
                lblVencLib.Visible = false;
                txtFecNac.Visible = false;
                txtLibTipo.Visible = false;
                txtLibVenc.Visible = false;
                ListarAdministradores();
            }
            else
            {
                lblFecNac.Visible = true;
                lblLibTipo.Visible = true;
                lblVencLib.Visible = true;
                txtFecNac.Visible = true;
                txtLibTipo.Visible = true;
                txtLibVenc.Visible = true;
                ListarCamioneros();
            }
        }

        private void ListarAdministradores()
        {
            var lista = new List<Administrador>();
            if (Fachada.Listar(lista))
            {
                Listar(lista);
                lblMensajes.Text = "";
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }

        private void ListarCamioneros()
        {
            var lista = new List<Camionero>();
            if (Fachada.Listar(lista))
            {
                Listar(lista);
                lblMensajes.Text = "";
            }
            else
            {
                lblMensajes.Text = "Error de base de datos.";
            }
        }

        private void Listar(object lista)
        {
            lstUsuarios.DataSource = null;
            lstUsuarios.DataSource = lista;
            lstUsuarios.DataBind();
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Text = "";
            txtContra.Text = "";
            txtFecNac.Text = "";
            txtLibTipo.Text = "";
            txtLibVenc.Text = "";
            lstUsuarios.ClearSelection();
        }
    }
}
