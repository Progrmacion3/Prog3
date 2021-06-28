using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace obligatorio.Dominio
{
    public class Camion
    {
        private string _marca;
        private string _modelo;
        private string _matricula;
        private int _ano; // año btw tbh idc

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
            if (BuscarCamion(unCamion) == null && Persistencia.Clases.pCamion.AgregarCamion(unCamion))
            {
                Empresa empresa = new Dominio.Empresa();
                empresa.ListaCamiones().Add(unCamion);
                return true;
            }
            return false;
            
        }
        public bool BajaCamion(Camion unCamion)
        {
            if (BuscarCamion(unCamion) != null && Persistencia.Clases.pCamion.EliminarCamion(unCamion))
            {
                Empresa empresa = new Dominio.Empresa();
                Camion camion = BuscarCamion(unCamion);
                empresa.ListaCamiones().Remove(camion);
                return true;
            }
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
            if (unCamion == null) return null;
            Empresa empresa = new Dominio.Empresa();
            foreach (Camion camion in empresa.ListaCamiones())
                if (unCamion.Matricula == camion.Matricula)
                    return camion;

            return null;
        }

        public Camion(string pMarca, string pModelo, string pMatricula, int pAno)
        {
            Marca = pMarca;
            Modelo = pModelo;
            Matricula = pMatricula;
            Ano = pAno;
        }
        public Camion(string pMatricula)
        {
            Matricula = pMatricula;
        }
        public Camion()
        {

        }
    }
}