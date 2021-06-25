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

        public Estado(string tipo, int kilaje, string comentario)
        {
            Tipo = tipo;
            Kilaje = kilaje;
            Comentario = comentario;
        }

        public Estado(int id, string tipo, DateTime time)
        {
            Id = id;
            Tipo = tipo;
            Time = time;
        }
    }
}
