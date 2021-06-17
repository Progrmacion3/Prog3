namespace Common
{
    public class Ciudad
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Ciudad()
        {
        }

        public Ciudad(string nombre)
        {
            Nombre = nombre;
        }

        public Ciudad(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
