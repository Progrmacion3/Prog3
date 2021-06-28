using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Camionero : Empleado
    {
        private int _idCamionero;
        private string _categoriaLibreta;
        private DateTime _fechaVencimiento;

        public int IdCamionero
        {
            get { return _idCamionero; }
            set { _idCamionero = value; }
        }
        public string CategoriaLibreta
        {
            get { return _categoriaLibreta; }
            set { _categoriaLibreta = value; }
        }
        public DateTime FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = value; }
        }

        public Camionero(int pCedula, string pNombre, string pApellido, DateTime pFechaNacimiento, string pCargo, string pTelefono, string pUsuario, string pContraseña, string pCategoriaLibreta, DateTime pFechaVencimiento)
            :base(pCedula, pNombre, pApellido, pFechaNacimiento, pCargo, pTelefono, pUsuario, pContraseña)
        {
            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.Apellido = pNombre;
            this.FechaNacimiento = pFechaNacimiento;
            this.Cargo = pCargo;
            this.Telefono = pTelefono;
            this.Usuario = pUsuario;
            this.Contraseña = pContraseña;
            this.CategoriaLibreta = pCategoriaLibreta;
            this.FechaVencimiento = pFechaVencimiento;
        }

        public Camionero()
        {
        }
    }
}
