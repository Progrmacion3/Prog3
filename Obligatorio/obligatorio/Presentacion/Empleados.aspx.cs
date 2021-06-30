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
            Dominio.Login login = new Dominio.Login();
            if (login.TipoLogin == "A")
            {
                this.Master.FindControl("btnEmp").Visible = true;
                this.Master.FindControl("btnCamiones").Visible = true;
                this.Master.FindControl("btnViajes").Visible = true;
                this.Master.FindControl("btnParadas").Visible = true;
                this.Master.FindControl("btnConsultas").Visible = true;
            }
            else if (login.TipoLogin == "C")
            {
                this.Master.FindControl("btnViajes").Visible = true;
                this.Master.FindControl("btnParadas").Visible = true;
            }
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

            if (this.InputDocument.Text == "" || this.InputName.Text == "" || this.InputPass.Text == "" || this.InputSecondName.Text == "" || this.InputTelefono.Text == "" || this.InputUser.Text == "")
                return true;

            if (this.rdbAdministrador.Checked)
                return false;

            if (this.rdbCamionero.Checked && (this.InputFechaVencimiento.SelectedDate < DateTime.Today.Date || this.InputEdad.Text == "" || this.InputTipoLibreta.Text == ""))
                return true;

            return false;
        }
        private void ListarDatos()
        {
            Empresa empresa = new Empresa();
            this.grdCamioneros.DataSource = empresa.ListaCamioneros();
            this.grdCamioneros.DataBind();
            this.grdAdmins.DataSource = empresa.ListaAdministradores();
            this.grdAdmins.DataBind();
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
            this.InputSecondName.Text = "";
            this.InputUser.Text = "";
            this.rdbCamionero.Checked = false;
            this.rdbAdministrador.Checked = false;
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
                    string mCargo = "Camionero";
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
                if (this.rdbAdministrador.Checked)
                {
                    string mNombre = this.InputName.Text;
                    string mDocumento = this.InputDocument.Text;
                    string mApellido = this.InputSecondName.Text;
                    string mCargo = "Admin";
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
                    int mId = int.Parse(this.InputId.Text);
                    mEdad = int.Parse(this.InputEdad.Text);
                    string mNombre = this.InputName.Text;
                    string mDocumento = this.InputDocument.Text;
                    string mApellido = this.InputSecondName.Text;
                    string mCargo = "Camionero";
                    string mPassword = this.InputPass.Text;
                    string mUser = this.InputUser.Text;
                    string mTelefono = this.InputTelefono.Text;
                    string mTipoLibreta = this.InputTipoLibreta.Text;

                    DateTime mVencimientoLibreta = this.InputFechaVencimiento.SelectedDate;
                    Camionero unCamionero = new Camionero(mId, mNombre, mApellido, mDocumento, mCargo, mTelefono, mUser, mPassword, mEdad, mTipoLibreta, mVencimientoLibreta);

                    if (empresa.MenuCamionero("modificar", unCamionero))
                    {
                        this.ListarDatos();
                        this.LimpiarCampos();
                        this.OperacionOutput("modificación");
                        return;
                    }
                    this.OperacionOutput("modificación no");
                    return;
                }
                if (this.rdbAdministrador.Checked)
                {
                    int mId = int.Parse(this.InputId.Text);
                    string mNombre = this.InputName.Text;
                    string mDocumento = this.InputDocument.Text;
                    string mApellido = this.InputSecondName.Text;
                    string mCargo = "Admin";
                    string mPassword = this.InputPass.Text;
                    string mUser = this.InputUser.Text;
                    string mTelefono = this.InputTelefono.Text;
                    Administrador unAdmin = new Administrador(mId, mNombre, mApellido, mDocumento, mCargo, mTelefono, mUser, mPassword);

                    if (empresa.MenuAdmin("modificar", unAdmin))
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

        protected void grdCamioneros_RowDeleting(object sender, GridViewDeleteEventArgs e)
      {
            this.LimpiarCampos();
            TableCell idCelda = grdCamioneros.Rows[e.RowIndex].Cells[4];
            Camionero camionero = new Empresa().BuscarCamionero(new Camionero(int.Parse(idCelda.Text)));
            bool output = new Empresa().MenuCamionero("baja", camionero);
            if (output)
            {
                this.ListarDatos();
                return;
            }
        }

        protected void grdCamioneros_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.LimpiarCampos();
            TableCell idCelda = grdCamioneros.Rows[e.NewSelectedIndex].Cells[4];
            Camionero camionero = new Empresa().BuscarCamionero(new Camionero(int.Parse(idCelda.Text)));
            if (camionero != null)
            {
                this.InputId.Text = camionero.Id.ToString();
                this.InputName.Text = camionero.Nombre;
                this.InputSecondName.Text = camionero.Apellido;
                this.InputDocument.Text = camionero.Cedula;
                this.InputEdad.Text = camionero.Edad.ToString();
                this.InputFechaVencimiento.SelectedDate = camionero.FechaVencimiento;
                this.InputPass.Text = camionero.Contrasena;
                this.InputTelefono.Text = camionero.Telefono;
                this.InputTipoLibreta.Text = camionero.TipoLibreta;
                this.InputUser.Text = camionero.Usuario;
                this.rdbCamionero.Checked = true;
                return;
            }

            this.lblDataOutput.Text = "Algo salió mal";
        }

        protected void grdAdmins_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            this.LimpiarCampos();
            TableCell idCelda = grdAdmins.Rows[e.RowIndex].Cells[1];
            Administrador admin = new Empresa().BuscarAdministrador(new Administrador(int.Parse(idCelda.Text)));
            bool output = new Empresa().MenuAdmin("baja", admin);
            if (output)
            {
                this.ListarDatos();
                return;
            }
        }

        protected void grdAdmins_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.LimpiarCampos();
            TableCell idCelda = grdAdmins.Rows[e.NewSelectedIndex].Cells[1];
            Administrador admin = new Empresa().BuscarAdministrador(new Administrador(int.Parse(idCelda.Text)));
            if (admin != null)
            {
                this.InputId.Text = admin.Id.ToString();
                this.InputName.Text = admin.Nombre;
                this.InputSecondName.Text = admin.Apellido;
                this.InputDocument.Text = admin.Cedula;
                this.InputPass.Text = admin.Contrasena;
                this.InputTelefono.Text = admin.Telefono;
                this.InputUser.Text = admin.Usuario;
                this.rdbAdministrador.Checked = true;
                return;
            }

            this.lblDataOutput.Text = "Algo salió mal";
        }
    }
}