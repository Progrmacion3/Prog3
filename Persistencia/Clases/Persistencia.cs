using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Persistencia.Clases
{
    public class Persistencia
    {
        protected static string CadenaDeConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["WindowsAuth"].ToString(); 
                //@"Server=WINDOWS-LHK6TF8\ESTEBANM;Database=Ejemplo;User Id=sa; password=@MartinezAnchen;";
            }
        }
    }
}
