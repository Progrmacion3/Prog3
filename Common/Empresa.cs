using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace obligatorio.Dominio
{
    public class Empresa
    {
        private List<Camionero> _listaCamioneros = new List<Camionero>();
        private List<Administrador> _listaAdmins = new List<Administrador>();
        private List<Camion> _listaCamiones = new List<Camion>();
        private List<Viaje> _listaViajes = new List<Viaje>();

        public List<Camionero> ListaCamioneros()
        {
            return _listaCamioneros;
        }
        public List<Administrador> ListaAdministradores()
        {
            return _listaAdmins;
        }
        public List<Camion> ListaCamiones()
        {
            return _listaCamiones;
        }
        public List<Viaje> ListaViajes()
        {
            return _listaViajes;
        }

        // to do -> los menus, switch con funcion y llamar a la clase con la funcion -> 24/6 done

        public bool MenuCamion(string pFuncion, Camion unCamion)
        {
            switch (pFuncion)
            {
                case "alta":
                    return new Camion().AltaCamion(unCamion);
                case "baja":
                    return new Camion().BajaCamion(unCamion);
                case "modificar":
                    return new Camion().ModificarCamion(unCamion);
                default:
                    return false;

            }
        }
        public bool MenuCamionero(string pFuncion, Empleado unCamionero)
        {
            switch (pFuncion)
            {
                case "alta":
                    return new Camionero().AltaCamionero(unCamionero);
                case "baja":
                    return new Camionero().BajaCamionero(unCamionero);
                case "modificar":
                    return new Camionero().ModificarCamionero(unCamionero);
                default:
                    return false;
            }
        }
        public bool MenuAdmin(string pFuncion, Administrador unAdmin)
        {
            switch (pFuncion)
            {
                case "alta":
                    return new Administrador().AltaAdmin(unAdmin);
                case "baja":
                    return new Administrador().BajaAdmin(unAdmin);
                case "modificar":
                    return new Administrador().ModificarAdmin(unAdmin);
                default:
                    return false;
            }
        }
        public bool MenuViaje(string pFuncion, Viaje unViaje)
        {
            switch (pFuncion)
            {
                case "alta":
                    return new Viaje().AltaViaje(unViaje);
                case "baja":
                    return new Viaje().BajaViaje(unViaje);
                case "modificar":
                    return new Viaje().ModificarViaje(unViaje);
                default:
                    return false;
            }
        }

        public Camion BuscarCamion(Camion unCamion)
        {
            return new Camion().BuscarCamion(unCamion);
        }
        public Empleado BuscarCamionero(Empleado unCamionero)
        {
            return new Camionero().BuscarCamionero(unCamionero);
        }
        public Administrador BuscarAdministrador(Administrador unAdmin)
        {
            return new Administrador().BuscarAdmin(unAdmin);
        }
        public Viaje BuscarViaje(Viaje unViaje)
        {
            return new Viaje().BuscarViaje(unViaje);
        }
    }
}