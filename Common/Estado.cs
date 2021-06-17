using System;

namespace Common
{
    public class Estado
    {
        public int Id { get; set; }

        public string Tipo { get; set; }

        public DateTime Time { get; set; }

        public int Kilaje { get; set; }

        public string Comentario { get; set; }

        public Estado()
        {
        }

        // Otros constructores
    }
}
