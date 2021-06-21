using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dCamion
    {
        public static bool AltaCamion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.AltaCamion(pCamion);
        }
        public static bool BajaCamion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.BajaCamion(pCamion);
        }
        public static bool ModificarCamion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.ModificarCamion(pCamion);
        }
        public static List<Common.Clases.Camion> ListarCamiones()
        {
            return Persistencia.Clases.pCamion.ListarCamiones();
        }
        public static Common.Clases.Camion TraerCamion(Common.Clases.Camion pCamion)
        {
            return Persistencia.Clases.pCamion.TraerCamion(pCamion);
        }

    }
}
