using System.Configuration;

namespace Persistencia
{
    public abstract class Persistencia
    {
        protected static string CadenaDeConexion
        {
            get { return ConfigurationManager.ConnectionStrings["WindowsAuth"].ToString(); }
        }
    }
}
