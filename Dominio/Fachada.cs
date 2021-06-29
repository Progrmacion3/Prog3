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

        #region Metodos de Empleado

        public static bool Agregar_Empleado(Empleado pEmpleado)
        {
            return dEmpleado.Agregar_Empleado(pEmpleado);
        }
        /*  public static List<Common.Clases.Cliente> Empleado_TraerTodosLosClientes()
          {
              return Dominio.Clases.dCliente.TraerClientes();
          }
        */
        /* public static Common.Clases.Cliente Cliente_TraerEspecifico(Common.Clases.Cliente pCliente)
         {
             return Dominio.Clases.dCliente.TraerEspecifico(pCliente);
         }
         */
        public static bool EliminarEmpleado(Common.Clases.Empleado pEmpleado)
        {
            return Dominio.Clases.dEmpleado.EliminarEmpleado(pEmpleado);
        }
        public static bool ModificarEmpleado(Common.Clases.Empleado pEmpleado)
        {
            return Dominio.Clases.dEmpleado.Modificar_Empleado(pEmpleado);
        }
        #endregion

        #region Metodos de Viajes

        public static bool Agregar_Viajes(Viaje pViaje)
        {
            return dViaje.Agregar_Viajes(pViaje);
        }
        /*  public static List<Common.Clases.Cliente> Empleado_TraerTodosLosClientes()
          {
              return Dominio.Clases.dCliente.TraerClientes();
          }
        */
        /* public static Common.Clases.Cliente Cliente_TraerEspecifico(Common.Clases.Cliente pCliente)
         {
             return Dominio.Clases.dCliente.TraerEspecifico(pCliente);
         }
         */
        public static bool EliminarViajes(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.dViaje.EliminarViajes(pViaje);
        }
        public static bool ModificarViajes(Common.Clases.Viaje pViaje)
        {
            return Dominio.Clases.dViaje.Modificar_Viajes(pViaje);
        }
        #endregion





        #region Metodos de Camion

        public static bool Agregar_Camion(Camion pCamion)
        {
            return dCamion.Agregar_Camion(pCamion);
        }
        /*  public static List<Common.Clases.Cliente> Empleado_TraerTodosLosClientes()
          {
              return Dominio.Clases.dCliente.TraerClientes();
          }
        */
        /* public static Common.Clases.Cliente Cliente_TraerEspecifico(Common.Clases.Cliente pCliente)
         {
             return Dominio.Clases.dCliente.TraerEspecifico(pCliente);
         }
         */
        public static bool EliminarCamion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.EliminarCamion(pCamion);
        }
        public static bool ModificarCamion(Common.Clases.Camion pCamion)
        {
            return Dominio.Clases.dCamion.Modificar_Camion(pCamion);
        }
        #endregion




        #region Metodos de Camionero

        public static bool Agregar_Camionero(Camionero pCamionero)
        {
            return dCamionero.Agregar_Camionero(pCamionero);
        }
        /*  public static List<Common.Clases.Cliente> Empleado_TraerTodosLosClientes()
          {
              return Dominio.Clases.dCliente.TraerClientes();
          }
        */
        /* public static Common.Clases.Cliente Cliente_TraerEspecifico(Common.Clases.Cliente pCliente)
         {
             return Dominio.Clases.dCliente.TraerEspecifico(pCliente);
         }
         */
        public static bool EliminarCamionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.EliminarCamionero(pCamionero);
        }
        public static bool ModificarCamionero(Common.Clases.Camionero pCamionero)
        {
            return Dominio.Clases.dCamionero.Modificar_Camionero(pCamionero);
        }
        #endregion

    }
}
