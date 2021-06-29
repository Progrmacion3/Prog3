using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Dominio
{
    public class Fachada
    {
        #region Metodos de Admin

        public static bool AdminAgregar(Common.Clases.Admin pAdmin)
        {
            return Dominio.Clases.Admin.AgregarAdmin(pAdmin);
        }

        public static bool AdminEliminar(Common.Clases.Admin pAdmin)
        {
            return Dominio.Clases.Admin.EliminarAdmin(pAdmin);
        }

        public static bool AdminModificar(Common.Clases.Admin pAdmin)
        {
            return Dominio.Clases.Admin.ModificarAdmin(pAdmin);
        }

        public static List<Common.Clases.Admin> MostrarAdmin()
        {
            return Dominio.Clases.Admin.MostrarAdmin();
        }
        public static Common.Clases.Admin MostrarAdminEspecifico(Common.Clases.Admin pAdmin)
        {
            return Dominio.Clases.Admin.MostrarAdminEspecifico(pAdmin);
        }
        public static Common.Clases.Admin ValidarAdmin(Common.Clases.Admin pAdmin)
        {
            return Dominio.Clases.Admin.ValidarAdmin(pAdmin);
        }
        #endregion
        #region Metodos de Camionero

        public static bool CamioneroAgregar(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.Camionero.AgregarCamionero(pCamionero);
        }

        public static bool CamioneroEliminar(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.Camionero.EliminarCamionero(pCamionero);
        }

        public static bool CamioneroModificar(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.Camionero.ModificarCamionero(pCamionero);
        }

        public static List<Common.Clases.Camionero> MostrarCamionero()
        {
            return Dominio.Clases.Camionero.MostrarCamionero();
        }
        public static Common.Clases.Camionero MostrarCamioneroEspecifico(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.Camionero.MostrarCamioneroEspecifico(pCamionero);
        }
        public static Common.Clases.Camionero MostrarCamioneroEspecifico2(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.Camionero.MostrarCamioneroEspecifico2(pCamionero);
        }
        #endregion
        #region Metodos de Empleado

        public static bool EmpleadoAgregar(Common.Clases.Empleado pEmpleado)
        {
            return Dominio.Clases.Empleado.AgregarEmpleado(pEmpleado);
        }

        public static bool EmpleadoEliminar(Common.Clases.Empleado pEmpleado)
        {
            return Dominio.Clases.Empleado.EliminarEmpleado(pEmpleado);
        }

        public static bool EmpleadoModificar(Common.Clases.Empleado pEmpleado)
        {
            return Dominio.Clases.Empleado.ModificarEmpleado(pEmpleado);
        }
        public static List<Common.Clases.Empleado> MostarEmpleadosActivos()
        {
            return Dominio.Clases.Empleado.MostrarEmpleadosActivos();
        }
        public static List<Common.Clases.Empleado> MostarEmpleadosEliminados()
        {
            return Dominio.Clases.Empleado.MostrarEmpleadosEliminados();
        }
        #endregion
        #region Metodos de Camion

        public static bool CamionAgregar(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.Camion.AgregarCamion(pCamion);
        }

        public static bool CamionEliminar(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.Camion.EliminarCamion(pCamion);
        }

        public static bool CamionModificar(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.Camion.ModificarCamion(pCamion);
        }
        public static List<Common.Clases.Camion> MostrarCamiones()
        {
            return Dominio.Clases.Camion.MostrarCamiones();
        }
        public static Common.Clases.Camion MostrarCamionEspecifico(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.Camion.MostrarCamionEspecifico(pCamion);
        }
        public static Common.Clases.Camion MostrarCamionEspecifico2(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.Camion.MostrarCamionEspecifico2(pCamion);
        }
        #endregion
        #region Metodos de Parada

        public static bool ParadaAgregar(Common.Clases.Parada pParada)
        {
            return Dominio.Clases.Parada.AgregarParada(pParada);
        }

        public static bool ParadaEliminar(Common.Clases.Parada pParada)
        {
            return Dominio.Clases.Parada.EliminarParada(pParada);
        }

        public static bool ParadaModificar(Common.Clases.Parada pParada)
        {
            return Dominio.Clases.Parada.ModificarParada(pParada);
        }
        public static List<Common.Clases.Parada> MostrarParadas()
        {
            return Dominio.Clases.Parada.MostrarParadas();
        }
        #endregion
        #region Metodos de Viaje

        public static bool ViajeAgregar(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.Viaje.AgregarViaje(pViaje);
        }

        public static bool ViajeEliminar(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.Viaje.EliminarViaje(pViaje);
        }

        public static bool ViajeModificar(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.Viaje.ModificarViaje(pViaje);
        }
        public static bool ViajeModificarCamionero(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.Viaje.ModificarViajeCamionero(pViaje);
        }
        public static List<Common.Clases.Viaje> MostrarViajes()
        {
            return Dominio.Clases.Viaje.MostrarViajes();
        }
        public static List<Common.Clases.Viaje> MostrarViajesMesActual()
        {
            return Dominio.Clases.Viaje.MostrarViajesMesActual();
        }
        public static List<Common.Clases.Viaje> MostrarViajesPorCamionero(int pCedula)
        {
            return Dominio.Clases.Viaje.MostrarViajesPorCamionero(pCedula);
        }
        public static List<Common.Clases.Viaje> MostrarViajesDelCamionero(string pUsuario)
        {
            return Dominio.Clases.Viaje.MostrarViajesDelCamionero(pUsuario);
        }
        public static Common.Clases.Viaje MostrarViajeEspecifico(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.Viaje.MostrarViajeEspecifico(pViaje);
        }
        #endregion

    }
}
