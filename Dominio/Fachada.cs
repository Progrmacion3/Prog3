﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Fachada
    {
        #region ABMViaje
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
        #endregion

        #region ABMCamion
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
        #endregion

        #region ABMCamionero
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
        #endregion

        #region ABMEmpleado
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
        #endregion

        #region ABMParada
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
        #endregion
    }
}
