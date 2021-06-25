using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Fachada
    {
        #region ABMViaje
        public static bool Agregar_Viaje(Common.Clases.Viaje pVia)
        {
            return Dominio.Clases.dViaje.Agregar_Viaje(pVia);
        }

        public static bool Eliminar_Viaje(Common.Clases.Viaje pVia)
        {
            return Dominio.Clases.dViaje.Eliminar_Viaje(pVia);
        }

        public static bool Modificar_Viaje(Common.Clases.Viaje pVia)
        {
            return Dominio.Clases.dViaje.Modificar_Viaje(pVia);
        }
        #endregion

    }
}
