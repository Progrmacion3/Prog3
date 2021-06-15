using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dCliente
    {
        public static bool Agregar_Cliente(Common.Clases.Cliente pCliente)
        {
            return Persistencia.Clases.pCliente.AgregarCliente(pCliente);
        }

        public static List<Common.Clases.Cliente> TraerClientes()
        {
            return Persistencia.Clases.pCliente.TraerTodosLosClientes();
        }
        public static Common.Clases.Cliente TraerEspecifico(Common.Clases.Cliente pCliente)
        {
            return Persistencia.Clases.pCliente.TraerEspecifico(pCliente);
        }

    }
}
