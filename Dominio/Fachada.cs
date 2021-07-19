using Common.Clases;
using Dominio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Fachada
    {
      

   

        #region Metodos de Empleado
        public static List<Common.Clases.Empleado> Empleados_TraerTodos()
        {
            return Dominio.Clases.dEmpleado.TraerEmpleados();
        }

        public static Common.Clases.Empleado Empleados_TraerEspecifico(Common.Clases.Empleado pEmpleado)
        {
            return Dominio.Clases.dEmpleado.TraerEspecifico(pEmpleado);
        }
        public static bool Agregar_Empleado(Empleado pEmpleado)
        {
            return dEmpleado.Agregar_Empleado(pEmpleado);
        }
        public static bool EliminarEmpleado(Common.Clases.Empleado pEmpleado)
        {
            return Dominio.Clases.dEmpleado.EliminarEmpleado(pEmpleado);
        }
        public static bool ModificarEmpleado(Common.Clases.Empleado pEmpleado)
        {
            return Dominio.Clases.dEmpleado.Modificar_Empleado(pEmpleado);
        }
        #endregion

        #region Metodos de Viajes

        public static bool Agregar_Viajes(Viaje pViaje)
        {
            return dViaje.Agregar_Viajes(pViaje);
        }
         public static List<Common.Clases.Viaje> Viaje_TraerTodosLosViajes()
          {
              return Dominio.Clases.dViaje.TraerViajes();
          }
        
         public static Common.Clases.Viaje Cliente_TraerEspecifico(Common.Clases.Viaje pViaje)
         {
             return Dominio.Clases.dViaje.TraerEspecifico(pViaje);
         }
         
        public static bool EliminarViajes(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.dViaje.EliminarViajes(pViaje);
        }
        public static bool ModificarViajes(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.dViaje.Modificar_Viajes(pViaje);
        }
        #endregion



        #region Metodos de Camion

        public static bool Agregar_Camion(Camion pCamion)
        {
            return dCamion.Agregar_Camion(pCamion);
        }
         public static List<Common.Clases.Camion> Camione_TraerTodosLosCamiones()
          {
              return Dominio.Clases.dCamion.TraerCamion();
          }
        
         public static Common.Clases.Camion Camion_TraerEspecifico(Common.Clases.Camion pCamion)
         {
             return Dominio.Clases.dCamion.TraerEspecifico(pCamion);
         }
         
        public static bool EliminarCamion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.EliminarCamion(pCamion);
        }
        public static bool ModificarCamion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.Modificar_Camion(pCamion);
        }
        #endregion




        #region Metodos de Camionero

        public static bool Agregar_Camionero(Camionero pCamionero)
        {
            return dCamionero.Agregar_Camionero(pCamionero);
        }
          public static List<Common.Clases.Camionero> Camionero_TraerTodosLosCamioneros()
          {
              return Dominio.Clases.dCamionero.TraerCamionero();
          }
        
         public static Common.Clases.Camionero Camionero_TraerEspecifico(Common.Clases.Camionero pCamionero)
         {
             return Dominio.Clases.dCamionero.TraerEspecifico(pCamionero);
         }
         
        public static bool EliminarCamionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.EliminarCamionero(pCamionero);
        }
        public static bool ModificarCamionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.Modificar_Camionero(pCamionero);
        }
        #endregion

    }
}
