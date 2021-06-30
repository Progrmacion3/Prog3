using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class dParada
    {
        public static bool Agregar_Parada(Common.Clases.Parada pPar)
        {
            return Persistencia.Clases.pParada.AgregarParada(pPar);
        }

        public static bool Eliminar_Parada(Common.Clases.Parada pPar)
        {
            return Persistencia.Clases.pParada.EliminarParada(pPar);
        }

        public static bool Modificar_Parada(Common.Clases.Parada pPar)
        {
            return Persistencia.Clases.pParada.ModificarParada(pPar);
        }

        public static List<Common.Clases.Parada> Traer_Paradas()
        {
            return Persistencia.Clases.pParada.TraerTodasLasParadas();
        }
    }
}

