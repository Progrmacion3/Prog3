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

        }

        private void ListarDatos()
        {

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
            Empresa empresa = new Empresa();
            string marca = this.InputMarca.Text;
            string modelo = this.InputModelo.Text;
            string matricula = this.InputMatricula.Text;
            int ano = int.Parse(this.InputAno.Text);
            Camion camion = new Camion(marca, modelo, matricula, ano);

            if (empresa.MenuCamion("alta", camion))
            {
                this.ListarDatos();
                this.LimpiarCampos();
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }
    }
}