using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Fachada
    {
        #region Viaje
        public static bool Agregar_Viaje(Common.Clases.Viaje pVia)
        {
            return Dominio.Clases.dViaje.Agregar_Viaje(pVia);
        }

        public static bool Eliminar_Viaje(Common.Clases.Viaje pVia)
        {
            return Dominio.Clases.dViaje.Eliminar_Viaje(pVia);
        }

        public static bool Modificar_Viaje(Common.Clases.Viaje pVia)
        {
            return Dominio.Clases.dViaje.Modificar_Viaje(pVia);
        }

        public static List<Common.Clases.Viaje> Traer_Viaje()
        {
            return Dominio.Clases.dViaje.Traer_Viaje();
        }

        public static Common.Clases.Viaje Traer_UnViaje(Common.Clases.Viaje pVia)
        {
            return Dominio.Clases.dViaje.Traer_UnViaje(pVia);
        }
        #endregion

        #region Camion
        public static bool Agregar_Camion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.Agregar_Camion(pCamion);
        }

        public static bool Eliminar_Camion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.Eliminar_Camion(pCamion);
        }

        public static bool Modificar_Camion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.Modificar_Camion(pCamion);
        }

        public static List<Common.Clases.Camion> Traer_Camiones()
        {
            return Dominio.Clases.dCamion.Traer_Camiones();
        }

        public static Common.Clases.Camion Traer_UnCamion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.Traer_UnCamion(pCamion);
        }
        #endregion

        #region Camionero
        public static bool Agregar_Camionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.Agregar_Camionero(pCamionero);
        }

        public static bool Eliminar_Camionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.Eliminar_Camionero(pCamionero);
        }

        public static bool Modificar_Camionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.Modificar_Camionero(pCamionero);
        }

        public static List<Common.Clases.Camionero> Traer_Camioneros()
        {
            return Dominio.Clases.dCamionero.Traer_Camioneros();
        }

        public static Common.Clases.Camionero Traer_UnCamionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.Traer_UnCamionero(pCamionero);
        }
        #endregion

        #region Empleado
        public static bool Agregar_Empleado(Common.Clases.Empleado pEmp)
        {
            return Dominio.Clases.dEmpleado.Agregar_Empleado(pEmp);
        }

        public static bool Eliminar_Empleado(Common.Clases.Empleado pEmp)
        {
            return Dominio.Clases.dEmpleado.Eliminar_Empleado(pEmp);
        }

        public static bool Modificar_Empleado(Common.Clases.Empleado pEmp)
        {
            return Dominio.Clases.dEmpleado.Modificar_Empleado(pEmp);
        }

        public static List<Common.Clases.Empleado> Traer_Empleados()
        {
            return Dominio.Clases.dEmpleado.Traer_Empleados();
        }

        public static Common.Clases.Empleado Traer_UnEmpleado(Common.Clases.Empleado pEmp)
        {
            return Dominio.Clases.dEmpleado.Traer_UnEmpleado(pEmp);
        }

        public static Common.Clases.Empleado Revisar_Usuario_Contraseña(Common.Clases.Empleado pEmp)
        {
            return Dominio.Clases.dEmpleado.Revisar_Usuario_Contraseña(pEmp);
        }
        #endregion

        #region Parada
        public static bool Agregar_Parada(Common.Clases.Parada pPar)
        {
            return Dominio.Clases.dParada.Agregar_Parada(pPar);
        }

        public static bool Eliminar_Parada(Common.Clases.Parada pPar)
        {
            return Dominio.Clases.dParada.Eliminar_Parada(pPar);
        }

        public static bool Modificar_Parada(Common.Clases.Parada pPar)
        {
            return Dominio.Clases.dParada.Modificar_Parada(pPar);
        }

        public static List<Common.Clases.Parada> Traer_Paradas()
        {
            return Dominio.Clases.dParada.Traer_Paradas();
        }

        public static Common.Clases.Parada Traer_UnaParada(Common.Clases.Parada pPar)
        {
            return Dominio.Clases.dParada.Traer_UnaParada(pPar);
        }
        #endregion
    }
}
