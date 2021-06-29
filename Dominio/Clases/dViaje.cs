


















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

        /*public static List<Common.Clases.Cliente> TraerClientes()
        {
            return Persistencia.Clases.pCliente.TraerTodosLosClientes();
        }
        public static Common.Clases.Cliente TraerEspecifico(Common.Clases.Cliente pCliente)
        {
            return Persistencia.Clases.pCliente.TraerEspecifico(pCliente);
        }*/

        public static bool EliminarViajes(Common.Clases.Viaje pViaje)
        {
            return Persistencia.Clases.pViaje.EliminarViaje(pViaje);
        }


    }
}


