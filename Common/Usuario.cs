namespace Common
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Cédula { get; set; }

        public string Cargo { get; set; }

        public string Teléfono { get; set; }

        public string UsuarioLogin { get; set; }

        public string Contraseña { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id)
        {
            Id = id;
        }

        public Usuario(string usuario, string contraseña)
        {
            UsuarioLogin = usuario;
            Contraseña = contraseña;
        }

        public Usuario(int id, string nombre, string apellido, int cédula, string cargo, string teléfono, string usuarioLogin, string contraseña)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Cédula = cédula;
            Cargo = cargo;
            Teléfono = teléfono;
            UsuarioLogin = usuarioLogin;
            Contraseña = contraseña;
        }
    }
}
