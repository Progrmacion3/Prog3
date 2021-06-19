using Common;
using System.Collections.Generic;

namespace Dominio
{
    public class Fachada
    {
        #region Login

        public static bool Ingresar(Usuario usuario, out bool correcto, out char tipo)
        {
            return DominioUsuario.Ingresar(usuario, out correcto, out tipo);
        }

        #endregion

        #region Ingreso de Usuarios

        public static bool Alta(Administrador administrador)
        {
            return DominioAdministrador.Alta(administrador);
        }

        public static bool Alta(Camionero camionero)
        {
            return DominioCamionero.Alta(camionero);
        }

        public static bool Baja(Usuario usuario)
        {
            return DominioUsuario.Baja(usuario);
        }

        public static bool Modificar(Administrador administrador)
        {
            return DominioAdministrador.Modificar(administrador);
        }

        public static bool Modificar(Camionero camionero)
        {
            return DominioCamionero.Modificar(camionero);
        }

        public static bool Listar(List<Administrador> lista)
        {
            return DominioAdministrador.Listar(lista);
        }

        public static bool Listar(List<Camionero> lista)
        {
            return DominioCamionero.Listar(lista);
        }

        #endregion

        #region Ingreso de Camiones

        public static bool Alta(Camión camión)
        {
            return DominioCamión.Alta(camión);
        }

        public static bool Baja(Camión camión)
        {
            return DominioCamión.Baja(camión);
        }

        public static bool Modificar(Camión camión)
        {
            return DominioCamión.Modificar(camión);
        }

        public static bool Listar(List<Camión> lista)
        {
            return DominioCamión.Listar(lista);
        }

        #endregion
    }
}
