using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class Viaje
    {
        public int Id { get; set; }

        public string Carga { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fin { get; set; }

        public Ciudad Origen { get; set; }

        public Ciudad Destino { get; set; }

        public Camión Camión { get; set; }

        public Camionero Camionero { get; set; }

        public List<Estado> Estados { get; set; }

        public Viaje()
        {
        }

        // Otros constructores

        public Estado EstadoActual()
        {
            return Estados.Last();
        }
    }
}
