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
                ListarDatos();
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
            return; // -> to-do
        }
        private void AvisoFaltaKilaje()
        {
            this.lblMissingKilaje.Text = "Te faltó el kilaje flaco.";
        }
        private void ResultadoOperacion(string operacion)
        {
            if (operacion == "alta" || operacion == "baja" || operacion == "modificación")
            {
                this.lblDataOutput.Text = $"Todo piola, la {operacion} anduvo perfecta.";
                return;
            }
            string[] rest = operacion.Split(' ');
            this.lblDataOutput.Text = $"Nada piola, la {rest[0]} salió mal. (T_T)";
        }
        private void AvisoFaltanDatos()
        {
            int output = new Random().Next(4);
            switch (output) {
                case 1:
                    this.lblDataOutput.Text = "Algó te faltó, fijate.";
                    break;
                case 2:
                    this.lblDataOutput.Text = "O soy ciego o estás con hambre y te comiste algún dato, fijate gato.";
                    break;
                case 3:
                    this.lblDataOutput.Text = "Te faltó algo ಠ_ಠ";
                    break;
                default:
                    this.lblDataOutput.Text = "Falta algún dato, revise por favor.";
                    break;
            }
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                int mKilaje;
                if(!int.TryParse(this.txtKilaje.Text, out mKilaje))
                {
                    this.AvisoFaltaKilaje();
                    return;
                }
                mKilaje = int.Parse(this.txtKilaje.Text);
                Empresa mEmpresa = new Empresa();
                string mMatCamion = this.txtCamion.Text;
                string mCarga = this.txtCarga.Text;
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
                    this.ResultadoOperacion("alta");
                    return;
                }
                this.ResultadoOperacion("alta no");
                return;
            }
            this.AvisoFaltanDatos();
            return;
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                int mKilaje;
                if (!int.TryParse(this.txtKilaje.Text, out mKilaje))
                {
                    this.AvisoFaltaKilaje();
                    return;
                }
                mKilaje = int.Parse(this.txtKilaje.Text);
                Empresa mEmpresa = new Empresa();
                string mMatCamion = this.txtCamion.Text;
                string mCarga = this.txtCarga.Text;
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
                    this.ResultadoOperacion("modificación");
                    return;
                }
                this.ResultadoOperacion("modificación no");
                return;
            }
            this.AvisoFaltanDatos();
            return;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }
    }
}