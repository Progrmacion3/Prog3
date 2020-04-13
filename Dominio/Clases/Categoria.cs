using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Clases
{
    public class Categoria
    {
        public static bool Agregar(Common.Clases.Categoria pCategoria) 
        {
            return Persistencia.Clases.Categoria.Agregar(pCategoria);
        }

        public static List<Common.Clases.Categoria> TraerTodas()
        {
            return Persistencia.Clases.Categoria.TraerTodas();
        }

        public static bool Eliminar(Common.Clases.Categoria pCategoria)
        {
            return Persistencia.Clases.Categoria.Eliminar(pCategoria);
        }

        public static Common.Clases.Categoria TraerEspecifica(Common.Clases.Categoria pCategoria)
        {
            return Persistencia.Clases.Categoria.TraerEspecifica(pCategoria);
        }

        public static bool Modificar(Common.Clases.Categoria pCategoria)
        {
            return Persistencia.Clases.Categoria.Modificar(pCategoria);
        }
    }
}
