using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using obligatorio.Persistencia.Clases;

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

        public bool AgregarParada(Parada parParada)
        {
            if (this.BuscarParada(parParada) == null && pParada.AgregarParada(parParada))
                return true;
            return false;

        }
        public bool EliminarParada(Parada parParada)
        {
            if (this.BuscarParada(parParada) != null && pParada.EliminarParada(parParada))
                return true;
            return false;
        }
        public bool ModificarParada(Parada parParada)
        {
            if (this.BuscarParada(parParada) != null && pParada.ModificarParada(parParada))
                return true;
            return false;
        }
        public Parada BuscarParada(Parada pParada)
        {
            foreach (Parada lParada in new Empresa().ListaParadas())
                if (lParada.Id == pParada.Id)
                    return lParada;
            return null;
        }

        public Parada(int pId, string pRazon, string pComentario, int pIdViaje)
        {
            Id = pId;
            Razon = pRazon;
            Comentario = pComentario;
            IdViaje = pIdViaje;
        }
        public Parada(string pRazon, string pComentario, int pIdViaje)
        {
            Razon = pRazon;
            Comentario = pComentario;
            IdViaje = pIdViaje;
        }
        public Parada(int pId, int pIdViaje)
        {
            Id = pId;
            IdViaje = pIdViaje;
        }
        public Parada()
        {

        }
    }
}