using Common;
using Persistencia;
using System.Collections.Generic;

namespace Dominio
{
    class DominioCiudad
    {
        public static bool Listar(List<Ciudad> lista)
        {
            return PersistenciaCiudad.Listar(lista);
        }

        public static bool Obtener(Ciudad ciudad)
        {
            return PersistenciaCiudad.Obtener(ciudad);
        }
    }
}
