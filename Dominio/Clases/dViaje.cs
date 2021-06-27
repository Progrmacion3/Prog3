using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dViaje
    {
        public static bool AltaViaje(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.pViaje.AltaViaje(pViaje);
        }
        public static bool BajaViaje(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.pViaje.BajaViaje(pViaje);
        }
        public static bool ModificarViaje(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.pViaje.ModificarViaje(pViaje);
        }
        public static List<Common.Clases.Viaje> ListarViajes()
        {
            return Persistencia.Clases.pViaje.ListarViajes();
        }
        public static Common.Clases.Viaje TraerViaje(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.pViaje.TraerViaje(pViaje);
        }
    }
}
