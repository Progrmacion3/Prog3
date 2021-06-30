using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using obligatorio.Dominio;

namespace obligatorio.Presentacion
{
    public partial class Paradas : System.Web.UI.Page
    {
        static int id = -1;
        static int idP = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Dominio.Login login = new Dominio.Login();
            if (login.TipoLogin == "A")
            {
                this.Master.FindControl("btnEmp").Visible = true;
                this.Master.FindControl("btnCamiones").Visible = true;
                this.Master.FindControl("btnViajes").Visible = true;
                this.Master.FindControl("btnParadas").Visible = true;
                this.Master.FindControl("btnConsultas").Visible = true;
            }
            else if (login.TipoLogin == "C")
            {
                this.Master.FindControl("btnViajes").Visible = true;
                this.Master.FindControl("btnParadas").Visible = true;
                this.txtEstado.Enabled = false;
            }
            if (!IsPostBack)
                this.CargarDatos();
        }

        private bool FaltanDatos()
        {
            if (this.txtRazon.Text == "" || this.ddlViaje.SelectedItem == null)
                return true;
            return false;
        }
        private void AvisoFaltanDatos()
        {
            this.lblMissingTrip.Text = "Te faltó esto flaco.";
        }
        private void LimpiarCampos()
        {
            this.lblMissingTrip.Text = "";
            this.lblDataOutput.Text = "";
            this.ddlViaje.SelectedIndex = 0;
            this.txtRazon.Text = "";
            this.txtComentario.Text = "";
            this.txtEstado.Text = "";
        }
        private void IdViajeIncorrecta()
        {
            this.lblMissingTrip.Text = "Te olvidaste de seleccionar el viaje capo.";
        }
        private string CheckComentario()
        {
            if (this.txtComentario.Text != "")
                return this.txtComentario.Text;
            return null;
        }
        private void ResultadoOperacion(string operacion)
        {
            if(operacion == "alta" || operacion == "baja" || operacion == "modificación")
            {
                this.lblDataOutput.Text = $"Todo piolaaaaaaaaaa con la {operacion}";
                return;
            }    
            this.lblDataOutput.Text = $"NADA PIOLA CON LA {operacion}, TODO MAL CON VOS";
        }
        private void CargarDatos()
        {
            if (this.ddlViaje.Text != "")
            {
                id = int.Parse(ddlViaje.Text);
            }
            foreach (Viaje viaje in new Empresa().ListaViajes())
            {
                if (id >= 0)
                {
                    if (viaje.Id == id)
                    {
                        this.grdParadas.DataSource = viaje.ListaParadas();
                        this.grdParadas.DataBind();
                    }
                }
                
            }
            

            List<string> listaIdViajes = new List<string>();
            listaIdViajes.Add("");
            foreach (Viaje viaje in new Empresa().ListaViajes())
            {
                Dominio.Login login = new Dominio.Login();
                if (login.TipoLogin == "C" && viaje.Camionero.Id == login.EmpLogeado.Id)
                {
                    listaIdViajes.Add(viaje.Id.ToString());
                }
                else if (login.TipoLogin == "A")
                {
                    listaIdViajes.Add(viaje.Id.ToString());
                }
                
            }
            this.ddlViaje.DataSource = listaIdViajes;
            this.ddlViaje.DataBind();
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                int mIdViaje;
                Empresa empresa = new Empresa();
                mIdViaje = id;
                string mComentario = this.CheckComentario();
                string mRazon = this.txtRazon.Text;

                Parada laParada = new Parada(mRazon, mComentario, mIdViaje);
                if(empresa.MenuParada("alta", laParada))
                {
                    this.LimpiarCampos();
                    this.CargarDatos();
                    this.ResultadoOperacion("alta");
                    return;
                }
                this.ResultadoOperacion("alta no");
                return;
            }
            this.AvisoFaltanDatos();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                int mIdViaje;
                Empresa empresa = new Empresa();
                mIdViaje = id;
                int idParada = idP;
                string mComentario = this.CheckComentario();
                string mRazon = this.txtRazon.Text;
                string mEstado = this.txtEstado.Text;

                Parada laParada = new Parada(idParada, mRazon, mComentario, mIdViaje, mEstado);
                if(empresa.MenuParada("modificar", laParada))
                {
                    this.CargarDatos();
                    this.LimpiarCampos();
                    this.ResultadoOperacion("modificación");
                    return;
                }
                this.ResultadoOperacion("modificación no");
                return;
            }
            this.AvisoFaltanDatos();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        protected void grdParadas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            this.LimpiarCampos();
            TableCell idParada = this.grdParadas.Rows[e.RowIndex].Cells[2];
            TableCell idViaje = this.grdParadas.Rows[e.RowIndex].Cells[1];

            Viaje viaje = new Empresa().BuscarViaje(new Viaje(int.Parse(idViaje.Text)));
            foreach (Parada parada in viaje.ListaParadas())
            {
                if (parada.Id == int.Parse(idParada.Text))
                {
                    bool output = new Empresa().MenuParada("baja", parada);
                    if (output)
                    {
                        this.ResultadoOperacion("baja");
                        this.CargarDatos();
                        return;
                    }
                        
                }
            }
            this.ResultadoOperacion("baja no");
        }

        protected void grdParadas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.LimpiarCampos();
            TableCell idParada = this.grdParadas.Rows[e.NewSelectedIndex].Cells[2];
            TableCell idViaje = this.grdParadas.Rows[e.NewSelectedIndex].Cells[1];

            Viaje viaje = new Empresa().BuscarViaje(new Viaje(int.Parse(idViaje.Text)));
            foreach(Parada parada in viaje.ListaParadas())
            {
                if(parada.Id == int.Parse(idParada.Text))
                {
                    this.txtComentario.Text = parada.Comentario;
                    this.txtRazon.Text = parada.Razon;
                    this.txtEstado.Text = parada.Estado;
                    id = parada.IdViaje;
                    idP = parada.Id;
                    return;
                }
            }
            this.lblDataOutput.Text = "Algo salió mal.";
        }

        protected void ddlViaje_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.CargarDatos();
        }
    }
}