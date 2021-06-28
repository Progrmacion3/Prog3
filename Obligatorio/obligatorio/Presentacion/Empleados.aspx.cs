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

        private void EdadNoEsNumber()
        {
            this.lblEdadNotNumber.Text = "Lo de arriba no es un número capo.";
        }
        private bool FaltanDatos()
        {
            if (this.rdbAdministrador == null || this.rdbCamionero == null)
            {
                this.lblDataOutput.Text = "Algo salió mal.";
                return true;
            }

            if (!this.rdbAdministrador.Checked && !this.rdbCamionero.Checked)
                return true;

            if (this.InputDocument.Text == "" || this.InputName.Text == "" || this.InputPass.Text == "" || this.InputPosition.Text == "" || this.InputSecondName.Text == "" || this.InputTelefono.Text == "" || this.InputUser.Text == "")
                return true;

            if (this.rdbAdministrador.Checked)
                return false;

            if (this.rdbCamionero.Checked && (this.InputFechaVencimiento.SelectedDate < DateTime.Today.Date || this.InputEdad.Text == "" || this.InputTipoLibreta.Text == ""))
                return true;

            return false;
        }
        private void ListarDatos()
        {

        }
        private void AvisoFaltanDatos()
        {
            this.lblDataOutput.Text = "Falta alguna cosita, pegale una leida de nuevo ahí.";
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
        private void OperacionOutput(string operacion)
        {
            if (operacion == "alta" || operacion == "baja" || operacion == "modificación")
            {
                this.lblDataOutput.Text = $"Alto crack, la {operacion} salió perfecta.";
                return;
            }
            string[] rest = operacion.Split(' ');
            this.lblDataOutput.Text = $"Te caes a pedazos, la {rest[0]} salió mal. (T_T)";
        }
        private void NoSeleccionaCamioneroAdmin()
        {
            this.lblRadioBtn.Text = "Te faltó uno de los de arriba.";
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
                    if (empresa.MenuAdmin("alta", unAdmin))
                    {
                        this.LimpiarCampos();
                        this.ListarDatos();
                        this.OperacionOutput("alta");
                        return;
                    }
                    this.OperacionOutput("alta no");
                    return;
                }
                this.NoSeleccionaCamioneroAdmin();
                return;
            }
            this.AvisoFaltanDatos();
            return;
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            // con la grid, dsp hay que borrarlo
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                Empresa empresa = new Empresa();
                if (this.rdbCamionero.Checked)
                {
                    int mEdad;
                    if (!int.TryParse(this.InputEdad.Text, out mEdad))
                    {
                        return;
                    }
                    mEdad = int.Parse(this.InputEdad.Text);
                    string mNombre = this.InputName.Text;
                    string mDocumento = this.InputDocument.Text;
                    string mApellido = this.InputSecondName.Text;
                    string mCargo = this.InputPosition.Text;
                    string mPassword = this.InputPass.Text;
                    string mUser = this.InputUser.Text;
                    string mTelefono = this.InputTelefono.Text;
                    string mTipoLibreta = this.InputTipoLibreta.Text;

                    DateTime mVencimientoLibreta = this.InputFechaVencimiento.SelectedDate;
                    Camionero unCamionero = new Camionero(mNombre, mApellido, mDocumento, mCargo, mTelefono, mUser, mPassword, mEdad, mTipoLibreta, mVencimientoLibreta);

                    if (empresa.MenuCamionero("modificación", unCamionero))
                    {
                        this.ListarDatos();
                        this.LimpiarCampos();
                        this.OperacionOutput("modificación");
                        return;
                    }
                    this.OperacionOutput("modificación no");
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

                    if (empresa.MenuAdmin("modificación", unAdmin))
                    {
                        this.LimpiarCampos();
                        this.ListarDatos();
                        this.OperacionOutput("modificación no");
                        return;
                    }
                    this.OperacionOutput("modificación no");
                    return;
                }
                this.NoSeleccionaCamioneroAdmin();
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