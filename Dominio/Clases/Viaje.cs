using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class Viaje
    {
        public static bool AgregarViaje(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.Viaje.AgregarViaje(pViaje);
        }
        public static bool EliminarViaje(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.Viaje.EliminarViaje(pViaje);
        }
        public static bool ModificarViaje(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.Viaje.ModificarViaje(pViaje);
        }
        public static List<Common.Clases.Viaje> MostrarViajes()
        {
            return Persistencia.Clases.Viaje.MostrarViajes();
        }
        public static Common.Clases.Viaje MostrarViajeEspecifico(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.Viaje.MostrarViajeEspecifico(pViaje);
        } 
    }
}
