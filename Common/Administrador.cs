namespace Common
{
    public class Administrador : Usuario
    {
        public Administrador()
        {
        }

        public Administrador(int id, string nombre, string apellido, int cédula, string cargo, string teléfono, string usuarioLogin, string contraseña)
            : base(id, nombre, apellido, cédula, cargo, teléfono, usuarioLogin, contraseña)
        {
        }
    }
}
