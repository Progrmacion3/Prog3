namespace Common
{
    public class Ciudad : Base
    {
        public string Nombre { get; set; }

        public Ciudad(int id) : base(id)
        {
        }

        public Ciudad(int id, string nombre) : base(id)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
