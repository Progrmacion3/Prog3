using Common;
using Persistencia;
using System.Collections.Generic;

namespace Dominio
{
    class DominioAdministrador : DominioUsuario
    {
        public static bool Alta(Administrador administrador)
        {
            return PersistenciaAdministrador.Alta(administrador);
        }

        public static bool Modificar(Administrador administrador)
        {
            return PersistenciaAdministrador.Modificar(administrador);
        }

        public static bool Listar(List<Administrador> lista)
        {
            return PersistenciaAdministrador.Listar(lista);
        }

        public static bool Obtener(Administrador administrador)
        {
            return PersistenciaAdministrador.Obtener(administrador);
        }
    }
}
