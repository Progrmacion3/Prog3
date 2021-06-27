
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Persistencia;

namespace Dominio.Clases

{
    class dEmpleado
    {


        public static bool Agregar_Empleado(Common.Clases.Empleado pEmpleado)
        {
            return Persistencia.Clases.pEmpleado.AgregarEmpleado(pEmpleado);
        }
        public static bool Modificar_Empleado(Common.Clases.Empleado pEmpleado)
        {
            return Persistencia.Clases.pEmpleado.ModificarEmpleado(pEmpleado);
        }

        /*public static List<Common.Clases.Cliente> TraerClientes()
        {
            return Persistencia.Clases.pCliente.TraerTodosLosClientes();
        }
        public static Common.Clases.Cliente TraerEspecifico(Common.Clases.Cliente pCliente)
        {
            return Persistencia.Clases.pCliente.TraerEspecifico(pCliente);
        }*/
        public static bool EliminarEmpleado(Common.Clases.Empleado pEmpleado)
        {
            return Persistencia.Clases.pEmpleado.EliminarEmpleado(pEmpleado);
        }
    }
}




