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
                string mMatCamion = this.txtCamion.Text;
                string mCarga = this.txtCarga.Text;
                int mKilaje = int.Parse(this.txtKilaje.Text);
                string mOrigen = this.txtOrigen.Text;
                string mDestino = this.txtDestino.Text;
                DateTime mFechaInicio = this.dtpFechaInicio.SelectedDate;
                DateTime mFechaFin = this.dtpFechaFin.SelectedDate;
                Camion elCamion = mEmpresa.BuscarCamion(new Camion(this.txtCamion.Text));
                Camionero elCamionero = mEmpresa.BuscarCamionero(new Camionero(int.Parse(this.txtCamionero.Text)));

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

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                Empresa mEmpresa = new Empresa();
                string mMatCamion = this.txtCamion.Text;
                string mCarga = this.txtCarga.Text;
                int mKilaje = int.Parse(this.txtKilaje.Text);
                string mOrigen = this.txtOrigen.Text;
                string mDestino = this.txtDestino.Text;
                DateTime mFechaInicio = this.dtpFechaInicio.SelectedDate;
                DateTime mFechaFin = this.dtpFechaFin.SelectedDate;
                Camion elCamion = mEmpresa.BuscarCamion(new Camion(this.txtCamion.Text));
                Camionero elCamionero = mEmpresa.BuscarCamionero(new Camionero(int.Parse(this.txtCamionero.Text)));

                Viaje unViaje = new Viaje(elCamionero, elCamion, mCarga, mKilaje, mOrigen, mDestino, mFechaInicio, mFechaFin);
                if(mEmpresa.MenuViaje("modificar", unViaje))
                {
                    this.LimpiarCampos();
                    this.ListarDatos();
                    //avisar que la opereishon tuvo ekzito
                }
                //avisar que la operasione tuvo una conclusion positiva
                return;
            }
            //avisar que faltan datos
            return;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }
    }
}