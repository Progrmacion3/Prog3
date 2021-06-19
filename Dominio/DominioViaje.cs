using Common;
using Persistencia;
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
    }
