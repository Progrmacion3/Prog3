using Common.Clases;
using Dominio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Fachada
    {

        #region Metodos de Categoria

        public static bool Categoria_Agregar(Common.Clases.Categoria pCategoria)
        {
            return Dominio.Clases.Categoria.Agregar(pCategoria);
        }

        public static List<Common.Clases.Categoria> Cateogoria_TraerTodas()
        {
            return Dominio.Clases.Categoria.Traer777Todas();
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

        #region Metodos de Cliente

        public static bool Agregar_cliente(Cliente pCliente)
        {
            return dCliente.Agregar_Cliente(pCliente);
        }
        public static List<Common.Clases.Cliente> Cliente_TraerTodosLosClientes()
        {
            return Dominio.Clases.dCliente.TraerClientes();
        }

        public static Common.Clases.Cliente Cliente_TraerEspecifico(Common.Clases.Cliente pCliente)
        {
            return Dominio.Clases.dCliente.TraerEspecifico(pCliente);
        }
        public static bool EliminarCliente(Common.Clases.Cliente pCliente)
        {
            return Dominio.Clases.dCliente.EliminarCliente(pCliente);
        }
        public static bool ModificarCliente(Common.Clases.Cliente pCliente)
        {
            return Dominio.Clases.dCliente.Modificar_Cliente(pCliente);
        }
        #endregion
    }
}
