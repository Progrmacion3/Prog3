using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using obligatorio.Dominio;

namespace obligatorio.Presentacion
{
    public partial class Camiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ListarDatos();
        }

        private bool FaltanDatos()
        {
            if (this.InputAno.Text == "" || this.InputMarca.Text == "" || this.InputMatricula.Text == "" || this.InputModelo.Text == "")
                return true;
            return false;
        }
        private bool FaltaMatricula()
        {
            if (this.InputMatricula.Text == "")
                return true;
            return false;
        }
        private void AvisoFaltanDatos()
        {
            this.lblDataOutput.Text = "Algún campo está vacío, fijate vos qué es.";
        }
        private void AvisoEdadNoEsNumber()
        {
            this.lblIdNotNum.Text = "Lo de arriba no es un número animal.";
        }

        private void ListarDatos()
        {
            Empresa empresa = new Empresa();
            this.grdCamiones.DataSource = empresa.ListaCamiones();
            this.grdCamiones.DataBind();
        }

        private void AvisoOperacion(string operacion)
        {
            this.lblDataOutput.Text = $"La {operacion} fue exitosa.";
        }
        private void AvisoFaltaMatricula()
        {
            this.lblMissingMat.Text = "Falta la matricula querid@";
        }
        private void LimpiarCampos()
        {
            this.InputMarca.Text = "";
            this.InputModelo.Text = "";
            this.InputMatricula.Text = "";
            this.InputAno.Text = "";
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                int ano;
                if (!int.TryParse(this.InputAno.Text, out ano))
                {
                    this.AvisoEdadNoEsNumber();
                    return;
                }
                Empresa empresa = new Empresa();
                string marca = this.InputMarca.Text;
                string modelo = this.InputModelo.Text;
                string matricula = this.InputMatricula.Text;
                ano = int.Parse(this.InputAno.Text);

                Camion camion = new Camion(marca, modelo, matricula, ano);
                if (empresa.MenuCamion("alta", camion))
                {
                    this.ListarDatos();
                    this.LimpiarCampos();
                    this.AvisoOperacion("alta");
                    return;
                }
                this.AvisoOperacion("alta no");
                return;
            }
            this.AvisoFaltanDatos();
            return;
        }

        protected void btnMod_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                int mAno;
                if (!int.TryParse(this.InputAno.Text, out mAno))
                {
                    this.AvisoEdadNoEsNumber();
                    return;
                }
                mAno = int.Parse(this.InputAno.Text);
                Empresa empresa = new Empresa();
                string mMarca = this.InputMarca.Text;
                string mModelo = this.InputModelo.Text;
                string mMatricula = this.InputMatricula.Text;
                
                Camion unCamion = new Camion(mMarca, mModelo, mMatricula, mAno);
                if(empresa.MenuCamion("modificar", unCamion))
                {
                    this.LimpiarCampos();
                    this.ListarDatos();
                    this.AvisoOperacion("modificación");
                    return;
                }
                this.LimpiarCampos();
                this.AvisoOperacion("modificación no");
                return;
            }
            this.AvisoFaltaMatricula();
            return;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        

        protected void grdCamiones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            this.LimpiarCampos();
            TableCell idCelda = grdCamiones.Rows[e.RowIndex].Cells[3];
            Camion camion = new Empresa().BuscarCamion(new Camion(idCelda.Text));
            bool output = new Empresa().MenuCamion("baja", camion);
            if (output)
            {
                this.ListarDatos();
                this.AvisoOperacion("baja");
                return;
            }
            this.AvisoOperacion("baja no");
        }

        protected void grdCamiones_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.LimpiarCampos();
            TableCell idCelda = grdCamiones.Rows[e.NewSelectedIndex].Cells[3];
            Camion camion = new Empresa().BuscarCamion(new Camion(idCelda.Text));
            if(camion != null)
            {
                this.InputMarca.Text = camion.Marca;
                this.InputModelo.Text = camion.Modelo;
                this.InputAno.Text = camion.Ano.ToString();
                this.InputMatricula.Text = camion.Matricula;
                return;
            }

            this.lblDataOutput.Text = "Algo salió mal";
        }
    }
}