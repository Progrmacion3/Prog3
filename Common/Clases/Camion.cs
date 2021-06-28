using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Camion
    {
        private int _idCamion;
        private string _matricula;
        private string _marca;
        private string _modelo;
        private int _año;

        public int IdCamion
        {
            get { return _idCamion; }
            set { _idCamion = value; }
        }
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
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
        public int Año
        {
            get { return _año; }
            set { _año = value; }
        }

        public Camion(string pMatriucla, string pMarca, string pModelo, int pAño)
        {
            this.Matricula = pMatriucla;
            this.Marca = pMarca;
            this.Modelo = pModelo;
            this.Año = pAño;
        }

        public Camion()
        {
        }
    }
}
