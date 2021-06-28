using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web.Secciones.Admin
{
    public partial class Empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }


        protected void ActualizarLista()
        {
            this.grdEmpleados.DataSource = Dominio.Fachada.MostarEmpleadosActivos();
            this.grdEmpleados.DataBind();
            this.grdExEmpleados.DataSource = Dominio.Fachada.MostarEmpleadosEliminados();
            this.grdExEmpleados.DataBind();
        }


    }
}