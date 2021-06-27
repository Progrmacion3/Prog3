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
                return ConfigurationManager.ConnectionStrings["SqlServerAuth"].ToString();
                //@"Server=WINDOWS-LHK6TF8\ESTEBANM;Database=obligProgramacion;User Id=sa; password=@MartinezAnchen;";
            }
        }
    }
}