using Common;
using Persistencia;
using System.Collections.Generic;

namespace Dominio
{
    class DominioCamión
    {
        public static bool Alta(Camión camión)
        {
            return PersistenciaCamión.Alta(camión);
        }

        public static bool Baja(Camión camión)
        {
            return PersistenciaCamión.Baja(camión);
        }

        public static bool Modificar(Camión camión)
        {
            return PersistenciaCamión.Modificar(camión);
        }

        public static bool Listar(List<Camión> lista)
        {
            return PersistenciaCamión.Listar(lista);
        }

        public static bool Obtener(Camión camión)
        {
            return PersistenciaCamión.Obtener(camión);
        }
    }
}
