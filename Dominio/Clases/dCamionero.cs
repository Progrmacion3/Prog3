
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Persistencia;

namespace Dominio.Clases

{
    class dCamionero
    {


        public static bool Agregar_Camionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.AgregarCamionero(pCamionero);
        }
        public static bool Modificar_Camionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.ModificarEmpleado(pCamionero);
        }

        public static List<Common.Clases.Camionero> TraerCamionero()
        {
            return Persistencia.Clases.pCamionero.TraerTodosLosCamioneros();
        }
        public static Common.Clases.Camionero TraerEspecifico(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.TraerEspecifico(pCamionero);
        }

        public static bool EliminarCamionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.EliminarCamionero(pCamionero);
        }
    }
}




