using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    class Viaje
    {
        public short Id { get; set;}
        public Camionero Camionero { get; set;}
        public Camion Camion { get; set; }
        public string TipoCarga { get; set;}
        public string Kilaje { get; set;}
        public string Origen { get; set;}
        public string Destino { get; set;}
        public string FechaInicio { get; set;}
        public string FechaFinalizacion { get; set;}
        public string Estado { get; set;}
        public List<Parada> Paradas { get; set;}

    }
}
