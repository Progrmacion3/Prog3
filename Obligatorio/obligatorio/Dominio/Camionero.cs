using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace obligatorio.Dominio
{
    public class Camionero : Empleado
    {
        private int _edad;
        private string _tipoLibreta;
        private DateTime _fechaVencimiento;

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public string TipoLibreta
        {
            get { return _tipoLibreta; }
            set { _tipoLibreta = value; }
        }
        public DateTime FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = value; }
        }

        public bool AltaCamionero(Camionero unCamionero) //Alta de Camioneros
        {
            if (BuscarCamionero(unCamionero) == null && Persistencia.Clases.pCamionero.AgregarCamionero(unCamionero))
            {
                return true;
            }
            return false;
          
        }
        public bool BajaCamionero(Camionero unCamionero)
        {
            if (BuscarCamionero(unCamionero) != null && Persistencia.Clases.pCamionero.EliminarCamionero(unCamionero))
            {
                Empresa empresa = new Dominio.Empresa();
                Camionero camionero = BuscarCamionero(unCamionero);
                empresa.ListaCamioneros().Remove(camionero);
                return true;
            }
            return false;
        }
        public bool ModificarCamionero(Camionero unCamionero)
        {
            if (BuscarCamionero(unCamionero) != null && Persistencia.Clases.pCamionero.ModificarCamionero(unCamionero))
            {
                return true;
            }
            return false;
        }
        public Camionero BuscarCamionero(Camionero unCamionero)
        {
            Empresa empresa = new Empresa();
            foreach (Camionero camionero in empresa.ListaCamioneros())
                if (unCamionero.Id == camionero.Id)
                    return camionero;

            return null;
        }


        public Camionero(int pId, string pNombre, string pApellido, string pCedula, string pCargo, string pTelefono, string pUsuario, string pContrasena, int pEdad, string pTipoLibreta, DateTime pFechaVencimiento) :
            base(pId, pNombre, pApellido, pCedula, pCargo, pTelefono, pUsuario, pContrasena)
        {
            Edad = pEdad;
            TipoLibreta = pTipoLibreta;
            FechaVencimiento = pFechaVencimiento;
        }

        public Camionero(string pNombre, string pApellido, string pCedula, string pCargo, string pTelefono, string pUsuario, string pContrasena, int pEdad, string pTipoLibreta, DateTime pFechaVencimiento) :
            base(pNombre, pApellido, pCedula, pCargo, pTelefono, pUsuario, pContrasena)
        {
            Edad = pEdad;
            TipoLibreta = pTipoLibreta;
            FechaVencimiento = pFechaVencimiento;
        }
        public Camionero(int pId) :
            base(pId)
        {

        } 
        public Camionero()
        {

        }
    }
}