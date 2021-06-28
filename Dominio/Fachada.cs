using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Fachada
    {
        #region Camiones
        public static bool AltaCamion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.AltaCamion(pCamion);
        }
        public static bool BajaCamion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.BajaCamion(pCamion);
        }
        public static bool ModificarCamion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.ModificarCamion(pCamion);
        }
        public static List<Common.Clases.Camion> ListarCamiones()
        {
            return Dominio.Clases.dCamion.ListarCamiones();
        }
        public static Common.Clases.Camion TraerCamion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.TraerCamion(pCamion);
        }
        #endregion

        #region Camioneros
        public static bool AltaCamionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.AltaCamionero(pCamionero);
        }
        public static bool BajaCamionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.BajaCamionero(pCamionero);
        }
        public static bool ModificarCamionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.ModificarCamionero(pCamionero);
        }
        public static List<Common.Clases.Camionero> ListarCamioneros()
        {
            return Dominio.Clases.dCamionero.ListarCamioneros();
        }
        public static Common.Clases.Camionero TraerCamionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.TraerCamionero(pCamionero);
        }
        #endregion

        #region Administrador
        public static bool AltaAdministrador(Common.Clases.Administrador pAdministrador)
        {
            return Dominio.Clases.dAdministrador.AltaAdministrador(pAdministrador);
        }
        public static bool BajaAdministrador(Common.Clases.Administrador pAdministrador)
        {
            return Dominio.Clases.dAdministrador.BajaAdministrador(pAdministrador);
        }
        public static bool ModificarAdministrador(Common.Clases.Administrador pAdministrador)
        {
            return Dominio.Clases.dAdministrador.ModificarAdministrador(pAdministrador);
        }
        public static List<Common.Clases.Administrador> ListarAdministradores()
        {
            return Dominio.Clases.dAdministrador.ListarAdministradores();
        }
        public static Common.Clases.Administrador TraerAdministrador(Common.Clases.Administrador pAdministrador)
        {
            return Dominio.Clases.dAdministrador.TraerAdministrador(pAdministrador);
        }
        #endregion

        #region Parada
        public static bool AltaParada(Common.Clases.Parada pParada)
        {
            return Dominio.Clases.dParada.AltaParada(pParada);
        }
        public static bool BajaParada(Common.Clases.Parada pParada)
        {
            return Dominio.Clases.dParada.BajaParada(pParada);
        }
        public static List<Common.Clases.Parada> ListarParadas()
        {
            return Dominio.Clases.dParada.ListarParadas();
        }
        public static Common.Clases.Parada TraerParada(Common.Clases.Parada pParada)
        {
            return Dominio.Clases.dParada.TraerParada(pParada);
        }
        #endregion

        #region Viaje
        public static bool AltaViaje(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.dViaje.AltaViaje(pViaje);
        }
        public static bool BajaViaje(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.dViaje.BajaViaje(pViaje);
        }
        public static bool ModificarViaje(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.dViaje.ModificarViaje(pViaje);
        }
        public static List<Common.Clases.Viaje> ListarViajes()
        {
            return Dominio.Clases.dViaje.ListarViajes();
        }
        public static Common.Clases.Viaje TraerViaje(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.dViaje.TraerViaje(pViaje);
        }

        #endregion

        #region Utilidades

        public static string TraerTipoEmpleado(Common.Clases.Empleado pEmpleado)
        {
            return Dominio.Clases.dUtilidades.TraerTipoEmpleado(pEmpleado);
        }

        #endregion
    }
}
