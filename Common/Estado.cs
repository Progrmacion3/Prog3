using System;

namespace Common
{
    public class Estado : Base
    {
        public string Tipo { get; set; }

        public DateTime Time { get; set; }

        public int Kilaje { get; set; }

        public string Comentario { get; set; }

        public Estado()
        {
        }

        public Estado(int id) : base(id)
        {
        }

        public Estado(string tipo, int kilaje, string comentario)
        {
            Tipo = tipo;
            Kilaje = kilaje;
            Comentario = comentario;
        }

        public Estado(int id, string tipo, DateTime time) : base(id)
        {
            Tipo = tipo;
            Time = time;
        }

        public Estado(int id, string tipo, DateTime time, int kilaje, string comentario) : base(id)
        {
            Tipo = tipo;
            Time = time;
            Kilaje = kilaje;
            Comentario = comentario;
        }

        public override string ToString()
        {
            return Time.ToString("g") + ", " + Tipo + ", " + Kilaje + "k: " + Comentario;
        }
    }
}
