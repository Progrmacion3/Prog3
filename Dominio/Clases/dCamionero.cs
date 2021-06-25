using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dCamionero
    {
        public static bool AltaCamionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.AltaCamionero(pCamionero);
        }
        public static bool BajaCamionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.BajaCamionero(pCamionero);
        }
        public static bool ModificarCamionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.ModificarCamionero(pCamionero);
        }
        public static List<Common.Clases.Camionero> ListarCamioneros()
        {
            return Persistencia.Clases.pCamionero.ListarCamioneros();
        }
        public static Common.Clases.Camionero TraerCamionero(Common.Clases.Camionero pCamionero)
        {
            return Persistencia.Clases.pCamionero.TraerCamionero(pCamionero);
        }
    }
}
