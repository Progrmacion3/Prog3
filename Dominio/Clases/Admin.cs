using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class Admin
    {
        public static bool AgregarAdmin(Common.Clases.Admin pAdmin)
        {
            return Persistencia.Clases.Admin.AgregarAdmin(pAdmin);
        }
        public static bool EliminarAdmin(Common.Clases.Admin pAdmin)
        {
            return Persistencia.Clases.Admin.EliminarAdmin(pAdmin);
        }
        public static bool ModificarAdmin(Common.Clases.Admin pAdmin)
        {
            return Persistencia.Clases.Admin.ModificarAdmin(pAdmin);
        }
        public static List<Common.Clases.Admin> MostrarAdmin()
        {
            return Persistencia.Clases.Admin.MostrarAdmin();
        }
        public static Common.Clases.Admin MostrarAdminEspecifico(Common.Clases.Admin pAdmin)
        {
            return Persistencia.Clases.Admin.MostrarAdminEspecifico(pAdmin);
        }
        public static Common.Clases.Admin ValidarAdmin(Common.Clases.Admin pAdmin)
        {
            return Persistencia.Clases.Admin.ValidarAdmin(pAdmin);
        }
    }
}
