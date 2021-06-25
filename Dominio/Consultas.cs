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

        public static bool ListarCamioneros(int cédula, List<Camionero> lista)
        {
            return PersistenciaConsultas.ListarCamioneros(cédula, lista);
        }

        public static bool ListarViajes(Camionero camionero, List<Viaje> lista)
        {
            return PersistenciaConsultas.ListarViajes(camionero, lista);
        }
    }
}