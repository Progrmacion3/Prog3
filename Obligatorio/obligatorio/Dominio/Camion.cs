using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace obligatorio.Dominio
{
    public class Camion
    {
        private int _id;
        private string _marca;
        private string _modelo;
        private string _matricula;
        private int _ano; // año btw tbh idc

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        public bool AltaCamion(Camion unCamion)
        {
            int num = new Random().Next();
            if (num == 1)
                return true;
            return false;
        }
        public bool BajaCamion(Camion unCamion)
        {
            int num = new Random().Next();
            if (num == 1)
                return true;
            return false;
        }
        public bool ModificarCamion(Camion unCamion)
        {
            int num = new Random().Next();
            if (num == 1)
                return true;
            return false;
        }
        public Camion BuscarCamion(Camion unCamion)
        {
            int num = new Random().Next();
            if (num == 1)
                return null;
            return null;
        }

        public Camion(int pId, string pMarca, string pModelo, string pMatricula, int pAno)
        {
            Id = pId;
            Marca = pMarca;
            Modelo = pModelo;
            Matricula = pMatricula;
            Ano = pAno;
        }
        public Camion(int pId)
        {
            Id = pId;
        }
        public Camion()
        {

        }
    }
}