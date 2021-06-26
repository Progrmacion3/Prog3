using System;
using System.Collections.Generic;

namespace Common
{
    public class Viaje : Base
    {
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
            Estados = new List<Estado>();
        }

        public Viaje(int id) : base(id)
        {
            Estados = new List<Estado>();
        }

        public Viaje(string carga, DateTime inicio, DateTime fin, Ciudad origen, Ciudad destino, Camión camión, Camionero camionero)
        {
            Carga = carga;
            Inicio = inicio;
            Fin = fin;
            Origen = origen;
            Destino = destino;
            Camión = camión;
            Camionero = camionero;
            Estados = new List<Estado>();
        }

        public override string ToString()
        {
            return "Matrícula: " + Camión.Matrícula
                + " Conductor: " + Camionero.Apellido
                + ", Carga: " + Carga
                + ", de " + Origen + " a " + Destino
                + ", desde " + Inicio.ToString("d") + " al " + Fin.ToString("d");
        }
    }
}
