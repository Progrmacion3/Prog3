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
            //to-do
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

        protected void btnBaja_Click(object sender, EventArgs e) // dsp cambiar, se hace con la grid, + ez
        {
            if (!FaltaMatricula()) {
                
                Empresa empresa = new Empresa();
                string matricula = this.InputMatricula.Text;
                Camion camion = new Camion(matricula);

                if (empresa.MenuCamion("baja", camion))
                {
                    this.ListarDatos();
                    this.LimpiarCampos();
                    this.AvisoOperacion("eliminación");
                    return;
                }
                this.AvisoOperacion("eliminación no");
                return;
            }
            this.AvisoFaltaMatricula();
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
    }
}