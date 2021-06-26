using Common;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Dominio
{
    class DominioViaje
    {
        public static bool Alta(Viaje viaje)
        {
            return PersistenciaViaje.Alta(viaje);
        }

        public static bool Baja(Viaje viaje)
        {
            return PersistenciaViaje.Baja(viaje);
        }

        public static bool Listar(List<Viaje> lista)
        {
            return PersistenciaViaje.Listar(lista);
        }

        public static bool Obtener(Viaje viaje)
        {
            return PersistenciaViaje.Obtener(viaje);
        }

        public static bool ViajeActual(Camionero camionero, out Viaje viaje)
        {
            return PersistenciaViaje.ViajeActual(camionero, out viaje);
        }

        public static bool ObtenerEstadoActual(Viaje viaje, out Estado estado)
        {
            return PersistenciaViaje.ObtenerEstadoActual(viaje, out estado);
        }

        public static bool Alta(Estado estado, Viaje viaje)
        {
            return PersistenciaViaje.Alta(estado, viaje);
        }
    }
}
