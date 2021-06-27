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

        #endregion

    }
}
