using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace obligatorio.Persistencia.Clases
{
    public class Persistencia
    {
        public static string CadenaDeConexion
        {
            get
            {
                return @"data source=localhost\SQLEXPRESS;Initial Catalog=ObligatorioProgramacion3;Integrated Security=SSPI";   
            }
        }
    }
}