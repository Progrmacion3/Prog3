﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo.Web
{
    public partial class wfrmConsultas : System.Web.UI.Page
    {
        private Administrador admin;
        protected void Page_Load(object sender, EventArgs e)
        {
            var usuario = Session["usuario"];
            if (usuario is Administrador)
            {
                admin = (Administrador)usuario;
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnViajesOrdenados_Click(object sender, EventArgs e)
        {

        }

        protected void btnParadasViaje_Click(object sender, EventArgs e)
        {

        }

        protected void btnParadasCamionero_Click(object sender, EventArgs e)
        {

        }

        protected void lstCamioneros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lstConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lstViajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}