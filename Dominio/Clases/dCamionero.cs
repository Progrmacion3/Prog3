using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    class dCamionero
    {
        public static bool Agregar_Camionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.AgregarCamionero(pCamionero);
        }
        public static bool Modificar_Camionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.ModificarCamionero(pCamionero);
        }

        /*public static List<Common.Clases.Cliente> TraerClientes()
        {
            return Persistencia.Clases.pCliente.TraerTodosLosClientes();
        }
        public static Common.Clases.Cliente TraerEspecifico(Common.Clases.Cliente pCliente)
        {
            return Persistencia.Clases.pCliente.TraerEspecifico(pCliente);
        }*/
        public static bool EliminarCamionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.EliminarCamionero(pCamionero);
        }
    }
}
