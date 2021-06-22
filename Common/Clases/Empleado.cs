using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Clases
{
    public class Empleado
    {
        //private int _idEmpleado;
        private int _cedula;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private string _cargo;
        private string _telefono;
        private string _usuario;
        private string _contraseña;

        
        //public int IdEmpleado
        //{
        //    get { return _idEmpleado; }
        //    set { _idEmpleado = value; }
        //}    
        public int Cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }


        public Empleado(int pCedula, string pNombre, string pApellido, DateTime pFechaNacimiento, string pCargo, string pTelefono, string pUsuario, string pContraseña)
        {
            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.Apellido = pNombre;
            this.FechaNacimiento = pFechaNacimiento;
            this.Cargo = pCargo;
            this.Telefono = pTelefono;
            this.Usuario = pUsuario;
            this.Contraseña = pContraseña;
        }
    }
}
