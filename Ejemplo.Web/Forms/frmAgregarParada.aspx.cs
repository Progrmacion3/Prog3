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
            Common.Clases.Camionero emp = new Common.Clases.Camionero();
            emp.CI = int.Parse(Session["CiEmpleadoInicioSesion"].ToString());

            this.grdViajes.DataSource = Dominio.Fachada.ListarViajesPorCamionero(emp);
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
            this.lblResultado.Text = string.Empty;
            this.lblResultado2.Text = string.Empty;
            this.lblResultado3.Text = string.Empty;
        }

        protected void btnAgregarParada_Click(object sender, EventArgs e)
        {
            Common.Clases.Parada parada = new Common.Clases.Parada();
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(this.lblIdViaje.Text);
            viaje = Dominio.Fachada.TraerViaje(viaje);
            viaje.Estado = "Parado";     
            parada.Tipo= this.ddlTipo.Text;
            parada.Comentario = this.txtComentario.Text;
            parada.Viaje = viaje;

            if(parada.Tipo == "Descanso")
            {
                viaje.Comentario = "En descanso...";
            }
            else
            {
                viaje.Comentario = "Esperando confirmación de Rotura...";
            }

            //short paradaAgregada = viaje.agregarParada( parada);
            //if (paradaAgregada == 2)
            //{
            //    this.lblResultad3.Text = "Parada Agregada a Viaje";
            //}
            //if (paradaAgregada == 1)
            //{
            //    this.lblResultad3.Text = "Parada no existe";
            //}

            try
            {
                bool resultado = Dominio.Fachada.AltaParada(parada);
                bool estadoViaje = Dominio.Fachada.ModificarEstadoViaje(viaje);
                bool comentarioviaje = Dominio.Fachada.AgregarComentarioViaje(viaje);

                if (resultado)
                {
                    this.LimpiarCampos();
                    this.lblResultado.Text = "Parada agregada correctamente.";
                    this.ActualizarGrillaParadas();
                    this.btnAgregarParada.Visible = false;

                    if (estadoViaje )
                    {
                        this.lblResultado2.Text = "Estado del viaje cambiado a Parado.";

                        if (comentarioviaje)
                        {
                            this.lblResultado3.Text = "Comentario Agregado.";
                            this.ActualizarGrillaViajes();
                        }
                        else
                        {
                            this.lblResultado3.Text = "ERROR: No se cambio estado viaje.";
                        }
                    }
                    else
                    {
                        this.lblResultado2.Text = "ERROR: No se cambio estado viaje.";
                    }
                }
                else
                {
                    this.lblResultado.Text = "ERROR: No se agrego la parada.";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }        

        protected void grdViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.LimpiarCampos();

            TableCell celdaId = grdViajes.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(celdaId.Text);
            viaje = Dominio.Fachada.TraerViaje(viaje);

            if (viaje != null)
            {
                this.lblIdViaje.Text = viaje.Id.ToString();
                this.btnAgregarParada.Visible = true;
                

                Session["IdentificadorViaje"] = viaje.Id;
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);

            }


        }

        protected void grdParadas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.LimpiarCampos();

            TableCell celdaId = grdParadas.Rows[e.NewSelectedIndex].Cells[1];
            Common.Clases.Parada parada = new Common.Clases.Parada();
            parada.Id = short.Parse(celdaId.Text);
            parada = Dominio.Fachada.TraerParada(parada);

            if (parada != null)
            {
                this.btnAgregarParada.Visible = true;

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
                

                
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "alert", "alert('ERROR: No se pudo cargar el dato.')", true);

            }

        }
                
        protected void grdParadas_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {

            this.LimpiarCampos();

            TableCell celdaId = grdParadas.Rows[e.RowIndex].Cells[1];
            TableCell celdaIdViaje = grdParadas.Rows[e.RowIndex].Cells[4];
            Common.Clases.Parada parada = new Common.Clases.Parada();
            parada.Id = short.Parse(celdaId.Text);

            Common.Clases.Viaje viaje = new Common.Clases.Viaje();
            viaje.Id = short.Parse(celdaIdViaje.Text);
            viaje = Dominio.Fachada.TraerViaje(viaje);

            //short paradaQuitada = viaje.quitarParada(viaje, parada);
            //if (paradaQuitada == 3)
            //{
            //    this.lblResultad3.Text = "Parada quitada a Viaje";
            //}
            //if (paradaQuitada == 2)
            //{
            //    this.lblResultad3.Text = "Parada no existe";
            //}
            //if (paradaQuitada == 1)
            //{
            //    this.lblResultad3.Text = "Viaje no existe";
            //}
            try
            {
                
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
            this.LimpiarCampos();
            this.btnAgregarParada.Visible = false;
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