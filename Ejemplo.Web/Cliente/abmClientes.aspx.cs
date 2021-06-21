using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common.Clases;
using Common.Utilidades;

namespace Ejemplo.Web.Cliente
{
    public partial class abmClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrillaDeCategoria();
            ActualizarGrillaDeCliente();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Common.Clases.Cliente cliente = new Common.Clases.Cliente();
            cliente.Apellido = this.txtApellido.Text;
            cliente.Direccion = this.txtDireccion.Text;
            cliente.Nombre = this.txtNombre.Text;

            if (validarCampoCategoria())
            {
                int idCat = 0;
                int.TryParse(Session["IdentificadorCategoria"].ToString(), out idCat);
                cliente.Categoria = new Common.Clases.Categoria() { Identificador = idCat };

                if (Dominio.Fachada.Agregar_cliente(cliente))
                {
                    lblResultado.Text = "Se ha ingresado el cliente de manera correcta.";
                    ActualizarGrillaDeCliente();
                }
                else
                {
                    lblResultado.Text = "NO se ha ingresado el cliente.";
                }
            }
            else
            {
                lblResultado.Text = "NO se ha seleccionado una categoria.";
            }

        }

        protected void grdCategorias_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaId = grdCategorias.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Categoria cat = new Common.Clases.Categoria();
            cat.Identificador = int.Parse(celdaId.Text);
            cat = Dominio.Fachada.Cateogoria_TraerEspecifica(cat);

            if (cat != null)
            {
                limpiarCampos();
                this.lblCategoria.Text = cat.Nombre;
                Session["IdentificadorCategoria"] = cat.Identificador;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
                limpiarCampos();
            }

        }

        protected void ActualizarGrillaDeCategoria()
        {
            this.grdCategorias.DataSource = Dominio.Fachada.Cateogoria_TraerTodas();
            this.grdCategorias.DataBind();
        }

        protected void limpiarCampos()
        {
            this.lblCategoria.Text = string.Empty;
            Session["IdentificadorCategoria"] = 0;
        }

        protected bool validarCampoCategoria()
        {
            bool result = true;
            if (Session["IdentificadorCategoria"] == null)
            {
                result = false;
            }

            if (Session["IdentificadorCategoria"] != null && int.Parse(Session["IdentificadorCategoria"].ToString()) == 0)
            {
                result = false;
            }
            return result;
        }

        protected void grillaCliente_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;


            TableCell celdaId = grillaCliente.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Cliente cli = new Common.Clases.Cliente();
            cli.Identificador = int.Parse(celdaId.Text);
            this.lblId.Text = celdaId.Text;
            cli = Dominio.Fachada.Cliente_TraerEspecifico(cli);

            if (cli != null)
            {
                this.txtNombre.Text = cli.Nombre;
                this.txtApellido.Text = cli.Apellido;
                this.txtDireccion.Text = cli.Direccion;
                this.lblCategoria.Text = cli.Categoria.Nombre;
                Edicion(true);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
                Edicion(false);
            }
        }
        protected void ActualizarGrillaDeCliente()
        {
            this.grillaCliente.DataSource = Dominio.Fachada.Cliente_TraerTodosLosClientes();
            this.grillaCliente.DataBind();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Common.Clases.Cliente cliente = new Common.Clases.Cliente();
            cliente.Apellido = this.txtApellido.Text;
            cliente.Direccion = this.txtDireccion.Text;
            cliente.Nombre = this.txtNombre.Text;
            cliente.Identificador = int.Parse(this.lblId.Text);

            if (Dominio.Fachada.ModificarCliente(cliente))
            {
                lblResultado.Text = "Se ha Modificado el cliente de manera correcta.";
                ActualizarGrillaDeCliente();
            }
            else
            {
                lblResultado.Text = "NO se ha Modificado el cliente.";
            }


        }
        protected void Edicion(bool value)
        {
            if (value)
            {
                this.btnAgregar.Visible = false;
                this.btnModificar.Visible = true;
                this.btnEliminar.Visible = true;
                this.btnCancelar.Visible = true;
                this.grdCategorias.Enabled = false;
            }
            else
            {
                this.btnAgregar.Visible = true;
                this.btnModificar.Visible = false;
                this.btnEliminar.Visible = false;
                this.btnCancelar.Visible = false;
                this.grdCategorias.Enabled = true;
                this.txtNombre.Text = string.Empty;
                this.txtApellido.Text = string.Empty;
                this.txtDireccion.Text = string.Empty;
                this.lblCategoria.Text = string.Empty;


            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Common.Clases.Cliente cliente = new Common.Clases.Cliente();
            cliente.Identificador = int.Parse(lblId.Text);
            int estado = (int)Constantes.EstadoCliente.Eliminado;
            cliente.Estado = estado;
            if (Dominio.Fachada.EliminarCliente(cliente))
            {
                Edicion(false);
                lblResultado.Text = "Se ha eliminado el cliente de manera correcta.";
                ActualizarGrillaDeCliente();
            }
            else
            {
                lblResultado.Text = "NO se ha eliminado el cliente.";
            }


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Edicion(false);
        }
    }
}