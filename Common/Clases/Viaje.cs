using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    class Viaje
    {
        private Camionero _camionero;
        private Camion _camion;
        private string _tipo_carga;
        private int _kilaje;
        private string _origen;
        private string _destino;
        private DateTime _fecha_inicio;
        private DateTime _fecha_finalizacion;
        private string _estado;

        public Camionero camionero
        {
            get { return _camionero; }
            set { _camionero = value; }
        }

        public Camion camion
        {
            get { return _camion; }
            set { _camion = value; }
        }

        public string Tipo_Carga
        {
            get { return _tipo_carga; }
            set { _tipo_carga = value; }
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

        public DateTime Fecha_Inicio
        {
            get { return _fecha_inicio; }
            set { _fecha_inicio = value; }
        }

        public DateTime Fecha_Finalizacion
        {
            get { return _fecha_finalizacion; }
            set { _fecha_finalizacion = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
