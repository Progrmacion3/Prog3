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
            Dominio.Login login = new Dominio.Login();
            if (login.TipoLogin == "A")
            {
                this.Master.FindControl("btnEmp").Visible = true;
                this.Master.FindControl("btnCamiones").Visible = true;
                this.Master.FindControl("btnViajes").Visible = true;
                this.Master.FindControl("btnParadas").Visible = true;
            }
            else if (login.TipoLogin == "C")
            {
                this.Master.FindControl("btnViajes").Visible = true;
                this.Master.FindControl("btnParadas").Visible = true;
                this.txtCamion.Enabled = false;
                this.txtCamionero.Enabled = false;
                this.txtCarga.Enabled = false;
                this.txtDestino.Enabled = false;
                this.txtOrigen.Enabled = false;
                this.btnAlta.Enabled = false;
                this.dtpFechaInicio.Enabled = false;
                this.dtpFechaFin.Enabled = false;
            }
            if (!IsPostBack)
            {
                ListarDatos();
            }
        }

        private bool FaltanDatos() // comprobamos que todos los campos tengan datos y las fechas sean validas
        {
            if (this.txtCamion.Text == "" || this.txtCamionero.Text == "" || this.txtCarga.Text == "" || this.txtDestino.Text == "" || this.txtKilaje.Text == "" || this.txtOrigen.Text == "" || this.dtpFechaFin.SelectedDate >= this.dtpFechaInicio.SelectedDate)
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
            Empresa empresa = new Empresa();
            this.grdViajes.DataSource = empresa.ListaViajes();
            this.grdViajes.DataBind();
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
            int output = new Random().Next(3);
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
                string mEstado = this.ddlEstado.Text;

                Viaje unViaje = new Viaje(elCamionero, elCamion, mCarga, mKilaje, mOrigen, mDestino, mFechaInicio, mFechaFin, mEstado);
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
                int mId = int.Parse(this.txtId.Text);
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
                string mEstado = this.ddlEstado.Text;

                Viaje unViaje = new Viaje(mId, elCamionero, elCamion, mCarga, mKilaje, mOrigen, mDestino, mFechaInicio, mFechaFin, mEstado);
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

        protected void grdViajes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            this.LimpiarCampos();
            TableCell idCelda = grdViajes.Rows[e.RowIndex].Cells[1];
            Viaje viaje = new Empresa().BuscarViaje(new Viaje(int.Parse(idCelda.Text)));
            bool output = new Empresa().MenuViaje("baja", viaje);
            if (output)
            {
                this.ListarDatos();
                //this.AvisoOperacion("baja");
                return;
            }
            //this.AvisoOperacion("baja no");
        }

        protected void grdViajes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.LimpiarCampos();
            TableCell idCelda = grdViajes.Rows[e.NewSelectedIndex].Cells[1];
            Viaje viaje = new Empresa().BuscarViaje(new Viaje(int.Parse(idCelda.Text)));
            if (viaje != null)
            {
                this.txtId.Text = viaje.Id.ToString();
                this.txtCamion.Text = viaje.Camion.Matricula;
                this.txtCamionero.Text = viaje.Camionero.Id.ToString();
                this.txtCarga.Text = viaje.Carga;
                this.txtOrigen.Text = viaje.Origen;
                this.txtDestino.Text = viaje.Destino;
                this.txtKilaje.Text = viaje.Kilaje.ToString();
                this.dtpFechaInicio.SelectedDate = viaje.FechaInicio;
                this.dtpFechaFin.SelectedDate = viaje.FechaFin;
                return;
            }

            this.lblDataOutput.Text = "Algo salió mal";
        }

    }
}