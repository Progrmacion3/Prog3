using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dViaje
    {
        public static bool Agregar_Viaje(Common.Clases.Viaje pVia)
        {
            return Persistencia.Clases.pViaje.AgregarViaje(pVia);
        }

        public static bool Eliminar_Viaje(Common.Clases.Viaje pVia)
        {
            return Persistencia.Clases.pViaje.EliminarViaje(pVia);
        }

        public static bool Modificar_Viaje(Common.Clases.Viaje pVia)
        {
            return Persistencia.Clases.pViaje.ModificarViaje(pVia);
        }
    }
}
