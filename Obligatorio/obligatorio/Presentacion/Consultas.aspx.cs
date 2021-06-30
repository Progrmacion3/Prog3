using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using obligatorio.Dominio;

namespace obligatorio.Presentacion
{
    public partial class Consultas : System.Web.UI.Page
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
                this.Master.FindControl("btnConsultas").Visible = true;
            }
            if (login.TipoLogin == "C")
            {
                this.Master.FindControl("btnViajes").Visible = true;
                this.Master.FindControl("btnParadas").Visible = true;
            }
            this.ListarDatos();
        }

        private void ListarDatos()
        {
            this.grdViajeC3.DataSource = new Empresa().ListaViajes();
            this.grdViajeC3.DataBind();
        }
        private bool FaltaParadaC3()
        {
            if (this.txtParadaC3.Text == "")
                return true;
            return false;
        }
        private void AvisoFaltaCamioneroC3()
        {
            this.lblMissingCamioneroC3.Text = "Te faltó seleccionar el camionero.";
        }
        private void LimpiarCampos()
        {
            this.txtParadaC3.Text = "";
            this.lblMissingCamioneroC3.Text = "";
            this.lblMissingMat.Text = "";
        }
        private int GetIdViaje()
        {
            if (!FaltaParadaC3())
                return 0;
            return int.Parse(this.txtParadaC3.Text);
        }

        protected void btnC1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnC2_Click(object sender, EventArgs e)
        {
            string ci = this.InputCiCamionero.Text;
            Empresa unaEmpresa = new Empresa();
            this.lstViajesCamionero.DataSource = null;
            this.lstViajesCamionero.DataSource = unaEmpresa.ListaViajes();
            this.lstViajesCamionero.DataBind();
        }

        protected void btnC3_Click(object sender, EventArgs e)
        {
            if (!FaltaParadaC3())
            {
                int idParada = int.Parse(this.txtParadaC3.Text);
            }
            this.AvisoFaltaCamioneroC3();
        }

        protected void grdParadas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.LimpiarCampos();
            int idParada = int.Parse(this.grdParadas.Rows[e.NewSelectedIndex].Cells[0].Text);
            int idViaje = int.Parse(this.grdParadas.Rows[e.NewSelectedIndex].Cells[3].Text);

            Viaje elViaje = new Empresa().BuscarViaje(new Viaje(idViaje));
            foreach (Parada unaParada in elViaje.ListaParadas())
                if (unaParada.Id == idParada)
                {
                    this.txtParadaC3.Text = idParada.ToString();
                    return;
                }
            this.lblMissingCamioneroC3.Text = "Algo salió mal.";
        }

        protected void grdViajeC3_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.LimpiarCampos();
            int idViaje = int.Parse(this.grdViajeC3.Rows[e.NewSelectedIndex].Cells[3].Text);

            Viaje elViaje = new Empresa().BuscarViaje(new Viaje(idViaje));
            if(elViaje == null)
            {    
                this.lblMissingCamioneroC3.Text = "Algo salió mal.";
                return;
            }
            this.txtParadaC3.Text = idViaje.ToString();
        }

        protected void lstViajesCamionero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}