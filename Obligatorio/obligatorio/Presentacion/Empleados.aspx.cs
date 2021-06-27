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
        private bool FaltanDatos()
        {
            if (this.InputDocument.Text == "" || this.InputEdad.Text == "" || this.InputName.Text == "" || this.InputPass.Text == "" || this.InputPosition.Text == "" || this.InputSecondName.Text == "" || this.InputTelefono.Text == "" || this.InputTipoLibreta.Text == "" || this.InputUser.Text == "")
                return true;

            if (this.rdbAdministrador.Checked)
                return true;

            if (this.rdbCamionero.Checked && this.InputFechaVencimiento.SelectedDate < DateTime.Today.Date)
                return false;

            return true;
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

        public void btnAlta_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                if (this.rdbCamionero.Checked)
                {
                    this.InputEdad.Visible = true;
                    this.InputTipoLibreta.Visible = true;
                    this.InputFechaVencimiento.Visible = true;
                    Empresa empresa = new Empresa();
                    string mNombre = this.InputName.Text;
                    string mDocumento = this.InputDocument.Text;
                    string mApellido = this.InputSecondName.Text;
                    string mCargo = this.InputPosition.Text;
                    string mPassword = this.InputPass.Text;
                    string mUser = this.InputUser.Text;
                    string mTelefono = this.InputTelefono.Text;
                    string mTipoLibreta = this.InputTipoLibreta.Text;
                    int mEdad = int.Parse(this.InputEdad.Text);
                    DateTime mVencimientoLibreta = DateTime.Parse(this.InputFechaVencimiento.ToString());
                    Camionero unCamionero = new Camionero(mNombre, mApellido, mDocumento, mCargo, mTelefono, mUser, mPassword, mEdad, mTipoLibreta, mVencimientoLibreta);

                    if (empresa.MenuCamionero("alta", unCamionero))
                    {
                        this.ListarDatos();
                        this.LimpiarCampos();
                        return;
                    }
                    return;
                }
                // #removeElsesFromProgramming
                if (this.rdbAdministrador.Checked)
                {
                    Console.WriteLine("Holis");
                    return;
                }
                return;
            }
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {

            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }


    }
}