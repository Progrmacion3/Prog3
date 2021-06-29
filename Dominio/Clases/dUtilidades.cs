using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dUtilidades
    {
        public static Common.Clases.Empleado TraerEmpleadoInicioSesion(Common.Clases.Empleado pEmpleado)
        {
            return Persistencia.Clases.pUtilidades.TraerEmpleadoInicioSesion(pEmpleado);
        }
    }
}
