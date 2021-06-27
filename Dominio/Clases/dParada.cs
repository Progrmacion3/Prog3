using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dParada
    {
        public static bool AltaParada(Common.Clases.Parada pParada)
        {
            return Persistencia.Clases.pParada.AltaParada(pParada);
        }
        public static bool BajaParada(Common.Clases.Parada pParada)
        {
            return Persistencia.Clases.pParada.BajaParada(pParada);
        }
       public static List<Common.Clases.Parada> ListarParadas()
        {
            return Persistencia.Clases.pParada.ListarParadas();
        }
        public static Common.Clases.Parada TraerParada(Common.Clases.Parada pParada)
        {
            return Persistencia.Clases.pParada.TraerParada(pParada);
        }


    }
}
