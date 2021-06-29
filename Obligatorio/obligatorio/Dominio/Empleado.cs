using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace obligatorio.Dominio
{
    public class Empleado
    {
        private int _id;
        private string _apellido;
        private string _nombre;
        private string _cedula;
        private string _cargo;
        private string _telefono;
        private string _usuario;
        private string _contrasena;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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
        public string Cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
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
        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }


        public Empleado(int pId, string pNombre, string pApellido, string pCedula, string pCargo, string pTelefono, string pUsuario, string pContrasena)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            Cedula = pCedula;
            Cargo = pCargo;
            Telefono = pTelefono;
            Usuario = pUsuario;
            Contrasena = pContrasena;
        }
        public Empleado(string pNombre, string pApellido, string pCedula, string pCargo, string pTelefono, string pUsuario, string pContrasena)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Cedula = pCedula;
            Cargo = pCargo;
            Telefono = pTelefono;
            Usuario = pUsuario;
            Contrasena = pContrasena;
        }
        public Empleado(int pid)
        {
            Id = pid;
        }
        public Empleado()
        {

        }
    }
}