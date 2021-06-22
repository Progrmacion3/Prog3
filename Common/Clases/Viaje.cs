using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Viaje
    {
        //private int _idViaje;
        private Camionero _camionero;
        private Camion _camion;
        private string _tipoCarga;
        private int _kilaje;
        private string _origen;
        private string _destino;
        private DateTime _fechaInicio;
        private DateTime _fechaFinal;
        private string _estado;

        //public int IdViaje
        //{
        //    get { return _idViaje; }
        //    set { _idViaje = value; }
        //}
        public Camionero Camionero
        {
            get { return _camionero; }
            set { _camionero = value; }
        }
        public Camion Camion
        {
            get { return _camion; }
            set { _camion = value; }
        }
        public string TipoCarga
        {
            get { return _tipoCarga; }
            set { _tipoCarga = value; }
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
        public DateTime FechaFinal
        {
            get { return _fechaFinal; }
            set { _fechaFinal = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public Viaje(Camionero pCamionero, Camion pCamion, string pTipoCarga, int pKilaje, string pOrigen, string pDestino, DateTime pFechaInicio, DateTime pFechaFinal, string pEstado)
        {
            this.Camionero = pCamionero;
            this.Camion = pCamion;
            this.TipoCarga = pTipoCarga;
            this.Kilaje = pKilaje;
            this.Origen = pOrigen;
            this.Destino = pDestino;
            this.FechaInicio = pFechaInicio;
            this.FechaFinal = pFechaFinal;
            this.Estado = pEstado;
        }
    }
}
