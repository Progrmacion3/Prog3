using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Parada
    {
        public short Id { get; set;}
        public string Tipo { get; set;}
        public string Comentario { get; set;}
        public Viaje Viaje { get; set; }
    }
}
