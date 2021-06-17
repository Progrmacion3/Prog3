using System;

namespace Common
{
    public class Camionero : Usuario
    {
        public DateTime Nacimiento { get; set; }

        public string TipoLibreta { get; set; }

        public DateTime VencimientoLibreta { get; set; }

        public Camionero()
        {
        }

        // Otros constructores: primero modificar Usuario

        public int Edad()
        {
            return (int)((DateTime.Now - Nacimiento).Days / 365.2425);
        }
    }
}
