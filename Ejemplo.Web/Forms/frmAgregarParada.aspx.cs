using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Forms
{
    public partial class frmAgregarParada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrillaViajes();
            ActualizarGrillaParadas();
            
        }

        
        protected void ActualizarGrillaViajes()
        {
            this.grdViajes.DataSource = Dominio.Fachada.ListarViajes();
            this.grdViajes.DataBind();
        }

        protected void ActualizarGrillaParadas()
        {
            this.grdParadas.DataSource = Dominio.Fachada.ListarParadas();
            this.grdParadas.DataBind();
        }

        protected void LimpiarCampos()
        {
            this.lblIdViaje.Text = string.Empty;
            this.txtComentario.Text = string.Empty;
           
        }

        protected void btnAgregarParada_Click(object sender, EventArgs e)
        {
            Common.Clases.Parada parada = new Common.Clases.Parada();
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(this.lblIdViaje.Text);
            viaje = Dominio.Fachada.TraerViaje(viaje);            
            parada.Tipo= this.ddlTipo.Text;
            parada.Comentario = this.txtComentario.Text;
            parada.Viaje = viaje; 
             
            
                try
                {
                    bool resultado = Dominio.Fachada.AltaParada(parada);
                

                    if (resultado)
                    {
                        this.lblResultado.Text = "Agregado correctamente.";
                        this.LimpiarCampos();
                        this.ActualizarGrillaParadas();

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

        protected void grdViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaId = grdViajes.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(celdaId.Text);
            viaje = Dominio.Fachada.TraerViaje(viaje);

            if (viaje != null)
            {
                this.lblIdViaje.Text = viaje.Id.ToString();
                

                Session["IdentificadorViaje"] = viaje.Id;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);

            }


        }

        protected void grdParadas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.lblResultado.Text = string.Empty;

            TableCell celdaId = grdParadas.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Parada parada = new Common.Clases.Parada();
            parada.Id = short.Parse(celdaId.Text);
            parada = Dominio.Fachada.TraerParada(parada);

            if (parada != null)
            {
                

                foreach (ListItem item in ddlTipo.Items)
                {
                    if (parada.Tipo == item.Text)
                    {
                        item.Selected = true;
                    }
                    else
                    {
                        foreach (ListItem itmes in ddlTipo.Items)
                        {
                            item.Selected = false;
                        }

                    }

                }
                if (parada.Tipo == "Rotura") {
                    this.txtComentario.Visible = true;
                    this.lblComentario.Visible = true;
                }
                else 
                {
                    this.txtComentario.Visible = false;
                    this.lblComentario.Visible = false;
                }
                this.lblIdViaje.Text = parada.Viaje.Id.ToString();
                this.txtComentario.Text = parada.Comentario;

                Session["IdentificadorParada"] = parada.Id;

                
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);

            }

        }
                
        protected void grdParadas_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblResultado.Text = string.Empty;

                TableCell celdaId = grdParadas.Rows[e.RowIndex].Cells[1];
                Common.Clases.Parada parada = new Common.Clases.Parada();
                parada.Id = short.Parse(celdaId.Text);


                bool resultado = Dominio.Fachada.BajaParada(parada);

                if (resultado)
                {
                    this.lblResultado.Text = "Eliminado exitosamente";
                    this.ActualizarGrillaParadas();
                    this.LimpiarCampos();

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

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        protected void ddlTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ddlTipo.SelectedItem.Text == "Rotura")
            {
                this.txtComentario.Visible = true;
                this.lblComentario.Visible = true;


            }
            else
            {
                this.txtComentario.Visible = false;
                this.lblComentario.Visible = false;

            }

        }

        
    }
}