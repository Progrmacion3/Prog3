using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Parada
    {
        private int _idParada;
        private int _idViaje;
        private string _tipo;
        private string _comentario;
        private string _estado;
        private DateTime _hora;

        public int IdParada
        {
            get { return _idParada; }
            set { _idParada = value; }
        }
        public int IdViaje
        {
            get { return _idViaje; }
            set { _idViaje = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string Comentario
        {
            get { return _comentario; }
            set { _comentario = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public DateTime Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }
        public Parada(string pTipo, string pComentario)
        {
            this.Tipo = pTipo;
            this.Comentario = pComentario;
        }

        public Parada()
        {
        }
    }
}
