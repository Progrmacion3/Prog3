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

        public static bool Modificar_ViajeC(Common.Clases.Viaje pVia)
        {
            return Persistencia.Clases.pViaje.ModificarViajeC(pVia);
        }

        public static List<Common.Clases.Viaje> Traer_Viaje()
        {
            return Persistencia.Clases.pViaje.TraerTodosLosViajes();
        }

        public static Common.Clases.Viaje Traer_UnViaje(Common.Clases.Viaje pVia)
        {
            return Persistencia.Clases.pViaje.TraerUnViajeEnEspecifico(pVia);
        }

    }
}
