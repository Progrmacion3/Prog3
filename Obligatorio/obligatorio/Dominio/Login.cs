using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using obligatorio.Dominio;

namespace obligatorio.Dominio
{
    public class Login
    {
        private static string _tipoLogin;
        public string TipoLogin
        {
            get { return _tipoLogin; }
            set { _tipoLogin = value; }
        }

        public void loginCheck(string user, string contra)
        {
            Empresa empresa = new Empresa();
            List<Administrador> listaA = empresa.ListaAdministradores();
            List<Camionero> listaC = empresa.ListaCamioneros();

            foreach(Administrador admin in listaA)
            {
                if (admin.Usuario == user && admin.Contrasena == contra)
                {
                    _tipoLogin = "A";
                    return;
                }
                    
            }

            foreach (Camionero camionero in listaC)
            {
                if (camionero.Usuario == user && camionero.Contrasena == contra)
                {
                    _tipoLogin = "C";
                    return;
                }
            }

            return;
        }
    }
}