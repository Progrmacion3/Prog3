using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace obligatorio.Dominio
{
    public class Consultas
    {
        private Viaje _unViaje;
        private string _ci;
        private List<Consultas> _listaConsultas = new List<Consultas>();
        public Viaje unViaje
        {
            get { return _unViaje; }
            set { _unViaje = value; }
        }

        public string CI
        {
            get { return _ci; }
            set { _ci = value; }
        }


        public override string ToString()
        {
            return this.unViaje + " " + this.CI;
        }

        public Consultas(string pCi, Viaje unViaje)
        {
            this.CI = pCi;
            this.unViaje = _unViaje; 

        }

    }
}