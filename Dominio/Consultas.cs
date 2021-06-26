using Common;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Dominio
{
    class Consultas
    {
        public static bool ListarViajesOrdenadosDelMes(List<Viaje> viajes)
        {
            return PersistenciaConsultas.ListarViajesOrdenadosDelMes(viajes);
        }

        public static bool ObtenerCamioneroPorCédula(Camionero camionero)
        {
            return PersistenciaConsultas.ObtenerCamioneroPorCédula(camionero);
        }

        public static bool ListarViajes(Camionero camionero, List<Viaje> lista)
        {
            return PersistenciaConsultas.ListarViajes(camionero, lista);
        }

        public static bool ListarParadas(Viaje viaje, List<Estado> lista)
        {
            return PersistenciaConsultas.ListarParadas(viaje, lista);
        }

        public static bool Obtener(Estado estado, Viaje viaje)
        {
            return PersistenciaConsultas.Obtener(estado, viaje);
        }
    }
}