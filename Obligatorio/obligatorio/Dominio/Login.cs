using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using obligatorio.Dominio;

namespace obligatorio.Dominio
{
    public class Login
    {
        public string loginCheck(string user, string contra)
        {
            Empresa empresa = new Empresa();
            List<Administrador> listaA = empresa.ListaAdministradores();
            List<Camionero> listaC = empresa.ListaCamioneros();

            foreach(Administrador admin in listaA)
            {
                if (admin.Usuario == user && admin.Contrasena == contra)
                    return "A";
            }

            foreach (Camionero camionero in listaC)
            {
                if (camionero.Usuario == user && camionero.Contrasena == contra)
                    return "C";
            }

            return null;
        }
    }
}