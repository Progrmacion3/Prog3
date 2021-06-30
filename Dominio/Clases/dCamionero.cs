using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dCamionero
    {
        public static bool Agregar_Camionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.AgregarCamionero(pCamionero);
        }

        public static bool Eliminar_Camionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.EliminarCamionero(pCamionero);
        }

        public static bool Modificar_Camionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.ModificarCamionero(pCamionero);
        }

        public static List<Common.Clases.Camionero> Traer_Camioneros()
        {
            return Persistencia.Clases.pCamionero.TraerTodosLosCamioneros();
        }

        public static Common.Clases.Camionero Traer_UnCamionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.TraerUnCamioneroEnEspecifico(pCamionero);
        }
    }
}