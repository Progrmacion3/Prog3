using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace obligatorio.Dominio
{
    public class Viaje
    {
        private int _id;
        private Empleado _camionero;
        private Camion _camion;
        private string _carga;
        private int _kilaje;
        private string _origen;
        private string _destino;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private string _estado;
        private static List<Parada> _listaParadas = new List<Parada>();

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Empleado Camionero
        {
            get { return _camionero; }
            set { _camionero = value; }
        }
        public Camion Camion
        {
            get { return _camion; }
            set { _camion = value; }
        }
        public string Carga
        {
            get { return _carga; }
            set { _carga = value; }
        }
        public int Kilaje
        {
            get { return _kilaje; }
            set { _kilaje = value; }
        }
        public string Origen
        {
            get { return _origen; }
            set { _origen = value; }
        }
        public string Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }
        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }
        public DateTime FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public List<Parada> ListaParadas()
        {
            return _listaParadas;
        }

        public bool AltaViaje(Viaje unViaje)
        {
            int num = new Random().Next();
            if (num == 1)
                return true;
            return false;
        }
        public bool BajaViaje(Viaje unViaje)
        {
            int num = new Random().Next();
            if (num == 1)
                return true;
            return false;
        }
        public bool ModificarViaje(Viaje unViaje)
        {
            int num = new Random().Next();
            if (num == 1)
                return true;
            return false;
        }
        public Viaje BuscarViaje(Viaje unViaje)
        {
            int num = new Random().Next();
            if (num == 1)
                return null;
            return null;
        }

        public Viaje(int pId, Empleado pCamionero, Camion pCamion, string pCarga, int pKilaje, string pOrigen, string pDestino, DateTime pFechaInicio, DateTime pFechaFin, string pEstado)
        {
            Id = pId;
            Camionero = pCamionero;
            Camion = pCamion;
            Carga = pCarga;
            Kilaje = pKilaje;
            Origen = pOrigen;
            Destino = pDestino;
            FechaInicio = pFechaInicio;
            FechaFin = pFechaFin;
            Estado = pEstado;
        }
        public Viaje(Empleado pCamionero, Camion pCamion, string pCarga, int pKilaje, string pOrigen, string pDestino, DateTime pFechaInicio, DateTime pFechaFin, string pEstado)
        {
            Camionero = pCamionero;
            Camion = pCamion;
            Carga = pCarga;
            Kilaje = pKilaje;
            Origen = pOrigen;
            Destino = pDestino;
            FechaInicio = pFechaInicio;
            FechaFin = pFechaFin;
            Estado = pEstado;
        }
        public Viaje(int pId)
        {
            Id = pId;
        }
        public Viaje()
        {

        }
    }
}