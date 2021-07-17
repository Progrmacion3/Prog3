


















using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    class dViaje
    {

        public static bool Agregar_Viajes(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.pViaje.AgregarViaje(pViaje);
        }
        public static bool Modificar_Viajes(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.pViaje.ModificarViaje(pViaje);
        }

        public static List<Common.Clases.Viaje> TraerViajes()
        {
            return Persistencia.Clases.pViaje.TraerTodosLosViajes();
        }
        public static Common.Clases.Viaje TraerEspecifico(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.pViaje.TraerEspecifico(pViaje);
        }

        public static bool EliminarViajes(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.pViaje.EliminarViaje(pViaje);
        }


    }
}


