using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dAdministrador
    {
        public static bool AltaAdministrador(Common.Clases.Administrador pAdministrador)
        {
            return Persistencia.Clases.pAdministrador.AltaAdministrador(pAdministrador);
        }
        public static bool BajaAdministrador(Common.Clases.Administrador pAdministrador)
        {
            return Persistencia.Clases.pAdministrador.BajaAdministrador(pAdministrador);
        }
        public static bool ModificarAdministrador(Common.Clases.Administrador pAdministrador)
        {
            return Persistencia.Clases.pAdministrador.ModificarAdministrador(pAdministrador);
        }
        public static List<Common.Clases.Administrador> ListarAdministradores()
        {
            return Persistencia.Clases.pAdministrador.ListarAdministradores();
        }
        public static Common.Clases.Administrador TraerAdministrador(Common.Clases.Administrador pAdministrador)
        {
            return Persistencia.Clases.pAdministrador.TraerAdministrador(pAdministrador);
        }
    }
}
