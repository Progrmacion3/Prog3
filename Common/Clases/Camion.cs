using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    class Camion
    {
        private string _marca;
        private string _modelo;
        private string _matricula;
        private int _año;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public int Año
        {
            get { return _año; }
            set { _año = value; }
        }
      
    }
}
