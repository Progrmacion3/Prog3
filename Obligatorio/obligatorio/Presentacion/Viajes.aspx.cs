using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using obligatorio.Dominio;

namespace obligatorio.Presentacion
{
    public partial class Viajes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarDatos();
            }
        }

        private bool FaltanDatos() // comprobamos que todos los campos tengan datos y las fechas sean validas
        {
            if (this.txtCamion.Text == "" || this.txtCamionero.Text == "" || this.txtCarga.Text == "" || this.txtDestino.Text == "" || this.txtKilaje.Text == "" || this.txtOrigen.Text == "" || this.dtpFechaFin.SelectedDate <= DateTime.Today.Date || this.dtpFechaInicio.SelectedDate < DateTime.Today.Date || this.dtpFechaFin.SelectedDate == this.dtpFechaInicio.SelectedDate)
                return false;
            return true;
        }
        private void LimpiarCampos()
        {
            this.txtCamion.Text = "";
            this.txtCamionero.Text = "";
            this.txtCarga.Text = "";
            this.txtDestino.Text = "";
            this.txtKilaje.Text = "";
            this.txtOrigen.Text = "";
            this.dtpFechaFin.SelectedDate = DateTime.Today.Date;
            this.dtpFechaInicio.SelectedDate = DateTime.Today.Date;
            return;
        }
        private void ListarDatos()
        {
            return;
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                Empresa mEmpresa = new Empresa();
                int mIdCamionero = int.Parse(this.txtCamionero.Text);
                int mIdCamion = int.Parse(this.txtCamion.Text);
                string mCarga = this.txtCarga.Text;
                int mKilaje = int.Parse(this.txtKilaje.Text);
                string mOrigen = this.txtOrigen.Text;
                string mDestino = this.txtDestino.Text;
                DateTime mFechaInicio = this.dtpFechaInicio.SelectedDate;
                DateTime mFechaFin = this.dtpFechaFin.SelectedDate;
                Camion elCamion = mEmpresa.BuscarCamion(new Camion(mIdCamion));
                Camionero elCamionero = mEmpresa.BuscarCamionero(new Camionero(mIdCamionero));
                Viaje unViaje = new Viaje(elCamionero, elCamion, mCarga, mKilaje, mOrigen, mDestino, mFechaInicio, mFechaFin, "propuesto");
                if(mEmpresa.MenuViaje("alta", unViaje))
                {
                    this.LimpiarCampos();
                    this.ListarDatos();
                    //mandar mensaje al usuario o algo indicando que se agrego no se xd
                    return;
                }
                //mandar mensaje indicando un error
                return;
            }
            //avisar que faltan datos
            return;
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            // falta la grid
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                Empresa empresa = new Empresa();
                Camionero elCamionero = new Camionero(int.Parse(this.txtCamionero.Text));
                Camion elCamion = new Camion(int.Parse(this.txtCamion.Text));
                string mCarga = this.txtCarga.Text;
                int mKilaje = int.Parse(this.txtKilaje.Text);
                string mOrigen = this.txtOrigen.Text;
                string mDestino = this.txtDestino.Text;
                DateTime mFechaFin = this.dtpFechaFin.SelectedDate;
                DateTime mFechaInicio = this.dtpFechaInicio.SelectedDate;

                Viaje unViaje = new Viaje(elCamionero, elCamion, mCarga, mKilaje, mOrigen, mDestino, mFechaInicio, mFechaFin);
                if(empresa.MenuViaje("modificar", unViaje))
                {
                    this.LimpiarCampos();
                    this.ListarDatos();
                    //avisar al user operacion exitosa
                    return;
                }
                //avisar al user que fallo
                return;
            }
            //avisar al user que falta/n dato/s
            return;   
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }
    }
}