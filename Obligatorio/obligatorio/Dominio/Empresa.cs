using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using obligatorio.Persistencia.Clases;

namespace obligatorio.Dominio
{
    public class Empresa
    {
        private static List<Camionero> _listaCamioneros = new List<Camionero>();
        private static List<Administrador> _listaAdmins = new List<Administrador>();
        private static List<Camion> _listaCamiones = new List<Camion>();
        private static List<Viaje> _listaViajes = new List<Viaje>();

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
            return _listaCamiones = pCamion.pListaCamiones();
        }
        public List<Viaje> ListaViajes()
        {
            return _listaViajes;
        }

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
        public bool MenuCamionero(string pFuncion, Camionero unCamionero)
        {
            switch (pFuncion)
            {
                case "alta":
                    if (new Camionero().AltaCamionero(unCamionero))
                    {
                        _listaCamioneros.Add(unCamionero);
                        return true;
                    }
                    return false;

                    
                case "baja":
                    if (new Camionero().BajaCamionero(unCamionero))
                    {
                        _listaCamioneros.Remove(unCamionero);
                        return true;
                    }
                    return false;
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
        public Camionero BuscarCamionero(Camionero unCamionero)
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