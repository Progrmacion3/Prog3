using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace obligatorio.Dominio
{
    public class Administrador : Empleado
    {
        public bool AltaAdmin(Administrador unAdmin)
        {
            int num = new Random().Next();
            if (num == 1)
                return true;
            return false;
        }
        public bool BajaAdmin(Administrador unAdmin)
        {
            int num = new Random().Next();
            if (num == 1)
                return true;
            return false;
        }
        public bool ModificarAdmin(Administrador unAdmin)
        {
            int num = new Random().Next();
            if (num == 1)
                return true;
            return false;
        }
        public Administrador BuscarAdmin(Administrador unAdmin)
        {
            int num = new Random().Next();
            if (num == 1)
                return null;
            return null;
        }

        /*
         * todos
         * todos -id
         * solo id
         * vacio
         */
        public Administrador(int pId, string pNombre, string pApellido, string pCedula, string pCargo, string pTelefono, string pUsuario, string pContrasena):
            base(pNombre, pApellido, pCargo, pCargo, pTelefono, pUsuario, pContrasena)
        {

        }
        public Administrador(string pNombre, string pApellido, string pCedula, string pCargo, string pTelefono, string pUsuario, string pContrasena) :
            base(pNombre, pApellido, pCargo, pCargo, pTelefono, pUsuario, pContrasena)
        {

        }
        public Administrador(int pId):
            base(pId)
        {

        }
        public Administrador()
        {

        }
    }
}