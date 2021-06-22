using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Parada
    {
        //private int _idParada;
        private string _tipo;
        private string _comentario;

        //public int IdParada
        //{
        //    get { return _idParada; }
        //    set { _idParada = value; }
        //}
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

        public Parada(string pTipo, string pComentario)
        {
            this.Tipo = pTipo;
            this.Comentario = pComentario;
        }
    }
}
