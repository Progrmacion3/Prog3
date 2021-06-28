using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace obligatorio.Dominio
{
    public class Parada
    {
        private int _id;
        private string _razon;
        private string _comentario;
        private int _idViaje;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Razon
        {
            get { return _razon; }
            set { _razon = value; }
        }
        public string Comentario
        {
            get { return _comentario; }
            set { _comentario = value; }
        }

        public int IdViaje
        {
            get { return _idViaje; }
            set { _idViaje = value; }
        }

        public Parada(int pId, string pRazon, string pComentario, int pIdViaje)
        {
            Id = pId;
            Razon = pRazon;
            Comentario = pComentario;
            IdViaje = pIdViaje;
        }
    }
}