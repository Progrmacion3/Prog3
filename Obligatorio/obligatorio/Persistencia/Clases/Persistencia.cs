using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace obligatorio.Persistencia.Clases
{
    public class Persistencia
    {
        protected static string CadenaDeConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[@"Server=localhost\SQLEXPRESS;Database=obligProgramacion;User Id=PABLOPC\pablo;"].ToString();      
            }
        }
    }
}