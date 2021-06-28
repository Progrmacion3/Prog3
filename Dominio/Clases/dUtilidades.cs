using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dUtilidades
    {
        public static string TraerTipoEmpleado(Common.Clases.Empleado pEmpleado)
        {
            return Persistencia.Clases.pUtilidades.TraerTipoEmpleado(pEmpleado);
        }
    }
}
