using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Viaje:Camionero
    {
        public int idViaje { get; set; }
        public int CedulaCam { get; set; }
        public string Matricula { get; set; }
        public int Kilos { get; set; }
        public string TipoCarga { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }

    }
}
