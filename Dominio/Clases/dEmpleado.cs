
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

        public static List<Common.Clases.Empleado> TraerEmpleados()
        {
            return Persistencia.Clases.pEmpleado.TraerTodosLosEmpleados();
        }
        public static Common.Clases.Empleado TraerEspecifico(Common.Clases.Empleado pEmpleado)
        {
            return Persistencia.Clases.pEmpleado.TraerEspecifico(pEmpleado);
        }

        public static bool EliminarEmpleado(Common.Clases.Empleado pEmpleado)
        {
            return Persistencia.Clases.pEmpleado.EliminarEmpleado(pEmpleado);
        }
    }
}




