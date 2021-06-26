using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using obligatorio.Dominio;

namespace obligatorio.Presentacion
{
    public partial class Empleados : System.Web.UI.Page // <- esto es camionero
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        private void MostrarCampos()
        {

        }

        private void ListarDatos()
        {

        }
        private void LimpiarCampos()
        {
            this.InputEdad.Text = "";
            this.InputDocument.Text = "";
            this.InputTipoLibreta.Text = "";
            this.InputFechaVencimiento.SelectedDate = DateTime.Today;
            this.InputName.Text = "";
            this.InputPass.Text = "";
            this.InputTelefono.Text = "";
            this.InputPosition.Text = "";
            this.InputSecondName.Text = "";
            this.InputUser.Text = "";
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (this.rdbCamionero.Checked)
            {
                this.InputEdad.Visible = true;
                this.InputTipoLibreta.Visible = true;
                this.InputFechaVencimiento.Visible = true;
                Empresa empresa = new Empresa();
                string mNombre = this.InputName.ToString();
                string mDocumento = this.InputDocument.ToString();
                string mApellido = this.InputSecondName.ToString();
                string mCargo = this.InputPosition.ToString();
                string mPassword = this.InputPass.ToString();
                string mUser = this.InputUser.ToString();
                string mTelefono = this.InputTelefono.ToString();
                string mTipoLibreta = this.InputTipoLibreta.ToString();
                int mEdad = int.Parse(this.InputEdad.ToString());
                DateTime mVencimientoLibreta = DateTime.Parse(this.InputFechaVencimiento.ToString());
                Empleado unEmpleado = new Camionero(mNombre, mApellido, mDocumento, mCargo, mTelefono, mUser, mPassword, mEdad, mTipoLibreta, mVencimientoLibreta);

                if(empresa.MenuCamionero("alta", unEmpleado))
                {
                    this.ListarDatos();
                    this.LimpiarCampos();
                }
            }
         
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }


    }
}