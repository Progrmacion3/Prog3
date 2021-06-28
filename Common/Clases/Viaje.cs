using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Viaje
    {
        private int _idViaje;
        private int _idCamionero;
        private int _idCamion;
        private string _tipoCarga;
        private int _kilaje;
        private string _origen;
        private string _destino;
        private DateTime _fechaInicio;
        private DateTime _fechaFinal;
        private string _estado;

        public int IdViaje
        {
            get { return _idViaje; }
            set { _idViaje = value; }
        }
        public int IdCamionero
        {
            get { return _idCamionero; }
            set { _idCamionero = value; }
        }
        public int IdCamion
        {
            get { return _idCamion; }
            set { _idCamion = value; }
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



        public Viaje()
        {
        }
    }
}
