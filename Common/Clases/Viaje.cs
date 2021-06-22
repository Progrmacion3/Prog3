using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    class Viaje
    {
        public Camionero Camionero { get; set; }
        public Camion Camion { get; set; }
        public string Tipo_Carga { get; set; }
        public int Kilaje { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Finalizacion { get; set; }
        public string Estado { get; set; }

       
    }
}
