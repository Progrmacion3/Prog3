using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    class dCamion
    {

        public static bool Agregar_Camion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.AgregarCamion(pCamion);
        }
        public static bool Modificar_Camion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.ModificarCamion(pCamion);
        }

        public static List<Common.Clases.Camion> TraerCamion()
        {
            return Persistencia.Clases.pCamion.TraerTodosLosCamiones();
        }
        
        public static Common.Clases.Camion TraerEspecifico(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.TraerEspecifico(pCamion);
        }

        public static bool EliminarCamion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.EliminarCamion(pCamion);
        }
    }
}
