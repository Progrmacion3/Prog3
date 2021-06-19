using Common;
using Persistencia;

namespace Dominio
{
    class DominioUsuario
    {
        public static bool Ingresar(Usuario usuario, out bool correcto, out char tipo)
        {
            return PersistenciaUsuario.Ingresar(usuario, out correcto, out tipo);
        }

        public static bool Baja(Usuario usuario)
        {
            return PersistenciaUsuario.Baja(usuario);
        }

        public static bool Obtener(Usuario usuario)
        {
            return PersistenciaUsuario.Obtener(usuario);
        }
    }
}
