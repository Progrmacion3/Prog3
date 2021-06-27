using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    class dCamion
    {

        public static bool Agregar_Camion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.AgregarCamion(pCamion);
        }
        public static bool Modificar_Camion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.ModificarCamion(pCamion);
        }

        /*public static List<Common.Clases.Cliente> TraerClientes()
        {
            return Persistencia.Clases.pCliente.TraerTodosLosClientes();
        }
        public static Common.Clases.Cliente TraerEspecifico(Common.Clases.Cliente pCliente)
        {
            return Persistencia.Clases.pCliente.TraerEspecifico(pCliente);
        }*/
        public static bool EliminarCamion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.EliminarCamion(pCamion);
        }
    }
}
