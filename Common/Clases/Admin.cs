using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Admin : Empleado
    {
        public Admin()
        {
        }


        //private int _idAdmin;
        //public int IdAdmin
        //{
        //    get { return _idAdmin; }
        //    set { _idAdmin = value; }
        //}

        public Admin(int pCedula, string pNombre, string pApellido, int pEdad, DateTime pFechaNacimiento, string pCargo, string pTelefono, string pUsuario, string pContraseña)
        :base(pCedula, pNombre, pApellido, pFechaNacimiento, pCargo, pTelefono, pUsuario, pContraseña)
        {
            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.Apellido = pNombre;
            this.Edad = pEdad;
            this.FechaNacimiento = pFechaNacimiento;
            this.Cargo = pCargo;
            this.Telefono = pTelefono;
            this.Usuario = pUsuario;
            this.Contraseña = pContraseña;
        }
    }
}
