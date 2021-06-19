using Common;
using Persistencia;
using System.Collections.Generic;

namespace Dominio
{
    class DominioCamionero : DominioUsuario
    {
        public static bool Alta(Camionero camionero)
        {
            return PersistenciaCamionero.Alta(camionero);
        }

        public static bool Modificar(Camionero camionero)
        {
            return PersistenciaCamionero.Modificar(camionero);
        }

        public static bool Listar(List<Camionero> lista)
        {
            return PersistenciaCamionero.Listar(lista);
        }

        public static bool Obtener(Camionero camionero)
        {
            return PersistenciaCamionero.Obtener(camionero);
        }
    }
}
