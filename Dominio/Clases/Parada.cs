using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class Parada
    {
        public static bool AgregarParada(Common.Clases.Parada pParada)
        {
            return Persistencia.Clases.Parada.AgregarParada(pParada);
        }
        public static bool EliminarParada(Common.Clases.Parada pParada)
        {
            return Persistencia.Clases.Parada.EliminarParada(pParada);
        }
        public static bool ModificarParada(Common.Clases.Parada pParada)
        {
            return Persistencia.Clases.Parada.ModificarParada(pParada);
        }
        public static List <Common.Clases.Parada> MostrarParadas()
        {
            return Persistencia.Clases.Parada.MostrarParadas();
        }
        public static string MostrarRotura(int pId, string pUsuario)
        {
            return Persistencia.Clases.Parada.MostrarRotura(pId, pUsuario);
        }
        public static List<Common.Clases.Parada> MostrarEstadoRoturas(int pIdViaje, string pUsuario)
        {
            return Persistencia.Clases.Parada.MostrarEstadoRotura(pIdViaje, pUsuario);
        }
    }
}
