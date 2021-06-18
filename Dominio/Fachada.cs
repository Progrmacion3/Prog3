using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Fachada
    {
        #region Métodos de Usuario

        public static bool VerificarLogin(string usuario, string contraseña)
        {
            return dUsuario.VerificarLogin(usuario, contraseña);
        }

        public static bool AltaUsuario(Usuario usuario)
        {
            return dUsuario.Alta(usuario);
        }

        #endregion

        #region Metodos de Categoria

        public static bool Categoria_Agregar(Common.Clases.Categoria pCategoria)
        {
            return Dominio.Clases.Categoria.Agregar(pCategoria);
        }

        public static List<Common.Clases.Categoria> Cateogoria_TraerTodas()
        {
            return Dominio.Clases.Categoria.TraerTodas();
        }

        public static bool Categoria_Eliminar(Common.Clases.Categoria pCategoria)
        {
            return Dominio.Clases.Categoria.Eliminar(pCategoria);
        }

        public static Common.Clases.Categoria Cateogoria_TraerEspecifica(Common.Clases.Categoria pCategoria)
        {
            return Dominio.Clases.Categoria.TraerEspecifica(pCategoria);
        }

        public static bool Categoria_Modificar(Common.Clases.Categoria pCategoria)
        {
            return Dominio.Clases.Categoria.Modificar(pCategoria);
        }

        #endregion
    }
}
