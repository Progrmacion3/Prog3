using Persistencia.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    class dEstado
    {
      

       

        public static bool AgregarEstado(Common.Clases.Estado pEstado)
        {
            return Persistencia.Clases.pEstado.AgregarEstado(pEstado);
        }
        public static bool Modificar(Common.Clases.Estado pEstado)
        {
            return Persistencia.Clases.pEstado.Modificar(pEstado);
        }

        //public static List<Common.Clases.Estado> TraerEstado()
        //{
        //    return Persistencia.Clases.pEstado.TraerTodosLosEstados();
        //}
        //public static Common.Clases.Estado TraerEspecifico(Common.Clases.Cliente pCliente)
        //{
        //    return Persistencia.Clases.pCliente.TraerEspecifico(pCliente);
        //}
        public static bool Eliminar(Common.Clases.Estado pEstado)
        {
            return Persistencia.Clases.pEstado.Eliminar(pEstado);
        }
    }
}
