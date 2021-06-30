using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dCamion
    {
        public static bool Agregar_Camion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.AgregarCamion(pCamion);
        }

        public static bool Eliminar_Camion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.EliminarCamion(pCamion);
        }

        public static bool Modificar_Camion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.ModificarCamion(pCamion);
        }

        public static List<Common.Clases.Camion> Traer_Camiones()
        {
            return Persistencia.Clases.pCamion.TraerTodosLosCamiones();
        }    

        public static Common.Clases.Camion Traer_UnCamion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.TraerUnCamionEnEspecifico(pCamion);
        }
    }
}
