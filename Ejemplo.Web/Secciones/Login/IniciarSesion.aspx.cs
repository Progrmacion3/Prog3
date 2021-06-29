using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Login
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["WindowsAuth"].ConnectionString;
            SqlConnection sqlConectar = new SqlConnection(conectar);

            if (this.ckbAdmin.Checked)
            {
                SqlCommand cmd = new SqlCommand("ValidarAdmin", sqlConectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Connection.Open();
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 30).Value = txtUsuario.Text;
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar, 30).Value = txtContraseña.Text;

                SqlDataReader oReader = cmd.ExecuteReader();
                if (oReader.Read())
                {
                    //sesion de admin
                    Session["esCamionero"] = false;
                    Response.Redirect("~/Secciones/Admin/formAdmin.aspx");
                }
                else
                {
                    this.lblError.Text = "Usuario o contraseña incorrecta";
                }
                cmd.Connection.Close();
            }
            else if (this.ckbCamionero.Checked)
            {
                SqlCommand cmd = new SqlCommand("ValidarCamionero", sqlConectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Connection.Open();
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 30).Value = txtUsuario.Text;
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar, 30).Value = txtContraseña.Text;

                SqlDataReader oReader = cmd.ExecuteReader();
                if (oReader.Read())
                {
                    Session["esCamionero"] = true;
                    Response.Redirect("~/Secciones/Camionero/formCamionero.aspx");
                }
                else
                {
                    this.lblError.Text = "Usuario o contraseña incorrecta";
                }
                cmd.Connection.Close();
            }
            else
            {
                this.lblError.Text = "Seleccione UN tipo de usuario";
            }
           
        }
    }
}
