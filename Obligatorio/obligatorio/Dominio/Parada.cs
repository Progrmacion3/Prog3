using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using obligatorio.Persistencia.Clases;

namespace obligatorio.Dominio
{
    public class Parada
    {
        private int _idViaje;
        private int _id;
        private string _razon;
        private string _comentario;
        private string _estado;

        public int IdViaje
        {
            get { return _idViaje; }
            set { _idViaje = value; }
        }
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
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public bool AgregarParada(Parada parParada)
        {
            if (this.BuscarParada(parParada) == null && pParada.AgregarParada(parParada))
            {
                Viaje viaje = new Empresa().BuscarViaje(new Viaje(parParada.IdViaje));
                viaje.Estado = "Parado";
                bool boolean = new Empresa().MenuViaje("modificar", viaje);
                return true;
            }
            return false;

        }
        public bool EliminarParada(Parada parParada)
        {
            if (pParada.EliminarParada(parParada))
            {
                return true;
            }
                
            return false;
        }
        public bool ModificarParada(Parada parParada)
        {
            if (pParada.ModificarParada(parParada))
                return true;
            return false;
        }
        public Parada BuscarParada(Parada pParada)
        {
            if (pParada == null)
                return null;
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

        public Parada(int pId, string pRazon, string pComentario, int pIdViaje, string pEstado)
        {
            Id = pId;
            Razon = pRazon;
            Comentario = pComentario;
            IdViaje = pIdViaje;
            Estado = pEstado;
        }

        public int ultimaId(int pIdViaje)
        {
            int max = 0;
            Empresa empresa = new Empresa();
            foreach (Viaje viaje in empresa.ListaViajes())
            {
                if (viaje.Id == pIdViaje)
                {
                    foreach (Parada parada in viaje.ListaParadas())
                    {
                        if (max <= parada.Id)
                        {
                            max = parada.Id;
                        }

                    }
                }
            }
            return max;
        }

        public Parada(string pRazon, string pComentario, int pIdViaje)
        {
            Id = ultimaId(pIdViaje)+1;
            Razon = pRazon;
            Comentario = pComentario;
            IdViaje = pIdViaje;
        }
        public Parada(int pId, int pIdViaje)
        {
            Id = pId;
            IdViaje = pIdViaje;
        }
        public Parada(int pId)
        {

        }
        public Parada()
        {

        }
    }
}