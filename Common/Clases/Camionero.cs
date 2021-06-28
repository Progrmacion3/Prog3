using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Camionero:Empleado
    {

        public int Edad { get; set; }
        public string TipoLibreta{ get; set; }
        public DateTime FechaVenLib{ get; set; }
    }


    
}
