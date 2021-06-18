using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    class Camionero: Empleado
    {   

        public short Edad { get; set;}
        public string Tipo_Libreta { get; set;}
        public string FechaVencimientoLibreta { get; set;}
    }
}
