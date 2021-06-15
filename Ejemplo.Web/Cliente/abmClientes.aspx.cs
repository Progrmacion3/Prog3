using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            Common.Clases.Cliente cli= new Common.Clases.Cliente();
            cli.Identificador = int.Parse(celdaId.Text);
            cli = Dominio.Fachada.Cliente_TraerEspecifico(cli);



            if (cli != null)
            {
                this.txtNombre.Text = cli.Nombre;
                this.txtApellido.Text = cli.Apellido;
                this.txtDireccion.Text = cli.Direccion;
                this.lblCategoria.Text = cli.Categoria.Nombre;
               
            }
            else
            {
                
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);
            }
        }
        protected void ActualizarGrillaDeCliente()
        {
            this.grillaCliente.DataSource = Dominio.Fachada.Cliente_TraerTodosLosClientes();
            this.grillaCliente.DataBind();
        }
    }
}