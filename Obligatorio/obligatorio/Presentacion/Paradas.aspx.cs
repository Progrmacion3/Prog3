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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                this.CargarDatos();
        }

        private bool FaltanDatos()
        {
            if (this.txtRazon.Text == "" || this.txtViaje.Text == "")
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
            this.txtViaje.Text = "";
            this.txtRazon.Text = "";
            this.txtComentario.Text = "";
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
                this.lblDataOutput.Text = $"Todo piolaaaaaaaaaa con la {operacion}";
            this.lblDataOutput.Text = $"NADA PIOLA CON LA {operacion}, TODO MAL CON VOS";
        }
        private void CargarDatos()
        {
            this.grdParadas.DataSource = new Empresa().ListaParadas();
            this.grdParadas.DataBind();
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                int mIdViaje;
                if(int.TryParse(this.txtViaje.Text, out mIdViaje))
                {
                    this.IdViajeIncorrecta();
                    return;
                }
                Empresa empresa = new Empresa();
                mIdViaje = int.Parse(this.txtViaje.Text);
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
                if(int.TryParse(this.txtViaje.Text, out mIdViaje))
                {
                    this.IdViajeIncorrecta();
                    return;
                }
                Empresa empresa = new Empresa();
                mIdViaje = int.Parse(this.txtViaje.Text);
                string mComentario = this.CheckComentario();
                string mRazon = this.txtRazon.Text;

                Parada laParada = new Parada(mRazon, mComentario, mIdViaje);
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
            TableCell idCelda = this.grdParadas.Rows[e.RowIndex].Cells[1];
            Parada laParada = new Empresa().BuscarParada(new Parada(int.Parse(idCelda.Text)));
            bool output = new Empresa().MenuParada("baja", laParada);
            if (output)
            {
                this.CargarDatos();
                this.ResultadoOperacion("baja");
                return;
            }
            this.ResultadoOperacion("baja no");
        }

        protected void grdParadas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.LimpiarCampos();
            TableCell idCelda = this.grdParadas.Rows[e.NewSelectedIndex].Cells[1];
            Parada laParada = new Empresa().BuscarParada(new Parada(int.Parse(idCelda.Text));
            if(laParada != null)
            {
                this.txtComentario.Text = laParada.Comentario;
                this.txtRazon.Text = laParada.Razon;
                this.txtViaje.Text = laParada.Id.ToString();
                return;
            }
            this.lblDataOutput.Text = "Algo salió mal.";
        }

    }
}