using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using obligatorio.Dominio;

namespace obligatorio.Presentacion
{
    public partial class Empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                this.ListarDatos();
        }

        private void MostrarCampos()
        {

        }
        private bool FaltanDatos()
        {
            if (!this.rdbAdministrador.Checked && !this.rdbCamionero.Checked)
                return true;

            if (this.InputDocument.Text == "" || this.InputName.Text == "" || this.InputPass.Text == "" || this.InputPosition.Text == "" || this.InputSecondName.Text == "" || this.InputTelefono.Text == "" || this.InputUser.Text == "")
                return false;

            if (this.rdbAdministrador.Checked)
                return true;

            if (this.rdbCamionero.Checked && (this.InputFechaVencimiento.SelectedDate < DateTime.Today.Date || this.InputEdad.Text == "" || this.InputTipoLibreta.Text == ""))
                return true;

            return false;
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
                Empresa empresa = new Empresa();
                if (this.rdbCamionero.Checked)
                {
                    string mNombre = this.InputName.Text;
                    string mDocumento = this.InputDocument.Text;
                    string mApellido = this.InputSecondName.Text;
                    string mCargo = this.InputPosition.Text;
                    string mPassword = this.InputPass.Text;
                    string mUser = this.InputUser.Text;
                    string mTelefono = this.InputTelefono.Text;
                    string mTipoLibreta = this.InputTipoLibreta.Text;
                    int mEdad = int.Parse(this.InputEdad.Text);
                    DateTime mVencimientoLibreta = this.InputFechaVencimiento.SelectedDate;
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
                    string mNombre = this.InputName.Text;
                    string mDocumento = this.InputDocument.Text;
                    string mApellido = this.InputSecondName.Text;
                    string mCargo = this.InputPosition.Text;
                    string mPassword = this.InputPass.Text;
                    string mUser = this.InputUser.Text;
                    string mTelefono = this.InputTelefono.Text;
                    Administrador unAdmin = new Administrador(mNombre, mApellido, mDocumento, mCargo, mTelefono, mUser, mPassword);
                    if(empresa.MenuAdmin("alta", unAdmin))
                    {
                        this.LimpiarCampos();
                        this.ListarDatos();
                        return;
                        // avisar al usuario que se agrego
                    }
                    // avisar al usuario que no se agrego
                    return;
                }
                return;
            }
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            // con la grid, dsp hay que borrarlo
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                // hay que hacer la grid
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }


    }
}