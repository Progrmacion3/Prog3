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
        private static List<Parada> _listaParadas = new List<Parada>();

        public List<Camionero> ListaCamioneros()
        {
            return _listaCamioneros = pCamionero.pListaCamioneros();
        }
        public List<Administrador> ListaAdministradores()
        {
            return _listaAdmins = pAdministrador.pListaAdmins();
        }
        public List<Camion> ListaCamiones()
        {
            return _listaCamiones = pCamion.pListaCamiones();
        }
        public List<Viaje> ListaViajes()
        {
            return _listaViajes = pViaje.pListaViajes();
        }
        public List<Parada> ListaParadas()
        {
            return _listaParadas;
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
        public bool MenuParada(string pFuncion, Parada pParada)
        {
            switch (pFuncion)
            {
                case "alta":
                    return new Parada().AgregarParada(pParada);
                case "baja":
                    return new Parada().EliminarParada(pParada);
                case "modificar":
                    return new Parada().ModificarParada(pParada);
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
        public Parada BuscarParada(Parada unaParada)
        {
            return new Parada().BuscarParada(unaParada);
        }
    }

    ////////////////////////////////////////Consultas////////////////////////////////////////

    //public List<Consultas> listaViajeCamionero(string pCi)
    //{
    //    foreach (Consultas unaConsulta in _listaConsultas)
    //    {

    //    }
    //}

    //    public List<Consulta> listaFecha(string pFecha, string pTipo)g        
    //    {
    //        List<Consulta> listaMascConsultadas = new List<Consulta>();
    //        foreach (Consulta unaConsulta in _listaConsultas)
    //        {
    //            if (unaConsulta.Fecha == pFecha && unaConsulta.unaMascota.Tipo == pTipo)
    //            {
    //                listaMascConsultadas.Add(unaConsulta);

    //            }
    //        }
    //        List<Consulta> ordenadaPorNombre = this.ordenoPerrosConsulta(listaMascConsultadas);
    //        return ordenadaPorNombre;
    //    }
}