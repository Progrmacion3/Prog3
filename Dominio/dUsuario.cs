using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Persistencia;

namespace Dominio
{
    class dUsuario
    {
        public static bool VerificarLogin(string usuario, string contraseña)
        {
            return PersistenciaUsuario.VerificarLogin(usuario, contraseña);
        }

        public static bool Alta(Usuario usuario)
        {
            PersistenciaUsuario.Alta(usuario;
        }
    }
}
